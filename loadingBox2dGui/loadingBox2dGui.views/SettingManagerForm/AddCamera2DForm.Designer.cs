namespace loadingBox2dGui.SettingManagerForm
{
    partial class AddCamera2DForm_
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAdd_ = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel_ = new MaterialSkin.Controls.MaterialButton();
            this.cmbCamera2DMaker = new MaterialSkin.Controls.MaterialComboBox();
            this.tbCam2DName = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblCameraModel_ = new MaterialSkin.Controls.MaterialLabel();
            this.lblCamera_ = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(3, 144);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd_);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnCancel_);
            this.splitContainer1.Size = new System.Drawing.Size(263, 40);
            this.splitContainer1.SplitterDistance = 132;
            this.splitContainer1.TabIndex = 6;
            // 
            // btnAdd_
            // 
            this.btnAdd_.AutoSize = false;
            this.btnAdd_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd_.Depth = 0;
            this.btnAdd_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd_.HighEmphasis = true;
            this.btnAdd_.Icon = null;
            this.btnAdd_.Location = new System.Drawing.Point(0, 0);
            this.btnAdd_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd_.Name = "btnAdd_";
            this.btnAdd_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd_.Size = new System.Drawing.Size(132, 40);
            this.btnAdd_.TabIndex = 0;
            this.btnAdd_.Text = "add";
            this.btnAdd_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd_.UseAccentColor = false;
            this.btnAdd_.UseVisualStyleBackColor = true;
            this.btnAdd_.Click += new System.EventHandler(this.btnAdd__Click);
            // 
            // btnCancel_
            // 
            this.btnCancel_.AutoSize = false;
            this.btnCancel_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel_.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel_.Depth = 0;
            this.btnCancel_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel_.HighEmphasis = true;
            this.btnCancel_.Icon = null;
            this.btnCancel_.Location = new System.Drawing.Point(0, 0);
            this.btnCancel_.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel_.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel_.Name = "btnCancel_";
            this.btnCancel_.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel_.Size = new System.Drawing.Size(127, 40);
            this.btnCancel_.TabIndex = 0;
            this.btnCancel_.Text = "cancel";
            this.btnCancel_.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel_.UseAccentColor = false;
            this.btnCancel_.UseVisualStyleBackColor = true;
            this.btnCancel_.Click += new System.EventHandler(this.btnCancel__Click_1);
            // 
            // cmbCamera2DMaker
            // 
            this.cmbCamera2DMaker.AutoResize = false;
            this.cmbCamera2DMaker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCamera2DMaker.Depth = 0;
            this.cmbCamera2DMaker.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCamera2DMaker.DropDownHeight = 102;
            this.cmbCamera2DMaker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCamera2DMaker.DropDownWidth = 121;
            this.cmbCamera2DMaker.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCamera2DMaker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCamera2DMaker.FormattingEnabled = true;
            this.cmbCamera2DMaker.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cmbCamera2DMaker.IntegralHeight = false;
            this.cmbCamera2DMaker.ItemHeight = 25;
            this.cmbCamera2DMaker.Location = new System.Drawing.Point(131, 86);
            this.cmbCamera2DMaker.MaxDropDownItems = 4;
            this.cmbCamera2DMaker.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCamera2DMaker.Name = "cmbCamera2DMaker";
            this.cmbCamera2DMaker.Size = new System.Drawing.Size(125, 31);
            this.cmbCamera2DMaker.StartIndex = 0;
            this.cmbCamera2DMaker.TabIndex = 13;
            this.cmbCamera2DMaker.UseTallSize = false;
            // 
            // tbCam2DName
            // 
            this.tbCam2DName.AnimateReadOnly = false;
            this.tbCam2DName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbCam2DName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbCam2DName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbCam2DName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCam2DName.Depth = 0;
            this.tbCam2DName.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCam2DName.HideSelection = true;
            this.tbCam2DName.LeadingIcon = null;
            this.tbCam2DName.Location = new System.Drawing.Point(131, 47);
            this.tbCam2DName.MaxLength = 32767;
            this.tbCam2DName.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCam2DName.Name = "tbCam2DName";
            this.tbCam2DName.PasswordChar = '\0';
            this.tbCam2DName.PrefixSuffixText = null;
            this.tbCam2DName.ReadOnly = false;
            this.tbCam2DName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCam2DName.SelectedText = "";
            this.tbCam2DName.SelectionLength = 0;
            this.tbCam2DName.SelectionStart = 0;
            this.tbCam2DName.ShortcutsEnabled = true;
            this.tbCam2DName.Size = new System.Drawing.Size(125, 26);
            this.tbCam2DName.TabIndex = 12;
            this.tbCam2DName.TabStop = false;
            this.tbCam2DName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCam2DName.TrailingIcon = null;
            this.tbCam2DName.UseSystemPasswordChar = false;
            this.tbCam2DName.UseTallSize = false;
            // 
            // lblCameraModel_
            // 
            this.lblCameraModel_.AutoSize = true;
            this.lblCameraModel_.BackColor = System.Drawing.Color.Transparent;
            this.lblCameraModel_.Depth = 0;
            this.lblCameraModel_.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCameraModel_.Location = new System.Drawing.Point(12, 93);
            this.lblCameraModel_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCameraModel_.Name = "lblCameraModel_";
            this.lblCameraModel_.Size = new System.Drawing.Size(111, 18);
            this.lblCameraModel_.TabIndex = 11;
            this.lblCameraModel_.Text = "Camera Model";
            // 
            // lblCamera_
            // 
            this.lblCamera_.AutoSize = true;
            this.lblCamera_.BackColor = System.Drawing.Color.Transparent;
            this.lblCamera_.Depth = 0;
            this.lblCamera_.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCamera_.Location = new System.Drawing.Point(12, 51);
            this.lblCamera_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCamera_.Name = "lblCamera_";
            this.lblCamera_.Size = new System.Drawing.Size(108, 18);
            this.lblCamera_.TabIndex = 10;
            this.lblCamera_.Text = "Camera Name";
            // 
            // AddCamera2DForm_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 187);
            this.Controls.Add(this.cmbCamera2DMaker);
            this.Controls.Add(this.tbCam2DName);
            this.Controls.Add(this.lblCameraModel_);
            this.Controls.Add(this.lblCamera_);
            this.Controls.Add(this.splitContainer1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "AddCamera2DForm_";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddCamera2DForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MaterialSkin.Controls.MaterialComboBox cmbCamera2DMaker;
        private MaterialSkin.Controls.MaterialTextBox2 tbCam2DName;
        private MaterialSkin.Controls.MaterialLabel lblCameraModel_;
        private MaterialSkin.Controls.MaterialLabel lblCamera_;
        private MaterialSkin.Controls.MaterialButton btnAdd_;
        private MaterialSkin.Controls.MaterialButton btnCancel_;
    }
}