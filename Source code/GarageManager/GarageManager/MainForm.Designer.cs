namespace GarageManager
{
    partial class MainForm
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
            this.mainpanel = new System.Windows.Forms.Panel();
            this.dataGridViewNhanvien = new System.Windows.Forms.DataGridView();
            this.gradient2 = new GarageManager.Control.gradient();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.gradient1 = new GarageManager.Control.gradient();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Tracuubtn = new System.Windows.Forms.Button();
            this.Baocaothangbtn = new System.Windows.Forms.Button();
            this.Lapphieubtn = new System.Windows.Forms.Button();
            this.Tiepnhanbaotrixebtn = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.Trangchubtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Mktxt = new System.Windows.Forms.TextBox();
            this.tktxt = new System.Windows.Forms.TextBox();
            this.Addaccount = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.deletetktxt = new System.Windows.Forms.TextBox();
            this.deletebnt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.Nhanviencbb = new System.Windows.Forms.ComboBox();
            this.mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanvien)).BeginInit();
            this.gradient2.SuspendLayout();
            this.gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainpanel.Controls.Add(this.label7);
            this.mainpanel.Controls.Add(this.label4);
            this.mainpanel.Controls.Add(this.panel2);
            this.mainpanel.Controls.Add(this.panel1);
            this.mainpanel.Controls.Add(this.dataGridViewNhanvien);
            this.mainpanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainpanel.Location = new System.Drawing.Point(214, 31);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1087, 721);
            this.mainpanel.TabIndex = 6;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint);
            // 
            // dataGridViewNhanvien
            // 
            this.dataGridViewNhanvien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column4,
            this.Column2});
            this.dataGridViewNhanvien.Location = new System.Drawing.Point(21, 376);
            this.dataGridViewNhanvien.Name = "dataGridViewNhanvien";
            this.dataGridViewNhanvien.Size = new System.Drawing.Size(532, 244);
            this.dataGridViewNhanvien.TabIndex = 1;
            // 
            // gradient2
            // 
            this.gradient2.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.gradient2.ColorTop = System.Drawing.Color.Silver;
            this.gradient2.Controls.Add(this.CloseBtn);
            this.gradient2.Controls.Add(this.MinimizeBtn);
            this.gradient2.Location = new System.Drawing.Point(0, 0);
            this.gradient2.Name = "gradient2";
            this.gradient2.Size = new System.Drawing.Size(1301, 29);
            this.gradient2.TabIndex = 24;
            // 
            // CloseBtn
            // 
            this.CloseBtn.AllowDrop = true;
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(166)))), ((int)(((byte)(235)))));
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseBtn.Image = global::GarageManager.Properties.Resources.Close_30px;
            this.CloseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseBtn.Location = new System.Drawing.Point(1258, 1);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(43, 28);
            this.CloseBtn.TabIndex = 14;
            this.CloseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.AllowDrop = true;
            this.MinimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MinimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(166)))), ((int)(((byte)(235)))));
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MinimizeBtn.Image = global::GarageManager.Properties.Resources.subtract_30px;
            this.MinimizeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MinimizeBtn.Location = new System.Drawing.Point(1217, 1);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(43, 28);
            this.MinimizeBtn.TabIndex = 16;
            this.MinimizeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MinimizeBtn.UseVisualStyleBackColor = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // gradient1
            // 
            this.gradient1.BackColor = System.Drawing.Color.CadetBlue;
            this.gradient1.ColorBottom = System.Drawing.SystemColors.ActiveCaptionText;
            this.gradient1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.gradient1.Controls.Add(this.pictureBox2);
            this.gradient1.Controls.Add(this.button2);
            this.gradient1.Controls.Add(this.button5);
            this.gradient1.Controls.Add(this.button7);
            this.gradient1.Controls.Add(this.Tracuubtn);
            this.gradient1.Controls.Add(this.Baocaothangbtn);
            this.gradient1.Controls.Add(this.Lapphieubtn);
            this.gradient1.Controls.Add(this.Tiepnhanbaotrixebtn);
            this.gradient1.Controls.Add(this.button13);
            this.gradient1.Controls.Add(this.Trangchubtn);
            this.gradient1.Location = new System.Drawing.Point(-1, 29);
            this.gradient1.Margin = new System.Windows.Forms.Padding(2);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(215, 925);
            this.gradient1.TabIndex = 23;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::GarageManager.Properties.Resources.car_maintenance_606ab2f8ab000;
            this.pictureBox2.Location = new System.Drawing.Point(2, 38);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(207, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Image = global::GarageManager.Properties.Resources.help_32px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(2, 469);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Trợ giúp";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button5.Location = new System.Drawing.Point(0, 155);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 42);
            this.button5.TabIndex = 29;
            this.button5.Text = "Chức năng";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Image = global::GarageManager.Properties.Resources.home_40px;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(2, 424);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(205, 41);
            this.button7.TabIndex = 22;
            this.button7.Text = "Chỉnh sửa quy định";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Tracuubtn
            // 
            this.Tracuubtn.BackColor = System.Drawing.Color.Transparent;
            this.Tracuubtn.FlatAppearance.BorderSize = 0;
            this.Tracuubtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tracuubtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tracuubtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Tracuubtn.Image = global::GarageManager.Properties.Resources.search_50px;
            this.Tracuubtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tracuubtn.Location = new System.Drawing.Point(3, 378);
            this.Tracuubtn.Margin = new System.Windows.Forms.Padding(2);
            this.Tracuubtn.Name = "Tracuubtn";
            this.Tracuubtn.Size = new System.Drawing.Size(192, 41);
            this.Tracuubtn.TabIndex = 23;
            this.Tracuubtn.Text = "Tra cứu";
            this.Tracuubtn.UseVisualStyleBackColor = false;
            this.Tracuubtn.Click += new System.EventHandler(this.Tracuubtn_Click);
            // 
            // Baocaothangbtn
            // 
            this.Baocaothangbtn.BackColor = System.Drawing.Color.Transparent;
            this.Baocaothangbtn.FlatAppearance.BorderSize = 0;
            this.Baocaothangbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Baocaothangbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Baocaothangbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Baocaothangbtn.Image = global::GarageManager.Properties.Resources.cash_40px;
            this.Baocaothangbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Baocaothangbtn.Location = new System.Drawing.Point(3, 339);
            this.Baocaothangbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Baocaothangbtn.Name = "Baocaothangbtn";
            this.Baocaothangbtn.Size = new System.Drawing.Size(228, 41);
            this.Baocaothangbtn.TabIndex = 24;
            this.Baocaothangbtn.Text = "Lập báo cáo ";
            this.Baocaothangbtn.UseVisualStyleBackColor = false;
            this.Baocaothangbtn.Click += new System.EventHandler(this.Baocaothangbtn_Click);
            // 
            // Lapphieubtn
            // 
            this.Lapphieubtn.BackColor = System.Drawing.Color.Transparent;
            this.Lapphieubtn.FlatAppearance.BorderSize = 0;
            this.Lapphieubtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lapphieubtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lapphieubtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lapphieubtn.Image = global::GarageManager.Properties.Resources.billboard_40px;
            this.Lapphieubtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lapphieubtn.Location = new System.Drawing.Point(3, 293);
            this.Lapphieubtn.Margin = new System.Windows.Forms.Padding(2);
            this.Lapphieubtn.Name = "Lapphieubtn";
            this.Lapphieubtn.Size = new System.Drawing.Size(207, 41);
            this.Lapphieubtn.TabIndex = 25;
            this.Lapphieubtn.Text = "Lập phiếu";
            this.Lapphieubtn.UseVisualStyleBackColor = false;
            this.Lapphieubtn.Click += new System.EventHandler(this.Lapphieubtn_Click);
            // 
            // Tiepnhanbaotrixebtn
            // 
            this.Tiepnhanbaotrixebtn.BackColor = System.Drawing.Color.Transparent;
            this.Tiepnhanbaotrixebtn.FlatAppearance.BorderSize = 0;
            this.Tiepnhanbaotrixebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tiepnhanbaotrixebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tiepnhanbaotrixebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Tiepnhanbaotrixebtn.Image = global::GarageManager.Properties.Resources.drill_40px;
            this.Tiepnhanbaotrixebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tiepnhanbaotrixebtn.Location = new System.Drawing.Point(1, 248);
            this.Tiepnhanbaotrixebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Tiepnhanbaotrixebtn.Name = "Tiepnhanbaotrixebtn";
            this.Tiepnhanbaotrixebtn.Size = new System.Drawing.Size(208, 41);
            this.Tiepnhanbaotrixebtn.TabIndex = 26;
            this.Tiepnhanbaotrixebtn.Text = "Tiếp nhận bảo trì xe";
            this.Tiepnhanbaotrixebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Tiepnhanbaotrixebtn.UseVisualStyleBackColor = false;
            this.Tiepnhanbaotrixebtn.Click += new System.EventHandler(this.Tiepnhanbaotrixebtn_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Transparent;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button13.Image = global::GarageManager.Properties.Resources.administrator_male_32px;
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(1, -1);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(158, 41);
            this.button13.TabIndex = 27;
            this.button13.Text = " ";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // Trangchubtn
            // 
            this.Trangchubtn.BackColor = System.Drawing.Color.Transparent;
            this.Trangchubtn.FlatAppearance.BorderSize = 0;
            this.Trangchubtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Trangchubtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trangchubtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Trangchubtn.Image = global::GarageManager.Properties.Resources.home_40px;
            this.Trangchubtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Trangchubtn.Location = new System.Drawing.Point(1, 202);
            this.Trangchubtn.Margin = new System.Windows.Forms.Padding(2);
            this.Trangchubtn.Name = "Trangchubtn";
            this.Trangchubtn.Size = new System.Drawing.Size(209, 41);
            this.Trangchubtn.TabIndex = 28;
            this.Trangchubtn.Text = "Trang chủ";
            this.Trangchubtn.UseVisualStyleBackColor = false;
            this.Trangchubtn.Click += new System.EventHandler(this.Trangchubtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Nhanviencbb);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Mktxt);
            this.panel1.Controls.Add(this.tktxt);
            this.panel1.Controls.Add(this.Addaccount);
            this.panel1.Location = new System.Drawing.Point(657, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 265);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cấp tài khoản nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nhập tài khoản";
            // 
            // Mktxt
            // 
            this.Mktxt.Location = new System.Drawing.Point(161, 105);
            this.Mktxt.Name = "Mktxt";
            this.Mktxt.Size = new System.Drawing.Size(178, 29);
            this.Mktxt.TabIndex = 6;
            // 
            // tktxt
            // 
            this.tktxt.Location = new System.Drawing.Point(161, 70);
            this.tktxt.Name = "tktxt";
            this.tktxt.Size = new System.Drawing.Size(178, 29);
            this.tktxt.TabIndex = 7;
            // 
            // Addaccount
            // 
            this.Addaccount.Location = new System.Drawing.Point(205, 222);
            this.Addaccount.Name = "Addaccount";
            this.Addaccount.Size = new System.Drawing.Size(89, 38);
            this.Addaccount.TabIndex = 5;
            this.Addaccount.Text = "Thêm";
            this.Addaccount.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.deletetktxt);
            this.panel2.Controls.Add(this.deletebnt);
            this.panel2.Location = new System.Drawing.Point(657, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 204);
            this.panel2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(129, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hủy tài khoản nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nhập tài khoản";
            // 
            // deletetktxt
            // 
            this.deletetktxt.Location = new System.Drawing.Point(163, 84);
            this.deletetktxt.Name = "deletetktxt";
            this.deletetktxt.Size = new System.Drawing.Size(178, 29);
            this.deletetktxt.TabIndex = 12;
            // 
            // deletebnt
            // 
            this.deletebnt.Location = new System.Drawing.Point(205, 129);
            this.deletebnt.Name = "deletebnt";
            this.deletebnt.Size = new System.Drawing.Size(89, 38);
            this.deletebnt.TabIndex = 11;
            this.deletebnt.Text = "Xóa";
            this.deletebnt.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(728, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 36);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quản lý tài khoản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(162, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 36);
            this.label7.TabIndex = 11;
            this.label7.Text = "Danh sách nhân viên";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 29);
            this.textBox1.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Họ và tên";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Stt";
            this.Column3.Name = "Column3";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Họ tên NV";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tên tài khoản";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Quyền hạn";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Giới tính";
            // 
            // Nhanviencbb
            // 
            this.Nhanviencbb.FormattingEnabled = true;
            this.Nhanviencbb.Location = new System.Drawing.Point(161, 172);
            this.Nhanviencbb.Name = "Nhanviencbb";
            this.Nhanviencbb.Size = new System.Drawing.Size(178, 32);
            this.Nhanviencbb.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.gradient2);
            this.Controls.Add(this.gradient1);
            this.Controls.Add(this.mainpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanvien)).EndInit();
            this.gradient2.ResumeLayout(false);
            this.gradient1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Control.gradient gradient1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Tracuubtn;
        private System.Windows.Forms.Button Baocaothangbtn;
        private System.Windows.Forms.Button Lapphieubtn;
        private System.Windows.Forms.Button Tiepnhanbaotrixebtn;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button Trangchubtn;
        private System.Windows.Forms.Panel mainpanel;
        private Control.gradient gradient2;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.DataGridView dataGridViewNhanvien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox deletetktxt;
        private System.Windows.Forms.Button deletebnt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Mktxt;
        private System.Windows.Forms.TextBox tktxt;
        private System.Windows.Forms.Button Addaccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Nhanviencbb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

