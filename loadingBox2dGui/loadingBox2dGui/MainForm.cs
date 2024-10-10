using CoPick;
using CoPick.Logging;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loadingBox2dGui
{
    public partial class MainForm : MaterialForm, IMainForm
    {
        private static readonly LogHelper Logger = LogHelper.Logger;

        private OperationMode _programMode;
        private PlcStatusPainter _plcStatusPainter;
        private Dictionary<PlcSignalForLoadingBox, Label> _plcSignalLabelDict;
        public MainForm()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);

            Logger.RtbLog = rtbLog;
            Logger.MaxLine = 1000;
            _plcStatusPainter = new PlcStatusPainter(gbPLC.CreateGraphics(), 20, 14);
            //_plcStatusPainter.PenColor = Color.White;
            gbPLC.Paint += gbPLC_Paint;
            LoadPlcSignalLabelDict();
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            Console.WriteLine($"Current Culture {Thread.CurrentThread.CurrentUICulture}");
            //FontManager.SetCustomFont("./Resources/NanumSquareRoundB.ttf");
            //this.ApplyFont();
        }

        #region Properties
        public OperationMode ProgramMode
        {
            get => _programMode;
        }
        public string PlcInfo
        {
            set => tbPlc.BeginInvokeIfNeeded(() => tbPlc.Text = value);
        }
        public int CarType
        {
            get => cmbCarTypeName.InvokeIfNeeded(() => (int)cmbCarTypeName.SelectedValue);
            set => cmbCarTypeName.InvokeIfNeeded(() => cmbCarTypeName.SelectedValue = value);
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
            get => tbCarBodyNumber.InvokeIfNeeded(() => tbCarBodyNumber.Text);
            set => tbCarBodyNumber.InvokeIfNeeded(() => 
            {
                if (value != null)
                {
                    tbCarBodyNumber.Text = value;
                }
            });
        }
        public string CarSeq 
        { 
            get => tbCarSeqNumber.InvokeIfNeeded(() => tbCarSeqNumber.Text);
            set => tbCarSeqNumber.InvokeIfNeeded(() => tbCarSeqNumber.Text = value);
        }

        public bool IsPlcConnected { get; set; }

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

        private void gbPLC_Paint(object sender, PaintEventArgs e)
        {
            _plcStatusPainter.DrawDefaultSketch(System.Threading.Thread.CurrentThread.CurrentUICulture);
            if (IsPlcConnected)
            {
                _plcStatusPainter.DrawConnStatus(PlcStatus.ON);
            }
        }

        private void LoadPlcSignalLabelDict()
        {
            _plcSignalLabelDict = new Dictionary<PlcSignalForLoadingBox, Label>();
            _plcSignalLabelDict[PlcSignalForLoadingBox.CAR_TYPE] = plcSignalStatusValueTable2.LblSignals[0];
            _plcSignalLabelDict[PlcSignalForLoadingBox.CAR_TYPE | PlcSignalForLoadingBox.VALUE] = plcSignalStatusValueTable2.LblValues[0];
            _plcSignalLabelDict[PlcSignalForLoadingBox.CAR_SEQ1] = plcSignalStatusValueTable2.LblSignals[1];
            _plcSignalLabelDict[PlcSignalForLoadingBox.CAR_SEQ2] = plcSignalStatusValueTable2.LblSignals[2];
            _plcSignalLabelDict[PlcSignalForLoadingBox.CAR_SEQ1 | PlcSignalForLoadingBox.VALUE] = plcSignalStatusValueTable2.LblValues[1];
            _plcSignalLabelDict[PlcSignalForLoadingBox.CAR_SEQ2 | PlcSignalForLoadingBox.VALUE] = plcSignalStatusValueTable2.LblValues[2];

            _plcSignalLabelDict[PlcSignalForLoadingBox.VISION_UPDATE] = plcSignalStatusOnlyTable2.LblSignals[0];
            _plcSignalLabelDict[PlcSignalForLoadingBox.VISION_START] = plcSignalStatusOnlyTable2.LblSignals[1];
            _plcSignalLabelDict[PlcSignalForLoadingBox.P1] = plcSignalStatusOnlyTable2.LblSignals[2];
            _plcSignalLabelDict[PlcSignalForLoadingBox.P2] = plcSignalStatusOnlyTable2.LblSignals[3];
            _plcSignalLabelDict[PlcSignalForLoadingBox.VISION_END] = plcSignalStatusOnlyTable2.LblSignals[4];
            _plcSignalLabelDict[PlcSignalForLoadingBox.VISION_RESET] = plcSignalStatusOnlyTable2.LblSignals[5];
            _plcSignalLabelDict[PlcSignalForLoadingBox.VISION_PASS] = plcSignalStatusOnlyTable2.LblSignals[6];

            _plcSignalLabelDict[PlcSignalForLoadingBox.VISION_OK] = plcSignalStatusOnlyTable1.LblSignals[0];
            _plcSignalLabelDict[PlcSignalForLoadingBox.VISION_NG] = plcSignalStatusOnlyTable1.LblSignals[1];
            _plcSignalLabelDict[PlcSignalForLoadingBox.P1_COMPLETED] = plcSignalStatusOnlyTable1.LblSignals[2];
            _plcSignalLabelDict[PlcSignalForLoadingBox.P2_COMPLETED] = plcSignalStatusOnlyTable1.LblSignals[3];
            _plcSignalLabelDict[PlcSignalForLoadingBox.PLC_PASS] = plcSignalStatusOnlyTable1.LblSignals[4];
            _plcSignalLabelDict[PlcSignalForLoadingBox.VISION_LIVE_BIT] = plcSignalStatusOnlyTable1.LblSignals[5];

            _plcSignalLabelDict[PlcSignalForLoadingBox.SHIFT_X] = plcSignalStatusValueTable1.LblSignals[0];
            _plcSignalLabelDict[PlcSignalForLoadingBox.SHIFT_Y] = plcSignalStatusValueTable1.LblSignals[1];
            _plcSignalLabelDict[PlcSignalForLoadingBox.SHIFT_Z] = plcSignalStatusValueTable1.LblSignals[2];
            _plcSignalLabelDict[PlcSignalForLoadingBox.SHIFT_RX] = plcSignalStatusValueTable1.LblSignals[3];
            _plcSignalLabelDict[PlcSignalForLoadingBox.SHIFT_RY] = plcSignalStatusValueTable1.LblSignals[4];
            _plcSignalLabelDict[PlcSignalForLoadingBox.SHIFT_RZ] = plcSignalStatusValueTable1.LblSignals[5];
            _plcSignalLabelDict[PlcSignalForLoadingBox.SHIFT_X | PlcSignalForLoadingBox.VALUE] = plcSignalStatusValueTable1.LblValues[0];
            _plcSignalLabelDict[PlcSignalForLoadingBox.SHIFT_Y | PlcSignalForLoadingBox.VALUE] = plcSignalStatusValueTable1.LblValues[1];
            _plcSignalLabelDict[PlcSignalForLoadingBox.SHIFT_Z | PlcSignalForLoadingBox.VALUE] = plcSignalStatusValueTable1.LblValues[2];
            _plcSignalLabelDict[PlcSignalForLoadingBox.SHIFT_RX | PlcSignalForLoadingBox.VALUE] = plcSignalStatusValueTable1.LblValues[3];
            _plcSignalLabelDict[PlcSignalForLoadingBox.SHIFT_RY | PlcSignalForLoadingBox.VALUE] = plcSignalStatusValueTable1.LblValues[4];
            _plcSignalLabelDict[PlcSignalForLoadingBox.SHIFT_RZ | PlcSignalForLoadingBox.VALUE] = plcSignalStatusValueTable1.LblValues[5];
        }
        #endregion

        #region EventHandlers
        public event EventHandler<ChangeModeEventArgs> ChangeModeRequested;
        public event EventHandler ConnectCameraRequested;
        public event EventHandler ShowSettingManagerRequested;
        public event EventHandler CalculateRequested;
        public event EventHandler UpdateRequested;
        public event EventHandler GetReferenceDataPathRequested;
        public event EventHandler GetHandEyeCalibrationFilePathRequested;
        public event EventHandler ScanPointRequsted;
        public event EventHandler DisconnectLhCameraRequested;
        public event EventHandler<FormClosingEventArgs> ProgramCloseRequested;
        public event EventHandler<ChangeLightStateEventArgs> LightStateChangeRequested;

        private void btnCameraConnect__Click(object sender, System.EventArgs e)
        {
            ConnectCameraRequested?.Invoke(sender, EventArgs.Empty);
        }

        private void btnSettingManager__Click(object sender, System.EventArgs e)
        {
            ChangeLightStateEventArgs args;
            if (btnSettingManager_.Text == "Light Off")
            {
                args = new ChangeLightStateEventArgs(true);
                btnSettingManager_.Text = "Light On";
            }
            else
            {
                args = new ChangeLightStateEventArgs(false);
                btnSettingManager_.Text = "Light Off";
            }
            LightStateChangeRequested?.Invoke(sender, args);
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
            ScanPointRequsted?.Invoke(sender, EventArgs.Empty);
        }
        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProgramCloseRequested?.Invoke(this, e);
        }

        private void rbAuto__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked && rb.Name == "rbAuto_")
            {
                ChangeModeRequested?.Invoke(sender, new ChangeModeEventArgs(OperationMode.Auto, true));
            }
        }
    }
}
