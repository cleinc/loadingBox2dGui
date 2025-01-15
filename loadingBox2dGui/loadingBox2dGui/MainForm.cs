using CoPick;
using CoPick.Logging;
using CoPick.Plc;
using CoPick.Setting;
using loadingBox2dGui.models;
using loadingBox2dGui.views;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;
using CoPick.Robot;

namespace loadingBox2dGui
{
    public partial class MainForm : MaterialForm, IMainForm
    {
        private static readonly LogHelper Logger = LogHelper.Logger;
        private readonly MaterialSkinManager _materialSkinManager = MaterialSkinManager.Instance;
        private PlcStatusPainter _plcStatusPainter;
        private Dictionary<PlcSignalForLoadingBox, Label> _plcSignalLabelDict;
        public MainForm(OperationMode startMode)
        {
            InitializeComponent();
            _materialSkinManager.AddFormToManage(this);

            Logger.RtbLog = rtbLog;
            Logger.MaxLine = 1000;
            Logger.ProcessName = "적재함 2D 보정 프로그램";
            this.ApplyFont();
            _plcStatusPainter = new PlcStatusPainter(gbPLC.CreateGraphics(), 20, 14);
            //_plcStatusPainter.PenColor = Color.White;
            gbPLC.Paint += gbPLC_Paint;
            LoadPlcSignalLabelDict();
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            Console.WriteLine($"Current Culture {Thread.CurrentThread.CurrentUICulture}");

            switch (startMode)
            {
                case OperationMode.Auto:
                    rbAuto_.Checked = true;
                    break;

                case OperationMode.Manual:
                    rbManual_.Checked = true;
                    break;

                case OperationMode.Set:
                    rbSet_.Checked = true;
                    break;
            }
        }

