using CoPick;
using CoPick.Logging;
using CoPick.Plc;
using CoPick.Robot;
using CoPick.Setting;
using loadingBox2dGui.models;
using loadingBox2dGui.models.ProductionRecord;
using loadingBox2dGui.views;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loadingBox2dGui.presenters
{
    public class MainPresenter
    {
        private static readonly LogHelper Logger = LogHelper.Logger;
        
        private readonly IMainForm _view;
        private Config _config;
        private OperationMode _mode;
        private PlcCommunicatorForLoadingBox _plcComm;
        private PlcModel _plcModel;
        private LightCommunicatorForLoadingBox _lightComm;
        private CameraCommunicatorForLoadingBox _cameraComm;
        private readonly ICargoBox2DInspectionEngine _engine;
        protected readonly IProductionRecordRepository _productionRecordRepository;
        private IRobotCommunicator _robotComm;
        private bool _isPlcEventHandlersRegistered = false;
        private readonly CargoBox2DSettingManagerPresenter _settingManagerPresenter;
        private ConcurrentDictionary<string, ConcurrentDictionary<InspectionLocation, CameraParameter>> _cameraParameterDict = new ConcurrentDictionary<string, ConcurrentDictionary<InspectionLocation, CameraParameter>>();
        private Dictionary<int, CargoBox2DConfig> _modelParameterDict = new Dictionary<int, CargoBox2DConfig>();
        private readonly SemaphoreSlim _cameraParameterAccessLock = new SemaphoreSlim(1, 1);
        private readonly SemaphoreSlim _modelParameterAccessLock = new SemaphoreSlim(1, 1);
        private int _currentCar;
        private string _bodyNumber;
        private string _sequenceNumber;
        private readonly MasterDataManager _masterDataManager;
        public MainPresenter(IMainForm view, CargoBox2DSettingManagerPresenter cargoBox2DSettingManagerPresenter, 
            Config config, ICargoBox2DInspectionEngine engine, IProductionRecordRepository repository)
        {

            _view = view;
            _config = config;
            _mode = _config.StartMode;
            _engine = engine;
            _masterDataManager = new MasterDataManager(_engine);
            _productionRecordRepository = repository;
            _settingManagerPresenter = cargoBox2DSettingManagerPresenter;

            _engine.SetCallbackWriteLog(Logger.WriteLog);
            CreateLightCommInstance(_config.Light);
            CreateCameraCommInstance(_config.Camera);
            CreatePlcCommInstance(_config.Plc);
            
            _view.ConnectCameraRequested += View_ConnectCameraRequested;
            _view.ScanPointRequested += View_ScanPointRequested;
            _view.DisconnectCameraRequested += View_DisconnectCameraRequested;
            _view.ChangeModeRequested += View_ChangeModeRequested;
            _view.ProgramCloseRequested += View_ProgramCloseRequested;
            _view.LightStateChangeRequested += View_LightStateChangedRequested;
            _view.MainFormLoadRequested += View_MainFormLoadRequested;
            _view.ShowSettingManagerRequested += View_ShowSettingManagerRequested;
            _view.CarTypeChanged += View_CarTypeChanged;
            _view.ReadInstallPoseRequested += View_ReadInstallPoseRequested;
            _view.ReadScanPoseRequested += View_ReadScanPoseRequested;
            _view.WriteTxTyRzRequested += View_WriteShiftPoseRequested;
            _view.CheckWrittenShiftPoseRequested += View_CheckWrittenShiftPoseRequested;
            _view.ShowScreenShotRequested += View_ShowScreenShotRequested;
            _view.ResetNgListRequested += View_ResetNgListRequested;
            _view.CaptureCheckerboardRequested += View_CaptureCheckerboardRequested;
            _settingManagerPresenter.SettingChangeConfirmed += SettingManagerPresenter_SettingChangeConfirmed;
            _settingManagerPresenter.UpdateMasterDataFromConfigPathRequested += SettingManagerPresenter_UpdateMasterDataFromConfigPathRequested;

            if (_productionRecordRepository != null)
            {
                UpdateNgList(_config.StartTimeToGetNgList);
            }
            else
            {
                Logger.Warning($"Production Record Repository Not Connected");
            }
        }

        private async void View_CaptureCheckerboardRequested(object sender, EventArgs e)
        {
            if (_mode != OperationMode.Set)
            {
                Logger.Warning($"Can only Capture Checkerboard data on Set mode. Current Mode: {_mode}");
            }
            await ScanPointAsync(true, DataType.CheckerBoard);
        }

        private void View_ResetNgListRequested(object sender, EventArgs e)
        {
            _config.StartTimeToGetNgList = DateTime.Now;
            SaveConfig();
            UpdateNgList(_config.StartTimeToGetNgList);
        }

        private void View_ShowScreenShotRequested(object sender, ImagePathEventArgs e)
        {
            if (File.Exists(e.ImagePath))
            {
                NgListItemImageForm_ openForm = Application.OpenForms["NgListItemImageForm_"] as NgListItemImageForm_;
                if (openForm != null)
                {
                    openForm.UpdateNgListItemImagePath(e.ImagePath);
                }
                else
                {
                    NgListItemImageForm_ form = new NgListItemImageForm_(e.ImagePath);
                    form.Show();
                }
            }
            else
            {
                Logger.Debug("file does not exist");
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
            RobotPose poseToWrite = new RobotPose()
            {
                Tx = e[0], Ty = e[1], Rz = e[2]
            };
            var result = await WriteRobotPoses(poseToWrite); 
            if (!result)
            {
                Logger.Error($"Failed to Write RobotPoses {poseToWrite}");
            }
            else
            {
                Logger.Info($"Write Success");
            }
        }

        private async void View_ReadScanPoseRequested(object sender, SaveMasterDataEventArgs e)
        {
            var robotConfig = _config.RobotConfigs[_config[-1].Robot];
            var readScanVariables = robotConfig[RobotAttribute.GapScanPoseVars]?.Split(',');
            var result = await ReadRobotPoses(readScanVariables); 
            if (result == null)
            {
                Logger.Error($"Failed to read RobotPoseds");
                return;
            }
            var pose = result.First();
            _view.SetReadScanPose(new double[] { pose.Tx, pose.Ty, pose.Tz, pose.Rx, pose.Ry, pose.Rz });
            if (e.SaveMaster)
            {
                _masterDataManager.SaveMasterRobotScanPose(pose, _currentCar);
            }
        }

        private async void View_ReadInstallPoseRequested(object sender, SaveMasterDataEventArgs e)
        {
            var robotConfig = _config.RobotConfigs[_config[-1].Robot];
            var readScanVariables = robotConfig[RobotAttribute.VehicleInstallVars]?.Split(',');
            var result = await ReadRobotPoses(readScanVariables); 
            if (result == null)
            {
                Logger.Error($"Failed to read RobotPoses");
                return;
            }
            var pose = result.First();
            _view.SetReadInstallPose(new double[] { pose.Tx, pose.Ty, pose.Tz, pose.Rx, pose.Ry, pose.Rz });
            if (e.SaveMaster)
            {
                _masterDataManager.SaveMasterRobotInstallPose(pose, _currentCar);
            }
        }

        private async void SettingManagerPresenter_UpdateMasterDataFromConfigPathRequested(object sender, EventArgs e)
        {
            var configMasterDataPathsDict = _settingManagerPresenter.ConfigCandidate.GetMasterDataPathsDict();
            await Task.Run(() => _masterDataManager.LoadMasterDataset(configMasterDataPathsDict));
            if (_mode != OperationMode.Auto)
            {
                await _masterDataManager.InitializeMasterData();
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
            bool isMasterDataPathModified = _settingManagerPresenter.ModifiedDataPaths;
            _config = configCandidate;
            SaveConfig();

            Logger.FileLoglevelFrom = _config.MinimumFileLogLevel;
            Logger.GuiLoglevelFrom = _config.MinimumUiLogLevel;
            if (_isCameraConfigChanged)
            {
                var camBundleToAdd = _config.CameraConfigs.Keys.Except(_cameraParameterDict.Keys).ToArray();
                var camBundleToModify = _config.CameraConfigs.Keys.Intersect(_cameraParameterDict.Keys).ToArray();
                var camBundleToDelete = _cameraParameterDict.Keys.Except(_config.CameraConfigs.Keys).ToArray();
                var updateCamParamsTask = UpdateCameraParametersFromConfig(camBundleToAdd, camBundleToModify, camBundleToDelete);
            }
            var updateModelParmsTask = UpdateModelParametersFromConfig();
            
            if (isMasterDataPathModified)
            {
                var masterDataPathsDict = _config.GetMasterDataPathsDict();
                await Task.Run(() => _masterDataManager.LoadMasterDataset(masterDataPathsDict));
                if (_mode != OperationMode.Auto)
                {
                    await _masterDataManager.InitializeMasterData();
                }
            }

            if (_mode == OperationMode.Auto)
            {
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
                Logger.Info($"Lang.Msgs.SettingChange\n{_settingManagerPresenter.ChangeTracker}");
            }
            UpdateUiByConfig();
        }

        private void View_ShowSettingManagerRequested(object sender, StartWithModifierEventArgs e)
        {
            if (_mode != OperationMode.Auto || e.HasFreePassTicket || _view.ValidatePassword())
            {
                _settingManagerPresenter.Start(_mode);
            }
        }

        private async void View_MainFormLoadRequested(object sender, EventArgs e)
        {
            await UpdateCameraParametersFromConfig(_config.CameraConfigs.Keys.ToArray(), null, null);
            await UpdateModelParametersFromConfig();
            await Task.Run(() => _masterDataManager.LoadMasterDataset(_config.GetMasterDataPathsDict()));
            await _masterDataManager.InitializeMasterData();
            string cameraName = _config[-1].Camera;
            await ConnectCameraAsync(cameraName);
            UpdateUiByConfig();
        }

        private async void View_ChangeModeRequested(object sender, ModeChangedEventArgs e)
        {
            if (_settingManagerPresenter.IsOpen)
            {
                Logger.Info($"Can't Change Mode while SettingManager Is Open");
                _view.ResetToAutoMode();
                return;
            }

            Logger.Debug($"Mode Change Request : {_mode} -> {e.Mode}");
            _view.IsModeChanging = true;
            try
            {
                if (_mode == OperationMode.Auto && !e.HasFreePassTicket && !_view.ValidatePassword())
                {
                    Console.WriteLine($"mode change from auto requested");
                    _view.ChangeModeRequested -= View_ChangeModeRequested;
                    _view.ResetToAutoMode();
                    _view.ChangeModeRequested += View_ChangeModeRequested;
                    _view.IsModeChanging = false;
                    return;
                }

                switch (e.Mode)
                {
                    case OperationMode.Set:
                        await SetupSetMode();
                        break;
                    case OperationMode.Manual:
                        await SetupManualMode();
                        break;
                    case OperationMode.Auto:
                        await SetupAutoMode();
                        break;
                }

                _lightComm?.WriteLightState(false);
                _view.SetLightState = false;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.ToString());
                _view.IsModeChanging = false;
                return;
            }

            _mode = e.Mode;
            _view.SetUiToMode(_mode);
            _view.IsModeChanging = false;
        }
        
        private async Task SetupSetMode()
        {
            //_engine.SetEngineVerbosity(5,5);
            if (_plcComm != null)
            {
                _plcComm.PlcDisconnected -= PlcComm_PlcDisconnected;
                await _plcComm.DisconnectAsync();
                _plcComm.PlcDisconnected += PlcComm_PlcDisconnected;
            }
            if (_cameraComm.IsConnected)
            {
                await Task.Run(() => _cameraComm.StopCamera());
            }
        }

        private async Task SetupManualMode()
        {
            if (_plcComm != null)
            {
                _plcComm.PlcDisconnected -= PlcComm_PlcDisconnected;
                await _plcComm.DisconnectAsync();
                _plcComm.PlcDisconnected += PlcComm_PlcDisconnected;
            }
            if (_cameraComm.IsConnected)
            {
                await Task.Run(() => _cameraComm.StopCamera());
            }
        }

        private async Task SetupAutoMode()
        {
            _engine.SetEngineVerbosity(0,0);
            await InitializePlc();
        }

        private void View_DisconnectCameraRequested(object sender, EventArgs e)
        {
            _cameraComm.StopCamera();
            //_pylonComm.DisConnectCamera();
        }

        private async void View_ScanPointRequested(object sender, EventArgs e)
        {
            _view.SetStartCameraButton = false;
            Logger.Debug($"Call [{((_mode == OperationMode.Manual) ? "Scan" : "Capture MasterImage")} Start]");
            ResetUi();

            if (_mode == OperationMode.Manual)
            {
                UpdatePlcInspectionInfo(_currentCar, "MMMM", "MMMMMMMM");
                await _masterDataManager.InitializeMasterData();
                if (await ScanPointAsync())
                {
                    var (calculatedPose, minConfidenceScore, maxMasterToSrcSizeRatioDiff, refHoleCount) = await CalculateShiftPointAsync();
                    var (calculationValidated, modelValidated) = await ValidateCalculationAndModelPerformance(calculatedPose, minConfidenceScore, maxMasterToSrcSizeRatioDiff, refHoleCount);
                    var filteredResult = FilterCalculatedResult(calculatedPose);
                    InspectionResult inspectionResult = calculationValidated && modelValidated ? InspectionResult.OK : InspectionResult.NG;
                    await RegisterInspectionResult(inspectionResult, filteredResult, true);
                    if (inspectionResult == InspectionResult.OK && await WriteRobotPoses(filteredResult))
                    {
                        _view.DisplayVisionResult(VisionStatus.OK);
                    }
                    else
                    {
                        _view.DisplayVisionResult(VisionStatus.NG);
                    }
                    _cameraComm?.ClearBmpData();
                }
            }
            else
            {
                await ScanPointAsync(true, DataType.MasterImage);
            }
            Logger.Debug($"Complete [{((_mode == OperationMode.Manual) ? "Scan" : "Capture MasterImage")}]");
            _view.SetStartCameraButton = true;
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
                ConfigFileManager.SaveToFile(_config, ConfigFileManager.GetConfigFilePath());

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

        private async void PlcComm_VisionUpdate(object sender, VisionUpdateEventArgs e)
        {
            Logger.Info("Plc Update Received");
            try
            {
                if (e.CarType != _config.RecentlyUsedCar)
                {
                    if (!ChangeCarType(e.CarType))
                    {
                        Logger.Warning($"Invalid Cartype {e.CarType} Received. Please revise permitted car types and or register new car type with its relevant master data.");
                    }
                }

                ResetUi();
                Logger.Info($"Given Cartype : {e.CarType} // seqnum : {e.SequenceNumber} // bodynum : {e.BodyNumber}");
                UpdatePlcInspectionInfo(_currentCar, e.SequenceNumber, e.BodyNumber);
                _lightComm.WriteLightState(true);
                var currentCam = _config[-1].Camera;
                await ConnectCameraAsync(currentCam);
                await _masterDataManager.InitializeMasterData();
            }
            catch (Exception ex)
            {
                Logger.Error(ex.ToString());
            }
        }

        private async void PlcComm_VisionStart(object sender, EventArgs e)
        {
            Logger.Info("Plc Start Received");
            try
            {
                if (!await ScanPointAsync())
                {
                    Logger.Error($"Scan Point Failed");
                }

                await SendPlcStatusAsync(PlcSignalForLoadingBox.P1_COMPLETED, true, 100, 10);

                var (calculatedPose, minConfidenceScore, maxAbsSizeDiff, refHoleCount) = await CalculateShiftPointAsync();
                var (calculationValidated, modelValidated) = await ValidateCalculationAndModelPerformance(calculatedPose, minConfidenceScore, maxAbsSizeDiff, refHoleCount);
                var filteredResult = FilterCalculatedResult(calculatedPose);
                var sendShiftValueTask = SendPlcShiftValueAsync(filteredResult, 1, 350);
                InspectionResult inspectionResult = InspectionResult.NONE;
                if (_plcComm.VisionPass || _view.OnManualPass)
                {
                    Logger.Info($"Current On Vision Pass: {_plcComm.VisionPass}. Manual Pass: {_view.OnManualPass}");
                    await WriteRobotPoses(filteredResult);
                    await SendPlcStatusAsync(PlcSignalForLoadingBox.VISION_OK, true, 100, 10);
                    _view.DisplayVisionResult(VisionStatus.OK);
                    inspectionResult = InspectionResult.OK;
                }
                else if ((calculationValidated && modelValidated && await WriteRobotPoses(filteredResult)))
                {
                    await SendPlcStatusAsync(PlcSignalForLoadingBox.VISION_OK, true, 100, 10);
                    _view.DisplayVisionResult(VisionStatus.OK);
                    inspectionResult = InspectionResult.OK;
                }
                else
                {
                    await SendPlcStatusAsync(PlcSignalForLoadingBox.VISION_NG, true, 100, 10);
                    _view.DisplayVisionResult(VisionStatus.NG);
                    inspectionResult = InspectionResult.NG;
                }

                await RegisterInspectionResult(inspectionResult, filteredResult);
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

        private async void PlcComm_VisionEnd(object sender, EventArgs e)
        {
            Logger.Info("Plc End Received");
            await Task.Run(() => _lightComm?.WriteLightState(false));
        }

        private async void PlcComm_VisionReset(object sender, EventArgs e)
        {
            Logger.Info("Plc Reset Received");
            await SendPlcStatusAsync(PlcSignalForLoadingBox.VISION_OK, false, 100, 10);
            await SendPlcStatusAsync(PlcSignalForLoadingBox.VISION_NG, false, 100, 10);
            await SendPlcStatusAsync(PlcSignalForLoadingBox.P1_COMPLETED, false, 100, 10);
        }

        #endregion

        #region Manual Events

        #endregion

        #region Methods
        private async Task<bool> StartCameraAsync()
        {
            if (_cameraComm == null || !await _cameraParameterAccessLock.WaitAsync(3000))
            {
                Logger.Error($"Failed to Start Camera");
                return false;
            }

            try
            {
                await Task.Run(() => _cameraComm.StartCamera(_cameraParameterDict[_config[-1].Camera], 3));
            }
            finally
            {
                _cameraParameterAccessLock.Release();
            }
            return true;
        }

        private async Task<bool> ConnectCameraAsync(string cameraName)
        {
            if (_cameraComm == null || cameraName == null || _cameraParameterDict.Count == 0)
            {
                return false;
            }

            try
            {
                if (!await _cameraParameterAccessLock.WaitAsync(3000))
                {
                    return false;
                }
                if (_cameraComm.IsConnected)
                {
                    _cameraComm.StopCamera();
                }
                _cameraComm.Connect(_cameraParameterDict[cameraName]);
            }
            finally
            {
                _cameraParameterAccessLock.Release();
            }
            return true;
        }

        private async Task<bool> InitializePlc()
        {
            if (_plcComm != null && !_plcComm.IsConnected)
            {
                await _plcComm.ConnectAsync();
                if (_plcComm.IsConnected)
                {
                    RegisterPlcEventHandler();
                }
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

        private void UpdatePlcInspectionInfo(int carType, string seqNum, string bodyNum)
        {
            _bodyNumber = bodyNum ?? "EMPTYBDYNUM";
            _sequenceNumber = seqNum ?? "EPTY";
            _view.CarSeq = _sequenceNumber;
            _view.BodyNum = _bodyNumber;
        }

        private bool ChangeCarType(int carType)
        {
            if (_config.GetCarTypeList().Contains(carType))
            {
                _currentCar = carType;
                _config.RecentlyUsedCar = _currentCar;
                _view.CarType = _currentCar;
                SaveConfig();
                Logger.Info($"Lang.Msgs.CarTypeChanged: {carType}");
                return true;
            }
            else
            {
                Logger.Warning($"Lang.Msgs.InvalidCarType: ({carType})");
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

            _plcModel = modelAttr.Model;
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
            _cameraComm = CameraCommunicationManager.CreateCameraCommunicator(selectedCamera, null) as CameraCommunicatorForLoadingBox;
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

        private async Task UpdateModelParametersFromConfig()
        {
            await _modelParameterAccessLock.WaitAsync();
            foreach (var kvp in _config.ConfigDict)
            {
                _modelParameterDict[kvp.Key] = kvp.Value;
            }
            _modelParameterAccessLock.Release();
        }

        private Task UpdateCameraParametersFromConfig(string[] cameraBundleToAdd, string[] cameraBundleToModify, string[] cameraBundleToDelete)
        {
            return Task.Run(async () =>
            {
                await _cameraParameterAccessLock.WaitAsync();
                try
                {
                    SetNewCameraParametersFromConfig(cameraBundleToAdd);
                    ModifyCameraParametersFromConfig(cameraBundleToModify);
                    DeleteCameraParametersFromConfig(cameraBundleToDelete);
                }
                finally
                {
                    _cameraParameterAccessLock.Release();
                }

            });
        }

        private void SetNewCameraParametersFromConfig(string[] cameraBundleNames)
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

        private void ModifyCameraParametersFromConfig(string[] cameraBundleNames)
        {
            if (cameraBundleNames == null || cameraBundleNames.Count() == 0)
            {
                return;
            }
            var modifiedCamBundleDict = _settingManagerPresenter.Cam2DSettingManager.ModifiedCamera2DBundles;
            foreach (var camBundleName in cameraBundleNames)
            {
                if (modifiedCamBundleDict.TryGetValue(camBundleName, out var modifiedLocations))
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

        private void DeleteCameraParametersFromConfig(string[] cameraBundleNames)
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

        private async Task<bool> InitializeTransformationMatrices()
        {
            var robotConfig = _config.RobotConfigs[_config[-1].Robot];
            var masterScanPoseVariables = robotConfig[RobotAttribute.GapScanPoseVars]?.Split(',');
            var masterInstallPoseVariables = robotConfig[RobotAttribute.VehicleInstallVars]?.Split(',');
            var masterScanPoses = await ReadRobotPoses(masterScanPoseVariables);
            var masterInstallPoses = await ReadRobotPoses(masterInstallPoseVariables);
            if (masterScanPoses == null || masterInstallPoses == null)
            {
                Logger.Error($"Failed to load Scan Settings to Engine: Failed Loading Master Poses from Robot");
                return false;
            }
            Logger.Info($"Read Scan Pose : {masterScanPoses.First()} \nInstall Pose TCP: {masterInstallPoses.First()}");
            bool ret = _masterDataManager.InitializeTransformationMatrices(_currentCar, masterScanPoses.First(), masterInstallPoses.First());
            return ret;
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

        private void SaveBitmap(InspectionLocation location, Bitmap bitmap, string saveRootPath, string uniformFilename)
        {
            try
            {
                string fileName = $"{location}_{uniformFilename}";
                string fullPath = Path.Combine(saveRootPath, fileName);
                if (!Directory.Exists(Path.GetDirectoryName(fullPath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(fullPath));
                }
                bitmap.Save(fullPath, ImageFormat.Png);
                Logger.Debug($"SaveComplete, ID: {location} on path {fullPath}");
            }
            catch (Exception ex)
            {
                Logger.Error($"Save Failed. Error: {ex.Message}");
            }
        }

        private async Task SaveInspectionData(string rootPath, string uniformFilename, IImageProvider<InspectionLocation> imageProvider)
        {
            var locImages = imageProvider.GetAllBitmaps();
            List<Task> saveImageTasks = new List<Task>();
            foreach (var locImg in locImages)
            {
                saveImageTasks.Add(Task.Run(() => SaveBitmap(locImg.Item1, locImg.Item2, rootPath, uniformFilename)));
            }
            await Task.WhenAll(saveImageTasks);
        }

        private void UpdateUiByConfig()
        {
            _view.SetCarTypeList(_config.GetCarTypeAndNameList(), _config.RecentlyUsedCar);
            if (_plcComm != null && _config.Plc != null && 
                _config.PlcConfigs.TryGetValue(_config.Plc, out var plcConfig))
            {
                _view.PlcInfo = plcConfig.ToPlcInfoString();
            }
        }

        private void UpdateUiByInspection(IImageProvider<InspectionLocation> providerByLoc)
        {
            try
            {
                var locImgs = providerByLoc?.GetAllBitmaps();
                Console.WriteLine($"Images, Count: {locImgs?.Length}");
                foreach (var locImg in locImgs)
                {
                    _view.SetInspectionImage(locImg.Item1, locImg.Item2?.Clone() as Image);
                }
            }
            catch (Exception) { }
        }

        private bool ConfigureInstallRobot(Dictionary<RobotAttribute, string> robotConfig, bool wantRemake = false)
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
                    bool ret = ConfigureInstallRobot(installRobotConfig, true);

                    if (ret && installRobotConfig[RobotAttribute.Maker].ToEnum<RobotMaker>() == RobotMaker.YASKAWA)
                    {
                        ret = await _robotComm.DisconnectAsync();
                    }
                    Logger.Debug($"Install Robot Ready : {ret}\t Took {sw.Elapsed}");
                    return ret;
                }
                catch (Exception ex)
                {
                    Logger.Error($"Ready Robot Failed. Error: {ex.Message}");
                    return false;
                }
            });
        }

        private async Task<bool> ScanPointAsync(bool saveAsMaster = false, DataType dataType = DataType.MasterImage)
        {
            Stopwatch sw = Stopwatch.StartNew();
            if (!await StartCameraAsync())
            {
                Logger.Error($"Scanning Failed: Failed to Start Camera");
                return false;
            }

            UpdateUiByInspection(_cameraComm);

            if (saveAsMaster)
            {
                try
                {
                    await _masterDataManager.SaveMasterImage(_cameraComm, _currentCar, dataType);
                }
                catch (Exception ex)
                {
                    Logger.Error($"Saving Master Data Failed: Error: {ex}");
                }
            }
            Logger.Debug($"Scan Pose Complete: SaveMaster: {saveAsMaster}, Took: {sw.ElapsedMilliseconds} ms");
            return true;
        }

        private async Task<(RobotPose, float, float, int)> CalculateShiftPointAsync()
        {
            if (!await InitializeTransformationMatrices())
            {
                return (null, 0, 0, 0);
            }

            Stopwatch stopwatch = Stopwatch.StartNew();
            ImageStruct[] structForShiftValueArray = _cameraComm.GetImageStructArray(_currentCar);

            if (structForShiftValueArray == null || structForShiftValueArray.Length != 2)
            {
                Logger.Error($"Failed Getting Both LH and RH Images");
                return (null, 0, 0, 0);
            }

            bool calculatePoseSuccess = false, modelValidated = false, calculationValidated = false;
            float minConfidenceScore = 0, maxMasterToSrcSizeRatioDiff = 0;
            int maxRefHoleCount = 0;

            calculatePoseSuccess = await Task.Run(() =>
            {
                return _engine.PoseAdjustmentCargoBox2D
                (structForShiftValueArray, structForShiftValueArray.Count(), 
                out minConfidenceScore, out maxMasterToSrcSizeRatioDiff, out maxRefHoleCount);
            });
            Logger.Debug($"Calculate Shift Value Complete, Took : {stopwatch.ElapsedMilliseconds} ms");

            if (calculatePoseSuccess)
            {
                foreach (ImageStruct imgStruct in structForShiftValueArray)
                {
                    Logger.Info($"Computed Shift Value: Location: {imgStruct.CameraLocation}, Pose: {imgStruct.Shift6D}");
                }
                var calculatedPose = structForShiftValueArray[0].GetRobotPose();
                return (calculatedPose, minConfidenceScore, maxMasterToSrcSizeRatioDiff, maxRefHoleCount);
            }

            Logger.Error($"Calculating Pose Success: {calculatePoseSuccess}. Model Validated: {modelValidated}. Calculation Validated: {calculationValidated}");
            return (null, 0, 0, 0);
        }
        
        private RobotPose FilterCalculatedResult(RobotPose calculatedResult)
        {
            Logger.Info($"Filtering Calculated Robot Pose. Calculated: {calculatedResult}");
            if (calculatedResult == null || (_plcComm != null && _plcComm.VisionPass) || _view.OnManualPass)
            {
                calculatedResult = new RobotPose();
            }

            RobotPose filteredResult;
            var robotMaker = _config.RobotConfigs[_config[_currentCar].Robot][RobotAttribute.Maker].ToEnum<RobotMaker>();
            switch(robotMaker)
            {
                case RobotMaker.YASKAWA: 
                    filteredResult = new YaskawaRobotPose();
                    break;
                default:
                    Logger.Warning($"Invalid Robot Type. Entered Type: {robotMaker}");
                    filteredResult = new RobotPose();
                    break;
            }

            filteredResult.Tx = calculatedResult.Tx;
            filteredResult.Ty = calculatedResult.Ty;

            Logger.Info($"Filtering Calculated Robot Pose. Filtered: {filteredResult}");
            return filteredResult;
        }

        private bool ValidateCalculatedResult(CargoBox2DConfig modelConfig, RobotPose calculatedPose)
        {
            if (calculatedPose is null)
            {
                return false;
            }

            if (modelConfig.MaxTranslationX < Math.Abs(calculatedPose.Tx)
                || modelConfig.MaxTranslationY < Math.Abs(calculatedPose.Ty)
                || modelConfig.MaxTranslationZ < Math.Abs(calculatedPose.Tz)
                || modelConfig.MaxRotationZ < Math.Abs(calculatedPose.Rz))
            {
                Logger.Error($"Calculated Value Exceeds current threshold, " +
                    $"Tx: {modelConfig.MaxTranslationX} Ty: {modelConfig.MaxTranslationY} Tz: {modelConfig.MaxTranslationZ}. " +
                    $"Rz: {modelConfig.MaxRotationZ} Calculated Pose: {calculatedPose}");
                return false;
            }
            return true;
        }

        private bool ValidateModelPerformance(CargoBox2DConfig modelConfig, float minConfidenceScore, float maxMasterToSrcSizeRatioDiff, int maxRefHoleCount)
        {
            Logger.Info($"Model Performance: Confidence Score : {minConfidenceScore}, Max Size Ratio Diff :{maxMasterToSrcSizeRatioDiff}, Ref Hole Count: {maxRefHoleCount}");
            if (modelConfig.ConfidenceThreshold > minConfidenceScore)
            {
                Logger.Error($"Computed Confidence {minConfidenceScore} is lower than threshold. {modelConfig.ConfidenceThreshold}");
                return false;
            }
            if (modelConfig.SizeRatioDifferenceToSrcThreshold < Math.Abs(1 - maxMasterToSrcSizeRatioDiff))
            {
                Logger.Error($"Computed Size Difference {Math.Abs(1 - maxMasterToSrcSizeRatioDiff)} is higher than the threshold. {modelConfig.SizeRatioDifferenceToSrcThreshold}");
                return false;
            }
            if (maxRefHoleCount != 1)
            {
                Logger.Error($"Computed Max Ref Hole Count {maxRefHoleCount} is not 1");
                return false;
            }
            return true;
        }

        private async Task<(bool, bool)> ValidateCalculationAndModelPerformance(RobotPose calculatedPose, float maxMasterToSrcSizeRatioDiff, float maxAbsSizeDiff, int maxRefHoleCount)
        {
            if (calculatedPose == null)
            {
                return (false, false);
            }

            await _modelParameterAccessLock.WaitAsync();
            try
            {
                var modelConfig = _modelParameterDict[_currentCar];
                bool calculationValidated = ValidateCalculatedResult(modelConfig, calculatedPose);
                bool modelPerformanceValidated = ValidateModelPerformance(modelConfig, maxMasterToSrcSizeRatioDiff, maxAbsSizeDiff, maxRefHoleCount);
                return (calculationValidated, modelPerformanceValidated);
            }
            finally
            {
                _modelParameterAccessLock.Release();
            }
        }

        private async Task<bool> WriteRobotPoses(params RobotPose[] posesToWrite)
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

        public async Task<RobotPose[]> ReadRobotPoses(string[] readVariables)
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
                
                Logger.Debug($"Read Poses complete. Took : {sw.ElapsedMilliseconds} ms");
                return robotPoses.ToArray();
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
                if (ret == 0)
                {
                    Logger.Info($"{(value ? "SEND" : "ERASE")} {signal} SUCCEED");
                    return true;
                }
                else
                {
                    Logger.Info($"{(value ? "SEND" : "ERASE")} {signal} FAILED");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"{(value ? "Sending" : "Erasing")} Plc Signal {signal} Failed. Error : {ex.Message}");
                return false;
            }
        }

        private async Task<bool> SendPlcShiftValueAsync(RobotPose calculatedPose, int nMaxTrials, int checkDelay)
        {
            try
            {
                if (calculatedPose == null)
                {
                    calculatedPose = new RobotPose();
                }

                int ret = await _plcComm.SendShiftValue(calculatedPose, nMaxTrials, checkDelay);
                if (ret == 0)
                {
                    Logger.Info($"Writing ShiftValues {calculatedPose} SUCCEED");
                    return true;
                }
                else
                {
                    Logger.Info($"Writing ShiftValues {calculatedPose} FAILED");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"Writing ShiftValues {calculatedPose} Failed. Error : {ex}");
                return false;
            }
        }

        private void UpdateNgList(DateTime? startDate = null)
        {
            var productionRecords = _productionRecordRepository?.GetRecordsByResult(startDate, InspectionResult.NG);
            if (productionRecords == null)
            {
                Logger.Debug($"Retrieving Records Failed");
                return;
            }
            _view.ShowOnDataGrid(new BindingSource { DataSource = productionRecords });
        }

        private async Task RegisterInspectionResult(InspectionResult result, RobotPose computedResult, bool saveRecordOnDb = true)
        {
            if (computedResult == null)
            {
                computedResult = new RobotPose() 
                { 
                    Tx = 0,
                    Ty = 0,
                    Rz = 0
                };
            }

            _view.SetCalculatedShiftPose(new double[] { computedResult.Tx, computedResult.Ty, computedResult.Rz });
            
            DateTime inspectionTime = DateTime.Now;
            FileHelper.GetResultSavePath(_config.LogPath, result, inspectionTime, 
                _config[-1].CarName, _sequenceNumber, _bodyNumber, ImageFormat.Png, 
                out var resultSaveDirectoryPath, out var resultSaveFilename);
            await SaveInspectionData(resultSaveDirectoryPath, resultSaveFilename, _cameraComm);
            string captureFile = CaptureScreen(inspectionTime, result);
            
            try
            {
                if (!saveRecordOnDb)
                {
                    return;
                }

                ProductionRecord record = new ProductionRecord()
                {
                    CarName = _config[-1].CarName,
                    SequenceNumber = _sequenceNumber,
                    BodyNumber = _bodyNumber,
                    InspectionResult = result,
                    ScreenShotImagePath = captureFile,
                    ProductionDateTime = inspectionTime,
                    Tx = computedResult.Tx,
                    Ty = computedResult.Ty,
                    Rz = computedResult.Rz
                };

                _productionRecordRepository.AddProductionRecord(record);
                UpdateNgList(_config.StartTimeToGetNgList);
            }
            catch (Exception ex)
            {
                Logger.Debug(ex.ToString());
            }
        }

        private string CaptureScreen(DateTime? dateTime = null, InspectionResult result = InspectionResult.NONE)
        {
            FileHelper.GetScreenCaptureFullPath(_config.LogPath, result, _sequenceNumber,
                _bodyNumber, dateTime, out var saveDirectoryPath, out var saveFilename);
            
            try
            {
                var capturedFilePaths = Logger.Capture(new List<string> { saveDirectoryPath }, new List<string> { saveFilename });
                return capturedFilePaths?.First();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        
        private void ResetUi()
        {
            _view.Init();
            _view.SetInspectionImage(InspectionLocation.LH, null);
            _view.SetInspectionImage(InspectionLocation.RH, null);
            _view.DisplayVisionResult(VisionStatus.NONE);
        }

        //private void ShowProductionRecord()
        //{
        //    if (_productionRecordRepository == null)
        //    {
        //        Logger.Warning(Presenter.RetrievingRecordsFromDatabaseFailed);
        //        return; 
        //    }
        //    try
        //    {
        //        DateTime nowDateTime = DateTime.Now;
        //        bool parseSuccess = DateTime.TryParseExact(_config.DailyProductionResetTime, "HH:mm", Thread.CurrentThread.CurrentCulture, DateTimeStyles.None, out DateTime dailyProdResetTime);
        //        if (!parseSuccess)
        //        {
        //            Logger.Warning(Presenter.ParsingDailyProductionResetTimeFailed);
        //            dailyProdResetTime = new DateTime(nowDateTime.Year, nowDateTime.Month, nowDateTime.Day, 0, 0, 0);
        //        }

        //        List<ProductionRecord> records; 
        //        if (nowDateTime >= dailyProdResetTime)
        //        {
        //            records = _productionRecordRepository.GetProductionRecordByDateRange(dailyProdResetTime, dailyProdResetTime.AddDays(1));
        //        }
        //        else
        //        {
        //            records = _productionRecordRepository.GetProductionRecordByDateRange(dailyProdResetTime.AddDays(-1), dailyProdResetTime);
        //        }

        //        double okCount = 0.0;
        //        double ngCount = 0.0;
        //        double totalCount = 0.0;

        //        records?.ForEach(record =>
        //        {
        //            if (record.ProductionResult == InspectionResult.OK)
        //            {
        //                okCount++;
        //            }
        //            else if (record.ProductionResult == InspectionResult.NG)
        //            {
        //                ngCount++;
        //            }
        //            totalCount++;
        //        });
        //        _view.TotalProductionRecord = totalCount.ToString();
        //        _view.OkProductionRecord = okCount.ToString();
        //        _view.NgProductionRecord = ngCount.ToString();
        //        _view.OkPercent = $"OK : {Math.Round(okCount / (totalCount + double.Epsilon) * 100.0, 1)}%";
        //    }
        //    catch (Exception ex)
        //    {
        //        Logger.Warning(ex.Message);
        //    }
        //}
        #endregion
    }
}