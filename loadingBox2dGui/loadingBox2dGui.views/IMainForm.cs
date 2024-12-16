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
        string PlcInfo { set; }
        int CarType { get; set; }
        bool IsModeChanging { set; }
        string BodyNum { get; set; }
        string CarSeq { get; set; }
        Image LhImage { set; }
        Image RhImage { set; }
        bool IsPlcConnected { get; set; }
        bool SetLightState { set; }
        bool SetStartCameraButton { set; }
        bool SetConnectCameraButton { set; }
        bool SetCaptureCameraButton { set; }
        #endregion

        #region Event Handlers
        event EventHandler<ModeChangedEventArgs> ChangeModeRequested;
        event EventHandler ConnectCameraRequested;
        event EventHandler<StartWithModifierEventArgs> ShowSettingManagerRequested;
        event EventHandler CalculateRequested;
        event EventHandler UpdateRequested;
        event EventHandler GetReferenceDataPathRequested;
        event EventHandler GetHandEyeCalibrationFilePathRequested;
        event EventHandler ScanPointRequsted;
        event EventHandler<FormClosingEventArgs> ProgramCloseRequested;
        event EventHandler<ChangeLightStateEventArgs> LightStateChangeRequested;
        event EventHandler DisconnectLhCameraRequested;
        event EventHandler MainFormLoadRequested;
        event EventHandler CarTypeChanged;
        event EventHandler<StartWithModifierEventArgs> CaptureRequested;
        event EventHandler ReadInstallPoseRequested; 
        event EventHandler ReadScanPoseRequested;
        event EventHandler<double[]> WriteShiftPoseRequested;
        event EventHandler CheckWrittenShiftPoseRequested;
        event EventHandler ScanPointUsingArucoRequested;
        #endregion

        #region Methods
        void DisplayVisionResult(VisionStatus visionStatus);
        void RefreshPlcStatus();
        void BlinkReadStatus(int time);
        void BlinkWriteStatus(int time);
        void UpdatePlcSignalLabel(PlcSignalForLoadingBox signal, string value);
        void TogglePlcSignalLabel(PlcSignalForLoadingBox signal, bool isOn);
        void SetUiToMode(OperationMode mode);
        void ResetToAutoMode();
        bool ValidatePassword();
        void SetCarTypeList(BindingList<CarTypeAndName> carTypeList, int selectedCarType = -1);
        void SetInspectionImage(InspectionLocation location, Image image);
        void SetReadScanPose(double[] poses); 
        void SetReadInstallPose(double[] poses); 
        void SetReadWrittenShiftPose(double[] poses); 
        #endregion
    }
}

#region EventArgs
public class ModeChangedEventArgs : StartWithModifierEventArgs
{
    public OperationMode Mode { get; private set; }
    public ModeChangedEventArgs(OperationMode programMode, bool hasFreePassTicket): base (hasFreePassTicket)
    {
        Mode = programMode;
    }
}

public class ChangeLightStateEventArgs : EventArgs
{
    public bool State { get; set; }
    public ChangeLightStateEventArgs(bool state)
    {
        State = state;
    }
}

public class StartWithModifierEventArgs : EventArgs
{
    public bool HasFreePassTicket { get; set; }

    public StartWithModifierEventArgs(bool hasFreePassTicket)
    {
        HasFreePassTicket = hasFreePassTicket; 
    }
}
#endregion
