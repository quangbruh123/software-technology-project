namespace GarageManager.usercontrol
{
    partial class Nhapvatu
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
            this.cancerbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTenVTPTMoi = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxTenVTPTMoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGiaVTPT = new System.Windows.Forms.Label();
            this.textBoxDongiaBan = new System.Windows.Forms.TextBox();
            this.textBoxDongiaNhap = new System.Windows.Forms.TextBox();
            this.labelSoLuongVTPT = new System.Windows.Forms.Label();
            this.textBoxSoLuongVTPT = new System.Windows.Forms.TextBox();
            this.labelPhieuNhapVTPT = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancerbtn
            // 
            this.cancerbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancerbtn.Location = new System.Drawing.Point(844, 467);
            this.cancerbtn.Name = "cancerbtn";
            this.cancerbtn.Size = new System.Drawing.Size(94, 32);
            this.cancerbtn.TabIndex = 32;
            this.cancerbtn.Text = "Hủy";
            this.cancerbtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(844, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 32);
            this.button1.TabIndex = 33;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // labelTenVTPTMoi
            // 
            this.labelTenVTPTMoi.AutoSize = true;
            this.labelTenVTPTMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenVTPTMoi.Location = new System.Drawing.Point(565, 118);
            this.labelTenVTPTMoi.Name = "labelTenVTPTMoi";
            this.labelTenVTPTMoi.Size = new System.Drawing.Size(144, 19);
            this.labelTenVTPTMoi.TabIndex = 23;
            this.labelTenVTPTMoi.Text = "Tên Vật Tư Phụ Tùng:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(952, 111);
            this.textBox1.MaxLength = 30;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 26);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxTenVTPTMoi
            // 
            this.textBoxTenVTPTMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenVTPTMoi.Location = new System.Drawing.Point(715, 115);
            this.textBoxTenVTPTMoi.MaxLength = 30;
            this.textBoxTenVTPTMoi.Name = "textBoxTenVTPTMoi";
            this.textBoxTenVTPTMoi.Size = new System.Drawing.Size(121, 26);
            this.textBoxTenVTPTMoi.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(857, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Đơn giá bán :";
            // 
            // labelGiaVTPT
            // 
            this.labelGiaVTPT.AutoSize = true;
            this.labelGiaVTPT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGiaVTPT.Location = new System.Drawing.Point(613, 167);
            this.labelGiaVTPT.Name = "labelGiaVTPT";
            this.labelGiaVTPT.Size = new System.Drawing.Size(96, 19);
            this.labelGiaVTPT.TabIndex = 28;
            this.labelGiaVTPT.Text = "Đơn giá nhập :";
            // 
            // textBoxDongiaBan
            // 
            this.textBoxDongiaBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDongiaBan.Location = new System.Drawing.Point(952, 166);
            this.textBoxDongiaBan.Name = "textBoxDongiaBan";
            this.textBoxDongiaBan.Size = new System.Drawing.Size(136, 26);
            this.textBoxDongiaBan.TabIndex = 29;
            // 
            // textBoxDongiaNhap
            // 
            this.textBoxDongiaNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDongiaNhap.Location = new System.Drawing.Point(715, 160);
            this.textBoxDongiaNhap.Name = "textBoxDongiaNhap";
            this.textBoxDongiaNhap.Size = new System.Drawing.Size(121, 26);
            this.textBoxDongiaNhap.TabIndex = 30;
            // 
            // labelSoLuongVTPT
            // 
            this.labelSoLuongVTPT.AutoSize = true;
            this.labelSoLuongVTPT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuongVTPT.Location = new System.Drawing.Point(861, 115);
            this.labelSoLuongVTPT.Name = "labelSoLuongVTPT";
            this.labelSoLuongVTPT.Size = new System.Drawing.Size(77, 19);
            this.labelSoLuongVTPT.TabIndex = 21;
            this.labelSoLuongVTPT.Text = "Số Lượng :";
            // 
            // textBoxSoLuongVTPT
            // 
            this.textBoxSoLuongVTPT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoLuongVTPT.Location = new System.Drawing.Point(715, 211);
            this.textBoxSoLuongVTPT.Name = "textBoxSoLuongVTPT";
            this.textBoxSoLuongVTPT.Size = new System.Drawing.Size(122, 26);
            this.textBoxSoLuongVTPT.TabIndex = 24;
            // 
            // labelPhieuNhapVTPT
            // 
            this.labelPhieuNhapVTPT.AutoSize = true;
            this.labelPhieuNhapVTPT.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhieuNhapVTPT.Location = new System.Drawing.Point(441, 12);
            this.labelPhieuNhapVTPT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhieuNhapVTPT.Name = "labelPhieuNhapVTPT";
            this.labelPhieuNhapVTPT.Size = new System.Drawing.Size(318, 33);
            this.labelPhieuNhapVTPT.TabIndex = 20;
            this.labelPhieuNhapVTPT.Text = "Phiếu nhập vật tư phụ tùng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(27, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(520, 320);
            this.dataGridView1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(746, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nhập mới vật tư phụ tùng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(634, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tiền công :";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Stt";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tên vật tư";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.Name = "Column3";
            this.Column3.Width = 69;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Số lượng tồn";
            this.Column4.Name = "Column4";
            // 
            // Nhapvatu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancerbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTenVTPTMoi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxTenVTPTMoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelGiaVTPT);
            this.Controls.Add(this.textBoxDongiaBan);
            this.Controls.Add(this.textBoxDongiaNhap);
            this.Controls.Add(this.labelSoLuongVTPT);
            this.Controls.Add(this.textBoxSoLuongVTPT);
            this.Controls.Add(this.labelPhieuNhapVTPT);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Nhapvatu";
            this.Size = new System.Drawing.Size(1089, 512);
            this.Load += new System.EventHandler(this.Nhapvatu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancerbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTenVTPTMoi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxTenVTPTMoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGiaVTPT;
        private System.Windows.Forms.TextBox textBoxDongiaBan;
        private System.Windows.Forms.TextBox textBoxDongiaNhap;
        private System.Windows.Forms.Label labelSoLuongVTPT;
        private System.Windows.Forms.TextBox textBoxSoLuongVTPT;
        private System.Windows.Forms.Label labelPhieuNhapVTPT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
