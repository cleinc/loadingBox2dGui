using CoPick;
using CoPick.Setting;
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
    public partial class AddCarTypeForm_ : Form, IAddCarTypeView
    {
        public int CarTypeNumberToAdd
        {
            get
            {
                return tbCarType.InvokeIfNeeded(() =>
                {
                    if (int.TryParse(tbCarType.Text, out int carTypeNumber))
                    {
                        return carTypeNumber;
                    }
                    else
                    {
                        return -1;
                    }
                });
            }
        }

        public string CarTypeNameToAdd
        {
            get
            {
                return tbCarName.InvokeIfNeeded(() =>
                {
                    return tbCarName.Text.Trim();
                });
            }
        }

        public event EventHandler CarTypeAddRequested;
        public event EventHandler CarTypeAddCanceled;

        public AddCarTypeForm_()
        {
            InitializeComponent();
            this.ApplyFont();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CarTypeAddRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btnCancel__Click(object sender, EventArgs e)
        {
            CarTypeAddCanceled?.Invoke(this, EventArgs.Empty);
        }

        public void CloseDialog(DialogResult dialogResult)
        {
            DialogResult = dialogResult;
            this.InvokeIfNeeded(() => Close());
        }

        public void ShowMessage(string message)
        {
            this.InvokeIfNeeded(() => MessageBox.Show(message));
        }

        public bool RequestAddingCarTypeInformation()
        {
            return this.InvokeIfNeeded(() =>
            {
                tbCarName.Text = "";
                tbCarType.Text = "";
                ActiveControl = tbCarType;
                //this.Translate(Lang.AddCarT.ResourceManager);
                return ShowDialog() == DialogResult.OK;
            });
        }

        private void HandleKeyDownEvent(Keys keyCode)
        {
            if (keyCode == Keys.Enter)
            {
                CarTypeAddRequested?.Invoke(this, EventArgs.Empty);
            }
            else if (keyCode == Keys.Escape)
            {
                CarTypeAddCanceled?.Invoke(this, EventArgs.Empty);
            }
        }

        private void tbCarType_KeyDown(object sender, KeyEventArgs e)
        {
            HandleKeyDownEvent(e.KeyCode);
        }

        private void tbCarName_KeyDown(object sender, KeyEventArgs e)
        {
            HandleKeyDownEvent(e.KeyCode);
        }

        public void Localize()
        {
            //throw new NotImplementedException();
        }
    }
}
