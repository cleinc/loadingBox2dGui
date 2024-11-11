using CoPick.Logging;
using CoPick.Plc;
using CoPick.Setting;
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
        private CameraCommunicatorForLoadingBox _camComm;
        private bool _isPlcEventHandlersRegistered = false;
        private CargoBox2DSettingManagerPresenter _settingManagerPresenter;
        private object _camSettingLock = new object();
        private Dictionary<string, Dictionary<InspectionLocation, bool>> _modifiedCameraBundleDict = new Dictionary<string, Dictionary<InspectionLocation, bool>>();
        private ConcurrentDictionary<string, ConcurrentDictionary<InspectionLocation, CameraParameter>> _camParamDict = new ConcurrentDictionary<string, ConcurrentDictionary<InspectionLocation, CameraParameter>>();
        public MainPresenter(IMainForm view, CargoBox2DSettingManagerPresenter cargoBox2DSettingManagerPresenter, Config config)
        {

            _view = view;
            _config = config;
            _mode = OperationMode.Auto;
            _settingManagerPresenter = cargoBox2DSettingManagerPresenter;

            CreateLightCommInstance(_config.Light);
            CreateCameraCommInstance(_config.Camera);
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
            _settingManagerPresenter.SettingChangeConfirmed += SettingManagerPresenter_SettingChangeConfirmed;
        }

        private void SettingManagerPresenter_SettingChangeConfirmed(object sender, EventArgs e)
        {
            bool isPlcChanged = (_config.Plc != _settingManagerPresenter.ConfigCandidate.Plc) ||
                                _settingManagerPresenter.ChangeTracker.IsPlcSettingModified;
            _settingManagerPresenter.ConfigCandidate.RecentlyUsedCar = _config.RecentlyUsedCar;
            Config configCandidate = _settingManagerPresenter.ConfigCandidate;
            bool _isCameraConfigChanged = _settingManagerPresenter.Cam2DSettingManager.Camera2DBundleModified()
                                    || configCandidate.CameraConfigs.Count != _config.CameraConfigs.Count;
            _modifiedCameraBundleDict = _settingManagerPresenter.Cam2DSettingManager.ModifiedCamera2DBundles;
            _config = configCandidate;
            SaveConfig();

            Logger.FileLoglevelFrom = _config.MinimumFileLogLevel;
            Logger.GuiLoglevelFrom = _config.MinimumUiLogLevel;
            var camBundleName = _config[-1].Camera;
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
            Logger.Debug("Call [Camera Start]");

            await _camComm.StartCamera(_camParamDict[_config[-1].Camera]);
            var currentCamBundle = _config.CameraConfigs[_config[-1].Camera];
            _view.LhImage = _camComm.GetImage(InspectionLocation.LH);
            _view.RhImage = _camComm.GetImage(InspectionLocation.RH);
            Logger.Debug("Complete [Camera Start]");
        }

        private void View_ConnectCameraRequested(object sender, EventArgs e)
        {
            if (!_camComm.IsConnected)
            {
                Logger.Debug("Call [Camera Connect]");
                var currentCamBundle = _config[-1].RegisteredCameraSerials;
                _camComm?.Connect(currentCamBundle);
                Logger.Debug("Complete [Camera Connect]");
            }
        }

        private async void View_LightStateChangedRequested(object sender, ChangeLightStateEventArgs e)
        {
            var result = await Task.Run(() => _lightComm?.WriteLightState(e.State));
        }

        private void View_ProgramCloseRequested(object sender, FormClosingEventArgs e)
        {
            _plcComm?.Disconnect();
            _view.RefreshPlcStatus();
            if (MessageBox.Show("Are you sure to Exit Program?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //_config.DarkMode = _view.DarkModeChecked;
                //ConfigFileManager.SaveToFile(_config, ConfigFileManager.GetConfigFilePath());

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
                Logger.Info($"cartype : {e.CarType} // seqnum : {e.CarSeq} // bodynum : {e.BodyNumber}");
                UpdatePlcInspectionInfo(e.CarType, e.CarSeq, e.BodyNumber);
                Logger.Debug("Call [Camera Connect]");
                _lightComm.WriteLightState(true);

                if (!_camComm.IsConnected)
                {
                    var currentCamBundle = _config[-1].RegisteredCameraSerials;
                    _camComm.Connect(currentCamBundle);
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

                _view.LhImage = _camComm.GetImage(InspectionLocation.LH);
                _view.RhImage = _camComm.GetImage(InspectionLocation.RH);
                
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

        private async void PlcComm_VisionEnd(object sender, EventArgs e)
        {
            Logger.Info("Plc End Received");
            _lightComm?.WriteLightState(false);
            _view.DisplayVisionResult(VisionStatus.OK);
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
        private bool InitializeModelSettings()
        {
            return true;
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
        private bool StartCamera()
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
            return Task.Run(() =>
            {
                lock (_camSettingLock)
                {
                    _modifiedCameraBundleDict = _settingManagerPresenter.Cam2DSettingManager.ModifiedCamera2DBundles;
                    SetNewCameraParametersFromConfig(cameraBundleToAdd);
                    UpdateCameraParametersFromConfig(cameraBundleToModify);
                    DeleteCameraParametersFromConfig(cameraBundleToDelete);
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
                if (!_camParamDict.ContainsKey(camBundleName))
                {
                    _camParamDict[camBundleName] = new ConcurrentDictionary<InspectionLocation, CameraParameter>();
        
                    foreach (var kvp in camBundleConfig)
                    {
                        _camParamDict[camBundleName][kvp.Key] = new CameraParameter(kvp.Value);
                    }
                }

                foreach (var kvp in _config.ConfigDict)
                {
                    var config = kvp.Value;
                    if (config.Camera == camBundleName)
                    {
                        config.RegisterCameras(_config.CameraConfigs[camBundleName]);
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

                foreach (var kvp in _config.ConfigDict)
                {
                    var config = kvp.Value;
                    if (config.Camera == camBundleName)
                    {
                        config.RegisterCameras(_config.CameraConfigs[camBundleName]);
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
        #endregion
        #region Enums
        enum ProgramState
        {

        }
        #endregion
    }
}
