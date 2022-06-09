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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.getStorageReportButton = new System.Windows.Forms.Button();
            this.lblCapNhatQuyDinh = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridViewStorageReport = new System.Windows.Forms.DataGridView();
            this.OrderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpawnsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStorageReport)).BeginInit();
            this.SuspendLayout();
            // 
            // getStorageReportButton
            // 
            this.getStorageReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getStorageReportButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getStorageReportButton.Location = new System.Drawing.Point(777, 71);
            this.getStorageReportButton.Margin = new System.Windows.Forms.Padding(2);
            this.getStorageReportButton.Name = "getStorageReportButton";
            this.getStorageReportButton.Size = new System.Drawing.Size(122, 28);
            this.getStorageReportButton.TabIndex = 10;
            this.getStorageReportButton.Text = "Xem";
            this.getStorageReportButton.UseVisualStyleBackColor = true;
            this.getStorageReportButton.Click += new System.EventHandler(this.getStorageReportButton_Click);
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
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(298, 76);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(46, 19);
            this.yearLabel.TabIndex = 26;
            this.yearLabel.Text = "Năm :";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.Location = new System.Drawing.Point(148, 76);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(53, 19);
            this.monthLabel.TabIndex = 27;
            this.monthLabel.Text = "Tháng :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(166)))), ((int)(((byte)(235)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(351, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(76, 2);
            this.panel2.TabIndex = 57;
            // 
            // yearComboBox
            // 
            this.yearComboBox.DisplayMember = "BienSo";
            this.yearComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yearComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(350, 70);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(93, 27);
            this.yearComboBox.TabIndex = 56;
            this.yearComboBox.ValueMember = "BienSo";
            this.yearComboBox.SelectionChangeCommitted += new System.EventHandler(this.yearComboBox_SelectionChangeCommitted);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(166)))), ((int)(((byte)(235)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(208, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(49, 2);
            this.panel1.TabIndex = 59;
            // 
            // monthComboBox
            // 
            this.monthComboBox.DisplayMember = "BienSo";
            this.monthComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monthComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(207, 70);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(66, 27);
            this.monthComboBox.TabIndex = 58;
            this.monthComboBox.ValueMember = "BienSo";
            this.monthComboBox.SelectionChangeCommitted += new System.EventHandler(this.monthComboBox_SelectionChangeCommitted);
            // 
            // dataGridViewStorageReport
            // 
            this.dataGridViewStorageReport.AllowUserToAddRows = false;
            this.dataGridViewStorageReport.AllowUserToDeleteRows = false;
            this.dataGridViewStorageReport.AllowUserToResizeColumns = false;
            this.dataGridViewStorageReport.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStorageReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStorageReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStorageReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderColumn,
            this.PartNameColumn,
            this.OriginalAmountColumn,
            this.SpawnsColumn,
            this.FinalAmount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStorageReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStorageReport.Location = new System.Drawing.Point(70, 139);
            this.dataGridViewStorageReport.MultiSelect = false;
            this.dataGridViewStorageReport.Name = "dataGridViewStorageReport";
            this.dataGridViewStorageReport.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStorageReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewStorageReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStorageReport.Size = new System.Drawing.Size(934, 338);
            this.dataGridViewStorageReport.TabIndex = 60;
            // 
            // OrderColumn
            // 
            this.OrderColumn.HeaderText = "STT";
            this.OrderColumn.Name = "OrderColumn";
            this.OrderColumn.ReadOnly = true;
            this.OrderColumn.Width = 50;
            // 
            // PartNameColumn
            // 
            this.PartNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PartNameColumn.HeaderText = "Tên vật tư";
            this.PartNameColumn.Name = "PartNameColumn";
            this.PartNameColumn.ReadOnly = true;
            // 
            // OriginalAmountColumn
            // 
            this.OriginalAmountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OriginalAmountColumn.HeaderText = "Tồn đầu";
            this.OriginalAmountColumn.Name = "OriginalAmountColumn";
            this.OriginalAmountColumn.ReadOnly = true;
            // 
            // SpawnsColumn
            // 
            this.SpawnsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SpawnsColumn.HeaderText = "Phát sinh";
            this.SpawnsColumn.Name = "SpawnsColumn";
            this.SpawnsColumn.ReadOnly = true;
            // 
            // FinalAmount
            // 
            this.FinalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FinalAmount.HeaderText = "Tồn cuối";
            this.FinalAmount.Name = "FinalAmount";
            this.FinalAmount.ReadOnly = true;
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
            this.Controls.Add(this.dataGridViewStorageReport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.lblCapNhatQuyDinh);
            this.Controls.Add(this.getStorageReportButton);
            this.Name = "Baocaoton";
            this.Size = new System.Drawing.Size(1089, 668);
            this.Load += new System.EventHandler(this.Baocaoton_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStorageReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button getStorageReportButton;
        private System.Windows.Forms.Label lblCapNhatQuyDinh;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.DataGridView dataGridViewStorageReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalAmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpawnsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalAmount;
    }
}
