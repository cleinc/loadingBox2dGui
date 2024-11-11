using CoPick;
using CoPick.Setting;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loadingBox2dGui
{
    public partial class LightSettingManagerView : MaterialForm, ILightSettingManagerView
    {
        MaterialSkinManager _materialSkinManager = MaterialSkinManager.Instance;
        private LightSettingManagerPresenter _presenter;
        private AddLightConfigForm _addForm;
        private CopyConfigsForm_ _copyForm;

        private Dictionary<string, Dictionary<LightAttribute, string>> _lightConfigs;
        private Dictionary<LightMaker, Func<Dictionary<LightAttribute, string>>> _defaultSettings;
        private SettingChangeTracker _settingChangeTracker;

        public bool IsControlDisposed
        {
            get => IsDisposed;
        }

        public List<string> AvailableLightList
        {
            set
            {
                cmbLightModel.InvokeIfNeeded(() =>
                {
                    cmbLightModel.DataSource = value;
                    if (value == null || value.Count == 0)
                    {
                        lightConfigGrid.SelectedObject = null;
                    }
                });
            }
        }

        public string ConfiguringLight
        {
            get => cmbLightModel.InvokeIfNeeded(() => cmbLightModel.SelectedItem?.ToString());
            set => cmbLightModel.InvokeIfNeeded(() =>cmbLightModel.SelectedItem = value);
        }

        public object ConfiguringLightDataSource
        {
            set => lightConfigGrid.InvokeIfNeeded(() => lightConfigGrid.SelectedObject = value);
        }

        #region Event Handlers
        public event EventHandler LightSettingAddRequested;
        public event EventHandler LightSettingRemoveRequested;
        public event EventHandler LightSettingCopyRequested;
        public event EventHandler ConfiguringLightChanged;
        public event EventHandler<SettingChangedEventArgs> SettingChanged;
        #endregion

        public LightSettingManagerView()
        {
            InitializeComponent();
            TopLevel = false;
            Dock = DockStyle.Fill;
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this, true);
        }

        public bool ConfirmUserChoiceToRemove()
        {
            return true;
        }

        public void RefreshPropertyGrid()
        {
            lightConfigGrid.BeginInvokeIfNeeded(() => lightConfigGrid.Refresh());
        }

        public void ShowSettingManager()
        {
            this.BeginInvokeIfNeeded(() =>
            {
                WindowState = FormWindowState.Normal;
                Show();
                Activate();
            });
        }

        private void btnLightAdd__Click(object sender, EventArgs e)
        {
            LightSettingAddRequested?.Invoke(sender, EventArgs.Empty);
        }

        private void btnLightRemove__Click(object sender, EventArgs e)
        {
            LightSettingRemoveRequested?.Invoke(sender, EventArgs.Empty);
        }

        private void btnLightCopy__Click(object sender, EventArgs e)
        {
            LightSettingCopyRequested?.Invoke(sender, EventArgs.Empty);
        }

        private void lightConfigGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            SettingChanged?.Invoke(e, new SettingChangedEventArgs(e.ChangedItem.PropertyDescriptor, e.OldValue, e.ChangedItem.Value,
                                                                  e.ChangedItem.Parent, e.ChangedItem.Label, e.ChangedItem.Parent.Label));
        }

        public void ResetInvalidValue(PropertyDescriptor propertyDescriptor, object component, object value, string msg)
        {
            this.InvokeIfNeeded(() =>
            {
                MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                propertyDescriptor.SetValue(component ?? lightConfigGrid.SelectedObject, value);
                SendKeys.Send("{TAB}");
            });
        }

        public void Localize()
        {
            //throw new NotImplementedException();
            //this.InvokeIfNeeded(() => this.Translate(Lang.Primer.ResourceManager));
        }

        public bool ConfirmUserChoice(string msg, string title)
        {
            return this.InvokeIfNeeded(() =>
            {
                return MessageBox.Show(msg, title, MessageBoxButtons.OKCancel) == DialogResult.OK;
            });
        }

        public void SetUiForAutoMode()
        {
            this.InvokeIfNeeded(() =>
            {
                lightConfigGrid.Enabled = false;
                btnLightAdd_.Enabled = false;
                btnLightRemove_.Enabled = false;
                btnLightCopy_.Enabled = false;
            });
        }

        public void SetUiForManualMode()
        {
            this.InvokeIfNeeded(() =>
            {
                lightConfigGrid.Enabled = false;
                btnLightAdd_.Enabled = false;
                btnLightRemove_.Enabled = false;
                btnLightCopy_.Enabled = false;
            });
        }

        public void SetUiForSetMode()
        {
            this.InvokeIfNeeded(() =>
            {
                lightConfigGrid.Enabled = true;
                btnLightAdd_.Enabled = true;
                btnLightRemove_.Enabled = true;
                btnLightCopy_.Enabled = true;
            });
        }

        private void cmbLightModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfiguringLightChanged?.Invoke(this, EventArgs.Empty);
        }

        public DialogResult ShowMessageBox(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return this.InvokeIfNeeded(() => MessageBox.Show(message, title, buttons, icon));
        }
    }
}
