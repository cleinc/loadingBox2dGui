namespace loadingBox2dGui
{
    partial class LightSettingManagerView
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
            this.lblLight_ = new MaterialSkin.Controls.MaterialLabel();
            this.cmbLightModel = new MaterialSkin.Controls.MaterialComboBox();
            this.btnLightCopy_ = new MaterialSkin.Controls.MaterialButton();
            this.btnLightAdd_ = new MaterialSkin.Controls.MaterialButton();
            this.btnLightRemove_ = new MaterialSkin.Controls.MaterialButton();
            this.lightConfigGrid = new System.Windows.Forms.PropertyGrid();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLight_
            // 
            this.lblLight_.AutoSize = true;
            this.lblLight_.BackColor = System.Drawing.Color.Transparent;
            this.lblLight_.Depth = 0;
            this.lblLight_.Font = new System.Drawing.Font("NanumSquareRound Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLight_.Location = new System.Drawing.Point(9, 19);
            this.lblLight_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLight_.Name = "lblLight_";
            this.lblLight_.Size = new System.Drawing.Size(45, 18);
            this.lblLight_.TabIndex = 5;
            this.lblLight_.Text = "Light";
            // 
            // cmbLightModel
            // 
            this.cmbLightModel.AutoResize = false;
            this.cmbLightModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbLightModel.Depth = 0;
            this.cmbLightModel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbLightModel.DropDownHeight = 102;
            this.cmbLightModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLightModel.DropDownWidth = 121;
            this.cmbLightModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbLightModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbLightModel.FormattingEnabled = true;
            this.cmbLightModel.IntegralHeight = false;
            this.cmbLightModel.ItemHeight = 25;
            this.cmbLightModel.Location = new System.Drawing.Point(92, 12);
            this.cmbLightModel.MaxDropDownItems = 4;
            this.cmbLightModel.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbLightModel.Name = "cmbLightModel";
            this.cmbLightModel.Size = new System.Drawing.Size(167, 31);
            this.cmbLightModel.StartIndex = 0;
            this.cmbLightModel.TabIndex = 3;
            this.cmbLightModel.UseTallSize = false;
            this.cmbLightModel.SelectedIndexChanged += new System.EventHandler(this.cmbLightModel_SelectedIndexChanged);
            // 
            // btnLightCopy_
            // 
            this.btnLightCopy_.AutoSize = false;
            this.btnLightCopy_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLightCopy_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnLightCopy_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLightCopy_.Depth = 0;
            this.btnLightCopy_.HighEmphasis = true;
            this.btnLightCopy_.Icon = null;
            this.btnLightCopy_.Location = new System.Drawing.Point(441, 13);
            this.btnLightCopy_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLightCopy_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLightCopy_.Name = "btnLightCopy_";
            this.btnLightCopy_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLightCopy_.Size = new System.Drawing.Size(75, 25);
            this.btnLightCopy_.TabIndex = 4;
            this.btnLightCopy_.Text = "copy";
            this.btnLightCopy_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLightCopy_.UseAccentColor = false;
            this.btnLightCopy_.UseVisualStyleBackColor = true;
            this.btnLightCopy_.Click += new System.EventHandler(this.btnLightCopy__Click);
            // 
            // btnLightAdd_
            // 
            this.btnLightAdd_.AutoSize = false;
            this.btnLightAdd_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLightAdd_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnLightAdd_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLightAdd_.Depth = 0;
            this.btnLightAdd_.HighEmphasis = true;
            this.btnLightAdd_.Icon = null;
            this.btnLightAdd_.Location = new System.Drawing.Point(277, 14);
            this.btnLightAdd_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLightAdd_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLightAdd_.Name = "btnLightAdd_";
            this.btnLightAdd_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLightAdd_.Size = new System.Drawing.Size(75, 25);
            this.btnLightAdd_.TabIndex = 4;
            this.btnLightAdd_.Text = "ADD";
            this.btnLightAdd_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLightAdd_.UseAccentColor = false;
            this.btnLightAdd_.UseVisualStyleBackColor = true;
            this.btnLightAdd_.Click += new System.EventHandler(this.btnLightAdd__Click);
            // 
            // btnLightRemove_
            // 
            this.btnLightRemove_.AutoSize = false;
            this.btnLightRemove_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLightRemove_.CustomBackColor = System.Drawing.Color.Empty;
            this.btnLightRemove_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLightRemove_.Depth = 0;
            this.btnLightRemove_.HighEmphasis = true;
            this.btnLightRemove_.Icon = null;
            this.btnLightRemove_.Location = new System.Drawing.Point(359, 14);
            this.btnLightRemove_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLightRemove_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLightRemove_.Name = "btnLightRemove_";
            this.btnLightRemove_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLightRemove_.Size = new System.Drawing.Size(75, 25);
            this.btnLightRemove_.TabIndex = 4;
            this.btnLightRemove_.Text = "remove";
            this.btnLightRemove_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLightRemove_.UseAccentColor = false;
            this.btnLightRemove_.UseVisualStyleBackColor = true;
            this.btnLightRemove_.Click += new System.EventHandler(this.btnLightRemove__Click);
            // 
            // lightConfigGrid
            // 
            this.lightConfigGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lightConfigGrid.Font = new System.Drawing.Font("Gulim", 11F);
            this.lightConfigGrid.LineColor = System.Drawing.Color.Gray;
            this.lightConfigGrid.Location = new System.Drawing.Point(0, 0);
            this.lightConfigGrid.Name = "lightConfigGrid";
            this.lightConfigGrid.Size = new System.Drawing.Size(634, 729);
            this.lightConfigGrid.TabIndex = 7;
            this.lightConfigGrid.ToolbarVisible = false;
            this.lightConfigGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.lightConfigGrid_PropertyValueChanged);
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
            this.splitContainer1.Panel1.Controls.Add(this.lblLight_);
            this.splitContainer1.Panel1.Controls.Add(this.cmbLightModel);
            this.splitContainer1.Panel1.Controls.Add(this.btnLightRemove_);
            this.splitContainer1.Panel1.Controls.Add(this.btnLightCopy_);
            this.splitContainer1.Panel1.Controls.Add(this.btnLightAdd_);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lightConfigGrid);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(634, 786);
            this.splitContainer1.SplitterDistance = 53;
            this.splitContainer1.TabIndex = 8;
            // 
            // LightSettingManagerView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 789);
            this.Controls.Add(this.splitContainer1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "LightSettingManagerView";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Text = "LightSettingManagerView";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lblLight_;
        private MaterialSkin.Controls.MaterialComboBox cmbLightModel;
        private MaterialSkin.Controls.MaterialButton btnLightCopy_;
        private MaterialSkin.Controls.MaterialButton btnLightAdd_;
        private MaterialSkin.Controls.MaterialButton btnLightRemove_;
        private System.Windows.Forms.PropertyGrid lightConfigGrid;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}