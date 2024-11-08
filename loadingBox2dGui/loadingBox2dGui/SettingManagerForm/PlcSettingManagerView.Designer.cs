namespace loadingBox2dGui.SettingManagerForm
{
    partial class PlcSettingManagerView
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
            this.lblPlc_ = new MaterialSkin.Controls.MaterialLabel();
            this.cmbPlcConfig = new MaterialSkin.Controls.MaterialComboBox();
            this.btnPlcRemove_ = new MaterialSkin.Controls.MaterialButton();
            this.plcConfigGrid = new System.Windows.Forms.PropertyGrid();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlc_
            // 
            this.lblPlc_.AutoSize = true;
            this.lblPlc_.BackColor = System.Drawing.Color.Transparent;
            this.lblPlc_.Depth = 0;
            this.lblPlc_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPlc_.Location = new System.Drawing.Point(9, 19);
            this.lblPlc_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPlc_.Name = "lblPlc_";
            this.lblPlc_.Size = new System.Drawing.Size(30, 18);
            this.lblPlc_.TabIndex = 5;
            this.lblPlc_.Text = "PLC";
            // 
            // cmbPlcConfig
            // 
            this.cmbPlcConfig.AutoResize = false;
            this.cmbPlcConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPlcConfig.Depth = 0;
            this.cmbPlcConfig.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPlcConfig.DropDownHeight = 102;
            this.cmbPlcConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlcConfig.DropDownWidth = 121;
            this.cmbPlcConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPlcConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPlcConfig.FormattingEnabled = true;
            this.cmbPlcConfig.IntegralHeight = false;
            this.cmbPlcConfig.ItemHeight = 25;
            this.cmbPlcConfig.Location = new System.Drawing.Point(92, 12);
            this.cmbPlcConfig.MaxDropDownItems = 4;
            this.cmbPlcConfig.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPlcConfig.Name = "cmbPlcConfig";
            this.cmbPlcConfig.Size = new System.Drawing.Size(250, 31);
            this.cmbPlcConfig.StartIndex = 0;
            this.cmbPlcConfig.TabIndex = 3;
            this.cmbPlcConfig.UseTallSize = false;
            this.cmbPlcConfig.SelectedIndexChanged += new System.EventHandler(this.cmbPlcConfig_SelectedIndexChanged);
            // 
            // btnPlcRemove_
            // 
            this.btnPlcRemove_.AutoSize = false;
            this.btnPlcRemove_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlcRemove_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnPlcRemove_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPlcRemove_.Depth = 0;
            this.btnPlcRemove_.HighEmphasis = true;
            this.btnPlcRemove_.Icon = null;
            this.btnPlcRemove_.Location = new System.Drawing.Point(260, 14);
            this.btnPlcRemove_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPlcRemove_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPlcRemove_.Name = "btnPlcRemove_";
            this.btnPlcRemove_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPlcRemove_.Size = new System.Drawing.Size(75, 25);
            this.btnPlcRemove_.TabIndex = 4;
            this.btnPlcRemove_.Text = "remove";
            this.btnPlcRemove_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPlcRemove_.UseAccentColor = false;
            this.btnPlcRemove_.UseVisualStyleBackColor = true;
            this.btnPlcRemove_.Click += new System.EventHandler(this.btnPlcRemove__Click);
            // 
            // plcConfigGrid
            // 
            this.plcConfigGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plcConfigGrid.Font = new System.Drawing.Font("Gulim", 11F);
            this.plcConfigGrid.LineColor = System.Drawing.Color.Gray;
            this.plcConfigGrid.Location = new System.Drawing.Point(5, 5);
            this.plcConfigGrid.Name = "plcConfigGrid";
            this.plcConfigGrid.Size = new System.Drawing.Size(624, 719);
            this.plcConfigGrid.TabIndex = 12;
            this.plcConfigGrid.ToolbarVisible = false;
            this.plcConfigGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.plcConfigGrid_PropertyValueChanged);
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
            this.splitContainer1.Panel1.Controls.Add(this.lblPlc_);
            this.splitContainer1.Panel1.Controls.Add(this.cmbPlcConfig);
            this.splitContainer1.Panel1.Controls.Add(this.btnPlcRemove_);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.plcConfigGrid);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(634, 786);
            this.splitContainer1.SplitterDistance = 53;
            this.splitContainer1.TabIndex = 13;
            // 
            // PlcSettingManagerView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(640, 789);
            this.Controls.Add(this.splitContainer1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "PlcSettingManagerView";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Text = "PlcSettingManagerView";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lblPlc_;
        private MaterialSkin.Controls.MaterialComboBox cmbPlcConfig;
        private MaterialSkin.Controls.MaterialButton btnPlcRemove_;
        private System.Windows.Forms.PropertyGrid plcConfigGrid;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}