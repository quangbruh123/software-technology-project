﻿namespace GarageManager.usercontrol
{
    partial class LAPPHIEU
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
            this.button2 = new System.Windows.Forms.Button();
            this.Lapphieusuachuabtn = new System.Windows.Forms.Button();
            this.lblCapNhatQuyDinh = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(166)))), ((int)(((byte)(235)))));
            this.panel1.Location = new System.Drawing.Point(1, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 3);
            this.panel1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(204)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Image = global::GarageManager.Properties.Resources.construction_40px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(462, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 93);
            this.button2.TabIndex = 7;
            this.button2.Text = "Lập phiếu thu tiền";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lapphieusuachuabtn
            // 
            this.Lapphieusuachuabtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(82)))));
            this.Lapphieusuachuabtn.FlatAppearance.BorderSize = 0;
            this.Lapphieusuachuabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lapphieusuachuabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lapphieusuachuabtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lapphieusuachuabtn.Image = global::GarageManager.Properties.Resources.wrench_40px;
            this.Lapphieusuachuabtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lapphieusuachuabtn.Location = new System.Drawing.Point(94, 56);
            this.Lapphieusuachuabtn.Name = "Lapphieusuachuabtn";
            this.Lapphieusuachuabtn.Size = new System.Drawing.Size(267, 93);
            this.Lapphieusuachuabtn.TabIndex = 8;
            this.Lapphieusuachuabtn.Text = "Lập phiếu sữa chữa";
            this.Lapphieusuachuabtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lapphieusuachuabtn.UseVisualStyleBackColor = false;
            this.Lapphieusuachuabtn.Click += new System.EventHandler(this.Lapphieusuachuabtn_Click);
            // 
            // lblCapNhatQuyDinh
            // 
            this.lblCapNhatQuyDinh.BackColor = System.Drawing.Color.Transparent;
            this.lblCapNhatQuyDinh.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCapNhatQuyDinh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCapNhatQuyDinh.Location = new System.Drawing.Point(3, 12);
            this.lblCapNhatQuyDinh.Name = "lblCapNhatQuyDinh";
            this.lblCapNhatQuyDinh.Size = new System.Drawing.Size(218, 27);
            this.lblCapNhatQuyDinh.TabIndex = 23;
            this.lblCapNhatQuyDinh.Text = "LẬP CÁC LOẠI PHIẾU";
            // 
            // LAPPHIEU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lblCapNhatQuyDinh);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Lapphieusuachuabtn);
            this.Controls.Add(this.panel1);
            this.Name = "LAPPHIEU";
            this.Size = new System.Drawing.Size(1175, 876);
            this.Load += new System.EventHandler(this.LAPPHIEU_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Lapphieusuachuabtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCapNhatQuyDinh;
    }
}
