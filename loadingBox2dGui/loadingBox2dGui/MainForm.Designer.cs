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
            this.btnUpdateMasterScanPose_ = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdateMasterInstallPose_ = new MaterialSkin.Controls.MaterialButton();
            this.gbRobotReadComputed = new MaterialSkin.Controls.MaterialCard();
            this.btnReadWrittenShiftPose_ = new MaterialSkin.Controls.MaterialButton();
            this.tbWrittenTxyz_ = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel22 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel23 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel28 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel29 = new MaterialSkin.Controls.MaterialLabel();
            this.tbWrittenRxyz_ = new MaterialSkin.Controls.MaterialTextBox2();
            this.gbRobotRead = new MaterialSkin.Controls.MaterialCard();
            this.tbReadInstallPoseTxyz = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.tbReadInstallPoseRxyz = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbReadScanPoseTxyz = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.tbReadScanPoseRxyz = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.btnReadScanPose_ = new MaterialSkin.Controls.MaterialButton();
            this.tbCurrRobotTz = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbCurrRobotRx = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.gbRobotWrite = new MaterialSkin.Controls.MaterialCard();
            this.tbShiftRz = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.btnWriteShiftPose_ = new MaterialSkin.Controls.MaterialButton();
            this.tbShiftTx = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.lblShiftPoseRxyz_ = new MaterialSkin.Controls.MaterialLabel();
            this.tbShiftTy = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnScanPoint_ = new MaterialSkin.Controls.MaterialButton();
            this.btnCameraConnect_ = new MaterialSkin.Controls.MaterialButton();
            this.btnLightOff_ = new MaterialSkin.Controls.MaterialButton();
            this.pbRh = new System.Windows.Forms.PictureBox();
            this.pbLh = new System.Windows.Forms.PictureBox();
            this.pbOk = new System.Windows.Forms.PictureBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.plcSignalStatusOnlyTable1 = new CoPick.Controls.PlcSignalStatusOnlyTable();
            this.plcSignalStatusValueTable1 = new CoPick.Controls.PlcSignalStatusValueTable();
            this.pbNg = new System.Windows.Forms.PictureBox();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.plcSignalStatusOnlyTable2 = new CoPick.Controls.PlcSignalStatusOnlyTable();
            this.plcSignalStatusValueTable2 = new CoPick.Controls.PlcSignalStatusValueTable();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvNgList = new System.Windows.Forms.DataGridView();
            this.btnNgListClear_ = new MaterialSkin.Controls.MaterialButton();
            this.rtbLog = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnGlassBackUp_ = new MaterialSkin.Controls.MaterialButton();
            this.lblGlassRHCamera_ = new MaterialSkin.Controls.MaterialButton();
            this.lblGlassLHCamera_ = new MaterialSkin.Controls.MaterialButton();
            this.btnGlassRHCameraUnuse_ = new MaterialSkin.Controls.MaterialButton();
            this.btnGlassRHCameraUse_ = new MaterialSkin.Controls.MaterialButton();
            this.btnGlassLHCameraUnuse_ = new MaterialSkin.Controls.MaterialButton();
            this.btnGlassLHCameraUse_ = new MaterialSkin.Controls.MaterialButton();
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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
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
            this.btnCaptureCheckerBoard_ = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.materialCard15.SuspendLayout();
            this.materialCard14.SuspendLayout();
            this.materialCard6.SuspendLayout();
            this.gbRobotReadComputed.SuspendLayout();
            this.gbRobotRead.SuspendLayout();
            this.gbRobotWrite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOk)).BeginInit();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNg)).BeginInit();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNgList)).BeginInit();
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
            this.splitContainer2.Panel1.Controls.Add(this.pbOk);
            this.splitContainer2.Panel1.Controls.Add(this.materialCard1);
            this.splitContainer2.Panel1.Controls.Add(this.pbNg);
            this.splitContainer2.Panel1.Controls.Add(this.materialCard2);
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
            this.materialCard6.Controls.Add(this.btnCaptureCheckerBoard_);
            this.materialCard6.Controls.Add(this.btnUpdateMasterScanPose_);
            this.materialCard6.Controls.Add(this.btnUpdateMasterInstallPose_);
            this.materialCard6.Controls.Add(this.gbRobotReadComputed);
            this.materialCard6.Controls.Add(this.gbRobotRead);
            this.materialCard6.Controls.Add(this.gbRobotWrite);
            this.materialCard6.Controls.Add(this.btnScanPoint_);
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
            // btnUpdateMasterScanPose_
            // 
            this.btnUpdateMasterScanPose_.AutoSize = false;
            this.btnUpdateMasterScanPose_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateMasterScanPose_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(215)))), ((int)(((byte)(73)))));
            this.btnUpdateMasterScanPose_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnUpdateMasterScanPose_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdateMasterScanPose_.Depth = 0;
            this.btnUpdateMasterScanPose_.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnUpdateMasterScanPose_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMasterScanPose_.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnUpdateMasterScanPose_.HighEmphasis = true;
            this.btnUpdateMasterScanPose_.Icon = null;
            this.btnUpdateMasterScanPose_.Location = new System.Drawing.Point(358, 247);
            this.btnUpdateMasterScanPose_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdateMasterScanPose_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdateMasterScanPose_.Name = "btnUpdateMasterScanPose_";
            this.btnUpdateMasterScanPose_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdateMasterScanPose_.Size = new System.Drawing.Size(325, 87);
            this.btnUpdateMasterScanPose_.TabIndex = 184;
            this.btnUpdateMasterScanPose_.Text = "Update Scan Pose";
            this.btnUpdateMasterScanPose_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdateMasterScanPose_.UseAccentColor = false;
            this.btnUpdateMasterScanPose_.UseVisualStyleBackColor = false;
            this.btnUpdateMasterScanPose_.Click += new System.EventHandler(this.btnUpdateMasterScanPose__Click);
            // 
            // btnUpdateMasterInstallPose_
            // 
            this.btnUpdateMasterInstallPose_.AutoSize = false;
            this.btnUpdateMasterInstallPose_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateMasterInstallPose_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(65)))));
            this.btnUpdateMasterInstallPose_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnUpdateMasterInstallPose_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdateMasterInstallPose_.Depth = 0;
            this.btnUpdateMasterInstallPose_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMasterInstallPose_.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnUpdateMasterInstallPose_.HighEmphasis = true;
            this.btnUpdateMasterInstallPose_.Icon = null;
            this.btnUpdateMasterInstallPose_.Location = new System.Drawing.Point(358, 137);
            this.btnUpdateMasterInstallPose_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdateMasterInstallPose_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdateMasterInstallPose_.Name = "btnUpdateMasterInstallPose_";
            this.btnUpdateMasterInstallPose_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdateMasterInstallPose_.Size = new System.Drawing.Size(325, 93);
            this.btnUpdateMasterInstallPose_.TabIndex = 183;
            this.btnUpdateMasterInstallPose_.Text = "Update Install Pose";
            this.btnUpdateMasterInstallPose_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdateMasterInstallPose_.UseAccentColor = false;
            this.btnUpdateMasterInstallPose_.UseVisualStyleBackColor = false;
            this.btnUpdateMasterInstallPose_.Click += new System.EventHandler(this.btnUpdateMasterInstallPose__Click);
            // 
            // gbRobotReadComputed
            // 
            this.gbRobotReadComputed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbRobotReadComputed.Controls.Add(this.btnReadWrittenShiftPose_);
            this.gbRobotReadComputed.Controls.Add(this.tbWrittenTxyz_);
            this.gbRobotReadComputed.Controls.Add(this.materialLabel22);
            this.gbRobotReadComputed.Controls.Add(this.materialLabel23);
            this.gbRobotReadComputed.Controls.Add(this.materialLabel28);
            this.gbRobotReadComputed.Controls.Add(this.materialLabel29);
            this.gbRobotReadComputed.Controls.Add(this.tbWrittenRxyz_);
            this.gbRobotReadComputed.Depth = 0;
            this.gbRobotReadComputed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbRobotReadComputed.Location = new System.Drawing.Point(688, 247);
            this.gbRobotReadComputed.Margin = new System.Windows.Forms.Padding(14);
            this.gbRobotReadComputed.MouseState = MaterialSkin.MouseState.HOVER;
            this.gbRobotReadComputed.Name = "gbRobotReadComputed";
            this.gbRobotReadComputed.Padding = new System.Windows.Forms.Padding(14);
            this.gbRobotReadComputed.Size = new System.Drawing.Size(198, 130);
            this.gbRobotReadComputed.TabIndex = 182;
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
            this.btnReadWrittenShiftPose_.Location = new System.Drawing.Point(128, 31);
            this.btnReadWrittenShiftPose_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReadWrittenShiftPose_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReadWrittenShiftPose_.Name = "btnReadWrittenShiftPose_";
            this.btnReadWrittenShiftPose_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReadWrittenShiftPose_.Size = new System.Drawing.Size(57, 26);
            this.btnReadWrittenShiftPose_.TabIndex = 179;
            this.btnReadWrittenShiftPose_.Text = "READ";
            this.btnReadWrittenShiftPose_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReadWrittenShiftPose_.UseAccentColor = false;
            this.btnReadWrittenShiftPose_.UseVisualStyleBackColor = false;
            this.btnReadWrittenShiftPose_.Click += new System.EventHandler(this.btnReadWrittenShiftPose__Click);
            // 
            // tbWrittenTxyz_
            // 
            this.tbWrittenTxyz_.AnimateReadOnly = false;
            this.tbWrittenTxyz_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbWrittenTxyz_.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbWrittenTxyz_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbWrittenTxyz_.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbWrittenTxyz_.Depth = 0;
            this.tbWrittenTxyz_.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbWrittenTxyz_.HideSelection = true;
            this.tbWrittenTxyz_.LeadingIcon = null;
            this.tbWrittenTxyz_.Location = new System.Drawing.Point(53, 63);
            this.tbWrittenTxyz_.MaxLength = 32767;
            this.tbWrittenTxyz_.MouseState = MaterialSkin.MouseState.OUT;
            this.tbWrittenTxyz_.Name = "tbWrittenTxyz_";
            this.tbWrittenTxyz_.PasswordChar = '\0';
            this.tbWrittenTxyz_.PrefixSuffixText = null;
            this.tbWrittenTxyz_.ReadOnly = false;
            this.tbWrittenTxyz_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbWrittenTxyz_.SelectedText = "";
            this.tbWrittenTxyz_.SelectionLength = 0;
            this.tbWrittenTxyz_.SelectionStart = 0;
            this.tbWrittenTxyz_.ShortcutsEnabled = true;
            this.tbWrittenTxyz_.Size = new System.Drawing.Size(132, 26);
            this.tbWrittenTxyz_.TabIndex = 6;
            this.tbWrittenTxyz_.TabStop = false;
            this.tbWrittenTxyz_.Text = "1";
            this.tbWrittenTxyz_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbWrittenTxyz_.TrailingIcon = null;
            this.tbWrittenTxyz_.UseSystemPasswordChar = false;
            this.tbWrittenTxyz_.UseTallSize = false;
            // 
            // materialLabel22
            // 
            this.materialLabel22.AutoSize = true;
            this.materialLabel22.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel22.Depth = 0;
            this.materialLabel22.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel22.Location = new System.Drawing.Point(6, 34);
            this.materialLabel22.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel22.Name = "materialLabel22";
            this.materialLabel22.Size = new System.Drawing.Size(101, 18);
            this.materialLabel22.TabIndex = 7;
            this.materialLabel22.Text = "Read Written";
            // 
            // materialLabel23
            // 
            this.materialLabel23.AutoSize = true;
            this.materialLabel23.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel23.Depth = 0;
            this.materialLabel23.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel23.Location = new System.Drawing.Point(7, 67);
            this.materialLabel23.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel23.Name = "materialLabel23";
            this.materialLabel23.Size = new System.Drawing.Size(35, 18);
            this.materialLabel23.TabIndex = 7;
            this.materialLabel23.Text = "Txyz";
            // 
            // materialLabel28
            // 
            this.materialLabel28.AutoSize = true;
            this.materialLabel28.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel28.Depth = 0;
            this.materialLabel28.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel28.Location = new System.Drawing.Point(6, 11);
            this.materialLabel28.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel28.Name = "materialLabel28";
            this.materialLabel28.Size = new System.Drawing.Size(128, 18);
            this.materialLabel28.TabIndex = 7;
            this.materialLabel28.Text = "ROBOT -> VISION";
            // 
            // materialLabel29
            // 
            this.materialLabel29.AutoSize = true;
            this.materialLabel29.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel29.Depth = 0;
            this.materialLabel29.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel29.Location = new System.Drawing.Point(7, 95);
            this.materialLabel29.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel29.Name = "materialLabel29";
            this.materialLabel29.Size = new System.Drawing.Size(36, 18);
            this.materialLabel29.TabIndex = 8;
            this.materialLabel29.Text = "Rxyz";
            // 
            // tbWrittenRxyz_
            // 
            this.tbWrittenRxyz_.AnimateReadOnly = false;
            this.tbWrittenRxyz_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbWrittenRxyz_.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbWrittenRxyz_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbWrittenRxyz_.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbWrittenRxyz_.Depth = 0;
            this.tbWrittenRxyz_.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbWrittenRxyz_.HideSelection = true;
            this.tbWrittenRxyz_.LeadingIcon = null;
            this.tbWrittenRxyz_.Location = new System.Drawing.Point(53, 91);
            this.tbWrittenRxyz_.MaxLength = 32767;
            this.tbWrittenRxyz_.MouseState = MaterialSkin.MouseState.OUT;
            this.tbWrittenRxyz_.Name = "tbWrittenRxyz_";
            this.tbWrittenRxyz_.PasswordChar = '\0';
            this.tbWrittenRxyz_.PrefixSuffixText = null;
            this.tbWrittenRxyz_.ReadOnly = false;
            this.tbWrittenRxyz_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbWrittenRxyz_.SelectedText = "";
            this.tbWrittenRxyz_.SelectionLength = 0;
            this.tbWrittenRxyz_.SelectionStart = 0;
            this.tbWrittenRxyz_.ShortcutsEnabled = true;
            this.tbWrittenRxyz_.Size = new System.Drawing.Size(132, 26);
            this.tbWrittenRxyz_.TabIndex = 13;
            this.tbWrittenRxyz_.TabStop = false;
            this.tbWrittenRxyz_.Text = "2";
            this.tbWrittenRxyz_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbWrittenRxyz_.TrailingIcon = null;
            this.tbWrittenRxyz_.UseSystemPasswordChar = false;
            this.tbWrittenRxyz_.UseTallSize = false;
            // 
            // gbRobotRead
            // 
            this.gbRobotRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbRobotRead.Controls.Add(this.tbReadInstallPoseTxyz);
            this.gbRobotRead.Controls.Add(this.materialLabel13);
            this.gbRobotRead.Controls.Add(this.materialLabel16);
            this.gbRobotRead.Controls.Add(this.tbReadInstallPoseRxyz);
            this.gbRobotRead.Controls.Add(this.tbReadScanPoseTxyz);
            this.gbRobotRead.Controls.Add(this.materialLabel10);
            this.gbRobotRead.Controls.Add(this.materialLabel12);
            this.gbRobotRead.Controls.Add(this.tbReadScanPoseRxyz);
            this.gbRobotRead.Controls.Add(this.materialLabel8);
            this.gbRobotRead.Controls.Add(this.materialButton1);
            this.gbRobotRead.Controls.Add(this.materialLabel9);
            this.gbRobotRead.Controls.Add(this.btnReadScanPose_);
            this.gbRobotRead.Controls.Add(this.tbCurrRobotTz);
            this.gbRobotRead.Controls.Add(this.tbCurrRobotRx);
            this.gbRobotRead.Controls.Add(this.materialLabel18);
            this.gbRobotRead.Controls.Add(this.materialLabel14);
            this.gbRobotRead.Depth = 0;
            this.gbRobotRead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbRobotRead.Location = new System.Drawing.Point(688, 13);
            this.gbRobotRead.Margin = new System.Windows.Forms.Padding(14);
            this.gbRobotRead.MouseState = MaterialSkin.MouseState.HOVER;
            this.gbRobotRead.Name = "gbRobotRead";
            this.gbRobotRead.Padding = new System.Windows.Forms.Padding(14);
            this.gbRobotRead.Size = new System.Drawing.Size(198, 230);
            this.gbRobotRead.TabIndex = 178;
            // 
            // tbReadInstallPoseTxyz
            // 
            this.tbReadInstallPoseTxyz.AnimateReadOnly = false;
            this.tbReadInstallPoseTxyz.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbReadInstallPoseTxyz.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbReadInstallPoseTxyz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbReadInstallPoseTxyz.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbReadInstallPoseTxyz.Depth = 0;
            this.tbReadInstallPoseTxyz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbReadInstallPoseTxyz.HideSelection = true;
            this.tbReadInstallPoseTxyz.LeadingIcon = null;
            this.tbReadInstallPoseTxyz.Location = new System.Drawing.Point(55, 170);
            this.tbReadInstallPoseTxyz.MaxLength = 32767;
            this.tbReadInstallPoseTxyz.MouseState = MaterialSkin.MouseState.OUT;
            this.tbReadInstallPoseTxyz.Name = "tbReadInstallPoseTxyz";
            this.tbReadInstallPoseTxyz.PasswordChar = '\0';
            this.tbReadInstallPoseTxyz.PrefixSuffixText = null;
            this.tbReadInstallPoseTxyz.ReadOnly = false;
            this.tbReadInstallPoseTxyz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbReadInstallPoseTxyz.SelectedText = "";
            this.tbReadInstallPoseTxyz.SelectionLength = 0;
            this.tbReadInstallPoseTxyz.SelectionStart = 0;
            this.tbReadInstallPoseTxyz.ShortcutsEnabled = true;
            this.tbReadInstallPoseTxyz.Size = new System.Drawing.Size(132, 26);
            this.tbReadInstallPoseTxyz.TabIndex = 186;
            this.tbReadInstallPoseTxyz.TabStop = false;
            this.tbReadInstallPoseTxyz.Text = "1";
            this.tbReadInstallPoseTxyz.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbReadInstallPoseTxyz.TrailingIcon = null;
            this.tbReadInstallPoseTxyz.UseSystemPasswordChar = false;
            this.tbReadInstallPoseTxyz.UseTallSize = false;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(7, 173);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(35, 18);
            this.materialLabel13.TabIndex = 187;
            this.materialLabel13.Text = "Txyz";
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.Location = new System.Drawing.Point(7, 201);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(36, 18);
            this.materialLabel16.TabIndex = 188;
            this.materialLabel16.Text = "Rxyz";
            // 
            // tbReadInstallPoseRxyz
            // 
            this.tbReadInstallPoseRxyz.AnimateReadOnly = false;
            this.tbReadInstallPoseRxyz.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbReadInstallPoseRxyz.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbReadInstallPoseRxyz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbReadInstallPoseRxyz.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbReadInstallPoseRxyz.Depth = 0;
            this.tbReadInstallPoseRxyz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbReadInstallPoseRxyz.HideSelection = true;
            this.tbReadInstallPoseRxyz.LeadingIcon = null;
            this.tbReadInstallPoseRxyz.Location = new System.Drawing.Point(55, 198);
            this.tbReadInstallPoseRxyz.MaxLength = 32767;
            this.tbReadInstallPoseRxyz.MouseState = MaterialSkin.MouseState.OUT;
            this.tbReadInstallPoseRxyz.Name = "tbReadInstallPoseRxyz";
            this.tbReadInstallPoseRxyz.PasswordChar = '\0';
            this.tbReadInstallPoseRxyz.PrefixSuffixText = null;
            this.tbReadInstallPoseRxyz.ReadOnly = false;
            this.tbReadInstallPoseRxyz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbReadInstallPoseRxyz.SelectedText = "";
            this.tbReadInstallPoseRxyz.SelectionLength = 0;
            this.tbReadInstallPoseRxyz.SelectionStart = 0;
            this.tbReadInstallPoseRxyz.ShortcutsEnabled = true;
            this.tbReadInstallPoseRxyz.Size = new System.Drawing.Size(132, 26);
            this.tbReadInstallPoseRxyz.TabIndex = 189;
            this.tbReadInstallPoseRxyz.TabStop = false;
            this.tbReadInstallPoseRxyz.Text = "2";
            this.tbReadInstallPoseRxyz.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbReadInstallPoseRxyz.TrailingIcon = null;
            this.tbReadInstallPoseRxyz.UseSystemPasswordChar = false;
            this.tbReadInstallPoseRxyz.UseTallSize = false;
            // 
            // tbReadScanPoseTxyz
            // 
            this.tbReadScanPoseTxyz.AnimateReadOnly = false;
            this.tbReadScanPoseTxyz.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbReadScanPoseTxyz.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbReadScanPoseTxyz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbReadScanPoseTxyz.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbReadScanPoseTxyz.Depth = 0;
            this.tbReadScanPoseTxyz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbReadScanPoseTxyz.HideSelection = true;
            this.tbReadScanPoseTxyz.LeadingIcon = null;
            this.tbReadScanPoseTxyz.Location = new System.Drawing.Point(55, 68);
            this.tbReadScanPoseTxyz.MaxLength = 32767;
            this.tbReadScanPoseTxyz.MouseState = MaterialSkin.MouseState.OUT;
            this.tbReadScanPoseTxyz.Name = "tbReadScanPoseTxyz";
            this.tbReadScanPoseTxyz.PasswordChar = '\0';
            this.tbReadScanPoseTxyz.PrefixSuffixText = null;
            this.tbReadScanPoseTxyz.ReadOnly = false;
            this.tbReadScanPoseTxyz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbReadScanPoseTxyz.SelectedText = "";
            this.tbReadScanPoseTxyz.SelectionLength = 0;
            this.tbReadScanPoseTxyz.SelectionStart = 0;
            this.tbReadScanPoseTxyz.ShortcutsEnabled = true;
            this.tbReadScanPoseTxyz.Size = new System.Drawing.Size(132, 26);
            this.tbReadScanPoseTxyz.TabIndex = 182;
            this.tbReadScanPoseTxyz.TabStop = false;
            this.tbReadScanPoseTxyz.Text = "1";
            this.tbReadScanPoseTxyz.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbReadScanPoseTxyz.TrailingIcon = null;
            this.tbReadScanPoseTxyz.UseSystemPasswordChar = false;
            this.tbReadScanPoseTxyz.UseTallSize = false;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(7, 71);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(35, 18);
            this.materialLabel10.TabIndex = 183;
            this.materialLabel10.Text = "Txyz";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(7, 99);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(36, 18);
            this.materialLabel12.TabIndex = 184;
            this.materialLabel12.Text = "Rxyz";
            // 
            // tbReadScanPoseRxyz
            // 
            this.tbReadScanPoseRxyz.AnimateReadOnly = false;
            this.tbReadScanPoseRxyz.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbReadScanPoseRxyz.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbReadScanPoseRxyz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbReadScanPoseRxyz.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbReadScanPoseRxyz.Depth = 0;
            this.tbReadScanPoseRxyz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbReadScanPoseRxyz.HideSelection = true;
            this.tbReadScanPoseRxyz.LeadingIcon = null;
            this.tbReadScanPoseRxyz.Location = new System.Drawing.Point(55, 96);
            this.tbReadScanPoseRxyz.MaxLength = 32767;
            this.tbReadScanPoseRxyz.MouseState = MaterialSkin.MouseState.OUT;
            this.tbReadScanPoseRxyz.Name = "tbReadScanPoseRxyz";
            this.tbReadScanPoseRxyz.PasswordChar = '\0';
            this.tbReadScanPoseRxyz.PrefixSuffixText = null;
            this.tbReadScanPoseRxyz.ReadOnly = false;
            this.tbReadScanPoseRxyz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbReadScanPoseRxyz.SelectedText = "";
            this.tbReadScanPoseRxyz.SelectionLength = 0;
            this.tbReadScanPoseRxyz.SelectionStart = 0;
            this.tbReadScanPoseRxyz.ShortcutsEnabled = true;
            this.tbReadScanPoseRxyz.Size = new System.Drawing.Size(132, 26);
            this.tbReadScanPoseRxyz.TabIndex = 185;
            this.tbReadScanPoseRxyz.TabStop = false;
            this.tbReadScanPoseRxyz.Text = "2";
            this.tbReadScanPoseRxyz.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbReadScanPoseRxyz.TrailingIcon = null;
            this.tbReadScanPoseRxyz.UseSystemPasswordChar = false;
            this.tbReadScanPoseRxyz.UseTallSize = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(6, 142);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(116, 18);
            this.materialLabel8.TabIndex = 181;
            this.materialLabel8.Text = "Ref Install Pose";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.BackColor = System.Drawing.Color.DimGray;
            this.materialButton1.CustomBackColor = System.Drawing.Color.Empty;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.materialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton1.Font = new System.Drawing.Font("Consolas", 12F);
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(129, 139);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(57, 26);
            this.materialButton1.TabIndex = 180;
            this.materialButton1.Text = "READ";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = false;
            this.materialButton1.Click += new System.EventHandler(this.btnReadInstallPose_Click);
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
            this.btnReadScanPose_.Location = new System.Drawing.Point(129, 33);
            this.btnReadScanPose_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReadScanPose_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReadScanPose_.Name = "btnReadScanPose_";
            this.btnReadScanPose_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReadScanPose_.Size = new System.Drawing.Size(57, 26);
            this.btnReadScanPose_.TabIndex = 178;
            this.btnReadScanPose_.Text = "READ";
            this.btnReadScanPose_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReadScanPose_.UseAccentColor = false;
            this.btnReadScanPose_.UseVisualStyleBackColor = false;
            this.btnReadScanPose_.Click += new System.EventHandler(this.btnReadScanPose_Click);
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
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel18.Location = new System.Drawing.Point(6, 36);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(108, 18);
            this.materialLabel18.TabIndex = 7;
            this.materialLabel18.Text = "Ref Scan Pose";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.Location = new System.Drawing.Point(6, 11);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(128, 18);
            this.materialLabel14.TabIndex = 7;
            this.materialLabel14.Text = "ROBOT -> VISION";
            // 
            // gbRobotWrite
            // 
            this.gbRobotWrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbRobotWrite.Controls.Add(this.tbShiftRz);
            this.gbRobotWrite.Controls.Add(this.materialLabel17);
            this.gbRobotWrite.Controls.Add(this.btnWriteShiftPose_);
            this.gbRobotWrite.Controls.Add(this.tbShiftTx);
            this.gbRobotWrite.Controls.Add(this.materialLabel11);
            this.gbRobotWrite.Controls.Add(this.materialLabel20);
            this.gbRobotWrite.Controls.Add(this.materialLabel15);
            this.gbRobotWrite.Controls.Add(this.lblShiftPoseRxyz_);
            this.gbRobotWrite.Controls.Add(this.tbShiftTy);
            this.gbRobotWrite.Depth = 0;
            this.gbRobotWrite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbRobotWrite.Location = new System.Drawing.Point(890, 13);
            this.gbRobotWrite.Margin = new System.Windows.Forms.Padding(14);
            this.gbRobotWrite.MouseState = MaterialSkin.MouseState.HOVER;
            this.gbRobotWrite.Name = "gbRobotWrite";
            this.gbRobotWrite.Padding = new System.Windows.Forms.Padding(14);
            this.gbRobotWrite.Size = new System.Drawing.Size(198, 160);
            this.gbRobotWrite.TabIndex = 179;
            // 
            // tbShiftRz
            // 
            this.tbShiftRz.AnimateReadOnly = false;
            this.tbShiftRz.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbShiftRz.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbShiftRz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbShiftRz.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbShiftRz.Depth = 0;
            this.tbShiftRz.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbShiftRz.HideSelection = true;
            this.tbShiftRz.LeadingIcon = null;
            this.tbShiftRz.Location = new System.Drawing.Point(53, 123);
            this.tbShiftRz.MaxLength = 32767;
            this.tbShiftRz.MouseState = MaterialSkin.MouseState.OUT;
            this.tbShiftRz.Name = "tbShiftRz";
            this.tbShiftRz.PasswordChar = '\0';
            this.tbShiftRz.PrefixSuffixText = null;
            this.tbShiftRz.ReadOnly = false;
            this.tbShiftRz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbShiftRz.SelectedText = "";
            this.tbShiftRz.SelectionLength = 0;
            this.tbShiftRz.SelectionStart = 0;
            this.tbShiftRz.ShortcutsEnabled = true;
            this.tbShiftRz.Size = new System.Drawing.Size(132, 26);
            this.tbShiftRz.TabIndex = 181;
            this.tbShiftRz.TabStop = false;
            this.tbShiftRz.Text = "2";
            this.tbShiftRz.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbShiftRz.TrailingIcon = null;
            this.tbShiftRz.UseSystemPasswordChar = false;
            this.tbShiftRz.UseTallSize = false;
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel17.Location = new System.Drawing.Point(5, 124);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(19, 18);
            this.materialLabel17.TabIndex = 180;
            this.materialLabel17.Text = "Rz";
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
            this.btnWriteShiftPose_.Location = new System.Drawing.Point(129, 34);
            this.btnWriteShiftPose_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnWriteShiftPose_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnWriteShiftPose_.Name = "btnWriteShiftPose_";
            this.btnWriteShiftPose_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnWriteShiftPose_.Size = new System.Drawing.Size(57, 26);
            this.btnWriteShiftPose_.TabIndex = 179;
            this.btnWriteShiftPose_.Text = "WRITE";
            this.btnWriteShiftPose_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnWriteShiftPose_.UseAccentColor = false;
            this.btnWriteShiftPose_.UseVisualStyleBackColor = false;
            this.btnWriteShiftPose_.Click += new System.EventHandler(this.btnWriteShiftPose_Click);
            // 
            // tbShiftTx
            // 
            this.tbShiftTx.AnimateReadOnly = false;
            this.tbShiftTx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbShiftTx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbShiftTx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbShiftTx.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbShiftTx.Depth = 0;
            this.tbShiftTx.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbShiftTx.HideSelection = true;
            this.tbShiftTx.LeadingIcon = null;
            this.tbShiftTx.Location = new System.Drawing.Point(53, 68);
            this.tbShiftTx.MaxLength = 32767;
            this.tbShiftTx.MouseState = MaterialSkin.MouseState.OUT;
            this.tbShiftTx.Name = "tbShiftTx";
            this.tbShiftTx.PasswordChar = '\0';
            this.tbShiftTx.PrefixSuffixText = null;
            this.tbShiftTx.ReadOnly = false;
            this.tbShiftTx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbShiftTx.SelectedText = "";
            this.tbShiftTx.SelectionLength = 0;
            this.tbShiftTx.SelectionStart = 0;
            this.tbShiftTx.ShortcutsEnabled = true;
            this.tbShiftTx.Size = new System.Drawing.Size(132, 26);
            this.tbShiftTx.TabIndex = 6;
            this.tbShiftTx.TabStop = false;
            this.tbShiftTx.Text = "1";
            this.tbShiftTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbShiftTx.TrailingIcon = null;
            this.tbShiftTx.UseSystemPasswordChar = false;
            this.tbShiftTx.UseTallSize = false;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(5, 71);
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
            this.materialLabel20.Location = new System.Drawing.Point(6, 37);
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
            this.materialLabel15.Location = new System.Drawing.Point(6, 11);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(128, 18);
            this.materialLabel15.TabIndex = 7;
            this.materialLabel15.Text = "VISION -> ROBOT";
            // 
            // lblShiftPoseRxyz_
            // 
            this.lblShiftPoseRxyz_.AutoSize = true;
            this.lblShiftPoseRxyz_.BackColor = System.Drawing.Color.Transparent;
            this.lblShiftPoseRxyz_.Depth = 0;
            this.lblShiftPoseRxyz_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblShiftPoseRxyz_.Location = new System.Drawing.Point(5, 99);
            this.lblShiftPoseRxyz_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblShiftPoseRxyz_.Name = "lblShiftPoseRxyz_";
            this.lblShiftPoseRxyz_.Size = new System.Drawing.Size(19, 18);
            this.lblShiftPoseRxyz_.TabIndex = 8;
            this.lblShiftPoseRxyz_.Text = "Ty";
            // 
            // tbShiftTy
            // 
            this.tbShiftTy.AnimateReadOnly = false;
            this.tbShiftTy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbShiftTy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbShiftTy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbShiftTy.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbShiftTy.Depth = 0;
            this.tbShiftTy.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbShiftTy.HideSelection = true;
            this.tbShiftTy.LeadingIcon = null;
            this.tbShiftTy.Location = new System.Drawing.Point(53, 96);
            this.tbShiftTy.MaxLength = 32767;
            this.tbShiftTy.MouseState = MaterialSkin.MouseState.OUT;
            this.tbShiftTy.Name = "tbShiftTy";
            this.tbShiftTy.PasswordChar = '\0';
            this.tbShiftTy.PrefixSuffixText = null;
            this.tbShiftTy.ReadOnly = false;
            this.tbShiftTy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbShiftTy.SelectedText = "";
            this.tbShiftTy.SelectionLength = 0;
            this.tbShiftTy.SelectionStart = 0;
            this.tbShiftTy.ShortcutsEnabled = true;
            this.tbShiftTy.Size = new System.Drawing.Size(132, 26);
            this.tbShiftTy.TabIndex = 13;
            this.tbShiftTy.TabStop = false;
            this.tbShiftTy.Text = "2";
            this.tbShiftTy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbShiftTy.TrailingIcon = null;
            this.tbShiftTy.UseSystemPasswordChar = false;
            this.tbShiftTy.UseTallSize = false;
            // 
            // btnScanPoint_
            // 
            this.btnScanPoint_.AutoSize = false;
            this.btnScanPoint_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnScanPoint_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(215)))), ((int)(((byte)(73)))));
            this.btnScanPoint_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnScanPoint_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnScanPoint_.Depth = 0;
            this.btnScanPoint_.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnScanPoint_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanPoint_.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnScanPoint_.HighEmphasis = true;
            this.btnScanPoint_.Icon = null;
            this.btnScanPoint_.Location = new System.Drawing.Point(25, 247);
            this.btnScanPoint_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnScanPoint_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnScanPoint_.Name = "btnScanPoint_";
            this.btnScanPoint_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnScanPoint_.Size = new System.Drawing.Size(325, 87);
            this.btnScanPoint_.TabIndex = 22;
            this.btnScanPoint_.Text = "Scan Point";
            this.btnScanPoint_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnScanPoint_.UseAccentColor = false;
            this.btnScanPoint_.UseVisualStyleBackColor = false;
            this.btnScanPoint_.Click += new System.EventHandler(this.btnScanPoint__Click);
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
            // pbOk
            // 
            this.pbOk.BackColor = System.Drawing.Color.LightGray;
            this.pbOk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOk.Image = ((System.Drawing.Image)(resources.GetObject("pbOk.Image")));
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
            this.pbNg.Image = ((System.Drawing.Image)(resources.GetObject("pbNg.Image")));
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
            this.splitContainer3.Size = new System.Drawing.Size(582, 925);
            this.splitContainer3.SplitterDistance = 798;
            this.splitContainer3.TabIndex = 98;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.IsSplitterFixed = true;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.panel1);
            this.splitContainer5.Panel1.Controls.Add(this.btnNgListClear_);
            this.splitContainer5.Panel1MinSize = 41;
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.rtbLog);
            this.splitContainer5.Size = new System.Drawing.Size(582, 798);
            this.splitContainer5.SplitterDistance = 264;
            this.splitContainer5.SplitterWidth = 1;
            this.splitContainer5.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvNgList);
            this.panel1.Location = new System.Drawing.Point(3, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 216);
            this.panel1.TabIndex = 100;
            // 
            // dgvNgList
            // 
            this.dgvNgList.BackgroundColor = System.Drawing.Color.White;
            this.dgvNgList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNgList.Location = new System.Drawing.Point(0, 0);
            this.dgvNgList.Name = "dgvNgList";
            this.dgvNgList.ReadOnly = true;
            this.dgvNgList.RowTemplate.Height = 23;
            this.dgvNgList.Size = new System.Drawing.Size(576, 216);
            this.dgvNgList.TabIndex = 1;
            this.dgvNgList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNgList_CellDoubleClick);
            this.dgvNgList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvNgList_DataBindingComplete);
            this.dgvNgList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvNgList_KeyDown);
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
            this.btnNgListClear_.Location = new System.Drawing.Point(448, 7);
            this.btnNgListClear_.Margin = new System.Windows.Forms.Padding(0);
            this.btnNgListClear_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNgListClear_.Name = "btnNgListClear_";
            this.btnNgListClear_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNgListClear_.Size = new System.Drawing.Size(128, 36);
            this.btnNgListClear_.TabIndex = 99;
            this.btnNgListClear_.Text = "Ng Log Reset";
            this.btnNgListClear_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNgListClear_.UseAccentColor = false;
            this.btnNgListClear_.UseVisualStyleBackColor = false;
            this.btnNgListClear_.Click += new System.EventHandler(this.btnNgListClear__Click);
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.Depth = 0;
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rtbLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtbLog.Location = new System.Drawing.Point(0, 0);
            this.rtbLog.Margin = new System.Windows.Forms.Padding(0);
            this.rtbLog.MouseState = MaterialSkin.MouseState.HOVER;
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(582, 533);
            this.rtbLog.TabIndex = 51;
            this.rtbLog.Text = "";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(582, 123);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 98;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(582, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 97;
            this.pictureBox2.TabStop = false;
            // 
            // btnGlassBackUp_
            // 
            this.btnGlassBackUp_.AutoSize = false;
            this.btnGlassBackUp_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGlassBackUp_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnGlassBackUp_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGlassBackUp_.Depth = 0;
            this.btnGlassBackUp_.HighEmphasis = true;
            this.btnGlassBackUp_.Icon = null;
            this.btnGlassBackUp_.Location = new System.Drawing.Point(0, 0);
            this.btnGlassBackUp_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGlassBackUp_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGlassBackUp_.Name = "btnGlassBackUp_";
            this.btnGlassBackUp_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGlassBackUp_.Size = new System.Drawing.Size(75, 36);
            this.btnGlassBackUp_.TabIndex = 0;
            this.btnGlassBackUp_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGlassBackUp_.UseAccentColor = false;
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
            this.lblGlassRHCamera_.Location = new System.Drawing.Point(0, 0);
            this.lblGlassRHCamera_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lblGlassRHCamera_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGlassRHCamera_.Name = "lblGlassRHCamera_";
            this.lblGlassRHCamera_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.lblGlassRHCamera_.Size = new System.Drawing.Size(75, 36);
            this.lblGlassRHCamera_.TabIndex = 0;
            this.lblGlassRHCamera_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.lblGlassRHCamera_.UseAccentColor = false;
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
            this.lblGlassLHCamera_.Location = new System.Drawing.Point(0, 0);
            this.lblGlassLHCamera_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lblGlassLHCamera_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGlassLHCamera_.Name = "lblGlassLHCamera_";
            this.lblGlassLHCamera_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.lblGlassLHCamera_.Size = new System.Drawing.Size(75, 36);
            this.lblGlassLHCamera_.TabIndex = 0;
            this.lblGlassLHCamera_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.lblGlassLHCamera_.UseAccentColor = false;
            // 
            // btnGlassRHCameraUnuse_
            // 
            this.btnGlassRHCameraUnuse_.AutoSize = false;
            this.btnGlassRHCameraUnuse_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGlassRHCameraUnuse_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnGlassRHCameraUnuse_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGlassRHCameraUnuse_.Depth = 0;
            this.btnGlassRHCameraUnuse_.HighEmphasis = true;
            this.btnGlassRHCameraUnuse_.Icon = null;
            this.btnGlassRHCameraUnuse_.Location = new System.Drawing.Point(0, 0);
            this.btnGlassRHCameraUnuse_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGlassRHCameraUnuse_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGlassRHCameraUnuse_.Name = "btnGlassRHCameraUnuse_";
            this.btnGlassRHCameraUnuse_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGlassRHCameraUnuse_.Size = new System.Drawing.Size(75, 36);
            this.btnGlassRHCameraUnuse_.TabIndex = 0;
            this.btnGlassRHCameraUnuse_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGlassRHCameraUnuse_.UseAccentColor = false;
            // 
            // btnGlassRHCameraUse_
            // 
            this.btnGlassRHCameraUse_.AutoSize = false;
            this.btnGlassRHCameraUse_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGlassRHCameraUse_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnGlassRHCameraUse_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGlassRHCameraUse_.Depth = 0;
            this.btnGlassRHCameraUse_.HighEmphasis = true;
            this.btnGlassRHCameraUse_.Icon = null;
            this.btnGlassRHCameraUse_.Location = new System.Drawing.Point(0, 0);
            this.btnGlassRHCameraUse_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGlassRHCameraUse_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGlassRHCameraUse_.Name = "btnGlassRHCameraUse_";
            this.btnGlassRHCameraUse_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGlassRHCameraUse_.Size = new System.Drawing.Size(75, 36);
            this.btnGlassRHCameraUse_.TabIndex = 0;
            this.btnGlassRHCameraUse_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGlassRHCameraUse_.UseAccentColor = false;
            // 
            // btnGlassLHCameraUnuse_
            // 
            this.btnGlassLHCameraUnuse_.AutoSize = false;
            this.btnGlassLHCameraUnuse_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGlassLHCameraUnuse_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnGlassLHCameraUnuse_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGlassLHCameraUnuse_.Depth = 0;
            this.btnGlassLHCameraUnuse_.HighEmphasis = true;
            this.btnGlassLHCameraUnuse_.Icon = null;
            this.btnGlassLHCameraUnuse_.Location = new System.Drawing.Point(0, 0);
            this.btnGlassLHCameraUnuse_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGlassLHCameraUnuse_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGlassLHCameraUnuse_.Name = "btnGlassLHCameraUnuse_";
            this.btnGlassLHCameraUnuse_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGlassLHCameraUnuse_.Size = new System.Drawing.Size(75, 36);
            this.btnGlassLHCameraUnuse_.TabIndex = 0;
            this.btnGlassLHCameraUnuse_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGlassLHCameraUnuse_.UseAccentColor = false;
            // 
            // btnGlassLHCameraUse_
            // 
            this.btnGlassLHCameraUse_.AutoSize = false;
            this.btnGlassLHCameraUse_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGlassLHCameraUse_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnGlassLHCameraUse_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGlassLHCameraUse_.Depth = 0;
            this.btnGlassLHCameraUse_.HighEmphasis = true;
            this.btnGlassLHCameraUse_.Icon = null;
            this.btnGlassLHCameraUse_.Location = new System.Drawing.Point(0, 0);
            this.btnGlassLHCameraUse_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGlassLHCameraUse_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGlassLHCameraUse_.Name = "btnGlassLHCameraUse_";
            this.btnGlassLHCameraUse_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGlassLHCameraUse_.Size = new System.Drawing.Size(75, 36);
            this.btnGlassLHCameraUse_.TabIndex = 0;
            this.btnGlassLHCameraUse_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGlassLHCameraUse_.UseAccentColor = false;
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
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "yml";
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "YAML(*.yml;*.yaml)|*.yml;*.yaml|All files|*.*";
            this.openFileDialog.ShowHelp = true;
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
            this.gbMode.TabIndex = 2;
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
            this.rbManual_.TabIndex = 1;
            this.rbManual_.TabStop = true;
            this.rbManual_.Text = "Manual";
            this.rbManual_.UseVisualStyleBackColor = true;
            this.rbManual_.CheckedChanged += new System.EventHandler(this.rbMode_CheckedChanged);
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
            this.rbSet_.TabIndex = 2;
            this.rbSet_.TabStop = true;
            this.rbSet_.Text = "Setting";
            this.rbSet_.UseVisualStyleBackColor = true;
            this.rbSet_.CheckedChanged += new System.EventHandler(this.rbMode_CheckedChanged);
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
            this.rbAuto_.CheckedChanged += new System.EventHandler(this.rbMode_CheckedChanged);
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
            // btnCaptureCheckerBoard_
            // 
            this.btnCaptureCheckerBoard_.AutoSize = false;
            this.btnCaptureCheckerBoard_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCaptureCheckerBoard_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(65)))));
            this.btnCaptureCheckerBoard_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnCaptureCheckerBoard_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCaptureCheckerBoard_.Depth = 0;
            this.btnCaptureCheckerBoard_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaptureCheckerBoard_.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnCaptureCheckerBoard_.HighEmphasis = true;
            this.btnCaptureCheckerBoard_.Icon = null;
            this.btnCaptureCheckerBoard_.Location = new System.Drawing.Point(358, 33);
            this.btnCaptureCheckerBoard_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCaptureCheckerBoard_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCaptureCheckerBoard_.Name = "btnCaptureCheckerBoard_";
            this.btnCaptureCheckerBoard_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCaptureCheckerBoard_.Size = new System.Drawing.Size(325, 93);
            this.btnCaptureCheckerBoard_.TabIndex = 185;
            this.btnCaptureCheckerBoard_.Text = "Save Master CheckerBoard";
            this.btnCaptureCheckerBoard_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCaptureCheckerBoard_.UseAccentColor = false;
            this.btnCaptureCheckerBoard_.UseVisualStyleBackColor = false;
            this.btnCaptureCheckerBoard_.Visible = false;
            this.btnCaptureCheckerBoard_.Click += new System.EventHandler(this.btnCaptureCheckerBoard__Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1061);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Consolas", 9F);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "적재함 2D 보정 프로그램";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.materialCard15.ResumeLayout(false);
            this.materialCard15.PerformLayout();
            this.materialCard14.ResumeLayout(false);
            this.materialCard14.PerformLayout();
            this.materialCard6.ResumeLayout(false);
            this.gbRobotReadComputed.ResumeLayout(false);
            this.gbRobotReadComputed.PerformLayout();
            this.gbRobotRead.ResumeLayout(false);
            this.gbRobotRead.PerformLayout();
            this.gbRobotWrite.ResumeLayout(false);
            this.gbRobotWrite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOk)).EndInit();
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbNg)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNgList)).EndInit();
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
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private MaterialSkin.Controls.MaterialMultiLineTextBox rtbLog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
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
        private CoPick.Controls.PlcSignalStatusValueTable carTypeSignalStatus;
        private CoPick.Controls.PlcSignalStatusValueTable glassWriteSignal2Status;
        private CoPick.Controls.PlcSignalStatusOnlyTable glassWriteSignalStatus;
        private CoPick.Controls.PlcSignalStatusOnlyTable glassReadSignalStatus;
        private PictureBox pictureBox4;
        private PictureBox pbOk;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private CoPick.Controls.PlcSignalStatusOnlyTable plcSignalStatusOnlyTable1;
        private CoPick.Controls.PlcSignalStatusValueTable plcSignalStatusValueTable1;
        private PictureBox pbNg;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private CoPick.Controls.PlcSignalStatusOnlyTable plcSignalStatusOnlyTable2;
        private CoPick.Controls.PlcSignalStatusValueTable plcSignalStatusValueTable2;
        private MaterialSkin.Controls.MaterialButton btnGlassBackUp_;
        private MaterialSkin.Controls.MaterialButton lblGlassRHCamera_;
        private MaterialSkin.Controls.MaterialButton lblGlassLHCamera_;
        private MaterialSkin.Controls.MaterialButton btnGlassRHCameraUnuse_;
        private MaterialSkin.Controls.MaterialButton btnGlassRHCameraUse_;
        private MaterialSkin.Controls.MaterialButton btnGlassLHCameraUnuse_;
        private MaterialSkin.Controls.MaterialButton btnGlassLHCameraUse_;
        private MaterialSkin.Controls.MaterialButton btnScanPoint_;
        private PictureBox pbRh;
        private PictureBox pbLh;
        private MaterialSkin.Controls.MaterialTextBox2 tbCarBodyNumber;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialLabel lblPlc;
        private MaterialSkin.Controls.MaterialButton btnSettingManage_;
        private MaterialSkin.Controls.MaterialCard materialCard15;
        private MaterialSkin.Controls.MaterialLabel lblRH_;
        private MaterialSkin.Controls.MaterialCard materialCard14;
        private MaterialSkin.Controls.MaterialLabel lblLH_;
        private MaterialSkin.Controls.MaterialCard gbRobotWrite;
        private MaterialSkin.Controls.MaterialButton btnWriteShiftPose_;
        private MaterialSkin.Controls.MaterialTextBox2 tbShiftTx;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel lblShiftPoseRxyz_;
        private MaterialSkin.Controls.MaterialTextBox2 tbShiftTy;
        private MaterialSkin.Controls.MaterialCard gbRobotRead;
        private MaterialSkin.Controls.MaterialTextBox2 tbReadInstallPoseTxyz;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialTextBox2 tbReadInstallPoseRxyz;
        private MaterialSkin.Controls.MaterialTextBox2 tbReadScanPoseTxyz;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialTextBox2 tbReadScanPoseRxyz;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialButton btnReadScanPose_;
        private MaterialSkin.Controls.MaterialTextBox2 tbCurrRobotTz;
        private MaterialSkin.Controls.MaterialTextBox2 tbCurrRobotRx;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private Panel panel1;
        private DataGridView dgvNgList;
        private MaterialSkin.Controls.MaterialTextBox2 tbShiftRz;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialCard gbRobotReadComputed;
        private MaterialSkin.Controls.MaterialLabel materialLabel22;
        private MaterialSkin.Controls.MaterialLabel materialLabel23;
        private MaterialSkin.Controls.MaterialLabel materialLabel28;
        private MaterialSkin.Controls.MaterialLabel materialLabel29;
        private MaterialSkin.Controls.MaterialTextBox2 tbWrittenRxyz_;
        private MaterialSkin.Controls.MaterialButton btnReadWrittenShiftPose_;
        private MaterialSkin.Controls.MaterialTextBox2 tbWrittenTxyz_;
        private MaterialSkin.Controls.MaterialButton btnUpdateMasterScanPose_;
        private MaterialSkin.Controls.MaterialButton btnUpdateMasterInstallPose_;
        private MaterialSkin.Controls.MaterialButton btnCaptureCheckerBoard_;
    }
}

