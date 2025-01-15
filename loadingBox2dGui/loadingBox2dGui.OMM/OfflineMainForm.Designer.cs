namespace loadingBox2dGui.OMM
{
    partial class OfflineMainForm
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
            this.InspectionTabs = new System.Windows.Forms.TabControl();
            this.tabModelChecker = new System.Windows.Forms.TabPage();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.lvOfflineSourceImages_ = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cardModelConfig_ = new MaterialSkin.Controls.MaterialCard();
            this.btnSetEngineVerbosity_ = new MaterialSkin.Controls.MaterialButton();
            this.tbVerbosityImgLvl_ = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbVerbosityLogLvl_ = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblSetEngineVerbosity_ = new MaterialSkin.Controls.MaterialLabel();
            this.cmbModelSelection_ = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.tbOfflineSourceImageRootPath_ = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnSetOfflineRootPath_ = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.tbConfidenceScore_ = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.tbDetectedRefHoleCount_ = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.lblModelPerformance = new MaterialSkin.Controls.MaterialLabel();
            this.tabOfflineAligner = new System.Windows.Forms.TabPage();
            this.tbOfflineImageRootPath_ = new MaterialSkin.Controls.MaterialTextBox2();
            this.dgvOfflineInspectionRecordPaths_ = new System.Windows.Forms.DataGridView();
            this.btnSetOfflineImageRootPath_ = new MaterialSkin.Controls.MaterialButton();
            this.rtbLog = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.tbAlignerMaxDetectedRefHoleCount_ = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tbAlignerMinConfidenceScore_ = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblModelPerformance_ = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.tbAlignerMaxAbsRefSizeDiff_ = new MaterialSkin.Controls.MaterialTextBox2();
            this.gbRobotWrite = new MaterialSkin.Controls.MaterialCard();
            this.tbShiftRz = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.tbShiftTx = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.lblShiftPoseRxyz_ = new MaterialSkin.Controls.MaterialLabel();
            this.tbShiftTy = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard15 = new MaterialSkin.Controls.MaterialCard();
            this.lblRH_ = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard14 = new MaterialSkin.Controls.MaterialCard();
            this.lblLH_ = new MaterialSkin.Controls.MaterialLabel();
            this.tabOfflineArUcoAligner = new System.Windows.Forms.TabPage();
            this.cardInspectingComponent = new MaterialSkin.Controls.MaterialCard();
            this.lblCamera_ = new MaterialSkin.Controls.MaterialLabel();
            this.cmbCarType_ = new MaterialSkin.Controls.MaterialComboBox();
            this.tbConfigFilePath_ = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnSetConfigPath_ = new MaterialSkin.Controls.MaterialButton();
            this.OfflineMainViewSplitContainer = new System.Windows.Forms.SplitContainer();
            this.btnSettingManage_ = new MaterialSkin.Controls.MaterialButton();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSetModelPath_ = new MaterialSkin.Controls.MaterialButton();
            this.pbModel = new System.Windows.Forms.PictureBox();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.pbRh = new System.Windows.Forms.PictureBox();
            this.pbLh = new System.Windows.Forms.PictureBox();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.InspectionTabs.SuspendLayout();
            this.tabModelChecker.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.cardModelConfig_.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tabOfflineAligner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfflineInspectionRecordPaths_)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.gbRobotWrite.SuspendLayout();
            this.materialCard15.SuspendLayout();
            this.materialCard14.SuspendLayout();
            this.cardInspectingComponent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OfflineMainViewSplitContainer)).BeginInit();
            this.OfflineMainViewSplitContainer.Panel1.SuspendLayout();
            this.OfflineMainViewSplitContainer.Panel2.SuspendLayout();
            this.OfflineMainViewSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLh)).BeginInit();
            this.materialCard4.SuspendLayout();
            this.SuspendLayout();
            // 
            // InspectionTabs
            // 
            this.InspectionTabs.Controls.Add(this.tabModelChecker);
            this.InspectionTabs.Controls.Add(this.tabOfflineAligner);
            this.InspectionTabs.Controls.Add(this.tabOfflineArUcoAligner);
            this.InspectionTabs.Location = new System.Drawing.Point(0, 0);
            this.InspectionTabs.Name = "InspectionTabs";
            this.InspectionTabs.SelectedIndex = 0;
            this.InspectionTabs.Size = new System.Drawing.Size(1274, 604);
            this.InspectionTabs.TabIndex = 0;
            // 
            // tabModelChecker
            // 
            this.tabModelChecker.Controls.Add(this.materialCard4);
            this.tabModelChecker.Controls.Add(this.materialCard3);
            this.tabModelChecker.Controls.Add(this.cardModelConfig_);
            this.tabModelChecker.Controls.Add(this.tbOfflineSourceImageRootPath_);
            this.tabModelChecker.Controls.Add(this.btnSetOfflineRootPath_);
            this.tabModelChecker.Controls.Add(this.materialCard1);
            this.tabModelChecker.Controls.Add(this.pbModel);
            this.tabModelChecker.Location = new System.Drawing.Point(4, 22);
            this.tabModelChecker.Name = "tabModelChecker";
            this.tabModelChecker.Padding = new System.Windows.Forms.Padding(3);
            this.tabModelChecker.Size = new System.Drawing.Size(1266, 578);
            this.tabModelChecker.TabIndex = 0;
            this.tabModelChecker.Text = "ModelChecker";
            this.tabModelChecker.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.lvOfflineSourceImages_);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(753, 89);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(507, 209);
            this.materialCard3.TabIndex = 198;
            // 
            // lvOfflineSourceImages_
            // 
            this.lvOfflineSourceImages_.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvOfflineSourceImages_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvOfflineSourceImages_.FullRowSelect = true;
            this.lvOfflineSourceImages_.GridLines = true;
            this.lvOfflineSourceImages_.HideSelection = false;
            this.lvOfflineSourceImages_.Location = new System.Drawing.Point(14, 14);
            this.lvOfflineSourceImages_.MultiSelect = false;
            this.lvOfflineSourceImages_.Name = "lvOfflineSourceImages_";
            this.lvOfflineSourceImages_.Size = new System.Drawing.Size(479, 181);
            this.lvOfflineSourceImages_.TabIndex = 0;
            this.lvOfflineSourceImages_.UseCompatibleStateImageBehavior = false;
            this.lvOfflineSourceImages_.View = System.Windows.Forms.View.Details;
            this.lvOfflineSourceImages_.SelectedIndexChanged += new System.EventHandler(this.lvOfflineSourceImages__SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Filename";
            this.columnHeader1.Width = 477;
            // 
            // cardModelConfig_
            // 
            this.cardModelConfig_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardModelConfig_.Controls.Add(this.btnSetEngineVerbosity_);
            this.cardModelConfig_.Controls.Add(this.tbVerbosityImgLvl_);
            this.cardModelConfig_.Controls.Add(this.tbVerbosityLogLvl_);
            this.cardModelConfig_.Controls.Add(this.materialLabel6);
            this.cardModelConfig_.Controls.Add(this.materialLabel3);
            this.cardModelConfig_.Controls.Add(this.lblSetEngineVerbosity_);
            this.cardModelConfig_.Depth = 0;
            this.cardModelConfig_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardModelConfig_.Location = new System.Drawing.Point(550, 4);
            this.cardModelConfig_.Margin = new System.Windows.Forms.Padding(14);
            this.cardModelConfig_.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardModelConfig_.Name = "cardModelConfig_";
            this.cardModelConfig_.Padding = new System.Windows.Forms.Padding(14);
            this.cardModelConfig_.Size = new System.Drawing.Size(198, 149);
            this.cardModelConfig_.TabIndex = 198;
            // 
            // btnSetEngineVerbosity_
            // 
            this.btnSetEngineVerbosity_.AutoSize = false;
            this.btnSetEngineVerbosity_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSetEngineVerbosity_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnSetEngineVerbosity_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSetEngineVerbosity_.Depth = 0;
            this.btnSetEngineVerbosity_.HighEmphasis = true;
            this.btnSetEngineVerbosity_.Icon = null;
            this.btnSetEngineVerbosity_.Location = new System.Drawing.Point(88, 101);
            this.btnSetEngineVerbosity_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSetEngineVerbosity_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSetEngineVerbosity_.Name = "btnSetEngineVerbosity_";
            this.btnSetEngineVerbosity_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSetEngineVerbosity_.Size = new System.Drawing.Size(80, 26);
            this.btnSetEngineVerbosity_.TabIndex = 42;
            this.btnSetEngineVerbosity_.Text = "Set";
            this.btnSetEngineVerbosity_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSetEngineVerbosity_.UseAccentColor = false;
            this.btnSetEngineVerbosity_.UseVisualStyleBackColor = true;
            this.btnSetEngineVerbosity_.Click += new System.EventHandler(this.btnSetEngineVerbosity__Click);
            // 
            // tbVerbosityImgLvl_
            // 
            this.tbVerbosityImgLvl_.AnimateReadOnly = false;
            this.tbVerbosityImgLvl_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbVerbosityImgLvl_.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbVerbosityImgLvl_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbVerbosityImgLvl_.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbVerbosityImgLvl_.Depth = 0;
            this.tbVerbosityImgLvl_.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbVerbosityImgLvl_.HideSelection = true;
            this.tbVerbosityImgLvl_.LeadingIcon = null;
            this.tbVerbosityImgLvl_.Location = new System.Drawing.Point(88, 66);
            this.tbVerbosityImgLvl_.MaxLength = 32767;
            this.tbVerbosityImgLvl_.MouseState = MaterialSkin.MouseState.OUT;
            this.tbVerbosityImgLvl_.Name = "tbVerbosityImgLvl_";
            this.tbVerbosityImgLvl_.PasswordChar = '\0';
            this.tbVerbosityImgLvl_.PrefixSuffixText = null;
            this.tbVerbosityImgLvl_.ReadOnly = false;
            this.tbVerbosityImgLvl_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbVerbosityImgLvl_.SelectedText = "";
            this.tbVerbosityImgLvl_.SelectionLength = 0;
            this.tbVerbosityImgLvl_.SelectionStart = 0;
            this.tbVerbosityImgLvl_.ShortcutsEnabled = true;
            this.tbVerbosityImgLvl_.Size = new System.Drawing.Size(84, 26);
            this.tbVerbosityImgLvl_.TabIndex = 187;
            this.tbVerbosityImgLvl_.TabStop = false;
            this.tbVerbosityImgLvl_.Text = "2";
            this.tbVerbosityImgLvl_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbVerbosityImgLvl_.TrailingIcon = null;
            this.tbVerbosityImgLvl_.UseSystemPasswordChar = false;
            this.tbVerbosityImgLvl_.UseTallSize = false;
            // 
            // tbVerbosityLogLvl_
            // 
            this.tbVerbosityLogLvl_.AnimateReadOnly = false;
            this.tbVerbosityLogLvl_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbVerbosityLogLvl_.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbVerbosityLogLvl_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbVerbosityLogLvl_.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbVerbosityLogLvl_.Depth = 0;
            this.tbVerbosityLogLvl_.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbVerbosityLogLvl_.HideSelection = true;
            this.tbVerbosityLogLvl_.LeadingIcon = null;
            this.tbVerbosityLogLvl_.Location = new System.Drawing.Point(88, 32);
            this.tbVerbosityLogLvl_.MaxLength = 32767;
            this.tbVerbosityLogLvl_.MouseState = MaterialSkin.MouseState.OUT;
            this.tbVerbosityLogLvl_.Name = "tbVerbosityLogLvl_";
            this.tbVerbosityLogLvl_.PasswordChar = '\0';
            this.tbVerbosityLogLvl_.PrefixSuffixText = null;
            this.tbVerbosityLogLvl_.ReadOnly = false;
            this.tbVerbosityLogLvl_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbVerbosityLogLvl_.SelectedText = "";
            this.tbVerbosityLogLvl_.SelectionLength = 0;
            this.tbVerbosityLogLvl_.SelectionStart = 0;
            this.tbVerbosityLogLvl_.ShortcutsEnabled = true;
            this.tbVerbosityLogLvl_.Size = new System.Drawing.Size(84, 26);
            this.tbVerbosityLogLvl_.TabIndex = 186;
            this.tbVerbosityLogLvl_.TabStop = false;
            this.tbVerbosityLogLvl_.Text = "2";
            this.tbVerbosityLogLvl_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbVerbosityLogLvl_.TrailingIcon = null;
            this.tbVerbosityLogLvl_.UseSystemPasswordChar = false;
            this.tbVerbosityLogLvl_.UseTallSize = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(11, 74);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(55, 18);
            this.materialLabel6.TabIndex = 14;
            this.materialLabel6.Text = "Img Lvl";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(11, 40);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(55, 18);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "Log Lvl";
            // 
            // lblSetEngineVerbosity_
            // 
            this.lblSetEngineVerbosity_.AutoSize = true;
            this.lblSetEngineVerbosity_.BackColor = System.Drawing.Color.Transparent;
            this.lblSetEngineVerbosity_.Depth = 0;
            this.lblSetEngineVerbosity_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSetEngineVerbosity_.Location = new System.Drawing.Point(11, 10);
            this.lblSetEngineVerbosity_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSetEngineVerbosity_.Name = "lblSetEngineVerbosity_";
            this.lblSetEngineVerbosity_.Size = new System.Drawing.Size(161, 18);
            this.lblSetEngineVerbosity_.TabIndex = 12;
            this.lblSetEngineVerbosity_.Text = "Set Engine Verbosity";
            // 
            // cmbModelSelection_
            // 
            this.cmbModelSelection_.AutoResize = false;
            this.cmbModelSelection_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbModelSelection_.Depth = 0;
            this.cmbModelSelection_.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbModelSelection_.DropDownHeight = 102;
            this.cmbModelSelection_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelSelection_.DropDownWidth = 121;
            this.cmbModelSelection_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbModelSelection_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbModelSelection_.FormattingEnabled = true;
            this.cmbModelSelection_.IntegralHeight = false;
            this.cmbModelSelection_.ItemHeight = 25;
            this.cmbModelSelection_.Location = new System.Drawing.Point(0, 6);
            this.cmbModelSelection_.MaxDropDownItems = 4;
            this.cmbModelSelection_.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbModelSelection_.Name = "cmbModelSelection_";
            this.cmbModelSelection_.Size = new System.Drawing.Size(383, 31);
            this.cmbModelSelection_.StartIndex = 0;
            this.cmbModelSelection_.TabIndex = 11;
            this.cmbModelSelection_.UseTallSize = false;
            this.cmbModelSelection_.SelectedIndexChanged += new System.EventHandler(this.cmbModelSelection__SelectedIndexChanged);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(389, 9);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(48, 18);
            this.materialLabel8.TabIndex = 7;
            this.materialLabel8.Text = "Model";
            // 
            // tbOfflineSourceImageRootPath_
            // 
            this.tbOfflineSourceImageRootPath_.AnimateReadOnly = false;
            this.tbOfflineSourceImageRootPath_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbOfflineSourceImageRootPath_.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbOfflineSourceImageRootPath_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbOfflineSourceImageRootPath_.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbOfflineSourceImageRootPath_.Depth = 0;
            this.tbOfflineSourceImageRootPath_.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbOfflineSourceImageRootPath_.HideSelection = true;
            this.tbOfflineSourceImageRootPath_.LeadingIcon = null;
            this.tbOfflineSourceImageRootPath_.Location = new System.Drawing.Point(753, 53);
            this.tbOfflineSourceImageRootPath_.MaxLength = 32767;
            this.tbOfflineSourceImageRootPath_.MouseState = MaterialSkin.MouseState.OUT;
            this.tbOfflineSourceImageRootPath_.Name = "tbOfflineSourceImageRootPath_";
            this.tbOfflineSourceImageRootPath_.PasswordChar = '\0';
            this.tbOfflineSourceImageRootPath_.PrefixSuffixText = null;
            this.tbOfflineSourceImageRootPath_.ReadOnly = false;
            this.tbOfflineSourceImageRootPath_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbOfflineSourceImageRootPath_.SelectedText = "";
            this.tbOfflineSourceImageRootPath_.SelectionLength = 0;
            this.tbOfflineSourceImageRootPath_.SelectionStart = 0;
            this.tbOfflineSourceImageRootPath_.ShortcutsEnabled = true;
            this.tbOfflineSourceImageRootPath_.Size = new System.Drawing.Size(267, 26);
            this.tbOfflineSourceImageRootPath_.TabIndex = 205;
            this.tbOfflineSourceImageRootPath_.TabStop = false;
            this.tbOfflineSourceImageRootPath_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbOfflineSourceImageRootPath_.TrailingIcon = null;
            this.tbOfflineSourceImageRootPath_.UseSystemPasswordChar = false;
            this.tbOfflineSourceImageRootPath_.UseTallSize = false;
            // 
            // btnSetOfflineRootPath_
            // 
            this.btnSetOfflineRootPath_.AutoSize = false;
            this.btnSetOfflineRootPath_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSetOfflineRootPath_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(65)))));
            this.btnSetOfflineRootPath_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnSetOfflineRootPath_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSetOfflineRootPath_.Depth = 0;
            this.btnSetOfflineRootPath_.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSetOfflineRootPath_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetOfflineRootPath_.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnSetOfflineRootPath_.ForeColor = System.Drawing.Color.Black;
            this.btnSetOfflineRootPath_.HighEmphasis = true;
            this.btnSetOfflineRootPath_.Icon = null;
            this.btnSetOfflineRootPath_.Location = new System.Drawing.Point(1027, 53);
            this.btnSetOfflineRootPath_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSetOfflineRootPath_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSetOfflineRootPath_.Name = "btnSetOfflineRootPath_";
            this.btnSetOfflineRootPath_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSetOfflineRootPath_.Size = new System.Drawing.Size(232, 32);
            this.btnSetOfflineRootPath_.TabIndex = 206;
            this.btnSetOfflineRootPath_.Text = "Set Offline Image Root Path";
            this.btnSetOfflineRootPath_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSetOfflineRootPath_.UseAccentColor = false;
            this.btnSetOfflineRootPath_.UseVisualStyleBackColor = false;
            this.btnSetOfflineRootPath_.Click += new System.EventHandler(this.btnSetOfflineRootPath__Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.tbConfidenceScore_);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.tbDetectedRefHoleCount_);
            this.materialCard1.Controls.Add(this.materialLabel7);
            this.materialCard1.Controls.Add(this.lblModelPerformance);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(550, 162);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(198, 157);
            this.materialCard1.TabIndex = 197;
            // 
            // tbConfidenceScore_
            // 
            this.tbConfidenceScore_.AnimateReadOnly = false;
            this.tbConfidenceScore_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbConfidenceScore_.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbConfidenceScore_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbConfidenceScore_.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbConfidenceScore_.Depth = 0;
            this.tbConfidenceScore_.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbConfidenceScore_.HideSelection = true;
            this.tbConfidenceScore_.LeadingIcon = null;
            this.tbConfidenceScore_.Location = new System.Drawing.Point(9, 57);
            this.tbConfidenceScore_.MaxLength = 32767;
            this.tbConfidenceScore_.MouseState = MaterialSkin.MouseState.OUT;
            this.tbConfidenceScore_.Name = "tbConfidenceScore_";
            this.tbConfidenceScore_.PasswordChar = '\0';
            this.tbConfidenceScore_.PrefixSuffixText = null;
            this.tbConfidenceScore_.ReadOnly = false;
            this.tbConfidenceScore_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbConfidenceScore_.SelectedText = "";
            this.tbConfidenceScore_.SelectionLength = 0;
            this.tbConfidenceScore_.SelectionStart = 0;
            this.tbConfidenceScore_.ShortcutsEnabled = true;
            this.tbConfidenceScore_.Size = new System.Drawing.Size(132, 26);
            this.tbConfidenceScore_.TabIndex = 182;
            this.tbConfidenceScore_.TabStop = false;
            this.tbConfidenceScore_.Text = "1";
            this.tbConfidenceScore_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbConfidenceScore_.TrailingIcon = null;
            this.tbConfidenceScore_.UseSystemPasswordChar = false;
            this.tbConfidenceScore_.UseTallSize = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(7, 99);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(186, 18);
            this.materialLabel4.TabIndex = 184;
            this.materialLabel4.Text = "Detected Ref Hole Count";
            // 
            // tbDetectedRefHoleCount_
            // 
            this.tbDetectedRefHoleCount_.AnimateReadOnly = false;
            this.tbDetectedRefHoleCount_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbDetectedRefHoleCount_.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbDetectedRefHoleCount_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbDetectedRefHoleCount_.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbDetectedRefHoleCount_.Depth = 0;
            this.tbDetectedRefHoleCount_.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbDetectedRefHoleCount_.HideSelection = true;
            this.tbDetectedRefHoleCount_.LeadingIcon = null;
            this.tbDetectedRefHoleCount_.Location = new System.Drawing.Point(9, 120);
            this.tbDetectedRefHoleCount_.MaxLength = 32767;
            this.tbDetectedRefHoleCount_.MouseState = MaterialSkin.MouseState.OUT;
            this.tbDetectedRefHoleCount_.Name = "tbDetectedRefHoleCount_";
            this.tbDetectedRefHoleCount_.PasswordChar = '\0';
            this.tbDetectedRefHoleCount_.PrefixSuffixText = null;
            this.tbDetectedRefHoleCount_.ReadOnly = false;
            this.tbDetectedRefHoleCount_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbDetectedRefHoleCount_.SelectedText = "";
            this.tbDetectedRefHoleCount_.SelectionLength = 0;
            this.tbDetectedRefHoleCount_.SelectionStart = 0;
            this.tbDetectedRefHoleCount_.ShortcutsEnabled = true;
            this.tbDetectedRefHoleCount_.Size = new System.Drawing.Size(132, 26);
            this.tbDetectedRefHoleCount_.TabIndex = 185;
            this.tbDetectedRefHoleCount_.TabStop = false;
            this.tbDetectedRefHoleCount_.Text = "2";
            this.tbDetectedRefHoleCount_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDetectedRefHoleCount_.TrailingIcon = null;
            this.tbDetectedRefHoleCount_.UseSystemPasswordChar = false;
            this.tbDetectedRefHoleCount_.UseTallSize = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(7, 36);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(135, 18);
            this.materialLabel7.TabIndex = 7;
            this.materialLabel7.Text = "Confidence Score";
            // 
            // lblModelPerformance
            // 
            this.lblModelPerformance.AutoSize = true;
            this.lblModelPerformance.BackColor = System.Drawing.Color.Transparent;
            this.lblModelPerformance.Depth = 0;
            this.lblModelPerformance.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblModelPerformance.Location = new System.Drawing.Point(7, 14);
            this.lblModelPerformance.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblModelPerformance.Name = "lblModelPerformance";
            this.lblModelPerformance.Size = new System.Drawing.Size(152, 18);
            this.lblModelPerformance.TabIndex = 7;
            this.lblModelPerformance.Text = "Model Performance";
            // 
            // tabOfflineAligner
            // 
            this.tabOfflineAligner.Controls.Add(this.tbOfflineImageRootPath_);
            this.tabOfflineAligner.Controls.Add(this.dgvOfflineInspectionRecordPaths_);
            this.tabOfflineAligner.Controls.Add(this.btnSetOfflineImageRootPath_);
            this.tabOfflineAligner.Controls.Add(this.rtbLog);
            this.tabOfflineAligner.Controls.Add(this.materialCard2);
            this.tabOfflineAligner.Controls.Add(this.gbRobotWrite);
            this.tabOfflineAligner.Controls.Add(this.materialCard15);
            this.tabOfflineAligner.Controls.Add(this.materialCard14);
            this.tabOfflineAligner.Controls.Add(this.pbResult);
            this.tabOfflineAligner.Controls.Add(this.pbRh);
            this.tabOfflineAligner.Controls.Add(this.pbLh);
            this.tabOfflineAligner.Location = new System.Drawing.Point(4, 22);
            this.tabOfflineAligner.Name = "tabOfflineAligner";
            this.tabOfflineAligner.Padding = new System.Windows.Forms.Padding(3);
            this.tabOfflineAligner.Size = new System.Drawing.Size(1266, 578);
            this.tabOfflineAligner.TabIndex = 1;
            this.tabOfflineAligner.Text = "Aligner";
            this.tabOfflineAligner.UseVisualStyleBackColor = true;
            // 
            // tbOfflineImageRootPath_
            // 
            this.tbOfflineImageRootPath_.AnimateReadOnly = false;
            this.tbOfflineImageRootPath_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbOfflineImageRootPath_.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbOfflineImageRootPath_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbOfflineImageRootPath_.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbOfflineImageRootPath_.Depth = 0;
            this.tbOfflineImageRootPath_.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbOfflineImageRootPath_.HideSelection = true;
            this.tbOfflineImageRootPath_.LeadingIcon = null;
            this.tbOfflineImageRootPath_.Location = new System.Drawing.Point(819, 4);
            this.tbOfflineImageRootPath_.MaxLength = 32767;
            this.tbOfflineImageRootPath_.MouseState = MaterialSkin.MouseState.OUT;
            this.tbOfflineImageRootPath_.Name = "tbOfflineImageRootPath_";
            this.tbOfflineImageRootPath_.PasswordChar = '\0';
            this.tbOfflineImageRootPath_.PrefixSuffixText = null;
            this.tbOfflineImageRootPath_.ReadOnly = false;
            this.tbOfflineImageRootPath_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbOfflineImageRootPath_.SelectedText = "";
            this.tbOfflineImageRootPath_.SelectionLength = 0;
            this.tbOfflineImageRootPath_.SelectionStart = 0;
            this.tbOfflineImageRootPath_.ShortcutsEnabled = true;
            this.tbOfflineImageRootPath_.Size = new System.Drawing.Size(204, 26);
            this.tbOfflineImageRootPath_.TabIndex = 42;
            this.tbOfflineImageRootPath_.TabStop = false;
            this.tbOfflineImageRootPath_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbOfflineImageRootPath_.TrailingIcon = null;
            this.tbOfflineImageRootPath_.UseSystemPasswordChar = false;
            this.tbOfflineImageRootPath_.UseTallSize = false;
            // 
            // dgvOfflineInspectionRecordPaths_
            // 
            this.dgvOfflineInspectionRecordPaths_.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOfflineInspectionRecordPaths_.BackgroundColor = System.Drawing.Color.White;
            this.dgvOfflineInspectionRecordPaths_.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOfflineInspectionRecordPaths_.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOfflineInspectionRecordPaths_.Location = new System.Drawing.Point(819, 35);
            this.dgvOfflineInspectionRecordPaths_.MultiSelect = false;
            this.dgvOfflineInspectionRecordPaths_.Name = "dgvOfflineInspectionRecordPaths_";
            this.dgvOfflineInspectionRecordPaths_.ReadOnly = true;
            this.dgvOfflineInspectionRecordPaths_.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvOfflineInspectionRecordPaths_.RowTemplate.Height = 23;
            this.dgvOfflineInspectionRecordPaths_.Size = new System.Drawing.Size(444, 212);
            this.dgvOfflineInspectionRecordPaths_.TabIndex = 204;
            this.dgvOfflineInspectionRecordPaths_.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOfflineInspectionRecordPaths__CellDoubleClick);
            this.dgvOfflineInspectionRecordPaths_.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvOfflineInspectionRecordPaths_DataBindingComplete);
            this.dgvOfflineInspectionRecordPaths_.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvOfflineInspectionRecordPaths_KeyDown);
            // 
            // btnSetOfflineImageRootPath_
            // 
            this.btnSetOfflineImageRootPath_.AutoSize = false;
            this.btnSetOfflineImageRootPath_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSetOfflineImageRootPath_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(65)))));
            this.btnSetOfflineImageRootPath_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnSetOfflineImageRootPath_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSetOfflineImageRootPath_.Depth = 0;
            this.btnSetOfflineImageRootPath_.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSetOfflineImageRootPath_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetOfflineImageRootPath_.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.btnSetOfflineImageRootPath_.ForeColor = System.Drawing.Color.Black;
            this.btnSetOfflineImageRootPath_.HighEmphasis = true;
            this.btnSetOfflineImageRootPath_.Icon = null;
            this.btnSetOfflineImageRootPath_.Location = new System.Drawing.Point(1030, 4);
            this.btnSetOfflineImageRootPath_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSetOfflineImageRootPath_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSetOfflineImageRootPath_.Name = "btnSetOfflineImageRootPath_";
            this.btnSetOfflineImageRootPath_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSetOfflineImageRootPath_.Size = new System.Drawing.Size(232, 32);
            this.btnSetOfflineImageRootPath_.TabIndex = 43;
            this.btnSetOfflineImageRootPath_.Text = "Set Offline Image Root Path";
            this.btnSetOfflineImageRootPath_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSetOfflineImageRootPath_.UseAccentColor = false;
            this.btnSetOfflineImageRootPath_.UseVisualStyleBackColor = false;
            this.btnSetOfflineImageRootPath_.Click += new System.EventHandler(this.btnSetOfflineImageRootPath_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.Depth = 0;
            this.rtbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rtbLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtbLog.Location = new System.Drawing.Point(819, 250);
            this.rtbLog.Margin = new System.Windows.Forms.Padding(0);
            this.rtbLog.MouseState = MaterialSkin.MouseState.HOVER;
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(444, 311);
            this.rtbLog.TabIndex = 202;
            this.rtbLog.Text = "";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.tbAlignerMaxDetectedRefHoleCount_);
            this.materialCard2.Controls.Add(this.materialLabel1);
            this.materialCard2.Controls.Add(this.tbAlignerMinConfidenceScore_);
            this.materialCard2.Controls.Add(this.materialLabel2);
            this.materialCard2.Controls.Add(this.lblModelPerformance_);
            this.materialCard2.Controls.Add(this.materialLabel5);
            this.materialCard2.Controls.Add(this.tbAlignerMaxAbsRefSizeDiff_);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(3, 417);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(372, 144);
            this.materialCard2.TabIndex = 200;
            // 
            // tbAlignerMaxDetectedRefHoleCount_
            // 
            this.tbAlignerMaxDetectedRefHoleCount_.AnimateReadOnly = false;
            this.tbAlignerMaxDetectedRefHoleCount_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbAlignerMaxDetectedRefHoleCount_.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbAlignerMaxDetectedRefHoleCount_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbAlignerMaxDetectedRefHoleCount_.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbAlignerMaxDetectedRefHoleCount_.Depth = 0;
            this.tbAlignerMaxDetectedRefHoleCount_.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbAlignerMaxDetectedRefHoleCount_.HideSelection = true;
            this.tbAlignerMaxDetectedRefHoleCount_.LeadingIcon = null;
            this.tbAlignerMaxDetectedRefHoleCount_.Location = new System.Drawing.Point(232, 96);
            this.tbAlignerMaxDetectedRefHoleCount_.MaxLength = 32767;
            this.tbAlignerMaxDetectedRefHoleCount_.MouseState = MaterialSkin.MouseState.OUT;
            this.tbAlignerMaxDetectedRefHoleCount_.Name = "tbAlignerMaxDetectedRefHoleCount_";
            this.tbAlignerMaxDetectedRefHoleCount_.PasswordChar = '\0';
            this.tbAlignerMaxDetectedRefHoleCount_.PrefixSuffixText = null;
            this.tbAlignerMaxDetectedRefHoleCount_.ReadOnly = false;
            this.tbAlignerMaxDetectedRefHoleCount_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbAlignerMaxDetectedRefHoleCount_.SelectedText = "";
            this.tbAlignerMaxDetectedRefHoleCount_.SelectionLength = 0;
            this.tbAlignerMaxDetectedRefHoleCount_.SelectionStart = 0;
            this.tbAlignerMaxDetectedRefHoleCount_.ShortcutsEnabled = true;
            this.tbAlignerMaxDetectedRefHoleCount_.Size = new System.Drawing.Size(132, 26);
            this.tbAlignerMaxDetectedRefHoleCount_.TabIndex = 181;
            this.tbAlignerMaxDetectedRefHoleCount_.TabStop = false;
            this.tbAlignerMaxDetectedRefHoleCount_.Text = "2";
            this.tbAlignerMaxDetectedRefHoleCount_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbAlignerMaxDetectedRefHoleCount_.TrailingIcon = null;
            this.tbAlignerMaxDetectedRefHoleCount_.UseSystemPasswordChar = false;
            this.tbAlignerMaxDetectedRefHoleCount_.UseTallSize = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(8, 97);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(209, 18);
            this.materialLabel1.TabIndex = 180;
            this.materialLabel1.Text = "Max DetectedRefHoleCount";
            // 
            // tbAlignerMinConfidenceScore_
            // 
            this.tbAlignerMinConfidenceScore_.AnimateReadOnly = false;
            this.tbAlignerMinConfidenceScore_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbAlignerMinConfidenceScore_.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbAlignerMinConfidenceScore_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbAlignerMinConfidenceScore_.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbAlignerMinConfidenceScore_.Depth = 0;
            this.tbAlignerMinConfidenceScore_.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbAlignerMinConfidenceScore_.HideSelection = true;
            this.tbAlignerMinConfidenceScore_.LeadingIcon = null;
            this.tbAlignerMinConfidenceScore_.Location = new System.Drawing.Point(232, 41);
            this.tbAlignerMinConfidenceScore_.MaxLength = 32767;
            this.tbAlignerMinConfidenceScore_.MouseState = MaterialSkin.MouseState.OUT;
            this.tbAlignerMinConfidenceScore_.Name = "tbAlignerMinConfidenceScore_";
            this.tbAlignerMinConfidenceScore_.PasswordChar = '\0';
            this.tbAlignerMinConfidenceScore_.PrefixSuffixText = null;
            this.tbAlignerMinConfidenceScore_.ReadOnly = false;
            this.tbAlignerMinConfidenceScore_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbAlignerMinConfidenceScore_.SelectedText = "";
            this.tbAlignerMinConfidenceScore_.SelectionLength = 0;
            this.tbAlignerMinConfidenceScore_.SelectionStart = 0;
            this.tbAlignerMinConfidenceScore_.ShortcutsEnabled = true;
            this.tbAlignerMinConfidenceScore_.Size = new System.Drawing.Size(132, 26);
            this.tbAlignerMinConfidenceScore_.TabIndex = 6;
            this.tbAlignerMinConfidenceScore_.TabStop = false;
            this.tbAlignerMinConfidenceScore_.Text = "1";
            this.tbAlignerMinConfidenceScore_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbAlignerMinConfidenceScore_.TrailingIcon = null;
            this.tbAlignerMinConfidenceScore_.UseSystemPasswordChar = false;
            this.tbAlignerMinConfidenceScore_.UseTallSize = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(8, 44);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(171, 18);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Min. Confidence Score";
            // 
            // lblModelPerformance_
            // 
            this.lblModelPerformance_.AutoSize = true;
            this.lblModelPerformance_.BackColor = System.Drawing.Color.Transparent;
            this.lblModelPerformance_.Depth = 0;
            this.lblModelPerformance_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblModelPerformance_.Location = new System.Drawing.Point(5, 14);
            this.lblModelPerformance_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblModelPerformance_.Name = "lblModelPerformance_";
            this.lblModelPerformance_.Size = new System.Drawing.Size(152, 18);
            this.lblModelPerformance_.TabIndex = 7;
            this.lblModelPerformance_.Text = "Model Performance";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(8, 72);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(148, 18);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "Max AbsRefSizeDiff";
            // 
            // tbAlignerMaxAbsRefSizeDiff_
            // 
            this.tbAlignerMaxAbsRefSizeDiff_.AnimateReadOnly = false;
            this.tbAlignerMaxAbsRefSizeDiff_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbAlignerMaxAbsRefSizeDiff_.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbAlignerMaxAbsRefSizeDiff_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbAlignerMaxAbsRefSizeDiff_.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbAlignerMaxAbsRefSizeDiff_.Depth = 0;
            this.tbAlignerMaxAbsRefSizeDiff_.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbAlignerMaxAbsRefSizeDiff_.HideSelection = true;
            this.tbAlignerMaxAbsRefSizeDiff_.LeadingIcon = null;
            this.tbAlignerMaxAbsRefSizeDiff_.Location = new System.Drawing.Point(232, 69);
            this.tbAlignerMaxAbsRefSizeDiff_.MaxLength = 32767;
            this.tbAlignerMaxAbsRefSizeDiff_.MouseState = MaterialSkin.MouseState.OUT;
            this.tbAlignerMaxAbsRefSizeDiff_.Name = "tbAlignerMaxAbsRefSizeDiff_";
            this.tbAlignerMaxAbsRefSizeDiff_.PasswordChar = '\0';
            this.tbAlignerMaxAbsRefSizeDiff_.PrefixSuffixText = null;
            this.tbAlignerMaxAbsRefSizeDiff_.ReadOnly = false;
            this.tbAlignerMaxAbsRefSizeDiff_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbAlignerMaxAbsRefSizeDiff_.SelectedText = "";
            this.tbAlignerMaxAbsRefSizeDiff_.SelectionLength = 0;
            this.tbAlignerMaxAbsRefSizeDiff_.SelectionStart = 0;
            this.tbAlignerMaxAbsRefSizeDiff_.ShortcutsEnabled = true;
            this.tbAlignerMaxAbsRefSizeDiff_.Size = new System.Drawing.Size(132, 26);
            this.tbAlignerMaxAbsRefSizeDiff_.TabIndex = 13;
            this.tbAlignerMaxAbsRefSizeDiff_.TabStop = false;
            this.tbAlignerMaxAbsRefSizeDiff_.Text = "2";
            this.tbAlignerMaxAbsRefSizeDiff_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbAlignerMaxAbsRefSizeDiff_.TrailingIcon = null;
            this.tbAlignerMaxAbsRefSizeDiff_.UseSystemPasswordChar = false;
            this.tbAlignerMaxAbsRefSizeDiff_.UseTallSize = false;
            // 
            // gbRobotWrite
            // 
            this.gbRobotWrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbRobotWrite.Controls.Add(this.tbShiftRz);
            this.gbRobotWrite.Controls.Add(this.materialLabel17);
            this.gbRobotWrite.Controls.Add(this.tbShiftTx);
            this.gbRobotWrite.Controls.Add(this.materialLabel11);
            this.gbRobotWrite.Controls.Add(this.materialLabel20);
            this.gbRobotWrite.Controls.Add(this.lblShiftPoseRxyz_);
            this.gbRobotWrite.Controls.Add(this.tbShiftTy);
            this.gbRobotWrite.Depth = 0;
            this.gbRobotWrite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbRobotWrite.Location = new System.Drawing.Point(384, 417);
            this.gbRobotWrite.Margin = new System.Windows.Forms.Padding(14);
            this.gbRobotWrite.MouseState = MaterialSkin.MouseState.HOVER;
            this.gbRobotWrite.Name = "gbRobotWrite";
            this.gbRobotWrite.Padding = new System.Windows.Forms.Padding(14);
            this.gbRobotWrite.Size = new System.Drawing.Size(198, 144);
            this.gbRobotWrite.TabIndex = 199;
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
            this.tbShiftRz.Location = new System.Drawing.Point(56, 96);
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
            this.materialLabel17.Location = new System.Drawing.Point(8, 97);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(19, 18);
            this.materialLabel17.TabIndex = 180;
            this.materialLabel17.Text = "Rz";
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
            this.tbShiftTx.Location = new System.Drawing.Point(56, 41);
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
            this.materialLabel11.Location = new System.Drawing.Point(8, 44);
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
            this.materialLabel20.Location = new System.Drawing.Point(5, 14);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Size = new System.Drawing.Size(161, 18);
            this.materialLabel20.TabIndex = 7;
            this.materialLabel20.Text = "Calculated Shift Pose";
            // 
            // lblShiftPoseRxyz_
            // 
            this.lblShiftPoseRxyz_.AutoSize = true;
            this.lblShiftPoseRxyz_.BackColor = System.Drawing.Color.Transparent;
            this.lblShiftPoseRxyz_.Depth = 0;
            this.lblShiftPoseRxyz_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblShiftPoseRxyz_.Location = new System.Drawing.Point(8, 72);
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
            this.tbShiftTy.Location = new System.Drawing.Point(56, 69);
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
            // materialCard15
            // 
            this.materialCard15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard15.Controls.Add(this.lblRH_);
            this.materialCard15.Depth = 0;
            this.materialCard15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard15.Location = new System.Drawing.Point(409, 3);
            this.materialCard15.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard15.Name = "materialCard15";
            this.materialCard15.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard15.Size = new System.Drawing.Size(58, 37);
            this.materialCard15.TabIndex = 198;
            // 
            // lblRH_
            // 
            this.lblRH_.AutoSize = true;
            this.lblRH_.BackColor = System.Drawing.Color.Transparent;
            this.lblRH_.Depth = 0;
            this.lblRH_.Font = new System.Drawing.Font("NanumSquareRound Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblRH_.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblRH_.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRH_.Location = new System.Drawing.Point(11, 6);
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
            this.materialCard14.Location = new System.Drawing.Point(3, 3);
            this.materialCard14.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard14.Name = "materialCard14";
            this.materialCard14.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard14.Size = new System.Drawing.Size(58, 37);
            this.materialCard14.TabIndex = 197;
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
            // tabOfflineArUcoAligner
            // 
            this.tabOfflineArUcoAligner.Location = new System.Drawing.Point(4, 22);
            this.tabOfflineArUcoAligner.Name = "tabOfflineArUcoAligner";
            this.tabOfflineArUcoAligner.Padding = new System.Windows.Forms.Padding(3);
            this.tabOfflineArUcoAligner.Size = new System.Drawing.Size(1266, 578);
            this.tabOfflineArUcoAligner.TabIndex = 2;
            this.tabOfflineArUcoAligner.Text = "ArUco Aligner";
            this.tabOfflineArUcoAligner.UseVisualStyleBackColor = true;
            // 
            // cardInspectingComponent
            // 
            this.cardInspectingComponent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardInspectingComponent.Controls.Add(this.lblCamera_);
            this.cardInspectingComponent.Controls.Add(this.cmbCarType_);
            this.cardInspectingComponent.Controls.Add(this.tbConfigFilePath_);
            this.cardInspectingComponent.Controls.Add(this.btnSetConfigPath_);
            this.cardInspectingComponent.Depth = 0;
            this.cardInspectingComponent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardInspectingComponent.Location = new System.Drawing.Point(7, 3);
            this.cardInspectingComponent.Margin = new System.Windows.Forms.Padding(14);
            this.cardInspectingComponent.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardInspectingComponent.Name = "cardInspectingComponent";
            this.cardInspectingComponent.Padding = new System.Windows.Forms.Padding(14);
            this.cardInspectingComponent.Size = new System.Drawing.Size(593, 41);
            this.cardInspectingComponent.TabIndex = 203;
            // 
            // lblCamera_
            // 
            this.lblCamera_.AutoSize = true;
            this.lblCamera_.BackColor = System.Drawing.Color.Transparent;
            this.lblCamera_.Depth = 0;
            this.lblCamera_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCamera_.Location = new System.Drawing.Point(353, 5);
            this.lblCamera_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCamera_.Name = "lblCamera_";
            this.lblCamera_.Size = new System.Drawing.Size(68, 18);
            this.lblCamera_.TabIndex = 2;
            this.lblCamera_.Text = "Car Type";
            // 
            // cmbCarType_
            // 
            this.cmbCarType_.AutoResize = false;
            this.cmbCarType_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCarType_.Depth = 0;
            this.cmbCarType_.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCarType_.DropDownHeight = 102;
            this.cmbCarType_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarType_.DropDownWidth = 121;
            this.cmbCarType_.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCarType_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCarType_.FormattingEnabled = true;
            this.cmbCarType_.IntegralHeight = false;
            this.cmbCarType_.ItemHeight = 25;
            this.cmbCarType_.Location = new System.Drawing.Point(427, 5);
            this.cmbCarType_.MaxDropDownItems = 4;
            this.cmbCarType_.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCarType_.Name = "cmbCarType_";
            this.cmbCarType_.Size = new System.Drawing.Size(154, 31);
            this.cmbCarType_.StartIndex = 0;
            this.cmbCarType_.TabIndex = 10;
            this.cmbCarType_.UseTallSize = false;
            this.cmbCarType_.SelectedIndexChanged += new System.EventHandler(this.cmbCarType__SelectedIndexChanged);
            // 
            // tbConfigFilePath_
            // 
            this.tbConfigFilePath_.AnimateReadOnly = false;
            this.tbConfigFilePath_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbConfigFilePath_.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbConfigFilePath_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbConfigFilePath_.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbConfigFilePath_.Depth = 0;
            this.tbConfigFilePath_.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbConfigFilePath_.HideSelection = true;
            this.tbConfigFilePath_.LeadingIcon = null;
            this.tbConfigFilePath_.Location = new System.Drawing.Point(5, 7);
            this.tbConfigFilePath_.MaxLength = 32767;
            this.tbConfigFilePath_.MouseState = MaterialSkin.MouseState.OUT;
            this.tbConfigFilePath_.Name = "tbConfigFilePath_";
            this.tbConfigFilePath_.PasswordChar = '\0';
            this.tbConfigFilePath_.PrefixSuffixText = null;
            this.tbConfigFilePath_.ReadOnly = false;
            this.tbConfigFilePath_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbConfigFilePath_.SelectedText = "";
            this.tbConfigFilePath_.SelectionLength = 0;
            this.tbConfigFilePath_.SelectionStart = 0;
            this.tbConfigFilePath_.ShortcutsEnabled = true;
            this.tbConfigFilePath_.Size = new System.Drawing.Size(241, 26);
            this.tbConfigFilePath_.TabIndex = 41;
            this.tbConfigFilePath_.TabStop = false;
            this.tbConfigFilePath_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbConfigFilePath_.TrailingIcon = null;
            this.tbConfigFilePath_.UseSystemPasswordChar = false;
            this.tbConfigFilePath_.UseTallSize = false;
            // 
            // btnSetConfigPath_
            // 
            this.btnSetConfigPath_.AutoSize = false;
            this.btnSetConfigPath_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSetConfigPath_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnSetConfigPath_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSetConfigPath_.Depth = 0;
            this.btnSetConfigPath_.HighEmphasis = true;
            this.btnSetConfigPath_.Icon = null;
            this.btnSetConfigPath_.Location = new System.Drawing.Point(253, 7);
            this.btnSetConfigPath_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSetConfigPath_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSetConfigPath_.Name = "btnSetConfigPath_";
            this.btnSetConfigPath_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSetConfigPath_.Size = new System.Drawing.Size(80, 26);
            this.btnSetConfigPath_.TabIndex = 12;
            this.btnSetConfigPath_.Text = "Config";
            this.btnSetConfigPath_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSetConfigPath_.UseAccentColor = false;
            this.btnSetConfigPath_.UseVisualStyleBackColor = true;
            this.btnSetConfigPath_.Click += new System.EventHandler(this.btnSetConfigPath__Click);
            // 
            // OfflineMainViewSplitContainer
            // 
            this.OfflineMainViewSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OfflineMainViewSplitContainer.IsSplitterFixed = true;
            this.OfflineMainViewSplitContainer.Location = new System.Drawing.Point(3, 64);
            this.OfflineMainViewSplitContainer.Name = "OfflineMainViewSplitContainer";
            this.OfflineMainViewSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // OfflineMainViewSplitContainer.Panel1
            // 
            this.OfflineMainViewSplitContainer.Panel1.Controls.Add(this.btnSettingManage_);
            this.OfflineMainViewSplitContainer.Panel1.Controls.Add(this.cardInspectingComponent);
            // 
            // OfflineMainViewSplitContainer.Panel2
            // 
            this.OfflineMainViewSplitContainer.Panel2.Controls.Add(this.InspectionTabs);
            this.OfflineMainViewSplitContainer.Panel2MinSize = 603;
            this.OfflineMainViewSplitContainer.Size = new System.Drawing.Size(1274, 653);
            this.OfflineMainViewSplitContainer.TabIndex = 1;
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
            this.btnSettingManage_.Location = new System.Drawing.Point(1069, 2);
            this.btnSettingManage_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSettingManage_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSettingManage_.Name = "btnSettingManage_";
            this.btnSettingManage_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSettingManage_.Size = new System.Drawing.Size(195, 42);
            this.btnSettingManage_.TabIndex = 42;
            this.btnSettingManage_.Text = "Setting Manager";
            this.btnSettingManage_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSettingManage_.UseAccentColor = false;
            this.btnSettingManage_.UseVisualStyleBackColor = false;
            this.btnSettingManage_.Click += new System.EventHandler(this.btnSettingManage__Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnSetModelPath_
            // 
            this.btnSetModelPath_.AutoSize = false;
            this.btnSetModelPath_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSetModelPath_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnSetModelPath_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSetModelPath_.Depth = 0;
            this.btnSetModelPath_.HighEmphasis = true;
            this.btnSetModelPath_.Icon = null;
            this.btnSetModelPath_.Location = new System.Drawing.Point(444, 6);
            this.btnSetModelPath_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSetModelPath_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSetModelPath_.Name = "btnSetModelPath_";
            this.btnSetModelPath_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSetModelPath_.Size = new System.Drawing.Size(62, 26);
            this.btnSetModelPath_.TabIndex = 42;
            this.btnSetModelPath_.Text = "Set";
            this.btnSetModelPath_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSetModelPath_.UseAccentColor = false;
            this.btnSetModelPath_.UseVisualStyleBackColor = true;
            this.btnSetModelPath_.Click += new System.EventHandler(this.btnSetModelPath__Click);
            // 
            // pbModel
            // 
            this.pbModel.BackColor = System.Drawing.Color.LightGray;
            this.pbModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbModel.Location = new System.Drawing.Point(3, 3);
            this.pbModel.Name = "pbModel";
            this.pbModel.Size = new System.Drawing.Size(542, 532);
            this.pbModel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbModel.TabIndex = 196;
            this.pbModel.TabStop = false;
            // 
            // pbResult
            // 
            this.pbResult.BackColor = System.Drawing.Color.LightGray;
            this.pbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbResult.InitialImage = null;
            this.pbResult.Location = new System.Drawing.Point(586, 417);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(223, 144);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResult.TabIndex = 200;
            this.pbResult.TabStop = false;
            // 
            // pbRh
            // 
            this.pbRh.BackColor = System.Drawing.Color.LightGray;
            this.pbRh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbRh.Location = new System.Drawing.Point(409, 3);
            this.pbRh.Name = "pbRh";
            this.pbRh.Size = new System.Drawing.Size(400, 400);
            this.pbRh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRh.TabIndex = 194;
            this.pbRh.TabStop = false;
            // 
            // pbLh
            // 
            this.pbLh.BackColor = System.Drawing.Color.LightGray;
            this.pbLh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLh.Location = new System.Drawing.Point(3, 3);
            this.pbLh.Name = "pbLh";
            this.pbLh.Size = new System.Drawing.Size(400, 400);
            this.pbLh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLh.TabIndex = 195;
            this.pbLh.TabStop = false;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.btnSetModelPath_);
            this.materialCard4.Controls.Add(this.materialLabel8);
            this.materialCard4.Controls.Add(this.cmbModelSelection_);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(753, 3);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(507, 41);
            this.materialCard4.TabIndex = 204;
            // 
            // OfflineMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.OfflineMainViewSplitContainer);
            this.Name = "OfflineMainForm";
            this.Text = "CargoBox2D Offline";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OfflineMainForm_FormClosing);
            this.Load += new System.EventHandler(this.OfflineMainForm_Load);
            this.InspectionTabs.ResumeLayout(false);
            this.tabModelChecker.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.cardModelConfig_.ResumeLayout(false);
            this.cardModelConfig_.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tabOfflineAligner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfflineInspectionRecordPaths_)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.gbRobotWrite.ResumeLayout(false);
            this.gbRobotWrite.PerformLayout();
            this.materialCard15.ResumeLayout(false);
            this.materialCard15.PerformLayout();
            this.materialCard14.ResumeLayout(false);
            this.materialCard14.PerformLayout();
            this.cardInspectingComponent.ResumeLayout(false);
            this.cardInspectingComponent.PerformLayout();
            this.OfflineMainViewSplitContainer.Panel1.ResumeLayout(false);
            this.OfflineMainViewSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OfflineMainViewSplitContainer)).EndInit();
            this.OfflineMainViewSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLh)).EndInit();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl InspectionTabs;
        private System.Windows.Forms.TabPage tabModelChecker;
        private System.Windows.Forms.TabPage tabOfflineAligner;
        private System.Windows.Forms.TabPage tabOfflineArUcoAligner;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox2 tbConfidenceScore_;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 tbDetectedRefHoleCount_;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel lblModelPerformance;
        private System.Windows.Forms.PictureBox pbModel;
        private System.Windows.Forms.PictureBox pbRh;
        private System.Windows.Forms.PictureBox pbLh;
        private MaterialSkin.Controls.MaterialCard materialCard14;
        private MaterialSkin.Controls.MaterialLabel lblLH_;
        private MaterialSkin.Controls.MaterialCard materialCard15;
        private MaterialSkin.Controls.MaterialLabel lblRH_;
        private System.Windows.Forms.SplitContainer OfflineMainViewSplitContainer;
        private MaterialSkin.Controls.MaterialButton btnSetConfigPath_;
        private MaterialSkin.Controls.MaterialButton btnSettingManage_;
        private MaterialSkin.Controls.MaterialTextBox2 tbConfigFilePath_;
        private MaterialSkin.Controls.MaterialCard gbRobotWrite;
        private MaterialSkin.Controls.MaterialTextBox2 tbShiftRz;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialTextBox2 tbShiftTx;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private MaterialSkin.Controls.MaterialLabel lblShiftPoseRxyz_;
        private MaterialSkin.Controls.MaterialTextBox2 tbShiftTy;
        private System.Windows.Forms.PictureBox pbResult;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialTextBox2 tbAlignerMaxDetectedRefHoleCount_;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 tbAlignerMinConfidenceScore_;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lblModelPerformance_;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox2 tbAlignerMaxAbsRefSizeDiff_;
        private MaterialSkin.Controls.MaterialMultiLineTextBox rtbLog;
        private MaterialSkin.Controls.MaterialButton btnSetOfflineImageRootPath_;
        private MaterialSkin.Controls.MaterialCard cardInspectingComponent;
        private MaterialSkin.Controls.MaterialLabel lblCamera_;
        private MaterialSkin.Controls.MaterialComboBox cmbCarType_;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView dgvOfflineInspectionRecordPaths_;
        private MaterialSkin.Controls.MaterialTextBox2 tbOfflineImageRootPath_;
        private MaterialSkin.Controls.MaterialTextBox2 tbOfflineSourceImageRootPath_;
        private MaterialSkin.Controls.MaterialButton btnSetOfflineRootPath_;
        private MaterialSkin.Controls.MaterialCard cardModelConfig_;
        private MaterialSkin.Controls.MaterialComboBox cmbModelSelection_;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel lblSetEngineVerbosity_;
        private MaterialSkin.Controls.MaterialButton btnSetEngineVerbosity_;
        private MaterialSkin.Controls.MaterialTextBox2 tbVerbosityImgLvl_;
        private MaterialSkin.Controls.MaterialTextBox2 tbVerbosityLogLvl_;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.ListView lvOfflineSourceImages_;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MaterialSkin.Controls.MaterialButton btnSetModelPath_;
        private MaterialSkin.Controls.MaterialCard materialCard4;
    }
}

