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
        bool OnManualPass { get; }
        #endregion

        #region Event Handlers
        event EventHandler<ModeChangedEventArgs> ChangeModeRequested;
        event EventHandler ConnectCameraRequested;
        event EventHandler<StartWithModifierEventArgs> ShowSettingManagerRequested;
        event EventHandler ScanPointRequested;
        event EventHandler<FormClosingEventArgs> ProgramCloseRequested;
        event EventHandler<ChangeLightStateEventArgs> LightStateChangeRequested;
        event EventHandler DisconnectCameraRequested;
        event EventHandler MainFormLoadRequested;
        event EventHandler CarTypeChanged;
        event EventHandler<SaveMasterDataEventArgs> ReadInstallPoseRequested;
        event EventHandler<SaveMasterDataEventArgs> ReadScanPoseRequested;
        event EventHandler<double[]> WriteTxTyRzRequested;
        event EventHandler CheckWrittenShiftPoseRequested;
        event EventHandler<ImagePathEventArgs> ShowScreenShotRequested;
        event EventHandler ResetNgListRequested;
        event EventHandler CaptureCheckerboardRequested;
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
        void SetCalculatedShiftPose(double[] poses);
        void ShowOnDataGrid(BindingSource bindingSource);
        void Init();
        #endregion
    }
}

#region EventArgs
public class SaveMasterDataEventArgs : EventArgs
{
    public bool SaveMaster { get; set; }
    public SaveMasterDataEventArgs(bool saveMaster)
    {
        SaveMaster = saveMaster;
    }
}

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

public class ImagePathEventArgs : EventArgs
{
    public string ImagePath { get; set; }
    public ImagePathEventArgs(string imagePath)
    {
        ImagePath = imagePath;
    }
}
#endregion
