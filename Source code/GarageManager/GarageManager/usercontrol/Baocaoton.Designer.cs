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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblThangBaoCaoTon = new System.Windows.Forms.Label();
            this.lblCapNhatQuyDinh = new System.Windows.Forms.Label();
            this.dataGridViewBaoCaoDoanhSo = new System.Windows.Forms.DataGridView();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.getFinancialReportButton = new System.Windows.Forms.Button();
            this.yearLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaoCaoDoanhSo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThangBaoCaoTon
            // 
            this.lblThangBaoCaoTon.AutoSize = true;
            this.lblThangBaoCaoTon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThangBaoCaoTon.Location = new System.Drawing.Point(636, 162);
            this.lblThangBaoCaoTon.Name = "lblThangBaoCaoTon";
            this.lblThangBaoCaoTon.Size = new System.Drawing.Size(58, 22);
            this.lblThangBaoCaoTon.TabIndex = 7;
            this.lblThangBaoCaoTon.Text = "Tháng";
            // 
            // lblCapNhatQuyDinh
            // 
            this.lblCapNhatQuyDinh.BackColor = System.Drawing.Color.Transparent;
            this.lblCapNhatQuyDinh.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCapNhatQuyDinh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCapNhatQuyDinh.Location = new System.Drawing.Point(699, 47);
            this.lblCapNhatQuyDinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapNhatQuyDinh.Name = "lblCapNhatQuyDinh";
            this.lblCapNhatQuyDinh.Size = new System.Drawing.Size(153, 33);
            this.lblCapNhatQuyDinh.TabIndex = 13;
            this.lblCapNhatQuyDinh.Text = "TỒN KHO";
            // 
            // dataGridViewBaoCaoDoanhSo
            // 
            this.dataGridViewBaoCaoDoanhSo.AllowUserToAddRows = false;
            this.dataGridViewBaoCaoDoanhSo.AllowUserToDeleteRows = false;
            this.dataGridViewBaoCaoDoanhSo.AllowUserToResizeColumns = false;
            this.dataGridViewBaoCaoDoanhSo.AllowUserToResizeRows = false;
            this.dataGridViewBaoCaoDoanhSo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBaoCaoDoanhSo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewBaoCaoDoanhSo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(166)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBaoCaoDoanhSo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBaoCaoDoanhSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBaoCaoDoanhSo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewBaoCaoDoanhSo.EnableHeadersVisualStyles = false;
            this.dataGridViewBaoCaoDoanhSo.Location = new System.Drawing.Point(89, 209);
            this.dataGridViewBaoCaoDoanhSo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewBaoCaoDoanhSo.MultiSelect = false;
            this.dataGridViewBaoCaoDoanhSo.Name = "dataGridViewBaoCaoDoanhSo";
            this.dataGridViewBaoCaoDoanhSo.ReadOnly = true;
            this.dataGridViewBaoCaoDoanhSo.RowHeadersVisible = false;
            this.dataGridViewBaoCaoDoanhSo.RowHeadersWidth = 51;
            this.dataGridViewBaoCaoDoanhSo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewBaoCaoDoanhSo.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBaoCaoDoanhSo.RowTemplate.Height = 24;
            this.dataGridViewBaoCaoDoanhSo.Size = new System.Drawing.Size(1285, 332);
            this.dataGridViewBaoCaoDoanhSo.TabIndex = 14;
            // 
            // yearComboBox
            // 
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(505, 105);
            this.yearComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(123, 24);
            this.yearComboBox.TabIndex = 29;
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(314, 105);
            this.monthComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(87, 24);
            this.monthComboBox.TabIndex = 30;
            // 
            // getFinancialReportButton
            // 
            this.getFinancialReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getFinancialReportButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getFinancialReportButton.Location = new System.Drawing.Point(1055, 101);
            this.getFinancialReportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getFinancialReportButton.Name = "getFinancialReportButton";
            this.getFinancialReportButton.Size = new System.Drawing.Size(163, 34);
            this.getFinancialReportButton.TabIndex = 28;
            this.getFinancialReportButton.Text = "Xem";
            this.getFinancialReportButton.UseVisualStyleBackColor = true;
            this.getFinancialReportButton.Click += new System.EventHandler(this.getFinancialReportButton_Click);
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(435, 108);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(58, 22);
            this.yearLabel.TabIndex = 26;
            this.yearLabel.Text = "Năm :";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.Location = new System.Drawing.Point(235, 108);
            this.monthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(69, 22);
            this.monthLabel.TabIndex = 27;
            this.monthLabel.Text = "Tháng :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(701, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(67, 22);
            this.textBox1.TabIndex = 31;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 53.47594F;
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 111.631F;
            this.Column2.HeaderText = "Vật Tư Phụ Tùng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 111.631F;
            this.Column3.HeaderText = "Tồn Đầu";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 111.631F;
            this.Column4.HeaderText = "Phát Sinh";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 111.631F;
            this.Column5.HeaderText = "Tồn Cuối";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Baocaoton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.getFinancialReportButton);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.dataGridViewBaoCaoDoanhSo);
            this.Controls.Add(this.lblCapNhatQuyDinh);
            this.Controls.Add(this.lblThangBaoCaoTon);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Baocaoton";
            this.Size = new System.Drawing.Size(1452, 822);
            this.Load += new System.EventHandler(this.Baocaoton_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaoCaoDoanhSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblThangBaoCaoTon;
        private System.Windows.Forms.Label lblCapNhatQuyDinh;
        private System.Windows.Forms.DataGridView dataGridViewBaoCaoDoanhSo;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.Button getFinancialReportButton;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
