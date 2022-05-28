namespace GarageManager.usercontrol
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Lapphieusuachuabtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lập các loại phiếu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(166)))), ((int)(((byte)(235)))));
            this.panel1.Location = new System.Drawing.Point(1, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 3);
            this.panel1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Image = global::GarageManager.Properties.Resources.cash_40px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(830, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(268, 93);
            this.button3.TabIndex = 6;
            this.button3.Text = "Lập báo cáo tháng";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
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
            // LAPPHIEU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Lapphieusuachuabtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "LAPPHIEU";
            this.Size = new System.Drawing.Size(1175, 512);
            this.Load += new System.EventHandler(this.LAPPHIEU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Lapphieusuachuabtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}
