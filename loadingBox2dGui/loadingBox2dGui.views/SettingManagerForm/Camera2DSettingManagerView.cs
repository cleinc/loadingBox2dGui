using CoPick.Setting;
using CoPick;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace loadingBox2dGui.SettingManagerForm
{
    public partial class Camera2DSettingManagerView : MaterialForm, ICamera2DSettingManagerView
    {
        MaterialSkinManager _materialSkinManager = MaterialSkinManager.Instance;

        public List<string> AvailableCamera2DList
        {
            set
            {
                cmbCam2DConfig.InvokeIfNeeded(() =>
                {
                    cmbCam2DConfig.DataSource = value;
                    if (value == null || value.Count == 0)
                    {
                        cam2DConfigGrid.SelectedObject = null;
                    }
                });
            }
        }

        public string ConfiguringCamera2D
        {
            get => cmbCam2DConfig.InvokeIfNeeded(() => cmbCam2DConfig.SelectedItem?.ToString());
            set => cmbCam2DConfig.InvokeIfNeeded(() => cmbCam2DConfig.SelectedItem = value);
        }

        public object ConfiguringCamera2DDataSource
        {
            set
            {
                cam2DConfigGrid.InvokeIfNeeded(() =>
                {
                    cam2DConfigGrid.SelectedObject = value;
                    cam2DConfigGrid.ExpandAllGridItems();
                });
            }
        }

        public bool IsControlDisposed
        {
            get => IsDisposed;
        }

        #region event handlers
        public event EventHandler Camera2DSettingAddRequested;
        public event EventHandler Camera2DSettingRemoveRequested;
        public event EventHandler Camera2DSettingCopyRequested;
        public event EventHandler ConfiguringCamera2DChanged;
        public event EventHandler<SettingChangedEventArgs> SettingChanged;
        #endregion

        public Camera2DSettingManagerView()
        {
            InitializeComponent();
            TopLevel = false;
            Dock = DockStyle.Fill;
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this, true);
        }

        public void ShowSettingManager()
        {
            this.BeginInvokeIfNeeded(() => Show());
        }

        public bool ConfirmUserChoice(string msg, string title)
        {
            return this.InvokeIfNeeded(() =>
            {
                return MessageBox.Show(msg, title, MessageBoxButtons.OKCancel) == DialogResult.OK;
            });
        }

        public bool ConfirmUserChoiceToRemove()
        {
            return true;
        }

        public void SetUiForAutoMode()
        {
            this.InvokeIfNeeded(() =>
            {
                btnCam2DAdd_.Enabled = false;
                btnCopyCamera2D_.Enabled = false;
                btnCam2DRemove_.Enabled = false;
                cam2DConfigGrid.Enabled = true;
            });
        }

        public void SetUiForSetMode()
        {
            this.InvokeIfNeeded(() =>
            {
                btnCam2DAdd_.Enabled = true;
                btnCopyCamera2D_.Enabled = true;
                btnCam2DRemove_.Enabled = true;
                cam2DConfigGrid.Enabled = true;
            });
        }

        public void SetUiForManualMode()
        {
            this.InvokeIfNeeded(() =>
            {
                btnCam2DAdd_.Enabled = true;
                btnCopyCamera2D_.Enabled = true;
                btnCam2DRemove_.Enabled = true;
                cam2DConfigGrid.Enabled = true;
            });
        }

        public void Localize()
        {
            //throw new NotImplementedException();
        }

        private void btnCam2DAdd__Click(object sender, EventArgs e)
        {
            Camera2DSettingAddRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btnCam2DRemove__Click(object sender, EventArgs e)
        {
            if (cam2DConfigGrid.SelectedGridItem != null)
            {
                Camera2DSettingRemoveRequested?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btnCopyCamera2D__Click(object sender, EventArgs e)
        {
            if (cam2DConfigGrid.SelectedGridItem != null)
            {
                Camera2DSettingCopyRequested?.Invoke(this, EventArgs.Empty);
            }
        }

        private void cmbCam2DConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfiguringCamera2DChanged?.Invoke(this, EventArgs.Empty);
        }

        public void RefreshPropertyGrid()
        {
            cam2DConfigGrid.BeginInvokeIfNeeded(() => cam2DConfigGrid.Refresh());
        }

        public void ResetInvalidValue(PropertyDescriptor propertyDescriptor, object component, object value, string msg)
        {
            this.InvokeIfNeeded(() =>
            {
                MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                propertyDescriptor.SetValue(component ?? cam2DConfigGrid.SelectedObject, value);
                SendKeys.Send("{TAB}");
            });
        }

        private void cam2DConfigGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            SettingChanged?.Invoke(this, new SettingChangedEventArgs(e.ChangedItem.PropertyDescriptor, e.OldValue, e.ChangedItem.Value,
                                                                      e.ChangedItem.Parent.Value, e.ChangedItem.Label, e.ChangedItem.Parent.Label));
        }

        private void deleteToolStripMenuItem__Click(object sender, EventArgs e)
        {
            this.InvokeIfNeeded(() =>
            {
                var selectedItem = cam2DConfigGrid.SelectedGridItem;
                if (selectedItem != null && selectedItem.GridItemType == GridItemType.Property)
                {
                    string selectedLabel = selectedItem.Expandable ? selectedItem.Label : selectedItem.Parent.Label;
                    int index = Convert.ToInt32(selectedLabel) - 1;
                }
            });
        }

        private void addToolStripMenuItem__Click(object sender, EventArgs e)
        {
            if (cam2DConfigGrid.SelectedGridItem != null)
            {
            }
        }

        public DialogResult ShowMessageBox(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return this.InvokeIfNeeded(() => MessageBox.Show(message, title, buttons, icon));
        }
    }
}
