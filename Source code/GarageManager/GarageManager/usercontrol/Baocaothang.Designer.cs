namespace GarageManager.usercontrol
{
    partial class Baocaothang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.baocaotonbtn = new System.Windows.Forms.Button();
            this.baocaodoanhsobtn = new System.Windows.Forms.Button();
            this.lblCapNhatQuyDinh = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(166)))), ((int)(((byte)(235)))));
            this.panel1.Location = new System.Drawing.Point(3, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1563, 4);
            this.panel1.TabIndex = 11;
            // 
            // baocaotonbtn
            // 
            this.baocaotonbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.baocaotonbtn.FlatAppearance.BorderSize = 0;
            this.baocaotonbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baocaotonbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baocaotonbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.baocaotonbtn.Image = global::GarageManager.Properties.Resources.construction_40px;
            this.baocaotonbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.baocaotonbtn.Location = new System.Drawing.Point(388, 76);
            this.baocaotonbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.baocaotonbtn.Name = "baocaotonbtn";
            this.baocaotonbtn.Size = new System.Drawing.Size(349, 114);
            this.baocaotonbtn.TabIndex = 9;
            this.baocaotonbtn.Text = "Báo cáo tồn";
            this.baocaotonbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.baocaotonbtn.UseVisualStyleBackColor = false;
            this.baocaotonbtn.Click += new System.EventHandler(this.baocaotonbtn_Click);
            // 
            // baocaodoanhsobtn
            // 
            this.baocaodoanhsobtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.baocaodoanhsobtn.FlatAppearance.BorderSize = 0;
            this.baocaodoanhsobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baocaodoanhsobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baocaodoanhsobtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.baocaodoanhsobtn.Image = global::GarageManager.Properties.Resources.wrench_40px;
            this.baocaodoanhsobtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.baocaodoanhsobtn.Location = new System.Drawing.Point(9, 76);
            this.baocaodoanhsobtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.baocaodoanhsobtn.Name = "baocaodoanhsobtn";
            this.baocaodoanhsobtn.Size = new System.Drawing.Size(356, 114);
            this.baocaodoanhsobtn.TabIndex = 10;
            this.baocaodoanhsobtn.Text = "Báo cáo doanh số";
            this.baocaodoanhsobtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.baocaodoanhsobtn.UseVisualStyleBackColor = false;
            this.baocaodoanhsobtn.Click += new System.EventHandler(this.baocaodoanhsobtn_Click);
            // 
            // lblCapNhatQuyDinh
            // 
            this.lblCapNhatQuyDinh.BackColor = System.Drawing.Color.Transparent;
            this.lblCapNhatQuyDinh.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCapNhatQuyDinh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCapNhatQuyDinh.Location = new System.Drawing.Point(4, 15);
            this.lblCapNhatQuyDinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapNhatQuyDinh.Name = "lblCapNhatQuyDinh";
            this.lblCapNhatQuyDinh.Size = new System.Drawing.Size(291, 33);
            this.lblCapNhatQuyDinh.TabIndex = 23;
            this.lblCapNhatQuyDinh.Text = "LẬP CÁC LOẠI PHIẾU";
            // 
            // Baocaothang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lblCapNhatQuyDinh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.baocaotonbtn);
            this.Controls.Add(this.baocaodoanhsobtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Baocaothang";
            this.Size = new System.Drawing.Size(1567, 1078);
            this.Load += new System.EventHandler(this.Baocaothang_Load);
            this.VisibleChanged += new System.EventHandler(this.Baocaothang_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button baocaotonbtn;
        private System.Windows.Forms.Button baocaodoanhsobtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCapNhatQuyDinh;
    }
}