        #region Properties
        public string PlcInfo
        {
            set => tbPlc.BeginInvokeIfNeeded(() => tbPlc.Text = value);
        }
        public int CarType
        {
            get => cmbCarTypeName.InvokeIfNeeded(() => (int)cmbCarTypeName.SelectedValue);
            set => cmbCarTypeName.InvokeIfNeeded(() => cmbCarTypeName.SelectedValue = value);
        }
        public bool IsModeChanging
        {
            set
            {
                gbMode.InvokeIfNeeded(() => gbMode.Enabled = !value);
            }
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
        public bool SetLightState
        {
            set
            {
                this.InvokeIfNeeded(() =>
                {
                    if (value)
                    {
                        btnLightOff_.Text = "Light Off";
                    }
                    else
                    {
                        btnLightOff_.Text = "Light On";
                    }
                });

            }
        }

        public bool SetConnectCameraButton
        {
            set
            {
                btnCameraConnect_.InvokeIfNeeded(() =>
                {
                    btnCameraConnect_.Enabled = value;
                });
            }
        }

        public bool SetStartCameraButton
        {
            set
            {
                btnScanPoint_.InvokeIfNeeded(() =>
                {
                    btnScanPoint_.Enabled = value;
                });
            }
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
                        pbOk.Image = Properties.Resources.visionOKOn;
                        pbNg.Image = Properties.Resources.visionNGOff;
                        break;

                    case VisionStatus.NG:
                        pbOk.Image = Properties.Resources.visionOKOff;
                        pbNg.Image = Properties.Resources.visionNGOn;
                        break;

                    case VisionStatus.NONE:
                        pbOk.Image = Properties.Resources.visionOKOff;
                        pbNg.Image = Properties.Resources.visionNGOff;
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

        public void SetCarTypeList(BindingList<CarTypeAndName> carTypeList, int selectedCarType = -1)
        {
            cmbCarTypeName.InvokeIfNeeded(() =>
            {
                cmbCarTypeName.DisplayMember = "CarName";
                cmbCarTypeName.ValueMember = "CarType";
                cmbCarTypeName.DataSource = carTypeList;
                if (selectedCarType != -1 && carTypeList.Any(c => c.CarType == selectedCarType))
                {
                    cmbCarTypeName.SelectedValue = selectedCarType;
                }
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
            
            _plcSignalLabelDict[PlcSignalForLoadingBox.BODY_NO1] = plcSignalStatusValueTable2.LblSignals[3];
            _plcSignalLabelDict[PlcSignalForLoadingBox.BODY_NO2] = plcSignalStatusValueTable2.LblSignals[4];
            _plcSignalLabelDict[PlcSignalForLoadingBox.BODY_NO3] = plcSignalStatusValueTable2.LblSignals[5];
            _plcSignalLabelDict[PlcSignalForLoadingBox.BODY_NO4] = plcSignalStatusValueTable2.LblSignals[6];
            _plcSignalLabelDict[PlcSignalForLoadingBox.BODY_NO5] = plcSignalStatusValueTable2.LblSignals[7];
            _plcSignalLabelDict[PlcSignalForLoadingBox.BODY_NO1 | PlcSignalForLoadingBox.VALUE] = plcSignalStatusValueTable2.LblValues[3];
            _plcSignalLabelDict[PlcSignalForLoadingBox.BODY_NO2 | PlcSignalForLoadingBox.VALUE] = plcSignalStatusValueTable2.LblValues[4];
            _plcSignalLabelDict[PlcSignalForLoadingBox.BODY_NO3 | PlcSignalForLoadingBox.VALUE] = plcSignalStatusValueTable2.LblValues[5];
            _plcSignalLabelDict[PlcSignalForLoadingBox.BODY_NO4 | PlcSignalForLoadingBox.VALUE] = plcSignalStatusValueTable2.LblValues[6];
            _plcSignalLabelDict[PlcSignalForLoadingBox.BODY_NO5 | PlcSignalForLoadingBox.VALUE] = plcSignalStatusValueTable2.LblValues[7];

            _plcSignalLabelDict[PlcSignalForLoadingBox.VISION_UPDATE] = plcSignalStatusOnlyTable2.LblSignals[0];
            _plcSignalLabelDict[PlcSignalForLoadingBox.VISION_START] = plcSignalStatusOnlyTable2.LblSignals[1];
            _plcSignalLabelDict[PlcSignalForLoadingBox.VISION_END] = plcSignalStatusOnlyTable2.LblSignals[2];
            _plcSignalLabelDict[PlcSignalForLoadingBox.VISION_RESET] = plcSignalStatusOnlyTable2.LblSignals[3];
            _plcSignalLabelDict[PlcSignalForLoadingBox.VISION_PASS] = plcSignalStatusOnlyTable2.LblSignals[4];

            _plcSignalLabelDict[PlcSignalForLoadingBox.VISION_OK] = plcSignalStatusOnlyTable1.LblSignals[0];
            _plcSignalLabelDict[PlcSignalForLoadingBox.VISION_NG] = plcSignalStatusOnlyTable1.LblSignals[1];
            _plcSignalLabelDict[PlcSignalForLoadingBox.P1_COMPLETED] = plcSignalStatusOnlyTable1.LblSignals[2];
            _plcSignalLabelDict[PlcSignalForLoadingBox.VISION_LIVE_BIT] = plcSignalStatusOnlyTable1.LblSignals[3];

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

        public void SetUiToMode(OperationMode mode)
        {
            this.InvokeIfNeeded(() =>
            {
                btnCameraConnect_.Enabled = mode != OperationMode.Auto;
                btnScanPoint_.Enabled = mode != OperationMode.Auto;
                btnLightOff_.Enabled = mode != OperationMode.Auto;
                cmbCarTypeName.Enabled = mode != OperationMode.Auto;

                btnCameraConnect_.Enabled = mode != OperationMode.Auto;
                btnScanPoint_.Enabled = mode != OperationMode.Auto;
                gbRobotRead.Enabled = mode != OperationMode.Auto;

                btnScanPoint_.Text = (mode == OperationMode.Set) ? "Save MasterImage" : "Scan Point";
                btnUpdateMasterInstallPose_.Visible = mode == OperationMode.Set;
                btnUpdateMasterScanPose_.Visible = mode == OperationMode.Set;
                gbRobotWrite.Enabled = mode == OperationMode.Set;
                
                gbRobotReadComputed.Visible = mode == OperationMode.Set;
                btnWriteShiftPose_.Visible = mode == OperationMode.Set;
                tbShiftTx.ReadOnly = mode != OperationMode.Set;
                tbShiftTy.ReadOnly = mode != OperationMode.Set;
                tbShiftRz.ReadOnly = mode != OperationMode.Set;
            });
        }

        public void ResetToAutoMode()
        {
            rbAuto_.InvokeIfNeeded(() => rbAuto_.Checked = true );
        }

        public bool ValidatePassword()
        {
            return this.InvokeIfNeeded(() =>
            {
                using (var f = new PasswordForm_(CultureInfo.CurrentUICulture))
                {
                    var res = f.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        return true;
                    }
                    else
                    {
                        if (res == DialogResult.No)
                        {
                            MessageBox.Show("Wrong Password. Accesss Denied",
                                            "Warning");
                        }
                        return false;
                    }
                }
            });
        }

        public void SetInspectionImage(InspectionLocation location, Image image)
        {
            if (location == InspectionLocation.LH)
            {
                pbLh.InvokeIfNeeded(() =>
                {
                    if (pbLh.Image != null)
                    {
                        pbLh.Image?.Dispose();
                        pbLh.Image = null;
                    }
                    pbLh.Image = image;
                });
            }
            else if (location == InspectionLocation.RH)
            {
                pbRh.InvokeIfNeeded(() =>
                {
                    if (pbRh.Image != null)
                    {
                        pbRh.Image?.Dispose();
                        pbRh.Image = null;
                    }
                    pbRh.Image = image;
                });
            }
            else { }
        }
        public void SetReadScanPose(double[] poses)
        {
            if (poses.Length != 6)
            {
                return;
            }
            this.InvokeIfNeeded(() =>
            {
                tbReadScanPoseTxyz.Text = $"{poses[0]},{poses[1]},{poses[2]}";
                tbReadScanPoseRxyz.Text = $"{poses[3]},{poses[4]},{poses[5]}";
            });
        }
        public void SetReadInstallPose(double[] poses)
        {
            if (poses.Length != 6)
            {
                return;
            }
            this.InvokeIfNeeded(() =>
            {
                tbReadInstallPoseTxyz.Text = $"{poses[0]},{poses[1]},{poses[2]}";
                tbReadInstallPoseRxyz.Text = $"{poses[3]},{poses[4]},{poses[5]}";
            });
        }
        public void SetReadWrittenShiftPose(double[] poses)
        {
            if (poses == null || poses.Length != 6)
            {
                return;
            }
            this.InvokeIfNeeded(() =>
            {
                tbWrittenTxyz_.Text = $"{poses[0]},{poses[1]},{poses[2]}";
                tbWrittenRxyz_.Text = $"{poses[3]},{poses[4]},{poses[5]}";
            });
        }
        public void SetCalculatedShiftPose(double[] poses)
        {
            this.InvokeIfNeeded(() =>
            {
                tbShiftTx.Text = $"{poses[0]}";
                tbShiftTy.Text = $"{poses[1]}";
                tbShiftRz.Text = $"{poses[2]}";
            });
        }
        public void ShowOnDataGrid(BindingSource bindingSource)
        {
            dgvNgList.BeginInvokeIfNeeded(() =>
            {
                dgvNgList.DataSource = bindingSource;
            });
        }
        public void Init()
        {
            this.InvokeIfNeeded(() =>
            {
                tbShiftTx.Text = "";
                tbShiftTy.Text = "";
                tbShiftRz.Text = "";
            });
        }

        #endregion

        #region EventHandlers
        public event EventHandler<ModeChangedEventArgs> ChangeModeRequested;
        public event EventHandler MainFormLoadRequested;
        public event EventHandler ConnectCameraRequested;
        public event EventHandler<StartWithModifierEventArgs> ShowSettingManagerRequested;
        public event EventHandler ScanPointRequsted;
        public event EventHandler DisconnectCameraRequested;
        public event EventHandler<FormClosingEventArgs> ProgramCloseRequested;
        public event EventHandler<ChangeLightStateEventArgs> LightStateChangeRequested;
        public event EventHandler CarTypeChanged;
        public event EventHandler<SaveMasterDataEventArgs> ReadInstallPoseRequested;
        public event EventHandler<SaveMasterDataEventArgs> ReadScanPoseRequested;
        public event EventHandler<double[]> WriteTxTyRzRequested;
        public event EventHandler CheckWrittenShiftPoseRequested;
        public event EventHandler<ImagePathEventArgs> ShowScreenShotRequested;
        public event EventHandler ResetNgListRequested;
        #endregion

        private void btnCameraConnect__Click(object sender, EventArgs e)
        {
            ConnectCameraRequested?.Invoke(sender, EventArgs.Empty);
        }

        private void btnSettingManager__Click(object sender, EventArgs e)
        {
           ShowSettingManagerRequested?.Invoke(sender, new StartWithModifierEventArgs(ModifierKeys == Keys.Shift));
        }

        private void btnNgListClear__Click(object sender, EventArgs e)
        {
            ResetNgListRequested?.Invoke(sender, EventArgs.Empty);
        }

        private void btnScanPoint__Click(object sender, EventArgs e)
        {
            ScanPointRequsted?.Invoke(sender, EventArgs.Empty);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProgramCloseRequested?.Invoke(this, e);
        }

        private void btnLightOff__Click(object sender, EventArgs e)
        {
            ChangeLightStateEventArgs args;
            if (btnLightOff_.Text == "Light Off")
            {
                args = new ChangeLightStateEventArgs(true);
                btnLightOff_.Text = "Light On";
            }
            else
            {
                args = new ChangeLightStateEventArgs(false);
                btnLightOff_.Text = "Light Off";
            }
            LightStateChangeRequested?.Invoke(sender, args);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (rbAuto_.Checked)
            {
                OnModeChanged(OperationMode.Auto, true);
            }
            else if (rbManual_.Checked)
            {
                OnModeChanged(OperationMode.Manual, true);
            }
            else if (rbSet_.Checked)
            {
                OnModeChanged(OperationMode.Set, true);
            }

            MainFormLoadRequested?.Invoke(sender, EventArgs.Empty);
        }

        private void cmbCarTypeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbCarType.Text = cmbCarTypeName.SelectedValue?.ToString();
            CarTypeChanged?.Invoke(sender, EventArgs.Empty);
        }

        private void btnReadScanPose_Click(object sender, EventArgs e)
        {
            ReadScanPoseRequested?.Invoke(sender, new SaveMasterDataEventArgs(false));
        }

        private void btnWriteShiftPose_Click(object sender, EventArgs e)
        {
            double tX = tbShiftTx.Text.Length > 0 ? double.Parse(tbShiftTx.Text) : 0;
            double tY = tbShiftTy.Text.Length > 0 ? double.Parse(tbShiftTy.Text) : 0;
            double rZ = tbShiftRz.Text.Length > 0 ? double.Parse(tbShiftRz.Text) : 0;
            
            WriteTxTyRzRequested?.Invoke(sender, new double[] { tX, tY, rZ});
        }

        private void btnReadInstallPose_Click(object sender, EventArgs e)
        {
            ReadInstallPoseRequested?.Invoke(sender, new SaveMasterDataEventArgs(false));
        }

        private void rbMode_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb.Checked)
            {
                if (rb == rbSet_)
                {
                    OnModeChanged(OperationMode.Set, ModifierKeys == Keys.Shift);
                }
                else if (rb == rbAuto_)
                {
                    OnModeChanged(OperationMode.Auto, true);
                }
                else if (rb == rbManual_)
                {
                    OnModeChanged(OperationMode.Manual, ModifierKeys == Keys.Shift);
                }
            }
        }

        private void OnModeChanged(OperationMode mode, bool hasFreePassTicket)
        {
            ChangeModeRequested?.Invoke(this, new ModeChangedEventArgs(mode, hasFreePassTicket));
        }

        private void dgvNgList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RequestShowScreenShot();
            }
        }

