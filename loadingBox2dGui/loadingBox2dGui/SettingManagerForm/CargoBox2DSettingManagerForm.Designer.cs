using System.Windows.Forms;

namespace loadingBox2dGui
{
    partial class CargoBox2DSettingManagerForm_
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ctxtMenuCameraDel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem_ = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem_ = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SettingManagerTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.ConfigDict_ = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gbRootFolderPaths_ = new MaterialSkin.Controls.MaterialCard();
            this.btnCameraTcpFilePath = new MaterialSkin.Controls.MaterialButton();
            this.tbCameraTcpFilePath = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblCameraTcp = new MaterialSkin.Controls.MaterialLabel();
            this.btnCalibrationRootFolderPath_ = new MaterialSkin.Controls.MaterialButton();
            this.tbCalibrationRootFolderPath = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblCalibrationRootFolderPath_ = new MaterialSkin.Controls.MaterialLabel();
            this.tbMasterImageRootPath = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbCheckerBoardRootPath = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblMasterImageFilePath = new MaterialSkin.Controls.MaterialLabel();
            this.lblCharucoFilePath = new MaterialSkin.Controls.MaterialLabel();
            this.lblImageRootFolderPath_ = new MaterialSkin.Controls.MaterialLabel();
            this.btnMasterImageFilePath = new MaterialSkin.Controls.MaterialButton();
            this.btnCharucoFilePath = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.cmbRobot_ = new MaterialSkin.Controls.MaterialComboBox();
            this.lblRobot_ = new MaterialSkin.Controls.MaterialLabel();
            this.gbModelFilePath_ = new MaterialSkin.Controls.MaterialCard();
            this.tbModelPath = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblShiftModel_ = new MaterialSkin.Controls.MaterialLabel();
            this.lblModelFilePaths_ = new MaterialSkin.Controls.MaterialLabel();
            this.btnModelPath = new MaterialSkin.Controls.MaterialButton();
            this.cardCamera = new MaterialSkin.Controls.MaterialCard();
            this.cmbLight = new MaterialSkin.Controls.MaterialComboBox();
            this.lblLight_ = new MaterialSkin.Controls.MaterialLabel();
            this.lblCamera_ = new MaterialSkin.Controls.MaterialLabel();
            this.cmbCamera = new MaterialSkin.Controls.MaterialComboBox();
            this.cardCarType = new MaterialSkin.Controls.MaterialCard();
            this.tbCarType = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnCopyCarType_ = new MaterialSkin.Controls.MaterialButton();
            this.btnRemoveCarType_ = new MaterialSkin.Controls.MaterialButton();
            this.btnAddCarType_ = new MaterialSkin.Controls.MaterialButton();
            this.lblCarType_ = new MaterialSkin.Controls.MaterialLabel();
            this.cmbCarType = new MaterialSkin.Controls.MaterialComboBox();
            this.cardPlc = new MaterialSkin.Controls.MaterialCard();
            this.cmbPlc = new MaterialSkin.Controls.MaterialComboBox();
            this.lblPlc_ = new MaterialSkin.Controls.MaterialLabel();
            this.taskGrid = new System.Windows.Forms.PropertyGrid();
            this.RobotConfig_ = new System.Windows.Forms.TabPage();
            this.Cam2DConfigs_ = new System.Windows.Forms.TabPage();
            this.LightConfigs_ = new System.Windows.Forms.TabPage();
            this.PlcConfigs_ = new System.Windows.Forms.TabPage();
            this.Logging_ = new System.Windows.Forms.TabPage();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.btnDeleteSchedule_ = new MaterialSkin.Controls.MaterialButton();
            this.btnRegisterSchedule_ = new MaterialSkin.Controls.MaterialButton();
            this.lblCsvLastingPeriod_ = new MaterialSkin.Controls.MaterialLabel();
            this.lblImgLastingPeriod_ = new MaterialSkin.Controls.MaterialLabel();
            this.lblLogLastingPeriod_ = new MaterialSkin.Controls.MaterialLabel();
            this.lblScheduleStartTime_ = new MaterialSkin.Controls.MaterialLabel();
            this.numericLogPeriodCount = new System.Windows.Forms.NumericUpDown();
            this.lblLogMgrScheduler_ = new MaterialSkin.Controls.MaterialLabel();
            this.dtpScheduleStartTime = new CoPick.Controls.CleTimePicker();
            this.numericCsvPeriodCount = new System.Windows.Forms.NumericUpDown();
            this.numericImgPeriodCount = new System.Windows.Forms.NumericUpDown();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.lblDailyProduction_ = new MaterialSkin.Controls.MaterialLabel();
            this.lblDailyProductionResetTime_ = new MaterialSkin.Controls.MaterialLabel();
            this.dtpDailyProdResetTime = new CoPick.Controls.CleTimePicker();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.btnLogPath = new MaterialSkin.Controls.MaterialButton();
            this.tbLogPath = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblLogSavePath_ = new MaterialSkin.Controls.MaterialLabel();
            this.lblLogPath_ = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.cmbUiLogLev = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbFileLogLev = new MaterialSkin.Controls.MaterialComboBox();
            this.lblUILogLev_ = new MaterialSkin.Controls.MaterialLabel();
            this.lblFileLogLev_ = new MaterialSkin.Controls.MaterialLabel();
            this.lblLogLabel_ = new MaterialSkin.Controls.MaterialLabel();
            this.btnUpdateMasterData_ = new MaterialSkin.Controls.MaterialButton();
            this.cmbLanguage = new MaterialSkin.Controls.MaterialComboBox();
            this.btnChangePassword_ = new MaterialSkin.Controls.MaterialButton();
            this.btnFactoryReset_ = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveFactorySettings = new System.Windows.Forms.Button();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.lblSaveData_ = new MaterialSkin.Controls.MaterialLabel();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.fileBrowserDialog = new System.Windows.Forms.OpenFileDialog();
            this.ctxtMenuCameraDel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SettingManagerTabControl.SuspendLayout();
            this.ConfigDict_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbRootFolderPaths_.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.gbModelFilePath_.SuspendLayout();
            this.cardCamera.SuspendLayout();
            this.cardCarType.SuspendLayout();
            this.cardPlc.SuspendLayout();
            this.Logging_.SuspendLayout();
            this.materialCard6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLogPeriodCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCsvPeriodCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericImgPeriodCount)).BeginInit();
            this.materialCard7.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctxtMenuCameraDel
            // 
            this.ctxtMenuCameraDel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem_,
            this.deleteToolStripMenuItem_});
            this.ctxtMenuCameraDel.Name = "ctxtMenuCameraDel";
            this.ctxtMenuCameraDel.Size = new System.Drawing.Size(109, 48);
            // 
            // addToolStripMenuItem_
            // 
            this.addToolStripMenuItem_.Name = "addToolStripMenuItem_";
            this.addToolStripMenuItem_.Size = new System.Drawing.Size(108, 22);
            this.addToolStripMenuItem_.Text = "Add";
            // 
            // deleteToolStripMenuItem_
            // 
            this.deleteToolStripMenuItem_.Name = "deleteToolStripMenuItem_";
            this.deleteToolStripMenuItem_.Size = new System.Drawing.Size(108, 22);
            this.deleteToolStripMenuItem_.Text = "Delete";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 64);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SettingManagerTabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnUpdateMasterData_);
            this.splitContainer1.Panel2.Controls.Add(this.cmbLanguage);
            this.splitContainer1.Panel2.Controls.Add(this.btnChangePassword_);
            this.splitContainer1.Panel2.Controls.Add(this.btnFactoryReset_);
            this.splitContainer1.Panel2.Controls.Add(this.btnSaveFactorySettings);
            this.splitContainer1.Size = new System.Drawing.Size(1407, 732);
            this.splitContainer1.SplitterDistance = 669;
            this.splitContainer1.TabIndex = 10;
            this.splitContainer1.TabStop = false;
            // 
            // SettingManagerTabControl
            // 
            this.SettingManagerTabControl.Controls.Add(this.ConfigDict_);
            this.SettingManagerTabControl.Controls.Add(this.RobotConfig_);
            this.SettingManagerTabControl.Controls.Add(this.Cam2DConfigs_);
            this.SettingManagerTabControl.Controls.Add(this.LightConfigs_);
            this.SettingManagerTabControl.Controls.Add(this.PlcConfigs_);
            this.SettingManagerTabControl.Controls.Add(this.Logging_);
            this.SettingManagerTabControl.Depth = 0;
            this.SettingManagerTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingManagerTabControl.Location = new System.Drawing.Point(0, 0);
            this.SettingManagerTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SettingManagerTabControl.Multiline = true;
            this.SettingManagerTabControl.Name = "SettingManagerTabControl";
            this.SettingManagerTabControl.SelectedIndex = 0;
            this.SettingManagerTabControl.Size = new System.Drawing.Size(1407, 669);
            this.SettingManagerTabControl.TabIndex = 10;
            this.SettingManagerTabControl.SelectedIndexChanged += new System.EventHandler(this.SettingManagerTabControl_SelectedIndexChanged);
            this.SettingManagerTabControl.Enter += new System.EventHandler(this.SettingManagerTabControl_Enter);
            // 
            // ConfigDict_
            // 
            this.ConfigDict_.BackColor = System.Drawing.Color.White;
            this.ConfigDict_.Controls.Add(this.splitContainer2);
            this.ConfigDict_.Location = new System.Drawing.Point(4, 22);
            this.ConfigDict_.Name = "ConfigDict_";
            this.ConfigDict_.Padding = new System.Windows.Forms.Padding(3);
            this.ConfigDict_.Size = new System.Drawing.Size(1399, 643);
            this.ConfigDict_.TabIndex = 10;
            this.ConfigDict_.Text = "TASK";
            // 
            // splitContainer2
            // 
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gbRootFolderPaths_);
            this.splitContainer2.Panel1.Controls.Add(this.materialCard1);
            this.splitContainer2.Panel1.Controls.Add(this.gbModelFilePath_);
            this.splitContainer2.Panel1.Controls.Add(this.cardCamera);
            this.splitContainer2.Panel1.Controls.Add(this.cardCarType);
            this.splitContainer2.Panel1.Controls.Add(this.cardPlc);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.taskGrid);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer2.Size = new System.Drawing.Size(1379, 633);
            this.splitContainer2.SplitterDistance = 300;
            this.splitContainer2.TabIndex = 20;
            this.splitContainer2.TabStop = false;
            // 
            // gbRootFolderPaths_
            // 
            this.gbRootFolderPaths_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbRootFolderPaths_.Controls.Add(this.btnCameraTcpFilePath);
            this.gbRootFolderPaths_.Controls.Add(this.tbCameraTcpFilePath);
            this.gbRootFolderPaths_.Controls.Add(this.lblCameraTcp);
            this.gbRootFolderPaths_.Controls.Add(this.btnCalibrationRootFolderPath_);
            this.gbRootFolderPaths_.Controls.Add(this.tbCalibrationRootFolderPath);
            this.gbRootFolderPaths_.Controls.Add(this.lblCalibrationRootFolderPath_);
            this.gbRootFolderPaths_.Controls.Add(this.tbMasterImageRootPath);
            this.gbRootFolderPaths_.Controls.Add(this.tbCheckerBoardRootPath);
            this.gbRootFolderPaths_.Controls.Add(this.lblMasterImageFilePath);
            this.gbRootFolderPaths_.Controls.Add(this.lblCharucoFilePath);
            this.gbRootFolderPaths_.Controls.Add(this.lblImageRootFolderPath_);
            this.gbRootFolderPaths_.Controls.Add(this.btnMasterImageFilePath);
            this.gbRootFolderPaths_.Controls.Add(this.btnCharucoFilePath);
            this.gbRootFolderPaths_.Depth = 0;
            this.gbRootFolderPaths_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbRootFolderPaths_.Location = new System.Drawing.Point(4, 345);
            this.gbRootFolderPaths_.Margin = new System.Windows.Forms.Padding(14);
            this.gbRootFolderPaths_.MouseState = MaterialSkin.MouseState.HOVER;
            this.gbRootFolderPaths_.Name = "gbRootFolderPaths_";
            this.gbRootFolderPaths_.Padding = new System.Windows.Forms.Padding(14);
            this.gbRootFolderPaths_.Size = new System.Drawing.Size(291, 179);
            this.gbRootFolderPaths_.TabIndex = 42;
            // 
            // btnCameraTcpFilePath
            // 
            this.btnCameraTcpFilePath.AutoSize = false;
            this.btnCameraTcpFilePath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCameraTcpFilePath.CustomBackColor = System.Drawing.Color.Empty;
            this.btnCameraTcpFilePath.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCameraTcpFilePath.Depth = 0;
            this.btnCameraTcpFilePath.HighEmphasis = true;
            this.btnCameraTcpFilePath.Icon = null;
            this.btnCameraTcpFilePath.Location = new System.Drawing.Point(245, 142);
            this.btnCameraTcpFilePath.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCameraTcpFilePath.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCameraTcpFilePath.Name = "btnCameraTcpFilePath";
            this.btnCameraTcpFilePath.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCameraTcpFilePath.Size = new System.Drawing.Size(32, 24);
            this.btnCameraTcpFilePath.TabIndex = 46;
            this.btnCameraTcpFilePath.Text = "...";
            this.btnCameraTcpFilePath.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCameraTcpFilePath.UseAccentColor = false;
            this.btnCameraTcpFilePath.UseVisualStyleBackColor = true;
            this.btnCameraTcpFilePath.Click += new System.EventHandler(this.btnCameraTcpFilePath_Click);
            // 
            // tbCameraTcpFilePath
            // 
            this.tbCameraTcpFilePath.AnimateReadOnly = false;
            this.tbCameraTcpFilePath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbCameraTcpFilePath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbCameraTcpFilePath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbCameraTcpFilePath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCameraTcpFilePath.Depth = 0;
            this.tbCameraTcpFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCameraTcpFilePath.HideSelection = true;
            this.tbCameraTcpFilePath.LeadingIcon = null;
            this.tbCameraTcpFilePath.Location = new System.Drawing.Point(114, 141);
            this.tbCameraTcpFilePath.MaxLength = 32767;
            this.tbCameraTcpFilePath.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCameraTcpFilePath.Name = "tbCameraTcpFilePath";
            this.tbCameraTcpFilePath.PasswordChar = '\0';
            this.tbCameraTcpFilePath.PrefixSuffixText = null;
            this.tbCameraTcpFilePath.ReadOnly = false;
            this.tbCameraTcpFilePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCameraTcpFilePath.SelectedText = "";
            this.tbCameraTcpFilePath.SelectionLength = 0;
            this.tbCameraTcpFilePath.SelectionStart = 0;
            this.tbCameraTcpFilePath.ShortcutsEnabled = true;
            this.tbCameraTcpFilePath.Size = new System.Drawing.Size(125, 26);
            this.tbCameraTcpFilePath.TabIndex = 45;
            this.tbCameraTcpFilePath.TabStop = false;
            this.tbCameraTcpFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCameraTcpFilePath.TrailingIcon = null;
            this.tbCameraTcpFilePath.UseSystemPasswordChar = false;
            this.tbCameraTcpFilePath.UseTallSize = false;
            // 
            // lblCameraTcp
            // 
            this.lblCameraTcp.AutoSize = true;
            this.lblCameraTcp.BackColor = System.Drawing.Color.Transparent;
            this.lblCameraTcp.Depth = 0;
            this.lblCameraTcp.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCameraTcp.Location = new System.Drawing.Point(8, 145);
            this.lblCameraTcp.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCameraTcp.Name = "lblCameraTcp";
            this.lblCameraTcp.Size = new System.Drawing.Size(87, 18);
            this.lblCameraTcp.TabIndex = 44;
            this.lblCameraTcp.Text = "CameraTcp";
            // 
            // btnCalibrationRootFolderPath_
            // 
            this.btnCalibrationRootFolderPath_.AutoSize = false;
            this.btnCalibrationRootFolderPath_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCalibrationRootFolderPath_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnCalibrationRootFolderPath_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCalibrationRootFolderPath_.Depth = 0;
            this.btnCalibrationRootFolderPath_.HighEmphasis = true;
            this.btnCalibrationRootFolderPath_.Icon = null;
            this.btnCalibrationRootFolderPath_.Location = new System.Drawing.Point(245, 104);
            this.btnCalibrationRootFolderPath_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCalibrationRootFolderPath_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCalibrationRootFolderPath_.Name = "btnCalibrationRootFolderPath_";
            this.btnCalibrationRootFolderPath_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCalibrationRootFolderPath_.Size = new System.Drawing.Size(32, 24);
            this.btnCalibrationRootFolderPath_.TabIndex = 43;
            this.btnCalibrationRootFolderPath_.Text = "...";
            this.btnCalibrationRootFolderPath_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCalibrationRootFolderPath_.UseAccentColor = false;
            this.btnCalibrationRootFolderPath_.UseVisualStyleBackColor = true;
            this.btnCalibrationRootFolderPath_.Click += new System.EventHandler(this.btnCalibrationRootFolderPath__Click);
            // 
            // tbCalibrationRootFolderPath
            // 
            this.tbCalibrationRootFolderPath.AnimateReadOnly = false;
            this.tbCalibrationRootFolderPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbCalibrationRootFolderPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbCalibrationRootFolderPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbCalibrationRootFolderPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCalibrationRootFolderPath.Depth = 0;
            this.tbCalibrationRootFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCalibrationRootFolderPath.HideSelection = true;
            this.tbCalibrationRootFolderPath.LeadingIcon = null;
            this.tbCalibrationRootFolderPath.Location = new System.Drawing.Point(114, 103);
            this.tbCalibrationRootFolderPath.MaxLength = 32767;
            this.tbCalibrationRootFolderPath.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCalibrationRootFolderPath.Name = "tbCalibrationRootFolderPath";
            this.tbCalibrationRootFolderPath.PasswordChar = '\0';
            this.tbCalibrationRootFolderPath.PrefixSuffixText = null;
            this.tbCalibrationRootFolderPath.ReadOnly = false;
            this.tbCalibrationRootFolderPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCalibrationRootFolderPath.SelectedText = "";
            this.tbCalibrationRootFolderPath.SelectionLength = 0;
            this.tbCalibrationRootFolderPath.SelectionStart = 0;
            this.tbCalibrationRootFolderPath.ShortcutsEnabled = true;
            this.tbCalibrationRootFolderPath.Size = new System.Drawing.Size(125, 26);
            this.tbCalibrationRootFolderPath.TabIndex = 42;
            this.tbCalibrationRootFolderPath.TabStop = false;
            this.tbCalibrationRootFolderPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCalibrationRootFolderPath.TrailingIcon = null;
            this.tbCalibrationRootFolderPath.UseSystemPasswordChar = false;
            this.tbCalibrationRootFolderPath.UseTallSize = false;
            // 
            // lblCalibrationRootFolderPath_
            // 
            this.lblCalibrationRootFolderPath_.AutoSize = true;
            this.lblCalibrationRootFolderPath_.BackColor = System.Drawing.Color.Transparent;
            this.lblCalibrationRootFolderPath_.Depth = 0;
            this.lblCalibrationRootFolderPath_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCalibrationRootFolderPath_.Location = new System.Drawing.Point(8, 111);
            this.lblCalibrationRootFolderPath_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCalibrationRootFolderPath_.Name = "lblCalibrationRootFolderPath_";
            this.lblCalibrationRootFolderPath_.Size = new System.Drawing.Size(84, 18);
            this.lblCalibrationRootFolderPath_.TabIndex = 41;
            this.lblCalibrationRootFolderPath_.Text = "Calibration";
            // 
            // tbMasterImageRootPath
            // 
            this.tbMasterImageRootPath.AnimateReadOnly = false;
            this.tbMasterImageRootPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbMasterImageRootPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbMasterImageRootPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbMasterImageRootPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbMasterImageRootPath.Depth = 0;
            this.tbMasterImageRootPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbMasterImageRootPath.HideSelection = true;
            this.tbMasterImageRootPath.LeadingIcon = null;
            this.tbMasterImageRootPath.Location = new System.Drawing.Point(114, 68);
            this.tbMasterImageRootPath.MaxLength = 32767;
            this.tbMasterImageRootPath.MouseState = MaterialSkin.MouseState.OUT;
            this.tbMasterImageRootPath.Name = "tbMasterImageRootPath";
            this.tbMasterImageRootPath.PasswordChar = '\0';
            this.tbMasterImageRootPath.PrefixSuffixText = null;
            this.tbMasterImageRootPath.ReadOnly = false;
            this.tbMasterImageRootPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbMasterImageRootPath.SelectedText = "";
            this.tbMasterImageRootPath.SelectionLength = 0;
            this.tbMasterImageRootPath.SelectionStart = 0;
            this.tbMasterImageRootPath.ShortcutsEnabled = true;
            this.tbMasterImageRootPath.Size = new System.Drawing.Size(125, 26);
            this.tbMasterImageRootPath.TabIndex = 40;
            this.tbMasterImageRootPath.TabStop = false;
            this.tbMasterImageRootPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbMasterImageRootPath.TrailingIcon = null;
            this.tbMasterImageRootPath.UseSystemPasswordChar = false;
            this.tbMasterImageRootPath.UseTallSize = false;
            // 
            // tbCheckerBoardRootPath
            // 
            this.tbCheckerBoardRootPath.AnimateReadOnly = false;
            this.tbCheckerBoardRootPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbCheckerBoardRootPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbCheckerBoardRootPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbCheckerBoardRootPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCheckerBoardRootPath.Depth = 0;
            this.tbCheckerBoardRootPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCheckerBoardRootPath.HideSelection = true;
            this.tbCheckerBoardRootPath.LeadingIcon = null;
            this.tbCheckerBoardRootPath.Location = new System.Drawing.Point(114, 27);
            this.tbCheckerBoardRootPath.MaxLength = 32767;
            this.tbCheckerBoardRootPath.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCheckerBoardRootPath.Name = "tbCheckerBoardRootPath";
            this.tbCheckerBoardRootPath.PasswordChar = '\0';
            this.tbCheckerBoardRootPath.PrefixSuffixText = null;
            this.tbCheckerBoardRootPath.ReadOnly = false;
            this.tbCheckerBoardRootPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCheckerBoardRootPath.SelectedText = "";
            this.tbCheckerBoardRootPath.SelectionLength = 0;
            this.tbCheckerBoardRootPath.SelectionStart = 0;
            this.tbCheckerBoardRootPath.ShortcutsEnabled = true;
            this.tbCheckerBoardRootPath.Size = new System.Drawing.Size(125, 26);
            this.tbCheckerBoardRootPath.TabIndex = 40;
            this.tbCheckerBoardRootPath.TabStop = false;
            this.tbCheckerBoardRootPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCheckerBoardRootPath.TrailingIcon = null;
            this.tbCheckerBoardRootPath.UseSystemPasswordChar = false;
            this.tbCheckerBoardRootPath.UseTallSize = false;
            // 
            // lblMasterImageFilePath
            // 
            this.lblMasterImageFilePath.AutoSize = true;
            this.lblMasterImageFilePath.BackColor = System.Drawing.Color.Transparent;
            this.lblMasterImageFilePath.Depth = 0;
            this.lblMasterImageFilePath.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMasterImageFilePath.Location = new System.Drawing.Point(9, 73);
            this.lblMasterImageFilePath.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMasterImageFilePath.Name = "lblMasterImageFilePath";
            this.lblMasterImageFilePath.Size = new System.Drawing.Size(101, 18);
            this.lblMasterImageFilePath.TabIndex = 2;
            this.lblMasterImageFilePath.Text = "MasterImage";
            // 
            // lblCharucoFilePath
            // 
            this.lblCharucoFilePath.AutoSize = true;
            this.lblCharucoFilePath.BackColor = System.Drawing.Color.Transparent;
            this.lblCharucoFilePath.Depth = 0;
            this.lblCharucoFilePath.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCharucoFilePath.Location = new System.Drawing.Point(9, 32);
            this.lblCharucoFilePath.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCharucoFilePath.Name = "lblCharucoFilePath";
            this.lblCharucoFilePath.Size = new System.Drawing.Size(65, 18);
            this.lblCharucoFilePath.TabIndex = 2;
            this.lblCharucoFilePath.Text = "Charuco";
            // 
            // lblImageRootFolderPath_
            // 
            this.lblImageRootFolderPath_.AutoSize = true;
            this.lblImageRootFolderPath_.BackColor = System.Drawing.Color.Transparent;
            this.lblImageRootFolderPath_.Depth = 0;
            this.lblImageRootFolderPath_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblImageRootFolderPath_.Location = new System.Drawing.Point(5, 5);
            this.lblImageRootFolderPath_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblImageRootFolderPath_.Name = "lblImageRootFolderPath_";
            this.lblImageRootFolderPath_.Size = new System.Drawing.Size(180, 18);
            this.lblImageRootFolderPath_.TabIndex = 0;
            this.lblImageRootFolderPath_.Text = "Image Root Folder Path";
            // 
            // btnMasterImageFilePath
            // 
            this.btnMasterImageFilePath.AutoSize = false;
            this.btnMasterImageFilePath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMasterImageFilePath.CustomBackColor = System.Drawing.Color.Empty;
            this.btnMasterImageFilePath.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMasterImageFilePath.Depth = 0;
            this.btnMasterImageFilePath.HighEmphasis = true;
            this.btnMasterImageFilePath.Icon = null;
            this.btnMasterImageFilePath.Location = new System.Drawing.Point(245, 67);
            this.btnMasterImageFilePath.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMasterImageFilePath.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMasterImageFilePath.Name = "btnMasterImageFilePath";
            this.btnMasterImageFilePath.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMasterImageFilePath.Size = new System.Drawing.Size(32, 24);
            this.btnMasterImageFilePath.TabIndex = 18;
            this.btnMasterImageFilePath.Text = "...";
            this.btnMasterImageFilePath.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMasterImageFilePath.UseAccentColor = false;
            this.btnMasterImageFilePath.UseVisualStyleBackColor = true;
            this.btnMasterImageFilePath.Click += new System.EventHandler(this.btnMasterImageFilePath_Click);
            // 
            // btnCharucoFilePath
            // 
            this.btnCharucoFilePath.AutoSize = false;
            this.btnCharucoFilePath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCharucoFilePath.CustomBackColor = System.Drawing.Color.Empty;
            this.btnCharucoFilePath.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCharucoFilePath.Depth = 0;
            this.btnCharucoFilePath.HighEmphasis = true;
            this.btnCharucoFilePath.Icon = null;
            this.btnCharucoFilePath.Location = new System.Drawing.Point(245, 26);
            this.btnCharucoFilePath.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCharucoFilePath.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCharucoFilePath.Name = "btnCharucoFilePath";
            this.btnCharucoFilePath.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCharucoFilePath.Size = new System.Drawing.Size(32, 24);
            this.btnCharucoFilePath.TabIndex = 18;
            this.btnCharucoFilePath.Text = "...";
            this.btnCharucoFilePath.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCharucoFilePath.UseAccentColor = false;
            this.btnCharucoFilePath.UseVisualStyleBackColor = true;
            this.btnCharucoFilePath.Click += new System.EventHandler(this.btnCharucoFilePath_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.cmbRobot_);
            this.materialCard1.Controls.Add(this.lblRobot_);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(4, 277);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(291, 62);
            this.materialCard1.TabIndex = 2;
            // 
            // cmbRobot_
            // 
            this.cmbRobot_.AutoResize = false;
            this.cmbRobot_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbRobot_.Depth = 0;
            this.cmbRobot_.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbRobot_.DropDownHeight = 102;
            this.cmbRobot_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRobot_.DropDownWidth = 121;
            this.cmbRobot_.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbRobot_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbRobot_.FormattingEnabled = true;
            this.cmbRobot_.IntegralHeight = false;
            this.cmbRobot_.ItemHeight = 25;
            this.cmbRobot_.Location = new System.Drawing.Point(81, 17);
            this.cmbRobot_.MaxDropDownItems = 4;
            this.cmbRobot_.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbRobot_.Name = "cmbRobot_";
            this.cmbRobot_.Size = new System.Drawing.Size(185, 31);
            this.cmbRobot_.StartIndex = 0;
            this.cmbRobot_.TabIndex = 2;
            this.cmbRobot_.UseTallSize = false;
            this.cmbRobot_.SelectedIndexChanged += new System.EventHandler(this.cmbRobot__SelectedIndexChanged);
            // 
            // lblRobot_
            // 
            this.lblRobot_.AutoSize = true;
            this.lblRobot_.BackColor = System.Drawing.Color.Transparent;
            this.lblRobot_.Depth = 0;
            this.lblRobot_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRobot_.Location = new System.Drawing.Point(6, 30);
            this.lblRobot_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRobot_.Name = "lblRobot_";
            this.lblRobot_.Size = new System.Drawing.Size(47, 18);
            this.lblRobot_.TabIndex = 2;
            this.lblRobot_.Text = "Robot";
            // 
            // gbModelFilePath_
            // 
            this.gbModelFilePath_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbModelFilePath_.Controls.Add(this.tbModelPath);
            this.gbModelFilePath_.Controls.Add(this.lblShiftModel_);
            this.gbModelFilePath_.Controls.Add(this.lblModelFilePaths_);
            this.gbModelFilePath_.Controls.Add(this.btnModelPath);
            this.gbModelFilePath_.Depth = 0;
            this.gbModelFilePath_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbModelFilePath_.Location = new System.Drawing.Point(4, 544);
            this.gbModelFilePath_.Margin = new System.Windows.Forms.Padding(14);
            this.gbModelFilePath_.MouseState = MaterialSkin.MouseState.HOVER;
            this.gbModelFilePath_.Name = "gbModelFilePath_";
            this.gbModelFilePath_.Padding = new System.Windows.Forms.Padding(14);
            this.gbModelFilePath_.Size = new System.Drawing.Size(291, 75);
            this.gbModelFilePath_.TabIndex = 1;
            // 
            // tbModelPath
            // 
            this.tbModelPath.AnimateReadOnly = false;
            this.tbModelPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbModelPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbModelPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbModelPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbModelPath.Depth = 0;
            this.tbModelPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbModelPath.HideSelection = true;
            this.tbModelPath.LeadingIcon = null;
            this.tbModelPath.Location = new System.Drawing.Point(114, 40);
            this.tbModelPath.MaxLength = 32767;
            this.tbModelPath.MouseState = MaterialSkin.MouseState.OUT;
            this.tbModelPath.Name = "tbModelPath";
            this.tbModelPath.PasswordChar = '\0';
            this.tbModelPath.PrefixSuffixText = null;
            this.tbModelPath.ReadOnly = false;
            this.tbModelPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbModelPath.SelectedText = "";
            this.tbModelPath.SelectionLength = 0;
            this.tbModelPath.SelectionStart = 0;
            this.tbModelPath.ShortcutsEnabled = true;
            this.tbModelPath.Size = new System.Drawing.Size(125, 26);
            this.tbModelPath.TabIndex = 40;
            this.tbModelPath.TabStop = false;
            this.tbModelPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbModelPath.TrailingIcon = null;
            this.tbModelPath.UseSystemPasswordChar = false;
            this.tbModelPath.UseTallSize = false;
            // 
            // lblShiftModel_
            // 
            this.lblShiftModel_.AutoSize = true;
            this.lblShiftModel_.BackColor = System.Drawing.Color.Transparent;
            this.lblShiftModel_.Depth = 0;
            this.lblShiftModel_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblShiftModel_.Location = new System.Drawing.Point(9, 45);
            this.lblShiftModel_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblShiftModel_.Name = "lblShiftModel_";
            this.lblShiftModel_.Size = new System.Drawing.Size(37, 18);
            this.lblShiftModel_.TabIndex = 2;
            this.lblShiftModel_.Text = "Shift";
            // 
            // lblModelFilePaths_
            // 
            this.lblModelFilePaths_.AutoSize = true;
            this.lblModelFilePaths_.BackColor = System.Drawing.Color.Transparent;
            this.lblModelFilePaths_.Depth = 0;
            this.lblModelFilePaths_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblModelFilePaths_.Location = new System.Drawing.Point(5, 5);
            this.lblModelFilePaths_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblModelFilePaths_.Name = "lblModelFilePaths_";
            this.lblModelFilePaths_.Size = new System.Drawing.Size(109, 18);
            this.lblModelFilePaths_.TabIndex = 0;
            this.lblModelFilePaths_.Text = "ModelFilePath";
            // 
            // btnModelPath
            // 
            this.btnModelPath.AutoSize = false;
            this.btnModelPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModelPath.CustomBackColor = System.Drawing.Color.Empty;
            this.btnModelPath.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModelPath.Depth = 0;
            this.btnModelPath.HighEmphasis = true;
            this.btnModelPath.Icon = null;
            this.btnModelPath.Location = new System.Drawing.Point(245, 40);
            this.btnModelPath.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModelPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModelPath.Name = "btnModelPath";
            this.btnModelPath.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModelPath.Size = new System.Drawing.Size(32, 24);
            this.btnModelPath.TabIndex = 18;
            this.btnModelPath.Text = "...";
            this.btnModelPath.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModelPath.UseAccentColor = false;
            this.btnModelPath.UseVisualStyleBackColor = true;
            this.btnModelPath.Click += new System.EventHandler(this.btnModelPath__Click);
            // 
            // cardCamera
            // 
            this.cardCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardCamera.Controls.Add(this.cmbLight);
            this.cardCamera.Controls.Add(this.lblLight_);
            this.cardCamera.Controls.Add(this.lblCamera_);
            this.cardCamera.Controls.Add(this.cmbCamera);
            this.cardCamera.Depth = 0;
            this.cardCamera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardCamera.Location = new System.Drawing.Point(4, 121);
            this.cardCamera.Margin = new System.Windows.Forms.Padding(14);
            this.cardCamera.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardCamera.Name = "cardCamera";
            this.cardCamera.Padding = new System.Windows.Forms.Padding(14);
            this.cardCamera.Size = new System.Drawing.Size(291, 83);
            this.cardCamera.TabIndex = 12;
            // 
            // cmbLight
            // 
            this.cmbLight.AutoResize = false;
            this.cmbLight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbLight.Depth = 0;
            this.cmbLight.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbLight.DropDownHeight = 102;
            this.cmbLight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLight.DropDownWidth = 121;
            this.cmbLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbLight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbLight.FormattingEnabled = true;
            this.cmbLight.IntegralHeight = false;
            this.cmbLight.ItemHeight = 25;
            this.cmbLight.Location = new System.Drawing.Point(149, 45);
            this.cmbLight.MaxDropDownItems = 4;
            this.cmbLight.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbLight.Name = "cmbLight";
            this.cmbLight.Size = new System.Drawing.Size(121, 31);
            this.cmbLight.StartIndex = 0;
            this.cmbLight.TabIndex = 1;
            this.cmbLight.UseTallSize = false;
            this.cmbLight.Visible = false;
            this.cmbLight.SelectedIndexChanged += new System.EventHandler(this.cmbLight_SelectedIndexChanged);
            // 
            // lblLight_
            // 
            this.lblLight_.AutoSize = true;
            this.lblLight_.BackColor = System.Drawing.Color.Transparent;
            this.lblLight_.Depth = 0;
            this.lblLight_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLight_.Location = new System.Drawing.Point(6, 51);
            this.lblLight_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLight_.Name = "lblLight_";
            this.lblLight_.Size = new System.Drawing.Size(40, 18);
            this.lblLight_.TabIndex = 15;
            this.lblLight_.Text = "Light";
            this.lblLight_.Visible = false;
            // 
            // lblCamera_
            // 
            this.lblCamera_.AutoSize = true;
            this.lblCamera_.BackColor = System.Drawing.Color.Transparent;
            this.lblCamera_.Depth = 0;
            this.lblCamera_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCamera_.Location = new System.Drawing.Point(7, 11);
            this.lblCamera_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCamera_.Name = "lblCamera_";
            this.lblCamera_.Size = new System.Drawing.Size(89, 18);
            this.lblCamera_.TabIndex = 2;
            this.lblCamera_.Text = "Camera Set";
            // 
            // cmbCamera
            // 
            this.cmbCamera.AutoResize = false;
            this.cmbCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCamera.Depth = 0;
            this.cmbCamera.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCamera.DropDownHeight = 102;
            this.cmbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCamera.DropDownWidth = 121;
            this.cmbCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCamera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCamera.FormattingEnabled = true;
            this.cmbCamera.IntegralHeight = false;
            this.cmbCamera.ItemHeight = 25;
            this.cmbCamera.Location = new System.Drawing.Point(149, 4);
            this.cmbCamera.MaxDropDownItems = 4;
            this.cmbCamera.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCamera.Name = "cmbCamera";
            this.cmbCamera.Size = new System.Drawing.Size(121, 31);
            this.cmbCamera.StartIndex = 0;
            this.cmbCamera.TabIndex = 10;
            this.cmbCamera.UseTallSize = false;
            this.cmbCamera.SelectedIndexChanged += new System.EventHandler(this.cmbCamera_SelectedIndexChanged);
            // 
            // cardCarType
            // 
            this.cardCarType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardCarType.Controls.Add(this.tbCarType);
            this.cardCarType.Controls.Add(this.btnCopyCarType_);
            this.cardCarType.Controls.Add(this.btnRemoveCarType_);
            this.cardCarType.Controls.Add(this.btnAddCarType_);
            this.cardCarType.Controls.Add(this.lblCarType_);
            this.cardCarType.Controls.Add(this.cmbCarType);
            this.cardCarType.Depth = 0;
            this.cardCarType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardCarType.Location = new System.Drawing.Point(4, 4);
            this.cardCarType.Margin = new System.Windows.Forms.Padding(14);
            this.cardCarType.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardCarType.Name = "cardCarType";
            this.cardCarType.Padding = new System.Windows.Forms.Padding(14);
            this.cardCarType.Size = new System.Drawing.Size(291, 112);
            this.cardCarType.TabIndex = 1;
            // 
            // tbCarType
            // 
            this.tbCarType.AnimateReadOnly = false;
            this.tbCarType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbCarType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbCarType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbCarType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCarType.Depth = 0;
            this.tbCarType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCarType.HideSelection = true;
            this.tbCarType.LeadingIcon = null;
            this.tbCarType.Location = new System.Drawing.Point(197, 42);
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
            this.tbCarType.Size = new System.Drawing.Size(69, 26);
            this.tbCarType.TabIndex = 16;
            this.tbCarType.TabStop = false;
            this.tbCarType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCarType.TrailingIcon = null;
            this.tbCarType.UseSystemPasswordChar = false;
            this.tbCarType.UseTallSize = false;
            // 
            // btnCopyCarType_
            // 
            this.btnCopyCarType_.AutoSize = false;
            this.btnCopyCarType_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCopyCarType_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnCopyCarType_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCopyCarType_.Depth = 0;
            this.btnCopyCarType_.HighEmphasis = true;
            this.btnCopyCarType_.Icon = null;
            this.btnCopyCarType_.Location = new System.Drawing.Point(190, 83);
            this.btnCopyCarType_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCopyCarType_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCopyCarType_.Name = "btnCopyCarType_";
            this.btnCopyCarType_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCopyCarType_.Size = new System.Drawing.Size(80, 25);
            this.btnCopyCarType_.TabIndex = 15;
            this.btnCopyCarType_.Text = "Copy";
            this.btnCopyCarType_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCopyCarType_.UseAccentColor = false;
            this.btnCopyCarType_.UseVisualStyleBackColor = true;
            this.btnCopyCarType_.Visible = false;
            this.btnCopyCarType_.Click += new System.EventHandler(this.btnCopyCarType__Click);
            // 
            // btnRemoveCarType_
            // 
            this.btnRemoveCarType_.AutoSize = false;
            this.btnRemoveCarType_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoveCarType_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnRemoveCarType_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRemoveCarType_.Depth = 0;
            this.btnRemoveCarType_.HighEmphasis = true;
            this.btnRemoveCarType_.Icon = null;
            this.btnRemoveCarType_.Location = new System.Drawing.Point(100, 83);
            this.btnRemoveCarType_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemoveCarType_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemoveCarType_.Name = "btnRemoveCarType_";
            this.btnRemoveCarType_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRemoveCarType_.Size = new System.Drawing.Size(80, 25);
            this.btnRemoveCarType_.TabIndex = 14;
            this.btnRemoveCarType_.Text = "Remove";
            this.btnRemoveCarType_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRemoveCarType_.UseAccentColor = false;
            this.btnRemoveCarType_.UseVisualStyleBackColor = true;
            this.btnRemoveCarType_.Visible = false;
            this.btnRemoveCarType_.Click += new System.EventHandler(this.btnRemoveCarType__Click);
            // 
            // btnAddCarType_
            // 
            this.btnAddCarType_.AutoSize = false;
            this.btnAddCarType_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddCarType_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnAddCarType_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddCarType_.Depth = 0;
            this.btnAddCarType_.HighEmphasis = true;
            this.btnAddCarType_.Icon = null;
            this.btnAddCarType_.Location = new System.Drawing.Point(10, 83);
            this.btnAddCarType_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddCarType_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddCarType_.Name = "btnAddCarType_";
            this.btnAddCarType_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddCarType_.Size = new System.Drawing.Size(80, 25);
            this.btnAddCarType_.TabIndex = 11;
            this.btnAddCarType_.Text = "Add";
            this.btnAddCarType_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddCarType_.UseAccentColor = false;
            this.btnAddCarType_.UseVisualStyleBackColor = true;
            this.btnAddCarType_.Visible = false;
            this.btnAddCarType_.Click += new System.EventHandler(this.btnAddCarType__Click);
            // 
            // lblCarType_
            // 
            this.lblCarType_.AutoSize = true;
            this.lblCarType_.BackColor = System.Drawing.Color.Transparent;
            this.lblCarType_.Depth = 0;
            this.lblCarType_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCarType_.Location = new System.Drawing.Point(5, 5);
            this.lblCarType_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCarType_.Name = "lblCarType_";
            this.lblCarType_.Size = new System.Drawing.Size(64, 18);
            this.lblCarType_.TabIndex = 0;
            this.lblCarType_.Text = "CarType";
            // 
            // cmbCarType
            // 
            this.cmbCarType.AutoResize = false;
            this.cmbCarType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCarType.Depth = 0;
            this.cmbCarType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCarType.DropDownHeight = 102;
            this.cmbCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarType.DropDownWidth = 121;
            this.cmbCarType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCarType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCarType.FormattingEnabled = true;
            this.cmbCarType.IntegralHeight = false;
            this.cmbCarType.ItemHeight = 25;
            this.cmbCarType.Location = new System.Drawing.Point(12, 37);
            this.cmbCarType.MaxDropDownItems = 4;
            this.cmbCarType.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCarType.Name = "cmbCarType";
            this.cmbCarType.Size = new System.Drawing.Size(179, 31);
            this.cmbCarType.StartIndex = 0;
            this.cmbCarType.TabIndex = 1;
            this.cmbCarType.UseTallSize = false;
            this.cmbCarType.SelectedIndexChanged += new System.EventHandler(this.cmbCarType_SelectedIndexChanged);
            // 
            // cardPlc
            // 
            this.cardPlc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardPlc.Controls.Add(this.cmbPlc);
            this.cardPlc.Controls.Add(this.lblPlc_);
            this.cardPlc.Depth = 0;
            this.cardPlc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardPlc.Location = new System.Drawing.Point(4, 214);
            this.cardPlc.Margin = new System.Windows.Forms.Padding(14);
            this.cardPlc.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardPlc.Name = "cardPlc";
            this.cardPlc.Padding = new System.Windows.Forms.Padding(14);
            this.cardPlc.Size = new System.Drawing.Size(291, 58);
            this.cardPlc.TabIndex = 1;
            // 
            // cmbPlc
            // 
            this.cmbPlc.AutoResize = false;
            this.cmbPlc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPlc.Depth = 0;
            this.cmbPlc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPlc.DropDownHeight = 102;
            this.cmbPlc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlc.DropDownWidth = 121;
            this.cmbPlc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPlc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPlc.FormattingEnabled = true;
            this.cmbPlc.IntegralHeight = false;
            this.cmbPlc.ItemHeight = 25;
            this.cmbPlc.Location = new System.Drawing.Point(82, 19);
            this.cmbPlc.MaxDropDownItems = 4;
            this.cmbPlc.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPlc.Name = "cmbPlc";
            this.cmbPlc.Size = new System.Drawing.Size(185, 31);
            this.cmbPlc.StartIndex = 0;
            this.cmbPlc.TabIndex = 1;
            this.cmbPlc.UseTallSize = false;
            this.cmbPlc.SelectedIndexChanged += new System.EventHandler(this.cmbPlc_SelectedIndexChanged);
            // 
            // lblPlc_
            // 
            this.lblPlc_.AutoSize = true;
            this.lblPlc_.BackColor = System.Drawing.Color.Transparent;
            this.lblPlc_.Depth = 0;
            this.lblPlc_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPlc_.Location = new System.Drawing.Point(5, 32);
            this.lblPlc_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPlc_.Name = "lblPlc_";
            this.lblPlc_.Size = new System.Drawing.Size(30, 18);
            this.lblPlc_.TabIndex = 0;
            this.lblPlc_.Text = "PLC";
            // 
            // taskGrid
            // 
            this.taskGrid.BackColor = System.Drawing.Color.White;
            this.taskGrid.CategoryForeColor = System.Drawing.Color.Black;
            this.taskGrid.CategorySplitterColor = System.Drawing.Color.WhiteSmoke;
            this.taskGrid.CommandsBackColor = System.Drawing.Color.Black;
            this.taskGrid.ContextMenuStrip = this.ctxtMenuCameraDel;
            this.taskGrid.DisabledItemForeColor = System.Drawing.SystemColors.ControlText;
            this.taskGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskGrid.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.taskGrid.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.taskGrid.LineColor = System.Drawing.Color.Gray;
            this.taskGrid.Location = new System.Drawing.Point(3, 3);
            this.taskGrid.Name = "taskGrid";
            this.taskGrid.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.taskGrid.SelectedItemWithFocusBackColor = System.Drawing.Color.IndianRed;
            this.taskGrid.SelectedItemWithFocusForeColor = System.Drawing.Color.White;
            this.taskGrid.Size = new System.Drawing.Size(1069, 627);
            this.taskGrid.TabIndex = 20;
            this.taskGrid.ToolbarVisible = false;
            this.taskGrid.ViewBackColor = System.Drawing.Color.White;
            this.taskGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.taskGrid_PropertyValueChanged);
            // 
            // RobotConfig_
            // 
            this.RobotConfig_.BackColor = System.Drawing.Color.White;
            this.RobotConfig_.Location = new System.Drawing.Point(4, 22);
            this.RobotConfig_.Name = "RobotConfig_";
            this.RobotConfig_.Padding = new System.Windows.Forms.Padding(3);
            this.RobotConfig_.Size = new System.Drawing.Size(1399, 643);
            this.RobotConfig_.TabIndex = 11;
            this.RobotConfig_.Text = "ROBOT";
            // 
            // Cam2DConfigs_
            // 
            this.Cam2DConfigs_.BackColor = System.Drawing.Color.White;
            this.Cam2DConfigs_.Location = new System.Drawing.Point(4, 22);
            this.Cam2DConfigs_.Name = "Cam2DConfigs_";
            this.Cam2DConfigs_.Size = new System.Drawing.Size(1399, 643);
            this.Cam2DConfigs_.TabIndex = 2;
            this.Cam2DConfigs_.Text = "CAMERA";
            // 
            // LightConfigs_
            // 
            this.LightConfigs_.BackColor = System.Drawing.Color.White;
            this.LightConfigs_.Location = new System.Drawing.Point(4, 22);
            this.LightConfigs_.Name = "LightConfigs_";
            this.LightConfigs_.Size = new System.Drawing.Size(1399, 643);
            this.LightConfigs_.TabIndex = 3;
            this.LightConfigs_.Text = "LIGHT";
            // 
            // PlcConfigs_
            // 
            this.PlcConfigs_.BackColor = System.Drawing.Color.White;
            this.PlcConfigs_.Location = new System.Drawing.Point(4, 22);
            this.PlcConfigs_.Name = "PlcConfigs_";
            this.PlcConfigs_.Size = new System.Drawing.Size(1399, 643);
            this.PlcConfigs_.TabIndex = 4;
            this.PlcConfigs_.Text = "PLC";
            // 
            // Logging_
            // 
            this.Logging_.BackColor = System.Drawing.Color.White;
            this.Logging_.Controls.Add(this.materialCard6);
            this.Logging_.Controls.Add(this.materialCard7);
            this.Logging_.Controls.Add(this.materialCard5);
            this.Logging_.Controls.Add(this.materialCard3);
            this.Logging_.Location = new System.Drawing.Point(4, 22);
            this.Logging_.Name = "Logging_";
            this.Logging_.Size = new System.Drawing.Size(1399, 643);
            this.Logging_.TabIndex = 5;
            this.Logging_.Text = "LOGGING";
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.btnDeleteSchedule_);
            this.materialCard6.Controls.Add(this.btnRegisterSchedule_);
            this.materialCard6.Controls.Add(this.lblCsvLastingPeriod_);
            this.materialCard6.Controls.Add(this.lblImgLastingPeriod_);
            this.materialCard6.Controls.Add(this.lblLogLastingPeriod_);
            this.materialCard6.Controls.Add(this.lblScheduleStartTime_);
            this.materialCard6.Controls.Add(this.numericLogPeriodCount);
            this.materialCard6.Controls.Add(this.lblLogMgrScheduler_);
            this.materialCard6.Controls.Add(this.dtpScheduleStartTime);
            this.materialCard6.Controls.Add(this.numericCsvPeriodCount);
            this.materialCard6.Controls.Add(this.numericImgPeriodCount);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(14, 302);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(1371, 198);
            this.materialCard6.TabIndex = 15;
            // 
            // btnDeleteSchedule_
            // 
            this.btnDeleteSchedule_.AutoSize = false;
            this.btnDeleteSchedule_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteSchedule_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnDeleteSchedule_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteSchedule_.Depth = 0;
            this.btnDeleteSchedule_.HighEmphasis = true;
            this.btnDeleteSchedule_.Icon = null;
            this.btnDeleteSchedule_.Location = new System.Drawing.Point(1022, 145);
            this.btnDeleteSchedule_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteSchedule_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteSchedule_.Name = "btnDeleteSchedule_";
            this.btnDeleteSchedule_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteSchedule_.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteSchedule_.TabIndex = 6;
            this.btnDeleteSchedule_.Text = "Delete";
            this.btnDeleteSchedule_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteSchedule_.UseAccentColor = false;
            this.btnDeleteSchedule_.UseVisualStyleBackColor = true;
            this.btnDeleteSchedule_.Click += new System.EventHandler(this.btnDeleteSchedule__Click);
            // 
            // btnRegisterSchedule_
            // 
            this.btnRegisterSchedule_.AutoSize = false;
            this.btnRegisterSchedule_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegisterSchedule_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnRegisterSchedule_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegisterSchedule_.Depth = 0;
            this.btnRegisterSchedule_.HighEmphasis = true;
            this.btnRegisterSchedule_.Icon = null;
            this.btnRegisterSchedule_.Location = new System.Drawing.Point(914, 145);
            this.btnRegisterSchedule_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegisterSchedule_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegisterSchedule_.Name = "btnRegisterSchedule_";
            this.btnRegisterSchedule_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegisterSchedule_.Size = new System.Drawing.Size(100, 30);
            this.btnRegisterSchedule_.TabIndex = 5;
            this.btnRegisterSchedule_.Text = "Register";
            this.btnRegisterSchedule_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegisterSchedule_.UseAccentColor = false;
            this.btnRegisterSchedule_.UseVisualStyleBackColor = true;
            this.btnRegisterSchedule_.Click += new System.EventHandler(this.btnRegisterSchedule__Click);
            // 
            // lblCsvLastingPeriod_
            // 
            this.lblCsvLastingPeriod_.AutoSize = true;
            this.lblCsvLastingPeriod_.BackColor = System.Drawing.Color.Transparent;
            this.lblCsvLastingPeriod_.Depth = 0;
            this.lblCsvLastingPeriod_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCsvLastingPeriod_.Location = new System.Drawing.Point(975, 62);
            this.lblCsvLastingPeriod_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCsvLastingPeriod_.Name = "lblCsvLastingPeriod_";
            this.lblCsvLastingPeriod_.Size = new System.Drawing.Size(168, 18);
            this.lblCsvLastingPeriod_.TabIndex = 15;
            this.lblCsvLastingPeriod_.Text = "NG Image Save Period";
            // 
            // lblImgLastingPeriod_
            // 
            this.lblImgLastingPeriod_.AutoSize = true;
            this.lblImgLastingPeriod_.BackColor = System.Drawing.Color.Transparent;
            this.lblImgLastingPeriod_.Depth = 0;
            this.lblImgLastingPeriod_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblImgLastingPeriod_.Location = new System.Drawing.Point(738, 62);
            this.lblImgLastingPeriod_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblImgLastingPeriod_.Name = "lblImgLastingPeriod_";
            this.lblImgLastingPeriod_.Size = new System.Drawing.Size(129, 18);
            this.lblImgLastingPeriod_.TabIndex = 15;
            this.lblImgLastingPeriod_.Text = ".png Save Period";
            // 
            // lblLogLastingPeriod_
            // 
            this.lblLogLastingPeriod_.AutoSize = true;
            this.lblLogLastingPeriod_.BackColor = System.Drawing.Color.Transparent;
            this.lblLogLastingPeriod_.Depth = 0;
            this.lblLogLastingPeriod_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLogLastingPeriod_.Location = new System.Drawing.Point(481, 62);
            this.lblLogLastingPeriod_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLogLastingPeriod_.Name = "lblLogLastingPeriod_";
            this.lblLogLastingPeriod_.Size = new System.Drawing.Size(123, 18);
            this.lblLogLastingPeriod_.TabIndex = 15;
            this.lblLogLastingPeriod_.Text = ".log Save Period";
            // 
            // lblScheduleStartTime_
            // 
            this.lblScheduleStartTime_.AutoSize = true;
            this.lblScheduleStartTime_.BackColor = System.Drawing.Color.Transparent;
            this.lblScheduleStartTime_.Depth = 0;
            this.lblScheduleStartTime_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblScheduleStartTime_.Location = new System.Drawing.Point(241, 62);
            this.lblScheduleStartTime_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblScheduleStartTime_.Name = "lblScheduleStartTime_";
            this.lblScheduleStartTime_.Size = new System.Drawing.Size(136, 18);
            this.lblScheduleStartTime_.TabIndex = 15;
            this.lblScheduleStartTime_.Text = "Log Manage Time";
            // 
            // numericLogPeriodCount
            // 
            this.numericLogPeriodCount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLogPeriodCount.Location = new System.Drawing.Point(490, 97);
            this.numericLogPeriodCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericLogPeriodCount.Maximum = new decimal(new int[] {
            3650,
            0,
            0,
            0});
            this.numericLogPeriodCount.Name = "numericLogPeriodCount";
            this.numericLogPeriodCount.Size = new System.Drawing.Size(107, 21);
            this.numericLogPeriodCount.TabIndex = 1;
            this.numericLogPeriodCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLogMgrScheduler_
            // 
            this.lblLogMgrScheduler_.AutoSize = true;
            this.lblLogMgrScheduler_.BackColor = System.Drawing.Color.Transparent;
            this.lblLogMgrScheduler_.Depth = 0;
            this.lblLogMgrScheduler_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLogMgrScheduler_.Location = new System.Drawing.Point(5, 5);
            this.lblLogMgrScheduler_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLogMgrScheduler_.Name = "lblLogMgrScheduler_";
            this.lblLogMgrScheduler_.Size = new System.Drawing.Size(179, 18);
            this.lblLogMgrScheduler_.TabIndex = 30;
            this.lblLogMgrScheduler_.Text = "LogManager Scheduler";
            // 
            // dtpScheduleStartTime
            // 
            this.dtpScheduleStartTime.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtpScheduleStartTime.CustomFormat = "HH:mm";
            this.dtpScheduleStartTime.FocusedPartColor = System.Drawing.SystemColors.Highlight;
            this.dtpScheduleStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpScheduleStartTime.Location = new System.Drawing.Point(264, 97);
            this.dtpScheduleStartTime.Name = "dtpScheduleStartTime";
            this.dtpScheduleStartTime.ShowUpDown = true;
            this.dtpScheduleStartTime.Size = new System.Drawing.Size(116, 21);
            this.dtpScheduleStartTime.TabIndex = 31;
            // 
            // numericCsvPeriodCount
            // 
            this.numericCsvPeriodCount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericCsvPeriodCount.Location = new System.Drawing.Point(1004, 97);
            this.numericCsvPeriodCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericCsvPeriodCount.Maximum = new decimal(new int[] {
            3650,
            0,
            0,
            0});
            this.numericCsvPeriodCount.Name = "numericCsvPeriodCount";
            this.numericCsvPeriodCount.Size = new System.Drawing.Size(107, 21);
            this.numericCsvPeriodCount.TabIndex = 3;
            this.numericCsvPeriodCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericImgPeriodCount
            // 
            this.numericImgPeriodCount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericImgPeriodCount.Location = new System.Drawing.Point(749, 97);
            this.numericImgPeriodCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericImgPeriodCount.Maximum = new decimal(new int[] {
            3650,
            0,
            0,
            0});
            this.numericImgPeriodCount.Name = "numericImgPeriodCount";
            this.numericImgPeriodCount.Size = new System.Drawing.Size(107, 21);
            this.numericImgPeriodCount.TabIndex = 2;
            this.numericImgPeriodCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // materialCard7
            // 
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.lblDailyProduction_);
            this.materialCard7.Controls.Add(this.lblDailyProductionResetTime_);
            this.materialCard7.Controls.Add(this.dtpDailyProdResetTime);
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(14, 514);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(1371, 115);
            this.materialCard7.TabIndex = 14;
            this.materialCard7.Visible = false;
            // 
            // lblDailyProduction_
            // 
            this.lblDailyProduction_.AutoSize = true;
            this.lblDailyProduction_.BackColor = System.Drawing.Color.Transparent;
            this.lblDailyProduction_.Depth = 0;
            this.lblDailyProduction_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDailyProduction_.Location = new System.Drawing.Point(5, 5);
            this.lblDailyProduction_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDailyProduction_.Name = "lblDailyProduction_";
            this.lblDailyProduction_.Size = new System.Drawing.Size(185, 18);
            this.lblDailyProduction_.TabIndex = 3;
            this.lblDailyProduction_.Text = "Daily Production Record";
            // 
            // lblDailyProductionResetTime_
            // 
            this.lblDailyProductionResetTime_.AutoSize = true;
            this.lblDailyProductionResetTime_.BackColor = System.Drawing.Color.Transparent;
            this.lblDailyProductionResetTime_.Depth = 0;
            this.lblDailyProductionResetTime_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDailyProductionResetTime_.Location = new System.Drawing.Point(531, 50);
            this.lblDailyProductionResetTime_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDailyProductionResetTime_.Name = "lblDailyProductionResetTime_";
            this.lblDailyProductionResetTime_.Size = new System.Drawing.Size(103, 18);
            this.lblDailyProductionResetTime_.TabIndex = 15;
            this.lblDailyProductionResetTime_.Text = "Manage Time";
            // 
            // dtpDailyProdResetTime
            // 
            this.dtpDailyProdResetTime.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtpDailyProdResetTime.CustomFormat = "HH:mm";
            this.dtpDailyProdResetTime.FocusedPartColor = System.Drawing.SystemColors.Highlight;
            this.dtpDailyProdResetTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDailyProdResetTime.Location = new System.Drawing.Point(740, 49);
            this.dtpDailyProdResetTime.Name = "dtpDailyProdResetTime";
            this.dtpDailyProdResetTime.ShowUpDown = true;
            this.dtpDailyProdResetTime.Size = new System.Drawing.Size(116, 21);
            this.dtpDailyProdResetTime.TabIndex = 32;
            this.dtpDailyProdResetTime.ValueChanged += new System.EventHandler(this.dtpDailyProdResetTime_ValueChanged);
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.btnLogPath);
            this.materialCard5.Controls.Add(this.tbLogPath);
            this.materialCard5.Controls.Add(this.lblLogSavePath_);
            this.materialCard5.Controls.Add(this.lblLogPath_);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(14, 168);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(1371, 122);
            this.materialCard5.TabIndex = 14;
            // 
            // btnLogPath
            // 
            this.btnLogPath.AutoSize = false;
            this.btnLogPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogPath.CustomBackColor = System.Drawing.Color.Empty;
            this.btnLogPath.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogPath.Depth = 0;
            this.btnLogPath.HighEmphasis = true;
            this.btnLogPath.Icon = null;
            this.btnLogPath.Location = new System.Drawing.Point(871, 46);
            this.btnLogPath.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogPath.Name = "btnLogPath";
            this.btnLogPath.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogPath.Size = new System.Drawing.Size(70, 30);
            this.btnLogPath.TabIndex = 12;
            this.btnLogPath.Text = "...";
            this.btnLogPath.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogPath.UseAccentColor = false;
            this.btnLogPath.UseVisualStyleBackColor = true;
            this.btnLogPath.Click += new System.EventHandler(this.btnLogPath_Click);
            // 
            // tbLogPath
            // 
            this.tbLogPath.AnimateReadOnly = false;
            this.tbLogPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbLogPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbLogPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbLogPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbLogPath.Depth = 0;
            this.tbLogPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbLogPath.HideSelection = true;
            this.tbLogPath.LeadingIcon = null;
            this.tbLogPath.Location = new System.Drawing.Point(596, 50);
            this.tbLogPath.MaxLength = 32767;
            this.tbLogPath.MouseState = MaterialSkin.MouseState.OUT;
            this.tbLogPath.Name = "tbLogPath";
            this.tbLogPath.PasswordChar = '\0';
            this.tbLogPath.PrefixSuffixText = null;
            this.tbLogPath.ReadOnly = true;
            this.tbLogPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbLogPath.SelectedText = "";
            this.tbLogPath.SelectionLength = 0;
            this.tbLogPath.SelectionStart = 0;
            this.tbLogPath.ShortcutsEnabled = true;
            this.tbLogPath.Size = new System.Drawing.Size(250, 26);
            this.tbLogPath.TabIndex = 11;
            this.tbLogPath.TabStop = false;
            this.tbLogPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbLogPath.TrailingIcon = null;
            this.tbLogPath.UseSystemPasswordChar = false;
            this.tbLogPath.UseTallSize = false;
            // 
            // lblLogSavePath_
            // 
            this.lblLogSavePath_.AutoSize = true;
            this.lblLogSavePath_.BackColor = System.Drawing.Color.Transparent;
            this.lblLogSavePath_.Depth = 0;
            this.lblLogSavePath_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLogSavePath_.Location = new System.Drawing.Point(5, 5);
            this.lblLogSavePath_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLogSavePath_.Name = "lblLogSavePath_";
            this.lblLogSavePath_.Size = new System.Drawing.Size(109, 18);
            this.lblLogSavePath_.TabIndex = 30;
            this.lblLogSavePath_.Text = "Log Save Path";
            // 
            // lblLogPath_
            // 
            this.lblLogPath_.AutoSize = true;
            this.lblLogPath_.BackColor = System.Drawing.Color.Transparent;
            this.lblLogPath_.Depth = 0;
            this.lblLogPath_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLogPath_.Location = new System.Drawing.Point(413, 55);
            this.lblLogPath_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLogPath_.Name = "lblLogPath_";
            this.lblLogPath_.Size = new System.Drawing.Size(69, 18);
            this.lblLogPath_.TabIndex = 7;
            this.lblLogPath_.Text = "Log Path";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.cmbUiLogLev);
            this.materialCard3.Controls.Add(this.cmbFileLogLev);
            this.materialCard3.Controls.Add(this.lblUILogLev_);
            this.materialCard3.Controls.Add(this.lblFileLogLev_);
            this.materialCard3.Controls.Add(this.lblLogLabel_);
            this.materialCard3.Depth = 0;
            this.materialCard3.Enabled = false;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(14, 10);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(1371, 147);
            this.materialCard3.TabIndex = 14;
            // 
            // cmbUiLogLev
            // 
            this.cmbUiLogLev.AutoResize = false;
            this.cmbUiLogLev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbUiLogLev.Depth = 0;
            this.cmbUiLogLev.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbUiLogLev.DropDownHeight = 102;
            this.cmbUiLogLev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUiLogLev.DropDownWidth = 121;
            this.cmbUiLogLev.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbUiLogLev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbUiLogLev.FormattingEnabled = true;
            this.cmbUiLogLev.IntegralHeight = false;
            this.cmbUiLogLev.ItemHeight = 25;
            this.cmbUiLogLev.Location = new System.Drawing.Point(871, 55);
            this.cmbUiLogLev.MaxDropDownItems = 4;
            this.cmbUiLogLev.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbUiLogLev.Name = "cmbUiLogLev";
            this.cmbUiLogLev.Size = new System.Drawing.Size(121, 31);
            this.cmbUiLogLev.StartIndex = 0;
            this.cmbUiLogLev.TabIndex = 1;
            this.cmbUiLogLev.UseTallSize = false;
            this.cmbUiLogLev.SelectedIndexChanged += new System.EventHandler(this.cmbUiLogLev_SelectedIndexChanged);
            // 
            // cmbFileLogLev
            // 
            this.cmbFileLogLev.AutoResize = false;
            this.cmbFileLogLev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbFileLogLev.Depth = 0;
            this.cmbFileLogLev.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbFileLogLev.DropDownHeight = 102;
            this.cmbFileLogLev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFileLogLev.DropDownWidth = 121;
            this.cmbFileLogLev.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbFileLogLev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbFileLogLev.FormattingEnabled = true;
            this.cmbFileLogLev.IntegralHeight = false;
            this.cmbFileLogLev.ItemHeight = 25;
            this.cmbFileLogLev.Location = new System.Drawing.Point(498, 55);
            this.cmbFileLogLev.MaxDropDownItems = 4;
            this.cmbFileLogLev.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbFileLogLev.Name = "cmbFileLogLev";
            this.cmbFileLogLev.Size = new System.Drawing.Size(121, 31);
            this.cmbFileLogLev.StartIndex = 0;
            this.cmbFileLogLev.TabIndex = 1;
            this.cmbFileLogLev.UseTallSize = false;
            this.cmbFileLogLev.SelectedIndexChanged += new System.EventHandler(this.cmbFileLogLev_SelectedIndexChanged);
            // 
            // lblUILogLev_
            // 
            this.lblUILogLev_.AutoSize = true;
            this.lblUILogLev_.BackColor = System.Drawing.Color.Transparent;
            this.lblUILogLev_.Depth = 0;
            this.lblUILogLev_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUILogLev_.Location = new System.Drawing.Point(761, 63);
            this.lblUILogLev_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUILogLev_.Name = "lblUILogLev_";
            this.lblUILogLev_.Size = new System.Drawing.Size(92, 18);
            this.lblUILogLev_.TabIndex = 30;
            this.lblUILogLev_.Text = "UI Log Level";
            // 
            // lblFileLogLev_
            // 
            this.lblFileLogLev_.AutoSize = true;
            this.lblFileLogLev_.BackColor = System.Drawing.Color.Transparent;
            this.lblFileLogLev_.Depth = 0;
            this.lblFileLogLev_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFileLogLev_.Location = new System.Drawing.Point(380, 63);
            this.lblFileLogLev_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFileLogLev_.Name = "lblFileLogLev_";
            this.lblFileLogLev_.Size = new System.Drawing.Size(103, 18);
            this.lblFileLogLev_.TabIndex = 30;
            this.lblFileLogLev_.Text = "File Log Level";
            // 
            // lblLogLabel_
            // 
            this.lblLogLabel_.AutoSize = true;
            this.lblLogLabel_.BackColor = System.Drawing.Color.Transparent;
            this.lblLogLabel_.Depth = 0;
            this.lblLogLabel_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLogLabel_.Location = new System.Drawing.Point(5, 5);
            this.lblLogLabel_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLogLabel_.Name = "lblLogLabel_";
            this.lblLogLabel_.Size = new System.Drawing.Size(73, 18);
            this.lblLogLabel_.TabIndex = 0;
            this.lblLogLabel_.Text = "Log Level";
            // 
            // btnUpdateMasterData_
            // 
            this.btnUpdateMasterData_.AutoSize = false;
            this.btnUpdateMasterData_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateMasterData_.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateMasterData_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnUpdateMasterData_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdateMasterData_.Depth = 0;
            this.btnUpdateMasterData_.HighEmphasis = true;
            this.btnUpdateMasterData_.Icon = null;
            this.btnUpdateMasterData_.Location = new System.Drawing.Point(1184, 6);
            this.btnUpdateMasterData_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdateMasterData_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdateMasterData_.Name = "btnUpdateMasterData_";
            this.btnUpdateMasterData_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdateMasterData_.Size = new System.Drawing.Size(219, 36);
            this.btnUpdateMasterData_.TabIndex = 31;
            this.btnUpdateMasterData_.Text = "Update MasterData";
            this.btnUpdateMasterData_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdateMasterData_.UseAccentColor = false;
            this.btnUpdateMasterData_.UseVisualStyleBackColor = false;
            this.btnUpdateMasterData_.Click += new System.EventHandler(this.btnUpdateMasterData__Click);
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.AutoResize = false;
            this.cmbLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbLanguage.Depth = 0;
            this.cmbLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbLanguage.DropDownHeight = 102;
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.DropDownWidth = 121;
            this.cmbLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.IntegralHeight = false;
            this.cmbLanguage.ItemHeight = 25;
            this.cmbLanguage.Location = new System.Drawing.Point(277, 7);
            this.cmbLanguage.MaxDropDownItems = 4;
            this.cmbLanguage.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(121, 31);
            this.cmbLanguage.StartIndex = 0;
            this.cmbLanguage.TabIndex = 30;
            this.cmbLanguage.UseTallSize = false;
            this.cmbLanguage.Visible = false;
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage_SelectedIndexChanged);
            // 
            // btnChangePassword_
            // 
            this.btnChangePassword_.AutoSize = false;
            this.btnChangePassword_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChangePassword_.BackColor = System.Drawing.SystemColors.Control;
            this.btnChangePassword_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnChangePassword_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnChangePassword_.Depth = 0;
            this.btnChangePassword_.HighEmphasis = true;
            this.btnChangePassword_.Icon = null;
            this.btnChangePassword_.Location = new System.Drawing.Point(138, 6);
            this.btnChangePassword_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChangePassword_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChangePassword_.Name = "btnChangePassword_";
            this.btnChangePassword_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnChangePassword_.Size = new System.Drawing.Size(126, 36);
            this.btnChangePassword_.TabIndex = 6;
            this.btnChangePassword_.Text = "Change Password";
            this.btnChangePassword_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnChangePassword_.UseAccentColor = false;
            this.btnChangePassword_.UseVisualStyleBackColor = false;
            this.btnChangePassword_.Visible = false;
            this.btnChangePassword_.Click += new System.EventHandler(this.btnChangePassword__Click);
            // 
            // btnFactoryReset_
            // 
            this.btnFactoryReset_.AutoSize = false;
            this.btnFactoryReset_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFactoryReset_.BackColor = System.Drawing.SystemColors.Control;
            this.btnFactoryReset_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnFactoryReset_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFactoryReset_.Depth = 0;
            this.btnFactoryReset_.HighEmphasis = true;
            this.btnFactoryReset_.Icon = null;
            this.btnFactoryReset_.Location = new System.Drawing.Point(4, 6);
            this.btnFactoryReset_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFactoryReset_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFactoryReset_.Name = "btnFactoryReset_";
            this.btnFactoryReset_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFactoryReset_.Size = new System.Drawing.Size(126, 36);
            this.btnFactoryReset_.TabIndex = 5;
            this.btnFactoryReset_.Text = "Factory Reset";
            this.btnFactoryReset_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFactoryReset_.UseAccentColor = false;
            this.btnFactoryReset_.UseVisualStyleBackColor = false;
            this.btnFactoryReset_.Visible = false;
            this.btnFactoryReset_.Click += new System.EventHandler(this.btnFactoryReset__Click);
            // 
            // btnSaveFactorySettings
            // 
            this.btnSaveFactorySettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveFactorySettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveFactorySettings.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSaveFactorySettings.FlatAppearance.BorderSize = 0;
            this.btnSaveFactorySettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSaveFactorySettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSaveFactorySettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFactorySettings.Location = new System.Drawing.Point(0, 0);
            this.btnSaveFactorySettings.Name = "btnSaveFactorySettings";
            this.btnSaveFactorySettings.Size = new System.Drawing.Size(1407, 59);
            this.btnSaveFactorySettings.TabIndex = 30;
            this.btnSaveFactorySettings.TabStop = false;
            this.btnSaveFactorySettings.UseVisualStyleBackColor = false;
            this.btnSaveFactorySettings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSaveFactorySettings_MouseDown);
            this.btnSaveFactorySettings.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSaveFactorySettings_MouseUp);
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(11, 103);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(256, 1);
            this.materialDivider3.TabIndex = 19;
            this.materialDivider3.Text = "materialDivider1";
            // 
            // lblSaveData_
            // 
            this.lblSaveData_.AutoSize = true;
            this.lblSaveData_.BackColor = System.Drawing.Color.Transparent;
            this.lblSaveData_.Depth = 0;
            this.lblSaveData_.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSaveData_.Location = new System.Drawing.Point(11, 117);
            this.lblSaveData_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSaveData_.Name = "lblSaveData_";
            this.lblSaveData_.Size = new System.Drawing.Size(76, 18);
            this.lblSaveData_.TabIndex = 15;
            this.lblSaveData_.Text = "Save Data";
            // 
            // fileBrowserDialog
            // 
            this.fileBrowserDialog.FileName = "fileBrowserDialog";
            // 
            // CargoBox2DSettingManagerForm_
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1413, 799);
            this.Controls.Add(this.splitContainer1);
            this.DrawerTabControl = this.SettingManagerTabControl;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CargoBox2DSettingManagerForm_";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CargoBox2DSettingManagerForm_FormClosing);
            this.Load += new System.EventHandler(this.CargoBox2DSettingManagerForm_Load);
            this.ctxtMenuCameraDel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.SettingManagerTabControl.ResumeLayout(false);
            this.ConfigDict_.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gbRootFolderPaths_.ResumeLayout(false);
            this.gbRootFolderPaths_.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.gbModelFilePath_.ResumeLayout(false);
            this.gbModelFilePath_.PerformLayout();
            this.cardCamera.ResumeLayout(false);
            this.cardCamera.PerformLayout();
            this.cardCarType.ResumeLayout(false);
            this.cardCarType.PerformLayout();
            this.cardPlc.ResumeLayout(false);
            this.cardPlc.PerformLayout();
            this.Logging_.ResumeLayout(false);
            this.materialCard6.ResumeLayout(false);
            this.materialCard6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLogPeriodCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCsvPeriodCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericImgPeriodCount)).EndInit();
            this.materialCard7.ResumeLayout(false);
            this.materialCard7.PerformLayout();
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSaveFactorySettings;
        private System.Windows.Forms.ContextMenuStrip ctxtMenuCameraDel;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem_;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem_;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private MaterialSkin.Controls.MaterialTabControl SettingManagerTabControl;
        private System.Windows.Forms.TabPage ConfigDict_;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PropertyGrid taskGrid;
        private System.Windows.Forms.TabPage Cam2DConfigs_;
        private System.Windows.Forms.TabPage LightConfigs_;
        private System.Windows.Forms.TabPage PlcConfigs_;
        private System.Windows.Forms.TabPage Logging_;
        private System.Windows.Forms.NumericUpDown numericLogPeriodCount;
        private System.Windows.Forms.NumericUpDown numericCsvPeriodCount;
        private System.Windows.Forms.NumericUpDown numericImgPeriodCount;
        private MaterialSkin.Controls.MaterialLabel lblLight_;
        private MaterialSkin.Controls.MaterialComboBox cmbLight;
        private MaterialSkin.Controls.MaterialCard cardCamera;
        private MaterialSkin.Controls.MaterialLabel lblCamera_;
        private MaterialSkin.Controls.MaterialComboBox cmbCamera;
        private MaterialSkin.Controls.MaterialCard cardPlc;
        private MaterialSkin.Controls.MaterialLabel lblPlc_;
        private MaterialSkin.Controls.MaterialComboBox cmbPlc;
        private MaterialSkin.Controls.MaterialButton btnCopyCarType_;
        private MaterialSkin.Controls.MaterialButton btnRemoveCarType_;
        private MaterialSkin.Controls.MaterialButton btnAddCarType_;
        private MaterialSkin.Controls.MaterialLabel lblSaveData_;
        private MaterialSkin.Controls.MaterialButton btnFactoryReset_;
        private MaterialSkin.Controls.MaterialButton btnChangePassword_;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialComboBox cmbLanguage;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialButton btnDeleteSchedule_;
        private MaterialSkin.Controls.MaterialButton btnRegisterSchedule_;
        private MaterialSkin.Controls.MaterialLabel lblCsvLastingPeriod_;
        private MaterialSkin.Controls.MaterialLabel lblImgLastingPeriod_;
        private MaterialSkin.Controls.MaterialLabel lblLogLastingPeriod_;
        private MaterialSkin.Controls.MaterialLabel lblScheduleStartTime_;
        private MaterialSkin.Controls.MaterialLabel lblLogMgrScheduler_;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialButton btnLogPath;
        private MaterialSkin.Controls.MaterialTextBox2 tbLogPath;
        private MaterialSkin.Controls.MaterialLabel lblLogPath_;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialComboBox cmbUiLogLev;
        private MaterialSkin.Controls.MaterialComboBox cmbFileLogLev;
        private MaterialSkin.Controls.MaterialLabel lblUILogLev_;
        private MaterialSkin.Controls.MaterialLabel lblFileLogLev_;
        private MaterialSkin.Controls.MaterialLabel lblLogLabel_;
        private MaterialSkin.Controls.MaterialTextBox2 tbModelPath;
        private MaterialSkin.Controls.MaterialButton btnModelPath;
        private MaterialSkin.Controls.MaterialTextBox2 tbCarType;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialLabel lblDailyProduction_;
        private MaterialSkin.Controls.MaterialLabel lblDailyProductionResetTime_;
        private MaterialSkin.Controls.MaterialCard cardCarType;
        private MaterialSkin.Controls.MaterialLabel lblCarType_;
        private MaterialSkin.Controls.MaterialComboBox cmbCarType;
        private MaterialSkin.Controls.MaterialCard gbModelFilePath_;
        private MaterialSkin.Controls.MaterialLabel lblModelFilePaths_;
        private MaterialSkin.Controls.MaterialLabel lblShiftModel_;
        private MaterialSkin.Controls.MaterialLabel lblLogSavePath_;
        private CoPick.Controls.CleTimePicker dtpScheduleStartTime;
        private CoPick.Controls.CleTimePicker dtpDailyProdResetTime;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialComboBox cmbRobot_;
        private MaterialSkin.Controls.MaterialLabel lblRobot_;
        private MaterialSkin.Controls.MaterialCard gbRootFolderPaths_;
        private MaterialSkin.Controls.MaterialButton btnCalibrationRootFolderPath_;
        private MaterialSkin.Controls.MaterialTextBox2 tbCalibrationRootFolderPath;
        private MaterialSkin.Controls.MaterialLabel lblCalibrationRootFolderPath_;
        private MaterialSkin.Controls.MaterialTextBox2 tbMasterImageRootPath;
        private MaterialSkin.Controls.MaterialTextBox2 tbCheckerBoardRootPath;
        private MaterialSkin.Controls.MaterialLabel lblMasterImageFilePath;
        private MaterialSkin.Controls.MaterialLabel lblCharucoFilePath;
        private MaterialSkin.Controls.MaterialLabel lblImageRootFolderPath_;
        private MaterialSkin.Controls.MaterialButton btnMasterImageFilePath;
        private MaterialSkin.Controls.MaterialButton btnCharucoFilePath;
        private MaterialSkin.Controls.MaterialButton btnCameraTcpFilePath;
        private MaterialSkin.Controls.MaterialTextBox2 tbCameraTcpFilePath;
        private MaterialSkin.Controls.MaterialLabel lblCameraTcp;
        private TabPage RobotConfig_;
        private MaterialSkin.Controls.MaterialButton btnUpdateMasterData_;
        private OpenFileDialog fileBrowserDialog;
    }
}