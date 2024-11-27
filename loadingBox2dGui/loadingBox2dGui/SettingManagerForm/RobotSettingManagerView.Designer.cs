namespace loadingBox2dGui.SettingManagerForm
{
    partial class RobotSettingManagerView
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.robotConfigGrid = new System.Windows.Forms.PropertyGrid();
            this.btnAddRobotConfig_ = new MaterialSkin.Controls.MaterialButton();
            this.btnRemoveRobotConfig_ = new MaterialSkin.Controls.MaterialButton();
            this.btnCopyRobot_ = new MaterialSkin.Controls.MaterialButton();
            this.lblRobot_ = new MaterialSkin.Controls.MaterialLabel();
            this.cmbRobotConfig = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.White;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(3, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.cmbRobotConfig);
            this.splitContainer.Panel1.Controls.Add(this.lblRobot_);
            this.splitContainer.Panel1.Controls.Add(this.btnCopyRobot_);
            this.splitContainer.Panel1.Controls.Add(this.btnRemoveRobotConfig_);
            this.splitContainer.Panel1.Controls.Add(this.btnAddRobotConfig_);
            this.splitContainer.Panel1MinSize = 50;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.robotConfigGrid);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer.Size = new System.Drawing.Size(558, 827);
            this.splitContainer.SplitterDistance = 53;
            this.splitContainer.TabIndex = 2;
            this.splitContainer.TabStop = false;
            // 
            // robotConfigGrid
            // 
            this.robotConfigGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.robotConfigGrid.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.robotConfigGrid.Location = new System.Drawing.Point(5, 5);
            this.robotConfigGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.robotConfigGrid.Name = "robotConfigGrid";
            this.robotConfigGrid.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.robotConfigGrid.Size = new System.Drawing.Size(548, 760);
            this.robotConfigGrid.TabIndex = 4;
            this.robotConfigGrid.ToolbarVisible = false;
            this.robotConfigGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.RobotConfigGrid_PropertyValueChanged);
            // 
            // btnAddRobotConfig_
            // 
            this.btnAddRobotConfig_.AutoSize = false;
            this.btnAddRobotConfig_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddRobotConfig_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnAddRobotConfig_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddRobotConfig_.Depth = 0;
            this.btnAddRobotConfig_.HighEmphasis = true;
            this.btnAddRobotConfig_.Icon = null;
            this.btnAddRobotConfig_.Location = new System.Drawing.Point(261, 16);
            this.btnAddRobotConfig_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddRobotConfig_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddRobotConfig_.Name = "btnAddRobotConfig_";
            this.btnAddRobotConfig_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddRobotConfig_.Size = new System.Drawing.Size(75, 25);
            this.btnAddRobotConfig_.TabIndex = 5;
            this.btnAddRobotConfig_.Text = "add";
            this.btnAddRobotConfig_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddRobotConfig_.UseAccentColor = false;
            this.btnAddRobotConfig_.UseVisualStyleBackColor = true;
            this.btnAddRobotConfig_.Click += new System.EventHandler(this.btnAddRobotConfig__Click);
            // 
            // btnRemoveRobotConfig_
            // 
            this.btnRemoveRobotConfig_.AutoSize = false;
            this.btnRemoveRobotConfig_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoveRobotConfig_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnRemoveRobotConfig_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRemoveRobotConfig_.Depth = 0;
            this.btnRemoveRobotConfig_.HighEmphasis = true;
            this.btnRemoveRobotConfig_.Icon = null;
            this.btnRemoveRobotConfig_.Location = new System.Drawing.Point(344, 16);
            this.btnRemoveRobotConfig_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemoveRobotConfig_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemoveRobotConfig_.Name = "btnRemoveRobotConfig_";
            this.btnRemoveRobotConfig_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRemoveRobotConfig_.Size = new System.Drawing.Size(75, 25);
            this.btnRemoveRobotConfig_.TabIndex = 6;
            this.btnRemoveRobotConfig_.Text = "remove";
            this.btnRemoveRobotConfig_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRemoveRobotConfig_.UseAccentColor = false;
            this.btnRemoveRobotConfig_.UseVisualStyleBackColor = true;
            this.btnRemoveRobotConfig_.Click += new System.EventHandler(this.btnRemoveRobotConfig__Click);
            // 
            // btnCopyRobot_
            // 
            this.btnCopyRobot_.AutoSize = false;
            this.btnCopyRobot_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCopyRobot_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnCopyRobot_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCopyRobot_.Depth = 0;
            this.btnCopyRobot_.HighEmphasis = true;
            this.btnCopyRobot_.Icon = null;
            this.btnCopyRobot_.Location = new System.Drawing.Point(427, 16);
            this.btnCopyRobot_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCopyRobot_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCopyRobot_.Name = "btnCopyRobot_";
            this.btnCopyRobot_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCopyRobot_.Size = new System.Drawing.Size(75, 25);
            this.btnCopyRobot_.TabIndex = 7;
            this.btnCopyRobot_.Text = "copy";
            this.btnCopyRobot_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCopyRobot_.UseAccentColor = false;
            this.btnCopyRobot_.UseVisualStyleBackColor = true;
            // 
            // lblRobot_
            // 
            this.lblRobot_.AutoSize = true;
            this.lblRobot_.BackColor = System.Drawing.Color.Transparent;
            this.lblRobot_.Depth = 0;
            this.lblRobot_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRobot_.Location = new System.Drawing.Point(3, 18);
            this.lblRobot_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRobot_.Name = "lblRobot_";
            this.lblRobot_.Size = new System.Drawing.Size(47, 18);
            this.lblRobot_.TabIndex = 8;
            this.lblRobot_.Text = "Robot";
            // 
            // cmbRobotConfig
            // 
            this.cmbRobotConfig.AutoResize = false;
            this.cmbRobotConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbRobotConfig.Depth = 0;
            this.cmbRobotConfig.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbRobotConfig.DropDownHeight = 102;
            this.cmbRobotConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRobotConfig.DropDownWidth = 121;
            this.cmbRobotConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbRobotConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbRobotConfig.FormattingEnabled = true;
            this.cmbRobotConfig.IntegralHeight = false;
            this.cmbRobotConfig.ItemHeight = 25;
            this.cmbRobotConfig.Location = new System.Drawing.Point(75, 16);
            this.cmbRobotConfig.MaxDropDownItems = 4;
            this.cmbRobotConfig.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbRobotConfig.Name = "cmbRobotConfig";
            this.cmbRobotConfig.Size = new System.Drawing.Size(167, 31);
            this.cmbRobotConfig.StartIndex = 0;
            this.cmbRobotConfig.TabIndex = 9;
            this.cmbRobotConfig.UseTallSize = false;
            this.cmbRobotConfig.SelectedIndexChanged += new System.EventHandler(this.cmbRobotConfig_SelectedIndexChanged);
            // 
            // RobotSettingManagerView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(564, 830);
            this.Controls.Add(this.splitContainer);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "RobotSettingManagerView";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Text = "RobotSettingManagerView";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.PropertyGrid robotConfigGrid;
        private MaterialSkin.Controls.MaterialButton btnCopyRobot_;
        private MaterialSkin.Controls.MaterialButton btnRemoveRobotConfig_;
        private MaterialSkin.Controls.MaterialButton btnAddRobotConfig_;
        private MaterialSkin.Controls.MaterialLabel lblRobot_;
        private MaterialSkin.Controls.MaterialComboBox cmbRobotConfig;
    }
}