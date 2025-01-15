using MaterialSkin.Controls;
using CoPick.Robot.Setting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoPick.Setting;
using CoPick;

namespace loadingBox2dGui.SettingManagerForm
{
    public partial class RobotSettingManagerView : MaterialForm, IRobotSettingManagerView
    {
        public List<string> AvailableRobotList
        {
            set
            {
                cmbRobotConfig.InvokeIfNeeded(() =>
                {
                    cmbRobotConfig.DataSource = value;
                    if (value == null || value.Count == 0)
                    {
                        robotConfigGrid.SelectedObject = null;
                    }
                });
            }
        }

        public string ConfiguringRobot
        {
            get => cmbRobotConfig.InvokeIfNeeded(() => cmbRobotConfig.SelectedItem?.ToString());
            set => cmbRobotConfig.InvokeIfNeeded(() => cmbRobotConfig.SelectedItem = value);
        }

        public object ConfiguringRobotDataSource
        {
            set => robotConfigGrid.InvokeIfNeeded(() => robotConfigGrid.SelectedObject = value);
        }

        public bool IsControlDisposed
        {
            get => IsDisposed;
        }

        public event EventHandler RobotSettingAddRequested;
        public event EventHandler RobotSettingRemoveRequested;
        public event EventHandler RobotSettingCopyRequested;
        public event EventHandler ConfiguringRobotChanged;
        public event EventHandler<SettingChangedEventArgs> SettingChanged;

        public RobotSettingManagerView()
        {
            TopLevel = false;
            Dock = DockStyle.Fill;
            InitializeComponent();
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

        public void SetUiForAutoMode()
        {
            this.InvokeIfNeeded(() =>
            {
                btnAddRobotConfig_.Enabled = false;
                btnCopyRobot_.Enabled = false;
                btnRemoveRobotConfig_.Enabled = false;
                robotConfigGrid.Enabled = false;
            });
        }

        public void SetUiForSetMode()
        {
            this.InvokeIfNeeded(() =>
            {
                btnAddRobotConfig_.Enabled = true;
                btnCopyRobot_.Enabled = true;
                btnRemoveRobotConfig_.Enabled = true;
                robotConfigGrid.Enabled = true;
            });
        }

        public void SetUiForManualMode()
        {
            this.InvokeIfNeeded(() =>
            {
                btnAddRobotConfig_.Enabled = true;
                btnCopyRobot_.Enabled = true;
                btnRemoveRobotConfig_.Enabled = true;
                robotConfigGrid.Enabled = true;
            });
        }

        public void Localize()
        {
            //throw new NotImplementedException();
        }

        private void btnAddRobotConfig__Click(object sender, EventArgs e)
        {
            RobotSettingAddRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btnRemoveRobotConfig__Click(object sender, EventArgs e)
        {
            if (robotConfigGrid.SelectedGridItem != null)
            {
                RobotSettingRemoveRequested?.Invoke(this, EventArgs.Empty);
            }
        }

        private void cmbRobotConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfiguringRobotChanged?.Invoke(this, EventArgs.Empty);
        }

        public void RefreshPropertyGrid()
        {
            robotConfigGrid.BeginInvokeIfNeeded(() => robotConfigGrid.Refresh());
        }

        public void ResetInvalidValue(PropertyDescriptor propertyDescriptor, object component, object value, string msg)
        {
            this.InvokeIfNeeded(() =>
            {
                MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                propertyDescriptor.SetValue(component ?? robotConfigGrid.SelectedObject, value);
                SendKeys.Send("{TAB}");
            });
        }

        private void RobotConfigGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            SettingChanged?.Invoke(this, new SettingChangedEventArgs(e.ChangedItem.PropertyDescriptor, e.OldValue, e.ChangedItem.Value,
                                                                     e.ChangedItem.Parent.Value, e.ChangedItem.Label, e.ChangedItem.Parent.Label));
        }

        private void btnCopyRobot_Click(object sender, EventArgs e)
        {
            if (robotConfigGrid.SelectedGridItem != null)
            {
                RobotSettingCopyRequested?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}