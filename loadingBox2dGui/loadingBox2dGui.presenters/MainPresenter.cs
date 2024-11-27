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

namespace loadingBox2dGui.presenters
{
    public class MainPresenter
    {
        private static readonly LogHelper Logger = LogHelper.Logger;
        
        private readonly IMainForm _view;
        private volatile Config _config;
        private OperationMode _mode;
        private PlcCommunicatorForLoadingBox _plcComm;
        private LightCommunicatorForLoadingBox _lightComm;
        private CameraCommunicatorForLoadingBox _camComm;
        private readonly ICargoBox2DInspectionEngine _engine;
        private IRobotCommunicator _installRobotComm;
        private bool _isPlcEventHandlersRegistered = false;
        private bool _isRunningCamera = false;
        private bool _isConnectingCamera = false; 
        private CargoBox2DSettingManagerPresenter _settingManagerPresenter;
        private object _camSettingLock = new object();
        private Dictionary<string, Dictionary<InspectionLocation, bool>> _modifiedCameraBundleDict = new Dictionary<string, Dictionary<InspectionLocation, bool>>();
        private ConcurrentDictionary<string, ConcurrentDictionary<InspectionLocation, CameraParameter>> _camParamDict = new ConcurrentDictionary<string, ConcurrentDictionary<InspectionLocation, CameraParameter>>();
        private readonly SemaphoreSlim _cameraSettingSem = new SemaphoreSlim(1, 1);
        private bool _updateMasterDataFromPath = true;
        private int _currentCar;
        private string _bodyNumber; 
        private string _sequenceNumber; 
        private OfflineImageHandler _offlineImageHandler;
        private readonly SemaphoreSlim _updateMasterDataSem = new SemaphoreSlim(1,1);
        private Dictionary<int, Dictionary<ImageType, List<MasterPathStruct>>> _carTypeToMasterDataset =  new Dictionary<int, Dictionary<ImageType, List<MasterPathStruct>>>();
        public MainPresenter(IMainForm view, CargoBox2DSettingManagerPresenter cargoBox2DSettingManagerPresenter, Config config, ICargoBox2DInspectionEngine engine)
        {

            _view = view;
            _config = config;
            _mode = OperationMode.Auto;
            _engine = engine;
            _settingManagerPresenter = cargoBox2DSettingManagerPresenter;

            engine.SetCallbackWriteLog(Logger.WriteLog);
            //CreateLightCommInstance(_config.Light);
            //CreateCameraCommInstance(_config.Camera);
            _camComm = new PylonCameraCommunicator()
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
            _settingManagerPresenter.SettingChangeConfirmed += SettingManagerPresenter_SettingChangeConfirmed;
            _settingManagerPresenter.UpdateMasterDataFromConfigPathRequested += SettingManagerPresenter_UpdateMasterDataFromConfigPathRequested;
        }

