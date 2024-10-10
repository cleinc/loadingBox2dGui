using CoPick.Setting;
using CoPick.Plc;
using loadingBox2dGui.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace loadingBox2dGui.views
{
    public interface IMainForm
    {
        #region Properties
        OperationMode ProgramMode { get; }
        string PlcInfo { set; }
        int CarType { get; set; }
        string BodyNum { set; }
        string CarSeq { set; }
        Image LhImage { set; }
        Image RhImage { set; }
        bool IsPlcConnected { get; set; }
        #endregion

        #region Event Handlers
        event EventHandler<ChangeModeEventArgs> ChangeModeRequested;
        event EventHandler ConnectCameraRequested;
        event EventHandler ShowSettingManagerRequested;
        event EventHandler CalculateRequested;
        event EventHandler UpdateRequested;
        event EventHandler GetReferenceDataPathRequested;
        event EventHandler GetHandEyeCalibrationFilePathRequested;
        event EventHandler ScanPointRequsted;
        event EventHandler<FormClosingEventArgs> ProgramCloseRequested;
        event EventHandler<ChangeLightStateEventArgs> LightStateChangeRequested;
        event EventHandler DisconnectLhCameraRequested;
        #endregion

        #region Methods
        void DisplayVisionResult(VisionStatus visionStatus);
        void RefreshPlcStatus();
        void BlinkReadStatus(int time);
        void BlinkWriteStatus(int time);
        void UpdatePlcSignalLabel(PlcSignalForLoadingBox signal, string value);
        void TogglePlcSignalLabel(PlcSignalForLoadingBox signal, bool isOn);
        #endregion
    }
}

#region EventArgs
public class ChangeModeEventArgs
{
    public OperationMode Mode { get; private set; }
    public bool HasFreePassTicket { get; set; }
    public ChangeModeEventArgs(OperationMode programMode, bool hasFreePassTicket = false)
    {
        Mode = programMode;
        HasFreePassTicket = hasFreePassTicket;
    }
}

public class ChangeLightStateEventArgs
{
    public bool State { get; set; }
    public ChangeLightStateEventArgs(bool state)
    {
        State = state;
    }
}
#endregion
