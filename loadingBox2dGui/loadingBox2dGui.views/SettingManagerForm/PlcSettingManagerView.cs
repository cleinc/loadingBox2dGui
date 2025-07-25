using CoPick;
using CoPick.Plc.Setting;
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

namespace loadingBox2dGui.SettingManagerForm
{
    public partial class PlcSettingManagerView: MaterialForm, IPlcSettingManagerView
    {
        MaterialSkinManager _materialSkinManager = MaterialSkinManager.Instance;
        public List<Type> SupportedPlcList
        {
            set => cmbPlcConfig.InvokeIfNeeded(() =>
            {
                cmbPlcConfig.DisplayMember = "Name";
                cmbPlcConfig.DataSource = value;
            });
        }

        public Type ConfiguringPlc
        {
            get => cmbPlcConfig.InvokeIfNeeded(() => (Type)cmbPlcConfig.SelectedItem);
            set => cmbPlcConfig.InvokeIfNeeded(() => cmbPlcConfig.SelectedItem = value);
        }

        public object ConfiguringPlcDataSource
        {
            set => plcConfigGrid.BeginInvokeIfNeeded(() => plcConfigGrid.SelectedObject = value);
        }

        public bool IsPropertyGridEditable
        {
            set=> plcConfigGrid.BeginInvokeIfNeeded(() => plcConfigGrid.Enabled = value);
        }

        public bool IsControlDisposed
        {
            get => IsDisposed;
        }

        #region event handlers
        public event EventHandler ConfiguringPlcChanged;
        public event EventHandler<SettingChangedEventArgs> SettingChanged;
        public event EventHandler RemovePlcRequested;
    
        #endregion

        public PlcSettingManagerView()
        {

            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this, true);
            TopLevel = false;
            Dock = DockStyle.Fill;
        }

        public void ShowSettingManager()
        {
            this.BeginInvokeIfNeeded(() => Show());
        }

        public void SetUiForAutoMode()
        {
            this.InvokeIfNeeded(() =>
            {
                plcConfigGrid.Enabled = false;
                btnPlcRemove_.Enabled = false;
            });
        }

        public void SetUiForSetMode()
        {
            this.InvokeIfNeeded(() =>
            {
                plcConfigGrid.Enabled = true;
                btnPlcRemove_.Enabled = true;
            });
        }

        public void SetUiForManualMode()
        {
            this.InvokeIfNeeded(() =>
            {
                plcConfigGrid.Enabled = false;
                btnPlcRemove_.Enabled = false;
            });
        }

        private void cmbPlcConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfiguringPlcChanged?.Invoke(this, EventArgs.Empty);
        }

        public void RefreshPropertyGrid()
        {
            plcConfigGrid.BeginInvokeIfNeeded(() => plcConfigGrid.Refresh());
        }

        public void Localize()
        {
            //throw new NotImplementedException();
            //this.BeginInvokeIfNeeded(() => this.Translate(Lang.Primer.ResourceManager));
        }

        public void ResetInvalidValue(PropertyDescriptor propertyDescriptor, object component, object value, string msg)
        {
            this.InvokeIfNeeded(() =>
            {
                MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                propertyDescriptor.SetValue(component ?? plcConfigGrid.SelectedObject, value);
                SendKeys.Send("{TAB}");
            });
        }

        private void plcConfigGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            SettingChanged?.Invoke(this, new SettingChangedEventArgs(e.ChangedItem.PropertyDescriptor, e.OldValue, e.ChangedItem.Value,
                                                                      e.ChangedItem.Parent.Value, e.ChangedItem.Label, e.ChangedItem.Parent.Label));
        }

        public bool ConfirmUserChoice(string msg, string title)
        {
            return this.InvokeIfNeeded(() =>
            {
                return MessageBox.Show(msg, title, MessageBoxButtons.OKCancel) == DialogResult.OK;
            });
        }

        private void btnPlcRemove__Click(object sender, EventArgs e)
        {
            RemovePlcRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