        private async void SettingManagerPresenter_UpdateMasterDataFromConfigPathRequested(object sender, EventArgs e)
        {
            _updateMasterDataFromPath = await Task.Run(() => LoadMasterDatasetFromConfigPaths());
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

        private void SettingManagerPresenter_SettingChangeConfirmed(object sender, EventArgs e)
        {
            bool isPlcChanged = (_config.Plc != _settingManagerPresenter.ConfigCandidate.Plc) ||
                                _settingManagerPresenter.ChangeTracker.IsPlcSettingModified;
            _settingManagerPresenter.ConfigCandidate.RecentlyUsedCar = _config.RecentlyUsedCar;
            Config configCandidate = _settingManagerPresenter.ConfigCandidate;
            bool _isCameraConfigChanged = _settingManagerPresenter.Cam2DSettingManager.Camera2DBundleModified()
                                    || configCandidate.CameraConfigs.Count != _config.CameraConfigs.Count;
            _config = configCandidate;
            SaveConfig();

            Logger.FileLoglevelFrom = _config.MinimumFileLogLevel;
            Logger.GuiLoglevelFrom = _config.MinimumUiLogLevel;
            if (_isCameraConfigChanged)
            {
                var camBundleToAdd = _config.CameraConfigs.Keys.Except(_camParamDict.Keys).ToArray();
                var camBundleToModify = _config.CameraConfigs.Keys.Intersect(_camParamDict.Keys).ToArray();
                var camBundleToDelete = _camParamDict.Keys.Except(_config.CameraConfigs.Keys).ToArray();
                UpdateCameraParametersFromConfig(camBundleToAdd, camBundleToModify, camBundleToDelete);
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
                    await InitializePlc();
                }
                else
                {
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
            _camComm.StopCamera();
            //_pylonComm.DisConnectCamera();
        }

        private async void View_ScanPointRequsted(object sender, EventArgs e)
        {
            _view.SetStartCameraButton = false;
            Logger.Debug("Call [Camera Start]");
            await StartCameraAsync();

            _view.LhImage = _camComm.GetImage(InspectionLocation.LH1);
            _view.RhImage = _camComm.GetImage(InspectionLocation.RH1);
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
                if (!_config.GetCarTypeList().Contains(e.CarType))
                {
                    Logger.Warning($"Lang.Msgs.InvalidCarType: ({_plcComm.CarType})");
                    return;
                }

                Logger.Info($"cartype : {e.CarType} // seqnum : {e.CarSeq} // bodynum : {e.BodyNumber}");
                ChangeCarType(e.CarType);
                UpdatePlcInspectionInfo(e.CarType, e.CarSeq, e.BodyNumber);
                Logger.Debug("Call [Camera Connect]");
                _lightComm.WriteLightState(true);

                if (!_camComm.IsConnected)
                {
                    var currentCam = _config[-1].Camera;
                    _camComm.Connect(_camParamDict[currentCam]);
                }
                Logger.Debug("Complete [Camera Connect]");
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
                await _camComm.StartCamera(_camParamDict[_config[-1].Camera]);
                
                int ret = await _plcComm.SendPlcStatusAsync(PlcSignalForLoadingBox.P1_COMPLETED, true, 100, 10);
                
                if (ret != 0)
                {
                    Logger.Info("SEND P1 COMPLETE FAIL");
                }
                else
                {
                    Logger.Info("SEND P1 COMPLETE SUCCEED");
                }
                // 
                _view.LhImage = _camComm.GetImage(InspectionLocation.LH1);
                _view.RhImage = _camComm.GetImage(InspectionLocation.RH1);
                
                ret = await _plcComm.SendPlcStatusAsync(PlcSignalForLoadingBox.VISION_OK, true, 100, 10);
                if (ret != 0)
                {
                    Logger.Info("SEND OK FAIL");
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
            Logger.Debug("Complete [Camera Start]");
        }

        private async Task<bool> StartCameraAsync()
        {
            if (_isRunningCamera)
            {
                return false;
            }

            if (_camComm == null)
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
                await Task.Run(() => _camComm.StartCamera(_camParamDict[_config[-1].Camera]));
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
            if (_camComm == null || cameraName == null)
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
                _camComm.Connect(_camParamDict[cameraName]);
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
                    var checkerBoardImageStructs = _carTypeToMasterDataset[carType][ImageType.CheckerBoard].ToArray();
                    _engine.LoadCharucoBoardConfig(checkerBoardImageStructs, checkerBoardImageStructs.Length);
                    var masterImageStructs = _carTypeToMasterDataset[carType][ImageType.MasterImage].ToArray();
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
            _view.CarType = carType;
            _view.CarSeq = seqNum;
            _view.BodyNum = bodyNum;
        }

        private bool ChangeCarType(int carType)
        {
            _config.RecentlyUsedCar = carType;
            _currentCar = carType;
            SaveConfig();
            Logger.Info($"Lang.Msgs.CarTypeChanged: {carType}");
            return true;
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

            _camComm?.Dispose();
            _camComm = CameraCommunicationManager.CreateCameraCommunicator(selectedCamera, null) as CameraCommunicatorForLoadingBox;
            if (_camComm == null)
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
                _modifiedCameraBundleDict = _settingManagerPresenter.Cam2DSettingManager.ModifiedCamera2DBundles;
                SetNewCameraParametersFromConfig(cameraBundleToAdd);
                UpdateCameraParametersFromConfig(cameraBundleToModify);
                DeleteCameraParametersFromConfig(cameraBundleToDelete);
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
                if (!_camParamDict.ContainsKey(camBundleName))
                {
                    _camParamDict[camBundleName] = new ConcurrentDictionary<InspectionLocation, CameraParameter>();
        
                    foreach (var kvp in camBundleConfig)
                    {
                        _camParamDict[camBundleName][kvp.Key] = new CameraParameter(kvp.Value);
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
                            _camParamDict[camBundleName][location].AdjustCameraParameters(newParameters);
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
                if (!_camParamDict.ContainsKey(camBundleName))
                {
                    throw new ArgumentOutOfRangeException(camBundleName);
                }
                if (!_camParamDict.TryRemove(camBundleName, out var existingConfig))
                {
                    Logger.Error($"Removing Camera Parameter Setting From Presenter Failed {camBundleName}");
                }
            }
        }
        private bool LoadMasterDatasetFromConfigPaths()
        {
            Stopwatch sw = Stopwatch.StartNew();
            _updateMasterDataSem.Wait();
            try
            {
                foreach (var carTypeToConfig in _config.ConfigDict)
                {
                    string masterImageRootPath = carTypeToConfig.Value.MasterImageRootFolderPath;
                    bool getMasterImageFilePathsSucceed = GetFilePathsByInspectionLocation(masterImageRootPath, out var locToMasterImagePaths);

                    string checkerBoardRootPath = _config.CheckerBoardRootFolderPath;
                    bool getCheckerBoardFilePathsSucceed = GetFilePathsByInspectionLocation(checkerBoardRootPath, out var locToCheckerBoardfiles);

                    string calibrationDataPath = _config.CalibrationDataRootPath;
                    bool getCalibrationFilePathsSucceed = GetFilePathsByInspectionLocation(calibrationDataPath, out var locToCalibrationFiles);

                    string zDegreeDataPath = _config.ZRotationPerLocationDataFilePath;
                    bool getZDegreeDataSucceed = TryDeserializeFromPath<Dictionary<InspectionLocation, float>>(zDegreeDataPath, out var zDegrees);
                    
                    bool getOfflineDataSucceed = true;
                    if (_config.OfflineMode)
                    {
                        getOfflineDataSucceed = InitializeOfflineSensor();
                    }

                    if (!getMasterImageFilePathsSucceed || !getCheckerBoardFilePathsSucceed || 
                        !getCalibrationFilePathsSucceed || !getZDegreeDataSucceed || !getOfflineDataSucceed)
                    {
                        Logger.Error($"Failed Refreshing Master Dataset. Master Image : {getMasterImageFilePathsSucceed}. " +
                            $"CheckerBoard : {getCheckerBoardFilePathsSucceed}. Calibration : {getCalibrationFilePathsSucceed}. " +
                            $"ZDegree : {getZDegreeDataSucceed}. OfflineData : {getOfflineDataSucceed}");

                        return false;
                    }
                    string shiftModelFilePath = carTypeToConfig.Value.ShiftModelPath;
                    //string detectModelFilePath = carTypeToConfig.Value.DetectModelPath;

                    int carType = carTypeToConfig.Key;
                    if (!_carTypeToMasterDataset.ContainsKey(carType))
                    {
                        _carTypeToMasterDataset[carType] = new Dictionary<ImageType, List<MasterPathStruct>>()
                        { 
                            [ImageType.MasterImage] = new List<MasterPathStruct>(),
                            [ImageType.CheckerBoard] = new List<MasterPathStruct>()
                        };
                    }

                    List<MasterPathStruct> masterImageStructs = new List<MasterPathStruct>();
                    List<MasterPathStruct> checkerBoardStructs = new List<MasterPathStruct>();
                    string cameraGroupName = carTypeToConfig.Value.Camera;
                    foreach (InspectionLocation registeredLoc in _cameraParameterDict[cameraGroupName].Keys)
                    {
                        if (TryDeserializeFromPath<CalibrationData>(locToCalibrationFiles[registeredLoc], out var calibrationData))
                        {
                            masterImageStructs.Add(MasterPathStruct.MasterImageStruct(carType, locToMasterImagePaths[registeredLoc], shiftModelFilePath, registeredLoc, 
                            calibrationData, zDegrees[registeredLoc])); 
                            checkerBoardStructs.Add(MasterPathStruct.CharucoImageStruct(carType, locToCheckerBoardfiles[registeredLoc], shiftModelFilePath, registeredLoc, 
                            calibrationData, zDegrees[registeredLoc]));
                        }
                        else
                        {
                            Logger.Error($"Failed Refreshing Master Dataset. Failed while parsing Calibration Data From Path : {locToCalibrationFiles[registeredLoc]}");
                            return false;
                        }
                    }

                    _carTypeToMasterDataset[carType][ImageType.MasterImage] = masterImageStructs;
                    _carTypeToMasterDataset[carType][ImageType.CheckerBoard] = checkerBoardStructs;
                }
            }
            finally
            {
                _updateMasterDataSem.Release();
            }
            Logger.Info($"Loading Master Data From File Path Complete, Took {sw.Elapsed}");
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
        private bool TryDeserializeFromPath<T>(string path, out T deserializedInstance) where T: class
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
                deserializedInstance = null;
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
                deserializedInstance = null;
                return false;
            }
            deserializedInstance = data;
            return true;
        }
        private bool InitializeOfflineSensor()
        {
            foreach (int carType in _config.ConfigDict.Keys)
            {
                string offlineDataPath = _config[carType].MasterImageRootFolderPath;
                string offlineDataPathByCarType = Path.Combine(offlineDataPath, carType.ToString());
                bool getOfflineDataSucceed = GetFilePathsByInspectionLocation(offlineDataPathByCarType, out var locToOfflineData);
                if (!getOfflineDataSucceed)
                {
                    Logger.Error($"Failed Retrieving Offline Images for Cartype {carType}. Try Reconfiguring Offline Image Path and Try Again");
                    return false;
                }
                _offlineImageHandler = new OfflineImageHandler(locToOfflineData?.Keys.ToArray());
                foreach (var kvp in locToOfflineData)
                {
                    _offlineImageHandler.LoadBitMapFromPath(carType, kvp.Key, kvp.Value);
                }
                Logger.Info($"OfflineMode: Load Offline Image for Cartype: {carType} Succeeded");
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

        private void UpdateUiByConfig()
        {
            _view.SetCarTypeList(_config.GetCarTypeAndNameList(), _config.RecentlyUsedCar);
        }

        private async Task<bool> InitializeShiftRobotAsync(Dictionary<RobotAttribute, string> robotConfig)
        {
            return false;
        }

        public Task<bool> ReadyRobotsAysnc()
        {
            return Task.Run(() =>
            {
                try
                {
                    Stopwatch sw = Stopwatch.StartNew();
                    var installRobotConfig = _config.RobotConfigs[_config[-1].Robot];
                    bool ret = ConfigureShiftRobot(installRobotConfig, true);
                    sw.Stop();

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

        public bool ConfigureShiftRobot(Dictionary<RobotAttribute, string> robotConfig, bool wantRemake = false)
        {
            if (wantRemake)
            {
                _installRobotComm?.Dispose();
                _installRobotComm = null;
            }

            if (_installRobotComm == null)
            {
                var robotMaker = robotConfig[RobotAttribute.Maker].ToEnum<RobotMaker>();
                _installRobotComm = RobotCommMaker.Make(robotMaker, robotConfig);

                if (_installRobotComm == null)
                {
                    Logger.Error($"Robot Not Supported");
                    return false;
                }
            }
            return true;
        }

        private async Task<bool> CalculateShiftPointAsync(bool offlineMode = false)
        {
            ImageStruct[] structForShiftValueArray;
            if (offlineMode)
            {
                structForShiftValueArray = _offlineImageHandler?.GetImageStructsArray();
            }
            else
            {
                structForShiftValueArray = _camComm.GetImageStructsArray(_currentCar);
            }
            //ImageStruct[] structForShiftValueArray = _cameraComm.GetImageStructsArray(_currentCarName, _cameraParameterDict[_currentCarName].Keys.ToArray());
            if (structForShiftValueArray.Length == 0)
            {
                Logger.Error($"Failed Getting Any Bitmaps");
                return false;
            }

            bool calculatePoseSuccess = false; 
            Stopwatch stopwatch = Stopwatch.StartNew();
            await Task.Run(() =>
            {
                calculatePoseSuccess = _engine.PoseAdjustment2D(structForShiftValueArray, structForShiftValueArray.Count());
            }); 

            if (calculatePoseSuccess)
            {
                Logger.Info($"Calculate Shift Value Complete, Took {stopwatch.Elapsed}");
                foreach (ImageStruct imgStruct in structForShiftValueArray)
                {
                    Logger.Info($"Computed Shift Value: Location: {imgStruct.CameraLocation}, TX: {imgStruct.Shift6D.Tx}, TY: {imgStruct.Shift6D.Ty}");
                    // If Location on FRT
                    if (imgStruct.CameraLocation < InspectionLocation.RearLh4)
                    {
                        _robotPoseFront[imgStruct.CameraLocation] = imgStruct.GetRobotPose();
                    }
                    else
                    {
                        _robotPoseRear[imgStruct.CameraLocation] = imgStruct.GetRobotPose();
                    }
                }
                return true;
            }
            else
            {
                Logger.Error($"Calculating Pose Failed");
                return false;
            }
        }

        public async Task<bool> WriteRobotPoses(RobotMaker robotMaker, List<RobotPose> robotPoses, List<string> variableNames)
        {
            if (robotPoses?.Count != variableNames?.Count)
            {
                Logger.Error($"Writing Pose Failed. Poses and Variable count should be same. Pose Count: {robotPoses.Count}\t Variable Count: {variableNames?.Count}"); 
                return false;
            }
            
            if (robotMaker == RobotMaker.YASKAWA)
            {
                await _installRobotComm?.DisconnectAsync();
            }
            try
            {
                for (int i = 0; i < robotPoses.Count; i++)
                {
                    Logger.Debug($"Writing Poses ([{i}] {robotPoses[i]} -> {variableNames[i]})");
                    var ret = await _installRobotComm.WriteRobotPoseAsync(robotPoses[i], variableNames[i]);

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
        #endregion
        #region Enums
        enum ProgramState
        {

        }
        #endregion
    }
}
