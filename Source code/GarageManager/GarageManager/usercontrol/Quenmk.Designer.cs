namespace GarageManager.usercontrol
{
    partial class Quenmk
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
            this.gradient1 = new GarageManager.Control.gradient();
            this.dangnhapbtn = new GarageManager.Control.RJButton();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.minbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.ColorBottom = System.Drawing.Color.Empty;
            this.gradient1.ColorTop = System.Drawing.Color.Empty;
            this.gradient1.Controls.Add(this.dangnhapbtn);
            this.gradient1.Controls.Add(this.CloseBtn);
            this.gradient1.Controls.Add(this.pictureBox3);
            this.gradient1.Controls.Add(this.minbtn);
            this.gradient1.Controls.Add(this.label4);
            this.gradient1.Controls.Add(this.usertxt);
            this.gradient1.Location = new System.Drawing.Point(0, 1);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(420, 425);
            this.gradient1.TabIndex = 34;
            this.gradient1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradient1_Paint);         
            // 
            // dangnhapbtn
            // 
            this.dangnhapbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.dangnhapbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.dangnhapbtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dangnhapbtn.BorderRadius = 20;
            this.dangnhapbtn.BorderSize = 0;
            this.dangnhapbtn.FlatAppearance.BorderSize = 0;
            this.dangnhapbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dangnhapbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhapbtn.ForeColor = System.Drawing.Color.White;
            this.dangnhapbtn.Location = new System.Drawing.Point(64, 215);
            this.dangnhapbtn.Name = "dangnhapbtn";
            this.dangnhapbtn.Size = new System.Drawing.Size(283, 40);
            this.dangnhapbtn.TabIndex = 33;
            this.dangnhapbtn.Text = "Kiểm tra";
            this.dangnhapbtn.TextColor = System.Drawing.Color.White;
            this.dangnhapbtn.UseVisualStyleBackColor = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Image = global::GarageManager.Properties.Resources.Close_30px;
            this.CloseBtn.Location = new System.Drawing.Point(381, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(28, 26);
            this.CloseBtn.TabIndex = 30;
            this.CloseBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GarageManager.Properties.Resources.user_30px;
            this.pictureBox3.Location = new System.Drawing.Point(7, 129);
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
            this.minbtn.Location = new System.Drawing.Point(353, 0);
            this.minbtn.Name = "minbtn";
            this.minbtn.Size = new System.Drawing.Size(28, 26);
            this.minbtn.TabIndex = 29;
            this.minbtn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(24, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 55);
            this.label4.TabIndex = 26;
            this.label4.Text = "Quên mật khẩu";
            // 
            // usertxt
            // 
            this.usertxt.BackColor = System.Drawing.SystemColors.Control;
            this.usertxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.usertxt.Location = new System.Drawing.Point(68, 129);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(283, 28);
            this.usertxt.TabIndex = 23;
            this.usertxt.Text = "Tên đăng nhập";
            this.usertxt.TextChanged += new System.EventHandler(this.usertxt_TextChanged);
            // 
            // Quenmk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gradient1);
            this.Name = "Quenmk";
            this.Size = new System.Drawing.Size(420, 425);
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Control.gradient gradient1;
        private Control.RJButton dangnhapbtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button minbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usertxt;
    }
}
