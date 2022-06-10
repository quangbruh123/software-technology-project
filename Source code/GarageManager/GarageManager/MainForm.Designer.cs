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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.delAccountBtn = new GarageManager.Control.RJButton();
            this.addAccountBtn = new GarageManager.Control.RJButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewNhanvien = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addAccountPnl = new System.Windows.Forms.Panel();
            this.cancelBtn = new GarageManager.Control.RJButton();
            this.confirmBtn = new GarageManager.Control.RJButton();
            this.adminCbx = new System.Windows.Forms.CheckBox();
            this.genderTbx = new System.Windows.Forms.TextBox();
            this.genderLb = new System.Windows.Forms.Label();
            this.emailTbx = new System.Windows.Forms.TextBox();
            this.passLb = new System.Windows.Forms.Label();
            this.nameTbx = new System.Windows.Forms.TextBox();
            this.passTbx = new System.Windows.Forms.TextBox();
            this.nameLb = new System.Windows.Forms.Label();
            this.emailLb = new System.Windows.Forms.Label();
            this.accTbx = new System.Windows.Forms.TextBox();
            this.accLb = new System.Windows.Forms.Label();
            this.gradient2 = new GarageManager.Control.gradient();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.gradient1 = new GarageManager.Control.gradient();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Tracuubtn = new System.Windows.Forms.Button();
            this.Baocaothangbtn = new System.Windows.Forms.Button();
            this.Lapphieubtn = new System.Windows.Forms.Button();
            this.Tiepnhanbaotrixebtn = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.Trangchubtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanvien)).BeginInit();
            this.addAccountPnl.SuspendLayout();
            this.gradient2.SuspendLayout();
            this.gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainpanel.Controls.Add(this.panel2);
            this.mainpanel.Controls.Add(this.delAccountBtn);
            this.mainpanel.Controls.Add(this.addAccountBtn);
            this.mainpanel.Controls.Add(this.label7);
            this.mainpanel.Controls.Add(this.panel1);
            this.mainpanel.Controls.Add(this.addAccountPnl);
            this.mainpanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainpanel.Location = new System.Drawing.Point(214, 31);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1087, 721);
            this.mainpanel.TabIndex = 6;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint);
            // 
            // delAccountBtn
            // 
            this.delAccountBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.delAccountBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.delAccountBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.delAccountBtn.BorderRadius = 20;
            this.delAccountBtn.BorderSize = 0;
            this.delAccountBtn.FlatAppearance.BorderSize = 0;
            this.delAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delAccountBtn.ForeColor = System.Drawing.Color.White;
            this.delAccountBtn.Location = new System.Drawing.Point(561, 398);
            this.delAccountBtn.Name = "delAccountBtn";
            this.delAccountBtn.Size = new System.Drawing.Size(204, 40);
            this.delAccountBtn.TabIndex = 14;
            this.delAccountBtn.Text = "Xóa tài khoản";
            this.delAccountBtn.TextColor = System.Drawing.Color.White;
            this.delAccountBtn.UseVisualStyleBackColor = false;
            this.delAccountBtn.Click += new System.EventHandler(this.delAccountBtn_Click);
            // 
            // addAccountBtn
            // 
            this.addAccountBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.addAccountBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.addAccountBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addAccountBtn.BorderRadius = 20;
            this.addAccountBtn.BorderSize = 0;
            this.addAccountBtn.FlatAppearance.BorderSize = 0;
            this.addAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAccountBtn.ForeColor = System.Drawing.Color.White;
            this.addAccountBtn.Location = new System.Drawing.Point(195, 398);
            this.addAccountBtn.Name = "addAccountBtn";
            this.addAccountBtn.Size = new System.Drawing.Size(204, 40);
            this.addAccountBtn.TabIndex = 13;
            this.addAccountBtn.Text = "Thêm tài khoản mới";
            this.addAccountBtn.TextColor = System.Drawing.Color.White;
            this.addAccountBtn.UseVisualStyleBackColor = false;
            this.addAccountBtn.Click += new System.EventHandler(this.addAccountBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.dataGridViewNhanvien);
            this.panel1.Location = new System.Drawing.Point(21, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 288);
            this.panel1.TabIndex = 12;
            // 
            // dataGridViewNhanvien
            // 
            this.dataGridViewNhanvien.AllowUserToResizeRows = false;
            this.dataGridViewNhanvien.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewNhanvien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNhanvien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNhanvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column4,
            this.Column5,
            this.Column2});
            this.dataGridViewNhanvien.EnableHeadersVisualStyles = false;
            this.dataGridViewNhanvien.Location = new System.Drawing.Point(0, 3);
            this.dataGridViewNhanvien.Name = "dataGridViewNhanvien";
            this.dataGridViewNhanvien.RowHeadersWidth = 51;
            this.dataGridViewNhanvien.Size = new System.Drawing.Size(958, 257);
            this.dataGridViewNhanvien.TabIndex = 1;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 42.78075F;
            this.Column3.HeaderText = "Stt";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Họ tên NV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Tên tài khoản";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Email";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Quyền hạn";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // addAccountPnl
            // 
            this.addAccountPnl.Controls.Add(this.cancelBtn);
            this.addAccountPnl.Controls.Add(this.confirmBtn);
            this.addAccountPnl.Controls.Add(this.adminCbx);
            this.addAccountPnl.Controls.Add(this.genderTbx);
            this.addAccountPnl.Controls.Add(this.genderLb);
            this.addAccountPnl.Controls.Add(this.emailTbx);
            this.addAccountPnl.Controls.Add(this.passLb);
            this.addAccountPnl.Controls.Add(this.nameTbx);
            this.addAccountPnl.Controls.Add(this.passTbx);
            this.addAccountPnl.Controls.Add(this.nameLb);
            this.addAccountPnl.Controls.Add(this.emailLb);
            this.addAccountPnl.Controls.Add(this.accTbx);
            this.addAccountPnl.Controls.Add(this.accLb);
            this.addAccountPnl.Location = new System.Drawing.Point(21, 376);
            this.addAccountPnl.Name = "addAccountPnl";
            this.addAccountPnl.Size = new System.Drawing.Size(958, 261);
            this.addAccountPnl.TabIndex = 23;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cancelBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.cancelBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cancelBtn.BorderRadius = 20;
            this.cancelBtn.BorderSize = 0;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(540, 207);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(204, 40);
            this.cancelBtn.TabIndex = 28;
            this.cancelBtn.Text = "Hủy bỏ";
            this.cancelBtn.TextColor = System.Drawing.Color.White;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.confirmBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.confirmBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.confirmBtn.BorderRadius = 20;
            this.confirmBtn.BorderSize = 0;
            this.confirmBtn.FlatAppearance.BorderSize = 0;
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBtn.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.Location = new System.Drawing.Point(174, 207);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(204, 40);
            this.confirmBtn.TabIndex = 27;
            this.confirmBtn.Text = "Thêm tài khoản";
            this.confirmBtn.TextColor = System.Drawing.Color.White;
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // adminCbx
            // 
            this.adminCbx.AutoSize = true;
            this.adminCbx.Location = new System.Drawing.Point(548, 154);
            this.adminCbx.Name = "adminCbx";
            this.adminCbx.Size = new System.Drawing.Size(135, 28);
            this.adminCbx.TabIndex = 26;
            this.adminCbx.Text = "Quản trị viên";
            this.adminCbx.UseVisualStyleBackColor = true;
            // 
            // genderTbx
            // 
            this.genderTbx.Location = new System.Drawing.Point(151, 151);
            this.genderTbx.Name = "genderTbx";
            this.genderTbx.Size = new System.Drawing.Size(285, 29);
            this.genderTbx.TabIndex = 23;
            // 
            // genderLb
            // 
            this.genderLb.AutoSize = true;
            this.genderLb.Location = new System.Drawing.Point(16, 154);
            this.genderLb.Name = "genderLb";
            this.genderLb.Size = new System.Drawing.Size(83, 24);
            this.genderLb.TabIndex = 24;
            this.genderLb.Text = "Giới tính:";
            // 
            // emailTbx
            // 
            this.emailTbx.Location = new System.Drawing.Point(641, 27);
            this.emailTbx.Name = "emailTbx";
            this.emailTbx.Size = new System.Drawing.Size(285, 29);
            this.emailTbx.TabIndex = 19;
            // 
            // passLb
            // 
            this.passLb.AutoSize = true;
            this.passLb.Location = new System.Drawing.Point(544, 92);
            this.passLb.Name = "passLb";
            this.passLb.Size = new System.Drawing.Size(91, 24);
            this.passLb.TabIndex = 22;
            this.passLb.Text = "Mật khẩu:";
            // 
            // nameTbx
            // 
            this.nameTbx.Location = new System.Drawing.Point(151, 27);
            this.nameTbx.Name = "nameTbx";
            this.nameTbx.Size = new System.Drawing.Size(285, 29);
            this.nameTbx.TabIndex = 15;
            // 
            // passTbx
            // 
            this.passTbx.Location = new System.Drawing.Point(641, 91);
            this.passTbx.Name = "passTbx";
            this.passTbx.Size = new System.Drawing.Size(285, 29);
            this.passTbx.TabIndex = 21;
            this.passTbx.UseSystemPasswordChar = true;
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Location = new System.Drawing.Point(16, 30);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(79, 24);
            this.nameLb.TabIndex = 16;
            this.nameLb.Text = "Họ Tên:";
            // 
            // emailLb
            // 
            this.emailLb.AutoSize = true;
            this.emailLb.Location = new System.Drawing.Point(544, 30);
            this.emailLb.Name = "emailLb";
            this.emailLb.Size = new System.Drawing.Size(62, 24);
            this.emailLb.TabIndex = 20;
            this.emailLb.Text = "Email:";
            // 
            // accTbx
            // 
            this.accTbx.Location = new System.Drawing.Point(151, 89);
            this.accTbx.Name = "accTbx";
            this.accTbx.Size = new System.Drawing.Size(285, 29);
            this.accTbx.TabIndex = 17;
            // 
            // accLb
            // 
            this.accLb.AutoSize = true;
            this.accLb.Location = new System.Drawing.Point(16, 92);
            this.accLb.Name = "accLb";
            this.accLb.Size = new System.Drawing.Size(129, 24);
            this.accLb.TabIndex = 18;
            this.accLb.Text = "Tên tài khoản:";
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
            this.gradient1.Controls.Add(this.logoutBtn);
            this.gradient1.Controls.Add(this.pictureBox2);
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
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logoutBtn.Image = global::GarageManager.Properties.Resources.Logout_30px;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(5, 619);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(205, 41);
            this.logoutBtn.TabIndex = 31;
            this.logoutBtn.Text = "Đăng xuất";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
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
            this.button7.Location = new System.Drawing.Point(2, 436);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(205, 46);
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
            this.Tracuubtn.Location = new System.Drawing.Point(2, 384);
            this.Tracuubtn.Margin = new System.Windows.Forms.Padding(2);
            this.Tracuubtn.Name = "Tracuubtn";
            this.Tracuubtn.Size = new System.Drawing.Size(205, 48);
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
            this.Baocaothangbtn.Size = new System.Drawing.Size(204, 41);
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
            this.Lapphieubtn.Size = new System.Drawing.Size(204, 41);
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
            this.Tiepnhanbaotrixebtn.Location = new System.Drawing.Point(5, 248);
            this.Tiepnhanbaotrixebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Tiepnhanbaotrixebtn.Name = "Tiepnhanbaotrixebtn";
            this.Tiepnhanbaotrixebtn.Size = new System.Drawing.Size(202, 41);
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
            this.Trangchubtn.Location = new System.Drawing.Point(0, 202);
            this.Trangchubtn.Margin = new System.Windows.Forms.Padding(2);
            this.Trangchubtn.Name = "Trangchubtn";
            this.Trangchubtn.Size = new System.Drawing.Size(207, 41);
            this.Trangchubtn.TabIndex = 28;
            this.Trangchubtn.Text = "Trang chủ";
            this.Trangchubtn.UseVisualStyleBackColor = false;
            this.Trangchubtn.Click += new System.EventHandler(this.Trangchubtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(166)))), ((int)(((byte)(235)))));
            this.panel2.Location = new System.Drawing.Point(1, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1172, 3);
            this.panel2.TabIndex = 24;
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
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanvien)).EndInit();
            this.addAccountPnl.ResumeLayout(false);
            this.addAccountPnl.PerformLayout();
            this.gradient2.ResumeLayout(false);
            this.gradient1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Control.gradient gradient1;
        private System.Windows.Forms.PictureBox pictureBox2;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Control.RJButton delAccountBtn;
        private Control.RJButton addAccountBtn;
        private System.Windows.Forms.Panel addAccountPnl;
        private System.Windows.Forms.TextBox emailTbx;
        private System.Windows.Forms.Label passLb;
        private System.Windows.Forms.TextBox nameTbx;
        private System.Windows.Forms.TextBox passTbx;
        private System.Windows.Forms.Label nameLb;
        private System.Windows.Forms.Label emailLb;
        private System.Windows.Forms.TextBox accTbx;
        private System.Windows.Forms.Label accLb;
        private System.Windows.Forms.TextBox genderTbx;
        private System.Windows.Forms.Label genderLb;
        private Control.RJButton cancelBtn;
        private Control.RJButton confirmBtn;
        private System.Windows.Forms.CheckBox adminCbx;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Panel panel2;
    }
}

