using System;
using System.Collections.Generic;
using System.Reflection;
using loadingBox2dGui.views;
using loadingBox2dGui.models;
using CoPick.Logging;
using CoPick.Plc;
using System.Threading.Tasks;
using loadingBox2dGui.models;
using CoPick.Setting;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace loadingBox2dGui.presenters
{
    public class MainPresenter
    {
        private static readonly LogHelper Logger = LogHelper.Logger;
        
        private readonly IMainForm _view;
        private Config _config;
        private PlcCommunicatorForLoadingBox _plcComm;
        private LightCommunicatorForLoadingBox _lightComm;
        private CameraCommunicatorForLoadingBox _camComm;
        private bool _isPlcEventHandlersRegistered = false;
        private (Bitmap, Bitmap) bmps;
        public MainPresenter(IMainForm view, Config config)
        {
            _view = view;
            _config = config;

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
        }

        private async void View_ChangeModeRequested(object sender, ChangeModeEventArgs e)
        {
            await InitializePlc();
        }

        private void View_DisconnectLhCameraRequested(object sender, EventArgs e)
        {
            _camComm.StopCamera();
            //_pylonComm.DisConnectCamera();
        }

        private async void View_ScanPointRequsted(object sender, EventArgs e)
        {
            Logger.Debug("Call [Camera Start]");

            bmps = await _camComm.StartCamera();
            _view.LhImage = bmps.Item1;
            //_view.RhImage = bmps.Item2;
            Logger.Debug("Complete [Camera Start]");
        }

        private void View_ConnectCameraRequested(object sender, EventArgs e)
        {
            Logger.Debug("Call [Camera Connect]");
            _camComm.Connect();
            Logger.Debug("Complete [Camera Connect]");
        }

        private void View_LightStateChangedRequested(object sender, ChangeLightStateEventArgs e)
        {
            _lightComm.WriteLightState(e.State);
        }

        private void View_ProgramCloseRequested(object sender, FormClosingEventArgs e)
        {
            _view.RefreshPlcStatus();
            if (MessageBox.Show("Are you sure to Exit Program?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //_config.DarkMode = _view.DarkModeChecked;
                //ConfigFileManager.SaveToFile(_config, ConfigFileManager.GetConfigFilePath());

                _plcComm?.Dispose();

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

        private void PlcComm_PlcDisconnected(object sender, EventArgs e)
        {
            Logger.Info("Plc Disconnected Received");
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
                
                _camComm.Connect();
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
                bmps = await _camComm.StartCamera();

                int ret = await _plcComm.SendPlcStatusAsync(PlcSignalForLoadingBox.P1_COMPLETED, true, 100, 10);
                if (ret != 0)
                {
                    Logger.Info("SEND P1 COMPLETE FAIL");
                }
                else
                {
                    Logger.Info("SEND P1 COMPLETE SUCCEED");
                }

                _view.LhImage = bmps.Item1;
                _view.RhImage = bmps.Item2;
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
            if (_plcComm.VisionPass)
            {
                int ret = await _plcComm.SendPlcStatusAsync(PlcSignalForLoadingBox.VISION_PASS, true, 100, 10);
                if (ret != 0)
                {
                    Logger.Info("SEND PASS FAIL");
                }
                else
                {
                    Logger.Info("SEND PASS SUCCEED");
                }
                _view.DisplayVisionResult(VisionStatus.OK);
            }
            else
            {
                Logger.Info($"not vision pass");
            }
        }

        private void PlcComm_VisionReset(object sender, EventArgs e)
        {
            Logger.Info("Plc Reset Received");
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
            if (_plcComm != null)
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
            if (selectedPlc == null || !_config.PlcConfig.TryGetValue(selectedPlc, out var plcConf))
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
            if (selectedLight == null || !_config.LightConfig.TryGetValue(selectedLight, out var lightConf))
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
            if (selectedCamera == null || !_config.CameraConfig.TryGetValue(selectedCamera, out var cameraConf))
            {
                Logger.Error($"Lang.Msgs.NotSupportedCameraCommunicator {selectedCamera}");
                return false;
            }

            _camComm?.Dispose();
            _camComm = CameraCommunicationManager.CreateCameraCommunicator(selectedCamera, cameraConf) as CameraCommunicatorForLoadingBox;
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
        #endregion
        #region Enums
        enum ProgramState
        {

        }
        #endregion
    }
}
