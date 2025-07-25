using CoPick.Setting;
using loadingBox2dGui.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loadingBox2dGui.presenters.SettingManagerPresenters
{
    public class AddCamera2DBundleConfigPresenter
    {
        private IAddCamera2DConfigView _view;

        private Dictionary<Camera2DMaker, Func<Dictionary<InspectionLocation, Dictionary<Camera2DAttribute, string>>>> _cameraDefaultSettings;

        private List<string> _existingCameraBundles;

        public AddCamera2DBundleConfigPresenter(IAddCamera2DConfigView view, Dictionary<Camera2DMaker, Func<Dictionary<InspectionLocation, Dictionary<Camera2DAttribute, string>>>> cameraDefaultSettings)
        {
            _view = view;
            _cameraDefaultSettings = cameraDefaultSettings;
            _view.SupportingCamera2DMakers = Enum.GetValues(typeof(Camera2DMaker)).Cast<Camera2DMaker>().ToList();
            _view.Camera2DAddRequested += View_CameraAddRequested;
            _view.Camera2DAddCanceled += View_CameraAddCanceled;
        }

        private void View_CameraAddCanceled(object sender, EventArgs e)
        {
            _view.CloseDialog(DialogResult.Cancel);
        }

        private void View_CameraAddRequested(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_view.Camera2DNameToAdd))
            {
                MessageBox.Show("Msgs.NeedBundleName");
            }
            else if (_existingCameraBundles.Contains(_view.Camera2DNameToAdd))
            {
                MessageBox.Show("Msgs.UsedBundleName");
            }
            else
            {
                _view.CloseDialog(DialogResult.OK);
            }
        }

        public string StartAddingCameraConfig(Dictionary<string, Dictionary<InspectionLocation, Dictionary<Camera2DAttribute, string>>> cameraConfigs)
        {
             _existingCameraBundles = cameraConfigs.Keys?.ToList();
            if (_view.RequestAddingCamera2DInformation())
            {
                cameraConfigs[_view.Camera2DNameToAdd] = _cameraDefaultSettings[_view.Camera2DMakerToAdd]();

                return _view.Camera2DNameToAdd;
            }
            else
            {
                return "";
            }
        }
    }
}
