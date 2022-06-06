﻿namespace GarageManager
{
    partial class LoginForm
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gradient1 = new GarageManager.Control.gradient();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.dangnhapbtn = new GarageManager.Control.RJButton();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.taotaikhoanbtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.minbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GarageManager.Properties.Resources.istockphoto_1152779126_612x612;
            this.pictureBox2.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(523, 570);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // gradient1
            // 
            this.gradient1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(130)))));
            this.gradient1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.gradient1.Controls.Add(this.passwordtxt);
            this.gradient1.Controls.Add(this.dangnhapbtn);
            this.gradient1.Controls.Add(this.button2);
            this.gradient1.Controls.Add(this.pictureBox4);
            this.gradient1.Controls.Add(this.taotaikhoanbtn);
            this.gradient1.Controls.Add(this.CloseBtn);
            this.gradient1.Controls.Add(this.label2);
            this.gradient1.Controls.Add(this.pictureBox3);
            this.gradient1.Controls.Add(this.minbtn);
            this.gradient1.Controls.Add(this.label4);
            this.gradient1.Controls.Add(this.usertxt);
            this.gradient1.Controls.Add(this.label1);
            this.gradient1.Location = new System.Drawing.Point(515, -1);
            this.gradient1.Margin = new System.Windows.Forms.Padding(4);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(491, 570);
            this.gradient1.TabIndex = 33;
            this.gradient1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradient1_Paint);
            // 
            // passwordtxt
            // 
            this.passwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.Location = new System.Drawing.Point(96, 250);
            this.passwordtxt.Margin = new System.Windows.Forms.Padding(4);
            this.passwordtxt.Multiline = true;
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '*';
            this.passwordtxt.Size = new System.Drawing.Size(376, 42);
            this.passwordtxt.TabIndex = 22;
            this.passwordtxt.Text = "Mật khẩu";
            this.passwordtxt.UseSystemPasswordChar = true;
            this.passwordtxt.Enter += new System.EventHandler(this.passwordtxt_Enter);
            this.passwordtxt.Leave += new System.EventHandler(this.passwordtxt_Leave);
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
            this.dangnhapbtn.ForeColor = System.Drawing.Color.Black;
            this.dangnhapbtn.Location = new System.Drawing.Point(76, 330);
            this.dangnhapbtn.Margin = new System.Windows.Forms.Padding(4);
            this.dangnhapbtn.Name = "dangnhapbtn";
            this.dangnhapbtn.Size = new System.Drawing.Size(377, 49);
            this.dangnhapbtn.TabIndex = 33;
            this.dangnhapbtn.Text = "Đăng nhập";
            this.dangnhapbtn.TextColor = System.Drawing.Color.Black;
            this.dangnhapbtn.UseVisualStyleBackColor = false;
            this.dangnhapbtn.Click += new System.EventHandler(this.dangnhapbtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(280, 473);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 53);
            this.button2.TabIndex = 27;
            this.button2.Text = "Quên mật khẩu";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GarageManager.Properties.Resources.Password_Key_26px;
            this.pictureBox4.Location = new System.Drawing.Point(39, 250);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(43, 43);
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // taotaikhoanbtn
            // 
            this.taotaikhoanbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.taotaikhoanbtn.FlatAppearance.BorderSize = 0;
            this.taotaikhoanbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taotaikhoanbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taotaikhoanbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taotaikhoanbtn.Location = new System.Drawing.Point(64, 473);
            this.taotaikhoanbtn.Margin = new System.Windows.Forms.Padding(4);
            this.taotaikhoanbtn.Name = "taotaikhoanbtn";
            this.taotaikhoanbtn.Size = new System.Drawing.Size(157, 53);
            this.taotaikhoanbtn.TabIndex = 28;
            this.taotaikhoanbtn.Text = "Đăng kí";
            this.taotaikhoanbtn.UseVisualStyleBackColor = false;
            this.taotaikhoanbtn.Click += new System.EventHandler(this.taotaikhoanbtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Image = global::GarageManager.Properties.Resources.Close_30px;
            this.CloseBtn.Location = new System.Drawing.Point(453, 0);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(37, 32);
            this.CloseBtn.TabIndex = 30;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(220, 402);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Hoặc";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GarageManager.Properties.Resources.user_30px;
            this.pictureBox3.Location = new System.Drawing.Point(39, 174);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 43);
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // minbtn
            // 
            this.minbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.minbtn.FlatAppearance.BorderSize = 0;
            this.minbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minbtn.Image = global::GarageManager.Properties.Resources.subtract_30px;
            this.minbtn.Location = new System.Drawing.Point(416, 0);
            this.minbtn.Margin = new System.Windows.Forms.Padding(4);
            this.minbtn.Name = "minbtn";
            this.minbtn.Size = new System.Drawing.Size(37, 32);
            this.minbtn.TabIndex = 29;
            this.minbtn.UseVisualStyleBackColor = false;
            this.minbtn.Click += new System.EventHandler(this.minbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(159, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 52);
            this.label4.TabIndex = 26;
            this.label4.Text = "Quản lý";
            // 
            // usertxt
            // 
            this.usertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxt.Location = new System.Drawing.Point(96, 174);
            this.usertxt.Margin = new System.Windows.Forms.Padding(4);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(376, 41);
            this.usertxt.TabIndex = 23;
            this.usertxt.Text = "Tên đăng nhập";
            this.usertxt.Enter += new System.EventHandler(this.usertxt_Enter);
            this.usertxt.Leave += new System.EventHandler(this.usertxt_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(96, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 52);
            this.label1.TabIndex = 25;
            this.label1.Text = "Gargage ô tô";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1001, 565);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDăngNhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.Button minbtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button taotaikhoanbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Control.gradient gradient1;
        private Control.RJButton dangnhapbtn;
    }
}