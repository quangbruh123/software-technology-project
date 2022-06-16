namespace GarageManager
{
    partial class ForgetPassword
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
            this.gradient1 = new GarageManager.Control.gradient();
            this.rjButton1 = new GarageManager.Control.RJButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.codetxt = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gmailtxt = new System.Windows.Forms.TextBox();
            this.dangnhapbtn = new GarageManager.Control.RJButton();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.minbtn = new System.Windows.Forms.Button();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.ColorBottom = System.Drawing.Color.Empty;
            this.gradient1.ColorTop = System.Drawing.Color.Empty;
            this.gradient1.Controls.Add(this.rjButton1);
            this.gradient1.Controls.Add(this.panel4);
            this.gradient1.Controls.Add(this.codetxt);
            this.gradient1.Controls.Add(this.pictureBox2);
            this.gradient1.Controls.Add(this.panel2);
            this.gradient1.Controls.Add(this.panel1);
            this.gradient1.Controls.Add(this.gmailtxt);
            this.gradient1.Controls.Add(this.dangnhapbtn);
            this.gradient1.Controls.Add(this.button2);
            this.gradient1.Controls.Add(this.label3);
            this.gradient1.Controls.Add(this.pictureBox4);
            this.gradient1.Controls.Add(this.CloseBtn);
            this.gradient1.Controls.Add(this.pictureBox3);
            this.gradient1.Controls.Add(this.minbtn);
            this.gradient1.Controls.Add(this.usertxt);
            this.gradient1.Location = new System.Drawing.Point(4, 2);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(368, 375);
            this.gradient1.TabIndex = 35;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(129, 177);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(149, 40);
            this.rjButton1.TabIndex = 3;
            this.rjButton1.Text = "Gửi mã xác nhận";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.panel4.Location = new System.Drawing.Point(63, 254);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(283, 3);
            this.panel4.TabIndex = 42;
            // 
            // codetxt
            // 
            this.codetxt.BackColor = System.Drawing.SystemColors.Control;
            this.codetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codetxt.Location = new System.Drawing.Point(63, 221);
            this.codetxt.Multiline = true;
            this.codetxt.Name = "codetxt";
            this.codetxt.PasswordChar = '*';
            this.codetxt.Size = new System.Drawing.Size(286, 35);
            this.codetxt.TabIndex = 4;
            this.codetxt.Text = "Mã xác nhận";
            this.codetxt.UseSystemPasswordChar = true;
            this.codetxt.Enter += new System.EventHandler(this.codetxt_Enter);
            this.codetxt.Leave += new System.EventHandler(this.codetxt_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GarageManager.Properties.Resources.lock_24px;
            this.pictureBox2.Location = new System.Drawing.Point(12, 221);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.panel2.Location = new System.Drawing.Point(63, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 3);
            this.panel2.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.panel1.Location = new System.Drawing.Point(62, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 3);
            this.panel1.TabIndex = 36;
            // 
            // gmailtxt
            // 
            this.gmailtxt.BackColor = System.Drawing.SystemColors.Control;
            this.gmailtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gmailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmailtxt.Location = new System.Drawing.Point(63, 135);
            this.gmailtxt.Multiline = true;
            this.gmailtxt.Name = "gmailtxt";
            this.gmailtxt.PasswordChar = '*';
            this.gmailtxt.Size = new System.Drawing.Size(286, 35);
            this.gmailtxt.TabIndex = 2;
            this.gmailtxt.Text = "Gmail";
            this.gmailtxt.UseSystemPasswordChar = true;
            this.gmailtxt.Enter += new System.EventHandler(this.gmailtxt_Enter);
            this.gmailtxt.Leave += new System.EventHandler(this.gmailtxt_Leave);
            // 
            // dangnhapbtn
            // 
            this.dangnhapbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dangnhapbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dangnhapbtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dangnhapbtn.BorderRadius = 20;
            this.dangnhapbtn.BorderSize = 0;
            this.dangnhapbtn.FlatAppearance.BorderSize = 0;
            this.dangnhapbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dangnhapbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhapbtn.ForeColor = System.Drawing.Color.White;
            this.dangnhapbtn.Location = new System.Drawing.Point(49, 277);
            this.dangnhapbtn.Name = "dangnhapbtn";
            this.dangnhapbtn.Size = new System.Drawing.Size(283, 40);
            this.dangnhapbtn.TabIndex = 5;
            this.dangnhapbtn.Text = "Xác nhận";
            this.dangnhapbtn.TextColor = System.Drawing.Color.White;
            this.dangnhapbtn.UseVisualStyleBackColor = false;
            this.dangnhapbtn.Click += new System.EventHandler(this.dangnhapbtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(129, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Quay lại";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(56, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 40);
            this.label3.TabIndex = 26;
            this.label3.Text = "Quên mật khẩu";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GarageManager.Properties.Resources.gmail_40px;
            this.pictureBox4.Location = new System.Drawing.Point(12, 135);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Image = global::GarageManager.Properties.Resources.Close_30px;
            this.CloseBtn.Location = new System.Drawing.Point(334, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(28, 26);
            this.CloseBtn.TabIndex = 30;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GarageManager.Properties.Resources.user_30px;
            this.pictureBox3.Location = new System.Drawing.Point(11, 91);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // minbtn
            // 
            this.minbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.minbtn.FlatAppearance.BorderSize = 0;
            this.minbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minbtn.Image = global::GarageManager.Properties.Resources.subtract_30px;
            this.minbtn.Location = new System.Drawing.Point(305, 0);
            this.minbtn.Name = "minbtn";
            this.minbtn.Size = new System.Drawing.Size(28, 26);
            this.minbtn.TabIndex = 29;
            this.minbtn.UseVisualStyleBackColor = false;
            this.minbtn.Click += new System.EventHandler(this.minbtn_Click);
            // 
            // usertxt
            // 
            this.usertxt.BackColor = System.Drawing.SystemColors.Control;
            this.usertxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxt.Location = new System.Drawing.Point(62, 91);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(283, 28);
            this.usertxt.TabIndex = 1;
            this.usertxt.Text = "Tên đăng nhập";
            this.usertxt.Enter += new System.EventHandler(this.usertxt_Enter);
            this.usertxt.Leave += new System.EventHandler(this.usertxt_Leave);
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 379);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPassword";
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Control.gradient gradient1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox gmailtxt;
        private Control.RJButton dangnhapbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button minbtn;
        private System.Windows.Forms.TextBox usertxt;
        private Control.RJButton rjButton1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox codetxt;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}