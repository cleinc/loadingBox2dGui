using CoPick.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using loadingBox2dGui.models;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loadingBox2dGui.presenters.SettingManagerPresenters
{
    public class Camera2DBundleSettingManagerPresenter
    {
        private ICamera2DSettingManagerView _view;
        private readonly AddCamera2DBundleConfigPresenter _addCamera2DBundlePresenter;
        private readonly CopyCamera2DBundleConfigPresenter _copyCamera2DBundlePresenter;
        private Dictionary<string, Dictionary<InspectionLocation, Dictionary<Camera2DAttribute, string>>> _camera2DBundleConfigs;
        private readonly Dictionary<Camera2DMaker, Func<Dictionary<Camera2DAttribute, string>>> _defaultSettings;
        private SettingChangeTracker _settingChangeTracker;
        private Type _typeOfView;
        private OperationMode _mode;
        private Dictionary<string, Dictionary<InspectionLocation, bool>> _modifiedCamera2DBundles;

        public Dictionary<string, Dictionary<InspectionLocation, Dictionary<Camera2DAttribute, string>>> Camera2DConfigs
        {
            set => _camera2DBundleConfigs = value;
        }

        public Dictionary<string, Dictionary<InspectionLocation, bool>> ModifiedCamera2DBundles
        {
            get => _modifiedCamera2DBundles;
        }

        public bool Camera2DBundleModified(string camera2DBundleName)
        {
            if (_modifiedCamera2DBundles.TryGetValue(camera2DBundleName, out var camera2DBundle))
            {
                return camera2DBundle.Any(kvp => kvp.Value == true);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public bool Camera2DBundleModified()
        {
            return _modifiedCamera2DBundles.
                Select(camKey => camKey.Value).
                Any(inspectionLocationKvp => inspectionLocationKvp.Values.Any(modified => modified));
        }

        public void ClearModifiedDictionary()
        {
            _modifiedCamera2DBundles.Clear();
        }

        public void ResetModifiedDictionary()
        {
            foreach (var outerEntry in ModifiedCamera2DBundles)
            {
                foreach (var innerKey in outerEntry.Value.Keys.ToList())
                {
                    outerEntry.Value[innerKey] = false;
                }
            }
        }

        public List<string> AvailableCamera2DBundleList
        {
            get => _camera2DBundleConfigs?.Keys?.ToList() ?? new List<string>();
        }

        public event EventHandler AvailableCamera2DAdded;
        public event EventHandler<AvailableCamera2DRemovedEventArgs> AvailableCamera2DRemoved;

        public ICamera2DSettingManagerView View => _view;

        public Camera2DBundleSettingManagerPresenter(ICamera2DSettingManagerView view,
                                            AddCamera2DBundleConfigPresenter addCamera2DPresenter,
                                            CopyCamera2DBundleConfigPresenter copyCamera2DPresenter,
                                            Dictionary<string, Dictionary<InspectionLocation, Dictionary<Camera2DAttribute, string>>> camera2DConfigs,
                                            Dictionary<Camera2DMaker, Func<Dictionary<Camera2DAttribute, string>>> defaultSettings,
                                            SettingChangeTracker settingChangeTracker)
        {
            _view = view;
            _typeOfView = view.GetType();
            _camera2DBundleConfigs = camera2DConfigs;
            _settingChangeTracker = settingChangeTracker;
            _addCamera2DBundlePresenter = addCamera2DPresenter;
            _copyCamera2DBundlePresenter = copyCamera2DPresenter;
            _defaultSettings = defaultSettings;
            _modifiedCamera2DBundles = new Dictionary<string, Dictionary<InspectionLocation, bool>>();
            _modifiedCamera2DBundles = camera2DConfigs.ToDictionary(
                i => i.Key, 
                i => i.Value.ToDictionary(j => j.Key, 
                                          j => false));
        }

        public void Start(OperationMode mode, Dictionary<string, Dictionary<InspectionLocation, Dictionary<Camera2DAttribute, string>>> camera2DConfigs)
        {
            if (_view.IsControlDisposed)
            {
                _view = (ICamera2DSettingManagerView)Activator.CreateInstance(_typeOfView);
            }

            _mode = mode;
            _camera2DBundleConfigs = camera2DConfigs;

            _view.ConfiguringCamera2DChanged += View_ConfiguringCamera2DChanged;
            _view.Camera2DSettingAddRequested += View_Camera2DSettingAddRequested;
            _view.Camera2DSettingRemoveRequested += View_Camera2DSettingRemoveRequested;
            _view.Camera2DSettingCopyRequested += View_Camera2DSettingCopyRequested;
            _view.SettingChanged += View_SettingChanged;
            InitUi();
            UpdateUiByConfig();
            ResetModifiedDictionary();
            _view.ShowSettingManager();
        }

        public void Stop()
        {
            _view.ConfiguringCamera2DChanged -= View_ConfiguringCamera2DChanged;
            _view.Camera2DSettingAddRequested -= View_Camera2DSettingAddRequested;
            _view.Camera2DSettingRemoveRequested -= View_Camera2DSettingRemoveRequested;
            _view.Camera2DSettingCopyRequested -= View_Camera2DSettingCopyRequested;
            _view.SettingChanged -= View_SettingChanged;
        }

        private void InitUi()
        {
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
            _view.AvailableCamera2DList = AvailableCamera2DBundleList;
            string configuringCamera = _view.ConfiguringCamera2D;
            if (configuringCamera != null && _camera2DBundleConfigs.TryGetValue(configuringCamera, out var cameraConfig))
            {
                UpdateCamera2DBundlePropertyGrid(cameraConfig);
            }
        }

        public void ChangeLanguage(string language)
        {
            if (_camera2DBundleConfigs.TryGetValue(_view.ConfiguringCamera2D ?? "", out var cameraConfig))
            {
                UpdateCamera2DBundlePropertyGrid(cameraConfig);
            }

            //_view.Localize();
        }

        private void UpdateCamera2DBundlePropertyGrid(Dictionary<InspectionLocation, Dictionary<Camera2DAttribute, string>> cameraConfig)
        {
            if (_view.ConfiguringCamera2D != null)
            {
                var camDict = cameraConfig.ToDictionary
                (
                    kvp => kvp.Key.ToString(),

                    kvp => new DictionaryPropertyGridAdapter<Camera2DAttribute, string>(kvp.Value,
                                                                                      null, null,
                                                                                      null)

                );
                _view.ConfiguringCamera2DDataSource = new DictionaryPropertyGridAdapter<string, DictionaryPropertyGridAdapter<Camera2DAttribute, string>>(camDict);
            }
        }

        private void AddCamera2DSetting(string camera2DBundleName)
        {
            _view.AvailableCamera2DList = AvailableCamera2DBundleList;
            _view.ConfiguringCamera2D = camera2DBundleName;
            _settingChangeTracker.NotifyAdd("Camera2DBundle", camera2DBundleName);
            _modifiedCamera2DBundles[camera2DBundleName] = _camera2DBundleConfigs[camera2DBundleName].ToDictionary(
                i => i.Key, 
                i => true);
            AvailableCamera2DAdded?.Invoke(this, EventArgs.Empty);
        }

        public void View_Camera2DSettingCopyRequested(object sender, EventArgs e)
        {
            string camera2DBundleToCopy = _view.ConfiguringCamera2D;
            if (!string.IsNullOrEmpty(camera2DBundleToCopy))
            {
                string copiedCamera2DBundleName = _copyCamera2DBundlePresenter.StartCopyCameraConfig(_camera2DBundleConfigs, camera2DBundleToCopy);
                if (!string.IsNullOrEmpty(copiedCamera2DBundleName))
                {
                    AddCamera2DSetting(copiedCamera2DBundleName);
                }
            }
        }

        public void View_Camera2DSettingAddRequested(object sender, EventArgs e)
        {
            string addedCamera2DBundleName = _addCamera2DBundlePresenter.StartAddingCameraConfig(_camera2DBundleConfigs);
            if (!string.IsNullOrEmpty(addedCamera2DBundleName))
            {
                AddCamera2DSetting(addedCamera2DBundleName);
            }
        }

        public void View_Camera2DSettingRemoveRequested(object sender, EventArgs e)
        {
            if (AvailableCamera2DBundleList.Count < 1)
                return;

            if (_view.ShowMessageBox("Lang.MsgBoxFineLo.WantRemove", "Lang.MsgBoxFineLo.SettingManagerTitle",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (_view.ConfirmUserChoiceToRemove())
            {
                string camera2DToRemove = _view.ConfiguringCamera2D;
                _camera2DBundleConfigs.Remove(camera2DToRemove);
                _settingChangeTracker.NotifyRemove("Camera2D", camera2DToRemove);
                _view.AvailableCamera2DList = AvailableCamera2DBundleList;
                
                if (AvailableCamera2DBundleList.Count == 0)
                {
                    _view.ConfiguringCamera2DDataSource = null;
                }
                AvailableCamera2DRemoved?.Invoke(this, new AvailableCamera2DRemovedEventArgs(camera2DToRemove));
                _modifiedCamera2DBundles.Remove(camera2DToRemove);
            }
        }

        public void View_ConfiguringCamera2DChanged(object sender, EventArgs e)
        {
            string configuringCamera = _view.ConfiguringCamera2D;
            if (_camera2DBundleConfigs.TryGetValue(configuringCamera ?? "", out var camera2DBundleConfig))
            {
                UpdateCamera2DBundlePropertyGrid(camera2DBundleConfig);
            }
            else
            {
                _view.AvailableCamera2DList = AvailableCamera2DBundleList;
            }
        }

        public void View_SettingChanged(object sender, SettingChangedEventArgs e)
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

            //bool parseSuccess = Enum.TryParse(e.PropertyDescriptor.Name, out Camera2DAttribute cam2DAttribute);
            //if (parseSuccess)
            //{
            //    bool ret = IdsCameraParameter.ValidateCamParameter(e.NewValue.ToString(), cam2DAttribute, out object output);
            //    if (!ret)
            //    {
            //        _view.ResetInvalidValue(e.PropertyDescriptor, e.ParentValue, e.OldValue, "cam parameter validation failed");
            //        return;
            //    }
            //    else
            //    {
            //        e.NewValue = output;
            //        e.PropertyDescriptor.SetValue(e.ParentValue, output);
            //    }
            //}

            // Add CustomCameraParameterValidator
            if (e.OldValue != e.NewValue)
            {
                InspectionLocation inspectionLocation = (InspectionLocation) Enum.Parse(typeof(InspectionLocation), e.ParentLabel.ToString());
                _modifiedCamera2DBundles[_view.ConfiguringCamera2D][inspectionLocation] = true;
                _settingChangeTracker.NotifyChange($"{e.ParentLabel}/{e.Label}", e.OldValue.ToString(), e.NewValue.ToString());
                _view.RefreshPropertyGrid();
            }
        }

        public void UpdateLanguage()
        {
            //Lang.Msgs.Culture = Thread.CurrentThread.CurrentUICulture;
            //Lang.PGrid.Culture = Thread.CurrentThread.CurrentUICulture;
            //if (_camera2DConfigs.TryGetValue(_view.ConfiguringCamera2D ?? "", out var _))
            //{
            //    UpdateCamera2DPropertyGrid();
            //}

            //_addCamera2DPresenter?.UpdateLanguage();
            //_copyCamera2DPresenter?.UpdateLanguage();
        }
    }
}
