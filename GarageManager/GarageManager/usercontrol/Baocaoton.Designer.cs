namespace GarageManager.usercontrol
{
    partial class Baocaoton
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
            this.btnBaoCaoTonMoi = new System.Windows.Forms.Button();
            this.lblChonThoiDiemTon = new System.Windows.Forms.Label();
            this.dateTimePickerChonThoiDiemBaoCaoTon = new System.Windows.Forms.DateTimePicker();
            this.btnLapBaoCaoTon = new System.Windows.Forms.Button();
            this.lblThangBaoCaoTon = new System.Windows.Forms.Label();
            this.dataGridViewBaoCaoTon = new System.Windows.Forms.DataGridView();
            this.lblCapNhatQuyDinh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaoCaoTon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaoCaoTonMoi
            // 
            this.btnBaoCaoTonMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaoCaoTonMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCaoTonMoi.Location = new System.Drawing.Point(819, 68);
            this.btnBaoCaoTonMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnBaoCaoTonMoi.Name = "btnBaoCaoTonMoi";
            this.btnBaoCaoTonMoi.Size = new System.Drawing.Size(122, 28);
            this.btnBaoCaoTonMoi.TabIndex = 12;
            this.btnBaoCaoTonMoi.Text = "Báo cáo mới";
            this.btnBaoCaoTonMoi.UseVisualStyleBackColor = true;
            // 
            // lblChonThoiDiemTon
            // 
            this.lblChonThoiDiemTon.AutoSize = true;
            this.lblChonThoiDiemTon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonThoiDiemTon.Location = new System.Drawing.Point(193, 77);
            this.lblChonThoiDiemTon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChonThoiDiemTon.Name = "lblChonThoiDiemTon";
            this.lblChonThoiDiemTon.Size = new System.Drawing.Size(104, 19);
            this.lblChonThoiDiemTon.TabIndex = 11;
            this.lblChonThoiDiemTon.Text = "Chọn thời điểm:";
            // 
            // dateTimePickerChonThoiDiemBaoCaoTon
            // 
            this.dateTimePickerChonThoiDiemBaoCaoTon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerChonThoiDiemBaoCaoTon.Location = new System.Drawing.Point(315, 76);
            this.dateTimePickerChonThoiDiemBaoCaoTon.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerChonThoiDiemBaoCaoTon.Name = "dateTimePickerChonThoiDiemBaoCaoTon";
            this.dateTimePickerChonThoiDiemBaoCaoTon.Size = new System.Drawing.Size(228, 20);
            this.dateTimePickerChonThoiDiemBaoCaoTon.TabIndex = 8;
            // 
            // btnLapBaoCaoTon
            // 
            this.btnLapBaoCaoTon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLapBaoCaoTon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapBaoCaoTon.Location = new System.Drawing.Point(662, 68);
            this.btnLapBaoCaoTon.Margin = new System.Windows.Forms.Padding(2);
            this.btnLapBaoCaoTon.Name = "btnLapBaoCaoTon";
            this.btnLapBaoCaoTon.Size = new System.Drawing.Size(122, 28);
            this.btnLapBaoCaoTon.TabIndex = 10;
            this.btnLapBaoCaoTon.Text = "Lập báo cáo";
            this.btnLapBaoCaoTon.UseVisualStyleBackColor = true;
            // 
            // lblThangBaoCaoTon
            // 
            this.lblThangBaoCaoTon.AutoSize = true;
            this.lblThangBaoCaoTon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThangBaoCaoTon.Location = new System.Drawing.Point(477, 132);
            this.lblThangBaoCaoTon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThangBaoCaoTon.Name = "lblThangBaoCaoTon";
            this.lblThangBaoCaoTon.Size = new System.Drawing.Size(46, 19);
            this.lblThangBaoCaoTon.TabIndex = 7;
            this.lblThangBaoCaoTon.Text = "Tháng";
            // 
            // dataGridViewBaoCaoTon
            // 
            this.dataGridViewBaoCaoTon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewBaoCaoTon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBaoCaoTon.Location = new System.Drawing.Point(70, 162);
            this.dataGridViewBaoCaoTon.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewBaoCaoTon.Name = "dataGridViewBaoCaoTon";
            this.dataGridViewBaoCaoTon.RowHeadersWidth = 51;
            this.dataGridViewBaoCaoTon.RowTemplate.Height = 24;
            this.dataGridViewBaoCaoTon.Size = new System.Drawing.Size(934, 240);
            this.dataGridViewBaoCaoTon.TabIndex = 9;
            // 
            // lblCapNhatQuyDinh
            // 
            this.lblCapNhatQuyDinh.BackColor = System.Drawing.Color.Transparent;
            this.lblCapNhatQuyDinh.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCapNhatQuyDinh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCapNhatQuyDinh.Location = new System.Drawing.Point(524, 38);
            this.lblCapNhatQuyDinh.Name = "lblCapNhatQuyDinh";
            this.lblCapNhatQuyDinh.Size = new System.Drawing.Size(115, 27);
            this.lblCapNhatQuyDinh.TabIndex = 13;
            this.lblCapNhatQuyDinh.Text = "TỒN KHO";
            // 
            // Baocaoton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lblCapNhatQuyDinh);
            this.Controls.Add(this.btnBaoCaoTonMoi);
            this.Controls.Add(this.lblChonThoiDiemTon);
            this.Controls.Add(this.dateTimePickerChonThoiDiemBaoCaoTon);
            this.Controls.Add(this.btnLapBaoCaoTon);
            this.Controls.Add(this.lblThangBaoCaoTon);
            this.Controls.Add(this.dataGridViewBaoCaoTon);
            this.Name = "Baocaoton";
            this.Size = new System.Drawing.Size(1089, 668);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaoCaoTon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaoCaoTonMoi;
        private System.Windows.Forms.Label lblChonThoiDiemTon;
        private System.Windows.Forms.DateTimePicker dateTimePickerChonThoiDiemBaoCaoTon;
        private System.Windows.Forms.Button btnLapBaoCaoTon;
        private System.Windows.Forms.Label lblThangBaoCaoTon;
        private System.Windows.Forms.DataGridView dataGridViewBaoCaoTon;
        private System.Windows.Forms.Label lblCapNhatQuyDinh;
    }
}
