using CoPick.Logging;
using CoPick.Plc.Setting;
using CoPick.Robot.Setting;
using CoPick.Setting;
using CoPick.Setting.Presenters;
using loadingBox2dGui.models;
using loadingBox2dGui.presenters.SettingManagerPresenters;
using loadingBox2dGui.views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace loadingBox2dGui.presenters
{
    public class CargoBox2DSettingManagerPresenter
    {
        private OperationMode _mode;
        private readonly List<string> _langList;
        private string _factorySettingsFilePath = "./gifnoc";
        private readonly LogManagerScheduler _logManagerScheduler = new LogManagerScheduler();

        private ISettingManagerView _view;
        private readonly Type _typeOfView;
        private readonly RobotSettingManagerPresenter _robotSettingManagerPresenter;
        private readonly Camera2DBundleSettingManagerPresenter _camera2DBundleSettingManagerPresenter;
        private readonly PlcSettingManagerPresenter _plcSettingManagerPresenter;
        private readonly CopyCarTypeConfigPresenter _copyCarTypeConfigPresenter;
        private readonly LightSettingManagerPresenter _lightSettingManagerPresenter;
        private readonly AddCarTypePresenter _addCarTypePresenter;

        private Config _config;
        public Config ConfigCandidate
        {
            get => _config;
        }

        public Camera2DBundleSettingManagerPresenter Cam2DSettingManager => _camera2DBundleSettingManagerPresenter;
        public SettingChangeTracker ChangeTracker { get; set; }

        private readonly Dictionary<string, string> LangCodeToNameDict = new Dictionary<string, string>()
        {
            ["ko-KR"] = "한국어",
            ["en"] = "English"
        };

        private readonly Dictionary<string, string> LangNameToCodeDict = new Dictionary<string, string>()
        {
            ["한국어"] = "ko-KR",
            ["English"] = "en"
        };

        public event EventHandler SettingChangeConfirmed;
        public event EventHandler UpdateMasterDataFromConfigPathRequested;
        private int _currentCarType;
        private bool _modifiedDataPaths = false; 
        public bool ModifiedDataPaths => _modifiedDataPaths;
        private bool _isOpen = false; 
        public bool IsOpen => _isOpen;
        private readonly ICargoBox2DInspectionEngine _engine;
        public CargoBox2DSettingManagerPresenter(ISettingManagerView view, RobotSettingManagerPresenter robotSettingManagerPresenter,
                                       Camera2DBundleSettingManagerPresenter camera2DSettingManagerPresenter, PlcSettingManagerPresenter plcSettingManagerPresenter,
                                       CopyCarTypeConfigPresenter copyCarTypeConfigPresenter, AddCarTypePresenter addCarTypePresenter,
                                       LightSettingManagerPresenter lightSettingManagerPresenter, 
                                       List<string> langList, SettingChangeTracker settingChangeTracker, ICargoBox2DInspectionEngine engine)
        {
            _view = view;
            _typeOfView = view.GetType();
            _langList = langList;
            _engine = engine;
            ChangeTracker = settingChangeTracker;

            _robotSettingManagerPresenter = robotSettingManagerPresenter;
            _camera2DBundleSettingManagerPresenter = camera2DSettingManagerPresenter;
            _plcSettingManagerPresenter = plcSettingManagerPresenter;
            _lightSettingManagerPresenter = lightSettingManagerPresenter;
            _copyCarTypeConfigPresenter = copyCarTypeConfigPresenter;
            _addCarTypePresenter = addCarTypePresenter;

            _robotSettingManagerPresenter.AvailableRobotAdded += RobotSettingManagerPresenter_AvailableRobotAdded;
            _robotSettingManagerPresenter.AvailableRobotRemoved += RobotSettingManagerPresenter_AvailableRobotRemoved;
            _camera2DBundleSettingManagerPresenter.AvailableCamera2DAdded += CameraSettingManagerPresenter_AvailableCameraAdded;
            _camera2DBundleSettingManagerPresenter.AvailableCamera2DRemoved += CameraSettingManagerPresenter_AvailableCameraRemoved;
            _plcSettingManagerPresenter.AvailablePlcAdded += PlcSettingManagerPresenter_AvailablePlcAdded;
            _plcSettingManagerPresenter.AvailablePlcRemoved += PlcSettingManagerPresenter_AvailablePlcRemoved;
        }

        public void Start(OperationMode mode)
        {
            _mode = mode;
            _isOpen = true;
            _modifiedDataPaths = false;
            _config = ConfigFileManager.LoadFromFile<Config>(ConfigFileManager.GetConfigFilePath());
            _config.LockCarType();
            _currentCarType = _config.RecentlyUsedCar;
            ChangeTracker.Clear();

            _robotSettingManagerPresenter?.Start(mode, _config.RobotConfigs);
            _camera2DBundleSettingManagerPresenter?.Start(mode, _config.CameraConfigs);
            _plcSettingManagerPresenter?.Start(mode, _config.PlcConfigs, _config.Plc);
            _lightSettingManagerPresenter?.Start(mode, _config.LightConfigs);
            if (_view.IsControlDisposed)
            {
                _view = (ISettingManagerView)Activator.CreateInstance(_typeOfView,
                    _robotSettingManagerPresenter?.View,
                    _plcSettingManagerPresenter?.View,
                    _lightSettingManagerPresenter?.View,
                    _camera2DBundleSettingManagerPresenter?.View);
            }

            InitUi();
            UpdateUiByConfig();

            _view.CarTypeAddRequested += View_CarTypeAddRequested;
            _view.CarTypeRemoveRequested += View_CarTypeRemoveRequested;
            _view.CarTypeCopyRequested += View_CarTypeCopyRequested;
            _view.CameraChanged += View_CameraChanged;
            _view.PlcChanged += View_PlcChanged;
            _view.LanguageChanged += View_LanguageChanged;
            _view.ConfiguringCarTypeChanged += View_ConfiguringCarTypeChanged;
            _view.SettingChanged += View_SettingChanged;
            _view.UiLogLevelChanged += View_UiLogLevelChanged;
            _view.FileLogLevelChanged += View_FileLogLevelChanged;
            _view.FactorySettingSaveAsked += View_FactorySettingSaveAsked;
            _view.FactoryResetAsked += View_FactoryResetAsked;
            _view.LogPathChanged += View_LogPathChanged;
            _view.EndRequested += View_EndRequested;
            _view.RobotChanged += View_RobotChanged;
            _view.ModelSettingPathChangeRequested += View_ModelSettingPathChangeRequested;
            _view.LogManagerArgsRegisterAsked += View_LogManagerRegisterAsked;
            _view.LogManagerArgsDeleteAsked += View_LogManagerDeleteAsked;
            _view.SettingTabChangeRequested += View_SettingTabChangeRequested;
            _view.UpdateMasterDataRequested += View_UpdateMasterDataRequested;
            _view.ShowSettingManager(mode != OperationMode.Auto);
        }

        private void View_UpdateMasterDataRequested(object sender, EventArgs e)
        {
            UpdateMasterDataFromConfigPathRequested?.Invoke(sender, EventArgs.Empty);
        }

        public void Stop()
        {
            _isOpen = false;
            _robotSettingManagerPresenter?.Stop();
            _camera2DBundleSettingManagerPresenter?.Stop();
            _plcSettingManagerPresenter?.Stop();
            _lightSettingManagerPresenter?.Stop();

            _view.CarTypeAddRequested -= View_CarTypeAddRequested;
            _view.CarTypeRemoveRequested -= View_CarTypeRemoveRequested;
            _view.CarTypeCopyRequested -= View_CarTypeCopyRequested;
            _view.CameraChanged -= View_CameraChanged;
            _view.PlcChanged -= View_PlcChanged;
            _view.LanguageChanged -= View_LanguageChanged;
            _view.ConfiguringCarTypeChanged -= View_ConfiguringCarTypeChanged;
            _view.SettingChanged -= View_SettingChanged;
            _view.UiLogLevelChanged -= View_UiLogLevelChanged;
            _view.FileLogLevelChanged -= View_FileLogLevelChanged;
            _view.FactorySettingSaveAsked -= View_FactorySettingSaveAsked;
            _view.FactoryResetAsked -= View_FactoryResetAsked;
            _view.LogPathChanged -= View_LogPathChanged;
            _view.EndRequested -= View_EndRequested;
            _view.RobotChanged -= View_RobotChanged;
            _view.ModelSettingPathChangeRequested -= View_ModelSettingPathChangeRequested;
            _view.LogManagerArgsRegisterAsked -= View_LogManagerRegisterAsked;
            _view.LogManagerArgsDeleteAsked -= View_LogManagerDeleteAsked;
            _view.SettingTabChangeRequested -= View_SettingTabChangeRequested;
            _view.UpdateMasterDataRequested -= View_UpdateMasterDataRequested;
        }

        private void View_RobotChanged(object sender, EventArgs e)
        {
            ChangeInstallRobot(_view.Robot);
        }

        private void View_LogManagerDeleteAsked(object sender, EventArgs e)
        {
            _logManagerScheduler.DeleteSchedule();
            _view.UpdateLogManagerScheduleToUi(0, 0, 0, DateTime.Today);
            _view.CanLogManagerScheduleBeDeleted = false;
        }

        private async void View_LogManagerRegisterAsked(object sender, EventArgs e)
        {
            _logManagerScheduler.LogPreservePeriod = _view.LogPeriodCount;
            _logManagerScheduler.ImgPreservePeriod = _view.ImgPeriodCount;
            _logManagerScheduler.CsvPreservePeriod = _view.CsvPeriodCount;
            _logManagerScheduler.StartDateTime = _view.LogManagerScheduleStartTime;
            _logManagerScheduler.LogPath = GetLogFullPath();
            await _logManagerScheduler.RegisterScheduleAsync();
        }

        private string GetLogFullPath()
        {
            string logFullPath = Path.GetFullPath(_config.LogPath);
            if (logFullPath.Contains(" "))
            {
                logFullPath = $"\"{logFullPath}\"";
            }
            return logFullPath;
        }

        private async void View_EndRequested(object sender, EventArgs e)
        {
            if (ChangeTracker.IsSettingModified)
            {
                bool isOk = _view.ConfirmUserChoice($"Lang.MsgBoxFineLo.WantSaveSettings",
                                                    $"Lang.MsgBoxFineLo.SettingManagerTitle");
                if (isOk)
                {
                    if (_logManagerScheduler.IsUsing && GetLogFullPath() != _logManagerScheduler.LogPath)
                    {
                        _logManagerScheduler.LogPath = GetLogFullPath();
                        await _logManagerScheduler.RegisterScheduleAsync();
                    }

                    _config.Language = Thread.CurrentThread.CurrentUICulture.Name;
                    SettingChangeConfirmed?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(_config.Language);
                }
            }

            Stop();
        }

        private void View_LogPathChanged(object sender, EventArgs e)
        {
            string newLogPath = _view.LogPath;
            if (_config.LogPath != newLogPath)
            {
                try
                {
                    if (!Directory.Exists(newLogPath))
                    {
                        Directory.CreateDirectory(newLogPath);
                    }
                }
                catch (Exception ex)
                {
                    _view.ShowMessage($"Lang.MsgBoxFineLo.InvalidPath ex", "Lang.MsgBoxFineLo.WarningTitle");
                    _view.LogPath = _config.LogPath;
                    return;
                }

                ChangeTracker.NotifyChange("LogPath", _config.LogPath, newLogPath);
                _config.LogPath = newLogPath;
            }
        }

        private void View_FactorySettingSaveAsked(object sender, EventArgs e)
        {
            bool isOk = _view.ConfirmUserChoice("Lang.MsgBoxFineLo.WantSaveFactoryDefault",
                                                "Lang.MsgBoxFineLo.SettingManagerTitle");

            if (isOk)
            {
                ConfigFileManager.SaveToBinaryFile(_config, _factorySettingsFilePath);
                _view.IsFactoryResetPossible = true;
            }
        }

        private void View_FactoryResetAsked(object sender, EventArgs e)
        {
            bool isOk = _view.ConfirmUserChoice("Lang.MsgBoxFineLo.WantResetFactorySetting",
                                                "Lang.MsgBoxFineLo.SettingManagerTitle");

            if (isOk)
            {
                _config = ConfigFileManager.LoadFromBinaryFile<Config>(_factorySettingsFilePath);
                _camera2DBundleSettingManagerPresenter.Camera2DConfigs = _config.CameraConfigs;
                _plcSettingManagerPresenter.PlcConfigs = _config.PlcConfigs;
                ChangeTracker.NotifyFactoryReset();

                _camera2DBundleSettingManagerPresenter.UpdateUiByConfig();
                _plcSettingManagerPresenter.UpdateUiByConfig();
                InitUi();
            }
        }

        private void View_FileLogLevelChanged(object sender, EventArgs e)
        {
            var fileLogLev = _view.FileLogLevel;
            if (_config.MinimumFileLogLevel != fileLogLev)
            {
                ChangeTracker.NotifyChange("MinimumFileLogLevel", _config.MinimumFileLogLevel.ToString(), fileLogLev.ToString());
                _config.MinimumFileLogLevel = fileLogLev;
            }
        }

        private void View_UiLogLevelChanged(object sender, EventArgs e)
        {
            var uiLogLev = _view.UiLogLevel;
            if (_config.MinimumUiLogLevel != uiLogLev)
            {
                ChangeTracker.NotifyChange("MinimumUiLogLevel", _config.MinimumUiLogLevel.ToString(), uiLogLev.ToString());
                _config.MinimumUiLogLevel = uiLogLev;
            }
        }

        private void View_SettingChanged(object sender, SettingChangedEventArgs e)
        {
            var validatorAttr = (ValidatorTypeAttribute)e.PropertyDescriptor.Attributes[typeof(ValidatorTypeAttribute)];
            if (validatorAttr != null)
            {
                (bool ret, string msg) = validatorAttr.ValidatorFunc(e.NewValue);
                if (!ret)
                {
                    _view.ResetInvalidValue(e.PropertyDescriptor, e.ParentValue, e.OldValue, msg);
                    return;
                }
            }
            
            if (e.OldValue != e.NewValue)
            {
                ChangeTracker.NotifyChange($"Task/{e.ParentLabel}/{e.Label}", e.OldValue.ToString(), e.NewValue.ToString());
                _view.RefreshTaskGrid();
            }
        }

        private void View_CarTypeRemoveRequested(object sender, EventArgs e)
        {
            if (_config.GetCarTypeList().Count < 2)
            {
                _view.ShowMessage($"Lang.MsgBoxFineLo.CantRemoveLastCar", "Lang.MsgBoxFineLo.SettingManagerTitle");
                return;
            }

            if (!_view.ConfirmUserChoice("Lang.MsgBoxFineLo.WantRemove", "Lang.MsgBoxFineLo.SettingManagerTitle"))
            {
                return;
            }

            int carTypeToRemove = _view.ConfiguringCarType;
            string carNameToRemove = _config[carTypeToRemove].CarName;
            if (_config.Delete(carTypeToRemove))
            {
                _view.SetCarTypeList(_config.GetCarTypeAndNameList(), -1);
                ChangeTracker.NotifyRemove("CarType", $"{carNameToRemove}({carTypeToRemove})");
            }
        }

        private void View_CarTypeAddRequested(object sender, EventArgs e)
        {
            var result = _addCarTypePresenter.StartAddingCarType(_config.GetCarTypeList());
            if (result.carTypeNumber >= 0)
            {
                if (!_config.GetPermittedCarTypeList().Contains(result.carTypeNumber))
                {
                    _view.ShowMessage($"Given Cartype {result.carTypeNumber} is not permitted to add.", "WARNING");
                    return;
                }
                _config[result.carTypeNumber] = new CargoBox2DConfig();
                _config[result.carTypeNumber].CarName = result.carTypeName;
                _view.SetCarTypeList(_config.GetCarTypeAndNameList(), result.carTypeNumber);
                ChangeTracker.NotifyAdd("CarType", $"{result.carTypeName}({result.carTypeNumber})");
            }
        }

        private void View_CarTypeCopyRequested(object sender, EventArgs e)
        {
            int copiedCarType = _copyCarTypeConfigPresenter.StartCopyCarTypeConfig(_config.GetCarTypeStringList());
            if (copiedCarType >= 0)
            {
                if (!_config.GetPermittedCarTypeList().Contains(copiedCarType))
                {
                    _view.ShowMessage($"Given Cartype {copiedCarType} is not permitted to add", "WARNING");
                    return;
                }
                int selectedCarType = _view.ConfiguringCarType;
                _config[copiedCarType] = _config[selectedCarType].DeepClone();
                _config[copiedCarType].CarName = $"{_config[selectedCarType].CarName}_copy";
                _view.SetCarTypeList(_config.GetCarTypeAndNameList(), copiedCarType);
                ChangeTracker.NotifyAdd("CarType", $"{_config[copiedCarType].CarName}({copiedCarType})");
            }
        }

        private void View_ConfiguringCarTypeChanged(object sender, EventArgs e)
        {
            if (_currentCarType != _view.ConfiguringCarType)
            {
                _currentCarType = _view.ConfiguringCarType;
            }
            RefreshConfiguringCarTypeConfig();
        }

        private void RefreshConfiguringCarTypeConfig()
        {
            _config.RecentlyUsedCar = _view.ConfiguringCarType;

            if (_config[-1].Camera == null || !_config.CameraConfigs.ContainsKey(_config[-1].Camera))
            {
                ChangeCamera(_view.Camera);
            }
            else
            {
                _view.Camera = _config[-1].Camera;
            }
            if (_config[-1].Robot == null || !_config.RobotConfigs.ContainsKey(_config[-1].Robot))
            {
                ChangeInstallRobot(_view.Robot);
            }
            else
            {
                _view.Robot = _config[-1].Robot;
            }
            if (_config[-1].ShiftModelPath == null)
            {
                ChangeShiftModelPath(_view.ShiftModelPath);
            }
            else
            {
                _view.ShiftModelPath = _config[-1].ShiftModelPath;
            }
            if (_config[-1].MasterImageRootFolderPath == null)
            {
                ChangeMasterImageFolderPath(_view.MasterImageRootFolderPath);
            }
            else
            {
                _view.MasterImageRootFolderPath = _config[-1].MasterImageRootFolderPath;
            }
            if (_config[-1].CheckerBoardRootFolderPath == null)
            {
                ChangeCheckerBoardFolderPath(_view.CheckerBoardImageRootFolderPath);
            }
            else
            {
                _view.CheckerBoardImageRootFolderPath = _config[-1].CheckerBoardRootFolderPath;
            }

            _config[-1].UpdatePropertyDescriptors();
            _view.TaskPropertyGridDataSource = _config[-1];
        }

        private void View_LanguageChanged(object sender, EventArgs e)
        {
            ChangeLanguage(_view.SelectedLanguage);
        }

        private void CameraSettingManagerPresenter_AvailableCameraRemoved(object sender, AvailableCamera2DRemovedEventArgs e)
        {
            if (_camera2DBundleSettingManagerPresenter.AvailableCamera2DBundleList.Count == 0)
            {
                foreach (var carType in _config.GetCarTypeList())
                {
                    _config[carType].Camera = null;
                    ChangeTracker.NotifyChange($"Task/{carType}/Camera", e.RemovedCamera2DName, "null");
                }
            }
            else
            {
                string firstCam = _camera2DBundleSettingManagerPresenter.AvailableCamera2DBundleList[0];
                foreach (var carType in _config.GetCarTypeList())
                {
                    if (_config[carType].Camera == e.RemovedCamera2DName)
                    {
                        _config[carType].Camera = firstCam;
                        ChangeTracker.NotifyChange($"Task/{carType}/Camera", e.RemovedCamera2DName, firstCam);
                    }
                }
            }

            _view.SetCameraList(_config.GetCamSetList(), _config[-1].Camera);
        }

        private void CameraSettingManagerPresenter_AvailableCameraAdded(object sender, EventArgs e)
        {
            _view.SetCameraList(_config.GetCamSetList(), _config[-1].Camera);
        }

        private void RobotSettingManagerPresenter_AvailableRobotRemoved(object sender, AvailableRobotRemovedEventArgs e)
        {
            if (_robotSettingManagerPresenter.AvailableRobotList.Count == 0)
            {
                foreach (var carType in _config.GetCarTypeList())
                {
                    _config[carType].Robot = null;
                    ChangeTracker.NotifyChange($"Task/{carType}/Robot", e.RemovedRobotName, "null");
                }
            }
            else
            {
                string firstRobot = _robotSettingManagerPresenter.AvailableRobotList[0];
                foreach (var carType in _config.GetCarTypeList())
                {
                    if (_config[carType].Robot == e.RemovedRobotName)
                    {
                        ChangeTracker.NotifyChange($"Task/{carType}/Robot", e.RemovedRobotName, firstRobot);
                        _config[carType].Robot = firstRobot;
                    }
                }
            }

            _view.SetRobotList(_robotSettingManagerPresenter.AvailableRobotList, _config[-1].Robot);
        }

        private void RobotSettingManagerPresenter_AvailableRobotAdded(object sender, EventArgs e)
        {
            _view.SetRobotList(_robotSettingManagerPresenter.AvailableRobotList, _config[-1].Robot);
        }

        private void PlcSettingManagerPresenter_AvailablePlcAdded(object sender, EventArgs e)
        {
            _view.SetPlcList(_plcSettingManagerPresenter.AvailablePlcList, _config.Plc);
        }

        private void PlcSettingManagerPresenter_AvailablePlcRemoved(object sender, AvailablePlcRemovedEventArgs e)
        {
            if (_plcSettingManagerPresenter.AvailablePlcList.Count == 0)
            {
                _config.Plc = null;
                ChangeTracker.NotifyChange($"Task/PLC", e.RemovedPlcName, "null");
            }
            else
            {
                string firstPlc = _plcSettingManagerPresenter.AvailablePlcList[0];
                if (_config.Plc == e.RemovedPlcName)
                {
                    ChangeTracker.NotifyChange($"Task/PLC", e.RemovedPlcName, firstPlc);
                    _config.Plc = firstPlc;
                }
            }

            _view.SetPlcList(_plcSettingManagerPresenter.AvailablePlcList, _config.Plc);
        }

        private void View_CameraChanged(object sender, EventArgs e)
        {
            ChangeCamera(_view.Camera);
        }

        private void View_PlcChanged(object sender, EventArgs e)
        {
            ChangePlc(_view.Plc);
        }

        private void View_ModelSettingPathChangeRequested(object sender, ModelSettingPathChangeEventArgs e)
        {
            switch (e.ModelPathType)
            {
                case ModelPathType.CalibrationDataRootFolderPath:
                    ChangeCalibrationFolderPath(e.NewPath);
                    break;
                case ModelPathType.MasterImageRootFolderPath:
                    ChangeMasterImageFolderPath(e.NewPath);
                    break;
                case ModelPathType.CheckerBoardRootFolderPath:
                    ChangeCheckerBoardFolderPath(e.NewPath);
                    break;
                case ModelPathType.ShiftModelFilePath:
                    ChangeShiftModelPath(e.NewPath);
                    break;
                case ModelPathType.CameraTcpDataFilePath:
                    ChangeCameraTcpRootFolderPath(e.NewPath);
                    break;
                default:
                    break;
            }

            _view.RefreshTaskGrid();
        }

        public void ChangeLanguage(string langName)
        {
            ChangeTracker.NotifyChange("Language",
                                       LangCodeToNameDict[Thread.CurrentThread.CurrentUICulture.Name],
                                       langName);

            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(LangNameToCodeDict[langName]);
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(LangNameToCodeDict[langName]);

            UpdateLanguage();
            _camera2DBundleSettingManagerPresenter?.UpdateLanguage();
            _plcSettingManagerPresenter?.UpdateLanguage();
        }

        public void UpdateLanguage()
        {
            _config[-1].UpdatePropertyDescriptors();
            _view.TaskPropertyGridDataSource = _config[-1];
            _view.Localize();
        }

        public async void InitUi()
        {
            _view.IsFactoryResetPossible = File.Exists(_factorySettingsFilePath) && _mode == OperationMode.Set;

            await _logManagerScheduler.LoadScheduleInfoFromSystemAsync();
            if (_logManagerScheduler.IsUsing)
            {
                _view.UpdateLogManagerScheduleToUi(_logManagerScheduler.LogPreservePeriod,
                                                   _logManagerScheduler.ImgPreservePeriod,
                                                   _logManagerScheduler.CsvPreservePeriod,
                                                   _logManagerScheduler.StartDateTime);
                _view.CanLogManagerScheduleBeDeleted = true;
            }
            else
            {
                _view.UpdateLogManagerScheduleToUi(0, 0, 0, DateTime.Today);
                _view.CanLogManagerScheduleBeDeleted = false;
            }

            switch (_mode)
            {
                case OperationMode.Auto:
                    _view.SetUiForAutoMode();
                    break;

                case OperationMode.Manual:
                    _view.SetUiForManualMode();
                    break;

                case OperationMode.Set:
                    _view.SetUiForSetMode();
                    break;
            }
        }

        public void UpdateUiByConfig()
        {
            _view.LogPath = _config.LogPath;
            //_view.SetSupportedLanguageList(_langList, LangCodeToNameDict[_config.Language]);
            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(_config.Language);
            _view.SetFileLogLevelList(Enum.GetValues(typeof(LogLevel)), _config.MinimumFileLogLevel);
            _view.SetUiLogLevelList(Enum.GetValues(typeof(LogLevel)), _config.MinimumUiLogLevel);
            _view.SetRobotList(_config.GetRobotList(), _config[-1].Robot);
            _view.SetPlcList(_plcSettingManagerPresenter.AvailablePlcList, _config.Plc);
            _view.SetCameraList(_config.GetCamSetList(), _config[-1].Camera);
            _view.SetCarTypeList(_config.GetCarTypeAndNameList(), _config.RecentlyUsedCar);
            _view.CalibrationDataRootFolderPath = _config.CalibrationDataRootPath;
            _view.CameraTcpDataRootFolderPath = _config.CameraTcpFilePath;
            RefreshConfiguringCarTypeConfig();
            _view.RefreshTaskGrid();
        }

        private void ChangeCamera(string cameraName)
        {
            if (_config[-1].Camera != cameraName)
            {
                ChangeTracker.NotifyChange($"Task/{_config.RecentlyUsedCar}/Camera", _config[-1].Camera, cameraName);
                _config[-1].Camera = cameraName;
            }
            RefreshConfiguringCarTypeConfig();
        }

        private void ChangePlc(string plcName)
        {
            if (_config.Plc != plcName)
            {
                ChangeTracker.NotifyChange("Task/PLC", _config.Plc, plcName);
                _config.Plc = plcName;
            }
            RefreshConfiguringCarTypeConfig();
        }
        private void ChangeInstallRobot(string robotName)
        {
            if (_config[-1].Robot != robotName)
            {
                ChangeTracker.NotifyChange($"Task/{_currentCarType}/Robot", _config.ConfigDict[_currentCarType].Robot, robotName);
                _config[-1].Robot = robotName;
            }
            RefreshConfiguringCarTypeConfig();
        }

        private void ChangeShiftModelPath(string shiftModelPath)
        {
            if (_config.ConfigDict[_currentCarType].ShiftModelPath != shiftModelPath)
            {
                //ValidityCheckOnShiftModelPath
                _modifiedDataPaths = true;
                ChangeTracker.NotifyChange($"Task/{_currentCarType}/ShiftModelPath", _config.ConfigDict[_currentCarType].ShiftModelPath, shiftModelPath);
                _config.ConfigDict[_currentCarType].ShiftModelPath = shiftModelPath;
                _view.ShiftModelPath = shiftModelPath;
            }
        }

        private void ChangeMasterImageFolderPath(string masterImageFolderPath)
        {
            if (_config.ConfigDict[_currentCarType].MasterImageRootFolderPath != masterImageFolderPath)
            {
                _modifiedDataPaths = true;
                ChangeTracker.NotifyChange($"Task/{_currentCarType}/MasterImageRootFolderPath", _config.ConfigDict[_currentCarType].MasterImageRootFolderPath, masterImageFolderPath);
                _config.ConfigDict[_currentCarType].MasterImageRootFolderPath = masterImageFolderPath;
                _view.MasterImageRootFolderPath = masterImageFolderPath;
            }
        }

        private void ChangeCheckerBoardFolderPath(string checkerBoardFolderPath)
        {
            if (_config.ConfigDict[_currentCarType].CheckerBoardRootFolderPath != checkerBoardFolderPath)
            {
                _modifiedDataPaths = true;
                ChangeTracker.NotifyChange($"Task/CheckerBoardRootFolderPath", _config.ConfigDict[_currentCarType].CheckerBoardRootFolderPath, checkerBoardFolderPath);
                _config.ConfigDict[_currentCarType].CheckerBoardRootFolderPath = checkerBoardFolderPath;
                _view.CheckerBoardImageRootFolderPath = checkerBoardFolderPath;
            }
        }

        private void ChangeCalibrationFolderPath(string calibrationDataRootFolderPath)
        {
            if (_config.CalibrationDataRootPath != calibrationDataRootFolderPath)
            {
                //Add Validation Step
                _modifiedDataPaths = true;
                ChangeTracker.NotifyChange($"Task/CalibrationDataRootFolderPath", _config.CalibrationDataRootPath, calibrationDataRootFolderPath);
                _config.CalibrationDataRootPath = calibrationDataRootFolderPath;
                _view.CalibrationDataRootFolderPath = calibrationDataRootFolderPath;
            }
        }

        private void ChangeCameraTcpRootFolderPath(string cameraTcpDataRootFolderPath)
        {
            if (_config.CameraTcpFilePath != cameraTcpDataRootFolderPath)
            {
                _modifiedDataPaths = true;
                ChangeTracker.NotifyChange($"Task/CalibrationDataRootFolderPath", _config.CameraTcpFilePath, cameraTcpDataRootFolderPath);
                _config.CameraTcpFilePath = cameraTcpDataRootFolderPath;
                _view.CameraTcpDataRootFolderPath = cameraTcpDataRootFolderPath;
            }
        }

        private void View_SettingTabChangeRequested(object sender, SettingTabChangeEventArgs e)
        {
            if (e.SettingTab == SettingTab.Task)
            {
                UpdateUiByConfig();
                RefreshConfiguringCarTypeConfig();
            }
        }
    }
}
