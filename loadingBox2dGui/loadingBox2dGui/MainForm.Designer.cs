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
            this.tbPlc = new MaterialSkin.Controls.MaterialTextBox2();
            this.gbCarType = new MaterialSkin.Controls.MaterialCard();
            this.tbCarType = new MaterialSkin.Controls.MaterialTextBox2();
            this.cmbCarTypeName = new MaterialSkin.Controls.MaterialComboBox();
            this.btnCameraConnect_ = new MaterialSkin.Controls.MaterialButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbCarSeqNumber_ = new MaterialSkin.Controls.MaterialCard();
            this.tbCarSeqNumber = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnSettingManager_ = new MaterialSkin.Controls.MaterialButton();
            this.label22 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.plcSignalStatusOnlyTable1 = new CoPick.Controls.PlcSignalStatusOnlyTable();
            this.plcSignalStatusValueTable1 = new CoPick.Controls.PlcSignalStatusValueTable();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
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
            this.btnGlassPoint_ = new MaterialSkin.Controls.MaterialButton();
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
            this.pbLh = new System.Windows.Forms.PictureBox();
            this.pbRh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbMode.SuspendLayout();
            this.gbPLC.SuspendLayout();
            this.gbCarType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbCarSeqNumber_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.materialCard4.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.tlpGlassCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.gbGlassUserControl_.SuspendLayout();
            this.gbGlassShiftValue_.SuspendLayout();
            this.gbGlassPoint_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRh)).BeginInit();
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
            this.splitContainer2.Panel1.Controls.Add(this.pbRh);
            this.splitContainer2.Panel1.Controls.Add(this.pbLh);
            this.splitContainer2.Panel1.Controls.Add(this.materialCard4);
            this.splitContainer2.Panel1.Controls.Add(this.materialCard3);
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer2.Panel1.Controls.Add(this.materialCard1);
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox3);
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
            this.splitContainer2.Size = new System.Drawing.Size(1920, 992);
            this.splitContainer2.SplitterDistance = 1336;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 107;
            this.splitContainer2.TabStop = false;
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
            this.tbGlassMaxValueRz.Font = new System.Drawing.Font("NanumSquareRound Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.label90.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.tbGlassMaxValueTy.Font = new System.Drawing.Font("NanumSquareRound Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.label94.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.tbGlassMaxValueTx.Font = new System.Drawing.Font("NanumSquareRound Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.label95.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.label92.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.textBox1.Font = new System.Drawing.Font("NanumSquareRound Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.lblGlassCameraModel_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGlassCameraModel_.Location = new System.Drawing.Point(0, 0);
            this.lblGlassCameraModel_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGlassCameraModel_.Name = "lblGlassCameraModel_";
            this.lblGlassCameraModel_.Size = new System.Drawing.Size(100, 23);
            this.lblGlassCameraModel_.TabIndex = 0;
            // 
            // lblGlassCameraSerials_
            // 
            this.lblGlassCameraSerials_.Depth = 0;
            this.lblGlassCameraSerials_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.tbGlassCamera.Font = new System.Drawing.Font("NanumSquareRound Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.lblGlassCamera_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.tbGlassCameraModel.Font = new System.Drawing.Font("NanumSquareRound Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.gbMode.Location = new System.Drawing.Point(8, 7);
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
            this.rbManual_.Location = new System.Drawing.Point(99, 12);
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
            // 
            // rbSet_
            // 
            this.rbSet_.AutoSize = true;
            this.rbSet_.Checked = true;
            this.rbSet_.Depth = 0;
            this.rbSet_.Font = new System.Drawing.Font("Consolas", 12F);
            this.rbSet_.Location = new System.Drawing.Point(193, 12);
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
            // 
            // rbAuto_
            // 
            this.rbAuto_.AutoSize = true;
            this.rbAuto_.Depth = 0;
            this.rbAuto_.Font = new System.Drawing.Font("Consolas", 12F);
            this.rbAuto_.Location = new System.Drawing.Point(9, 12);
            this.rbAuto_.Margin = new System.Windows.Forms.Padding(0);
            this.rbAuto_.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbAuto_.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbAuto_.Name = "rbAuto_";
            this.rbAuto_.Ripple = true;
            this.rbAuto_.Size = new System.Drawing.Size(72, 37);
            this.rbAuto_.TabIndex = 0;
            this.rbAuto_.Text = "Auto";
            this.rbAuto_.UseVisualStyleBackColor = true;
            // 
            // gbPLC
            // 
            this.gbPLC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbPLC.Controls.Add(this.tbPlc);
            this.gbPLC.Depth = 0;
            this.gbPLC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbPLC.Location = new System.Drawing.Point(310, 7);
            this.gbPLC.Margin = new System.Windows.Forms.Padding(14);
            this.gbPLC.MouseState = MaterialSkin.MouseState.HOVER;
            this.gbPLC.Name = "gbPLC";
            this.gbPLC.Padding = new System.Windows.Forms.Padding(14);
            this.gbPLC.Size = new System.Drawing.Size(299, 62);
            this.gbPLC.TabIndex = 27;
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
            this.tbPlc.Location = new System.Drawing.Point(127, 9);
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
            this.tbPlc.Size = new System.Drawing.Size(166, 48);
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
            this.gbCarType.Location = new System.Drawing.Point(615, 7);
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
            this.tbCarType.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.btnCameraConnect_.Location = new System.Drawing.Point(1534, 18);
            this.btnCameraConnect_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCameraConnect_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCameraConnect_.Name = "btnCameraConnect_";
            this.btnCameraConnect_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCameraConnect_.Size = new System.Drawing.Size(177, 33);
            this.btnCameraConnect_.TabIndex = 106;
            this.btnCameraConnect_.Text = "Camera Connect";
            this.btnCameraConnect_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCameraConnect_.UseAccentColor = false;
            this.btnCameraConnect_.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.gbCarSeqNumber_);
            this.splitContainer1.Panel1.Controls.Add(this.gbPLC);
            this.splitContainer1.Panel1.Controls.Add(this.btnCameraConnect_);
            this.splitContainer1.Panel1.Controls.Add(this.btnSettingManager_);
            this.splitContainer1.Panel1.Controls.Add(this.gbMode);
            this.splitContainer1.Panel1.Controls.Add(this.gbCarType);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1920, 1061);
            this.splitContainer1.SplitterDistance = 68;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 106;
            this.splitContainer1.TabStop = false;
            // 
            // gbCarSeqNumber_
            // 
            this.gbCarSeqNumber_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbCarSeqNumber_.Controls.Add(this.tbCarSeqNumber);
            this.gbCarSeqNumber_.Depth = 0;
            this.gbCarSeqNumber_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbCarSeqNumber_.Location = new System.Drawing.Point(936, 7);
            this.gbCarSeqNumber_.Margin = new System.Windows.Forms.Padding(14);
            this.gbCarSeqNumber_.MouseState = MaterialSkin.MouseState.HOVER;
            this.gbCarSeqNumber_.Name = "gbCarSeqNumber_";
            this.gbCarSeqNumber_.Padding = new System.Windows.Forms.Padding(14);
            this.gbCarSeqNumber_.Size = new System.Drawing.Size(150, 62);
            this.gbCarSeqNumber_.TabIndex = 107;
            this.gbCarSeqNumber_.Visible = false;
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
            // btnSettingManager_
            // 
            this.btnSettingManager_.AutoSize = false;
            this.btnSettingManager_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSettingManager_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(65)))));
            this.btnSettingManager_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnSettingManager_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSettingManager_.Depth = 0;
            this.btnSettingManager_.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSettingManager_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingManager_.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnSettingManager_.ForeColor = System.Drawing.Color.Black;
            this.btnSettingManager_.HighEmphasis = true;
            this.btnSettingManager_.Icon = null;
            this.btnSettingManager_.Location = new System.Drawing.Point(1717, 18);
            this.btnSettingManager_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSettingManager_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSettingManager_.Name = "btnSettingManager_";
            this.btnSettingManager_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSettingManager_.Size = new System.Drawing.Size(181, 33);
            this.btnSettingManager_.TabIndex = 3;
            this.btnSettingManager_.Text = "Setting Manager";
            this.btnSettingManager_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSettingManager_.UseAccentColor = false;
            this.btnSettingManager_.UseVisualStyleBackColor = false;
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1110, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 190;
            this.pictureBox1.TabStop = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.plcSignalStatusOnlyTable1);
            this.materialCard1.Controls.Add(this.plcSignalStatusValueTable1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(1111, 612);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialCard1.Size = new System.Drawing.Size(223, 326);
            this.materialCard1.TabIndex = 187;
            // 
            // plcSignalStatusOnlyTable1
            // 
            this.plcSignalStatusOnlyTable1.Location = new System.Drawing.Point(10, 12);
            this.plcSignalStatusOnlyTable1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plcSignalStatusOnlyTable1.Name = "plcSignalStatusOnlyTable1";
            this.plcSignalStatusOnlyTable1.RowCount = 5;
            this.plcSignalStatusOnlyTable1.RowHeight = 23;
            this.plcSignalStatusOnlyTable1.Size = new System.Drawing.Size(203, 121);
            this.plcSignalStatusOnlyTable1.TabIndex = 1;
            // 
            // plcSignalStatusValueTable1
            // 
            this.plcSignalStatusValueTable1.ColumnWidth1 = 135;
            this.plcSignalStatusValueTable1.ColumnWidth2 = 65;
            this.plcSignalStatusValueTable1.Location = new System.Drawing.Point(10, 152);
            this.plcSignalStatusValueTable1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plcSignalStatusValueTable1.Name = "plcSignalStatusValueTable1";
            this.plcSignalStatusValueTable1.RowCount = 6;
            this.plcSignalStatusValueTable1.RowHeight = 23;
            this.plcSignalStatusValueTable1.Size = new System.Drawing.Size(203, 145);
            this.plcSignalStatusValueTable1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(1110, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(223, 124);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 189;
            this.pictureBox3.TabStop = false;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.plcSignalStatusOnlyTable2);
            this.materialCard2.Controls.Add(this.plcSignalStatusValueTable2);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(1110, 256);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialCard2.Size = new System.Drawing.Size(223, 352);
            this.materialCard2.TabIndex = 188;
            // 
            // plcSignalStatusOnlyTable2
            // 
            this.plcSignalStatusOnlyTable2.Location = new System.Drawing.Point(10, 10);
            this.plcSignalStatusOnlyTable2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plcSignalStatusOnlyTable2.Name = "plcSignalStatusOnlyTable2";
            this.plcSignalStatusOnlyTable2.RowCount = 6;
            this.plcSignalStatusOnlyTable2.RowHeight = 23;
            this.plcSignalStatusOnlyTable2.Size = new System.Drawing.Size(203, 145);
            this.plcSignalStatusOnlyTable2.TabIndex = 108;
            // 
            // plcSignalStatusValueTable2
            // 
            this.plcSignalStatusValueTable2.ColumnWidth1 = 135;
            this.plcSignalStatusValueTable2.ColumnWidth2 = 65;
            this.plcSignalStatusValueTable2.Location = new System.Drawing.Point(10, 166);
            this.plcSignalStatusValueTable2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plcSignalStatusValueTable2.Name = "plcSignalStatusValueTable2";
            this.plcSignalStatusValueTable2.RowCount = 7;
            this.plcSignalStatusValueTable2.RowHeight = 23;
            this.plcSignalStatusValueTable2.Size = new System.Drawing.Size(203, 169);
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
            this.gbGlassPoint_.Controls.Add(this.btnGlassPoint_);
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
            // 
            // btnGlassPoint_
            // 
            this.btnGlassPoint_.AutoSize = false;
            this.btnGlassPoint_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGlassPoint_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(215)))), ((int)(((byte)(73)))));
            this.btnGlassPoint_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnGlassPoint_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGlassPoint_.Depth = 0;
            this.btnGlassPoint_.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnGlassPoint_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlassPoint_.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnGlassPoint_.HighEmphasis = true;
            this.btnGlassPoint_.Icon = null;
            this.btnGlassPoint_.Location = new System.Drawing.Point(8, 31);
            this.btnGlassPoint_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGlassPoint_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGlassPoint_.Name = "btnGlassPoint_";
            this.btnGlassPoint_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGlassPoint_.Size = new System.Drawing.Size(66, 73);
            this.btnGlassPoint_.TabIndex = 22;
            this.btnGlassPoint_.Text = "Point Scan";
            this.btnGlassPoint_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGlassPoint_.UseAccentColor = false;
            this.btnGlassPoint_.UseVisualStyleBackColor = false;
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
            // pbLh
            // 
            this.pbLh.Location = new System.Drawing.Point(8, 5);
            this.pbLh.Name = "pbLh";
            this.pbLh.Size = new System.Drawing.Size(542, 532);
            this.pbLh.TabIndex = 193;
            this.pbLh.TabStop = false;
            // 
            // pbRh
            // 
            this.pbRh.Location = new System.Drawing.Point(561, 5);
            this.pbRh.Name = "pbRh";
            this.pbRh.Size = new System.Drawing.Size(542, 532);
            this.pbRh.TabIndex = 193;
            this.pbRh.TabStop = false;
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
            this.Text = "2D Loding Box Inspection System";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            this.gbPLC.ResumeLayout(false);
            this.gbCarType.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbCarSeqNumber_.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.tlpGlassCamera.ResumeLayout(false);
            this.tlpGlassCamera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.gbGlassUserControl_.ResumeLayout(false);
            this.gbGlassShiftValue_.ResumeLayout(false);
            this.gbGlassShiftValue_.PerformLayout();
            this.gbGlassPoint_.ResumeLayout(false);
            this.gbGlassPoint_.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRh)).EndInit();
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
        private MaterialSkin.Controls.MaterialButton btnSettingManager_;
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
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private CoPick.Controls.PlcSignalStatusOnlyTable plcSignalStatusOnlyTable1;
        private CoPick.Controls.PlcSignalStatusValueTable plcSignalStatusValueTable1;
        private PictureBox pictureBox3;
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
        private MaterialSkin.Controls.MaterialButton btnGlassPoint_;
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
    }
}