        private void dgvNgList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvNgList.ColumnCount == 0)
            {
                return;
            }

            dgvNgList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvNgList.Columns["Id"].Visible = false;
            dgvNgList.Columns["CarType"].Visible = false;
            dgvNgList.Columns["BodyNumber"].Visible = false;
            dgvNgList.Columns["InspectionResult"].Visible = false;
            dgvNgList.Columns["ScreenShotImagePath"].Visible = false;
            dgvNgList.Columns["Tx"].Visible = false;
            dgvNgList.Columns["Ty"].Visible = false;
            dgvNgList.Columns["Rz"].Visible = false;

            dgvNgList.Columns["CarName"].HeaderText = "CAR";
            dgvNgList.Columns["SequenceNumber"].HeaderText = "SEQUENCE";
            dgvNgList.Columns["ProductionDateTime"].HeaderText = "RECORD TIME";
            dgvNgList.Columns["CarName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNgList.Columns["SequenceNumber"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNgList.Columns["ProductionDateTime"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            dgvNgList.Columns["CarName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNgList.Columns["SequenceNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNgList.Columns["ProductionDateTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            dgvNgList.Columns["CarName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNgList.Columns["SequenceNumber"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNgList.Columns["ProductionDateTime"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void RequestShowScreenShot()
        {
            string screenShotPath = dgvNgList.Rows[dgvNgList.CurrentCell.RowIndex].Cells[6].Value?.ToString();
            ShowScreenShotRequested?.Invoke(null, new ImagePathEventArgs(screenShotPath));
        }

        private void btnUpdateMasterScanPose__Click(object sender, EventArgs e)
        {
            ReadScanPoseRequested?.Invoke(sender, new SaveMasterDataEventArgs(true));
        }

        private void btnUpdateMasterInstallPose__Click(object sender, EventArgs e)
        {
            ReadInstallPoseRequested?.Invoke(sender, new SaveMasterDataEventArgs(true));
        }

        private void btnReadWrittenShiftPose__Click(object sender, EventArgs e)
        {
            CheckWrittenShiftPoseRequested?.Invoke(this, EventArgs.Empty);
        }

        private void dgvNgList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RequestShowScreenShot();
        }
    }
}