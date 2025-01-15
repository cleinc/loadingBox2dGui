namespace loadingBox2dGui.SettingManagerForm
{
    partial class AddCarTypeForm_
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
            this.btnAdd_ = new System.Windows.Forms.Button();
            this.label1_ = new System.Windows.Forms.Label();
            this.label2_ = new System.Windows.Forms.Label();
            this.tbCarType = new System.Windows.Forms.TextBox();
            this.tbCarName = new System.Windows.Forms.TextBox();
            this.btnCancel_ = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd_
            // 
            this.btnAdd_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(216)))), ((int)(((byte)(110)))));
            this.btnAdd_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd_.FlatAppearance.BorderSize = 0;
            this.btnAdd_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_.Location = new System.Drawing.Point(0, 0);
            this.btnAdd_.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd_.Name = "btnAdd_";
            this.btnAdd_.Size = new System.Drawing.Size(125, 38);
            this.btnAdd_.TabIndex = 2;
            this.btnAdd_.Text = "추가하기";
            this.btnAdd_.UseVisualStyleBackColor = false;
            this.btnAdd_.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1_
            // 
            this.label1_.AutoSize = true;
            this.label1_.Location = new System.Drawing.Point(23, 29);
            this.label1_.Name = "label1_";
            this.label1_.Size = new System.Drawing.Size(72, 15);
            this.label1_.TabIndex = 1;
            this.label1_.Text = "차종 번호";
            // 
            // label2_
            // 
            this.label2_.AutoSize = true;
            this.label2_.Location = new System.Drawing.Point(23, 66);
            this.label2_.Name = "label2_";
            this.label2_.Size = new System.Drawing.Size(72, 15);
            this.label2_.TabIndex = 2;
            this.label2_.Text = "차량 이름";
            // 
            // tbCarType
            // 
            this.tbCarType.Location = new System.Drawing.Point(101, 22);
            this.tbCarType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCarType.Name = "tbCarType";
            this.tbCarType.Size = new System.Drawing.Size(125, 25);
            this.tbCarType.TabIndex = 0;
            this.tbCarType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCarType_KeyDown);
            // 
            // tbCarName
            // 
            this.tbCarName.Location = new System.Drawing.Point(101, 62);
            this.tbCarName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCarName.Name = "tbCarName";
            this.tbCarName.Size = new System.Drawing.Size(125, 25);
            this.tbCarName.TabIndex = 1;
            this.tbCarName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCarName_KeyDown);
            // 
            // btnCancel_
            // 
            this.btnCancel_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(216)))), ((int)(((byte)(110)))));
            this.btnCancel_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel_.FlatAppearance.BorderSize = 0;
            this.btnCancel_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel_.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel_.Location = new System.Drawing.Point(0, 0);
            this.btnCancel_.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel_.Name = "btnCancel_";
            this.btnCancel_.Size = new System.Drawing.Size(127, 38);
            this.btnCancel_.TabIndex = 3;
            this.btnCancel_.Text = "cancel";
            this.btnCancel_.UseVisualStyleBackColor = false;
            this.btnCancel_.Click += new System.EventHandler(this.btnCancel__Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 146);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd_);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnCancel_);
            this.splitContainer1.Size = new System.Drawing.Size(253, 38);
            this.splitContainer1.SplitterDistance = 125;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 4;
            // 
            // AddNewCarTypeForm_
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(253, 184);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tbCarName);
            this.Controls.Add(this.tbCarType);
            this.Controls.Add(this.label2_);
            this.Controls.Add(this.label1_);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AddNewCarTypeForm_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "새로운 차종 등록";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd_;
        private System.Windows.Forms.Label label1_;
        private System.Windows.Forms.Label label2_;
        private System.Windows.Forms.TextBox tbCarType;
        private System.Windows.Forms.TextBox tbCarName;
        private System.Windows.Forms.Button btnCancel_;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}