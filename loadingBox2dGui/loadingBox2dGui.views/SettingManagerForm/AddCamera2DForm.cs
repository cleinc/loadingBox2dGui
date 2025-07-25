using CoPick.Setting;
using CoPick;
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
    public partial class AddCamera2DForm_ : MaterialForm, IAddCamera2DConfigView
    {
        public List<Camera2DMaker> SupportingCamera2DMakers 
        { 
            set => cmbCamera2DMaker.InvokeIfNeeded(() => cmbCamera2DMaker.DataSource = value);
        }

        public string Camera2DNameToAdd { get; private set; }

        public Camera2DMaker Camera2DMakerToAdd { get; private set; }

        public event EventHandler Camera2DAddRequested;
        public event EventHandler Camera2DAddCanceled;

        public bool RequestAddingCamera2DInformation()
        {
            tbCam2DName.InvokeIfNeeded(() => tbCam2DName.Text = "");
            ActiveControl = tbCam2DName;
            //this.Translate(Lang.Primer.ResourceManager);
            return ShowDialog() == DialogResult.OK;
        }

        public void ShowMessage(string msg)
        {
            this.InvokeIfNeeded(() => MessageBox.Show(msg));
        }

        public void CloseDialog(DialogResult result)
        {
            DialogResult = result;
            this.InvokeIfNeeded(() => Close());
        }
        public AddCamera2DForm_()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }

        private void OnCamera2DAddRequested()
        {
            this.InvokeIfNeeded(() =>
            {
                Camera2DNameToAdd = tbCam2DName.Text.Trim();
                Camera2DMakerToAdd = (Camera2DMaker)cmbCamera2DMaker.SelectedIndex;
                Camera2DAddRequested?.Invoke(this, EventArgs.Empty);
            });
        }

        private void OnCamera2DAddCanceled()
        {
            Camera2DAddCanceled?.Invoke(this, EventArgs.Empty);
        }

        private void btnAdd__Click(object sender, EventArgs e)
        {
            OnCamera2DAddRequested();
        }

        private void btnCancel__Click_1(object sender, EventArgs e)
        {
            OnCamera2DAddCanceled();
        }

        public void Localize()
        {
            //throw new NotImplementedException();
        }
    }
}
