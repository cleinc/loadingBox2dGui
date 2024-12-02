using CoPick.Logging;
using CoPick.Plc;
using CoPick.Setting;
using CoPick.Robot;
using loadingBox2dGui.models;
using loadingBox2dGui.views;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoPick;
using System.Diagnostics;
using System.IO;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;
using System.Drawing;
using System.Drawing.Imaging;
using System.Security.AccessControl;

namespace loadingBox2dGui.presenters
{
    public class MainPresenter
    {
        private static readonly LogHelper Logger = LogHelper.Logger;
        
        private readonly IMainForm _view;
        private Config _config;
        private OperationMode _mode;
        private PlcCommunicatorForLoadingBox _plcComm;
        private LightCommunicatorForLoadingBox _lightComm;
        private PylonCameraCommunicator.PylonCameraCommunicator _cameraComm;
        private readonly ICargoBox2DInspectionEngine _engine;
        private IRobotCommunicator _robotComm;
        private bool _isPlcEventHandlersRegistered = false;
        private bool _isRunningCamera = false;
        private bool _isConnectingCamera = false; 
        private readonly CargoBox2DSettingManagerPresenter _settingManagerPresenter;
        private Dictionary<string, Dictionary<InspectionLocation, bool>> _modifiedCameraBundleDict = new Dictionary<string, Dictionary<InspectionLocation, bool>>();
        private ConcurrentDictionary<string, ConcurrentDictionary<InspectionLocation, CameraParameter>> _cameraParameterDict = new ConcurrentDictionary<string, ConcurrentDictionary<InspectionLocation, CameraParameter>>();
        private readonly SemaphoreSlim _cameraSettingSem = new SemaphoreSlim(1, 1);
        private bool _updateMasterDataFromPath = true;
        private int _currentCar;
        private string _bodyNumber; 
        private string _sequenceNumber;
        private OfflineImageHandler _offlineImageHandler;
        private readonly SemaphoreSlim _updateImageSem = new SemaphoreSlim(1,1);
        private readonly SemaphoreSlim _updateMasterDataSem = new SemaphoreSlim(1,1);
        private Dictionary<int, Dictionary<DataType, List<MasterPathStruct>>> _carTypeToMasterDataset =  new Dictionary<int, Dictionary<DataType, List<MasterPathStruct>>>();
        private Dictionary<InspectionLocation, TCP> _locToMasterCameraTcp = new Dictionary<InspectionLocation, TCP>();
        private const string _installPoseTcpFile = "installPoseTcp.yml"; 
        private const string _scanPoseTcpFile = "scanPoseTcp.yml";
        public MainPresenter(IMainForm view, CargoBox2DSettingManagerPresenter cargoBox2DSettingManagerPresenter, Config config, ICargoBox2DInspectionEngine engine)
        {

            _view = view;
            _config = config;
            _mode = OperationMode.Auto;
            _engine = engine;
            _settingManagerPresenter = cargoBox2DSettingManagerPresenter;

            _engine.SetCallbackWriteLog(Logger.WriteLog);
            _engine.SetEngineVerbosity(5,5);
            CreateLightCommInstance(_config.Light);
            //CreateCameraCommInstance(_config.Camera);
            _cameraComm = new PylonCameraCommunicator.PylonCameraCommunicator();
            CreatePlcCommInstance(_config.Plc);
            Console.WriteLine($"plc comm is empty {_plcComm == null}");

            _view.ConnectCameraRequested += View_ConnectCameraRequested;
            _view.ScanPointRequsted += View_ScanPointRequsted;
            _view.DisconnectLhCameraRequested += View_DisconnectLhCameraRequested;
            _view.ChangeModeRequested += View_ChangeModeRequested;
            _view.ProgramCloseRequested += View_ProgramCloseRequested;
            _view.LightStateChangeRequested += View_LightStateChangedRequested;
            _view.MainFormLoadRequested += View_MainFormLoadRequested;
            _view.ShowSettingManagerRequested += View_ShowSettingManagerRequested;
            _view.CarTypeChanged += View_CarTypeChanged;
            _view.CaptureRequested += View_CaptureRequested;
            _view.ReadInstallPoseRequested += View_ReadInstallPoseRequested;
            _view.ReadScanPoseRequested += View_ReadScanPoseRequested;
            _view.WriteShiftPoseRequested += View_WriteShiftPoseRequested;
            _view.CheckWrittenShiftPoseRequested += View_CheckWrittenShiftPoseRequested;
            _view.ScanPointUsingArucoRequested += View_ScanPointUsingArucoRequested;
            _settingManagerPresenter.SettingChangeConfirmed += SettingManagerPresenter_SettingChangeConfirmed;
            _settingManagerPresenter.UpdateMasterDataFromConfigPathRequested += SettingManagerPresenter_UpdateMasterDataFromConfigPathRequested;
        }

        private async void View_ScanPointUsingArucoRequested(object sender, EventArgs e)
        {
            if (await Task.Run(() => LoadArucoDataset()))
            {
                _offlineImageHandler.SetCarType(-1);
                UpdateUiByInspection(_offlineImageHandler);
                await InitializeScanSettings(true);
                ImageStruct[] structForShiftValueArray = _offlineImageHandler.GetImageStructsArray
                    (InspectionLocation.LH, InspectionLocation.RH);
                Logger.Info($"Struct Count: {structForShiftValueArray.Count()}");
                bool calculatePoseSuccess = false;
                await Task.Run(() =>
                {
                    calculatePoseSuccess = _engine.PoseAdjustment2D(structForShiftValueArray, structForShiftValueArray.Count());
                }); 
                Logger.Info($"Passed Calculating Pose, pose Count: {structForShiftValueArray.Count()}, calculatePoseSuccess = {calculatePoseSuccess}");
                //_cameraComm.ClearBmpData();
                if (calculatePoseSuccess)
                {
                    foreach (ImageStruct imgStruct in structForShiftValueArray)
                    {
                        Logger.Info($"Computed Shift Value: Location: {imgStruct.CameraLocation}, Pose: {imgStruct.Shift6D}");
                    }
                    RobotPose calculatedPose = structForShiftValueArray[0].GetRobotPose();
                    Logger.Info($"Aruco Image Pose Computation Value: {calculatedPose}");
                    //bool writeSucceeded = await WriteRobotPoses(new RobotPose[] {calculatedPose});
                }
            }
        }

        private async void View_CheckWrittenShiftPoseRequested(object sender, EventArgs e)
        {
            var robotConfig = _config.RobotConfigs[_config[-1].Robot];
            var readScanVariables = robotConfig[RobotAttribute.VehicleShiftVars]?.Split(',');
            var result = await ReadRobotPoses(readScanVariables); 
            if (result == null)
            {
                Logger.Error($"Failed to read RobotPoses");
            }
            var pose = result.First();
            _view.SetReadWrittenShiftPose(new double[] { pose.Tx, pose.Ty, pose.Tz, pose.Rx, pose.Ry, pose.Rz });
        }

        private async void View_WriteShiftPoseRequested(object sender, double[] e)
        {
            var robotConfig = _config.RobotConfigs[_config[-1].Robot];
            var readScanVariables = robotConfig[RobotAttribute.VehicleShiftVars]?.Split(',');
            RobotPose poseToWrite = new RobotPose()
            {
                Tx = e[0], Ty = e[1], Tz = e[2], 
                Rx = e[3], Ry = e[4], Rz = e[5]
            };
            var result = await WriteRobotPoses(new RobotPose[] {poseToWrite }); 
            if (!result)
            {
                Logger.Error($"Failed to read RobotPoses {poseToWrite}");
            }
            else
            {
                Logger.Info($"Write Success");
            }
        }

        private async void View_ReadScanPoseRequested(object sender, EventArgs e)
        {
            var robotConfig = _config.RobotConfigs[_config[-1].Robot];
            var readScanVariables = robotConfig[RobotAttribute.GapScanPoseVars]?.Split(',');
            var result = await ReadRobotPoses(readScanVariables); 
            if (result == null)
            {
                Logger.Error($"Failed to read RobotPoses");
            }
            var pose = result.First();
            _view.SetReadScanPose(new double[] { pose.Tx, pose.Ty, pose.Tz, pose.Rx, pose.Ry, pose.Rz });
        }

