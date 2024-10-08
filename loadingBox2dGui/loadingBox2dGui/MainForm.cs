using CoPick;
using CoPick.Setting;
using loadingBox2dGui.views;
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
    public partial class MainForm : MaterialForm, IMainForm
    {
        private OperationMode _programMode;
        public MainForm()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }

        #region Properties
        public OperationMode ProgramMode
        {
            get => _programMode;
        }
        public string PlcInfo
        {
            set { }
        }
        public int CarType
        {
            get => cmbCarTypeName.InvokeIfNeeded(() => (int)cmbCarTypeName.SelectedValue);
            set { }
        }

        public Image LhImage
        {
            set => pbLh.BeginInvokeIfNeeded(() => pbLh.Image = value);
        }
        public Image RhImage
        {
            set => pbRh.BeginInvokeIfNeeded(() => pbRh.Image = value);
        }

        #endregion

        #region Methods
        #endregion

        #region EventHandlers
        public event EventHandler<ChangeModeEventArgs> ChangeModeRequeted;
        public event EventHandler ConnectCameraRequested;
        public event EventHandler ShowSettingManagerRequested;
        public event EventHandler CalculateRequested;
        public event EventHandler UpdateRequested;
        public event EventHandler GetReferenceDataPathRequested;
        public event EventHandler GetHandEyeCalibrationFilePathRequested;
        public event EventHandler ScanPointRequsted;
        private void btnCameraConnect__Click(object sender, System.EventArgs e)
        {

        }

        private void btnSettingManager__Click(object sender, System.EventArgs e)
        {

        }

        private void btnNgListClear__Click(object sender, System.EventArgs e)
        {

        }

        private void btnGlassBackUp__Click(object sender, System.EventArgs e)
        {

        }

        private void btnGlassLHCameraUse__Click(object sender, System.EventArgs e)
        {

        }

        private void btnGlassLHCameraUnuse__Click(object sender, System.EventArgs e)
        {

        }

        private void btnGlassRHCameraUse__Click(object sender, System.EventArgs e)
        {

        }

        private void btnGlassRHCameraUnuse__Click(object sender, System.EventArgs e)
        {

        }

        private void btnGlassCalculate__Click(object sender, System.EventArgs e)
        {

        }

        private void btnGlassUpdate__Click(object sender, System.EventArgs e)
        {

        }

        private void btnGlassRefDataPath_Click(object sender, System.EventArgs e)
        {

        }

        private void btnGlassHandEyeCalibFilePath_Click(object sender, System.EventArgs e)
        {

        }

        private void btnGlassPoint__Click(object sender, System.EventArgs e)
        {

        }
        #endregion
    }
}
