namespace GarageManager.usercontrol
{
    partial class Nhaptiencong
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
            this.cancerbtn = new System.Windows.Forms.Button();
            this.labelPhieuNhapVTPT = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.labelTenVTPTMoi = new System.Windows.Forms.Label();
            this.textBoxTenVTPTMoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSoLuongVTPT = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnChonSua = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTCSua = new System.Windows.Forms.TextBox();
            this.textBoxDGMoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancerbtn
            // 
            this.cancerbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancerbtn.Location = new System.Drawing.Point(939, 477);
            this.cancerbtn.Name = "cancerbtn";
            this.cancerbtn.Size = new System.Drawing.Size(142, 32);
            this.cancerbtn.TabIndex = 47;
            this.cancerbtn.Text = "Hủy";
            this.cancerbtn.UseVisualStyleBackColor = false;
            this.cancerbtn.Click += new System.EventHandler(this.cancerbtn_Click);
            // 
            // labelPhieuNhapVTPT
            // 
            this.labelPhieuNhapVTPT.AutoSize = true;
            this.labelPhieuNhapVTPT.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhieuNhapVTPT.Location = new System.Drawing.Point(428, 13);
            this.labelPhieuNhapVTPT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhieuNhapVTPT.Name = "labelPhieuNhapVTPT";
            this.labelPhieuNhapVTPT.Size = new System.Drawing.Size(251, 33);
            this.labelPhieuNhapVTPT.TabIndex = 36;
            this.labelPhieuNhapVTPT.Text = "Phiếu nhập tiền công";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(5, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 329);
            this.panel1.TabIndex = 51;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(446, 320);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Stt";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tên tiền công";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.Name = "Column3";
            // 
            // btnSua
            // 
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(402, 71);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(142, 32);
            this.btnSua.TabIndex = 52;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Thêm",
            "Chỉnh sửa"});
            this.comboBox1.Location = new System.Drawing.Point(480, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 28);
            this.comboBox1.TabIndex = 54;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.labelTenVTPTMoi);
            this.panel2.Controls.Add(this.textBoxTenVTPTMoi);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxSoLuongVTPT);
            this.panel2.Location = new System.Drawing.Point(480, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 134);
            this.panel2.TabIndex = 55;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(402, 74);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(142, 32);
            this.btnThem.TabIndex = 53;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTenVTPTMoi
            // 
            this.labelTenVTPTMoi.AutoSize = true;
            this.labelTenVTPTMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenVTPTMoi.Location = new System.Drawing.Point(10, 29);
            this.labelTenVTPTMoi.Name = "labelTenVTPTMoi";
            this.labelTenVTPTMoi.Size = new System.Drawing.Size(119, 19);
            this.labelTenVTPTMoi.TabIndex = 49;
            this.labelTenVTPTMoi.Text = "Tên tiền công mới:";
            // 
            // textBoxTenVTPTMoi
            // 
            this.textBoxTenVTPTMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenVTPTMoi.Location = new System.Drawing.Point(135, 26);
            this.textBoxTenVTPTMoi.MaxLength = 30;
            this.textBoxTenVTPTMoi.Name = "textBoxTenVTPTMoi";
            this.textBoxTenVTPTMoi.Size = new System.Drawing.Size(243, 26);
            this.textBoxTenVTPTMoi.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 52;
            this.label3.Text = "Đơn giá:";
            // 
            // textBoxSoLuongVTPT
            // 
            this.textBoxSoLuongVTPT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoLuongVTPT.Location = new System.Drawing.Point(135, 77);
            this.textBoxSoLuongVTPT.Name = "textBoxSoLuongVTPT";
            this.textBoxSoLuongVTPT.Size = new System.Drawing.Size(243, 26);
            this.textBoxSoLuongVTPT.TabIndex = 50;
            this.textBoxSoLuongVTPT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoLuongVTPT_KeyPress);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnChonSua);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBoxTCSua);
            this.panel4.Controls.Add(this.textBoxDGMoi);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnSua);
            this.panel4.Location = new System.Drawing.Point(480, 279);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(556, 112);
            this.panel4.TabIndex = 57;
            // 
            // btnChonSua
            // 
            this.btnChonSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonSua.Location = new System.Drawing.Point(402, 23);
            this.btnChonSua.Name = "btnChonSua";
            this.btnChonSua.Size = new System.Drawing.Size(142, 32);
            this.btnChonSua.TabIndex = 55;
            this.btnChonSua.Text = "Chọn";
            this.btnChonSua.UseVisualStyleBackColor = true;
            this.btnChonSua.Click += new System.EventHandler(this.btnChonSua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 54;
            this.label4.Text = "Đơn giá mới:";
            // 
            // textBoxTCSua
            // 
            this.textBoxTCSua.Enabled = false;
            this.textBoxTCSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTCSua.Location = new System.Drawing.Point(129, 26);
            this.textBoxTCSua.Name = "textBoxTCSua";
            this.textBoxTCSua.ReadOnly = true;
            this.textBoxTCSua.Size = new System.Drawing.Size(249, 26);
            this.textBoxTCSua.TabIndex = 53;
            this.textBoxTCSua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDGMoi_KeyPress);
            // 
            // textBoxDGMoi
            // 
            this.textBoxDGMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDGMoi.Location = new System.Drawing.Point(129, 74);
            this.textBoxDGMoi.Name = "textBoxDGMoi";
            this.textBoxDGMoi.Size = new System.Drawing.Size(249, 26);
            this.textBoxDGMoi.TabIndex = 53;
            this.textBoxDGMoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDGMoi_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 38);
            this.label2.TabIndex = 49;
            this.label2.Text = "Tên tiền công \r\nđược sửa:";
            // 
            // Nhaptiencong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cancerbtn);
            this.Controls.Add(this.labelPhieuNhapVTPT);
            this.Controls.Add(this.panel1);
            this.Name = "Nhaptiencong";
            this.Size = new System.Drawing.Size(1089, 512);
            this.Load += new System.EventHandler(this.Nhaptiencong_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancerbtn;
        private System.Windows.Forms.Label labelPhieuNhapVTPT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label labelTenVTPTMoi;
        private System.Windows.Forms.TextBox textBoxTenVTPTMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSoLuongVTPT;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDGMoi;
        private System.Windows.Forms.Button btnChonSua;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox textBoxTCSua;
    }
}
