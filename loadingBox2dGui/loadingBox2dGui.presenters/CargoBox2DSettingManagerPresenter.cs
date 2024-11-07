using CoPick.Logging;
using CoPick.Plc.Setting;
using CoPick.Setting.Presenters;
using CoPick.Setting;
using loadingBox2dGui.models;
using loadingBox2dGui.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loadingBox2dGui.presenters
{
    public class CargoBox2DSettingManagerPresenter
    {
        private static readonly LogHelper Logger = LogHelper.Logger;
        //private readonly List<string> _langList; 
        private string _factorySettingsFilePath = "./gifnoc";
        private Config _config;
        private readonly Type _typeOfView;
        private ISettingManagerView _view;
        private OperationMode _mode;
        private readonly Camera2DSettingManagerPresenter _camera2DSettingManagerPresenter;
        private readonly PlcSettingManagerPresenter _plcSettingManagerPresenter;
        private readonly LightSettingManagerPresenter _lightSettingManagerPresenter;
        private readonly CopyCarTypeConfigPresenter _copyCarTypeConfigPresenter;
        private readonly AddCarTypePresenter _addCarTypePresenter;

        private int _configuringCarType;
        public Config ConfigCandidate => _config;
        public SettingChangeTracker ChangeTracker { get; set; }

        public event EventHandler SettingChangeConfirmed;

        public CargoBox2DSettingManagerPresenter(ISettingManagerView view,
                                             Camera2DSettingManagerPresenter camera2DSettingManagerPresenter,
                                             LightSettingManagerPresenter lightSettingManagerPresenter,
                                             PlcSettingManagerPresenter plcSettingManagerPresenter,
                                             CopyCarTypeConfigPresenter copyCarTypeConfigPresenter,
                                             AddCarTypePresenter addCarTypePresenter,
                                             List<string> langList, SettingChangeTracker settingChangeTracker)
        {
            _view = view;
            _typeOfView = view.GetType();
            ChangeTracker = settingChangeTracker;

            //PropertyGridLocalizer.ResourceManagers.Add(Lang.Presenter.ResourceManager);
            _camera2DSettingManagerPresenter = camera2DSettingManagerPresenter;
            _lightSettingManagerPresenter = lightSettingManagerPresenter;
            _plcSettingManagerPresenter = plcSettingManagerPresenter;
            _copyCarTypeConfigPresenter = copyCarTypeConfigPresenter;
            _addCarTypePresenter = addCarTypePresenter;
        }

        public void Start(OperationMode mode)
        {
            try
            {
                _mode = mode;
                _config = ConfigFileManager.LoadFromFile<Config>(ConfigFileManager.GetConfigFilePath());

                //_config.LockCarType();
                ChangeTracker.Clear();
                _view.SetFont();

                _plcSettingManagerPresenter?.Start(_mode, _config.PlcConfigs);
                _lightSettingManagerPresenter?.Start(_mode, _config.LightConfigs);
                _camera2DSettingManagerPresenter?.Start(_mode, _config.CameraConfigs);

                if (_view.IsControlDisposed)
                {
                    _view = (ISettingManagerView)Activator.CreateInstance(_typeOfView,
                                                                                _plcSettingManagerPresenter?.View,
                                                                                _lightSettingManagerPresenter?.View,
                                                                                _camera2DSettingManagerPresenter?.View);
                }

                _view.LockLogPathButton(_mode == OperationMode.Auto);
                _view.TaskPropertyGridDataSource = _config[-1];
                _view.CarTypeAddRequested += View_CarTypeAddRequested;
                _view.CarTypeRemoveRequested += View_CarTypeRemoveRequested;
                _view.CarTypeCopyRequested += View_CarTypeCopyRequested;
                _view.PlcChanged += View_PlcChanged;
                _view.LanguageChanged += View_LanguageChanged;
                _view.ConfiguringCarTypeChanged += View_ConfiguringCarTypeChanged;
                _view.ConfiguringCarTypeInSectionTabChanged += View_ConfiguringCarTypeInSectionTabChanged;
                _view.SettingChanged += View_SettingChanged;
                _view.UiLogLevelChanged += View_UiLogLevelChanged;
                _view.FileLogLevelChanged += View_FileLogLevelChanged;
                _view.FactorySettingSaveAsked += View_FactorySettingSaveAsked;
                _view.FactoryResetAsked += View_FactoryResetAsked;
                _view.LogPathChanged += View_LogPathChanged;
                _view.EndRequested += View_EndRequested;
                _view.SearchModelPathRequested += View_SearchModelPathRequested;
                _view.SearchRoiPathRequested += View_SearchRoiPathRequested;
                _view.CameraChanged += View_CameraChanged;
                _view.LightChanged += View_LightChanged;
                _view.SelectOtherTabPageRequested += View_SelectOtherTabPageRequested;
                _view.SaveSourceImageRequested += View_SaveSourceImageRequested;
                _view.SaveResultImageRequested += View_SaveResultImageRequested;
                _view.SaveSectionPassValueRequested += View_SaveSectionPassValueRequested;
                _view.SaveSectionMinPercentileValueRequested += View_SaveSectionMinPercentileValueRequested;
                _view.SaveSectionMaxPercentileValueRequested += View_SaveSectionMaxPercentileValueRequested;
                _view.SaveSectionThresholdValueRequested += View_SaveSectionThresholdValueRequested;
                _view.SaveSectionLightValueRequested += View_SaveSectionLightValueRequested;
                _view.SaveSectionScoreValueRequested += View_SaveSectionScoreValueRequested;
                _view.FlipCameraHorizontalRequested += View_FlipCameraHorizontalRequested;
                _view.FlipCameraVerticalRequested += View_FlipCameraVerticalRequested;
                _plcSettingManagerPresenter.AvailablePlcAdded += PlcSettingManagerPresenter_AvailablePlcAdded;
                _plcSettingManagerPresenter.AvailablePlcRemoved += PlcSettingManagerPresenter_AvailablePlcRemoved;
                _view.SectionNumberChangeRequested += View_SectionNumberChangeRequested;
                _view.SectionPassRequested += View_SectionPassRequested;
                _view.StartSectionChangeRequested += View_StartSectionChangeRequested;
                _view.PassAllSectionRequested += View_PassAllSectionRequested;
                _view.ChangePasswordRequested += View_ChangePasswordRequested;
                _view.SettingTabExitRequested += View_SettingTabExitRequested;
                _view.SettingTabEnterRequested += View_SettingTabEnterRequested;
                _view.PassValueChangeRequested += View_PassValueChangeRequested;
                _view.PaintSectionRequested += View_PaintSectionRequested;
                _view.SetReverseGlassSectionRequested += View_SetReverseGlassSectionRequested;
                _view.DailyProdResetTimeChangeRequested += View_DailyProdResetTimeChangeRequested;
                _view.SaveResultImageInHalfRequested += View_SaveResultImageInHalfRequested;

                _beforeConfiguringCarTypeSection = _config.RecentlyUsedCar;
                UpdateUiByConfig();
                ReadSectionSettingsToTable(_config.RecentlyUsedCar);
                InitUi();
                _view.ShowSettingManager(mode != OperationMode.Auto);
            }
            catch (Exception ex)
            {
                Logger.Debug(ex.ToString());
            }
        }
    }
}
