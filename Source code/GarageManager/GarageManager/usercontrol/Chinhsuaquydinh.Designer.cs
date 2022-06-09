namespace GarageManager.usercontrol
{
    partial class Chinhsuaquydinh
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
            this.panelQuyDinhHienHanh = new System.Windows.Forms.Panel();
            this.buttonLamMoiQuyDinh = new System.Windows.Forms.Button();
            this.labelQuyDinhHienHanh = new System.Windows.Forms.Label();
            this.dataGridViewQuyDinhHienHanh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnCapNhatQuyDinh = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCapNhatTienCong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxTienCong = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCapNhatHieuxe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxHieuxe = new System.Windows.Forms.TextBox();
            this.lblCapNhatQuyDinh = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnCapNhatSoXeSuaToiDa = new System.Windows.Forms.Button();
            this.lblSoXeSuaChuaToiDa = new System.Windows.Forms.Label();
            this.txtBoxSoXeSuaChuaToiDa = new System.Windows.Forms.TextBox();
            this.panelQuyDinhHienHanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuyDinhHienHanh)).BeginInit();
            this.pnCapNhatQuyDinh.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuyDinhHienHanh
            // 
            this.panelQuyDinhHienHanh.Controls.Add(this.buttonLamMoiQuyDinh);
            this.panelQuyDinhHienHanh.Controls.Add(this.labelQuyDinhHienHanh);
            this.panelQuyDinhHienHanh.Controls.Add(this.dataGridViewQuyDinhHienHanh);
            this.panelQuyDinhHienHanh.Location = new System.Drawing.Point(503, 88);
            this.panelQuyDinhHienHanh.Margin = new System.Windows.Forms.Padding(2);
            this.panelQuyDinhHienHanh.Name = "panelQuyDinhHienHanh";
            this.panelQuyDinhHienHanh.Size = new System.Drawing.Size(514, 356);
            this.panelQuyDinhHienHanh.TabIndex = 3;
            // 
            // buttonLamMoiQuyDinh
            // 
            this.buttonLamMoiQuyDinh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLamMoiQuyDinh.Location = new System.Drawing.Point(4, 64);
            this.buttonLamMoiQuyDinh.Name = "buttonLamMoiQuyDinh";
            this.buttonLamMoiQuyDinh.Size = new System.Drawing.Size(75, 23);
            this.buttonLamMoiQuyDinh.TabIndex = 9;
            this.buttonLamMoiQuyDinh.Text = "Làm Mới";
            this.buttonLamMoiQuyDinh.UseVisualStyleBackColor = true;
            this.buttonLamMoiQuyDinh.Click += new System.EventHandler(this.buttonLamMoiQuyDinh_Click);
            // 
            // labelQuyDinhHienHanh
            // 
            this.labelQuyDinhHienHanh.AutoSize = true;
            this.labelQuyDinhHienHanh.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuyDinhHienHanh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelQuyDinhHienHanh.Location = new System.Drawing.Point(142, 33);
            this.labelQuyDinhHienHanh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuyDinhHienHanh.Name = "labelQuyDinhHienHanh";
            this.labelQuyDinhHienHanh.Size = new System.Drawing.Size(241, 25);
            this.labelQuyDinhHienHanh.TabIndex = 1;
            this.labelQuyDinhHienHanh.Text = "QUY ĐỊNH HIỆN HÀNH";
            // 
            // dataGridViewQuyDinhHienHanh
            // 
            this.dataGridViewQuyDinhHienHanh.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewQuyDinhHienHanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuyDinhHienHanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewQuyDinhHienHanh.Location = new System.Drawing.Point(4, 93);
            this.dataGridViewQuyDinhHienHanh.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewQuyDinhHienHanh.Name = "dataGridViewQuyDinhHienHanh";
            this.dataGridViewQuyDinhHienHanh.RowHeadersWidth = 51;
            this.dataGridViewQuyDinhHienHanh.RowTemplate.Height = 24;
            this.dataGridViewQuyDinhHienHanh.Size = new System.Drawing.Size(493, 246);
            this.dataGridViewQuyDinhHienHanh.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên tham số";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Gía trị tham số";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // pnCapNhatQuyDinh
            // 
            this.pnCapNhatQuyDinh.Controls.Add(this.panel2);
            this.pnCapNhatQuyDinh.Controls.Add(this.panel1);
            this.pnCapNhatQuyDinh.Controls.Add(this.lblCapNhatQuyDinh);
            this.pnCapNhatQuyDinh.Controls.Add(this.panel13);
            this.pnCapNhatQuyDinh.Location = new System.Drawing.Point(2, 88);
            this.pnCapNhatQuyDinh.Margin = new System.Windows.Forms.Padding(2);
            this.pnCapNhatQuyDinh.Name = "pnCapNhatQuyDinh";
            this.pnCapNhatQuyDinh.Size = new System.Drawing.Size(497, 356);
            this.pnCapNhatQuyDinh.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCapNhatTienCong);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtboxTienCong);
            this.panel2.Location = new System.Drawing.Point(1, 244);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 31);
            this.panel2.TabIndex = 13;
            // 
            // btnCapNhatTienCong
            // 
            this.btnCapNhatTienCong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapNhatTienCong.Location = new System.Drawing.Point(369, 2);
            this.btnCapNhatTienCong.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhatTienCong.Name = "btnCapNhatTienCong";
            this.btnCapNhatTienCong.Size = new System.Drawing.Size(124, 24);
            this.btnCapNhatTienCong.TabIndex = 12;
            this.btnCapNhatTienCong.Text = "Cập nhật";
            this.btnCapNhatTienCong.UseVisualStyleBackColor = true;
            this.btnCapNhatTienCong.Click += new System.EventHandler(this.btnCapNhatTienCong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(13, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số loại tiền công tối đa:";
            // 
            // txtboxTienCong
            // 
            this.txtboxTienCong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxTienCong.Location = new System.Drawing.Point(163, 2);
            this.txtboxTienCong.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxTienCong.Name = "txtboxTienCong";
            this.txtboxTienCong.Size = new System.Drawing.Size(192, 26);
            this.txtboxTienCong.TabIndex = 1;
            this.txtboxTienCong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxTienCong_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCapNhatHieuxe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtboxHieuxe);
            this.panel1.Location = new System.Drawing.Point(1, 178);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 31);
            this.panel1.TabIndex = 12;
            // 
            // btnCapNhatHieuxe
            // 
            this.btnCapNhatHieuxe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapNhatHieuxe.Location = new System.Drawing.Point(369, 2);
            this.btnCapNhatHieuxe.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhatHieuxe.Name = "btnCapNhatHieuxe";
            this.btnCapNhatHieuxe.Size = new System.Drawing.Size(124, 24);
            this.btnCapNhatHieuxe.TabIndex = 12;
            this.btnCapNhatHieuxe.Text = "Cập nhật";
            this.btnCapNhatHieuxe.UseVisualStyleBackColor = true;
            this.btnCapNhatHieuxe.Click += new System.EventHandler(this.btnCapNhatHieuxe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số hiệu xe tối đa:";
            // 
            // txtboxHieuxe
            // 
            this.txtboxHieuxe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxHieuxe.Location = new System.Drawing.Point(163, 2);
            this.txtboxHieuxe.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxHieuxe.Name = "txtboxHieuxe";
            this.txtboxHieuxe.Size = new System.Drawing.Size(192, 26);
            this.txtboxHieuxe.TabIndex = 1;
            this.txtboxHieuxe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxHieuxe_KeyPress);
            // 
            // lblCapNhatQuyDinh
            // 
            this.lblCapNhatQuyDinh.BackColor = System.Drawing.Color.Transparent;
            this.lblCapNhatQuyDinh.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCapNhatQuyDinh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCapNhatQuyDinh.Location = new System.Drawing.Point(158, 34);
            this.lblCapNhatQuyDinh.Name = "lblCapNhatQuyDinh";
            this.lblCapNhatQuyDinh.Size = new System.Drawing.Size(218, 27);
            this.lblCapNhatQuyDinh.TabIndex = 11;
            this.lblCapNhatQuyDinh.Text = "CẬP NHẬT QUY ĐỊNH\r\n";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnCapNhatSoXeSuaToiDa);
            this.panel13.Controls.Add(this.lblSoXeSuaChuaToiDa);
            this.panel13.Controls.Add(this.txtBoxSoXeSuaChuaToiDa);
            this.panel13.Location = new System.Drawing.Point(0, 117);
            this.panel13.Margin = new System.Windows.Forms.Padding(2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(495, 31);
            this.panel13.TabIndex = 7;
            // 
            // btnCapNhatSoXeSuaToiDa
            // 
            this.btnCapNhatSoXeSuaToiDa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapNhatSoXeSuaToiDa.Location = new System.Drawing.Point(369, 2);
            this.btnCapNhatSoXeSuaToiDa.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhatSoXeSuaToiDa.Name = "btnCapNhatSoXeSuaToiDa";
            this.btnCapNhatSoXeSuaToiDa.Size = new System.Drawing.Size(124, 24);
            this.btnCapNhatSoXeSuaToiDa.TabIndex = 12;
            this.btnCapNhatSoXeSuaToiDa.Text = "Cập nhật";
            this.btnCapNhatSoXeSuaToiDa.UseVisualStyleBackColor = true;
            this.btnCapNhatSoXeSuaToiDa.Click += new System.EventHandler(this.btnCapNhatSoXeSuaToiDa_Click);
            // 
            // lblSoXeSuaChuaToiDa
            // 
            this.lblSoXeSuaChuaToiDa.AutoSize = true;
            this.lblSoXeSuaChuaToiDa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoXeSuaChuaToiDa.Location = new System.Drawing.Point(13, 2);
            this.lblSoXeSuaChuaToiDa.Name = "lblSoXeSuaChuaToiDa";
            this.lblSoXeSuaChuaToiDa.Size = new System.Drawing.Size(145, 19);
            this.lblSoXeSuaChuaToiDa.TabIndex = 2;
            this.lblSoXeSuaChuaToiDa.Text = "Số xe sửa chữa tối đa:";
            // 
            // txtBoxSoXeSuaChuaToiDa
            // 
            this.txtBoxSoXeSuaChuaToiDa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSoXeSuaChuaToiDa.Location = new System.Drawing.Point(163, 2);
            this.txtBoxSoXeSuaChuaToiDa.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxSoXeSuaChuaToiDa.Name = "txtBoxSoXeSuaChuaToiDa";
            this.txtBoxSoXeSuaChuaToiDa.Size = new System.Drawing.Size(192, 26);
            this.txtBoxSoXeSuaChuaToiDa.TabIndex = 1;
            this.txtBoxSoXeSuaChuaToiDa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSoXeSuaChuaToiDa_KeyPress);
            // 
            // Chinhsuaquydinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panelQuyDinhHienHanh);
            this.Controls.Add(this.pnCapNhatQuyDinh);
            this.Name = "Chinhsuaquydinh";
            this.Size = new System.Drawing.Size(1175, 717);
            this.VisibleChanged += new System.EventHandler(this.Chinhsuaquydinh_VisibleChanged);
            this.panelQuyDinhHienHanh.ResumeLayout(false);
            this.panelQuyDinhHienHanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuyDinhHienHanh)).EndInit();
            this.pnCapNhatQuyDinh.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelQuyDinhHienHanh;
        private System.Windows.Forms.Button buttonLamMoiQuyDinh;
        private System.Windows.Forms.Label labelQuyDinhHienHanh;
        private System.Windows.Forms.DataGridView dataGridViewQuyDinhHienHanh;
        private System.Windows.Forms.Panel pnCapNhatQuyDinh;
        private System.Windows.Forms.Label lblCapNhatQuyDinh;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnCapNhatSoXeSuaToiDa;
        private System.Windows.Forms.Label lblSoXeSuaChuaToiDa;
        private System.Windows.Forms.TextBox txtBoxSoXeSuaChuaToiDa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCapNhatTienCong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxTienCong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCapNhatHieuxe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxHieuxe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
