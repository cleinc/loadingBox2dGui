using System;
using System.Collections.Generic;
using System.Reflection;
using loadingBox2dGui.views;
using loadingBox2dGui.models;
using CoPick.Logging;
using CoPick.Plc;
using System.Threading.Tasks;
using CoPick.Setting;
using System.Diagnostics;
using System.Windows.Forms;

namespace loadingBox2dGui.presenters
{
    public class MainPresenter
    {
        private static readonly LogHelper Logger = LogHelper.Logger;
        
        private readonly IMainForm _view;
        private PlcCommunicatorForLoadingBox _plcComm;
        private bool _isPlcEventHandlersRegistered = false;
        public MainPresenter(IMainForm view)
        {
            _view = view;
            _view.ProgramCloseRequested += View_ProgramCloseRequested;
            CreatePlcCommInstance("Tk1MelsecCommunicator");
            Console.WriteLine($"plc comm is empty {_plcComm == null}");
            InitializePlc();

            //bool result = InitializePlc();

            //if (!result)
            //{
            //    Logger.Warning("Unable to Connect To PLC");
            //}
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

        private void PlcComm_LocalizerVisionStartReceived(object sender, EventArgs e)
        {
            Logger.Info("Plc Start Received");
        }

        private void PlcComm_VisionReset(object sender, EventArgs e)
        {
            Logger.Info("Plc Reset Received");
        }

        private void PlcComm_VisionEnd(object sender, EventArgs e)
        {
            Logger.Info("Plc End Received");
            _view.DisplayVisionResult(VisionStatus.OK);
        }

        private void PlcComm_CarTypeUpdate(object sender, VisionUpdateEventArgs e)
        {
            Logger.Info("Plc Update Received");
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

                await _plcComm.ConnectAsync();
                if (_plcComm.IsConnected)
                {
                    RegisterPlcEventHandler();
                    _view.PlcInfo = "MELSEC";
                }
                Console.WriteLine($"Is Connected {_plcComm.IsConnected}");
                _view.IsPlcConnected = _plcComm.IsConnected;
                _view.RefreshPlcStatus();
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

        private bool CreatePlcCommInstance(string selectedPlc)
        {
            if (selectedPlc == null)
            {
                Logger.Error($"Lang.Msgs.NotSupportedPlcCommunicator {selectedPlc}");
                return false;
            }
            Console.WriteLine("Step 1");
            Console.WriteLine(selectedPlc);

            _plcComm?.Dispose();
            _plcComm = PlcCommunicationManager.CreatePlcCommunicator(selectedPlc, new Dictionary<PlcAttribute, string>() { [PlcAttribute.Model] = "MELSEC"}) as PlcCommunicatorForLoadingBox;
            if (_plcComm == null)
            {
                Logger.Error("Lang.Msgs.NotFindPlcCommunicator");
                return false;
            }

            Console.WriteLine("Step 2");
            var modelAttr = _plcComm.GetType().GetCustomAttribute<PlcModelAttribute>();
            if (modelAttr == null)
            {
                Logger.Error("Lang.Msgs.HaveNoPlcModelInfo");
                return false;
            }

            Console.WriteLine("Step 3");
            _isPlcEventHandlersRegistered = false;
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

            _plcComm.CarTypeUpdate += PlcComm_CarTypeUpdate;
            _plcComm.VisionEnd += PlcComm_VisionEnd;
            _plcComm.VisionReset += PlcComm_VisionReset;
            _plcComm.VisionStart += PlcComm_LocalizerVisionStartReceived;
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
