namespace GarageManager
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
            this.circularButton11 = new GarageManager.Classes.CircularButton1();
            this.gradient1 = new GarageManager.Control.gradient();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.dangnhapbtn = new GarageManager.Control.RJButton();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.minbtn = new System.Windows.Forms.Button();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // circularButton11
            // 
            this.circularButton11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.circularButton11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.circularButton11.Location = new System.Drawing.Point(-51, -129);
            this.circularButton11.Name = "circularButton11";
            this.circularButton11.Size = new System.Drawing.Size(238, 642);
            this.circularButton11.TabIndex = 34;
            this.circularButton11.Text = "              Garage \r\n             Manager";
            this.circularButton11.UseVisualStyleBackColor = false;
            // 
            // gradient1
            // 
            this.gradient1.ColorBottom = System.Drawing.Color.Empty;
            this.gradient1.ColorTop = System.Drawing.Color.Empty;
            this.gradient1.Controls.Add(this.panel2);
            this.gradient1.Controls.Add(this.panel1);
            this.gradient1.Controls.Add(this.passwordtxt);
            this.gradient1.Controls.Add(this.dangnhapbtn);
            this.gradient1.Controls.Add(this.button2);
            this.gradient1.Controls.Add(this.label3);
            this.gradient1.Controls.Add(this.pictureBox4);
            this.gradient1.Controls.Add(this.CloseBtn);
            this.gradient1.Controls.Add(this.pictureBox3);
            this.gradient1.Controls.Add(this.minbtn);
            this.gradient1.Controls.Add(this.usertxt);
            this.gradient1.Location = new System.Drawing.Point(193, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(352, 463);
            this.gradient1.TabIndex = 33;
            this.gradient1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradient1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.panel2.Location = new System.Drawing.Point(63, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 3);
            this.panel2.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.panel1.Location = new System.Drawing.Point(62, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 3);
            this.panel1.TabIndex = 36;
            // 
            // passwordtxt
            // 
            this.passwordtxt.BackColor = System.Drawing.SystemColors.Control;
            this.passwordtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.Location = new System.Drawing.Point(63, 197);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(286, 28);
            this.passwordtxt.TabIndex = 3;
            this.passwordtxt.Text = "Mật khẩu";
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
            this.dangnhapbtn.ForeColor = System.Drawing.Color.White;
            this.dangnhapbtn.Location = new System.Drawing.Point(52, 238);
            this.dangnhapbtn.Name = "dangnhapbtn";
            this.dangnhapbtn.Size = new System.Drawing.Size(283, 40);
            this.dangnhapbtn.TabIndex = 4;
            this.dangnhapbtn.Text = "Đăng nhập";
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
            this.button2.Location = new System.Drawing.Point(122, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = "Quên mật khẩu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(99, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 40);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đăng nhập";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GarageManager.Properties.Resources.Password_Key_26px;
            this.pictureBox4.Location = new System.Drawing.Point(12, 197);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 35);
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Image = global::GarageManager.Properties.Resources.Close_30px;
            this.CloseBtn.Location = new System.Drawing.Point(320, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(28, 26);
            this.CloseBtn.TabIndex = 6;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GarageManager.Properties.Resources.user_30px;
            this.pictureBox3.Location = new System.Drawing.Point(12, 148);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 35);
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // minbtn
            // 
            this.minbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.minbtn.FlatAppearance.BorderSize = 0;
            this.minbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minbtn.Image = global::GarageManager.Properties.Resources.subtract_30px;
            this.minbtn.Location = new System.Drawing.Point(292, 0);
            this.minbtn.Name = "minbtn";
            this.minbtn.Size = new System.Drawing.Size(28, 26);
            this.minbtn.TabIndex = 5;
            this.minbtn.UseVisualStyleBackColor = false;
            this.minbtn.Click += new System.EventHandler(this.minbtn_Click);
            // 
            // usertxt
            // 
            this.usertxt.BackColor = System.Drawing.SystemColors.Control;
            this.usertxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxt.Location = new System.Drawing.Point(62, 148);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(283, 28);
            this.usertxt.TabIndex = 2;
            this.usertxt.Text = "Tên đăng nhập";
            this.usertxt.Enter += new System.EventHandler(this.usertxt_Enter);
            this.usertxt.Leave += new System.EventHandler(this.usertxt_Leave);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.dangnhapbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(540, 379);
            this.Controls.Add(this.circularButton11);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garage Manager";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.Button minbtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button button2;
        private Control.gradient gradient1;
        private Control.RJButton dangnhapbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Panel panel2;
        private Classes.CircularButton1 circularButton11;
    }
}