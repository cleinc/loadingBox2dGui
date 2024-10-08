using CoPick;
using CoPick.Plc;
using CoPick.Setting;
using loadingBox2dGui.models;
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
        private PlcStatusPainter _plcStatusPainter;
        private Dictionary<PlcSignalForLoadingBox, Label> _plcSignalLabelDict;
        public MainForm()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
            _plcStatusPainter = new PlcStatusPainter(gbPLC.CreateGraphics(), 20, 22);
            LoadPlcSignalLabelDict();
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
        public string BodyNum
        {
            set { }
        }
        public string CarSeq 
        { 
            set => tbCarSeqNumber.InvokeIfNeeded(() => tbCarSeqNumber.Text = value); 
        }

        #endregion

        #region Methods
        public void DisplayVisionResult(VisionStatus visionStatus)
        {
            this.BeginInvokeIfNeeded(() =>
            {
                switch (visionStatus)
                {
                    case VisionStatus.OK:
                        pictureBox1.Image = Properties.Resources.visionOKOn;
                        pictureBox2.Image = Properties.Resources.visionNGOff;
                        break;

                    case VisionStatus.NG:
                        pictureBox1.Image = Properties.Resources.visionOKOff;
                        pictureBox2.Image = Properties.Resources.visionNGOn;
                        break;

                    case VisionStatus.NONE:
                        pictureBox1.Image = Properties.Resources.visionOKOff;
                        pictureBox2.Image = Properties.Resources.visionNGOff;
                        break;
                }
            });
        }

        public void UpdatePlcSignalLabel(PlcSignalForLoadingBox signal, string value)
        {
            if (_plcSignalLabelDict.TryGetValue(signal, out var label))
            {
                label.BeginInvokeIfNeeded(() =>
                {
                    label.Text = value;
                });
            }
        }

        public void TogglePlcSignalLabel(PlcSignalForLoadingBox signal, bool isOn)
        {
            if (_plcSignalLabelDict.TryGetValue(signal, out var label))
            {
                label.BeginInvokeIfNeeded(() =>
                {
                    label.BackColor = isOn ? Color.LightGreen : Color.White;
                });
            }
        }

        public void RefreshPlcStatus()
        {
            gbPLC.BeginInvokeIfNeeded(() => gbPLC.Invalidate());
        }

        public void BlinkReadStatus(int time)
        {
            gbPLC.BeginInvokeIfNeeded(() =>
            {
                _plcStatusPainter.BlinkReadStatus(time);
            });
        }

        public void BlinkWriteStatus(int time)
        {
            gbPLC.BeginInvokeIfNeeded(() =>
            {
                _plcStatusPainter.BlinkWriteStatus(time);
            });
        }

        private void LoadPlcSignalLabelDict()
        {
            _plcSignalLabelDict = new Dictionary<PlcSignalForLoadingBox, Label>();
            _plcSignalLabelDict[PlcSignalForLoadingBox.CAR_TYPE] = carTypeSignalStatus.LblSignals[0];
            _plcSignalLabelDict[PlcSignalForLoadingBox.CAR_TYPE | PlcSignalForLoadingBox.VALUE] = carTypeSignalStatus.LblValues[0];
            _plcSignalLabelDict[PlcSignalForLoadingBox.CAR_SEQ1] = carTypeSignalStatus.LblSignals[1];
            _plcSignalLabelDict[PlcSignalForLoadingBox.CAR_SEQ2] = carTypeSignalStatus.LblSignals[2];
            _plcSignalLabelDict[PlcSignalForLoadingBox.CAR_SEQ1 | PlcSignalForLoadingBox.VALUE] = carTypeSignalStatus.LblValues[1];
            _plcSignalLabelDict[PlcSignalForLoadingBox.CAR_SEQ2 | PlcSignalForLoadingBox.VALUE] = carTypeSignalStatus.LblValues[2];

            _plcSignalLabelDict[PlcSignalForLoadingBox.VISION_UPDATE] = glassReadSignalStatus.LblSignals[0];
            _plcSignalLabelDict[PlcSignalForLoadingBox.VISION_START] = glassReadSignalStatus.LblSignals[1];
            _plcSignalLabelDict[PlcSignalForLoadingBox.P1] = glassReadSignalStatus.LblSignals[2];
            _plcSignalLabelDict[PlcSignalForLoadingBox.P2] = glassReadSignalStatus.LblSignals[3];
            _plcSignalLabelDict[PlcSignalForLoadingBox.VISION_END] = glassReadSignalStatus.LblSignals[4];
            _plcSignalLabelDict[PlcSignalForLoadingBox.VISION_RESET] = glassReadSignalStatus.LblSignals[5];
            _plcSignalLabelDict[PlcSignalForLoadingBox.VISION_PASS] = glassReadSignalStatus.LblSignals[6];

            _plcSignalLabelDict[PlcSignalForLoadingBox.VISION_OK] = glassWriteSignalStatus.LblSignals[0];
            _plcSignalLabelDict[PlcSignalForLoadingBox.VISION_NG] = glassWriteSignalStatus.LblSignals[1];
            _plcSignalLabelDict[PlcSignalForLoadingBox.P1_COMPLETED] = glassWriteSignalStatus.LblSignals[2];
            _plcSignalLabelDict[PlcSignalForLoadingBox.P2_COMPLETED] = glassWriteSignalStatus.LblSignals[3];
            _plcSignalLabelDict[PlcSignalForLoadingBox.PLC_PASS] = glassWriteSignalStatus.LblSignals[4];
            _plcSignalLabelDict[PlcSignalForLoadingBox.SHIFT_X] = glassWriteSignal2Status.LblSignals[0];
            _plcSignalLabelDict[PlcSignalForLoadingBox.SHIFT_Y] = glassWriteSignal2Status.LblSignals[1];
            _plcSignalLabelDict[PlcSignalForLoadingBox.SHIFT_Z] = glassWriteSignal2Status.LblSignals[2];
            _plcSignalLabelDict[PlcSignalForLoadingBox.SHIFT_RX] = glassWriteSignal2Status.LblSignals[3];
            _plcSignalLabelDict[PlcSignalForLoadingBox.SHIFT_RY] = glassWriteSignal2Status.LblSignals[4];
            _plcSignalLabelDict[PlcSignalForLoadingBox.SHIFT_RZ] = glassWriteSignal2Status.LblSignals[5];
            _plcSignalLabelDict[PlcSignalForLoadingBox.SHIFT_X | PlcSignalForLoadingBox.VALUE] = glassWriteSignal2Status.LblValues[0];
            _plcSignalLabelDict[PlcSignalForLoadingBox.SHIFT_Y | PlcSignalForLoadingBox.VALUE] = glassWriteSignal2Status.LblValues[1];
            _plcSignalLabelDict[PlcSignalForLoadingBox.SHIFT_Z | PlcSignalForLoadingBox.VALUE] = glassWriteSignal2Status.LblValues[2];
            _plcSignalLabelDict[PlcSignalForLoadingBox.SHIFT_RX | PlcSignalForLoadingBox.VALUE] = glassWriteSignal2Status.LblValues[3];
            _plcSignalLabelDict[PlcSignalForLoadingBox.SHIFT_RY | PlcSignalForLoadingBox.VALUE] = glassWriteSignal2Status.LblValues[4];
            _plcSignalLabelDict[PlcSignalForLoadingBox.SHIFT_RZ | PlcSignalForLoadingBox.VALUE] = glassWriteSignal2Status.LblValues[5];
        }
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
