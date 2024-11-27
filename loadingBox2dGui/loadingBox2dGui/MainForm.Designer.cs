using System.Windows.Forms;

namespace loadingBox2dGui
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.materialCard15 = new MaterialSkin.Controls.MaterialCard();
            this.lblRH_ = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard14 = new MaterialSkin.Controls.MaterialCard();
            this.lblLH_ = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.btnStartCamera_ = new MaterialSkin.Controls.MaterialButton();
            this.btnCameraConnect_ = new MaterialSkin.Controls.MaterialButton();
            this.btnLightOff_ = new MaterialSkin.Controls.MaterialButton();
            this.pbRh = new System.Windows.Forms.PictureBox();
            this.pbLh = new System.Windows.Forms.PictureBox();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.materialTextBox24 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox25 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox26 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox22 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.tlpGlassCamera = new System.Windows.Forms.TableLayoutPanel();
            this.ckbGlassCameraUse4 = new MaterialSkin.Controls.MaterialCheckbox();
            this.tbGlassCameraSerial1 = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblGlassCameraAlias1 = new MaterialSkin.Controls.MaterialLabel();
            this.ckbGlassCameraUse1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.lblGlassCameraAlias4 = new MaterialSkin.Controls.MaterialLabel();
            this.ckbGlassCameraUse2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.tbGlassCameraSerial3 = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblGlassCameraAlias3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblGlassCameraAlias2 = new MaterialSkin.Controls.MaterialLabel();
            this.tbGlassCameraSerial2 = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbGlassCameraSerial4 = new MaterialSkin.Controls.MaterialTextBox2();
            this.ckbGlassCameraUse3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialTextBox23 = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnConnectPlc_ = new MaterialSkin.Controls.MaterialButton();
            this.pbOk = new System.Windows.Forms.PictureBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.plcSignalStatusOnlyTable1 = new CoPick.Controls.PlcSignalStatusOnlyTable();
            this.plcSignalStatusValueTable1 = new CoPick.Controls.PlcSignalStatusValueTable();
            this.pbNg = new System.Windows.Forms.PictureBox();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.plcSignalStatusOnlyTable2 = new CoPick.Controls.PlcSignalStatusOnlyTable();
            this.plcSignalStatusValueTable2 = new CoPick.Controls.PlcSignalStatusValueTable();
            this.gbGlassUserControl_ = new MaterialSkin.Controls.MaterialCard();
            this.btnGlassBackUp_ = new MaterialSkin.Controls.MaterialButton();
            this.lblGlassRHCamera_ = new MaterialSkin.Controls.MaterialButton();
            this.lblGlassLHCamera_ = new MaterialSkin.Controls.MaterialButton();
            this.btnGlassRHCameraUnuse_ = new MaterialSkin.Controls.MaterialButton();
            this.btnGlassRHCameraUse_ = new MaterialSkin.Controls.MaterialButton();
            this.btnGlassLHCameraUnuse_ = new MaterialSkin.Controls.MaterialButton();
            this.btnGlassLHCameraUse_ = new MaterialSkin.Controls.MaterialButton();
            this.label85_ = new MaterialSkin.Controls.MaterialLabel();
            this.tbGlassRefDataPath = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnGlassRefDataPath = new MaterialSkin.Controls.MaterialButton();
            this.label86_ = new MaterialSkin.Controls.MaterialLabel();
            this.tbGlassHandEyeCalibFilePath = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnGlassHandEyeCalibFilePath = new MaterialSkin.Controls.MaterialButton();
            this.btnGlassUpdate_ = new MaterialSkin.Controls.MaterialButton();
            this.btnGlassCalculate_ = new MaterialSkin.Controls.MaterialButton();
            this.gbGlassShiftValue_ = new MaterialSkin.Controls.MaterialCard();
            this.label88 = new MaterialSkin.Controls.MaterialLabel();
            this.tbGlassShiftValueRz = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbGlassShiftValueTx = new MaterialSkin.Controls.MaterialTextBox2();
            this.label79 = new MaterialSkin.Controls.MaterialLabel();
            this.label80 = new MaterialSkin.Controls.MaterialLabel();
            this.tbGlassShiftValueTy = new MaterialSkin.Controls.MaterialTextBox2();
            this.gbGlassPoint_ = new MaterialSkin.Controls.MaterialCard();
            this.tbGlassPointTx = new MaterialSkin.Controls.MaterialTextBox2();
            this.label73 = new MaterialSkin.Controls.MaterialLabel();
            this.label74 = new MaterialSkin.Controls.MaterialLabel();
            this.label75 = new MaterialSkin.Controls.MaterialLabel();
            this.label76 = new MaterialSkin.Controls.MaterialLabel();
            this.label77 = new MaterialSkin.Controls.MaterialLabel();
            this.label78 = new MaterialSkin.Controls.MaterialLabel();
            this.tbGlassPointTy = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbGlassPointTz = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbGlassPointRx = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbGlassPointRz = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbGlassPointRy = new MaterialSkin.Controls.MaterialTextBox2();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.btnNgListClear_ = new MaterialSkin.Controls.MaterialButton();
            this.lblErrorNotice = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelNgListViewHeader = new System.Windows.Forms.Panel();
            this.lblDashDate = new MaterialSkin.Controls.MaterialLabel();
            this.lblDashType = new MaterialSkin.Controls.MaterialLabel();
            this.lblDashCarSeqNum = new MaterialSkin.Controls.MaterialLabel();
            this.lblDashCarType = new MaterialSkin.Controls.MaterialLabel();
            this.ltvNG = new System.Windows.Forms.ListView();
            this.rtbLog = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbGlassMaxValueRz = new MaterialSkin.Controls.MaterialTextBox2();
            this.label90 = new MaterialSkin.Controls.MaterialLabel();
            this.tbGlassMaxValueTy = new MaterialSkin.Controls.MaterialTextBox2();
            this.label94 = new MaterialSkin.Controls.MaterialLabel();
            this.tbGlassMaxValueTx = new MaterialSkin.Controls.MaterialTextBox2();
            this.label95 = new MaterialSkin.Controls.MaterialLabel();
            this.glassWriteSignalStatus = new CoPick.Controls.PlcSignalStatusOnlyTable();
            this.glassWriteSignal2Status = new CoPick.Controls.PlcSignalStatusValueTable();
            this.label92 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox1 = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblGlassCameraModel_ = new MaterialSkin.Controls.MaterialLabel();
            this.lblGlassCameraSerials_ = new MaterialSkin.Controls.MaterialLabel();
            this.tbGlassCamera = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblGlassCamera_ = new MaterialSkin.Controls.MaterialLabel();
            this.tbGlassCameraModel = new MaterialSkin.Controls.MaterialTextBox2();
            this.glassReadSignalStatus = new CoPick.Controls.PlcSignalStatusOnlyTable();
            this.carTypeSignalStatus = new CoPick.Controls.PlcSignalStatusValueTable();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbMode = new MaterialSkin.Controls.MaterialCard();
            this.rbManual_ = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbSet_ = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbAuto_ = new MaterialSkin.Controls.MaterialRadioButton();
            this.gbPLC = new MaterialSkin.Controls.MaterialCard();
            this.lblPlc = new MaterialSkin.Controls.MaterialLabel();
            this.tbPlc = new MaterialSkin.Controls.MaterialTextBox2();
            this.gbCarType = new MaterialSkin.Controls.MaterialCard();
            this.tbCarType = new MaterialSkin.Controls.MaterialTextBox2();
            this.cmbCarTypeName = new MaterialSkin.Controls.MaterialComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.tbCarBodyNumber = new MaterialSkin.Controls.MaterialTextBox2();
            this.gbCarSeqNumber_ = new MaterialSkin.Controls.MaterialCard();
            this.tbCarSeqNumber = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnSettingManage_ = new MaterialSkin.Controls.MaterialButton();
            this.label22 = new MaterialSkin.Controls.MaterialLabel();
            this.gbRobotRead = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel24 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.tbScanPoseRz_ = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbScanPoseTz_ = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnReadScanPose_ = new MaterialSkin.Controls.MaterialButton();
            this.tbCurrRobotTz = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbCurrRobotRx = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbScanPoseRx_ = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbScanPoseTx_ = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel23 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel22 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.tbScanPoseRy_ = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbScanPoseTy_ = new MaterialSkin.Controls.MaterialTextBox2();
            this.gbRobotWrite = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.btnWriteShiftPose_ = new MaterialSkin.Controls.MaterialButton();
            this.tbShiftRzR1 = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbShiftTxR1 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel28 = new MaterialSkin.Controls.MaterialLabel();
            this.tbShiftTyR1 = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbWrittenTx_ = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbWrittenTy_ = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbWrittenRz_ = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel25 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            this.btnReadWrittenShiftPose_ = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel21 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel27 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel29 = new MaterialSkin.Controls.MaterialLabel();
            this.tbInstallPoseRz_ = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbInstallPoseTz_ = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnReadInstallPose_ = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox29 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBox210 = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbInstallPoseRx_ = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbInstallPoseTx_ = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel32 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel33 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel34 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel35 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel36 = new MaterialSkin.Controls.MaterialLabel();
            this.tbInstallPoseRy_ = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbInstallPoseTy_ = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel31 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.materialCard15.SuspendLayout();
            this.materialCard14.SuspendLayout();
            this.materialCard6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLh)).BeginInit();
            this.materialCard4.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.tlpGlassCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOk)).BeginInit();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNg)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.gbGlassUserControl_.SuspendLayout();
            this.gbGlassShiftValue_.SuspendLayout();
            this.gbGlassPoint_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelNgListViewHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbMode.SuspendLayout();
            this.gbPLC.SuspendLayout();
            this.gbCarType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.gbCarSeqNumber_.SuspendLayout();
            this.gbRobotRead.SuspendLayout();
            this.gbRobotWrite.SuspendLayout();
            this.materialCard7.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.materialCard15);
            this.splitContainer2.Panel1.Controls.Add(this.materialCard14);
            this.splitContainer2.Panel1.Controls.Add(this.materialCard6);
            this.splitContainer2.Panel1.Controls.Add(this.pbRh);
            this.splitContainer2.Panel1.Controls.Add(this.pbLh);
            this.splitContainer2.Panel1.Controls.Add(this.materialCard4);
            this.splitContainer2.Panel1.Controls.Add(this.materialCard3);
            this.splitContainer2.Panel1.Controls.Add(this.btnConnectPlc_);
            this.splitContainer2.Panel1.Controls.Add(this.pbOk);
            this.splitContainer2.Panel1.Controls.Add(this.materialCard1);
            this.splitContainer2.Panel1.Controls.Add(this.pbNg);
            this.splitContainer2.Panel1.Controls.Add(this.materialCard2);
            this.splitContainer2.Panel1.Controls.Add(this.gbGlassUserControl_);
            this.splitContainer2.Panel1.Controls.Add(this.label85_);
            this.splitContainer2.Panel1.Controls.Add(this.tbGlassRefDataPath);
            this.splitContainer2.Panel1.Controls.Add(this.btnGlassRefDataPath);
            this.splitContainer2.Panel1.Controls.Add(this.label86_);
            this.splitContainer2.Panel1.Controls.Add(this.tbGlassHandEyeCalibFilePath);
            this.splitContainer2.Panel1.Controls.Add(this.btnGlassHandEyeCalibFilePath);
            this.splitContainer2.Panel1.Controls.Add(this.btnGlassUpdate_);
            this.splitContainer2.Panel1.Controls.Add(this.btnGlassCalculate_);
            this.splitContainer2.Panel1.Controls.Add(this.gbGlassShiftValue_);
            this.splitContainer2.Panel1.Controls.Add(this.gbGlassPoint_);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.splitContainer2.Size = new System.Drawing.Size(1914, 925);
            this.splitContainer2.SplitterDistance = 1331;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 107;
            this.splitContainer2.TabStop = false;
            // 
            // materialCard15
            // 
            this.materialCard15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard15.Controls.Add(this.lblRH_);
            this.materialCard15.Depth = 0;
            this.materialCard15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard15.Location = new System.Drawing.Point(560, 11);
            this.materialCard15.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard15.Name = "materialCard15";
            this.materialCard15.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard15.Size = new System.Drawing.Size(58, 37);
            this.materialCard15.TabIndex = 195;
            // 
            // lblRH_
            // 
            this.lblRH_.AutoSize = true;
            this.lblRH_.BackColor = System.Drawing.Color.Transparent;
            this.lblRH_.Depth = 0;
            this.lblRH_.Font = new System.Drawing.Font("NanumSquareRound Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblRH_.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblRH_.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRH_.Location = new System.Drawing.Point(12, 6);
            this.lblRH_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRH_.Name = "lblRH_";
            this.lblRH_.Size = new System.Drawing.Size(34, 26);
            this.lblRH_.TabIndex = 0;
            this.lblRH_.Text = "RH";
            // 
            // materialCard14
            // 
            this.materialCard14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard14.Controls.Add(this.lblLH_);
            this.materialCard14.Depth = 0;
            this.materialCard14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard14.Location = new System.Drawing.Point(12, 11);
            this.materialCard14.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard14.Name = "materialCard14";
            this.materialCard14.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard14.Size = new System.Drawing.Size(58, 37);
            this.materialCard14.TabIndex = 196;
            // 
            // lblLH_
            // 
            this.lblLH_.AutoSize = true;
            this.lblLH_.BackColor = System.Drawing.Color.Transparent;
            this.lblLH_.Depth = 0;
            this.lblLH_.Font = new System.Drawing.Font("NanumSquareRound Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblLH_.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblLH_.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLH_.Location = new System.Drawing.Point(14, 7);
            this.lblLH_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLH_.Name = "lblLH_";
            this.lblLH_.Size = new System.Drawing.Size(31, 26);
            this.lblLH_.TabIndex = 0;
            this.lblLH_.Text = "LH";
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.materialCard7);
            this.materialCard6.Controls.Add(this.gbRobotRead);
            this.materialCard6.Controls.Add(this.gbRobotWrite);
            this.materialCard6.Controls.Add(this.btnStartCamera_);
            this.materialCard6.Controls.Add(this.btnCameraConnect_);
            this.materialCard6.Controls.Add(this.btnLightOff_);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(6, 544);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(1097, 395);
            this.materialCard6.TabIndex = 194;
            // 
            // btnStartCamera_
            // 
            this.btnStartCamera_.AutoSize = false;
            this.btnStartCamera_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStartCamera_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(215)))), ((int)(((byte)(73)))));
            this.btnStartCamera_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnStartCamera_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStartCamera_.Depth = 0;
            this.btnStartCamera_.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnStartCamera_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartCamera_.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnStartCamera_.HighEmphasis = true;
            this.btnStartCamera_.Icon = null;
            this.btnStartCamera_.Location = new System.Drawing.Point(25, 253);
            this.btnStartCamera_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStartCamera_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStartCamera_.Name = "btnStartCamera_";
            this.btnStartCamera_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStartCamera_.Size = new System.Drawing.Size(325, 94);
            this.btnStartCamera_.TabIndex = 22;
            this.btnStartCamera_.Text = "Start Camera";
            this.btnStartCamera_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStartCamera_.UseAccentColor = false;
            this.btnStartCamera_.UseVisualStyleBackColor = false;
            this.btnStartCamera_.Click += new System.EventHandler(this.btnGlassPoint__Click);
            // 
            // btnCameraConnect_
            // 
            this.btnCameraConnect_.AutoSize = false;
            this.btnCameraConnect_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCameraConnect_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(65)))));
            this.btnCameraConnect_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnCameraConnect_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCameraConnect_.Depth = 0;
            this.btnCameraConnect_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCameraConnect_.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnCameraConnect_.HighEmphasis = true;
            this.btnCameraConnect_.Icon = null;
            this.btnCameraConnect_.Location = new System.Drawing.Point(25, 137);
            this.btnCameraConnect_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCameraConnect_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCameraConnect_.Name = "btnCameraConnect_";
            this.btnCameraConnect_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCameraConnect_.Size = new System.Drawing.Size(325, 93);
            this.btnCameraConnect_.TabIndex = 106;
            this.btnCameraConnect_.Text = "Camera Connect";
            this.btnCameraConnect_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCameraConnect_.UseAccentColor = false;
            this.btnCameraConnect_.UseVisualStyleBackColor = false;
            this.btnCameraConnect_.Click += new System.EventHandler(this.btnCameraConnect__Click);
            // 
            // btnLightOff_
            // 
            this.btnLightOff_.AutoSize = false;
            this.btnLightOff_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLightOff_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(65)))));
            this.btnLightOff_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnLightOff_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLightOff_.Depth = 0;
            this.btnLightOff_.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnLightOff_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLightOff_.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnLightOff_.ForeColor = System.Drawing.Color.Black;
            this.btnLightOff_.HighEmphasis = true;
            this.btnLightOff_.Icon = null;
            this.btnLightOff_.Location = new System.Drawing.Point(23, 33);
            this.btnLightOff_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLightOff_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLightOff_.Name = "btnLightOff_";
            this.btnLightOff_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLightOff_.Size = new System.Drawing.Size(325, 87);
            this.btnLightOff_.TabIndex = 3;
            this.btnLightOff_.Text = "Light Off";
            this.btnLightOff_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLightOff_.UseAccentColor = false;
            this.btnLightOff_.UseVisualStyleBackColor = false;
            this.btnLightOff_.Click += new System.EventHandler(this.btnLightOff__Click);
            // 
            // pbRh
            // 
            this.pbRh.BackColor = System.Drawing.Color.LightGray;
            this.pbRh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbRh.Location = new System.Drawing.Point(553, 5);
            this.pbRh.Name = "pbRh";
            this.pbRh.Size = new System.Drawing.Size(542, 532);
            this.pbRh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRh.TabIndex = 193;
            this.pbRh.TabStop = false;
            // 
            // pbLh
            // 
            this.pbLh.BackColor = System.Drawing.Color.LightGray;
            this.pbLh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLh.Location = new System.Drawing.Point(6, 5);
            this.pbLh.Name = "pbLh";
            this.pbLh.Size = new System.Drawing.Size(542, 532);
            this.pbLh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLh.TabIndex = 193;
            this.pbLh.TabStop = false;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.materialTextBox24);
            this.materialCard4.Controls.Add(this.materialLabel5);
            this.materialCard4.Controls.Add(this.materialTextBox25);
            this.materialCard4.Controls.Add(this.materialLabel6);
            this.materialCard4.Controls.Add(this.materialTextBox26);
            this.materialCard4.Controls.Add(this.materialLabel7);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(615, 685);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(305, 125);
            this.materialCard4.TabIndex = 192;
            this.materialCard4.Visible = false;
            // 
            // materialTextBox24
            // 
            this.materialTextBox24.AnimateReadOnly = false;
            this.materialTextBox24.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.materialTextBox24.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.materialTextBox24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox24.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox24.Depth = 0;
            this.materialTextBox24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox24.HideSelection = true;
            this.materialTextBox24.LeadingIcon = null;
            this.materialTextBox24.Location = new System.Drawing.Point(82, 89);
            this.materialTextBox24.MaxLength = 32767;
            this.materialTextBox24.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox24.Name = "materialTextBox24";
            this.materialTextBox24.PasswordChar = '\0';
            this.materialTextBox24.PrefixSuffixText = null;
            this.materialTextBox24.ReadOnly = false;
            this.materialTextBox24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox24.SelectedText = "";
            this.materialTextBox24.SelectionLength = 0;
            this.materialTextBox24.SelectionStart = 0;
            this.materialTextBox24.ShortcutsEnabled = true;
            this.materialTextBox24.Size = new System.Drawing.Size(172, 26);
            this.materialTextBox24.TabIndex = 11;
            this.materialTextBox24.TabStop = false;
            this.materialTextBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox24.TrailingIcon = null;
            this.materialTextBox24.UseSystemPasswordChar = false;
            this.materialTextBox24.UseTallSize = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(56, 92);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(19, 18);
            this.materialLabel5.TabIndex = 10;
            this.materialLabel5.Text = "Rz";
            // 
            // materialTextBox25
            // 
            this.materialTextBox25.AnimateReadOnly = false;
            this.materialTextBox25.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.materialTextBox25.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.materialTextBox25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox25.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox25.Depth = 0;
            this.materialTextBox25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox25.HideSelection = true;
            this.materialTextBox25.LeadingIcon = null;
            this.materialTextBox25.Location = new System.Drawing.Point(82, 56);
            this.materialTextBox25.MaxLength = 32767;
            this.materialTextBox25.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox25.Name = "materialTextBox25";
            this.materialTextBox25.PasswordChar = '\0';
            this.materialTextBox25.PrefixSuffixText = null;
            this.materialTextBox25.ReadOnly = false;
            this.materialTextBox25.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox25.SelectedText = "";
            this.materialTextBox25.SelectionLength = 0;
            this.materialTextBox25.SelectionStart = 0;
            this.materialTextBox25.ShortcutsEnabled = true;
            this.materialTextBox25.Size = new System.Drawing.Size(172, 26);
            this.materialTextBox25.TabIndex = 3;
            this.materialTextBox25.TabStop = false;
            this.materialTextBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox25.TrailingIcon = null;
            this.materialTextBox25.UseSystemPasswordChar = false;
            this.materialTextBox25.UseTallSize = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(56, 60);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(19, 18);
            this.materialLabel6.TabIndex = 2;
            this.materialLabel6.Text = "Ty";
            // 
            // materialTextBox26
            // 
            this.materialTextBox26.AnimateReadOnly = false;
            this.materialTextBox26.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.materialTextBox26.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.materialTextBox26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox26.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox26.Depth = 0;
            this.materialTextBox26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox26.HideSelection = true;
            this.materialTextBox26.LeadingIcon = null;
            this.materialTextBox26.Location = new System.Drawing.Point(82, 23);
            this.materialTextBox26.MaxLength = 32767;
            this.materialTextBox26.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox26.Name = "materialTextBox26";
            this.materialTextBox26.PasswordChar = '\0';
            this.materialTextBox26.PrefixSuffixText = null;
            this.materialTextBox26.ReadOnly = false;
            this.materialTextBox26.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox26.SelectedText = "";
            this.materialTextBox26.SelectionLength = 0;
            this.materialTextBox26.SelectionStart = 0;
            this.materialTextBox26.ShortcutsEnabled = true;
            this.materialTextBox26.Size = new System.Drawing.Size(172, 26);
            this.materialTextBox26.TabIndex = 1;
            this.materialTextBox26.TabStop = false;
            this.materialTextBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox26.TrailingIcon = null;
            this.materialTextBox26.UseSystemPasswordChar = false;
            this.materialTextBox26.UseTallSize = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(56, 27);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(18, 18);
            this.materialLabel7.TabIndex = 0;
            this.materialLabel7.Text = "Tx";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialLabel1);
            this.materialCard3.Controls.Add(this.materialTextBox21);
            this.materialCard3.Controls.Add(this.materialLabel2);
            this.materialCard3.Controls.Add(this.materialLabel3);
            this.materialCard3.Controls.Add(this.materialTextBox22);
            this.materialCard3.Controls.Add(this.materialLabel4);
            this.materialCard3.Controls.Add(this.tlpGlassCamera);
            this.materialCard3.Controls.Add(this.materialTextBox23);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(936, 652);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(167, 289);
            this.materialCard3.TabIndex = 191;
            this.materialCard3.Visible = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(-906, -434);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(24, 18);
            this.materialLabel1.TabIndex = 151;
            this.materialLabel1.Text = "lab";
            // 
            // materialTextBox21
            // 
            this.materialTextBox21.AnimateReadOnly = false;
            this.materialTextBox21.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.materialTextBox21.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.materialTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox21.Depth = 0;
            this.materialTextBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox21.HideSelection = true;
            this.materialTextBox21.LeadingIcon = null;
            this.materialTextBox21.Location = new System.Drawing.Point(-875, -439);
            this.materialTextBox21.MaxLength = 32767;
            this.materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox21.Name = "materialTextBox21";
            this.materialTextBox21.PasswordChar = '\0';
            this.materialTextBox21.PrefixSuffixText = null;
            this.materialTextBox21.ReadOnly = true;
            this.materialTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox21.SelectedText = "";
            this.materialTextBox21.SelectionLength = 0;
            this.materialTextBox21.SelectionStart = 0;
            this.materialTextBox21.ShortcutsEnabled = true;
            this.materialTextBox21.Size = new System.Drawing.Size(91, 26);
            this.materialTextBox21.TabIndex = 150;
            this.materialTextBox21.TabStop = false;
            this.materialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox21.TrailingIcon = null;
            this.materialTextBox21.UseSystemPasswordChar = false;
            this.materialTextBox21.UseTallSize = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(16, 83);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(48, 18);
            this.materialLabel2.TabIndex = 28;
            this.materialLabel2.Text = "Model";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(16, 142);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(52, 18);
            this.materialLabel3.TabIndex = 27;
            this.materialLabel3.Text = "Serials";
            // 
            // materialTextBox22
            // 
            this.materialTextBox22.AnimateReadOnly = false;
            this.materialTextBox22.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.materialTextBox22.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.materialTextBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox22.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox22.Depth = 0;
            this.materialTextBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox22.HideSelection = true;
            this.materialTextBox22.LeadingIcon = null;
            this.materialTextBox22.Location = new System.Drawing.Point(13, 50);
            this.materialTextBox22.MaxLength = 32767;
            this.materialTextBox22.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox22.Name = "materialTextBox22";
            this.materialTextBox22.PasswordChar = '\0';
            this.materialTextBox22.PrefixSuffixText = null;
            this.materialTextBox22.ReadOnly = true;
            this.materialTextBox22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox22.SelectedText = "";
            this.materialTextBox22.SelectionLength = 0;
            this.materialTextBox22.SelectionStart = 0;
            this.materialTextBox22.ShortcutsEnabled = true;
            this.materialTextBox22.Size = new System.Drawing.Size(142, 26);
            this.materialTextBox22.TabIndex = 20;
            this.materialTextBox22.TabStop = false;
            this.materialTextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox22.TrailingIcon = null;
            this.materialTextBox22.UseSystemPasswordChar = false;
            this.materialTextBox22.UseTallSize = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(16, 28);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(45, 18);
            this.materialLabel4.TabIndex = 26;
            this.materialLabel4.Text = "Name";
            // 
            // tlpGlassCamera
            // 
            this.tlpGlassCamera.BackColor = System.Drawing.Color.White;
            this.tlpGlassCamera.ColumnCount = 3;
            this.tlpGlassCamera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpGlassCamera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tlpGlassCamera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpGlassCamera.Controls.Add(this.ckbGlassCameraUse4, 2, 3);
            this.tlpGlassCamera.Controls.Add(this.tbGlassCameraSerial1, 1, 0);
            this.tlpGlassCamera.Controls.Add(this.lblGlassCameraAlias1, 0, 0);
            this.tlpGlassCamera.Controls.Add(this.ckbGlassCameraUse1, 2, 0);
            this.tlpGlassCamera.Controls.Add(this.lblGlassCameraAlias4, 0, 3);
            this.tlpGlassCamera.Controls.Add(this.ckbGlassCameraUse2, 2, 1);
            this.tlpGlassCamera.Controls.Add(this.tbGlassCameraSerial3, 1, 2);
            this.tlpGlassCamera.Controls.Add(this.lblGlassCameraAlias3, 0, 2);
            this.tlpGlassCamera.Controls.Add(this.lblGlassCameraAlias2, 0, 1);
            this.tlpGlassCamera.Controls.Add(this.tbGlassCameraSerial2, 1, 1);
            this.tlpGlassCamera.Controls.Add(this.tbGlassCameraSerial4, 1, 3);
            this.tlpGlassCamera.Controls.Add(this.ckbGlassCameraUse3, 2, 2);
            this.tlpGlassCamera.Location = new System.Drawing.Point(6, 164);
            this.tlpGlassCamera.Name = "tlpGlassCamera";
            this.tlpGlassCamera.RowCount = 4;
            this.tlpGlassCamera.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpGlassCamera.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpGlassCamera.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpGlassCamera.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpGlassCamera.Size = new System.Drawing.Size(156, 123);
            this.tlpGlassCamera.TabIndex = 160;
            // 
            // ckbGlassCameraUse4
            // 
            this.ckbGlassCameraUse4.AutoCheck = false;
            this.ckbGlassCameraUse4.AutoSize = true;
            this.ckbGlassCameraUse4.BackColor = System.Drawing.Color.Transparent;
            this.ckbGlassCameraUse4.Checked = true;
            this.ckbGlassCameraUse4.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.ckbGlassCameraUse4.Depth = 0;
            this.ckbGlassCameraUse4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckbGlassCameraUse4.Location = new System.Drawing.Point(137, 93);
            this.ckbGlassCameraUse4.Margin = new System.Windows.Forms.Padding(0);
            this.ckbGlassCameraUse4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckbGlassCameraUse4.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckbGlassCameraUse4.Name = "ckbGlassCameraUse4";
            this.ckbGlassCameraUse4.ReadOnly = false;
            this.ckbGlassCameraUse4.Ripple = true;
            this.ckbGlassCameraUse4.Size = new System.Drawing.Size(46, 31);
            this.ckbGlassCameraUse4.TabIndex = 158;
            this.ckbGlassCameraUse4.UseVisualStyleBackColor = false;
            // 
            // tbGlassCameraSerial1
            // 
            this.tbGlassCameraSerial1.AnimateReadOnly = false;
            this.tbGlassCameraSerial1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbGlassCameraSerial1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbGlassCameraSerial1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbGlassCameraSerial1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbGlassCameraSerial1.Depth = 0;
            this.tbGlassCameraSerial1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGlassCameraSerial1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGlassCameraSerial1.HideSelection = true;
            this.tbGlassCameraSerial1.LeadingIcon = null;
            this.tbGlassCameraSerial1.Location = new System.Drawing.Point(35, 3);
            this.tbGlassCameraSerial1.MaxLength = 32767;
            this.tbGlassCameraSerial1.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGlassCameraSerial1.Name = "tbGlassCameraSerial1";
            this.tbGlassCameraSerial1.PasswordChar = '\0';
            this.tbGlassCameraSerial1.PrefixSuffixText = null;
            this.tbGlassCameraSerial1.ReadOnly = true;
            this.tbGlassCameraSerial1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbGlassCameraSerial1.SelectedText = "";
            this.tbGlassCameraSerial1.SelectionLength = 0;
            this.tbGlassCameraSerial1.SelectionStart = 0;
            this.tbGlassCameraSerial1.ShortcutsEnabled = true;
            this.tbGlassCameraSerial1.Size = new System.Drawing.Size(99, 26);
            this.tbGlassCameraSerial1.TabIndex = 165;
            this.tbGlassCameraSerial1.TabStop = false;
            this.tbGlassCameraSerial1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbGlassCameraSerial1.TrailingIcon = null;
            this.tbGlassCameraSerial1.UseSystemPasswordChar = false;
            this.tbGlassCameraSerial1.UseTallSize = false;
            // 
            // lblGlassCameraAlias1
            // 
            this.lblGlassCameraAlias1.AutoSize = true;
            this.lblGlassCameraAlias1.BackColor = System.Drawing.Color.Transparent;
            this.lblGlassCameraAlias1.Depth = 0;
            this.lblGlassCameraAlias1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGlassCameraAlias1.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGlassCameraAlias1.Location = new System.Drawing.Point(0, 0);
            this.lblGlassCameraAlias1.Margin = new System.Windows.Forms.Padding(0);
            this.lblGlassCameraAlias1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGlassCameraAlias1.Name = "lblGlassCameraAlias1";
            this.lblGlassCameraAlias1.Size = new System.Drawing.Size(32, 31);
            this.lblGlassCameraAlias1.TabIndex = 162;
            this.lblGlassCameraAlias1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckbGlassCameraUse1
            // 
            this.ckbGlassCameraUse1.AutoCheck = false;
            this.ckbGlassCameraUse1.AutoSize = true;
            this.ckbGlassCameraUse1.BackColor = System.Drawing.Color.Transparent;
            this.ckbGlassCameraUse1.Checked = true;
            this.ckbGlassCameraUse1.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.ckbGlassCameraUse1.Depth = 0;
            this.ckbGlassCameraUse1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckbGlassCameraUse1.Location = new System.Drawing.Point(137, 0);
            this.ckbGlassCameraUse1.Margin = new System.Windows.Forms.Padding(0);
            this.ckbGlassCameraUse1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckbGlassCameraUse1.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckbGlassCameraUse1.Name = "ckbGlassCameraUse1";
            this.ckbGlassCameraUse1.ReadOnly = false;
            this.ckbGlassCameraUse1.Ripple = true;
            this.ckbGlassCameraUse1.Size = new System.Drawing.Size(46, 31);
            this.ckbGlassCameraUse1.TabIndex = 160;
            this.ckbGlassCameraUse1.UseVisualStyleBackColor = false;
            // 
            // lblGlassCameraAlias4
            // 
            this.lblGlassCameraAlias4.AutoSize = true;
            this.lblGlassCameraAlias4.BackColor = System.Drawing.Color.Transparent;
            this.lblGlassCameraAlias4.Depth = 0;
            this.lblGlassCameraAlias4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGlassCameraAlias4.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGlassCameraAlias4.Location = new System.Drawing.Point(0, 93);
            this.lblGlassCameraAlias4.Margin = new System.Windows.Forms.Padding(0);
            this.lblGlassCameraAlias4.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGlassCameraAlias4.Name = "lblGlassCameraAlias4";
            this.lblGlassCameraAlias4.Size = new System.Drawing.Size(32, 31);
            this.lblGlassCameraAlias4.TabIndex = 159;
            this.lblGlassCameraAlias4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckbGlassCameraUse2
            // 
            this.ckbGlassCameraUse2.AutoCheck = false;
            this.ckbGlassCameraUse2.AutoSize = true;
            this.ckbGlassCameraUse2.BackColor = System.Drawing.Color.Transparent;
            this.ckbGlassCameraUse2.Checked = true;
            this.ckbGlassCameraUse2.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.ckbGlassCameraUse2.Depth = 0;
            this.ckbGlassCameraUse2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckbGlassCameraUse2.Location = new System.Drawing.Point(137, 31);
            this.ckbGlassCameraUse2.Margin = new System.Windows.Forms.Padding(0);
            this.ckbGlassCameraUse2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckbGlassCameraUse2.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckbGlassCameraUse2.Name = "ckbGlassCameraUse2";
            this.ckbGlassCameraUse2.ReadOnly = false;
            this.ckbGlassCameraUse2.Ripple = true;
            this.ckbGlassCameraUse2.Size = new System.Drawing.Size(46, 31);
            this.ckbGlassCameraUse2.TabIndex = 152;
            this.ckbGlassCameraUse2.UseVisualStyleBackColor = false;
            // 
            // tbGlassCameraSerial3
            // 
            this.tbGlassCameraSerial3.AnimateReadOnly = false;
            this.tbGlassCameraSerial3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbGlassCameraSerial3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbGlassCameraSerial3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbGlassCameraSerial3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbGlassCameraSerial3.Depth = 0;
            this.tbGlassCameraSerial3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGlassCameraSerial3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGlassCameraSerial3.HideSelection = true;
            this.tbGlassCameraSerial3.LeadingIcon = null;
            this.tbGlassCameraSerial3.Location = new System.Drawing.Point(35, 65);
            this.tbGlassCameraSerial3.MaxLength = 32767;
            this.tbGlassCameraSerial3.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGlassCameraSerial3.Name = "tbGlassCameraSerial3";
            this.tbGlassCameraSerial3.PasswordChar = '\0';
            this.tbGlassCameraSerial3.PrefixSuffixText = null;
            this.tbGlassCameraSerial3.ReadOnly = true;
            this.tbGlassCameraSerial3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbGlassCameraSerial3.SelectedText = "";
            this.tbGlassCameraSerial3.SelectionLength = 0;
            this.tbGlassCameraSerial3.SelectionStart = 0;
            this.tbGlassCameraSerial3.ShortcutsEnabled = true;
            this.tbGlassCameraSerial3.Size = new System.Drawing.Size(99, 26);
            this.tbGlassCameraSerial3.TabIndex = 157;
            this.tbGlassCameraSerial3.TabStop = false;
            this.tbGlassCameraSerial3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbGlassCameraSerial3.TrailingIcon = null;
            this.tbGlassCameraSerial3.UseSystemPasswordChar = false;
            this.tbGlassCameraSerial3.UseTallSize = false;
            // 
            // lblGlassCameraAlias3
            // 
            this.lblGlassCameraAlias3.AutoSize = true;
            this.lblGlassCameraAlias3.BackColor = System.Drawing.Color.Transparent;
            this.lblGlassCameraAlias3.Depth = 0;
            this.lblGlassCameraAlias3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGlassCameraAlias3.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGlassCameraAlias3.Location = new System.Drawing.Point(0, 62);
            this.lblGlassCameraAlias3.Margin = new System.Windows.Forms.Padding(0);
            this.lblGlassCameraAlias3.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGlassCameraAlias3.Name = "lblGlassCameraAlias3";
            this.lblGlassCameraAlias3.Size = new System.Drawing.Size(32, 31);
            this.lblGlassCameraAlias3.TabIndex = 156;
            this.lblGlassCameraAlias3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGlassCameraAlias2
            // 
            this.lblGlassCameraAlias2.AutoSize = true;
            this.lblGlassCameraAlias2.BackColor = System.Drawing.Color.Transparent;
            this.lblGlassCameraAlias2.Depth = 0;
            this.lblGlassCameraAlias2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGlassCameraAlias2.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGlassCameraAlias2.Location = new System.Drawing.Point(0, 31);
            this.lblGlassCameraAlias2.Margin = new System.Windows.Forms.Padding(0);
            this.lblGlassCameraAlias2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGlassCameraAlias2.Name = "lblGlassCameraAlias2";
            this.lblGlassCameraAlias2.Size = new System.Drawing.Size(32, 31);
            this.lblGlassCameraAlias2.TabIndex = 154;
            this.lblGlassCameraAlias2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbGlassCameraSerial2
            // 
            this.tbGlassCameraSerial2.AnimateReadOnly = false;
            this.tbGlassCameraSerial2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbGlassCameraSerial2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbGlassCameraSerial2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbGlassCameraSerial2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbGlassCameraSerial2.Depth = 0;
            this.tbGlassCameraSerial2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGlassCameraSerial2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGlassCameraSerial2.HideSelection = true;
            this.tbGlassCameraSerial2.LeadingIcon = null;
            this.tbGlassCameraSerial2.Location = new System.Drawing.Point(35, 34);
            this.tbGlassCameraSerial2.MaxLength = 32767;
            this.tbGlassCameraSerial2.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGlassCameraSerial2.Name = "tbGlassCameraSerial2";
            this.tbGlassCameraSerial2.PasswordChar = '\0';
            this.tbGlassCameraSerial2.PrefixSuffixText = null;
            this.tbGlassCameraSerial2.ReadOnly = true;
            this.tbGlassCameraSerial2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbGlassCameraSerial2.SelectedText = "";
            this.tbGlassCameraSerial2.SelectionLength = 0;
            this.tbGlassCameraSerial2.SelectionStart = 0;
            this.tbGlassCameraSerial2.ShortcutsEnabled = true;
            this.tbGlassCameraSerial2.Size = new System.Drawing.Size(99, 26);
            this.tbGlassCameraSerial2.TabIndex = 153;
            this.tbGlassCameraSerial2.TabStop = false;
            this.tbGlassCameraSerial2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbGlassCameraSerial2.TrailingIcon = null;
            this.tbGlassCameraSerial2.UseSystemPasswordChar = false;
            this.tbGlassCameraSerial2.UseTallSize = false;
            // 
            // tbGlassCameraSerial4
            // 
            this.tbGlassCameraSerial4.AnimateReadOnly = false;
            this.tbGlassCameraSerial4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbGlassCameraSerial4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbGlassCameraSerial4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbGlassCameraSerial4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbGlassCameraSerial4.Depth = 0;
            this.tbGlassCameraSerial4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGlassCameraSerial4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGlassCameraSerial4.HideSelection = true;
            this.tbGlassCameraSerial4.LeadingIcon = null;
            this.tbGlassCameraSerial4.Location = new System.Drawing.Point(35, 96);
            this.tbGlassCameraSerial4.MaxLength = 32767;
            this.tbGlassCameraSerial4.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGlassCameraSerial4.Name = "tbGlassCameraSerial4";
            this.tbGlassCameraSerial4.PasswordChar = '\0';
            this.tbGlassCameraSerial4.PrefixSuffixText = null;
            this.tbGlassCameraSerial4.ReadOnly = true;
            this.tbGlassCameraSerial4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbGlassCameraSerial4.SelectedText = "";
            this.tbGlassCameraSerial4.SelectionLength = 0;
            this.tbGlassCameraSerial4.SelectionStart = 0;
            this.tbGlassCameraSerial4.ShortcutsEnabled = true;
            this.tbGlassCameraSerial4.Size = new System.Drawing.Size(99, 26);
            this.tbGlassCameraSerial4.TabIndex = 23;
            this.tbGlassCameraSerial4.TabStop = false;
            this.tbGlassCameraSerial4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbGlassCameraSerial4.TrailingIcon = null;
            this.tbGlassCameraSerial4.UseSystemPasswordChar = false;
            this.tbGlassCameraSerial4.UseTallSize = false;
            // 
            // ckbGlassCameraUse3
            // 
            this.ckbGlassCameraUse3.AutoCheck = false;
            this.ckbGlassCameraUse3.AutoSize = true;
            this.ckbGlassCameraUse3.BackColor = System.Drawing.Color.Transparent;
            this.ckbGlassCameraUse3.Checked = true;
            this.ckbGlassCameraUse3.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.ckbGlassCameraUse3.Depth = 0;
            this.ckbGlassCameraUse3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckbGlassCameraUse3.Location = new System.Drawing.Point(137, 62);
            this.ckbGlassCameraUse3.Margin = new System.Windows.Forms.Padding(0);
            this.ckbGlassCameraUse3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckbGlassCameraUse3.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckbGlassCameraUse3.Name = "ckbGlassCameraUse3";
            this.ckbGlassCameraUse3.ReadOnly = false;
            this.ckbGlassCameraUse3.Ripple = true;
            this.ckbGlassCameraUse3.Size = new System.Drawing.Size(46, 31);
            this.ckbGlassCameraUse3.TabIndex = 155;
            this.ckbGlassCameraUse3.UseVisualStyleBackColor = false;
            // 
            // materialTextBox23
            // 
            this.materialTextBox23.AnimateReadOnly = false;
            this.materialTextBox23.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.materialTextBox23.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.materialTextBox23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox23.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox23.Depth = 0;
            this.materialTextBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox23.HideSelection = true;
            this.materialTextBox23.LeadingIcon = null;
            this.materialTextBox23.Location = new System.Drawing.Point(13, 105);
            this.materialTextBox23.MaxLength = 32767;
            this.materialTextBox23.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox23.Name = "materialTextBox23";
            this.materialTextBox23.PasswordChar = '\0';
            this.materialTextBox23.PrefixSuffixText = null;
            this.materialTextBox23.ReadOnly = true;
            this.materialTextBox23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox23.SelectedText = "";
            this.materialTextBox23.SelectionLength = 0;
            this.materialTextBox23.SelectionStart = 0;
            this.materialTextBox23.ShortcutsEnabled = true;
            this.materialTextBox23.Size = new System.Drawing.Size(142, 26);
            this.materialTextBox23.TabIndex = 25;
            this.materialTextBox23.TabStop = false;
            this.materialTextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox23.TrailingIcon = null;
            this.materialTextBox23.UseSystemPasswordChar = false;
            this.materialTextBox23.UseTallSize = false;
            // 
            // btnConnectPlc_
            // 
            this.btnConnectPlc_.AutoSize = false;
            this.btnConnectPlc_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnectPlc_.BackColor = System.Drawing.Color.DarkGray;
            this.btnConnectPlc_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnConnectPlc_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConnectPlc_.Depth = 0;
            this.btnConnectPlc_.FlatAppearance.BorderSize = 0;
            this.btnConnectPlc_.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(215)))), ((int)(((byte)(73)))));
            this.btnConnectPlc_.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(215)))), ((int)(((byte)(73)))));
            this.btnConnectPlc_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectPlc_.Font = new System.Drawing.Font("Consolas", 16F);
            this.btnConnectPlc_.HighEmphasis = true;
            this.btnConnectPlc_.Icon = null;
            this.btnConnectPlc_.Location = new System.Drawing.Point(23, 699);
            this.btnConnectPlc_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConnectPlc_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConnectPlc_.Name = "btnConnectPlc_";
            this.btnConnectPlc_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConnectPlc_.Size = new System.Drawing.Size(100, 36);
            this.btnConnectPlc_.TabIndex = 159;
            this.btnConnectPlc_.Text = "Connect PLC";
            this.btnConnectPlc_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConnectPlc_.UseAccentColor = false;
            this.btnConnectPlc_.UseVisualStyleBackColor = false;
            this.btnConnectPlc_.Visible = false;
            this.btnConnectPlc_.Click += new System.EventHandler(this.btnGlassRHCameraUse__Click);
            // 
            // pbOk
            // 
            this.pbOk.BackColor = System.Drawing.Color.LightGray;
            this.pbOk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOk.Image = global::loadingBox2dGui.Properties.Resources.visionOKOff;
            this.pbOk.Location = new System.Drawing.Point(1102, 5);
            this.pbOk.Name = "pbOk";
            this.pbOk.Size = new System.Drawing.Size(223, 124);
            this.pbOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOk.TabIndex = 190;
            this.pbOk.TabStop = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.plcSignalStatusOnlyTable1);
            this.materialCard1.Controls.Add(this.plcSignalStatusValueTable1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(1102, 594);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialCard1.Size = new System.Drawing.Size(223, 294);
            this.materialCard1.TabIndex = 187;
            // 
            // plcSignalStatusOnlyTable1
            // 
            this.plcSignalStatusOnlyTable1.Location = new System.Drawing.Point(10, 13);
            this.plcSignalStatusOnlyTable1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plcSignalStatusOnlyTable1.Name = "plcSignalStatusOnlyTable1";
            this.plcSignalStatusOnlyTable1.RowCount = 4;
            this.plcSignalStatusOnlyTable1.RowHeight = 23;
            this.plcSignalStatusOnlyTable1.Size = new System.Drawing.Size(203, 97);
            this.plcSignalStatusOnlyTable1.TabIndex = 1;
            // 
            // plcSignalStatusValueTable1
            // 
            this.plcSignalStatusValueTable1.ColumnWidth1 = 135;
            this.plcSignalStatusValueTable1.ColumnWidth2 = 65;
            this.plcSignalStatusValueTable1.Location = new System.Drawing.Point(9, 131);
            this.plcSignalStatusValueTable1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plcSignalStatusValueTable1.Name = "plcSignalStatusValueTable1";
            this.plcSignalStatusValueTable1.RowCount = 6;
            this.plcSignalStatusValueTable1.RowHeight = 23;
            this.plcSignalStatusValueTable1.Size = new System.Drawing.Size(203, 145);
            this.plcSignalStatusValueTable1.TabIndex = 0;
            // 
            // pbNg
            // 
            this.pbNg.BackColor = System.Drawing.Color.LightGray;
            this.pbNg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbNg.Image = global::loadingBox2dGui.Properties.Resources.visionNGOff;
            this.pbNg.Location = new System.Drawing.Point(1101, 132);
            this.pbNg.Name = "pbNg";
            this.pbNg.Size = new System.Drawing.Size(223, 124);
            this.pbNg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNg.TabIndex = 189;
            this.pbNg.TabStop = false;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.plcSignalStatusOnlyTable2);
            this.materialCard2.Controls.Add(this.plcSignalStatusValueTable2);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(1102, 260);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialCard2.Size = new System.Drawing.Size(223, 330);
            this.materialCard2.TabIndex = 188;
            // 
            // plcSignalStatusOnlyTable2
            // 
            this.plcSignalStatusOnlyTable2.Location = new System.Drawing.Point(11, 6);
            this.plcSignalStatusOnlyTable2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plcSignalStatusOnlyTable2.Name = "plcSignalStatusOnlyTable2";
            this.plcSignalStatusOnlyTable2.RowCount = 5;
            this.plcSignalStatusOnlyTable2.RowHeight = 23;
            this.plcSignalStatusOnlyTable2.Size = new System.Drawing.Size(203, 121);
            this.plcSignalStatusOnlyTable2.TabIndex = 108;
            // 
            // plcSignalStatusValueTable2
            // 
            this.plcSignalStatusValueTable2.ColumnWidth1 = 135;
            this.plcSignalStatusValueTable2.ColumnWidth2 = 65;
            this.plcSignalStatusValueTable2.Location = new System.Drawing.Point(11, 132);
            this.plcSignalStatusValueTable2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plcSignalStatusValueTable2.Name = "plcSignalStatusValueTable2";
            this.plcSignalStatusValueTable2.RowCount = 8;
            this.plcSignalStatusValueTable2.RowHeight = 23;
            this.plcSignalStatusValueTable2.Size = new System.Drawing.Size(203, 193);
            this.plcSignalStatusValueTable2.TabIndex = 107;
            // 
            // gbGlassUserControl_
            // 
            this.gbGlassUserControl_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbGlassUserControl_.Controls.Add(this.btnGlassBackUp_);
            this.gbGlassUserControl_.Controls.Add(this.lblGlassRHCamera_);
            this.gbGlassUserControl_.Controls.Add(this.lblGlassLHCamera_);
            this.gbGlassUserControl_.Controls.Add(this.btnGlassRHCameraUnuse_);
            this.gbGlassUserControl_.Controls.Add(this.btnGlassRHCameraUse_);
            this.gbGlassUserControl_.Controls.Add(this.btnGlassLHCameraUnuse_);
            this.gbGlassUserControl_.Controls.Add(this.btnGlassLHCameraUse_);
            this.gbGlassUserControl_.Depth = 0;
            this.gbGlassUserControl_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbGlassUserControl_.Location = new System.Drawing.Point(8, 554);
            this.gbGlassUserControl_.Margin = new System.Windows.Forms.Padding(14);
            this.gbGlassUserControl_.MouseState = MaterialSkin.MouseState.HOVER;
            this.gbGlassUserControl_.Name = "gbGlassUserControl_";
            this.gbGlassUserControl_.Padding = new System.Windows.Forms.Padding(14);
            this.gbGlassUserControl_.Size = new System.Drawing.Size(589, 125);
            this.gbGlassUserControl_.TabIndex = 186;
            this.gbGlassUserControl_.Visible = false;
            // 
            // btnGlassBackUp_
            // 
            this.btnGlassBackUp_.AutoSize = false;
            this.btnGlassBackUp_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGlassBackUp_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnGlassBackUp_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGlassBackUp_.Depth = 0;
            this.btnGlassBackUp_.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnGlassBackUp_.FlatAppearance.BorderSize = 0;
            this.btnGlassBackUp_.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(65)))));
            this.btnGlassBackUp_.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(65)))));
            this.btnGlassBackUp_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlassBackUp_.ForeColor = System.Drawing.Color.White;
            this.btnGlassBackUp_.HighEmphasis = true;
            this.btnGlassBackUp_.Icon = null;
            this.btnGlassBackUp_.Location = new System.Drawing.Point(15, 22);
            this.btnGlassBackUp_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGlassBackUp_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGlassBackUp_.Name = "btnGlassBackUp_";
            this.btnGlassBackUp_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGlassBackUp_.Size = new System.Drawing.Size(103, 93);
            this.btnGlassBackUp_.TabIndex = 163;
            this.btnGlassBackUp_.Text = "BackUp";
            this.btnGlassBackUp_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGlassBackUp_.UseAccentColor = false;
            this.btnGlassBackUp_.UseVisualStyleBackColor = true;
            this.btnGlassBackUp_.Click += new System.EventHandler(this.btnGlassBackUp__Click);
            // 
            // lblGlassRHCamera_
            // 
            this.lblGlassRHCamera_.AutoSize = false;
            this.lblGlassRHCamera_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lblGlassRHCamera_.CustomBackColor = System.Drawing.Color.Empty;
            this.lblGlassRHCamera_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.lblGlassRHCamera_.Depth = 0;
            this.lblGlassRHCamera_.HighEmphasis = true;
            this.lblGlassRHCamera_.Icon = null;
            this.lblGlassRHCamera_.Location = new System.Drawing.Point(363, 22);
            this.lblGlassRHCamera_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lblGlassRHCamera_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGlassRHCamera_.Name = "lblGlassRHCamera_";
            this.lblGlassRHCamera_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.lblGlassRHCamera_.Size = new System.Drawing.Size(210, 36);
            this.lblGlassRHCamera_.TabIndex = 162;
            this.lblGlassRHCamera_.Text = "RH Camera";
            this.lblGlassRHCamera_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.lblGlassRHCamera_.UseAccentColor = false;
            this.lblGlassRHCamera_.UseVisualStyleBackColor = true;
            // 
            // lblGlassLHCamera_
            // 
            this.lblGlassLHCamera_.AutoSize = false;
            this.lblGlassLHCamera_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lblGlassLHCamera_.CustomBackColor = System.Drawing.Color.Empty;
            this.lblGlassLHCamera_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.lblGlassLHCamera_.Depth = 0;
            this.lblGlassLHCamera_.HighEmphasis = true;
            this.lblGlassLHCamera_.Icon = null;
            this.lblGlassLHCamera_.Location = new System.Drawing.Point(133, 22);
            this.lblGlassLHCamera_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lblGlassLHCamera_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGlassLHCamera_.Name = "lblGlassLHCamera_";
            this.lblGlassLHCamera_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.lblGlassLHCamera_.Size = new System.Drawing.Size(210, 36);
            this.lblGlassLHCamera_.TabIndex = 161;
            this.lblGlassLHCamera_.Text = "LH Camera";
            this.lblGlassLHCamera_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.lblGlassLHCamera_.UseAccentColor = false;
            this.lblGlassLHCamera_.UseVisualStyleBackColor = true;
            // 
            // btnGlassRHCameraUnuse_
            // 
            this.btnGlassRHCameraUnuse_.AutoSize = false;
            this.btnGlassRHCameraUnuse_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGlassRHCameraUnuse_.BackColor = System.Drawing.Color.DarkGray;
            this.btnGlassRHCameraUnuse_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnGlassRHCameraUnuse_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGlassRHCameraUnuse_.Depth = 0;
            this.btnGlassRHCameraUnuse_.FlatAppearance.BorderSize = 0;
            this.btnGlassRHCameraUnuse_.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btnGlassRHCameraUnuse_.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnGlassRHCameraUnuse_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlassRHCameraUnuse_.Font = new System.Drawing.Font("Consolas", 16F);
            this.btnGlassRHCameraUnuse_.HighEmphasis = true;
            this.btnGlassRHCameraUnuse_.Icon = null;
            this.btnGlassRHCameraUnuse_.Location = new System.Drawing.Point(473, 79);
            this.btnGlassRHCameraUnuse_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGlassRHCameraUnuse_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGlassRHCameraUnuse_.Name = "btnGlassRHCameraUnuse_";
            this.btnGlassRHCameraUnuse_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGlassRHCameraUnuse_.Size = new System.Drawing.Size(100, 36);
            this.btnGlassRHCameraUnuse_.TabIndex = 160;
            this.btnGlassRHCameraUnuse_.Text = "Unuse";
            this.btnGlassRHCameraUnuse_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGlassRHCameraUnuse_.UseAccentColor = false;
            this.btnGlassRHCameraUnuse_.UseVisualStyleBackColor = false;
            this.btnGlassRHCameraUnuse_.Click += new System.EventHandler(this.btnGlassRHCameraUnuse__Click);
            // 
            // btnGlassRHCameraUse_
            // 
            this.btnGlassRHCameraUse_.AutoSize = false;
            this.btnGlassRHCameraUse_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGlassRHCameraUse_.BackColor = System.Drawing.Color.DarkGray;
            this.btnGlassRHCameraUse_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnGlassRHCameraUse_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGlassRHCameraUse_.Depth = 0;
            this.btnGlassRHCameraUse_.FlatAppearance.BorderSize = 0;
            this.btnGlassRHCameraUse_.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(215)))), ((int)(((byte)(73)))));
            this.btnGlassRHCameraUse_.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(215)))), ((int)(((byte)(73)))));
            this.btnGlassRHCameraUse_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlassRHCameraUse_.Font = new System.Drawing.Font("Consolas", 16F);
            this.btnGlassRHCameraUse_.HighEmphasis = true;
            this.btnGlassRHCameraUse_.Icon = null;
            this.btnGlassRHCameraUse_.Location = new System.Drawing.Point(363, 79);
            this.btnGlassRHCameraUse_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGlassRHCameraUse_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGlassRHCameraUse_.Name = "btnGlassRHCameraUse_";
            this.btnGlassRHCameraUse_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGlassRHCameraUse_.Size = new System.Drawing.Size(100, 36);
            this.btnGlassRHCameraUse_.TabIndex = 159;
            this.btnGlassRHCameraUse_.Text = "Use";
            this.btnGlassRHCameraUse_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGlassRHCameraUse_.UseAccentColor = false;
            this.btnGlassRHCameraUse_.UseVisualStyleBackColor = false;
            this.btnGlassRHCameraUse_.Click += new System.EventHandler(this.btnGlassRHCameraUse__Click);
            // 
            // btnGlassLHCameraUnuse_
            // 
            this.btnGlassLHCameraUnuse_.AutoSize = false;
            this.btnGlassLHCameraUnuse_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGlassLHCameraUnuse_.BackColor = System.Drawing.Color.DarkGray;
            this.btnGlassLHCameraUnuse_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnGlassLHCameraUnuse_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGlassLHCameraUnuse_.Depth = 0;
            this.btnGlassLHCameraUnuse_.FlatAppearance.BorderSize = 0;
            this.btnGlassLHCameraUnuse_.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btnGlassLHCameraUnuse_.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnGlassLHCameraUnuse_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlassLHCameraUnuse_.Font = new System.Drawing.Font("Consolas", 16F);
            this.btnGlassLHCameraUnuse_.HighEmphasis = true;
            this.btnGlassLHCameraUnuse_.Icon = null;
            this.btnGlassLHCameraUnuse_.Location = new System.Drawing.Point(243, 79);
            this.btnGlassLHCameraUnuse_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGlassLHCameraUnuse_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGlassLHCameraUnuse_.Name = "btnGlassLHCameraUnuse_";
            this.btnGlassLHCameraUnuse_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGlassLHCameraUnuse_.Size = new System.Drawing.Size(100, 36);
            this.btnGlassLHCameraUnuse_.TabIndex = 158;
            this.btnGlassLHCameraUnuse_.Text = "Unuse";
            this.btnGlassLHCameraUnuse_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGlassLHCameraUnuse_.UseAccentColor = false;
            this.btnGlassLHCameraUnuse_.UseVisualStyleBackColor = false;
            this.btnGlassLHCameraUnuse_.Click += new System.EventHandler(this.btnGlassLHCameraUnuse__Click);
            // 
            // btnGlassLHCameraUse_
            // 
            this.btnGlassLHCameraUse_.AutoSize = false;
            this.btnGlassLHCameraUse_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGlassLHCameraUse_.BackColor = System.Drawing.Color.DarkGray;
            this.btnGlassLHCameraUse_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnGlassLHCameraUse_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGlassLHCameraUse_.Depth = 0;
            this.btnGlassLHCameraUse_.FlatAppearance.BorderSize = 0;
            this.btnGlassLHCameraUse_.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(215)))), ((int)(((byte)(73)))));
            this.btnGlassLHCameraUse_.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(215)))), ((int)(((byte)(73)))));
            this.btnGlassLHCameraUse_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlassLHCameraUse_.Font = new System.Drawing.Font("Consolas", 16F);
            this.btnGlassLHCameraUse_.HighEmphasis = true;
            this.btnGlassLHCameraUse_.Icon = null;
            this.btnGlassLHCameraUse_.Location = new System.Drawing.Point(133, 79);
            this.btnGlassLHCameraUse_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGlassLHCameraUse_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGlassLHCameraUse_.Name = "btnGlassLHCameraUse_";
            this.btnGlassLHCameraUse_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGlassLHCameraUse_.Size = new System.Drawing.Size(100, 36);
            this.btnGlassLHCameraUse_.TabIndex = 157;
            this.btnGlassLHCameraUse_.Text = "Use";
            this.btnGlassLHCameraUse_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGlassLHCameraUse_.UseAccentColor = false;
            this.btnGlassLHCameraUse_.UseVisualStyleBackColor = false;
            this.btnGlassLHCameraUse_.Click += new System.EventHandler(this.btnGlassLHCameraUse__Click);
            // 
            // label85_
            // 
            this.label85_.AutoSize = true;
            this.label85_.BackColor = System.Drawing.Color.Transparent;
            this.label85_.Depth = 0;
            this.label85_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label85_.Location = new System.Drawing.Point(6, 811);
            this.label85_.MouseState = MaterialSkin.MouseState.HOVER;
            this.label85_.Name = "label85_";
            this.label85_.Size = new System.Drawing.Size(156, 18);
            this.label85_.TabIndex = 180;
            this.label85_.Text = "Reference Data Path";
            this.label85_.Visible = false;
            // 
            // tbGlassRefDataPath
            // 
            this.tbGlassRefDataPath.AnimateReadOnly = false;
            this.tbGlassRefDataPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbGlassRefDataPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbGlassRefDataPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbGlassRefDataPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbGlassRefDataPath.Depth = 0;
            this.tbGlassRefDataPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGlassRefDataPath.HideSelection = true;
            this.tbGlassRefDataPath.LeadingIcon = null;
            this.tbGlassRefDataPath.Location = new System.Drawing.Point(6, 829);
            this.tbGlassRefDataPath.MaxLength = 32767;
            this.tbGlassRefDataPath.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGlassRefDataPath.Name = "tbGlassRefDataPath";
            this.tbGlassRefDataPath.PasswordChar = '\0';
            this.tbGlassRefDataPath.PrefixSuffixText = null;
            this.tbGlassRefDataPath.ReadOnly = false;
            this.tbGlassRefDataPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbGlassRefDataPath.SelectedText = "";
            this.tbGlassRefDataPath.SelectionLength = 0;
            this.tbGlassRefDataPath.SelectionStart = 0;
            this.tbGlassRefDataPath.ShortcutsEnabled = true;
            this.tbGlassRefDataPath.Size = new System.Drawing.Size(555, 26);
            this.tbGlassRefDataPath.TabIndex = 181;
            this.tbGlassRefDataPath.TabStop = false;
            this.tbGlassRefDataPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbGlassRefDataPath.TrailingIcon = null;
            this.tbGlassRefDataPath.UseSystemPasswordChar = false;
            this.tbGlassRefDataPath.UseTallSize = false;
            this.tbGlassRefDataPath.Visible = false;
            // 
            // btnGlassRefDataPath
            // 
            this.btnGlassRefDataPath.AutoSize = false;
            this.btnGlassRefDataPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGlassRefDataPath.CustomBackColor = System.Drawing.Color.Empty;
            this.btnGlassRefDataPath.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGlassRefDataPath.Depth = 0;
            this.btnGlassRefDataPath.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.btnGlassRefDataPath.HighEmphasis = true;
            this.btnGlassRefDataPath.Icon = null;
            this.btnGlassRefDataPath.Location = new System.Drawing.Point(562, 827);
            this.btnGlassRefDataPath.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGlassRefDataPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGlassRefDataPath.Name = "btnGlassRefDataPath";
            this.btnGlassRefDataPath.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGlassRefDataPath.Size = new System.Drawing.Size(37, 26);
            this.btnGlassRefDataPath.TabIndex = 182;
            this.btnGlassRefDataPath.Text = "...";
            this.btnGlassRefDataPath.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGlassRefDataPath.UseAccentColor = false;
            this.btnGlassRefDataPath.UseVisualStyleBackColor = true;
            this.btnGlassRefDataPath.Visible = false;
            this.btnGlassRefDataPath.Click += new System.EventHandler(this.btnGlassRefDataPath_Click);
            // 
            // label86_
            // 
            this.label86_.AutoSize = true;
            this.label86_.BackColor = System.Drawing.Color.Transparent;
            this.label86_.Depth = 0;
            this.label86_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label86_.Location = new System.Drawing.Point(6, 854);
            this.label86_.MouseState = MaterialSkin.MouseState.HOVER;
            this.label86_.Name = "label86_";
            this.label86_.Size = new System.Drawing.Size(232, 18);
            this.label86_.TabIndex = 183;
            this.label86_.Text = "Hand-Eye Calibration File Path";
            this.label86_.Visible = false;
            // 
            // tbGlassHandEyeCalibFilePath
            // 
            this.tbGlassHandEyeCalibFilePath.AnimateReadOnly = false;
            this.tbGlassHandEyeCalibFilePath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbGlassHandEyeCalibFilePath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbGlassHandEyeCalibFilePath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbGlassHandEyeCalibFilePath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbGlassHandEyeCalibFilePath.Depth = 0;
            this.tbGlassHandEyeCalibFilePath.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.tbGlassHandEyeCalibFilePath.HideSelection = true;
            this.tbGlassHandEyeCalibFilePath.LeadingIcon = null;
            this.tbGlassHandEyeCalibFilePath.Location = new System.Drawing.Point(6, 872);
            this.tbGlassHandEyeCalibFilePath.MaxLength = 32767;
            this.tbGlassHandEyeCalibFilePath.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGlassHandEyeCalibFilePath.Name = "tbGlassHandEyeCalibFilePath";
            this.tbGlassHandEyeCalibFilePath.PasswordChar = '\0';
            this.tbGlassHandEyeCalibFilePath.PrefixSuffixText = null;
            this.tbGlassHandEyeCalibFilePath.ReadOnly = false;
            this.tbGlassHandEyeCalibFilePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbGlassHandEyeCalibFilePath.SelectedText = "";
            this.tbGlassHandEyeCalibFilePath.SelectionLength = 0;
            this.tbGlassHandEyeCalibFilePath.SelectionStart = 0;
            this.tbGlassHandEyeCalibFilePath.ShortcutsEnabled = true;
            this.tbGlassHandEyeCalibFilePath.Size = new System.Drawing.Size(555, 26);
            this.tbGlassHandEyeCalibFilePath.TabIndex = 184;
            this.tbGlassHandEyeCalibFilePath.TabStop = false;
            this.tbGlassHandEyeCalibFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbGlassHandEyeCalibFilePath.TrailingIcon = null;
            this.tbGlassHandEyeCalibFilePath.UseSystemPasswordChar = false;
            this.tbGlassHandEyeCalibFilePath.UseTallSize = false;
            this.tbGlassHandEyeCalibFilePath.Visible = false;
            // 
            // btnGlassHandEyeCalibFilePath
            // 
            this.btnGlassHandEyeCalibFilePath.AutoSize = false;
            this.btnGlassHandEyeCalibFilePath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGlassHandEyeCalibFilePath.CustomBackColor = System.Drawing.Color.Empty;
            this.btnGlassHandEyeCalibFilePath.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGlassHandEyeCalibFilePath.Depth = 0;
            this.btnGlassHandEyeCalibFilePath.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.btnGlassHandEyeCalibFilePath.HighEmphasis = true;
            this.btnGlassHandEyeCalibFilePath.Icon = null;
            this.btnGlassHandEyeCalibFilePath.Location = new System.Drawing.Point(562, 870);
            this.btnGlassHandEyeCalibFilePath.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGlassHandEyeCalibFilePath.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGlassHandEyeCalibFilePath.Name = "btnGlassHandEyeCalibFilePath";
            this.btnGlassHandEyeCalibFilePath.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGlassHandEyeCalibFilePath.Size = new System.Drawing.Size(37, 26);
            this.btnGlassHandEyeCalibFilePath.TabIndex = 185;
            this.btnGlassHandEyeCalibFilePath.Text = "...";
            this.btnGlassHandEyeCalibFilePath.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGlassHandEyeCalibFilePath.UseAccentColor = false;
            this.btnGlassHandEyeCalibFilePath.UseVisualStyleBackColor = true;
            this.btnGlassHandEyeCalibFilePath.Visible = false;
            this.btnGlassHandEyeCalibFilePath.Click += new System.EventHandler(this.btnGlassHandEyeCalibFilePath_Click);
            // 
            // btnGlassUpdate_
            // 
            this.btnGlassUpdate_.AutoSize = false;
            this.btnGlassUpdate_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGlassUpdate_.BackColor = System.Drawing.Color.DimGray;
            this.btnGlassUpdate_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnGlassUpdate_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGlassUpdate_.Depth = 0;
            this.btnGlassUpdate_.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnGlassUpdate_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlassUpdate_.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnGlassUpdate_.HighEmphasis = true;
            this.btnGlassUpdate_.Icon = null;
            this.btnGlassUpdate_.Location = new System.Drawing.Point(936, 598);
            this.btnGlassUpdate_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGlassUpdate_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGlassUpdate_.Name = "btnGlassUpdate_";
            this.btnGlassUpdate_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGlassUpdate_.Size = new System.Drawing.Size(167, 32);
            this.btnGlassUpdate_.TabIndex = 179;
            this.btnGlassUpdate_.Text = "Update";
            this.btnGlassUpdate_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGlassUpdate_.UseAccentColor = false;
            this.btnGlassUpdate_.UseVisualStyleBackColor = false;
            this.btnGlassUpdate_.Visible = false;
            this.btnGlassUpdate_.Click += new System.EventHandler(this.btnGlassUpdate__Click);
            // 
            // btnGlassCalculate_
            // 
            this.btnGlassCalculate_.AutoSize = false;
            this.btnGlassCalculate_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGlassCalculate_.BackColor = System.Drawing.Color.DimGray;
            this.btnGlassCalculate_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnGlassCalculate_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGlassCalculate_.Depth = 0;
            this.btnGlassCalculate_.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnGlassCalculate_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlassCalculate_.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnGlassCalculate_.HighEmphasis = true;
            this.btnGlassCalculate_.Icon = null;
            this.btnGlassCalculate_.Location = new System.Drawing.Point(936, 553);
            this.btnGlassCalculate_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGlassCalculate_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGlassCalculate_.Name = "btnGlassCalculate_";
            this.btnGlassCalculate_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGlassCalculate_.Size = new System.Drawing.Size(167, 32);
            this.btnGlassCalculate_.TabIndex = 178;
            this.btnGlassCalculate_.Text = "Calculate";
            this.btnGlassCalculate_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGlassCalculate_.UseAccentColor = false;
            this.btnGlassCalculate_.UseVisualStyleBackColor = false;
            this.btnGlassCalculate_.Visible = false;
            this.btnGlassCalculate_.Click += new System.EventHandler(this.btnGlassCalculate__Click);
            // 
            // gbGlassShiftValue_
            // 
            this.gbGlassShiftValue_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbGlassShiftValue_.Controls.Add(this.label88);
            this.gbGlassShiftValue_.Controls.Add(this.tbGlassShiftValueRz);
            this.gbGlassShiftValue_.Controls.Add(this.tbGlassShiftValueTx);
            this.gbGlassShiftValue_.Controls.Add(this.label79);
            this.gbGlassShiftValue_.Controls.Add(this.label80);
            this.gbGlassShiftValue_.Controls.Add(this.tbGlassShiftValueTy);
            this.gbGlassShiftValue_.Depth = 0;
            this.gbGlassShiftValue_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbGlassShiftValue_.Location = new System.Drawing.Point(615, 554);
            this.gbGlassShiftValue_.Margin = new System.Windows.Forms.Padding(14);
            this.gbGlassShiftValue_.MouseState = MaterialSkin.MouseState.HOVER;
            this.gbGlassShiftValue_.Name = "gbGlassShiftValue_";
            this.gbGlassShiftValue_.Padding = new System.Windows.Forms.Padding(14);
            this.gbGlassShiftValue_.Size = new System.Drawing.Size(305, 125);
            this.gbGlassShiftValue_.TabIndex = 177;
            this.gbGlassShiftValue_.Visible = false;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.BackColor = System.Drawing.Color.Transparent;
            this.label88.Depth = 0;
            this.label88.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label88.Location = new System.Drawing.Point(56, 92);
            this.label88.MouseState = MaterialSkin.MouseState.HOVER;
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(19, 18);
            this.label88.TabIndex = 17;
            this.label88.Text = "Rz";
            // 
            // tbGlassShiftValueRz
            // 
            this.tbGlassShiftValueRz.AnimateReadOnly = false;
            this.tbGlassShiftValueRz.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbGlassShiftValueRz.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbGlassShiftValueRz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbGlassShiftValueRz.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbGlassShiftValueRz.Depth = 0;
            this.tbGlassShiftValueRz.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.tbGlassShiftValueRz.HideSelection = true;
            this.tbGlassShiftValueRz.LeadingIcon = null;
            this.tbGlassShiftValueRz.Location = new System.Drawing.Point(82, 89);
            this.tbGlassShiftValueRz.MaxLength = 32767;
            this.tbGlassShiftValueRz.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGlassShiftValueRz.Name = "tbGlassShiftValueRz";
            this.tbGlassShiftValueRz.PasswordChar = '\0';
            this.tbGlassShiftValueRz.PrefixSuffixText = null;
            this.tbGlassShiftValueRz.ReadOnly = true;
            this.tbGlassShiftValueRz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbGlassShiftValueRz.SelectedText = "";
            this.tbGlassShiftValueRz.SelectionLength = 0;
            this.tbGlassShiftValueRz.SelectionStart = 0;
            this.tbGlassShiftValueRz.ShortcutsEnabled = true;
            this.tbGlassShiftValueRz.Size = new System.Drawing.Size(172, 26);
            this.tbGlassShiftValueRz.TabIndex = 18;
            this.tbGlassShiftValueRz.TabStop = false;
            this.tbGlassShiftValueRz.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbGlassShiftValueRz.TrailingIcon = null;
            this.tbGlassShiftValueRz.UseSystemPasswordChar = false;
            this.tbGlassShiftValueRz.UseTallSize = false;
            // 
            // tbGlassShiftValueTx
            // 
            this.tbGlassShiftValueTx.AnimateReadOnly = false;
            this.tbGlassShiftValueTx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbGlassShiftValueTx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbGlassShiftValueTx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbGlassShiftValueTx.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbGlassShiftValueTx.Depth = 0;
            this.tbGlassShiftValueTx.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGlassShiftValueTx.HideSelection = true;
            this.tbGlassShiftValueTx.LeadingIcon = null;
            this.tbGlassShiftValueTx.Location = new System.Drawing.Point(82, 23);
            this.tbGlassShiftValueTx.MaxLength = 32767;
            this.tbGlassShiftValueTx.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGlassShiftValueTx.Name = "tbGlassShiftValueTx";
            this.tbGlassShiftValueTx.PasswordChar = '\0';
            this.tbGlassShiftValueTx.PrefixSuffixText = null;
            this.tbGlassShiftValueTx.ReadOnly = true;
            this.tbGlassShiftValueTx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbGlassShiftValueTx.SelectedText = "";
            this.tbGlassShiftValueTx.SelectionLength = 0;
            this.tbGlassShiftValueTx.SelectionStart = 0;
            this.tbGlassShiftValueTx.ShortcutsEnabled = true;
            this.tbGlassShiftValueTx.Size = new System.Drawing.Size(172, 26);
            this.tbGlassShiftValueTx.TabIndex = 6;
            this.tbGlassShiftValueTx.TabStop = false;
            this.tbGlassShiftValueTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbGlassShiftValueTx.TrailingIcon = null;
            this.tbGlassShiftValueTx.UseSystemPasswordChar = false;
            this.tbGlassShiftValueTx.UseTallSize = false;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.BackColor = System.Drawing.Color.Transparent;
            this.label79.Depth = 0;
            this.label79.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label79.Location = new System.Drawing.Point(56, 27);
            this.label79.MouseState = MaterialSkin.MouseState.HOVER;
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(18, 18);
            this.label79.TabIndex = 7;
            this.label79.Text = "Tx";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.BackColor = System.Drawing.Color.Transparent;
            this.label80.Depth = 0;
            this.label80.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label80.Location = new System.Drawing.Point(56, 60);
            this.label80.MouseState = MaterialSkin.MouseState.HOVER;
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(19, 18);
            this.label80.TabIndex = 8;
            this.label80.Text = "Ty";
            // 
            // tbGlassShiftValueTy
            // 
            this.tbGlassShiftValueTy.AnimateReadOnly = false;
            this.tbGlassShiftValueTy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbGlassShiftValueTy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbGlassShiftValueTy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbGlassShiftValueTy.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbGlassShiftValueTy.Depth = 0;
            this.tbGlassShiftValueTy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGlassShiftValueTy.HideSelection = true;
            this.tbGlassShiftValueTy.LeadingIcon = null;
            this.tbGlassShiftValueTy.Location = new System.Drawing.Point(82, 56);
            this.tbGlassShiftValueTy.MaxLength = 32767;
            this.tbGlassShiftValueTy.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGlassShiftValueTy.Name = "tbGlassShiftValueTy";
            this.tbGlassShiftValueTy.PasswordChar = '\0';
            this.tbGlassShiftValueTy.PrefixSuffixText = null;
            this.tbGlassShiftValueTy.ReadOnly = true;
            this.tbGlassShiftValueTy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbGlassShiftValueTy.SelectedText = "";
            this.tbGlassShiftValueTy.SelectionLength = 0;
            this.tbGlassShiftValueTy.SelectionStart = 0;
            this.tbGlassShiftValueTy.ShortcutsEnabled = true;
            this.tbGlassShiftValueTy.Size = new System.Drawing.Size(172, 26);
            this.tbGlassShiftValueTy.TabIndex = 13;
            this.tbGlassShiftValueTy.TabStop = false;
            this.tbGlassShiftValueTy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbGlassShiftValueTy.TrailingIcon = null;
            this.tbGlassShiftValueTy.UseSystemPasswordChar = false;
            this.tbGlassShiftValueTy.UseTallSize = false;
            // 
            // gbGlassPoint_
            // 
            this.gbGlassPoint_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbGlassPoint_.Controls.Add(this.tbGlassPointTx);
            this.gbGlassPoint_.Controls.Add(this.label73);
            this.gbGlassPoint_.Controls.Add(this.label74);
            this.gbGlassPoint_.Controls.Add(this.label75);
            this.gbGlassPoint_.Controls.Add(this.label76);
            this.gbGlassPoint_.Controls.Add(this.label77);
            this.gbGlassPoint_.Controls.Add(this.label78);
            this.gbGlassPoint_.Controls.Add(this.tbGlassPointTy);
            this.gbGlassPoint_.Controls.Add(this.tbGlassPointTz);
            this.gbGlassPoint_.Controls.Add(this.tbGlassPointRx);
            this.gbGlassPoint_.Controls.Add(this.tbGlassPointRz);
            this.gbGlassPoint_.Controls.Add(this.tbGlassPointRy);
            this.gbGlassPoint_.Depth = 0;
            this.gbGlassPoint_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbGlassPoint_.Location = new System.Drawing.Point(615, 815);
            this.gbGlassPoint_.Margin = new System.Windows.Forms.Padding(14);
            this.gbGlassPoint_.MouseState = MaterialSkin.MouseState.HOVER;
            this.gbGlassPoint_.Name = "gbGlassPoint_";
            this.gbGlassPoint_.Padding = new System.Windows.Forms.Padding(14);
            this.gbGlassPoint_.Size = new System.Drawing.Size(305, 125);
            this.gbGlassPoint_.TabIndex = 176;
            this.gbGlassPoint_.Visible = false;
            // 
            // tbGlassPointTx
            // 
            this.tbGlassPointTx.AnimateReadOnly = false;
            this.tbGlassPointTx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbGlassPointTx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbGlassPointTx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbGlassPointTx.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbGlassPointTx.Depth = 0;
            this.tbGlassPointTx.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGlassPointTx.HideSelection = true;
            this.tbGlassPointTx.LeadingIcon = null;
            this.tbGlassPointTx.Location = new System.Drawing.Point(105, 21);
            this.tbGlassPointTx.MaxLength = 32767;
            this.tbGlassPointTx.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGlassPointTx.Name = "tbGlassPointTx";
            this.tbGlassPointTx.PasswordChar = '\0';
            this.tbGlassPointTx.PrefixSuffixText = null;
            this.tbGlassPointTx.ReadOnly = true;
            this.tbGlassPointTx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbGlassPointTx.SelectedText = "";
            this.tbGlassPointTx.SelectionLength = 0;
            this.tbGlassPointTx.SelectionStart = 0;
            this.tbGlassPointTx.ShortcutsEnabled = true;
            this.tbGlassPointTx.Size = new System.Drawing.Size(80, 26);
            this.tbGlassPointTx.TabIndex = 23;
            this.tbGlassPointTx.TabStop = false;
            this.tbGlassPointTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbGlassPointTx.TrailingIcon = null;
            this.tbGlassPointTx.UseSystemPasswordChar = false;
            this.tbGlassPointTx.UseTallSize = false;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.BackColor = System.Drawing.Color.Transparent;
            this.label73.Depth = 0;
            this.label73.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label73.Location = new System.Drawing.Point(79, 24);
            this.label73.MouseState = MaterialSkin.MouseState.HOVER;
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(18, 18);
            this.label73.TabIndex = 24;
            this.label73.Text = "Tx";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.BackColor = System.Drawing.Color.Transparent;
            this.label74.Depth = 0;
            this.label74.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label74.Location = new System.Drawing.Point(79, 58);
            this.label74.MouseState = MaterialSkin.MouseState.HOVER;
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(19, 18);
            this.label74.TabIndex = 25;
            this.label74.Text = "Ty";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.BackColor = System.Drawing.Color.Transparent;
            this.label75.Depth = 0;
            this.label75.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label75.Location = new System.Drawing.Point(79, 92);
            this.label75.MouseState = MaterialSkin.MouseState.HOVER;
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(18, 18);
            this.label75.TabIndex = 26;
            this.label75.Text = "Tz";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.BackColor = System.Drawing.Color.Transparent;
            this.label76.Depth = 0;
            this.label76.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label76.Location = new System.Drawing.Point(189, 24);
            this.label76.MouseState = MaterialSkin.MouseState.HOVER;
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(19, 18);
            this.label76.TabIndex = 27;
            this.label76.Text = "Rx";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.BackColor = System.Drawing.Color.Transparent;
            this.label77.Depth = 0;
            this.label77.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label77.Location = new System.Drawing.Point(189, 58);
            this.label77.MouseState = MaterialSkin.MouseState.HOVER;
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(20, 18);
            this.label77.TabIndex = 28;
            this.label77.Text = "Ry";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.BackColor = System.Drawing.Color.Transparent;
            this.label78.Depth = 0;
            this.label78.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label78.Location = new System.Drawing.Point(189, 92);
            this.label78.MouseState = MaterialSkin.MouseState.HOVER;
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(19, 18);
            this.label78.TabIndex = 29;
            this.label78.Text = "Rz";
            // 
            // tbGlassPointTy
            // 
            this.tbGlassPointTy.AnimateReadOnly = false;
            this.tbGlassPointTy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbGlassPointTy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbGlassPointTy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbGlassPointTy.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbGlassPointTy.Depth = 0;
            this.tbGlassPointTy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGlassPointTy.HideSelection = true;
            this.tbGlassPointTy.LeadingIcon = null;
            this.tbGlassPointTy.Location = new System.Drawing.Point(105, 55);
            this.tbGlassPointTy.MaxLength = 32767;
            this.tbGlassPointTy.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGlassPointTy.Name = "tbGlassPointTy";
            this.tbGlassPointTy.PasswordChar = '\0';
            this.tbGlassPointTy.PrefixSuffixText = null;
            this.tbGlassPointTy.ReadOnly = true;
            this.tbGlassPointTy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbGlassPointTy.SelectedText = "";
            this.tbGlassPointTy.SelectionLength = 0;
            this.tbGlassPointTy.SelectionStart = 0;
            this.tbGlassPointTy.ShortcutsEnabled = true;
            this.tbGlassPointTy.Size = new System.Drawing.Size(80, 26);
            this.tbGlassPointTy.TabIndex = 30;
            this.tbGlassPointTy.TabStop = false;
            this.tbGlassPointTy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbGlassPointTy.TrailingIcon = null;
            this.tbGlassPointTy.UseSystemPasswordChar = false;
            this.tbGlassPointTy.UseTallSize = false;
            // 
            // tbGlassPointTz
            // 
            this.tbGlassPointTz.AnimateReadOnly = false;
            this.tbGlassPointTz.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbGlassPointTz.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbGlassPointTz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbGlassPointTz.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbGlassPointTz.Depth = 0;
            this.tbGlassPointTz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGlassPointTz.HideSelection = true;
            this.tbGlassPointTz.LeadingIcon = null;
            this.tbGlassPointTz.Location = new System.Drawing.Point(105, 89);
            this.tbGlassPointTz.MaxLength = 32767;
            this.tbGlassPointTz.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGlassPointTz.Name = "tbGlassPointTz";
            this.tbGlassPointTz.PasswordChar = '\0';
            this.tbGlassPointTz.PrefixSuffixText = null;
            this.tbGlassPointTz.ReadOnly = true;
            this.tbGlassPointTz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbGlassPointTz.SelectedText = "";
            this.tbGlassPointTz.SelectionLength = 0;
            this.tbGlassPointTz.SelectionStart = 0;
            this.tbGlassPointTz.ShortcutsEnabled = true;
            this.tbGlassPointTz.Size = new System.Drawing.Size(80, 26);
            this.tbGlassPointTz.TabIndex = 31;
            this.tbGlassPointTz.TabStop = false;
            this.tbGlassPointTz.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbGlassPointTz.TrailingIcon = null;
            this.tbGlassPointTz.UseSystemPasswordChar = false;
            this.tbGlassPointTz.UseTallSize = false;
            // 
            // tbGlassPointRx
            // 
            this.tbGlassPointRx.AnimateReadOnly = false;
            this.tbGlassPointRx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbGlassPointRx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbGlassPointRx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbGlassPointRx.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbGlassPointRx.Depth = 0;
            this.tbGlassPointRx.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGlassPointRx.HideSelection = true;
            this.tbGlassPointRx.LeadingIcon = null;
            this.tbGlassPointRx.Location = new System.Drawing.Point(216, 21);
            this.tbGlassPointRx.MaxLength = 32767;
            this.tbGlassPointRx.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGlassPointRx.Name = "tbGlassPointRx";
            this.tbGlassPointRx.PasswordChar = '\0';
            this.tbGlassPointRx.PrefixSuffixText = null;
            this.tbGlassPointRx.ReadOnly = true;
            this.tbGlassPointRx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbGlassPointRx.SelectedText = "";
            this.tbGlassPointRx.SelectionLength = 0;
            this.tbGlassPointRx.SelectionStart = 0;
            this.tbGlassPointRx.ShortcutsEnabled = true;
            this.tbGlassPointRx.Size = new System.Drawing.Size(80, 26);
            this.tbGlassPointRx.TabIndex = 32;
            this.tbGlassPointRx.TabStop = false;
            this.tbGlassPointRx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbGlassPointRx.TrailingIcon = null;
            this.tbGlassPointRx.UseSystemPasswordChar = false;
            this.tbGlassPointRx.UseTallSize = false;
            // 
            // tbGlassPointRz
            // 
            this.tbGlassPointRz.AnimateReadOnly = false;
            this.tbGlassPointRz.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbGlassPointRz.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbGlassPointRz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbGlassPointRz.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbGlassPointRz.Depth = 0;
            this.tbGlassPointRz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGlassPointRz.HideSelection = true;
            this.tbGlassPointRz.LeadingIcon = null;
            this.tbGlassPointRz.Location = new System.Drawing.Point(216, 89);
            this.tbGlassPointRz.MaxLength = 32767;
            this.tbGlassPointRz.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGlassPointRz.Name = "tbGlassPointRz";
            this.tbGlassPointRz.PasswordChar = '\0';
            this.tbGlassPointRz.PrefixSuffixText = null;
            this.tbGlassPointRz.ReadOnly = true;
            this.tbGlassPointRz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbGlassPointRz.SelectedText = "";
            this.tbGlassPointRz.SelectionLength = 0;
            this.tbGlassPointRz.SelectionStart = 0;
            this.tbGlassPointRz.ShortcutsEnabled = true;
            this.tbGlassPointRz.Size = new System.Drawing.Size(80, 26);
            this.tbGlassPointRz.TabIndex = 33;
            this.tbGlassPointRz.TabStop = false;
            this.tbGlassPointRz.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbGlassPointRz.TrailingIcon = null;
            this.tbGlassPointRz.UseSystemPasswordChar = false;
            this.tbGlassPointRz.UseTallSize = false;
            // 
            // tbGlassPointRy
            // 
            this.tbGlassPointRy.AnimateReadOnly = false;
            this.tbGlassPointRy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbGlassPointRy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbGlassPointRy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbGlassPointRy.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbGlassPointRy.Depth = 0;
            this.tbGlassPointRy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGlassPointRy.HideSelection = true;
            this.tbGlassPointRy.LeadingIcon = null;
            this.tbGlassPointRy.Location = new System.Drawing.Point(216, 55);
            this.tbGlassPointRy.MaxLength = 32767;
            this.tbGlassPointRy.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGlassPointRy.Name = "tbGlassPointRy";
            this.tbGlassPointRy.PasswordChar = '\0';
            this.tbGlassPointRy.PrefixSuffixText = null;
            this.tbGlassPointRy.ReadOnly = true;
            this.tbGlassPointRy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbGlassPointRy.SelectedText = "";
            this.tbGlassPointRy.SelectionLength = 0;
            this.tbGlassPointRy.SelectionStart = 0;
            this.tbGlassPointRy.ShortcutsEnabled = true;
            this.tbGlassPointRy.Size = new System.Drawing.Size(80, 26);
            this.tbGlassPointRy.TabIndex = 34;
            this.tbGlassPointRy.TabStop = false;
            this.tbGlassPointRy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbGlassPointRy.TrailingIcon = null;
            this.tbGlassPointRy.UseSystemPasswordChar = false;
            this.tbGlassPointRy.UseTallSize = false;
            // 
            // splitContainer3
            // 
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer5);
            this.splitContainer3.Panel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.pictureBox4);
            this.splitContainer3.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer3.Size = new System.Drawing.Size(571, 925);
            this.splitContainer3.SplitterDistance = 798;
            this.splitContainer3.TabIndex = 98;
            // 
            // splitContainer5
            // 
            this.splitContainer5.IsSplitterFixed = true;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.btnNgListClear_);
            this.splitContainer5.Panel1.Controls.Add(this.lblErrorNotice);
            this.splitContainer5.Panel1MinSize = 41;
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer5.Size = new System.Drawing.Size(570, 809);
            this.splitContainer5.SplitterDistance = 71;
            this.splitContainer5.SplitterWidth = 1;
            this.splitContainer5.TabIndex = 0;
            // 
            // btnNgListClear_
            // 
            this.btnNgListClear_.AutoSize = false;
            this.btnNgListClear_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNgListClear_.BackColor = System.Drawing.Color.DimGray;
            this.btnNgListClear_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnNgListClear_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNgListClear_.Depth = 0;
            this.btnNgListClear_.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnNgListClear_.FlatAppearance.BorderSize = 0;
            this.btnNgListClear_.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btnNgListClear_.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnNgListClear_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNgListClear_.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNgListClear_.ForeColor = System.Drawing.Color.White;
            this.btnNgListClear_.HighEmphasis = true;
            this.btnNgListClear_.Icon = null;
            this.btnNgListClear_.Location = new System.Drawing.Point(439, 47);
            this.btnNgListClear_.Margin = new System.Windows.Forms.Padding(0);
            this.btnNgListClear_.MaximumSize = new System.Drawing.Size(128, 23);
            this.btnNgListClear_.MinimumSize = new System.Drawing.Size(128, 23);
            this.btnNgListClear_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNgListClear_.Name = "btnNgListClear_";
            this.btnNgListClear_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNgListClear_.Size = new System.Drawing.Size(128, 23);
            this.btnNgListClear_.TabIndex = 99;
            this.btnNgListClear_.Text = "Ng Log Reset";
            this.btnNgListClear_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNgListClear_.UseAccentColor = false;
            this.btnNgListClear_.UseVisualStyleBackColor = false;
            this.btnNgListClear_.Visible = false;
            this.btnNgListClear_.Click += new System.EventHandler(this.btnNgListClear__Click);
            // 
            // lblErrorNotice
            // 
            this.lblErrorNotice.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorNotice.Depth = 0;
            this.lblErrorNotice.Font = new System.Drawing.Font("NanumSquareRound Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblErrorNotice.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.lblErrorNotice.ForeColor = System.Drawing.Color.White;
            this.lblErrorNotice.Location = new System.Drawing.Point(0, 5);
            this.lblErrorNotice.Margin = new System.Windows.Forms.Padding(0);
            this.lblErrorNotice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblErrorNotice.Name = "lblErrorNotice";
            this.lblErrorNotice.Size = new System.Drawing.Size(400, 65);
            this.lblErrorNotice.TabIndex = 100;
            this.lblErrorNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelNgListViewHeader, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ltvNG, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rtbLog, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 535F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(567, 726);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelNgListViewHeader
            // 
            this.panelNgListViewHeader.BackColor = System.Drawing.SystemColors.Control;
            this.panelNgListViewHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNgListViewHeader.Controls.Add(this.lblDashDate);
            this.panelNgListViewHeader.Controls.Add(this.lblDashType);
            this.panelNgListViewHeader.Controls.Add(this.lblDashCarSeqNum);
            this.panelNgListViewHeader.Controls.Add(this.lblDashCarType);
            this.panelNgListViewHeader.Location = new System.Drawing.Point(0, 0);
            this.panelNgListViewHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panelNgListViewHeader.Name = "panelNgListViewHeader";
            this.panelNgListViewHeader.Size = new System.Drawing.Size(567, 30);
            this.panelNgListViewHeader.TabIndex = 101;
            // 
            // lblDashDate
            // 
            this.lblDashDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDashDate.Depth = 0;
            this.lblDashDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDashDate.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDashDate.Location = new System.Drawing.Point(344, 0);
            this.lblDashDate.Margin = new System.Windows.Forms.Padding(0);
            this.lblDashDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDashDate.Name = "lblDashDate";
            this.lblDashDate.Size = new System.Drawing.Size(221, 28);
            this.lblDashDate.TabIndex = 3;
            this.lblDashDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDashType
            // 
            this.lblDashType.BackColor = System.Drawing.Color.Transparent;
            this.lblDashType.Depth = 0;
            this.lblDashType.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDashType.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDashType.Location = new System.Drawing.Point(226, 0);
            this.lblDashType.Margin = new System.Windows.Forms.Padding(0);
            this.lblDashType.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDashType.Name = "lblDashType";
            this.lblDashType.Size = new System.Drawing.Size(120, 28);
            this.lblDashType.TabIndex = 2;
            this.lblDashType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDashCarSeqNum
            // 
            this.lblDashCarSeqNum.BackColor = System.Drawing.Color.Transparent;
            this.lblDashCarSeqNum.Depth = 0;
            this.lblDashCarSeqNum.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDashCarSeqNum.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDashCarSeqNum.Location = new System.Drawing.Point(113, 0);
            this.lblDashCarSeqNum.Margin = new System.Windows.Forms.Padding(0);
            this.lblDashCarSeqNum.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDashCarSeqNum.Name = "lblDashCarSeqNum";
            this.lblDashCarSeqNum.Size = new System.Drawing.Size(113, 28);
            this.lblDashCarSeqNum.TabIndex = 1;
            this.lblDashCarSeqNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDashCarType
            // 
            this.lblDashCarType.BackColor = System.Drawing.Color.Transparent;
            this.lblDashCarType.Depth = 0;
            this.lblDashCarType.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDashCarType.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDashCarType.Location = new System.Drawing.Point(0, 0);
            this.lblDashCarType.Margin = new System.Windows.Forms.Padding(0);
            this.lblDashCarType.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDashCarType.Name = "lblDashCarType";
            this.lblDashCarType.Size = new System.Drawing.Size(113, 28);
            this.lblDashCarType.TabIndex = 0;
            this.lblDashCarType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ltvNG
            // 
            this.ltvNG.FullRowSelect = true;
            this.ltvNG.GridLines = true;
            this.ltvNG.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ltvNG.HideSelection = false;
            this.ltvNG.Location = new System.Drawing.Point(0, 30);
            this.ltvNG.Margin = new System.Windows.Forms.Padding(0);
            this.ltvNG.MultiSelect = false;
            this.ltvNG.Name = "ltvNG";
            this.ltvNG.Size = new System.Drawing.Size(567, 191);
            this.ltvNG.TabIndex = 52;
            this.ltvNG.UseCompatibleStateImageBehavior = false;
            this.ltvNG.View = System.Windows.Forms.View.Details;
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.Depth = 0;
            this.rtbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rtbLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtbLog.Location = new System.Drawing.Point(0, 221);
            this.rtbLog.Margin = new System.Windows.Forms.Padding(0);
            this.rtbLog.MouseState = MaterialSkin.MouseState.HOVER;
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(567, 501);
            this.rtbLog.TabIndex = 51;
            this.rtbLog.Text = "";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(571, 123);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 98;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(571, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 97;
            this.pictureBox2.TabStop = false;
            // 
            // tbGlassMaxValueRz
            // 
            this.tbGlassMaxValueRz.AnimateReadOnly = false;
            this.tbGlassMaxValueRz.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbGlassMaxValueRz.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbGlassMaxValueRz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbGlassMaxValueRz.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbGlassMaxValueRz.Depth = 0;
            this.tbGlassMaxValueRz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGlassMaxValueRz.HideSelection = true;
            this.tbGlassMaxValueRz.LeadingIcon = null;
            this.tbGlassMaxValueRz.Location = new System.Drawing.Point(0, 0);
            this.tbGlassMaxValueRz.MaxLength = 32767;
            this.tbGlassMaxValueRz.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGlassMaxValueRz.Name = "tbGlassMaxValueRz";
            this.tbGlassMaxValueRz.PasswordChar = '\0';
            this.tbGlassMaxValueRz.PrefixSuffixText = null;
            this.tbGlassMaxValueRz.ReadOnly = false;
            this.tbGlassMaxValueRz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbGlassMaxValueRz.SelectedText = "";
            this.tbGlassMaxValueRz.SelectionLength = 0;
            this.tbGlassMaxValueRz.SelectionStart = 0;
            this.tbGlassMaxValueRz.ShortcutsEnabled = true;
            this.tbGlassMaxValueRz.Size = new System.Drawing.Size(250, 48);
            this.tbGlassMaxValueRz.TabIndex = 0;
            this.tbGlassMaxValueRz.TabStop = false;
            this.tbGlassMaxValueRz.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbGlassMaxValueRz.TrailingIcon = null;
            this.tbGlassMaxValueRz.UseSystemPasswordChar = false;
            // 
            // label90
            // 
            this.label90.Depth = 0;
            this.label90.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label90.Location = new System.Drawing.Point(0, 0);
            this.label90.MouseState = MaterialSkin.MouseState.HOVER;
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(100, 23);
            this.label90.TabIndex = 0;
            // 
            // tbGlassMaxValueTy
            // 
            this.tbGlassMaxValueTy.AnimateReadOnly = false;
            this.tbGlassMaxValueTy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbGlassMaxValueTy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbGlassMaxValueTy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbGlassMaxValueTy.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbGlassMaxValueTy.Depth = 0;
            this.tbGlassMaxValueTy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGlassMaxValueTy.HideSelection = true;
            this.tbGlassMaxValueTy.LeadingIcon = null;
            this.tbGlassMaxValueTy.Location = new System.Drawing.Point(0, 0);
            this.tbGlassMaxValueTy.MaxLength = 32767;
            this.tbGlassMaxValueTy.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGlassMaxValueTy.Name = "tbGlassMaxValueTy";
            this.tbGlassMaxValueTy.PasswordChar = '\0';
            this.tbGlassMaxValueTy.PrefixSuffixText = null;
            this.tbGlassMaxValueTy.ReadOnly = false;
            this.tbGlassMaxValueTy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbGlassMaxValueTy.SelectedText = "";
            this.tbGlassMaxValueTy.SelectionLength = 0;
            this.tbGlassMaxValueTy.SelectionStart = 0;
            this.tbGlassMaxValueTy.ShortcutsEnabled = true;
            this.tbGlassMaxValueTy.Size = new System.Drawing.Size(250, 48);
            this.tbGlassMaxValueTy.TabIndex = 0;
            this.tbGlassMaxValueTy.TabStop = false;
            this.tbGlassMaxValueTy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbGlassMaxValueTy.TrailingIcon = null;
            this.tbGlassMaxValueTy.UseSystemPasswordChar = false;
            // 
            // label94
            // 
            this.label94.Depth = 0;
            this.label94.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label94.Location = new System.Drawing.Point(0, 0);
            this.label94.MouseState = MaterialSkin.MouseState.HOVER;
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(100, 23);
            this.label94.TabIndex = 0;
            // 
            // tbGlassMaxValueTx
            // 
            this.tbGlassMaxValueTx.AnimateReadOnly = false;
            this.tbGlassMaxValueTx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbGlassMaxValueTx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbGlassMaxValueTx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbGlassMaxValueTx.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbGlassMaxValueTx.Depth = 0;
            this.tbGlassMaxValueTx.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGlassMaxValueTx.HideSelection = true;
            this.tbGlassMaxValueTx.LeadingIcon = null;
            this.tbGlassMaxValueTx.Location = new System.Drawing.Point(0, 0);
            this.tbGlassMaxValueTx.MaxLength = 32767;
            this.tbGlassMaxValueTx.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGlassMaxValueTx.Name = "tbGlassMaxValueTx";
            this.tbGlassMaxValueTx.PasswordChar = '\0';
            this.tbGlassMaxValueTx.PrefixSuffixText = null;
            this.tbGlassMaxValueTx.ReadOnly = false;
            this.tbGlassMaxValueTx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbGlassMaxValueTx.SelectedText = "";
            this.tbGlassMaxValueTx.SelectionLength = 0;
            this.tbGlassMaxValueTx.SelectionStart = 0;
            this.tbGlassMaxValueTx.ShortcutsEnabled = true;
            this.tbGlassMaxValueTx.Size = new System.Drawing.Size(250, 48);
            this.tbGlassMaxValueTx.TabIndex = 0;
            this.tbGlassMaxValueTx.TabStop = false;
            this.tbGlassMaxValueTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbGlassMaxValueTx.TrailingIcon = null;
            this.tbGlassMaxValueTx.UseSystemPasswordChar = false;
            // 
            // label95
            // 
            this.label95.Depth = 0;
            this.label95.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label95.Location = new System.Drawing.Point(0, 0);
            this.label95.MouseState = MaterialSkin.MouseState.HOVER;
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(100, 23);
            this.label95.TabIndex = 0;
            // 
            // glassWriteSignalStatus
            // 
            this.glassWriteSignalStatus.Location = new System.Drawing.Point(0, 0);
            this.glassWriteSignalStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.glassWriteSignalStatus.Name = "glassWriteSignalStatus";
            this.glassWriteSignalStatus.RowCount = 3;
            this.glassWriteSignalStatus.RowHeight = 30;
            this.glassWriteSignalStatus.Size = new System.Drawing.Size(153, 94);
            this.glassWriteSignalStatus.TabIndex = 0;
            // 
            // glassWriteSignal2Status
            // 
            this.glassWriteSignal2Status.ColumnWidth1 = 100;
            this.glassWriteSignal2Status.ColumnWidth2 = 50;
            this.glassWriteSignal2Status.Location = new System.Drawing.Point(0, 0);
            this.glassWriteSignal2Status.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.glassWriteSignal2Status.Name = "glassWriteSignal2Status";
            this.glassWriteSignal2Status.RowCount = 3;
            this.glassWriteSignal2Status.RowHeight = 30;
            this.glassWriteSignal2Status.Size = new System.Drawing.Size(153, 94);
            this.glassWriteSignal2Status.TabIndex = 0;
            // 
            // label92
            // 
            this.label92.Depth = 0;
            this.label92.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label92.Location = new System.Drawing.Point(0, 0);
            this.label92.MouseState = MaterialSkin.MouseState.HOVER;
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(100, 23);
            this.label92.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.AnimateReadOnly = false;
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBox1.Depth = 0;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox1.HideSelection = true;
            this.textBox1.LeadingIcon = null;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.MaxLength = 32767;
            this.textBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.PrefixSuffixText = null;
            this.textBox1.ReadOnly = false;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.SelectedText = "";
            this.textBox1.SelectionLength = 0;
            this.textBox1.SelectionStart = 0;
            this.textBox1.ShortcutsEnabled = true;
            this.textBox1.Size = new System.Drawing.Size(250, 48);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox1.TrailingIcon = null;
            this.textBox1.UseSystemPasswordChar = false;
            // 
            // lblGlassCameraModel_
            // 
            this.lblGlassCameraModel_.Depth = 0;
            this.lblGlassCameraModel_.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGlassCameraModel_.Location = new System.Drawing.Point(0, 0);
            this.lblGlassCameraModel_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGlassCameraModel_.Name = "lblGlassCameraModel_";
            this.lblGlassCameraModel_.Size = new System.Drawing.Size(100, 23);
            this.lblGlassCameraModel_.TabIndex = 0;
            // 
            // lblGlassCameraSerials_
            // 
            this.lblGlassCameraSerials_.Depth = 0;
            this.lblGlassCameraSerials_.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGlassCameraSerials_.Location = new System.Drawing.Point(0, 0);
            this.lblGlassCameraSerials_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGlassCameraSerials_.Name = "lblGlassCameraSerials_";
            this.lblGlassCameraSerials_.Size = new System.Drawing.Size(100, 23);
            this.lblGlassCameraSerials_.TabIndex = 0;
            // 
            // tbGlassCamera
            // 
            this.tbGlassCamera.AnimateReadOnly = false;
            this.tbGlassCamera.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbGlassCamera.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbGlassCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbGlassCamera.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbGlassCamera.Depth = 0;
            this.tbGlassCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGlassCamera.HideSelection = true;
            this.tbGlassCamera.LeadingIcon = null;
            this.tbGlassCamera.Location = new System.Drawing.Point(0, 0);
            this.tbGlassCamera.MaxLength = 32767;
            this.tbGlassCamera.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGlassCamera.Name = "tbGlassCamera";
            this.tbGlassCamera.PasswordChar = '\0';
            this.tbGlassCamera.PrefixSuffixText = null;
            this.tbGlassCamera.ReadOnly = false;
            this.tbGlassCamera.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbGlassCamera.SelectedText = "";
            this.tbGlassCamera.SelectionLength = 0;
            this.tbGlassCamera.SelectionStart = 0;
            this.tbGlassCamera.ShortcutsEnabled = true;
            this.tbGlassCamera.Size = new System.Drawing.Size(250, 48);
            this.tbGlassCamera.TabIndex = 0;
            this.tbGlassCamera.TabStop = false;
            this.tbGlassCamera.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbGlassCamera.TrailingIcon = null;
            this.tbGlassCamera.UseSystemPasswordChar = false;
            // 
            // lblGlassCamera_
            // 
            this.lblGlassCamera_.Depth = 0;
            this.lblGlassCamera_.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGlassCamera_.Location = new System.Drawing.Point(0, 0);
            this.lblGlassCamera_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGlassCamera_.Name = "lblGlassCamera_";
            this.lblGlassCamera_.Size = new System.Drawing.Size(100, 23);
            this.lblGlassCamera_.TabIndex = 0;
            // 
            // tbGlassCameraModel
            // 
            this.tbGlassCameraModel.AnimateReadOnly = false;
            this.tbGlassCameraModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbGlassCameraModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbGlassCameraModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbGlassCameraModel.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbGlassCameraModel.Depth = 0;
            this.tbGlassCameraModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGlassCameraModel.HideSelection = true;
            this.tbGlassCameraModel.LeadingIcon = null;
            this.tbGlassCameraModel.Location = new System.Drawing.Point(0, 0);
            this.tbGlassCameraModel.MaxLength = 32767;
            this.tbGlassCameraModel.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGlassCameraModel.Name = "tbGlassCameraModel";
            this.tbGlassCameraModel.PasswordChar = '\0';
            this.tbGlassCameraModel.PrefixSuffixText = null;
            this.tbGlassCameraModel.ReadOnly = false;
            this.tbGlassCameraModel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbGlassCameraModel.SelectedText = "";
            this.tbGlassCameraModel.SelectionLength = 0;
            this.tbGlassCameraModel.SelectionStart = 0;
            this.tbGlassCameraModel.ShortcutsEnabled = true;
            this.tbGlassCameraModel.Size = new System.Drawing.Size(250, 48);
            this.tbGlassCameraModel.TabIndex = 0;
            this.tbGlassCameraModel.TabStop = false;
            this.tbGlassCameraModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbGlassCameraModel.TrailingIcon = null;
            this.tbGlassCameraModel.UseSystemPasswordChar = false;
            // 
            // glassReadSignalStatus
            // 
            this.glassReadSignalStatus.Location = new System.Drawing.Point(0, 0);
            this.glassReadSignalStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.glassReadSignalStatus.Name = "glassReadSignalStatus";
            this.glassReadSignalStatus.RowCount = 3;
            this.glassReadSignalStatus.RowHeight = 30;
            this.glassReadSignalStatus.Size = new System.Drawing.Size(153, 94);
            this.glassReadSignalStatus.TabIndex = 0;
            // 
            // carTypeSignalStatus
            // 
            this.carTypeSignalStatus.ColumnWidth1 = 100;
            this.carTypeSignalStatus.ColumnWidth2 = 50;
            this.carTypeSignalStatus.Location = new System.Drawing.Point(0, 0);
            this.carTypeSignalStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.carTypeSignalStatus.Name = "carTypeSignalStatus";
            this.carTypeSignalStatus.RowCount = 3;
            this.carTypeSignalStatus.RowHeight = 30;
            this.carTypeSignalStatus.Size = new System.Drawing.Size(153, 94);
            this.carTypeSignalStatus.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "yml";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "YAML(*.yml;*.yaml)|*.yml;*.yaml|All files|*.*";
            this.openFileDialog1.ShowHelp = true;
            // 
            // gbMode
            // 
            this.gbMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbMode.Controls.Add(this.rbManual_);
            this.gbMode.Controls.Add(this.rbSet_);
            this.gbMode.Controls.Add(this.rbAuto_);
            this.gbMode.Depth = 0;
            this.gbMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbMode.Location = new System.Drawing.Point(6, 3);
            this.gbMode.Margin = new System.Windows.Forms.Padding(14);
            this.gbMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.gbMode.Name = "gbMode";
            this.gbMode.Padding = new System.Windows.Forms.Padding(14);
            this.gbMode.Size = new System.Drawing.Size(297, 62);
            this.gbMode.TabIndex = 0;
            // 
            // rbManual_
            // 
            this.rbManual_.AutoSize = true;
            this.rbManual_.Depth = 0;
            this.rbManual_.Location = new System.Drawing.Point(99, 14);
            this.rbManual_.Margin = new System.Windows.Forms.Padding(0);
            this.rbManual_.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbManual_.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbManual_.Name = "rbManual_";
            this.rbManual_.Ripple = true;
            this.rbManual_.Size = new System.Drawing.Size(91, 37);
            this.rbManual_.TabIndex = 2;
            this.rbManual_.TabStop = true;
            this.rbManual_.Text = "Manual";
            this.rbManual_.UseVisualStyleBackColor = true;
            this.rbManual_.Click += new System.EventHandler(this.rbManual__Click);
            // 
            // rbSet_
            // 
            this.rbSet_.AutoSize = true;
            this.rbSet_.Depth = 0;
            this.rbSet_.Font = new System.Drawing.Font("Consolas", 12F);
            this.rbSet_.Location = new System.Drawing.Point(193, 14);
            this.rbSet_.Margin = new System.Windows.Forms.Padding(0);
            this.rbSet_.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbSet_.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbSet_.Name = "rbSet_";
            this.rbSet_.Ripple = true;
            this.rbSet_.Size = new System.Drawing.Size(90, 37);
            this.rbSet_.TabIndex = 1;
            this.rbSet_.TabStop = true;
            this.rbSet_.Text = "Setting";
            this.rbSet_.UseVisualStyleBackColor = true;
            this.rbSet_.Click += new System.EventHandler(this.rbSet__Click);
            // 
            // rbAuto_
            // 
            this.rbAuto_.AutoSize = true;
            this.rbAuto_.Checked = true;
            this.rbAuto_.Depth = 0;
            this.rbAuto_.Font = new System.Drawing.Font("Consolas", 12F);
            this.rbAuto_.Location = new System.Drawing.Point(9, 14);
            this.rbAuto_.Margin = new System.Windows.Forms.Padding(0);
            this.rbAuto_.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbAuto_.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbAuto_.Name = "rbAuto_";
            this.rbAuto_.Ripple = true;
            this.rbAuto_.Size = new System.Drawing.Size(72, 37);
            this.rbAuto_.TabIndex = 0;
            this.rbAuto_.TabStop = true;
            this.rbAuto_.Text = "Auto";
            this.rbAuto_.UseVisualStyleBackColor = true;
            this.rbAuto_.Click += new System.EventHandler(this.rbAuto__Click);
            // 
            // gbPLC
            // 
            this.gbPLC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbPLC.Controls.Add(this.lblPlc);
            this.gbPLC.Controls.Add(this.tbPlc);
            this.gbPLC.Depth = 0;
            this.gbPLC.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPLC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbPLC.Location = new System.Drawing.Point(308, 3);
            this.gbPLC.Margin = new System.Windows.Forms.Padding(14);
            this.gbPLC.MouseState = MaterialSkin.MouseState.HOVER;
            this.gbPLC.Name = "gbPLC";
            this.gbPLC.Padding = new System.Windows.Forms.Padding(14);
            this.gbPLC.Size = new System.Drawing.Size(299, 62);
            this.gbPLC.TabIndex = 27;
            // 
            // lblPlc
            // 
            this.lblPlc.AutoSize = true;
            this.lblPlc.BackColor = System.Drawing.Color.Transparent;
            this.lblPlc.Depth = 0;
            this.lblPlc.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPlc.Location = new System.Drawing.Point(12, 0);
            this.lblPlc.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPlc.Name = "lblPlc";
            this.lblPlc.Size = new System.Drawing.Size(5, 18);
            this.lblPlc.TabIndex = 158;
            this.lblPlc.Text = " ";
            // 
            // tbPlc
            // 
            this.tbPlc.AnimateReadOnly = false;
            this.tbPlc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbPlc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbPlc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbPlc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbPlc.Depth = 0;
            this.tbPlc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPlc.HideSelection = true;
            this.tbPlc.LeadingIcon = null;
            this.tbPlc.Location = new System.Drawing.Point(151, 8);
            this.tbPlc.MaxLength = 32767;
            this.tbPlc.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPlc.Name = "tbPlc";
            this.tbPlc.PasswordChar = '\0';
            this.tbPlc.PrefixSuffixText = null;
            this.tbPlc.ReadOnly = true;
            this.tbPlc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPlc.SelectedText = "";
            this.tbPlc.SelectionLength = 0;
            this.tbPlc.SelectionStart = 0;
            this.tbPlc.ShortcutsEnabled = true;
            this.tbPlc.Size = new System.Drawing.Size(140, 48);
            this.tbPlc.TabIndex = 140;
            this.tbPlc.TabStop = false;
            this.tbPlc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPlc.TrailingIcon = null;
            this.tbPlc.UseSystemPasswordChar = false;
            // 
            // gbCarType
            // 
            this.gbCarType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbCarType.Controls.Add(this.tbCarType);
            this.gbCarType.Controls.Add(this.cmbCarTypeName);
            this.gbCarType.Depth = 0;
            this.gbCarType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbCarType.Location = new System.Drawing.Point(613, 3);
            this.gbCarType.Margin = new System.Windows.Forms.Padding(14);
            this.gbCarType.MouseState = MaterialSkin.MouseState.HOVER;
            this.gbCarType.Name = "gbCarType";
            this.gbCarType.Padding = new System.Windows.Forms.Padding(14);
            this.gbCarType.Size = new System.Drawing.Size(315, 62);
            this.gbCarType.TabIndex = 1;
            // 
            // tbCarType
            // 
            this.tbCarType.AnimateReadOnly = false;
            this.tbCarType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbCarType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbCarType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbCarType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCarType.Depth = 0;
            this.tbCarType.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbCarType.HideSelection = true;
            this.tbCarType.LeadingIcon = null;
            this.tbCarType.Location = new System.Drawing.Point(228, 8);
            this.tbCarType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCarType.MaxLength = 32767;
            this.tbCarType.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCarType.Name = "tbCarType";
            this.tbCarType.PasswordChar = '\0';
            this.tbCarType.PrefixSuffixText = null;
            this.tbCarType.ReadOnly = true;
            this.tbCarType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCarType.SelectedText = "";
            this.tbCarType.SelectionLength = 0;
            this.tbCarType.SelectionStart = 0;
            this.tbCarType.ShortcutsEnabled = true;
            this.tbCarType.Size = new System.Drawing.Size(73, 48);
            this.tbCarType.TabIndex = 1;
            this.tbCarType.TabStop = false;
            this.tbCarType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCarType.TrailingIcon = null;
            this.tbCarType.UseSystemPasswordChar = false;
            // 
            // cmbCarTypeName
            // 
            this.cmbCarTypeName.AutoResize = false;
            this.cmbCarTypeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCarTypeName.Depth = 0;
            this.cmbCarTypeName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCarTypeName.DropDownHeight = 174;
            this.cmbCarTypeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarTypeName.DropDownWidth = 121;
            this.cmbCarTypeName.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarTypeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCarTypeName.FormattingEnabled = true;
            this.cmbCarTypeName.IntegralHeight = false;
            this.cmbCarTypeName.ItemHeight = 43;
            this.cmbCarTypeName.Location = new System.Drawing.Point(12, 8);
            this.cmbCarTypeName.MaxDropDownItems = 4;
            this.cmbCarTypeName.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCarTypeName.Name = "cmbCarTypeName";
            this.cmbCarTypeName.Size = new System.Drawing.Size(204, 49);
            this.cmbCarTypeName.StartIndex = 0;
            this.cmbCarTypeName.TabIndex = 0;
            this.cmbCarTypeName.SelectedIndexChanged += new System.EventHandler(this.cmbCarTypeName_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 64);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.materialCard5);
            this.splitContainer1.Panel1.Controls.Add(this.gbCarSeqNumber_);
            this.splitContainer1.Panel1.Controls.Add(this.btnSettingManage_);
            this.splitContainer1.Panel1.Controls.Add(this.gbPLC);
            this.splitContainer1.Panel1.Controls.Add(this.gbMode);
            this.splitContainer1.Panel1.Controls.Add(this.gbCarType);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1914, 994);
            this.splitContainer1.SplitterDistance = 68;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 106;
            this.splitContainer1.TabStop = false;
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.tbCarBodyNumber);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(1088, 3);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(298, 65);
            this.materialCard5.TabIndex = 159;
            // 
            // tbCarBodyNumber
            // 
            this.tbCarBodyNumber.AnimateReadOnly = false;
            this.tbCarBodyNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbCarBodyNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbCarBodyNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbCarBodyNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCarBodyNumber.Depth = 0;
            this.tbCarBodyNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCarBodyNumber.HideSelection = true;
            this.tbCarBodyNumber.LeadingIcon = null;
            this.tbCarBodyNumber.Location = new System.Drawing.Point(7, 12);
            this.tbCarBodyNumber.MaxLength = 32767;
            this.tbCarBodyNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCarBodyNumber.Name = "tbCarBodyNumber";
            this.tbCarBodyNumber.PasswordChar = '\0';
            this.tbCarBodyNumber.PrefixSuffixText = null;
            this.tbCarBodyNumber.ReadOnly = true;
            this.tbCarBodyNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCarBodyNumber.SelectedText = "";
            this.tbCarBodyNumber.SelectionLength = 0;
            this.tbCarBodyNumber.SelectionStart = 0;
            this.tbCarBodyNumber.ShortcutsEnabled = true;
            this.tbCarBodyNumber.Size = new System.Drawing.Size(285, 48);
            this.tbCarBodyNumber.TabIndex = 0;
            this.tbCarBodyNumber.TabStop = false;
            this.tbCarBodyNumber.Text = "0";
            this.tbCarBodyNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCarBodyNumber.TrailingIcon = null;
            this.tbCarBodyNumber.UseSystemPasswordChar = false;
            // 
            // gbCarSeqNumber_
            // 
            this.gbCarSeqNumber_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbCarSeqNumber_.Controls.Add(this.tbCarSeqNumber);
            this.gbCarSeqNumber_.Depth = 0;
            this.gbCarSeqNumber_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbCarSeqNumber_.Location = new System.Drawing.Point(934, 3);
            this.gbCarSeqNumber_.Margin = new System.Windows.Forms.Padding(14);
            this.gbCarSeqNumber_.MouseState = MaterialSkin.MouseState.HOVER;
            this.gbCarSeqNumber_.Name = "gbCarSeqNumber_";
            this.gbCarSeqNumber_.Padding = new System.Windows.Forms.Padding(14);
            this.gbCarSeqNumber_.Size = new System.Drawing.Size(150, 62);
            this.gbCarSeqNumber_.TabIndex = 107;
            // 
            // tbCarSeqNumber
            // 
            this.tbCarSeqNumber.AnimateReadOnly = false;
            this.tbCarSeqNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbCarSeqNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbCarSeqNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbCarSeqNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCarSeqNumber.Depth = 0;
            this.tbCarSeqNumber.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCarSeqNumber.HideSelection = true;
            this.tbCarSeqNumber.LeadingIcon = null;
            this.tbCarSeqNumber.Location = new System.Drawing.Point(15, 8);
            this.tbCarSeqNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCarSeqNumber.MaxLength = 32767;
            this.tbCarSeqNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCarSeqNumber.Name = "tbCarSeqNumber";
            this.tbCarSeqNumber.PasswordChar = '\0';
            this.tbCarSeqNumber.PrefixSuffixText = null;
            this.tbCarSeqNumber.ReadOnly = true;
            this.tbCarSeqNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCarSeqNumber.SelectedText = "";
            this.tbCarSeqNumber.SelectionLength = 0;
            this.tbCarSeqNumber.SelectionStart = 0;
            this.tbCarSeqNumber.ShortcutsEnabled = true;
            this.tbCarSeqNumber.Size = new System.Drawing.Size(122, 48);
            this.tbCarSeqNumber.TabIndex = 0;
            this.tbCarSeqNumber.TabStop = false;
            this.tbCarSeqNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCarSeqNumber.TrailingIcon = null;
            this.tbCarSeqNumber.UseSystemPasswordChar = false;
            // 
            // btnSettingManage_
            // 
            this.btnSettingManage_.AutoSize = false;
            this.btnSettingManage_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSettingManage_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(65)))));
            this.btnSettingManage_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnSettingManage_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSettingManage_.Depth = 0;
            this.btnSettingManage_.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSettingManage_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingManage_.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnSettingManage_.ForeColor = System.Drawing.Color.Black;
            this.btnSettingManage_.HighEmphasis = true;
            this.btnSettingManage_.Icon = null;
            this.btnSettingManage_.Location = new System.Drawing.Point(1708, 13);
            this.btnSettingManage_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSettingManage_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSettingManage_.Name = "btnSettingManage_";
            this.btnSettingManage_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSettingManage_.Size = new System.Drawing.Size(195, 42);
            this.btnSettingManage_.TabIndex = 3;
            this.btnSettingManage_.Text = "Setting Manager";
            this.btnSettingManage_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSettingManage_.UseAccentColor = false;
            this.btnSettingManage_.UseVisualStyleBackColor = false;
            this.btnSettingManage_.Click += new System.EventHandler(this.btnSettingManager__Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Depth = 0;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label22.Location = new System.Drawing.Point(9, 114);
            this.label22.MouseState = MaterialSkin.MouseState.HOVER;
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(44, 12);
            this.label22.TabIndex = 71;
            this.label22.Text = "label22";
            // 
            // gbRobotRead
            // 
            this.gbRobotRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbRobotRead.Controls.Add(this.materialLabel24);
            this.gbRobotRead.Controls.Add(this.materialLabel13);
            this.gbRobotRead.Controls.Add(this.materialLabel9);
            this.gbRobotRead.Controls.Add(this.tbScanPoseRz_);
            this.gbRobotRead.Controls.Add(this.tbScanPoseTz_);
            this.gbRobotRead.Controls.Add(this.btnReadScanPose_);
            this.gbRobotRead.Controls.Add(this.tbCurrRobotTz);
            this.gbRobotRead.Controls.Add(this.tbCurrRobotRx);
            this.gbRobotRead.Controls.Add(this.tbScanPoseRx_);
            this.gbRobotRead.Controls.Add(this.tbScanPoseTx_);
            this.gbRobotRead.Controls.Add(this.materialLabel18);
            this.gbRobotRead.Controls.Add(this.materialLabel14);
            this.gbRobotRead.Controls.Add(this.materialLabel23);
            this.gbRobotRead.Controls.Add(this.materialLabel10);
            this.gbRobotRead.Controls.Add(this.materialLabel22);
            this.gbRobotRead.Controls.Add(this.materialLabel12);
            this.gbRobotRead.Controls.Add(this.tbScanPoseRy_);
            this.gbRobotRead.Controls.Add(this.tbScanPoseTy_);
            this.gbRobotRead.Depth = 0;
            this.gbRobotRead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbRobotRead.Location = new System.Drawing.Point(688, 13);
            this.gbRobotRead.Margin = new System.Windows.Forms.Padding(14);
            this.gbRobotRead.MouseState = MaterialSkin.MouseState.HOVER;
            this.gbRobotRead.Name = "gbRobotRead";
            this.gbRobotRead.Padding = new System.Windows.Forms.Padding(14);
            this.gbRobotRead.Size = new System.Drawing.Size(198, 354);
            this.gbRobotRead.TabIndex = 178;
            // 
            // materialLabel24
            // 
            this.materialLabel24.AutoSize = true;
            this.materialLabel24.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel24.Depth = 0;
            this.materialLabel24.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel24.Location = new System.Drawing.Point(17, 262);
            this.materialLabel24.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel24.Name = "materialLabel24";
            this.materialLabel24.Size = new System.Drawing.Size(19, 18);
            this.materialLabel24.TabIndex = 17;
            this.materialLabel24.Text = "Rz";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(17, 122);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(18, 18);
            this.materialLabel13.TabIndex = 17;
            this.materialLabel13.Text = "Tz";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(207, 10);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(18, 18);
            this.materialLabel9.TabIndex = 17;
            this.materialLabel9.Text = "Tz";
            // 
            // tbScanPoseRz_
            // 
            this.tbScanPoseRz_.AnimateReadOnly = false;
            this.tbScanPoseRz_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbScanPoseRz_.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbScanPoseRz_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbScanPoseRz_.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbScanPoseRz_.Depth = 0;
            this.tbScanPoseRz_.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.tbScanPoseRz_.HideSelection = true;
            this.tbScanPoseRz_.LeadingIcon = null;
            this.tbScanPoseRz_.Location = new System.Drawing.Point(48, 258);
            this.tbScanPoseRz_.MaxLength = 32767;
            this.tbScanPoseRz_.MouseState = MaterialSkin.MouseState.OUT;
            this.tbScanPoseRz_.Name = "tbScanPoseRz_";
            this.tbScanPoseRz_.PasswordChar = '\0';
            this.tbScanPoseRz_.PrefixSuffixText = null;
            this.tbScanPoseRz_.ReadOnly = true;
            this.tbScanPoseRz_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbScanPoseRz_.SelectedText = "";
            this.tbScanPoseRz_.SelectionLength = 0;
            this.tbScanPoseRz_.SelectionStart = 0;
            this.tbScanPoseRz_.ShortcutsEnabled = true;
            this.tbScanPoseRz_.Size = new System.Drawing.Size(139, 26);
            this.tbScanPoseRz_.TabIndex = 18;
            this.tbScanPoseRz_.TabStop = false;
            this.tbScanPoseRz_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbScanPoseRz_.TrailingIcon = null;
            this.tbScanPoseRz_.UseSystemPasswordChar = false;
            this.tbScanPoseRz_.UseTallSize = false;
            // 
            // tbScanPoseTz_
            // 
            this.tbScanPoseTz_.AnimateReadOnly = false;
            this.tbScanPoseTz_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbScanPoseTz_.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbScanPoseTz_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbScanPoseTz_.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbScanPoseTz_.Depth = 0;
            this.tbScanPoseTz_.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.tbScanPoseTz_.HideSelection = true;
            this.tbScanPoseTz_.LeadingIcon = null;
            this.tbScanPoseTz_.Location = new System.Drawing.Point(48, 118);
            this.tbScanPoseTz_.MaxLength = 32767;
            this.tbScanPoseTz_.MouseState = MaterialSkin.MouseState.OUT;
            this.tbScanPoseTz_.Name = "tbScanPoseTz_";
            this.tbScanPoseTz_.PasswordChar = '\0';
            this.tbScanPoseTz_.PrefixSuffixText = null;
            this.tbScanPoseTz_.ReadOnly = true;
            this.tbScanPoseTz_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbScanPoseTz_.SelectedText = "";
            this.tbScanPoseTz_.SelectionLength = 0;
            this.tbScanPoseTz_.SelectionStart = 0;
            this.tbScanPoseTz_.ShortcutsEnabled = true;
            this.tbScanPoseTz_.Size = new System.Drawing.Size(139, 26);
            this.tbScanPoseTz_.TabIndex = 18;
            this.tbScanPoseTz_.TabStop = false;
            this.tbScanPoseTz_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbScanPoseTz_.TrailingIcon = null;
            this.tbScanPoseTz_.UseSystemPasswordChar = false;
            this.tbScanPoseTz_.UseTallSize = false;
            // 
            // btnReadScanPose_
            // 
            this.btnReadScanPose_.AutoSize = false;
            this.btnReadScanPose_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReadScanPose_.BackColor = System.Drawing.Color.DimGray;
            this.btnReadScanPose_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnReadScanPose_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReadScanPose_.Depth = 0;
            this.btnReadScanPose_.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnReadScanPose_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadScanPose_.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnReadScanPose_.HighEmphasis = true;
            this.btnReadScanPose_.Icon = null;
            this.btnReadScanPose_.Location = new System.Drawing.Point(110, 33);
            this.btnReadScanPose_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReadScanPose_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReadScanPose_.Name = "btnReadScanPose_";
            this.btnReadScanPose_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReadScanPose_.Size = new System.Drawing.Size(77, 21);
            this.btnReadScanPose_.TabIndex = 178;
            this.btnReadScanPose_.Text = "READ";
            this.btnReadScanPose_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReadScanPose_.UseAccentColor = false;
            this.btnReadScanPose_.UseVisualStyleBackColor = false;
            // 
            // tbCurrRobotTz
            // 
            this.tbCurrRobotTz.AnimateReadOnly = false;
            this.tbCurrRobotTz.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbCurrRobotTz.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbCurrRobotTz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbCurrRobotTz.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCurrRobotTz.Depth = 0;
            this.tbCurrRobotTz.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.tbCurrRobotTz.HideSelection = true;
            this.tbCurrRobotTz.LeadingIcon = null;
            this.tbCurrRobotTz.Location = new System.Drawing.Point(236, 6);
            this.tbCurrRobotTz.MaxLength = 32767;
            this.tbCurrRobotTz.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCurrRobotTz.Name = "tbCurrRobotTz";
            this.tbCurrRobotTz.PasswordChar = '\0';
            this.tbCurrRobotTz.PrefixSuffixText = null;
            this.tbCurrRobotTz.ReadOnly = false;
            this.tbCurrRobotTz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCurrRobotTz.SelectedText = "";
            this.tbCurrRobotTz.SelectionLength = 0;
            this.tbCurrRobotTz.SelectionStart = 0;
            this.tbCurrRobotTz.ShortcutsEnabled = true;
            this.tbCurrRobotTz.Size = new System.Drawing.Size(139, 26);
            this.tbCurrRobotTz.TabIndex = 18;
            this.tbCurrRobotTz.TabStop = false;
            this.tbCurrRobotTz.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCurrRobotTz.TrailingIcon = null;
            this.tbCurrRobotTz.UseSystemPasswordChar = false;
            this.tbCurrRobotTz.UseTallSize = false;
            // 
            // tbCurrRobotRx
            // 
            this.tbCurrRobotRx.AnimateReadOnly = false;
            this.tbCurrRobotRx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbCurrRobotRx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbCurrRobotRx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbCurrRobotRx.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCurrRobotRx.Depth = 0;
            this.tbCurrRobotRx.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCurrRobotRx.HideSelection = true;
            this.tbCurrRobotRx.LeadingIcon = null;
            this.tbCurrRobotRx.Location = new System.Drawing.Point(231, 38);
            this.tbCurrRobotRx.MaxLength = 32767;
            this.tbCurrRobotRx.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCurrRobotRx.Name = "tbCurrRobotRx";
            this.tbCurrRobotRx.PasswordChar = '\0';
            this.tbCurrRobotRx.PrefixSuffixText = null;
            this.tbCurrRobotRx.ReadOnly = false;
            this.tbCurrRobotRx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCurrRobotRx.SelectedText = "";
            this.tbCurrRobotRx.SelectionLength = 0;
            this.tbCurrRobotRx.SelectionStart = 0;
            this.tbCurrRobotRx.ShortcutsEnabled = true;
            this.tbCurrRobotRx.Size = new System.Drawing.Size(139, 26);
            this.tbCurrRobotRx.TabIndex = 6;
            this.tbCurrRobotRx.TabStop = false;
            this.tbCurrRobotRx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCurrRobotRx.TrailingIcon = null;
            this.tbCurrRobotRx.UseSystemPasswordChar = false;
            this.tbCurrRobotRx.UseTallSize = false;
            // 
            // tbScanPoseRx_
            // 
            this.tbScanPoseRx_.AnimateReadOnly = false;
            this.tbScanPoseRx_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbScanPoseRx_.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbScanPoseRx_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbScanPoseRx_.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbScanPoseRx_.Depth = 0;
            this.tbScanPoseRx_.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbScanPoseRx_.HideSelection = true;
            this.tbScanPoseRx_.LeadingIcon = null;
            this.tbScanPoseRx_.Location = new System.Drawing.Point(48, 202);
            this.tbScanPoseRx_.MaxLength = 32767;
            this.tbScanPoseRx_.MouseState = MaterialSkin.MouseState.OUT;
            this.tbScanPoseRx_.Name = "tbScanPoseRx_";
            this.tbScanPoseRx_.PasswordChar = '\0';
            this.tbScanPoseRx_.PrefixSuffixText = null;
            this.tbScanPoseRx_.ReadOnly = true;
            this.tbScanPoseRx_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbScanPoseRx_.SelectedText = "";
            this.tbScanPoseRx_.SelectionLength = 0;
            this.tbScanPoseRx_.SelectionStart = 0;
            this.tbScanPoseRx_.ShortcutsEnabled = true;
            this.tbScanPoseRx_.Size = new System.Drawing.Size(139, 26);
            this.tbScanPoseRx_.TabIndex = 6;
            this.tbScanPoseRx_.TabStop = false;
            this.tbScanPoseRx_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbScanPoseRx_.TrailingIcon = null;
            this.tbScanPoseRx_.UseSystemPasswordChar = false;
            this.tbScanPoseRx_.UseTallSize = false;
            // 
            // tbScanPoseTx_
            // 
            this.tbScanPoseTx_.AnimateReadOnly = false;
            this.tbScanPoseTx_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbScanPoseTx_.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbScanPoseTx_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbScanPoseTx_.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbScanPoseTx_.Depth = 0;
            this.tbScanPoseTx_.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbScanPoseTx_.HideSelection = true;
            this.tbScanPoseTx_.LeadingIcon = null;
            this.tbScanPoseTx_.Location = new System.Drawing.Point(48, 62);
            this.tbScanPoseTx_.MaxLength = 32767;
            this.tbScanPoseTx_.MouseState = MaterialSkin.MouseState.OUT;
            this.tbScanPoseTx_.Name = "tbScanPoseTx_";
            this.tbScanPoseTx_.PasswordChar = '\0';
            this.tbScanPoseTx_.PrefixSuffixText = null;
            this.tbScanPoseTx_.ReadOnly = true;
            this.tbScanPoseTx_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbScanPoseTx_.SelectedText = "";
            this.tbScanPoseTx_.SelectionLength = 0;
            this.tbScanPoseTx_.SelectionStart = 0;
            this.tbScanPoseTx_.ShortcutsEnabled = true;
            this.tbScanPoseTx_.Size = new System.Drawing.Size(139, 26);
            this.tbScanPoseTx_.TabIndex = 6;
            this.tbScanPoseTx_.TabStop = false;
            this.tbScanPoseTx_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbScanPoseTx_.TrailingIcon = null;
            this.tbScanPoseTx_.UseSystemPasswordChar = false;
            this.tbScanPoseTx_.UseTallSize = false;
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel18.Location = new System.Drawing.Point(14, 36);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(79, 18);
            this.materialLabel18.TabIndex = 7;
            this.materialLabel18.Text = "Scan Pose";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.Location = new System.Drawing.Point(11, 11);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(128, 18);
            this.materialLabel14.TabIndex = 7;
            this.materialLabel14.Text = "ROBOT -> VISION";
            // 
            // materialLabel23
            // 
            this.materialLabel23.AutoSize = true;
            this.materialLabel23.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel23.Depth = 0;
            this.materialLabel23.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel23.Location = new System.Drawing.Point(17, 206);
            this.materialLabel23.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel23.Name = "materialLabel23";
            this.materialLabel23.Size = new System.Drawing.Size(19, 18);
            this.materialLabel23.TabIndex = 7;
            this.materialLabel23.Text = "Rx";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(17, 66);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(18, 18);
            this.materialLabel10.TabIndex = 7;
            this.materialLabel10.Text = "Tx";
            // 
            // materialLabel22
            // 
            this.materialLabel22.AutoSize = true;
            this.materialLabel22.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel22.Depth = 0;
            this.materialLabel22.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel22.Location = new System.Drawing.Point(17, 234);
            this.materialLabel22.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel22.Name = "materialLabel22";
            this.materialLabel22.Size = new System.Drawing.Size(20, 18);
            this.materialLabel22.TabIndex = 8;
            this.materialLabel22.Text = "Ry";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(17, 94);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(19, 18);
            this.materialLabel12.TabIndex = 8;
            this.materialLabel12.Text = "Ty";
            // 
            // tbScanPoseRy_
            // 
            this.tbScanPoseRy_.AnimateReadOnly = false;
            this.tbScanPoseRy_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbScanPoseRy_.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbScanPoseRy_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbScanPoseRy_.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbScanPoseRy_.Depth = 0;
            this.tbScanPoseRy_.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbScanPoseRy_.HideSelection = true;
            this.tbScanPoseRy_.LeadingIcon = null;
            this.tbScanPoseRy_.Location = new System.Drawing.Point(48, 230);
            this.tbScanPoseRy_.MaxLength = 32767;
            this.tbScanPoseRy_.MouseState = MaterialSkin.MouseState.OUT;
            this.tbScanPoseRy_.Name = "tbScanPoseRy_";
            this.tbScanPoseRy_.PasswordChar = '\0';
            this.tbScanPoseRy_.PrefixSuffixText = null;
            this.tbScanPoseRy_.ReadOnly = true;
            this.tbScanPoseRy_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbScanPoseRy_.SelectedText = "";
            this.tbScanPoseRy_.SelectionLength = 0;
            this.tbScanPoseRy_.SelectionStart = 0;
            this.tbScanPoseRy_.ShortcutsEnabled = true;
            this.tbScanPoseRy_.Size = new System.Drawing.Size(139, 26);
            this.tbScanPoseRy_.TabIndex = 13;
            this.tbScanPoseRy_.TabStop = false;
            this.tbScanPoseRy_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbScanPoseRy_.TrailingIcon = null;
            this.tbScanPoseRy_.UseSystemPasswordChar = false;
            this.tbScanPoseRy_.UseTallSize = false;
            // 
            // tbScanPoseTy_
            // 
            this.tbScanPoseTy_.AnimateReadOnly = false;
            this.tbScanPoseTy_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbScanPoseTy_.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbScanPoseTy_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbScanPoseTy_.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbScanPoseTy_.Depth = 0;
            this.tbScanPoseTy_.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbScanPoseTy_.HideSelection = true;
            this.tbScanPoseTy_.LeadingIcon = null;
            this.tbScanPoseTy_.Location = new System.Drawing.Point(48, 90);
            this.tbScanPoseTy_.MaxLength = 32767;
            this.tbScanPoseTy_.MouseState = MaterialSkin.MouseState.OUT;
            this.tbScanPoseTy_.Name = "tbScanPoseTy_";
            this.tbScanPoseTy_.PasswordChar = '\0';
            this.tbScanPoseTy_.PrefixSuffixText = null;
            this.tbScanPoseTy_.ReadOnly = true;
            this.tbScanPoseTy_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbScanPoseTy_.SelectedText = "";
            this.tbScanPoseTy_.SelectionLength = 0;
            this.tbScanPoseTy_.SelectionStart = 0;
            this.tbScanPoseTy_.ShortcutsEnabled = true;
            this.tbScanPoseTy_.Size = new System.Drawing.Size(139, 26);
            this.tbScanPoseTy_.TabIndex = 13;
            this.tbScanPoseTy_.TabStop = false;
            this.tbScanPoseTy_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbScanPoseTy_.TrailingIcon = null;
            this.tbScanPoseTy_.UseSystemPasswordChar = false;
            this.tbScanPoseTy_.UseTallSize = false;
            // 
            // gbRobotWrite
            // 
            this.gbRobotWrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbRobotWrite.Controls.Add(this.materialLabel17);
            this.gbRobotWrite.Controls.Add(this.materialLabel8);
            this.gbRobotWrite.Controls.Add(this.btnReadWrittenShiftPose_);
            this.gbRobotWrite.Controls.Add(this.btnWriteShiftPose_);
            this.gbRobotWrite.Controls.Add(this.tbWrittenRz_);
            this.gbRobotWrite.Controls.Add(this.tbShiftRzR1);
            this.gbRobotWrite.Controls.Add(this.tbWrittenTx_);
            this.gbRobotWrite.Controls.Add(this.tbShiftTxR1);
            this.gbRobotWrite.Controls.Add(this.materialLabel21);
            this.gbRobotWrite.Controls.Add(this.materialLabel26);
            this.gbRobotWrite.Controls.Add(this.materialLabel11);
            this.gbRobotWrite.Controls.Add(this.materialLabel20);
            this.gbRobotWrite.Controls.Add(this.materialLabel15);
            this.gbRobotWrite.Controls.Add(this.materialLabel25);
            this.gbRobotWrite.Controls.Add(this.tbWrittenTy_);
            this.gbRobotWrite.Controls.Add(this.materialLabel28);
            this.gbRobotWrite.Controls.Add(this.tbShiftTyR1);
            this.gbRobotWrite.Depth = 0;
            this.gbRobotWrite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbRobotWrite.Location = new System.Drawing.Point(890, 13);
            this.gbRobotWrite.Margin = new System.Windows.Forms.Padding(14);
            this.gbRobotWrite.MouseState = MaterialSkin.MouseState.HOVER;
            this.gbRobotWrite.Name = "gbRobotWrite";
            this.gbRobotWrite.Padding = new System.Windows.Forms.Padding(14);
            this.gbRobotWrite.Size = new System.Drawing.Size(198, 354);
            this.gbRobotWrite.TabIndex = 179;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(15, 125);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(19, 18);
            this.materialLabel8.TabIndex = 17;
            this.materialLabel8.Text = "Rz";
            // 
            // btnWriteShiftPose_
            // 
            this.btnWriteShiftPose_.AutoSize = false;
            this.btnWriteShiftPose_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWriteShiftPose_.BackColor = System.Drawing.Color.DimGray;
            this.btnWriteShiftPose_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnWriteShiftPose_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnWriteShiftPose_.Depth = 0;
            this.btnWriteShiftPose_.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnWriteShiftPose_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWriteShiftPose_.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnWriteShiftPose_.HighEmphasis = true;
            this.btnWriteShiftPose_.Icon = null;
            this.btnWriteShiftPose_.Location = new System.Drawing.Point(101, 32);
            this.btnWriteShiftPose_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnWriteShiftPose_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnWriteShiftPose_.Name = "btnWriteShiftPose_";
            this.btnWriteShiftPose_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnWriteShiftPose_.Size = new System.Drawing.Size(82, 20);
            this.btnWriteShiftPose_.TabIndex = 179;
            this.btnWriteShiftPose_.Text = "WRITE";
            this.btnWriteShiftPose_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnWriteShiftPose_.UseAccentColor = false;
            this.btnWriteShiftPose_.UseVisualStyleBackColor = false;
            // 
            // tbShiftRzR1
            // 
            this.tbShiftRzR1.AnimateReadOnly = false;
            this.tbShiftRzR1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbShiftRzR1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbShiftRzR1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbShiftRzR1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbShiftRzR1.Depth = 0;
            this.tbShiftRzR1.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.tbShiftRzR1.HideSelection = true;
            this.tbShiftRzR1.LeadingIcon = null;
            this.tbShiftRzR1.Location = new System.Drawing.Point(44, 122);
            this.tbShiftRzR1.MaxLength = 32767;
            this.tbShiftRzR1.MouseState = MaterialSkin.MouseState.OUT;
            this.tbShiftRzR1.Name = "tbShiftRzR1";
            this.tbShiftRzR1.PasswordChar = '\0';
            this.tbShiftRzR1.PrefixSuffixText = null;
            this.tbShiftRzR1.ReadOnly = false;
            this.tbShiftRzR1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbShiftRzR1.SelectedText = "";
            this.tbShiftRzR1.SelectionLength = 0;
            this.tbShiftRzR1.SelectionStart = 0;
            this.tbShiftRzR1.ShortcutsEnabled = true;
            this.tbShiftRzR1.Size = new System.Drawing.Size(142, 26);
            this.tbShiftRzR1.TabIndex = 18;
            this.tbShiftRzR1.TabStop = false;
            this.tbShiftRzR1.Text = "3";
            this.tbShiftRzR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbShiftRzR1.TrailingIcon = null;
            this.tbShiftRzR1.UseSystemPasswordChar = false;
            this.tbShiftRzR1.UseTallSize = false;
            // 
            // tbShiftTxR1
            // 
            this.tbShiftTxR1.AnimateReadOnly = false;
            this.tbShiftTxR1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbShiftTxR1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbShiftTxR1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbShiftTxR1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbShiftTxR1.Depth = 0;
            this.tbShiftTxR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbShiftTxR1.HideSelection = true;
            this.tbShiftTxR1.LeadingIcon = null;
            this.tbShiftTxR1.Location = new System.Drawing.Point(44, 68);
            this.tbShiftTxR1.MaxLength = 32767;
            this.tbShiftTxR1.MouseState = MaterialSkin.MouseState.OUT;
            this.tbShiftTxR1.Name = "tbShiftTxR1";
            this.tbShiftTxR1.PasswordChar = '\0';
            this.tbShiftTxR1.PrefixSuffixText = null;
            this.tbShiftTxR1.ReadOnly = false;
            this.tbShiftTxR1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbShiftTxR1.SelectedText = "";
            this.tbShiftTxR1.SelectionLength = 0;
            this.tbShiftTxR1.SelectionStart = 0;
            this.tbShiftTxR1.ShortcutsEnabled = true;
            this.tbShiftTxR1.Size = new System.Drawing.Size(141, 26);
            this.tbShiftTxR1.TabIndex = 6;
            this.tbShiftTxR1.TabStop = false;
            this.tbShiftTxR1.Text = "1";
            this.tbShiftTxR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbShiftTxR1.TrailingIcon = null;
            this.tbShiftTxR1.UseSystemPasswordChar = false;
            this.tbShiftTxR1.UseTallSize = false;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(15, 72);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(18, 18);
            this.materialLabel11.TabIndex = 7;
            this.materialLabel11.Text = "Tx";
            // 
            // materialLabel20
            // 
            this.materialLabel20.AutoSize = true;
            this.materialLabel20.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel20.Depth = 0;
            this.materialLabel20.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel20.Location = new System.Drawing.Point(13, 36);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Size = new System.Drawing.Size(78, 18);
            this.materialLabel20.TabIndex = 7;
            this.materialLabel20.Text = "Shift Pose";
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel15.Location = new System.Drawing.Point(10, 11);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(128, 18);
            this.materialLabel15.TabIndex = 7;
            this.materialLabel15.Text = "VISION -> ROBOT";
            // 
            // materialLabel28
            // 
            this.materialLabel28.AutoSize = true;
            this.materialLabel28.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel28.Depth = 0;
            this.materialLabel28.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel28.Location = new System.Drawing.Point(15, 100);
            this.materialLabel28.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel28.Name = "materialLabel28";
            this.materialLabel28.Size = new System.Drawing.Size(19, 18);
            this.materialLabel28.TabIndex = 8;
            this.materialLabel28.Text = "Ty";
            // 
            // tbShiftTyR1
            // 
            this.tbShiftTyR1.AnimateReadOnly = false;
            this.tbShiftTyR1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbShiftTyR1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbShiftTyR1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbShiftTyR1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbShiftTyR1.Depth = 0;
            this.tbShiftTyR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbShiftTyR1.HideSelection = true;
            this.tbShiftTyR1.LeadingIcon = null;
            this.tbShiftTyR1.Location = new System.Drawing.Point(44, 96);
            this.tbShiftTyR1.MaxLength = 32767;
            this.tbShiftTyR1.MouseState = MaterialSkin.MouseState.OUT;
            this.tbShiftTyR1.Name = "tbShiftTyR1";
            this.tbShiftTyR1.PasswordChar = '\0';
            this.tbShiftTyR1.PrefixSuffixText = null;
            this.tbShiftTyR1.ReadOnly = false;
            this.tbShiftTyR1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbShiftTyR1.SelectedText = "";
            this.tbShiftTyR1.SelectionLength = 0;
            this.tbShiftTyR1.SelectionStart = 0;
            this.tbShiftTyR1.ShortcutsEnabled = true;
            this.tbShiftTyR1.Size = new System.Drawing.Size(141, 26);
            this.tbShiftTyR1.TabIndex = 13;
            this.tbShiftTyR1.TabStop = false;
            this.tbShiftTyR1.Text = "2";
            this.tbShiftTyR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbShiftTyR1.TrailingIcon = null;
            this.tbShiftTyR1.UseSystemPasswordChar = false;
            this.tbShiftTyR1.UseTallSize = false;
            // 
            // tbWrittenTx_
            // 
            this.tbWrittenTx_.AnimateReadOnly = false;
            this.tbWrittenTx_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbWrittenTx_.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbWrittenTx_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbWrittenTx_.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbWrittenTx_.Depth = 0;
            this.tbWrittenTx_.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbWrittenTx_.HideSelection = true;
            this.tbWrittenTx_.LeadingIcon = null;
            this.tbWrittenTx_.Location = new System.Drawing.Point(42, 255);
            this.tbWrittenTx_.MaxLength = 32767;
            this.tbWrittenTx_.MouseState = MaterialSkin.MouseState.OUT;
            this.tbWrittenTx_.Name = "tbWrittenTx_";
            this.tbWrittenTx_.PasswordChar = '\0';
            this.tbWrittenTx_.PrefixSuffixText = null;
            this.tbWrittenTx_.ReadOnly = false;
            this.tbWrittenTx_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbWrittenTx_.SelectedText = "";
            this.tbWrittenTx_.SelectionLength = 0;
            this.tbWrittenTx_.SelectionStart = 0;
            this.tbWrittenTx_.ShortcutsEnabled = true;
            this.tbWrittenTx_.Size = new System.Drawing.Size(141, 26);
            this.tbWrittenTx_.TabIndex = 6;
            this.tbWrittenTx_.TabStop = false;
            this.tbWrittenTx_.Text = "1";
            this.tbWrittenTx_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbWrittenTx_.TrailingIcon = null;
            this.tbWrittenTx_.UseSystemPasswordChar = false;
            this.tbWrittenTx_.UseTallSize = false;
            // 
            // tbWrittenTy_
            // 
            this.tbWrittenTy_.AnimateReadOnly = false;
            this.tbWrittenTy_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbWrittenTy_.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbWrittenTy_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbWrittenTy_.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbWrittenTy_.Depth = 0;
            this.tbWrittenTy_.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbWrittenTy_.HideSelection = true;
            this.tbWrittenTy_.LeadingIcon = null;
            this.tbWrittenTy_.Location = new System.Drawing.Point(42, 283);
            this.tbWrittenTy_.MaxLength = 32767;
            this.tbWrittenTy_.MouseState = MaterialSkin.MouseState.OUT;
            this.tbWrittenTy_.Name = "tbWrittenTy_";
            this.tbWrittenTy_.PasswordChar = '\0';
            this.tbWrittenTy_.PrefixSuffixText = null;
            this.tbWrittenTy_.ReadOnly = false;
            this.tbWrittenTy_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbWrittenTy_.SelectedText = "";
            this.tbWrittenTy_.SelectionLength = 0;
            this.tbWrittenTy_.SelectionStart = 0;
            this.tbWrittenTy_.ShortcutsEnabled = true;
            this.tbWrittenTy_.Size = new System.Drawing.Size(141, 26);
            this.tbWrittenTy_.TabIndex = 13;
            this.tbWrittenTy_.TabStop = false;
            this.tbWrittenTy_.Text = "2";
            this.tbWrittenTy_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbWrittenTy_.TrailingIcon = null;
            this.tbWrittenTy_.UseSystemPasswordChar = false;
            this.tbWrittenTy_.UseTallSize = false;
            // 
            // tbWrittenRz_
            // 
            this.tbWrittenRz_.AnimateReadOnly = false;
            this.tbWrittenRz_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbWrittenRz_.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbWrittenRz_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbWrittenRz_.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbWrittenRz_.Depth = 0;
            this.tbWrittenRz_.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.tbWrittenRz_.HideSelection = true;
            this.tbWrittenRz_.LeadingIcon = null;
            this.tbWrittenRz_.Location = new System.Drawing.Point(41, 311);
            this.tbWrittenRz_.MaxLength = 32767;
            this.tbWrittenRz_.MouseState = MaterialSkin.MouseState.OUT;
            this.tbWrittenRz_.Name = "tbWrittenRz_";
            this.tbWrittenRz_.PasswordChar = '\0';
            this.tbWrittenRz_.PrefixSuffixText = null;
            this.tbWrittenRz_.ReadOnly = false;
            this.tbWrittenRz_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbWrittenRz_.SelectedText = "";
            this.tbWrittenRz_.SelectionLength = 0;
            this.tbWrittenRz_.SelectionStart = 0;
            this.tbWrittenRz_.ShortcutsEnabled = true;
            this.tbWrittenRz_.Size = new System.Drawing.Size(142, 26);
            this.tbWrittenRz_.TabIndex = 18;
            this.tbWrittenRz_.TabStop = false;
            this.tbWrittenRz_.Text = "3";
            this.tbWrittenRz_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbWrittenRz_.TrailingIcon = null;
            this.tbWrittenRz_.UseSystemPasswordChar = false;
            this.tbWrittenRz_.UseTallSize = false;
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel17.Location = new System.Drawing.Point(13, 315);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(19, 18);
            this.materialLabel17.TabIndex = 17;
            this.materialLabel17.Text = "Rz";
            // 
            // materialLabel25
            // 
            this.materialLabel25.AutoSize = true;
            this.materialLabel25.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel25.Depth = 0;
            this.materialLabel25.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel25.Location = new System.Drawing.Point(13, 287);
            this.materialLabel25.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel25.Name = "materialLabel25";
            this.materialLabel25.Size = new System.Drawing.Size(19, 18);
            this.materialLabel25.TabIndex = 8;
            this.materialLabel25.Text = "Ty";
            // 
            // materialLabel26
            // 
            this.materialLabel26.AutoSize = true;
            this.materialLabel26.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel26.Depth = 0;
            this.materialLabel26.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel26.Location = new System.Drawing.Point(13, 259);
            this.materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel26.Name = "materialLabel26";
            this.materialLabel26.Size = new System.Drawing.Size(18, 18);
            this.materialLabel26.TabIndex = 7;
            this.materialLabel26.Text = "Tx";
            // 
            // btnReadWrittenShiftPose_
            // 
            this.btnReadWrittenShiftPose_.AutoSize = false;
            this.btnReadWrittenShiftPose_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReadWrittenShiftPose_.BackColor = System.Drawing.Color.DimGray;
            this.btnReadWrittenShiftPose_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnReadWrittenShiftPose_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReadWrittenShiftPose_.Depth = 0;
            this.btnReadWrittenShiftPose_.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnReadWrittenShiftPose_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadWrittenShiftPose_.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnReadWrittenShiftPose_.HighEmphasis = true;
            this.btnReadWrittenShiftPose_.Icon = null;
            this.btnReadWrittenShiftPose_.Location = new System.Drawing.Point(12, 217);
            this.btnReadWrittenShiftPose_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReadWrittenShiftPose_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReadWrittenShiftPose_.Name = "btnReadWrittenShiftPose_";
            this.btnReadWrittenShiftPose_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReadWrittenShiftPose_.Size = new System.Drawing.Size(168, 26);
            this.btnReadWrittenShiftPose_.TabIndex = 179;
            this.btnReadWrittenShiftPose_.Text = "READ";
            this.btnReadWrittenShiftPose_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReadWrittenShiftPose_.UseAccentColor = false;
            this.btnReadWrittenShiftPose_.UseVisualStyleBackColor = false;
            // 
            // materialLabel21
            // 
            this.materialLabel21.AutoSize = true;
            this.materialLabel21.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel21.Depth = 0;
            this.materialLabel21.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel21.Location = new System.Drawing.Point(13, 193);
            this.materialLabel21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel21.Name = "materialLabel21";
            this.materialLabel21.Size = new System.Drawing.Size(101, 18);
            this.materialLabel21.TabIndex = 7;
            this.materialLabel21.Text = "Read Written";
            // 
            // materialCard7
            // 
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.materialLabel31);
            this.materialCard7.Controls.Add(this.materialLabel16);
            this.materialCard7.Controls.Add(this.materialLabel27);
            this.materialCard7.Controls.Add(this.materialLabel29);
            this.materialCard7.Controls.Add(this.tbInstallPoseRz_);
            this.materialCard7.Controls.Add(this.tbInstallPoseTz_);
            this.materialCard7.Controls.Add(this.btnReadInstallPose_);
            this.materialCard7.Controls.Add(this.materialTextBox29);
            this.materialCard7.Controls.Add(this.materialTextBox210);
            this.materialCard7.Controls.Add(this.tbInstallPoseRx_);
            this.materialCard7.Controls.Add(this.tbInstallPoseTx_);
            this.materialCard7.Controls.Add(this.materialLabel32);
            this.materialCard7.Controls.Add(this.materialLabel33);
            this.materialCard7.Controls.Add(this.materialLabel34);
            this.materialCard7.Controls.Add(this.materialLabel35);
            this.materialCard7.Controls.Add(this.materialLabel36);
            this.materialCard7.Controls.Add(this.tbInstallPoseRy_);
            this.materialCard7.Controls.Add(this.tbInstallPoseTy_);
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(485, 14);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(198, 354);
            this.materialCard7.TabIndex = 179;
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.Location = new System.Drawing.Point(17, 262);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(19, 18);
            this.materialLabel16.TabIndex = 17;
            this.materialLabel16.Text = "Rz";
            // 
            // materialLabel27
            // 
            this.materialLabel27.AutoSize = true;
            this.materialLabel27.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel27.Depth = 0;
            this.materialLabel27.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel27.Location = new System.Drawing.Point(17, 122);
            this.materialLabel27.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel27.Name = "materialLabel27";
            this.materialLabel27.Size = new System.Drawing.Size(18, 18);
            this.materialLabel27.TabIndex = 17;
            this.materialLabel27.Text = "Tz";
            // 
            // materialLabel29
            // 
            this.materialLabel29.AutoSize = true;
            this.materialLabel29.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel29.Depth = 0;
            this.materialLabel29.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel29.Location = new System.Drawing.Point(207, 10);
            this.materialLabel29.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel29.Name = "materialLabel29";
            this.materialLabel29.Size = new System.Drawing.Size(18, 18);
            this.materialLabel29.TabIndex = 17;
            this.materialLabel29.Text = "Tz";
            // 
            // tbInstallPoseRz_
            // 
            this.tbInstallPoseRz_.AnimateReadOnly = false;
            this.tbInstallPoseRz_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbInstallPoseRz_.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbInstallPoseRz_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbInstallPoseRz_.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbInstallPoseRz_.Depth = 0;
            this.tbInstallPoseRz_.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.tbInstallPoseRz_.HideSelection = true;
            this.tbInstallPoseRz_.LeadingIcon = null;
            this.tbInstallPoseRz_.Location = new System.Drawing.Point(48, 258);
            this.tbInstallPoseRz_.MaxLength = 32767;
            this.tbInstallPoseRz_.MouseState = MaterialSkin.MouseState.OUT;
            this.tbInstallPoseRz_.Name = "tbInstallPoseRz_";
            this.tbInstallPoseRz_.PasswordChar = '\0';
            this.tbInstallPoseRz_.PrefixSuffixText = null;
            this.tbInstallPoseRz_.ReadOnly = true;
            this.tbInstallPoseRz_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbInstallPoseRz_.SelectedText = "";
            this.tbInstallPoseRz_.SelectionLength = 0;
            this.tbInstallPoseRz_.SelectionStart = 0;
            this.tbInstallPoseRz_.ShortcutsEnabled = true;
            this.tbInstallPoseRz_.Size = new System.Drawing.Size(139, 26);
            this.tbInstallPoseRz_.TabIndex = 18;
            this.tbInstallPoseRz_.TabStop = false;
            this.tbInstallPoseRz_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbInstallPoseRz_.TrailingIcon = null;
            this.tbInstallPoseRz_.UseSystemPasswordChar = false;
            this.tbInstallPoseRz_.UseTallSize = false;
            // 
            // tbInstallPoseTz_
            // 
            this.tbInstallPoseTz_.AnimateReadOnly = false;
            this.tbInstallPoseTz_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbInstallPoseTz_.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbInstallPoseTz_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbInstallPoseTz_.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbInstallPoseTz_.Depth = 0;
            this.tbInstallPoseTz_.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.tbInstallPoseTz_.HideSelection = true;
            this.tbInstallPoseTz_.LeadingIcon = null;
            this.tbInstallPoseTz_.Location = new System.Drawing.Point(48, 118);
            this.tbInstallPoseTz_.MaxLength = 32767;
            this.tbInstallPoseTz_.MouseState = MaterialSkin.MouseState.OUT;
            this.tbInstallPoseTz_.Name = "tbInstallPoseTz_";
            this.tbInstallPoseTz_.PasswordChar = '\0';
            this.tbInstallPoseTz_.PrefixSuffixText = null;
            this.tbInstallPoseTz_.ReadOnly = true;
            this.tbInstallPoseTz_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbInstallPoseTz_.SelectedText = "";
            this.tbInstallPoseTz_.SelectionLength = 0;
            this.tbInstallPoseTz_.SelectionStart = 0;
            this.tbInstallPoseTz_.ShortcutsEnabled = true;
            this.tbInstallPoseTz_.Size = new System.Drawing.Size(139, 26);
            this.tbInstallPoseTz_.TabIndex = 18;
            this.tbInstallPoseTz_.TabStop = false;
            this.tbInstallPoseTz_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbInstallPoseTz_.TrailingIcon = null;
            this.tbInstallPoseTz_.UseSystemPasswordChar = false;
            this.tbInstallPoseTz_.UseTallSize = false;
            // 
            // btnReadInstallPose_
            // 
            this.btnReadInstallPose_.AutoSize = false;
            this.btnReadInstallPose_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReadInstallPose_.BackColor = System.Drawing.Color.DimGray;
            this.btnReadInstallPose_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnReadInstallPose_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReadInstallPose_.Depth = 0;
            this.btnReadInstallPose_.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnReadInstallPose_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadInstallPose_.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnReadInstallPose_.HighEmphasis = true;
            this.btnReadInstallPose_.Icon = null;
            this.btnReadInstallPose_.Location = new System.Drawing.Point(110, 33);
            this.btnReadInstallPose_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReadInstallPose_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReadInstallPose_.Name = "btnReadInstallPose_";
            this.btnReadInstallPose_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReadInstallPose_.Size = new System.Drawing.Size(77, 21);
            this.btnReadInstallPose_.TabIndex = 178;
            this.btnReadInstallPose_.Text = "READ";
            this.btnReadInstallPose_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReadInstallPose_.UseAccentColor = false;
            this.btnReadInstallPose_.UseVisualStyleBackColor = false;
            // 
            // materialTextBox29
            // 
            this.materialTextBox29.AnimateReadOnly = false;
            this.materialTextBox29.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.materialTextBox29.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.materialTextBox29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox29.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox29.Depth = 0;
            this.materialTextBox29.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.materialTextBox29.HideSelection = true;
            this.materialTextBox29.LeadingIcon = null;
            this.materialTextBox29.Location = new System.Drawing.Point(236, 6);
            this.materialTextBox29.MaxLength = 32767;
            this.materialTextBox29.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox29.Name = "materialTextBox29";
            this.materialTextBox29.PasswordChar = '\0';
            this.materialTextBox29.PrefixSuffixText = null;
            this.materialTextBox29.ReadOnly = false;
            this.materialTextBox29.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox29.SelectedText = "";
            this.materialTextBox29.SelectionLength = 0;
            this.materialTextBox29.SelectionStart = 0;
            this.materialTextBox29.ShortcutsEnabled = true;
            this.materialTextBox29.Size = new System.Drawing.Size(139, 26);
            this.materialTextBox29.TabIndex = 18;
            this.materialTextBox29.TabStop = false;
            this.materialTextBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox29.TrailingIcon = null;
            this.materialTextBox29.UseSystemPasswordChar = false;
            this.materialTextBox29.UseTallSize = false;
            // 
            // materialTextBox210
            // 
            this.materialTextBox210.AnimateReadOnly = false;
            this.materialTextBox210.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.materialTextBox210.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.materialTextBox210.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox210.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox210.Depth = 0;
            this.materialTextBox210.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox210.HideSelection = true;
            this.materialTextBox210.LeadingIcon = null;
            this.materialTextBox210.Location = new System.Drawing.Point(231, 38);
            this.materialTextBox210.MaxLength = 32767;
            this.materialTextBox210.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox210.Name = "materialTextBox210";
            this.materialTextBox210.PasswordChar = '\0';
            this.materialTextBox210.PrefixSuffixText = null;
            this.materialTextBox210.ReadOnly = false;
            this.materialTextBox210.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox210.SelectedText = "";
            this.materialTextBox210.SelectionLength = 0;
            this.materialTextBox210.SelectionStart = 0;
            this.materialTextBox210.ShortcutsEnabled = true;
            this.materialTextBox210.Size = new System.Drawing.Size(139, 26);
            this.materialTextBox210.TabIndex = 6;
            this.materialTextBox210.TabStop = false;
            this.materialTextBox210.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox210.TrailingIcon = null;
            this.materialTextBox210.UseSystemPasswordChar = false;
            this.materialTextBox210.UseTallSize = false;
            // 
            // tbInstallPoseRx_
            // 
            this.tbInstallPoseRx_.AnimateReadOnly = false;
            this.tbInstallPoseRx_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbInstallPoseRx_.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbInstallPoseRx_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbInstallPoseRx_.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbInstallPoseRx_.Depth = 0;
            this.tbInstallPoseRx_.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbInstallPoseRx_.HideSelection = true;
            this.tbInstallPoseRx_.LeadingIcon = null;
            this.tbInstallPoseRx_.Location = new System.Drawing.Point(48, 202);
            this.tbInstallPoseRx_.MaxLength = 32767;
            this.tbInstallPoseRx_.MouseState = MaterialSkin.MouseState.OUT;
            this.tbInstallPoseRx_.Name = "tbInstallPoseRx_";
            this.tbInstallPoseRx_.PasswordChar = '\0';
            this.tbInstallPoseRx_.PrefixSuffixText = null;
            this.tbInstallPoseRx_.ReadOnly = true;
            this.tbInstallPoseRx_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbInstallPoseRx_.SelectedText = "";
            this.tbInstallPoseRx_.SelectionLength = 0;
            this.tbInstallPoseRx_.SelectionStart = 0;
            this.tbInstallPoseRx_.ShortcutsEnabled = true;
            this.tbInstallPoseRx_.Size = new System.Drawing.Size(139, 26);
            this.tbInstallPoseRx_.TabIndex = 6;
            this.tbInstallPoseRx_.TabStop = false;
            this.tbInstallPoseRx_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbInstallPoseRx_.TrailingIcon = null;
            this.tbInstallPoseRx_.UseSystemPasswordChar = false;
            this.tbInstallPoseRx_.UseTallSize = false;
            // 
            // tbInstallPoseTx_
            // 
            this.tbInstallPoseTx_.AnimateReadOnly = false;
            this.tbInstallPoseTx_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbInstallPoseTx_.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbInstallPoseTx_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbInstallPoseTx_.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbInstallPoseTx_.Depth = 0;
            this.tbInstallPoseTx_.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbInstallPoseTx_.HideSelection = true;
            this.tbInstallPoseTx_.LeadingIcon = null;
            this.tbInstallPoseTx_.Location = new System.Drawing.Point(48, 62);
            this.tbInstallPoseTx_.MaxLength = 32767;
            this.tbInstallPoseTx_.MouseState = MaterialSkin.MouseState.OUT;
            this.tbInstallPoseTx_.Name = "tbInstallPoseTx_";
            this.tbInstallPoseTx_.PasswordChar = '\0';
            this.tbInstallPoseTx_.PrefixSuffixText = null;
            this.tbInstallPoseTx_.ReadOnly = true;
            this.tbInstallPoseTx_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbInstallPoseTx_.SelectedText = "";
            this.tbInstallPoseTx_.SelectionLength = 0;
            this.tbInstallPoseTx_.SelectionStart = 0;
            this.tbInstallPoseTx_.ShortcutsEnabled = true;
            this.tbInstallPoseTx_.Size = new System.Drawing.Size(139, 26);
            this.tbInstallPoseTx_.TabIndex = 6;
            this.tbInstallPoseTx_.TabStop = false;
            this.tbInstallPoseTx_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbInstallPoseTx_.TrailingIcon = null;
            this.tbInstallPoseTx_.UseSystemPasswordChar = false;
            this.tbInstallPoseTx_.UseTallSize = false;
            // 
            // materialLabel32
            // 
            this.materialLabel32.AutoSize = true;
            this.materialLabel32.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel32.Depth = 0;
            this.materialLabel32.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel32.Location = new System.Drawing.Point(11, 11);
            this.materialLabel32.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel32.Name = "materialLabel32";
            this.materialLabel32.Size = new System.Drawing.Size(128, 18);
            this.materialLabel32.TabIndex = 7;
            this.materialLabel32.Text = "ROBOT -> VISION";
            // 
            // materialLabel33
            // 
            this.materialLabel33.AutoSize = true;
            this.materialLabel33.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel33.Depth = 0;
            this.materialLabel33.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel33.Location = new System.Drawing.Point(17, 206);
            this.materialLabel33.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel33.Name = "materialLabel33";
            this.materialLabel33.Size = new System.Drawing.Size(19, 18);
            this.materialLabel33.TabIndex = 7;
            this.materialLabel33.Text = "Rx";
            // 
            // materialLabel34
            // 
            this.materialLabel34.AutoSize = true;
            this.materialLabel34.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel34.Depth = 0;
            this.materialLabel34.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel34.Location = new System.Drawing.Point(17, 66);
            this.materialLabel34.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel34.Name = "materialLabel34";
            this.materialLabel34.Size = new System.Drawing.Size(18, 18);
            this.materialLabel34.TabIndex = 7;
            this.materialLabel34.Text = "Tx";
            // 
            // materialLabel35
            // 
            this.materialLabel35.AutoSize = true;
            this.materialLabel35.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel35.Depth = 0;
            this.materialLabel35.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel35.Location = new System.Drawing.Point(17, 234);
            this.materialLabel35.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel35.Name = "materialLabel35";
            this.materialLabel35.Size = new System.Drawing.Size(20, 18);
            this.materialLabel35.TabIndex = 8;
            this.materialLabel35.Text = "Ry";
            // 
            // materialLabel36
            // 
            this.materialLabel36.AutoSize = true;
            this.materialLabel36.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel36.Depth = 0;
            this.materialLabel36.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel36.Location = new System.Drawing.Point(17, 94);
            this.materialLabel36.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel36.Name = "materialLabel36";
            this.materialLabel36.Size = new System.Drawing.Size(19, 18);
            this.materialLabel36.TabIndex = 8;
            this.materialLabel36.Text = "Ty";
            // 
            // tbInstallPoseRy_
            // 
            this.tbInstallPoseRy_.AnimateReadOnly = false;
            this.tbInstallPoseRy_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbInstallPoseRy_.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbInstallPoseRy_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbInstallPoseRy_.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbInstallPoseRy_.Depth = 0;
            this.tbInstallPoseRy_.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbInstallPoseRy_.HideSelection = true;
            this.tbInstallPoseRy_.LeadingIcon = null;
            this.tbInstallPoseRy_.Location = new System.Drawing.Point(48, 230);
            this.tbInstallPoseRy_.MaxLength = 32767;
            this.tbInstallPoseRy_.MouseState = MaterialSkin.MouseState.OUT;
            this.tbInstallPoseRy_.Name = "tbInstallPoseRy_";
            this.tbInstallPoseRy_.PasswordChar = '\0';
            this.tbInstallPoseRy_.PrefixSuffixText = null;
            this.tbInstallPoseRy_.ReadOnly = true;
            this.tbInstallPoseRy_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbInstallPoseRy_.SelectedText = "";
            this.tbInstallPoseRy_.SelectionLength = 0;
            this.tbInstallPoseRy_.SelectionStart = 0;
            this.tbInstallPoseRy_.ShortcutsEnabled = true;
            this.tbInstallPoseRy_.Size = new System.Drawing.Size(139, 26);
            this.tbInstallPoseRy_.TabIndex = 13;
            this.tbInstallPoseRy_.TabStop = false;
            this.tbInstallPoseRy_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbInstallPoseRy_.TrailingIcon = null;
            this.tbInstallPoseRy_.UseSystemPasswordChar = false;
            this.tbInstallPoseRy_.UseTallSize = false;
            // 
            // tbInstallPoseTy_
            // 
            this.tbInstallPoseTy_.AnimateReadOnly = false;
            this.tbInstallPoseTy_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbInstallPoseTy_.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbInstallPoseTy_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbInstallPoseTy_.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbInstallPoseTy_.Depth = 0;
            this.tbInstallPoseTy_.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbInstallPoseTy_.HideSelection = true;
            this.tbInstallPoseTy_.LeadingIcon = null;
            this.tbInstallPoseTy_.Location = new System.Drawing.Point(48, 90);
            this.tbInstallPoseTy_.MaxLength = 32767;
            this.tbInstallPoseTy_.MouseState = MaterialSkin.MouseState.OUT;
            this.tbInstallPoseTy_.Name = "tbInstallPoseTy_";
            this.tbInstallPoseTy_.PasswordChar = '\0';
            this.tbInstallPoseTy_.PrefixSuffixText = null;
            this.tbInstallPoseTy_.ReadOnly = true;
            this.tbInstallPoseTy_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbInstallPoseTy_.SelectedText = "";
            this.tbInstallPoseTy_.SelectionLength = 0;
            this.tbInstallPoseTy_.SelectionStart = 0;
            this.tbInstallPoseTy_.ShortcutsEnabled = true;
            this.tbInstallPoseTy_.Size = new System.Drawing.Size(139, 26);
            this.tbInstallPoseTy_.TabIndex = 13;
            this.tbInstallPoseTy_.TabStop = false;
            this.tbInstallPoseTy_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbInstallPoseTy_.TrailingIcon = null;
            this.tbInstallPoseTy_.UseSystemPasswordChar = false;
            this.tbInstallPoseTy_.UseTallSize = false;
            // 
            // materialLabel31
            // 
            this.materialLabel31.AutoSize = true;
            this.materialLabel31.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel31.Depth = 0;
            this.materialLabel31.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel31.Location = new System.Drawing.Point(14, 33);
            this.materialLabel31.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel31.Name = "materialLabel31";
            this.materialLabel31.Size = new System.Drawing.Size(87, 18);
            this.materialLabel31.TabIndex = 179;
            this.materialLabel31.Text = "Install Pose";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1061);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Consolas", 9F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "적재함 2D 보정 프로그램";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.materialCard15.ResumeLayout(false);
            this.materialCard15.PerformLayout();
            this.materialCard14.ResumeLayout(false);
            this.materialCard14.PerformLayout();
            this.materialCard6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLh)).EndInit();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.tlpGlassCamera.ResumeLayout(false);
            this.tlpGlassCamera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOk)).EndInit();
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbNg)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.gbGlassUserControl_.ResumeLayout(false);
            this.gbGlassShiftValue_.ResumeLayout(false);
            this.gbGlassShiftValue_.PerformLayout();
            this.gbGlassPoint_.ResumeLayout(false);
            this.gbGlassPoint_.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelNgListViewHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            this.gbPLC.ResumeLayout(false);
            this.gbPLC.PerformLayout();
            this.gbCarType.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.materialCard5.ResumeLayout(false);
            this.gbCarSeqNumber_.ResumeLayout(false);
            this.gbRobotRead.ResumeLayout(false);
            this.gbRobotRead.PerformLayout();
            this.gbRobotWrite.ResumeLayout(false);
            this.gbRobotWrite.PerformLayout();
            this.materialCard7.ResumeLayout(false);
            this.materialCard7.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox rtbLog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialCard gbMode;
        private MaterialSkin.Controls.MaterialRadioButton rbSet_;
        private MaterialSkin.Controls.MaterialRadioButton rbAuto_;
        private MaterialSkin.Controls.MaterialCard gbPLC;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialCard gbCarType;
        private MaterialSkin.Controls.MaterialTextBox2 tbCarType;
        private MaterialSkin.Controls.MaterialComboBox cmbCarTypeName;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private MaterialSkin.Controls.MaterialButton btnCameraConnect_;
        private MaterialSkin.Controls.MaterialButton btnLightOff_;
        private MaterialSkin.Controls.MaterialLabel label22;
        private MaterialSkin.Controls.MaterialTextBox2 tbPlc;
        private MaterialSkin.Controls.MaterialLabel lblGlassCameraModel_;
        private MaterialSkin.Controls.MaterialLabel lblGlassCameraSerials_;
        private MaterialSkin.Controls.MaterialTextBox2 tbGlassCamera;
        private MaterialSkin.Controls.MaterialLabel lblGlassCamera_;
        private MaterialSkin.Controls.MaterialTextBox2 tbGlassCameraModel;
        private MaterialSkin.Controls.MaterialCard gbCarSeqNumber_;
        private MaterialSkin.Controls.MaterialTextBox2 tbCarSeqNumber;
        private MaterialSkin.Controls.MaterialRadioButton rbManual_;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ListView ltvNG;
        private MaterialSkin.Controls.MaterialTextBox2 tbGlassMaxValueRz;
        private MaterialSkin.Controls.MaterialLabel label90;
        private MaterialSkin.Controls.MaterialTextBox2 tbGlassMaxValueTy;
        private MaterialSkin.Controls.MaterialLabel label94;
        private MaterialSkin.Controls.MaterialTextBox2 tbGlassMaxValueTx;
        private MaterialSkin.Controls.MaterialLabel label95;
        private MaterialSkin.Controls.MaterialLabel label92;
        private MaterialSkin.Controls.MaterialTextBox2 textBox1;
        private MaterialSkin.Controls.MaterialButton btnNgListClear_;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.Panel panelNgListViewHeader;
        private MaterialSkin.Controls.MaterialLabel lblDashDate;
        private MaterialSkin.Controls.MaterialLabel lblDashType;
        private MaterialSkin.Controls.MaterialLabel lblDashCarSeqNum;
        private MaterialSkin.Controls.MaterialLabel lblDashCarType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CoPick.Controls.PlcSignalStatusValueTable carTypeSignalStatus;
        private CoPick.Controls.PlcSignalStatusValueTable glassWriteSignal2Status;
        private CoPick.Controls.PlcSignalStatusOnlyTable glassWriteSignalStatus;
        private CoPick.Controls.PlcSignalStatusOnlyTable glassReadSignalStatus;
        private MaterialSkin.Controls.MaterialLabel lblErrorNotice;
        private PictureBox pictureBox4;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox24;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox25;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox26;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox22;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private TableLayoutPanel tlpGlassCamera;
        private MaterialSkin.Controls.MaterialCheckbox ckbGlassCameraUse4;
        private MaterialSkin.Controls.MaterialTextBox2 tbGlassCameraSerial1;
        private MaterialSkin.Controls.MaterialLabel lblGlassCameraAlias1;
        private MaterialSkin.Controls.MaterialCheckbox ckbGlassCameraUse1;
        private MaterialSkin.Controls.MaterialLabel lblGlassCameraAlias4;
        private MaterialSkin.Controls.MaterialCheckbox ckbGlassCameraUse2;
        private MaterialSkin.Controls.MaterialTextBox2 tbGlassCameraSerial3;
        private MaterialSkin.Controls.MaterialLabel lblGlassCameraAlias3;
        private MaterialSkin.Controls.MaterialLabel lblGlassCameraAlias2;
        private MaterialSkin.Controls.MaterialTextBox2 tbGlassCameraSerial2;
        private MaterialSkin.Controls.MaterialTextBox2 tbGlassCameraSerial4;
        private MaterialSkin.Controls.MaterialCheckbox ckbGlassCameraUse3;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox23;
        private PictureBox pbOk;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private CoPick.Controls.PlcSignalStatusOnlyTable plcSignalStatusOnlyTable1;
        private CoPick.Controls.PlcSignalStatusValueTable plcSignalStatusValueTable1;
        private PictureBox pbNg;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private CoPick.Controls.PlcSignalStatusOnlyTable plcSignalStatusOnlyTable2;
        private CoPick.Controls.PlcSignalStatusValueTable plcSignalStatusValueTable2;
        private MaterialSkin.Controls.MaterialCard gbGlassUserControl_;
        private MaterialSkin.Controls.MaterialButton btnGlassBackUp_;
        private MaterialSkin.Controls.MaterialButton lblGlassRHCamera_;
        private MaterialSkin.Controls.MaterialButton lblGlassLHCamera_;
        private MaterialSkin.Controls.MaterialButton btnGlassRHCameraUnuse_;
        private MaterialSkin.Controls.MaterialButton btnGlassRHCameraUse_;
        private MaterialSkin.Controls.MaterialButton btnGlassLHCameraUnuse_;
        private MaterialSkin.Controls.MaterialButton btnGlassLHCameraUse_;
        private MaterialSkin.Controls.MaterialLabel label85_;
        private MaterialSkin.Controls.MaterialTextBox2 tbGlassRefDataPath;
        private MaterialSkin.Controls.MaterialButton btnGlassRefDataPath;
        private MaterialSkin.Controls.MaterialLabel label86_;
        private MaterialSkin.Controls.MaterialTextBox2 tbGlassHandEyeCalibFilePath;
        private MaterialSkin.Controls.MaterialButton btnGlassHandEyeCalibFilePath;
        private MaterialSkin.Controls.MaterialButton btnGlassUpdate_;
        private MaterialSkin.Controls.MaterialButton btnGlassCalculate_;
        private MaterialSkin.Controls.MaterialCard gbGlassShiftValue_;
        private MaterialSkin.Controls.MaterialLabel label88;
        private MaterialSkin.Controls.MaterialTextBox2 tbGlassShiftValueRz;
        private MaterialSkin.Controls.MaterialTextBox2 tbGlassShiftValueTx;
        private MaterialSkin.Controls.MaterialLabel label79;
        private MaterialSkin.Controls.MaterialLabel label80;
        private MaterialSkin.Controls.MaterialTextBox2 tbGlassShiftValueTy;
        private MaterialSkin.Controls.MaterialCard gbGlassPoint_;
        private MaterialSkin.Controls.MaterialButton btnStartCamera_;
        private MaterialSkin.Controls.MaterialTextBox2 tbGlassPointTx;
        private MaterialSkin.Controls.MaterialLabel label73;
        private MaterialSkin.Controls.MaterialLabel label74;
        private MaterialSkin.Controls.MaterialLabel label75;
        private MaterialSkin.Controls.MaterialLabel label76;
        private MaterialSkin.Controls.MaterialLabel label77;
        private MaterialSkin.Controls.MaterialLabel label78;
        private MaterialSkin.Controls.MaterialTextBox2 tbGlassPointTy;
        private MaterialSkin.Controls.MaterialTextBox2 tbGlassPointTz;
        private MaterialSkin.Controls.MaterialTextBox2 tbGlassPointRx;
        private MaterialSkin.Controls.MaterialTextBox2 tbGlassPointRz;
        private MaterialSkin.Controls.MaterialTextBox2 tbGlassPointRy;
        private PictureBox pbRh;
        private PictureBox pbLh;
        private MaterialSkin.Controls.MaterialTextBox2 tbCarBodyNumber;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialButton btnConnectPlc_;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialLabel lblPlc;
        private MaterialSkin.Controls.MaterialButton btnSettingManage_;
        private MaterialSkin.Controls.MaterialCard materialCard15;
        private MaterialSkin.Controls.MaterialLabel lblRH_;
        private MaterialSkin.Controls.MaterialCard materialCard14;
        private MaterialSkin.Controls.MaterialLabel lblLH_;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialLabel materialLabel31;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel materialLabel27;
        private MaterialSkin.Controls.MaterialLabel materialLabel29;
        private MaterialSkin.Controls.MaterialTextBox2 tbInstallPoseRz_;
        private MaterialSkin.Controls.MaterialTextBox2 tbInstallPoseTz_;
        private MaterialSkin.Controls.MaterialButton btnReadInstallPose_;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox29;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox210;
        private MaterialSkin.Controls.MaterialTextBox2 tbInstallPoseRx_;
        private MaterialSkin.Controls.MaterialTextBox2 tbInstallPoseTx_;
        private MaterialSkin.Controls.MaterialLabel materialLabel32;
        private MaterialSkin.Controls.MaterialLabel materialLabel33;
        private MaterialSkin.Controls.MaterialLabel materialLabel34;
        private MaterialSkin.Controls.MaterialLabel materialLabel35;
        private MaterialSkin.Controls.MaterialLabel materialLabel36;
        private MaterialSkin.Controls.MaterialTextBox2 tbInstallPoseRy_;
        private MaterialSkin.Controls.MaterialTextBox2 tbInstallPoseTy_;
        private MaterialSkin.Controls.MaterialCard gbRobotRead;
        private MaterialSkin.Controls.MaterialLabel materialLabel24;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox2 tbScanPoseRz_;
        private MaterialSkin.Controls.MaterialTextBox2 tbScanPoseTz_;
        private MaterialSkin.Controls.MaterialButton btnReadScanPose_;
        private MaterialSkin.Controls.MaterialTextBox2 tbCurrRobotTz;
        private MaterialSkin.Controls.MaterialTextBox2 tbCurrRobotRx;
        private MaterialSkin.Controls.MaterialTextBox2 tbScanPoseRx_;
        private MaterialSkin.Controls.MaterialTextBox2 tbScanPoseTx_;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel23;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel22;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialTextBox2 tbScanPoseRy_;
        private MaterialSkin.Controls.MaterialTextBox2 tbScanPoseTy_;
        private MaterialSkin.Controls.MaterialCard gbRobotWrite;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialButton btnReadWrittenShiftPose_;
        private MaterialSkin.Controls.MaterialButton btnWriteShiftPose_;
        private MaterialSkin.Controls.MaterialTextBox2 tbWrittenRz_;
        private MaterialSkin.Controls.MaterialTextBox2 tbShiftRzR1;
        private MaterialSkin.Controls.MaterialTextBox2 tbWrittenTx_;
        private MaterialSkin.Controls.MaterialTextBox2 tbShiftTxR1;
        private MaterialSkin.Controls.MaterialLabel materialLabel21;
        private MaterialSkin.Controls.MaterialLabel materialLabel26;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel25;
        private MaterialSkin.Controls.MaterialTextBox2 tbWrittenTy_;
        private MaterialSkin.Controls.MaterialLabel materialLabel28;
        private MaterialSkin.Controls.MaterialTextBox2 tbShiftTyR1;
    }
}

