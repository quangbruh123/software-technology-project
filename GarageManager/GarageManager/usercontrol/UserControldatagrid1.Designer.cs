namespace GarageManager.usercontrol
{
    partial class UserControldatagrid1
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxTongTienPhieuSuaChua = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnInPhieuSuaChua = new System.Windows.Forms.Button();
            this.btnLuuPSC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(446, 54);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(360, 338);
            this.dataGridView2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(542, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hủy phiếu sửa chữa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phiếu sửa chữa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(13, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(406, 338);
            this.dataGridView1.TabIndex = 43;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Stt";
            this.Column1.MaxInputLength = 30000;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Vật tư phụ tùng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tiền công";
            this.Column4.Name = "Column4";
            // 
            // textBoxTongTienPhieuSuaChua
            // 
            this.textBoxTongTienPhieuSuaChua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTongTienPhieuSuaChua.Location = new System.Drawing.Point(250, 397);
            this.textBoxTongTienPhieuSuaChua.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTongTienPhieuSuaChua.Name = "textBoxTongTienPhieuSuaChua";
            this.textBoxTongTienPhieuSuaChua.ReadOnly = true;
            this.textBoxTongTienPhieuSuaChua.Size = new System.Drawing.Size(169, 26);
            this.textBoxTongTienPhieuSuaChua.TabIndex = 45;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(183, 401);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(65, 19);
            this.lblTongTien.TabIndex = 44;
            this.lblTongTien.Text = "Tổng tiền";
            // 
            // btnInPhieuSuaChua
            // 
            this.btnInPhieuSuaChua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.btnInPhieuSuaChua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInPhieuSuaChua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPhieuSuaChua.Location = new System.Drawing.Point(337, 468);
            this.btnInPhieuSuaChua.Margin = new System.Windows.Forms.Padding(2);
            this.btnInPhieuSuaChua.Name = "btnInPhieuSuaChua";
            this.btnInPhieuSuaChua.Size = new System.Drawing.Size(163, 29);
            this.btnInPhieuSuaChua.TabIndex = 48;
            this.btnInPhieuSuaChua.Text = "In phiếu sửa chữa";
            this.btnInPhieuSuaChua.UseVisualStyleBackColor = false;
            // 
            // btnLuuPSC
            // 
            this.btnLuuPSC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.btnLuuPSC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuuPSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuPSC.Location = new System.Drawing.Point(64, 468);
            this.btnLuuPSC.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuuPSC.Name = "btnLuuPSC";
            this.btnLuuPSC.Size = new System.Drawing.Size(228, 29);
            this.btnLuuPSC.TabIndex = 47;
            this.btnLuuPSC.Text = "Lưu phiếu sửa chữa";
            this.btnLuuPSC.UseVisualStyleBackColor = false;
            // 
            // UserControldatagrid1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.textBoxTongTienPhieuSuaChua);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.btnInPhieuSuaChua);
            this.Controls.Add(this.btnLuuPSC);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "UserControldatagrid1";
            this.Size = new System.Drawing.Size(824, 499);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox textBoxTongTienPhieuSuaChua;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnInPhieuSuaChua;
        private System.Windows.Forms.Button btnLuuPSC;
    }
}
