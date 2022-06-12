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
            this.dataGridViewStorageReport = new System.Windows.Forms.DataGridView();
            this.OrderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpawnsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStorageReport)).BeginInit();
            this.SuspendLayout();
            // 
            // getStorageReportButton
            // 
            this.getStorageReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getStorageReportButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getStorageReportButton.Location = new System.Drawing.Point(647, 63);
            this.getStorageReportButton.Margin = new System.Windows.Forms.Padding(2);
            this.getStorageReportButton.Name = "getStorageReportButton";
            this.getStorageReportButton.Size = new System.Drawing.Size(92, 30);
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
            this.lblCapNhatQuyDinh.Location = new System.Drawing.Point(378, 31);
            this.lblCapNhatQuyDinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCapNhatQuyDinh.Name = "lblCapNhatQuyDinh";
            this.lblCapNhatQuyDinh.Size = new System.Drawing.Size(131, 22);
            this.lblCapNhatQuyDinh.TabIndex = 13;
            this.lblCapNhatQuyDinh.Text = "TỒN KHO";
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
            this.dataGridViewStorageReport.Location = new System.Drawing.Point(82, 124);
            this.dataGridViewStorageReport.Margin = new System.Windows.Forms.Padding(2);
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
            this.dataGridViewStorageReport.Size = new System.Drawing.Size(795, 329);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(166)))), ((int)(((byte)(235)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(216, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(58, 2);
            this.panel2.TabIndex = 62;
            // 
            // monthComboBox
            // 
            this.monthComboBox.DisplayMember = "BienSo";
            this.monthComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monthComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(215, 66);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(75, 27);
            this.monthComboBox.TabIndex = 61;
            this.monthComboBox.ValueMember = "BienSo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(166)))), ((int)(((byte)(235)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(373, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(69, 2);
            this.panel1.TabIndex = 64;
            // 
            // yearComboBox
            // 
            this.yearComboBox.DisplayMember = "BienSo";
            this.yearComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yearComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(372, 66);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(86, 27);
            this.yearComboBox.TabIndex = 63;
            this.yearComboBox.ValueMember = "BienSo";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(320, 69);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(46, 19);
            this.yearLabel.TabIndex = 65;
            this.yearLabel.Text = "Năm :";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.Location = new System.Drawing.Point(156, 69);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(53, 19);
            this.monthLabel.TabIndex = 66;
            this.monthLabel.Text = "Tháng :";
            // 
            // Baocaoton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.dataGridViewStorageReport);
            this.Controls.Add(this.lblCapNhatQuyDinh);
            this.Controls.Add(this.getStorageReportButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Baocaoton";
            this.Size = new System.Drawing.Size(918, 652);
            this.Load += new System.EventHandler(this.Baocaoton_Load);
            this.VisibleChanged += new System.EventHandler(this.Baocaoton_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStorageReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button getStorageReportButton;
        private System.Windows.Forms.Label lblCapNhatQuyDinh;
        private System.Windows.Forms.DataGridView dataGridViewStorageReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalAmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpawnsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalAmount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label monthLabel;
    }
}
