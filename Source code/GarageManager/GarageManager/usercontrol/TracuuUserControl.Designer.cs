namespace GarageManager.usercontrol
{
    partial class tracuuUserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HiệuXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BIểnSố = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChủXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxCarBrand = new System.Windows.Forms.ComboBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.FindBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.OwnerTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CarPlateTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MainWordTextbox = new System.Windows.Forms.TextBox();
            this.lblCapNhatQuyDinh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stt,
            this.HiệuXe,
            this.BIểnSố,
            this.ChủXe});
            this.dataGridView1.Location = new System.Drawing.Point(449, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(573, 566);
            this.dataGridView1.TabIndex = 9;
            // 
            // Stt
            // 
            this.Stt.HeaderText = "Stt";
            this.Stt.Name = "Stt";
            // 
            // HiệuXe
            // 
            this.HiệuXe.HeaderText = "Hiệu Xe";
            this.HiệuXe.Name = "HiệuXe";
            // 
            // BIểnSố
            // 
            this.BIểnSố.HeaderText = "BIển Số";
            this.BIểnSố.Name = "BIểnSố";
            // 
            // ChủXe
            // 
            this.ChủXe.HeaderText = "Chủ Xe";
            this.ChủXe.Name = "ChủXe";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBoxCarBrand);
            this.panel1.Controls.Add(this.ResetBtn);
            this.panel1.Controls.Add(this.FindBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.OwnerTextbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CarPlateTextbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MainWordTextbox);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(11, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 566);
            this.panel1.TabIndex = 14;
            // 
            // comboBoxCarBrand
            // 
            this.comboBoxCarBrand.DropDownWidth = 215;
            this.comboBoxCarBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBoxCarBrand.FormattingEnabled = true;
            this.comboBoxCarBrand.Location = new System.Drawing.Point(96, 189);
            this.comboBoxCarBrand.Name = "comboBoxCarBrand";
            this.comboBoxCarBrand.Size = new System.Drawing.Size(163, 21);
            this.comboBoxCarBrand.TabIndex = 20;
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ResetBtn.FlatAppearance.BorderSize = 0;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Location = new System.Drawing.Point(68, 497);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(252, 47);
            this.ResetBtn.TabIndex = 19;
            this.ResetBtn.Text = "Đặt lại";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // FindBtn
            // 
            this.FindBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.FindBtn.FlatAppearance.BorderSize = 0;
            this.FindBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindBtn.Location = new System.Drawing.Point(68, 426);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(251, 47);
            this.FindBtn.TabIndex = 19;
            this.FindBtn.Text = "Tìm kiếm";
            this.FindBtn.UseVisualStyleBackColor = false;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Chủ xe";
            // 
            // OwnerTextbox
            // 
            this.OwnerTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.OwnerTextbox.Location = new System.Drawing.Point(96, 330);
            this.OwnerTextbox.Name = "OwnerTextbox";
            this.OwnerTextbox.Size = new System.Drawing.Size(163, 20);
            this.OwnerTextbox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Biển số xe";
            // 
            // CarPlateTextbox
            // 
            this.CarPlateTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CarPlateTextbox.Location = new System.Drawing.Point(96, 253);
            this.CarPlateTextbox.Name = "CarPlateTextbox";
            this.CarPlateTextbox.Size = new System.Drawing.Size(163, 20);
            this.CarPlateTextbox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hiệu xe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tìm kiếm theo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Từ khóa";
            // 
            // MainWordTextbox
            // 
            this.MainWordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MainWordTextbox.Location = new System.Drawing.Point(122, 26);
            this.MainWordTextbox.Name = "MainWordTextbox";
            this.MainWordTextbox.Size = new System.Drawing.Size(137, 20);
            this.MainWordTextbox.TabIndex = 11;
            // 
            // lblCapNhatQuyDinh
            // 
            this.lblCapNhatQuyDinh.BackColor = System.Drawing.Color.Transparent;
            this.lblCapNhatQuyDinh.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCapNhatQuyDinh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCapNhatQuyDinh.Location = new System.Drawing.Point(377, 44);
            this.lblCapNhatQuyDinh.Name = "lblCapNhatQuyDinh";
            this.lblCapNhatQuyDinh.Size = new System.Drawing.Size(131, 27);
            this.lblCapNhatQuyDinh.TabIndex = 20;
            this.lblCapNhatQuyDinh.Text = "TRA CỨU XE";
            // 
            // tracuuUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lblCapNhatQuyDinh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "tracuuUserControl1";
            this.Size = new System.Drawing.Size(1089, 668);
            this.Load += new System.EventHandler(this.tracuuUserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button FindBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OwnerTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CarPlateTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MainWordTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCapNhatQuyDinh;
        private System.Windows.Forms.ComboBox comboBoxCarBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn HiệuXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn BIểnSố;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChủXe;
    }
}
