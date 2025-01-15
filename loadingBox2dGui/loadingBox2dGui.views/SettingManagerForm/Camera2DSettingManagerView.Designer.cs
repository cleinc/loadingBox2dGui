namespace loadingBox2dGui.SettingManagerForm
{
    partial class Camera2DSettingManagerView
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
            this.cam2DConfigGrid = new System.Windows.Forms.PropertyGrid();
            this.cmbCam2DConfig = new MaterialSkin.Controls.MaterialComboBox();
            this.btnCam2DAdd_ = new MaterialSkin.Controls.MaterialButton();
            this.btnCam2DRemove_ = new MaterialSkin.Controls.MaterialButton();
            this.btnCopyCamera2D_ = new MaterialSkin.Controls.MaterialButton();
            this.lblCamera_ = new MaterialSkin.Controls.MaterialLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cam2DConfigGrid
            // 
            this.cam2DConfigGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cam2DConfigGrid.Font = new System.Drawing.Font("Gulim", 11F);
            this.cam2DConfigGrid.LineColor = System.Drawing.Color.Gray;
            this.cam2DConfigGrid.Location = new System.Drawing.Point(5, 5);
            this.cam2DConfigGrid.Name = "cam2DConfigGrid";
            this.cam2DConfigGrid.Size = new System.Drawing.Size(624, 719);
            this.cam2DConfigGrid.TabIndex = 1;
            this.cam2DConfigGrid.ToolbarVisible = false;
            this.cam2DConfigGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.cam2DConfigGrid_PropertyValueChanged);
            // 
            // cmbCam2DConfig
            // 
            this.cmbCam2DConfig.AutoResize = false;
            this.cmbCam2DConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCam2DConfig.Depth = 0;
            this.cmbCam2DConfig.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCam2DConfig.DropDownHeight = 102;
            this.cmbCam2DConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCam2DConfig.DropDownWidth = 121;
            this.cmbCam2DConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCam2DConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCam2DConfig.FormattingEnabled = true;
            this.cmbCam2DConfig.IntegralHeight = false;
            this.cmbCam2DConfig.ItemHeight = 25;
            this.cmbCam2DConfig.Location = new System.Drawing.Point(92, 12);
            this.cmbCam2DConfig.MaxDropDownItems = 4;
            this.cmbCam2DConfig.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCam2DConfig.Name = "cmbCam2DConfig";
            this.cmbCam2DConfig.Size = new System.Drawing.Size(167, 31);
            this.cmbCam2DConfig.StartIndex = 0;
            this.cmbCam2DConfig.TabIndex = 3;
            this.cmbCam2DConfig.UseTallSize = false;
            this.cmbCam2DConfig.SelectedIndexChanged += new System.EventHandler(this.cmbCam2DConfig_SelectedIndexChanged);
            // 
            // btnCam2DAdd_
            // 
            this.btnCam2DAdd_.AutoSize = false;
            this.btnCam2DAdd_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCam2DAdd_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnCam2DAdd_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCam2DAdd_.Depth = 0;
            this.btnCam2DAdd_.Enabled = false;
            this.btnCam2DAdd_.HighEmphasis = true;
            this.btnCam2DAdd_.Icon = null;
            this.btnCam2DAdd_.Location = new System.Drawing.Point(276, 14);
            this.btnCam2DAdd_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCam2DAdd_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCam2DAdd_.Name = "btnCam2DAdd_";
            this.btnCam2DAdd_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCam2DAdd_.Size = new System.Drawing.Size(75, 25);
            this.btnCam2DAdd_.TabIndex = 4;
            this.btnCam2DAdd_.Text = "ADD";
            this.btnCam2DAdd_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCam2DAdd_.UseAccentColor = false;
            this.btnCam2DAdd_.UseVisualStyleBackColor = true;
            this.btnCam2DAdd_.Click += new System.EventHandler(this.btnCam2DAdd__Click);
            // 
            // btnCam2DRemove_
            // 
            this.btnCam2DRemove_.AutoSize = false;
            this.btnCam2DRemove_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCam2DRemove_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnCam2DRemove_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCam2DRemove_.Depth = 0;
            this.btnCam2DRemove_.Enabled = false;
            this.btnCam2DRemove_.HighEmphasis = true;
            this.btnCam2DRemove_.Icon = null;
            this.btnCam2DRemove_.Location = new System.Drawing.Point(359, 14);
            this.btnCam2DRemove_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCam2DRemove_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCam2DRemove_.Name = "btnCam2DRemove_";
            this.btnCam2DRemove_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCam2DRemove_.Size = new System.Drawing.Size(75, 25);
            this.btnCam2DRemove_.TabIndex = 4;
            this.btnCam2DRemove_.Text = "remove";
            this.btnCam2DRemove_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCam2DRemove_.UseAccentColor = false;
            this.btnCam2DRemove_.UseVisualStyleBackColor = true;
            this.btnCam2DRemove_.Click += new System.EventHandler(this.btnCam2DRemove__Click);
            // 
            // btnCopyCamera2D_
            // 
            this.btnCopyCamera2D_.AutoSize = false;
            this.btnCopyCamera2D_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCopyCamera2D_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnCopyCamera2D_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCopyCamera2D_.Depth = 0;
            this.btnCopyCamera2D_.Enabled = false;
            this.btnCopyCamera2D_.HighEmphasis = true;
            this.btnCopyCamera2D_.Icon = null;
            this.btnCopyCamera2D_.Location = new System.Drawing.Point(441, 14);
            this.btnCopyCamera2D_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCopyCamera2D_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCopyCamera2D_.Name = "btnCopyCamera2D_";
            this.btnCopyCamera2D_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCopyCamera2D_.Size = new System.Drawing.Size(75, 25);
            this.btnCopyCamera2D_.TabIndex = 4;
            this.btnCopyCamera2D_.Text = "copy";
            this.btnCopyCamera2D_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCopyCamera2D_.UseAccentColor = false;
            this.btnCopyCamera2D_.UseVisualStyleBackColor = true;
            this.btnCopyCamera2D_.Click += new System.EventHandler(this.btnCopyCamera2D__Click);
            // 
            // lblCamera_
            // 
            this.lblCamera_.AutoSize = true;
            this.lblCamera_.BackColor = System.Drawing.Color.Transparent;
            this.lblCamera_.Depth = 0;
            this.lblCamera_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCamera_.Location = new System.Drawing.Point(4, 19);
            this.lblCamera_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCamera_.Name = "lblCamera_";
            this.lblCamera_.Size = new System.Drawing.Size(85, 18);
            this.lblCamera_.TabIndex = 5;
            this.lblCamera_.Text = "CameraSet";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblCamera_);
            this.splitContainer1.Panel1.Controls.Add(this.cmbCam2DConfig);
            this.splitContainer1.Panel1.Controls.Add(this.btnCam2DRemove_);
            this.splitContainer1.Panel1.Controls.Add(this.btnCopyCamera2D_);
            this.splitContainer1.Panel1.Controls.Add(this.btnCam2DAdd_);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cam2DConfigGrid);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(634, 786);
            this.splitContainer1.SplitterDistance = 53;
            this.splitContainer1.TabIndex = 6;
            // 
            // Camera2DSettingManagerView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 789);
            this.Controls.Add(this.splitContainer1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "Camera2DSettingManagerView";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Text = "Camera2DSettingManagerView";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PropertyGrid cam2DConfigGrid;
        private MaterialSkin.Controls.MaterialComboBox cmbCam2DConfig;
        private MaterialSkin.Controls.MaterialButton btnCam2DAdd_;
        private MaterialSkin.Controls.MaterialButton btnCam2DRemove_;
        private MaterialSkin.Controls.MaterialButton btnCopyCamera2D_;
        private MaterialSkin.Controls.MaterialLabel lblCamera_;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}