        private async void View_ReadInstallPoseRequested(object sender, EventArgs e)
        {
            var robotConfig = _config.RobotConfigs[_config[-1].Robot];
            var readScanVariables = robotConfig[RobotAttribute.VehicleInstallVars]?.Split(',');
            var result = await ReadRobotPoses(readScanVariables); 
            if (result == null)
            {
                Logger.Error($"Failed to read RobotPoses");
            }
            var pose = result.First();
            _view.SetReadInstallPose(new double[] { pose.Tx, pose.Ty, pose.Tz, pose.Rx, pose.Ry, pose.Rz });
        }

        private async void View_CaptureRequested(object sender, StartWithModifierEventArgs e)
        {
            _view.SetCaptureCameraButton = false;
            await ScanPointAsync(e.HasFreePassTicket);
            _view.SetCaptureCameraButton = true;
        }

        private async void SettingManagerPresenter_UpdateMasterDataFromConfigPathRequested(object sender, EventArgs e)
        {
            _updateMasterDataFromPath = await Task.Run(() => LoadMasterDataset());
            if (_mode != OperationMode.Auto)
            {
                await InitializeModelSettings();
            }
        }

        private void View_CarTypeChanged(object sender, EventArgs e)
        {
            if (_currentCar != _view.CarType)
            {
                ChangeCarType(_view.CarType);
            }
        }

        private async void SettingManagerPresenter_SettingChangeConfirmed(object sender, EventArgs e)
        {
            bool isPlcChanged = (_config.Plc != _settingManagerPresenter.ConfigCandidate.Plc) ||
                                _settingManagerPresenter.ChangeTracker.IsPlcSettingModified;
            _settingManagerPresenter.ConfigCandidate.RecentlyUsedCar = _config.RecentlyUsedCar;
            Config configCandidate = _settingManagerPresenter.ConfigCandidate;
            bool _isCameraConfigChanged = _settingManagerPresenter.Cam2DSettingManager.Camera2DBundleModified()
                                    || configCandidate.CameraConfigs.Count != _config.CameraConfigs.Count;
            bool isPathModified = _settingManagerPresenter.ModifiedDataPaths;
            _config = configCandidate;
            SaveConfig();

            Logger.FileLoglevelFrom = _config.MinimumFileLogLevel;
            Logger.GuiLoglevelFrom = _config.MinimumUiLogLevel;
            if (_isCameraConfigChanged)
            {
                var camBundleToAdd = _config.CameraConfigs.Keys.Except(_cameraParameterDict.Keys).ToArray();
                var camBundleToModify = _config.CameraConfigs.Keys.Intersect(_cameraParameterDict.Keys).ToArray();
                var camBundleToDelete = _cameraParameterDict.Keys.Except(_config.CameraConfigs.Keys).ToArray();
                UpdateCameraParametersFromConfig(camBundleToAdd, camBundleToModify, camBundleToDelete);
            }

            if (_mode == OperationMode.Auto)
            {
                _updateMasterDataFromPath = true;
                Logger.Info($"Lang.Msgs.SettingChangeAutoMode\n{_settingManagerPresenter.ChangeTracker}");
            }
            else
            {
                Logger.LogPath = _config.LogPath;

                if (isPlcChanged)
                {
                    CreatePlcCommInstance(_settingManagerPresenter.ConfigCandidate.Plc);
                    LoadPlcSignalLabelTitle();
                }

                if (isPathModified)
                {
                    _updateMasterDataFromPath = await Task.Run(() => LoadMasterDataset());
                    await InitializeModelSettings();
                }
                Logger.Info($"Lang.Msgs.SettingChange\n{_settingManagerPresenter.ChangeTracker}");
            }
            UpdateUiByConfig();
        }

        private void View_ShowSettingManagerRequested(object sender, EventArgs e)
        {
            _settingManagerPresenter?.Start(_mode);
        }

        private async void View_MainFormLoadRequested(object sender, EventArgs e)
        {
            if (_mode == OperationMode.Auto)
            {
                await InitializePlc();
            }
            await UpdateCameraParametersFromConfig(_config.CameraConfigs.Keys.ToArray(), null, null);
            string currentCam = _config[-1].Camera;
            _cameraComm.Connect(_cameraParameterDict[currentCam]);
            UpdateUiByConfig();
            _view.SetUiToMode(_mode);
        }

        private async void View_ChangeModeRequested(object sender, ChangeModeEventArgs e)
        {
            Logger.Debug($"Mode Change Request : {_mode} -> {e.Mode}");
            if (_mode == e.Mode)
            {
                return;
            }
            _mode = e.Mode;
            try
            {
                if (e.Mode == OperationMode.Auto)
                {
                    _engine.SetEngineVerbosity(1,1);
                    await InitializePlc();
                }
                else
                {
                    _engine.SetEngineVerbosity(5,5);
                    if (_plcComm != null)
                    {
                        await _plcComm.DisconnectAsync();
                    }
                }

                _lightComm?.WriteLightState(false);
                _view.SetLightState = false;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.ToString());
            }

            _view.SetUiToMode(_mode);
        }

        private void View_DisconnectLhCameraRequested(object sender, EventArgs e)
        {
            _cameraComm.StopCamera();
            //_pylonComm.DisConnectCamera();
        }

        private async void View_ScanPointRequsted(object sender, EventArgs e)
        {
            _view.SetStartCameraButton = false;
            Logger.Debug("Call [Camera Start]");
            await InitializeModelSettings();
            await InitializeScanSettings();
            var readPose = await ScanPointAsync();
            if (readPose != null)
            {
                var calculatedPose = await CalculateShiftPointAsync(readPose);
                // Validate Calculated Shift Point;
                //await WriteRobotPoses(new RobotPose[] {calculatedPose});
            }
            //UpdateRobotPoses
            _view.SetStartCameraButton = true;
            Logger.Debug("Complete [Camera Start]");
        }

        private async void View_ConnectCameraRequested(object sender, EventArgs e)
        {
            _view.SetConnectCameraButton = false;
            Logger.Debug("Call [Camera Connect]");
            var cameraName = _config[-1].Camera;
            await ConnectCameraAsync(cameraName);
            Logger.Debug("Complete [Camera Connect]");
            _view.SetConnectCameraButton = true;
        }

        private async void View_LightStateChangedRequested(object sender, ChangeLightStateEventArgs e)
        {
            var result = await Task.Run(() => _lightComm?.WriteLightState(e.State));
        }

