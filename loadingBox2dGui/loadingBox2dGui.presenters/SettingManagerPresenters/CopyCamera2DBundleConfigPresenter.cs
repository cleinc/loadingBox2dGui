using CoPick.Setting;
using CoPick.Setting.Presenters;
using loadingBox2dGui.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loadingBox2dGui.presenters.SettingManagerPresenters
{
    public class CopyCamera2DBundleConfigPresenter : CopyConfigPresenter
    {
        public CopyCamera2DBundleConfigPresenter(ICopyConfigView view)
        : base(view)
        {
        }

        public string StartCopyCameraConfig(Dictionary<string, Dictionary<InspectionLocation, Dictionary<Camera2DAttribute, string>>> cameraConfigs, string cameraToCopy)
        {
            _existingConfigList = cameraConfigs.Keys.ToList();

            if (_view.RequestCopyInformation())
            {
                cameraConfigs[_view.CopiedName] = cameraConfigs[cameraToCopy].ToDictionary(
                kvp => kvp.Key,
                kvp => new Dictionary<Camera2DAttribute, string>(kvp.Value)
                );

                return _view.CopiedName;
            }
            else
            {
                return "";
            }
        }
    }
}
