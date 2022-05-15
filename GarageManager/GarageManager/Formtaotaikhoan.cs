﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageManager
{
    public partial class Formtaotaikhoan : Form
    {
        public Formtaotaikhoan()
        {
            InitializeComponent();
        }

        private void pictureBoxexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm formDăngNhập = new LoginForm();
            formDăngNhập.ShowDialog();
        }

        private void dangnhapbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();  
        }

        private void taotaikhoanbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm formDăngNhập = new LoginForm();
            formDăngNhập.ShowDialog();
        }
    }
}
