using CoPick.Logging;
using CoPick.Setting;
using loadingBox2dGui.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loadingBox2dGui.views
{
    public interface ISettingManagerView
    {
        int ConfiguringCarType { get; set; }
        object TaskPropertyGridDataSource { set; }
        string Plc { get; set; }
        string Camera { get; set; }
        string ShiftModelPath { get; set; }
        string CheckerBoardImageRootFolderPath { get; set; }
        string MasterImageRootFolderPath { get; set; }
        string CalibrationDataRootFolderPath { get; set; }
        string CameraTcpDataRootFolderPath { get; set; }
        string Robot { get; set; }
        bool IsControlDisposed { get; }
        string SelectedLanguage { get; set; }
        string LogPath { get; set; }

        bool CanLogManagerScheduleBeDeleted { set; }
        DateTime LogManagerScheduleStartTime { get; }
        int LogPeriodCount { get; }
        int ImgPeriodCount { get; }
        int CsvPeriodCount { get; }

        LogLevel FileLogLevel { get; set; }
        LogLevel UiLogLevel { get; set; }
        bool IsFactoryResetPossible { set; }

        event EventHandler CarTypeAddRequested;
        event EventHandler CarTypeRemoveRequested;
        event EventHandler CarTypeCopyRequested;
        event EventHandler CameraChanged;
        event EventHandler PlcChanged;
        event EventHandler LanguageChanged;
        event EventHandler ConfiguringCarTypeChanged;
        event EventHandler<SettingChangedEventArgs> SettingChanged;
        event EventHandler FileLogLevelChanged;
        event EventHandler UiLogLevelChanged;
        event EventHandler LogPathChanged;
        event EventHandler FactorySettingSaveAsked;
        event EventHandler FactoryResetAsked;
        event EventHandler CameraMaxScanTimeChanged;
        event EventHandler EndRequested;
        event EventHandler LogManagerArgsRegisterAsked;
        event EventHandler LogManagerArgsDeleteAsked;
        event EventHandler<SettingTabChangeEventArgs> SettingTabChangeRequested;
        event EventHandler RobotChanged;
        event EventHandler <ModelSettingPathChangeEventArgs> ModelSettingPathChangeRequested;
        event EventHandler UpdateMasterDataRequested;
        void SetRobotList(List<string> robotList, string selectedRobot = null);
        void SetCarTypeList(BindingList<CarTypeAndName> carTypeList, int selectedCarType = -1);
        void SetCameraList(List<string> cameraList, string selectedCamera = null);
        void SetLightList(List<string> lightList, string selectedLight = null);
        void SetPlcList(List<string> plcList, string selectedPlc);
        void SetFileLogLevelList(Array LogLevels, LogLevel selectedLevel);
        void SetUiLogLevelList(Array LogLevels, LogLevel selectedLevel);
        void SetSupportedLanguageList(List<string> languageList, string selectedLanguage = null);
        void ShowMessage(string msg, string title);
        bool ConfirmUserChoice(string msg, string title);
        void RefreshTaskGrid();
        void Localize();
        void SetUiForAutoMode();
        void SetUiForSetMode();
        void SetUiForManualMode();

        void ResetInvalidValue(PropertyDescriptor propertyDescriptor, object component, object value, string msg);
        void ShowSettingManager(bool isBlocking);
        void UpdateLogManagerScheduleToUi(int logPeriod, int imgPeriod, int csvPeriod, DateTime startDateTime);
    }
    public enum SettingTab
    {
        Task, 
        Robot, 
        Camera, 
        Light, 
        Log
    }
    
    public class SettingTabChangeEventArgs : EventArgs
    {
        public SettingTab SettingTab { get; private set; }
        public SettingTabChangeEventArgs (SettingTab settingTab)
        {
            SettingTab = settingTab;
        }
    }

    public enum ModelPathType
    {
       CheckerBoardRootFolderPath,
       MasterImageRootFolderPath,
       CalibrationDataRootFolderPath,
       CameraTcpDataFilePath,
       ShiftModelFilePath,
    }

    public class ModelSettingPathChangeEventArgs : EventArgs
    {
        public ModelPathType ModelPathType { get; private set; }
        public string NewPath { get; private set; }
        public ModelSettingPathChangeEventArgs(ModelPathType modelDataType, string newPath)
        {
            ModelPathType = modelDataType;
            NewPath = newPath;
        }
    }
}