        private void View_ProgramCloseRequested(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to Exit Program?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //_config.DarkMode = _view.DarkModeChecked;
                //ConfigFileManager.SaveToFile(_config, ConfigFileManager.GetConfigFilePath());

                _view.RefreshPlcStatus();
                _plcComm?.Disconnect();
                _plcComm?.Dispose();
                _lightComm?.Dispose();

                //Process[] procs = Process.GetProcessesByName("ProductionRecordManager");
                //if (procs.Length > 0)
                //{
                //    procs[0].Kill();
                //}
                Logger.Debug("Program Exited");
            }
            else
            {
                e.Cancel = true;
            }
        }

        #region Auto Events
        private void PlcComm_PlcError(object sender, EventArgs e)
        {
            Logger.Info("Plc Error Received");
        }

        private void PlcComm_PlcConnected(object sender, EventArgs e)
        {
            Logger.Info("Plc Connected Received");
        }

        private async void PlcComm_PlcDisconnected(object sender, EventArgs e)
        {
            Logger.Info("Plc Disconnected Received");
            if (_mode == OperationMode.Auto && _plcComm != null)
            {
                await _plcComm.ConnectAsync();
                if (_plcComm.IsConnected)
                {
                    RegisterPlcEventHandler();
                }
                _view.IsPlcConnected = _plcComm.IsConnected;
                _view.RefreshPlcStatus();
            }
        }

        private void PlcComm_VisionUpdate(object sender, VisionUpdateEventArgs e)
        {
            Logger.Info("Plc Update Received");
            try
            {
                if (e.CarType != _config.RecentlyUsedCar)
                {
                    ChangeCarType(e.CarType);
                }

                Logger.Info($"cartype : {e.CarType} // seqnum : {e.CarSeq} // bodynum : {e.BodyNumber}");
                UpdatePlcInspectionInfo(e.CarType, e.CarSeq, e.BodyNumber);
                Logger.Debug("Call [Camera Connect]");
                _lightComm.WriteLightState(true);

                if (!_cameraComm.IsConnected)
                {
                    var currentCam = _config[-1].Camera;
                    _cameraComm.Connect(_cameraParameterDict[currentCam]);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.ToString());
            }
        }

        private async void PlcComm_VisionStart(object sender, EventArgs e)
        {
            Logger.Info("Plc Start Received");
            Logger.Debug("Call [Camera Start]");
            try
            {
                await InitializeModelSettings();
                var readPose = await ScanPointAsync();
                if (readPose == null)
                {
                    Logger.Error($"Read Pose is null");
                    //Consider Yelling NG
                }
                int ret = await _plcComm.SendPlcStatusAsync(PlcSignalForLoadingBox.P1_COMPLETED, true, 100, 10);
                if (ret != 0)
                {
                    Logger.Info("SEND P1 COMPLETE FAIL");
                }
                else
                {
                    Logger.Info("SEND P1 COMPLETE SUCCEED");
                }
                
                var calculatedPose = await CalculateShiftPointAsync(readPose);
                //Validate Computed Shift Value
                Logger.Info($"Calculated Pose: {calculatedPose}");
                //bool writeSucceeded = await WriteRobotPoses(new RobotPose[] {calculatedPose});
                ret = await _plcComm.SendPlcStatusAsync(PlcSignalForLoadingBox.VISION_OK, true, 100, 10);
                if (ret != 0)
                {
                    Logger.Info("SEND OK Fail");
                }
                else
                {
                    Logger.Info("SEND OK SUCCEED");
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.ToString());
            }
            finally
            {
                _cameraComm?.ClearBmpData();
            }
            Logger.Debug("Complete [Vision Start]");
        }

        private async Task<bool> StartCameraAsync()
        {
            if (_isRunningCamera)
            {
                return false;
            }

            if (_cameraComm == null)
            {
                return false;
            }
            _isRunningCamera = true;

            try
            {
                if (!await _cameraSettingSem.WaitAsync(3000))
                {
                    Logger.Error($"Failed to Start Camera");
                    return false;
                }
                await Task.Run(() => _cameraComm.StartCamera(_cameraParameterDict[_config[-1].Camera]));
            }
            finally
            {
                _isRunningCamera = false;
                _cameraSettingSem.Release();
            }
            return true;
        }

        private async Task<bool> ConnectCameraAsync(string cameraName)
        {
            if (_isConnectingCamera)
            {
                return false;
            }
            if (_cameraComm == null || cameraName == null)
            {
                return false;
            }
            _isConnectingCamera = true;

            try
            {
                if (!await _cameraSettingSem.WaitAsync(3000))
                {
                    return false;
                }
                if (_cameraComm.IsConnected)
                {
                    _cameraComm.Disconnect();
                }
                _cameraComm.Connect(_cameraParameterDict[cameraName]);
            }
            finally
            {
                _isConnectingCamera = false;
                _cameraSettingSem.Release();
            }
            return true;
        }

        private async void PlcComm_VisionEnd(object sender, EventArgs e)
        {
            Logger.Info("Plc End Received");
            _view.DisplayVisionResult(VisionStatus.OK);
            await Task.Run(() => _lightComm?.WriteLightState(false));
        }

        private async void PlcComm_VisionReset(object sender, EventArgs e)
        {
            Logger.Info("Plc Reset Received");
            int ret = await _plcComm.SendPlcStatusAsync(PlcSignalForLoadingBox.VISION_OK, false, 100, 10);
            if (ret != 0)
            {
                Logger.Error($"PLC VISION OK OFF FAIL {ret}");
            }
            else
            {
                Logger.Info("PLC VISION OK OFF SUCCEED");
            }

            ret = await _plcComm.SendPlcStatusAsync(PlcSignalForLoadingBox.VISION_NG, false, 100, 10);
            if (ret != 0)
            {
                Logger.Error($"PLC VISION NG OFF FAIL {ret}");
            }
            else
            {
                Logger.Info("PLC VISION NG OFF SUCCEED");
            }

            ret = await _plcComm.SendPlcStatusAsync(PlcSignalForLoadingBox.P1_COMPLETED, false, 100, 10);
            if (ret != 0)
            {
                Logger.Error($"PLC VISION P1_COMPLETED OFF FAIL {ret}");
            }
            else
            {
                Logger.Info("PLC VISION P1_COMPLETED OFF SUCCEED");
            }
        }

        #endregion

        #region Manual Events
        #endregion

        #region Methods
        private bool LoadConfig()
        {
            return true;
        }
        private bool InitializeCameraSettings()
        {
            return true;
        }
        private bool LoadModelSettings()
        {
            try
            {
                foreach (int carType in _config.ConfigDict.Keys)
                {
                    var checkerBoardImageStructs = _carTypeToMasterDataset[carType][DataType.CheckerBoard].ToArray();
                    _engine.LoadCharucoBoardConfig(checkerBoardImageStructs, checkerBoardImageStructs.Length);
                    var masterImageStructs = _carTypeToMasterDataset[carType][DataType.MasterImage].ToArray();
                    _engine.LoadMasterImage(masterImageStructs, masterImageStructs.Length);
                }
                return true;
            }
            catch (Exception ex)
            {
                Logger.Error($"Failed Loading Model Settings, Error: {ex.Message}");
                return false;
            }
        }
        private async Task<bool> InitializeModelSettings(int timeOutMilliseconds = 500)
        {
            if (!_updateMasterDataFromPath)
            {
                Logger.Debug($"Update Master Data From Path Set to False. Check to see if Loading Master Data from Config Path Failed");
                return true;
            }

            Stopwatch sw = Stopwatch.StartNew();
            if (!await _updateMasterDataSem.WaitAsync(timeOutMilliseconds))
            {
                Logger.Error($"Failed Loading MasterPathStructs to InspectionEngine");
                return false;
            }

            try
            {
                if (!LoadModelSettings())
                {
                    Logger.Info($"Load Model Failed.");
                    return false;
                }

                if (!await Task.Run(() => _engine.InitializeMaster()))
                {
                    Logger.Error($"Initializing Model Settings Failed");
                    return false;
                }

                _updateMasterDataFromPath = false;
                Logger.Info($"Initializing Model Finished. Succeeded, Took {sw.Elapsed}");
                return true;
            }
            catch (Exception ex) 
            { 
                Logger.Error($"Error while Initializing Master Data to Inspection Engine. Error : {ex}");
                return false;
            }
            finally
            {
                _updateMasterDataSem.Release();
            }
        }
        private async Task<bool> InitializePlc()
        {
            if (_plcComm != null && !_plcComm.IsConnected)
            {
                Console.WriteLine("Intialize PLC Thread Id : " + Thread.CurrentThread.ManagedThreadId);
                await _plcComm.ConnectAsync();
                if (_plcComm.IsConnected)
                {
                    RegisterPlcEventHandler();
                    _view.PlcInfo = "MELSEC";
                }
                Console.WriteLine($"Is Connected {_plcComm.IsConnected}");
                _view.IsPlcConnected = _plcComm.IsConnected;
                _view.RefreshPlcStatus();
                LoadPlcSignalLabelTitle();
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool ConnectPlc(bool isOn)
        {
            return true;
        }
        private bool ReadyCamera()
        {
            return true;
        }
        private bool ReadyModel()
        {
            return true;
        }
        private bool StartInspection()
        {
            return true;
        }
        private bool StopCamera()
        {
            return true;
        }
        private bool StopInspection()
        {
            return true;
        }
        private bool WriteOnPlc()
        {
            return true;
        }
        private bool SaveProductionRecord()
        {
            return true;
        }
        private bool UpdateControls(ProgramState programState)
        {
            return true;
        }
        private bool ChangeMode()
        {
            return true;
        }

        private void UpdatePlcInspectionInfo(int carType, string seqNum, string bodyNum)
        {
            _bodyNumber = bodyNum;
            _sequenceNumber = seqNum;
            _view.CarSeq = _sequenceNumber;
            _view.BodyNum = _bodyNumber;
        }

        private bool ChangeCarType(int carType)
        {
            if (_config.GetCarTypeList().Contains(carType))
            {
                _config.RecentlyUsedCar = carType;
                _currentCar = carType;
                _view.CarType = carType;
                SaveConfig();
                Logger.Info($"Lang.Msgs.CarTypeChanged: {carType}");
                return true;
            }
            else
            {
                Logger.Warning($"Lang.Msgs.InvalidCarType: ({_plcComm.CarType})");
                return false;
            }
        }

        private bool CreatePlcCommInstance(string selectedPlc)
        {
            if (selectedPlc == null || !_config.PlcConfigs.TryGetValue(selectedPlc, out var plcConf))
            {
                Logger.Error($"Lang.Msgs.NotSupportedPlcCommunicator {selectedPlc}");
                return false;
            }

            _plcComm?.Dispose();
            _plcComm = PlcCommunicationManager.CreatePlcCommunicator(selectedPlc, plcConf) as PlcCommunicatorForLoadingBox;
            if (_plcComm == null)
            {
                Logger.Error("Lang.Msgs.NotFindPlcCommunicator");
                return false;
            }

            var modelAttr = _plcComm.GetType().GetCustomAttribute<PlcModelAttribute>();
            if (modelAttr == null)
            {
                Logger.Error("Lang.Msgs.HaveNoPlcModelInfo");
                return false;
            }

            _isPlcEventHandlersRegistered = false;
            return true;
        }

        private bool CreateLightCommInstance(string selectedLight)
        {
            if (selectedLight == null || !_config.LightConfigs.TryGetValue(selectedLight, out var lightConf))
            {
                Logger.Error($"Lang.Msgs.NotSupportedLightCommunicator {selectedLight}");
                return false;
            }

            _lightComm?.Dispose();
            _lightComm = LightCommunicationManager.CreateLightCommunicator(selectedLight, lightConf) as LightCommunicatorForLoadingBox;
            if (_lightComm == null)
            {
                Logger.Error("Lang.Msgs.NotFindLightCommunicator");
                return false;
            }
            return true;
        }

        private bool CreateCameraCommInstance(string selectedCamera)
        {
            if (selectedCamera == null || _config.CameraConfigs == null)
            {
                Logger.Error($"Lang.Msgs.NotSupportedCameraCommunicator {selectedCamera}");
                return false;
            }

            _cameraComm?.Dispose();
            //_camComm = CameraCommunicationManager.CreateCameraCommunicator(selectedCamera, null) as CameraCommunicatorForLoadingBox;
            if (_cameraComm == null)
            {
                Logger.Error("Lang.Msgs.NotFindCameraCommunicator");
                return false;
            }
            return true;
        }

        private void RegisterPlcEventHandler()
        {
            if (_isPlcEventHandlersRegistered)
            {
                return;
            }

            _plcComm.PlcSent += (s, args) =>
            {
                _view.BlinkWriteStatus(100);
            };

            _plcComm.PlcReceived += (s, args) =>
            {
                _view.BlinkReadStatus(100);
                UpdatePlcSignalStatus();
            };

            _plcComm.CarTypeUpdate += PlcComm_VisionUpdate;
            _plcComm.VisionStart += PlcComm_VisionStart;
            _plcComm.VisionEnd += PlcComm_VisionEnd;
            _plcComm.VisionReset += PlcComm_VisionReset;
            _plcComm.PlcDisconnected += PlcComm_PlcDisconnected;
            _plcComm.PlcConnected += PlcComm_PlcConnected;
            _plcComm.PlcError += PlcComm_PlcError;

            _isPlcEventHandlersRegistered = true;
        }

        private void UpdatePlcSignalStatus()
        {
            foreach (var mInfo in _plcComm.PlcMonitorInfos)
            {
                foreach (var sig in mInfo.SignalDict.Keys)
                {
                    if (mInfo.DataParseType == PlcDataType.BIT)
                    {
                        _view.TogglePlcSignalLabel(sig, mInfo.SignalDict[sig].IsOn);
                    }
                    else
                    {
                        _view.UpdatePlcSignalLabel(sig, mInfo.SignalDict[sig].GetText(mInfo.DataParseType));
                    }
                }
            }
        }

        private void LoadPlcSignalLabelTitle()
        {
            if (_plcComm == null)
            {
                return;
            }

            foreach (var mInfo in _plcComm.PlcMonitorInfos)
            {
                foreach (var kv in mInfo.SignalDict)
                {
                    PlcSignalForLoadingBox bareSig = kv.Key & ~PlcSignalForLoadingBox.VALUE;
                    _view.UpdatePlcSignalLabel(bareSig,
                                               mInfo.GetLabelTitle(bareSig.ToString(), kv.Key));
                }
            }
        }

        private Task UpdateCameraParametersFromConfig(string[] cameraBundleToAdd, string[] cameraBundleToModify, string[] cameraBundleToDelete)
        {
            return Task.Run(async () =>
            {
                await _cameraSettingSem.WaitAsync();
                try
                {
                    _modifiedCameraBundleDict = _settingManagerPresenter.Cam2DSettingManager.ModifiedCamera2DBundles;
                    SetNewCameraParametersFromConfig(cameraBundleToAdd);
                    UpdateCameraParametersFromConfig(cameraBundleToModify);
                    DeleteCameraParametersFromConfig(cameraBundleToDelete);
                }
                finally
                {
                    _cameraSettingSem.Release();
                }

            });
        }

        private void SetNewCameraParametersFromConfig(IEnumerable<string> cameraBundleNames)
        {
            if (cameraBundleNames == null || cameraBundleNames.Count() == 0)
            {
                return;
            }
            foreach (var camBundleName in cameraBundleNames)
            {
                if (!_config.CameraConfigs.TryGetValue(camBundleName, out var camBundleConfig))
                {
                    throw new ArgumentOutOfRangeException(camBundleName);
                }
                if (!_cameraParameterDict.ContainsKey(camBundleName))
                {
                    _cameraParameterDict[camBundleName] = new ConcurrentDictionary<InspectionLocation, CameraParameter>();
        
                    foreach (var kvp in camBundleConfig)
                    {
                        _cameraParameterDict[camBundleName][kvp.Key] = new CameraParameter(kvp.Value);
                    }
                }
            }
        }

        private void UpdateCameraParametersFromConfig(IEnumerable<string> cameraBundleNames)
        {
            if (cameraBundleNames == null || cameraBundleNames.Count() == 0)
            {
                return;
            }
            foreach (var camBundleName in cameraBundleNames)
            {
                if (_modifiedCameraBundleDict.TryGetValue(camBundleName, out var modifiedLocations))
                {
                    foreach (var kvp in modifiedLocations)
                    {
                        if (kvp.Value)
                        {
                            var location = kvp.Key;
                            var newParameters = _config.CameraConfigs[camBundleName][location];
                            _cameraParameterDict[camBundleName][location].AdjustCameraParameters(newParameters);
                        }
                    }
                }
            }
        }

        private void DeleteCameraParametersFromConfig(IEnumerable<string> cameraBundleNames)
        {
            if (cameraBundleNames == null || cameraBundleNames.Count() == 0)
            {
                return;
            }

            foreach (var camBundleName in cameraBundleNames)
            {
                if (!_cameraParameterDict.ContainsKey(camBundleName))
                {
                    throw new ArgumentOutOfRangeException(camBundleName);
                }
                if (!_cameraParameterDict.TryRemove(camBundleName, out var existingConfig))
                {
                    Logger.Error($"Removing Camera Parameter Setting From Presenter Failed {camBundleName}");
                }
            }
        }
        private bool LoadMasterDataset()
        {
            Stopwatch sw = Stopwatch.StartNew();
            _updateMasterDataSem.Wait();
            try
            {
                foreach (var carTypeToConfig in _config.ConfigDict)
                {
                    string masterImageRootPath = carTypeToConfig.Value.MasterImageRootFolderPath;
                    bool getMasterImageFilePathsSucceed = GetFilePathsByInspectionLocation(masterImageRootPath, out var locToMasterImagePaths);

                    string checkerBoardRootPath = carTypeToConfig.Value.CheckerBoardRootFolderPath;
                    bool getCheckerBoardFilePathsSucceed = GetFilePathsByInspectionLocation(checkerBoardRootPath, out var locToCheckerBoardfiles);

                    string calibrationDataPath = _config.CalibrationDataRootPath;
                    bool getCalibrationFilePathsSucceed = GetFilePathsByInspectionLocation(calibrationDataPath, out var locToCalibrationFiles);

                    string zDegreeDataPath = _config.ZRotationPerLocationDataFilePath;
                    bool getZDegreeDataSucceed = TryDeserializeYaml<Dictionary<InspectionLocation, float>>(zDegreeDataPath, out var zDegrees);
                    
                    string masterCameraTcpRootPath = _config.CameraTcpDataRootFolderPath;
                    bool getMasterCameraTcpFilePathsSucceed = GetFilePathsByInspectionLocation(masterCameraTcpRootPath, out var locToMasterTcpFile);

                    if (!getMasterImageFilePathsSucceed || !getCheckerBoardFilePathsSucceed || !getCalibrationFilePathsSucceed
                        || !getMasterCameraTcpFilePathsSucceed || !getZDegreeDataSucceed)
                    {
                        Logger.Error($"Failed Refreshing Master Dataset. Master Image : {getMasterImageFilePathsSucceed}. " +
                            $"CheckerBoard : {getCheckerBoardFilePathsSucceed}. Calibration : {getCalibrationFilePathsSucceed}. " +
                            $"ZDegree : {getZDegreeDataSucceed}. ");

                        return false;
                    }
                    string shiftModelFilePath = carTypeToConfig.Value.ShiftModelPath;
                    //string detectModelFilePath = carTypeToConfig.Value.DetectModelPath;

                    int carType = carTypeToConfig.Key;
                    if (!_carTypeToMasterDataset.ContainsKey(carType))
                    {
                        _carTypeToMasterDataset[carType] = new Dictionary<DataType, List<MasterPathStruct>>()
                        { 
                            [DataType.MasterImage] = new List<MasterPathStruct>(),
                            [DataType.CheckerBoard] = new List<MasterPathStruct>()
                        };
                    }

                    List<MasterPathStruct> masterImageStructs = new List<MasterPathStruct>();
                    List<MasterPathStruct> checkerBoardStructs = new List<MasterPathStruct>();
                    string cameraGroupName = carTypeToConfig.Value.Camera;
                    foreach (InspectionLocation registeredLoc in _cameraParameterDict[cameraGroupName].Keys)
                    {
                        bool hasSerializationError = false;
                        if (TryDeserializeYaml<CalibrationData>(locToCalibrationFiles[registeredLoc], out var calibrationData))
                        {
                            masterImageStructs.Add(MasterPathStruct.MasterImageStruct(carType, locToMasterImagePaths[registeredLoc], shiftModelFilePath, registeredLoc, 
                            calibrationData, zDegrees[registeredLoc])); 
                            checkerBoardStructs.Add(MasterPathStruct.CharucoImageStruct(carType, locToCheckerBoardfiles[registeredLoc], shiftModelFilePath, registeredLoc, 
                            calibrationData, zDegrees[registeredLoc]));
                        }
                        else
                        {
                            Logger.Error($"Failed Refreshing Master Dataset. Failed while parsing Calibration Data From Path : {locToCalibrationFiles[registeredLoc]}");
                            hasSerializationError = true;
                        }

                        if (TryGetCameraTcp(locToMasterTcpFile[registeredLoc], out var tcpData))
                        {
                            TCP tcp = new TCP()
                            {
                                TcpMatrix = tcpData
                            };

                            _locToMasterCameraTcp[registeredLoc] = tcp;
                        }
                        else
                        {
                            Logger.Error($"Failed Retrieving Tcp Dta From Path: {locToMasterTcpFile[registeredLoc]}");
                            hasSerializationError = true;
                            _locToMasterCameraTcp.Clear();
                        }

                        if (hasSerializationError)
                        {
                            Logger.Error($"Retrieving MasterDataSet From Config Failed");
                            return false;
                        }
                    }

                    _carTypeToMasterDataset[carType][DataType.MasterImage] = masterImageStructs;
                    _carTypeToMasterDataset[carType][DataType.CheckerBoard] = checkerBoardStructs;
                }

                if (_config.OfflineMode)
                {
                    if (!LoadOfflineImages())
                    {
                        return false;
                    }
                }
            }
            finally
            {
                _updateMasterDataSem.Release();
            }
            Logger.Info($"Loading Master Data From File Path Complete, Took {sw.Elapsed}");
            return true;
        }
        private bool LoadArucoDataset()
        {
            string arucoImageRootPath = Path.Combine(_config.ArucoDataRootFolderPath, "Master");
            bool getArucoImageFilePathsSucceed = GetFilePathsByInspectionLocation(arucoImageRootPath, out var locToMasterImagePaths);

            string arucoCheckerBoardRootPath = Path.Combine(_config.ArucoDataRootFolderPath, "Charuco");
            bool getCheckerBoardFilePathsSucceed = GetFilePathsByInspectionLocation(arucoCheckerBoardRootPath, out var locToCheckerBoardfiles);

            string calibrationDataPath = _config.CalibrationDataRootPath;
            bool getCalibrationFilePathsSucceed = GetFilePathsByInspectionLocation(calibrationDataPath, out var locToCalibrationFiles);

            string zDegreeDataPath = _config.ZRotationPerLocationDataFilePath;
            bool getZDegreeDataSucceed = TryDeserializeYaml<Dictionary<InspectionLocation, float>>(zDegreeDataPath, out var zDegrees);
            
            string masterCameraTcpRootPath = _config.CameraTcpDataRootFolderPath;
            bool getMasterCameraTcpFilePathsSucceed = GetFilePathsByInspectionLocation(masterCameraTcpRootPath, out var locToMasterTcpFile);

            if (!getArucoImageFilePathsSucceed || !getCheckerBoardFilePathsSucceed || !getCalibrationFilePathsSucceed
                || !getMasterCameraTcpFilePathsSucceed || !getZDegreeDataSucceed)
            {
                Logger.Error($"Failed Refreshing Master Dataset. Master Image : {getArucoImageFilePathsSucceed}. " +
                    $"CheckerBoard : {getCheckerBoardFilePathsSucceed}. Calibration : {getCalibrationFilePathsSucceed}. " +
                    $"ZDegree : {getZDegreeDataSucceed}. ");

                return false;
            }
            string shiftModelFileRootPath= Path.Combine(_config.ArucoDataRootFolderPath, "Model");
            string shiftModelFilePath = Directory.GetFiles(shiftModelFileRootPath).First();
            //string detectModelFilePath = carTypeToConfig.Value.DetectModelPath;

            int carType = -1;
            if (!_carTypeToMasterDataset.ContainsKey(carType))
            {
                _carTypeToMasterDataset[carType] = new Dictionary<DataType, List<MasterPathStruct>>()
                { 
                    [DataType.MasterImage] = new List<MasterPathStruct>(),
                    [DataType.CheckerBoard] = new List<MasterPathStruct>()
                };
            }

            List<MasterPathStruct> masterImageStructs = new List<MasterPathStruct>();
            List<MasterPathStruct> checkerBoardStructs = new List<MasterPathStruct>();
            InspectionLocation[] locations = new InspectionLocation[] {InspectionLocation.LH, InspectionLocation.RH};
            foreach (InspectionLocation registeredLoc in locations)
            {
                bool hasSerializationError = false;
                if (TryDeserializeYaml<CalibrationData>(locToCalibrationFiles[registeredLoc], out var calibrationData))
                {
                    masterImageStructs.Add(MasterPathStruct.MasterImageStruct(carType, locToMasterImagePaths[registeredLoc], shiftModelFilePath, registeredLoc, 
                    calibrationData, zDegrees[registeredLoc])); 
                    checkerBoardStructs.Add(MasterPathStruct.CharucoImageStruct(carType, locToCheckerBoardfiles[registeredLoc], shiftModelFilePath, registeredLoc, 
                    calibrationData, zDegrees[registeredLoc]));
                }
                else
                {
                    Logger.Error($"Failed Refreshing Master Dataset. Failed while parsing Calibration Data From Path : {locToCalibrationFiles[registeredLoc]}");
                    hasSerializationError = true;
                }

                if (TryGetCameraTcp(locToMasterTcpFile[registeredLoc], out var tcpData))
                {
                    TCP tcp = new TCP()
                    {
                        TcpMatrix = tcpData
                    };

                    _locToMasterCameraTcp[registeredLoc] = tcp;
                }
                else
                {
                    Logger.Error($"Failed Retrieving Tcp Dta From Path: {locToMasterTcpFile[registeredLoc]}");
                    hasSerializationError = true;
                    _locToMasterCameraTcp.Clear();
                }

                if (hasSerializationError)
                {
                    Logger.Error($"Retrieving MasterDataSet From Config Failed");
                    return false;
                }
            }

            _carTypeToMasterDataset[carType][DataType.MasterImage] = masterImageStructs;
            _carTypeToMasterDataset[carType][DataType.CheckerBoard] = checkerBoardStructs;

            var checkerBoardImageStruct = _carTypeToMasterDataset[carType][DataType.CheckerBoard].ToArray();
            _engine.LoadCharucoBoardConfig(checkerBoardImageStruct, 1);
            var masterImageStruct = _carTypeToMasterDataset[carType][DataType.MasterImage].ToArray();
            _engine.LoadMasterImage(masterImageStruct, 1);

            _engine.InitializeMaster();

            LoadOfflineImages(true);
            return true;
        }
        private bool GetFilePathsByInspectionLocation (string folderPath, out Dictionary<InspectionLocation, string> locToFilePaths)
        {
            if (!Directory.Exists(folderPath))
            {
                Logger.Error($"Failed getting file path from given folder path : {folderPath}");
                locToFilePaths = null;
                return false;
            }

            string[] folderPaths;
            try
            {
                folderPaths = Directory.GetDirectories(folderPath);
            }
            catch (Exception e)
            {
                Logger.Error($"Getting Folder Paths from {folderPath} Failed. Error : {e.Message}");
                locToFilePaths = null;
                return false;
            }

            Dictionary<InspectionLocation, string> foundLocToFilePaths = new Dictionary<InspectionLocation, string>();
            foreach (string folder in folderPaths)
            {
                string folderName = Path.GetFileName(folder).Trim();
                if (Enum.TryParse(folderName, true, out InspectionLocation location))
                {
                    string[] file = Directory.GetFiles(folder);
                    if (file.Length == 0)
                    {
                        Logger.Error($"Found no files on Path {folder}");
                        locToFilePaths = null;
                        return false;
                    }
                    else if (file.Length > 1)
                    {
                        Logger.Error($"Multiple files found on path {folder}, setting first as file path {file[0]}");
                        foundLocToFilePaths[location] = file[0].Replace('\\', '/');
                    }
                    else
                    {
                        foundLocToFilePaths[location] = file[0].Replace('\\', '/');
                    }
                    Console.WriteLine($"Path : {file[0]}");
                }
                else
                {
                    Logger.Error($"Invalid Folder Path found on RootPath: {folderPath}, Invalid Path : {folder}");
                }
            }

            locToFilePaths = foundLocToFilePaths;
            return true;
        }
        private bool TryDeserializeYaml<T>(string path, out T deserializedInstance)
        {
            string yamlContent;
            try
            {
                yamlContent = File.ReadAllText(path);
                yamlContent = yamlContent.Replace("\uFEFF", "").Trim();

                // Remove the `%YAML:1.0` directive if present
                if (yamlContent.StartsWith("%YAML"))
                {
                    int firstNewLineIndex = yamlContent.IndexOf('\n');
                    yamlContent = firstNewLineIndex >= 0
                        ? yamlContent.Substring(firstNewLineIndex).Trim()
                        : yamlContent;
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"Error reading file from path : {path}, Error: {ex.Message}");
                deserializedInstance = default;
                return false;
            }

            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance) // Match YAML keys
                .WithTagMapping("tag:yaml.org,2002:opencv-matrix", typeof(Matrix)) // Handle custom tags
                .Build();

            T data;
            try 
            {
                data = deserializer.Deserialize<T>(yamlContent);
            }
            catch (Exception ex)
            {
                Logger.Error($"Error while deserializing calibration data from path : {path}, Error: {ex}");
                deserializedInstance = default;
                return false;
            }
            deserializedInstance = data;
            return true;
        }
        private bool TrySerializeYaml<T>(string path, string fileName, T data)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                string fullPath = Path.Combine(path, fileName);

                var serializer = new SerializerBuilder()
                    .WithNamingConvention(CamelCaseNamingConvention.Instance)
                    .Build();

                string yaml = serializer.Serialize(data);

                File.WriteAllText(fullPath, yaml);

                return true; // Indicate success
            }
            catch (Exception ex)
            {
                Logger.Error($"Failed to serialize to {path}: {ex.Message}");
                return false; 
            }
        }
        private bool TryGetCameraTcp(string path, out double[] cameraTcp)
        {
            string fileContent; 
            try
            {
                fileContent = File.ReadAllText(path);
                var tcpValue = fileContent.Trim().Split(',');
                if (tcpValue.Length != 16)
                {
                    Logger.Error($"Error while getting CameraTcp from path: {path}, should have eactly 16 float values.");
                    cameraTcp = null;
                    return false;
                }

                var result = tcpValue.Select(x => double.Parse(x)).ToArray();
                cameraTcp = result;
                return true;
            }
            catch (Exception ex)
            {
                Logger.Error($"Error while getting CameraTcp from path: {path}, should have eactly 16 float values. Error: {ex}");
                cameraTcp = null;
                return false;
            }
        }
        private bool LoadOfflineImages(bool getAruco = false)
        {
            _offlineImageHandler = new OfflineImageHandler(new InspectionLocation[] {InspectionLocation.LH, InspectionLocation.RH});
            if (getAruco)
            {
                string offlineDataPath = Path.Combine(_config.ArucoDataRootFolderPath, "InspectionImages");
                bool getOfflineDataSucceed = GetFilePathsByInspectionLocation(offlineDataPath, out var locToOfflineData);
                if (!getOfflineDataSucceed)
                {
                    Logger.Error($"Failed Retrieving Aruco Images. Try Reconfiguring Aruco Image Path and Try Again");
                    return false;
                }
                Logger.Info($"Images Count: {locToOfflineData.Count()}");
                foreach (var kvp in locToOfflineData)
                {
                    Logger.Info($"Offline File Path: {kvp.Value}");
                    _offlineImageHandler.LoadBitMapFromPath(-1, kvp.Key, kvp.Value);
                }
                Logger.Info($"Aruco Mode: Load Offline Image for Aruco: {-1} Succeeded");
                return true;
            }
            foreach (int carType in _config.ConfigDict.Keys)
            {
                string offlineDataPath = _config[carType].OfflineImageRootFolderPath;
                bool getOfflineDataSucceed = GetFilePathsByInspectionLocation(offlineDataPath, out var locToOfflineData);
                if (!getOfflineDataSucceed)
                {
                    Logger.Error($"Failed Retrieving Offline Images for Cartype {carType}. Try Reconfiguring Offline Image Path and Try Again");
                    return false;
                }
                
                foreach (var kvp in locToOfflineData)
                {
                    _offlineImageHandler.LoadBitMapFromPath(carType, kvp.Key, kvp.Value);
                }
                Logger.Info($"OfflineMode: Load Offline Image for Cartype: {carType} Succeeded");
            }
            return true;
        }
        private async Task<bool> InitializeScanSettings(bool onAruco = false)
        {
            if (_locToMasterCameraTcp.Count != 2)
            {
                return false;
            }
            TCP masterScanPoseTcp = new TCP();
            TCP masterInstallPoseTcp = new TCP();
            if (_config.OfflineMode)
            {
                if (TryDeserializeYaml<TCP>(Path.Combine(_config[-1].MasterImageRootFolderPath, _scanPoseTcpFile), out var scanPoseTcp))
                {
                    masterScanPoseTcp = scanPoseTcp;
                }
                else { return false; }
                if (TryDeserializeYaml<TCP>(Path.Combine(_config[-1].MasterImageRootFolderPath, _installPoseTcpFile), out var installPoseTcp))
                {
                    masterInstallPoseTcp = installPoseTcp;
                }
                else { return false; }
            }
            else if (onAruco)
            {
                if (TryDeserializeYaml<TCP>(Path.Combine(_config.ArucoDataRootFolderPath, _scanPoseTcpFile), out var scanPoseTcp))
                {
                    masterScanPoseTcp = scanPoseTcp;
                }
                else { return false; }
                if (TryDeserializeYaml<TCP>(Path.Combine(_config.ArucoDataRootFolderPath, _installPoseTcpFile), out var installPoseTcp))
                {
                    masterInstallPoseTcp = installPoseTcp;
                }
                else { return false; }
            }
            else
            {
                var robotConfig = _config.RobotConfigs[_config[-1].Robot];
                var masterScanPoseVariables = robotConfig[RobotAttribute.GapScanPoseVars]?.Split(',');
                var masterInstallPoseVariables = robotConfig[RobotAttribute.VehicleInstallVars]?.Split(',');
                var masterScanPoses = await ReadRobotPoses(masterScanPoseVariables);
                var masterInstallPoses = await ReadRobotPoses(masterInstallPoseVariables);
                if (masterScanPoses == null || masterInstallPoses == null)
                {
                    Logger.Error($"Failed to load Scan Settings to Engine: Failed Loading Master Poses from Robot");
                    //Temp pass empty scan poses
                    masterScanPoseTcp = TCP.GetTCPFromRobotPose(new RobotPose());
                    masterInstallPoseTcp = TCP.GetTCPFromRobotPose(new RobotPose());
                }
                else
                {
                    masterScanPoseTcp = TCP.GetTCPFromRobotPose(masterScanPoses.First());
                    masterInstallPoseTcp = TCP.GetTCPFromRobotPose(masterInstallPoses.First());
                }
            }
            
            bool ret = _engine.LoadTransformationMatrix(masterScanPoseTcp, masterInstallPoseTcp,
                                                        _locToMasterCameraTcp[InspectionLocation.LH], _locToMasterCameraTcp[InspectionLocation.RH]);
            if (!ret)
            {
                Logger.Error($"Failed Loading Scan Settings to Engine. loadTransformMat API Failed");
                return false;
            }

            return true;
        }
        private async Task<bool> SaveRobotMasterPoses(int carType, string rootPath)
        {
            var robotConfig = _config.RobotConfigs[_config[carType].Robot];
            var masterScanPoseVariables = robotConfig[RobotAttribute.GapScanPoseVars]?.Split(',');
            var masterInstallPoseVariables = robotConfig[RobotAttribute.VehicleInstallVars]?.Split(',');
            var masterScanPoses = await ReadRobotPoses(masterScanPoseVariables);
            var masterInstallPoses = await ReadRobotPoses(masterInstallPoseVariables);
            if (masterScanPoses == null || masterInstallPoses == null)
            {
                Logger.Error($"Failed to load Scan Settings to Engine: Failed Loading Master Poses from Robot");
                return false;
            }
            else
            {
                TCP masterScanPoseTcp = TCP.GetTCPFromRobotPose(masterScanPoses.First());
                if (!TrySerializeYaml<TCP>(rootPath, _scanPoseTcpFile, masterScanPoseTcp))
                {
                    return false;
                }
                TCP masterInstallPoseTcp = TCP.GetTCPFromRobotPose(masterInstallPoses.First());
                if (!TrySerializeYaml<TCP>(rootPath, _installPoseTcpFile, masterInstallPoseTcp))
                {
                    return false;
                }
            }
            return true;
        }
        private void SaveConfig()
        {
            try
            {
                ConfigFileManager.SaveToFile(_config, ConfigFileManager.GetConfigFilePath());
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
        }
        private void SaveBitmap(InspectionLocation location, Bitmap bitmap, string saveRootPath)
        {
            try
            {
                string fileName = $"{location}.png";
                //if (!string.IsNullOrEmpty(_sequenceNumber))
                //{
                //    fileName += $"_{_sequenceNumber}";
                //}
                //if (!string.IsNullOrEmpty(_bodyNumber))
                //{
                //    fileName += $"_{_bodyNumber}";
                //}
                string fullPath = Path.Combine(saveRootPath, location.ToString(), fileName);
                if (!Directory.Exists(Path.GetDirectoryName(fullPath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(fullPath));
                }
                bitmap.Save(fullPath, ImageFormat.Png);
                Logger.Info($"SaveComplete, ID: {location} on path {fullPath}");
            }
            catch (Exception ex)
            {
                Logger.Error($"Save Failed. Error: {ex.Message}");
            }
        }
        private async Task SaveInspectionData(string rootPath, RobotPose scanPose, IImageProvider<InspectionLocation> imageProvider)
        {
            var locimages = imageProvider.GetAllBitmaps();
            TrySerializeYaml<TCP>(rootPath, _scanPoseTcpFile, TCP.GetTCPFromRobotPose(scanPose));
            IEnumerable<Task> saveImages = locimages?.Select(locImg => Task.Run(() => SaveBitmap(locImg.Item1, locImg.Item2, rootPath)));
            await Task.WhenAll(saveImages);
        }
        private void UpdateUiByConfig()
        {
            _view.SetCarTypeList(_config.GetCarTypeAndNameList(), _config.RecentlyUsedCar);
        }

        private bool ConfigureRobot(Dictionary<RobotAttribute, string> robotConfig, bool wantRemake = false)
        {
            if (wantRemake)
            {
                _robotComm?.Dispose();
                _robotComm = null;
            }

            if (_robotComm == null)
            {
                var robotMaker = robotConfig[RobotAttribute.Maker].ToEnum<RobotMaker>();
                _robotComm = RobotCommMaker.Make(robotMaker, robotConfig);

                if (_robotComm == null)
                {
                    Logger.Error($"Robot Not Supported");
                    return false;
                }
            }
            return true;
        }
        private Task<bool> ReadyRobotsAysnc()
        {
            return Task.Run(async () =>
            {
                try
                {
                    Stopwatch sw = Stopwatch.StartNew();
                    var installRobotConfig = _config.RobotConfigs[_config[-1].Robot];
                    bool ret = ConfigureRobot(installRobotConfig, true);

                    if (ret && installRobotConfig[RobotAttribute.Maker].ToEnum<RobotMaker>() == RobotMaker.YASKAWA)
                    {
                        ret = await _robotComm.DisconnectAsync();
                    }
                    Logger.Info($"Install Robot Ready : {ret}\t Took {sw.Elapsed}");
                    return ret;
                }
                catch (Exception ex)
                {
                    Logger.Error($"Ready Robot Failed. Error: {ex.Message}");
                    return false;
                }
            });
        }

        private async Task<RobotPose> ScanPointAsync(bool saveAsMaster = false)
        {
            Stopwatch sw = Stopwatch.StartNew();
            if (!await StartCameraAsync())
            {
                Logger.Info($"Scanning Current Value Failed");
                return null;
            }
            UpdateUiByInspection(_cameraComm);

            if (!await ReadyRobotsAysnc())
            {
                Logger.Error($"Robot Error Failed");
                return null;
            }

            var currentScanPose = await _robotComm.ReadRobotCurrentPoseAsync();
            Logger.Info($"Read Current Pose :{currentScanPose}");
            if (currentScanPose == null)
            {
                Logger.Error($"Failed To read Current Robot Pose");
                //TEMP 
                currentScanPose = new RobotPose();
                //return null;
            }

            await SaveInspectionData(ConfigureSaveRootPath(false), currentScanPose, _cameraComm);

            if (saveAsMaster)
            {
                try
                {
                    var masterSaveRootPath = ConfigureSaveRootPath(true);
                    await SaveInspectionData(masterSaveRootPath, currentScanPose, _cameraComm);
                    await SaveRobotMasterPoses(_currentCar, masterSaveRootPath);
                }
                catch (Exception ex)
                {
                    Logger.Error($"Saving TCP to Path Failed: ScanPose : {currentScanPose}. Error: {ex.Message}");
                }
            }
            Logger.Info($"Scan Pose Complete: SaveMaster: {saveAsMaster}, Took: {sw.Elapsed}");
            return currentScanPose;
        }

        private async Task<RobotPose> CalculateShiftPointAsync(RobotPose readPose, bool useArcoForDetection = false)
        {
            if (!await InitializeScanSettings())
            {
                return null;
            }

            Stopwatch stopwatch = Stopwatch.StartNew();
            ImageStruct[] structForShiftValueArray;
            if (_config.OfflineMode)
            {
                structForShiftValueArray = _offlineImageHandler?.GetImageStructsArray();
            }
            else
            {
                structForShiftValueArray = _cameraComm.GetImageStructArray(_currentCar);
            }
            //ImageStruct[] structForShiftValueArray = _cameraComm.GetImageStructsArray(_currentCarName, _cameraParameterDict[_currentCarName].Keys.ToArray());
            if (structForShiftValueArray.Length == 0)
            {
                Logger.Error($"Failed Getting Any Bitmaps");
                return null;
            }
            //else
            //{
            //    for (int i = 0; i < structForShiftValueArray.Length; ++i)
            //    {
            //        structForShiftValueArray[i].ScanPose4x4Matrix = TCP.GetFlattenMatrix4x4FromRobotPose(readPose);
            //    }
            //}
            Logger.Info($"Finished Fetching Images. Image Count : {structForShiftValueArray.Length}. Took : {stopwatch.Elapsed}");
            bool calculatePoseSuccess = false; 
            await Task.Run(() =>
            {
                calculatePoseSuccess = _engine.PoseAdjustment2D(structForShiftValueArray, structForShiftValueArray.Count());
            }); 

            _cameraComm.ClearBmpData();
            if (calculatePoseSuccess)
            {
                Logger.Info($"Calculate Shift Value Complete, Took {stopwatch.Elapsed}");
                foreach (ImageStruct imgStruct in structForShiftValueArray)
                {
                    Logger.Info($"Computed Shift Value: Location: {imgStruct.CameraLocation}, Pose: {imgStruct.Shift6D}");
                }
                return structForShiftValueArray[0].GetRobotPose();
            }
            else
            {
                Logger.Error($"Calculating Pose Failed");
                return null;
            }
        }
        private void UpdateUiByInspection(IImageProvider<InspectionLocation> providerByLoc)
        {
            try
            {
                var locImgs = providerByLoc?.GetAllBitmaps();
                Console.WriteLine($"Images, Count: {locImgs.Length}");
                foreach (var locImg in locImgs)
                {
                    _view.SetInspectionImage(locImg.Item1, locImg.Item2?.Clone() as Image);
                }
            }
            catch (Exception) { }
        }
        private string ConfigureSaveRootPath(bool isMasterData)
        {
            string saveRootPath;
            if (isMasterData)
            {
                saveRootPath = _config[-1].MasterImageRootFolderPath;
            }
            else
            {
                var capturedDate = $"{DateTime.Now:yyMMdd}";
                var capturedTime = $"{DateTime.Now:HHmmss}";
                saveRootPath = Path.Combine(_config.LogPath, capturedDate, _currentCar.ToString(), capturedTime);
                //TODO: Apply body and sequence number
            }
            return saveRootPath;
        }
        public async Task<bool> WriteRobotPoses(RobotPose[] posesToWrite)
        {
            if (!await ReadyRobotsAysnc())
            {
                return false;
            }
            var installRobotConfig = _config.RobotConfigs[_config[-1].Robot];
            var writeVarNames = installRobotConfig[RobotAttribute.VehicleShiftVars].Split(',');

            if (posesToWrite.Length == 0 || writeVarNames.Length != posesToWrite.Length)
            {
                Logger.Error($"Writing Pose Failed. Poses and Variable count should be same. Pose Count: {posesToWrite.Length}. Write Variable Count: {writeVarNames.Length}"); 
                return false;
            }
            
            try
            {
                for (int i = 0; i < posesToWrite.Length; i++)
                {
                    Logger.Debug($"Writing Poses ([{i}] {posesToWrite[i]} -> {writeVarNames[i]})");
                    var ret = await _robotComm.WriteRobotPoseAsync(posesToWrite[i], writeVarNames[i]);

                    if (!ret)
                    {
                        Logger.Error($"Writing to Robot Failed");
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Logger.Error($"Error while writing poses to Robot. Error: {ex}");
                return false;
            }
        }
        public async Task<List<RobotPose>> ReadRobotPoses(string[] readVariables)
        {
            if (!await ReadyRobotsAysnc())
            {
                Logger.Error($"Read Variable Failed: Failed to Ready Robot");
                return null;
            }
            try
            {
                if (readVariables == null)
                {
                    Logger.Error($"Failed to load Poses, Given Read Variables is null");
                    return null;
                }
                Stopwatch sw = Stopwatch.StartNew();
                List<RobotPose> robotPoses = new List<RobotPose>();
                foreach (string variable in readVariables)
                {
                    Console.WriteLine($"variable: {variable}");
                    RobotPose pose = await _robotComm.ReadRobotPoseAsync(variable);
                    if (pose == null)
                    {
                        Logger.Error($"Failed to Read Pose from Variable: {variable}");
                        return null;
                    }
                    robotPoses.Add(pose);
                }
                
                Logger.Info($"Read Poses complete. Took : {sw.Elapsed}");
                return robotPoses;
            }
            catch (Exception ex)
            {
                Logger.Error($"Failed To Read Poses. Error: {ex}");
                return null;
            }
        }
        private async Task<bool> SendPlcStatusAsync(PlcSignalForLoadingBox signal, bool value, int nMaxTrials, int delay)
        {
            try
            {
                int ret = await _plcComm.SendPlcStatusAsync(signal, value, nMaxTrials, delay);
                if (value)
                {
                    if (ret == 0)
                    {
                            
                        Logger.Info($"SEND {signal} SUCCEED");
                        return true;
                    }
                    else
                    {
                        Logger.Info($"SEND {signal} FAILED");
                        return false;
                    }
                }
                else
                {
                    if (ret == 0)
                    {
                        Logger.Info($"Erase {signal} SUCCEED");
                        return true;
                    }
                    else
                    {
                        Logger.Info($"Erase {signal} FAILED");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"Sending Plc Signal {signal}, Failed. Error : {ex.Message}");
                return false;
            }
        }
        private void ConfigureImageStructForArcoDetection(ImageStruct[] imageStructs)
        {
            for (int i = 0; i < imageStructs.Count(); i++)
            {
                var imgstruct = imageStructs[i];
                imgstruct.CarType = -1;
                imageStructs[i] = imgstruct;
            }
        }
        #endregion
        #region Enums
        enum ProgramState
        {

        }
        #endregion
    }
}
