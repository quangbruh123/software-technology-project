﻿using GarageManager.usercontrol;
using System;
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
    public partial class MainForm : Form
    {
        /// <summary>
        /// Log in state
        /// </summary>
        /// 
        public static bool isLoggedIn = false;
        //Nút nhảy usercontrol
        private LapphieuthutienUserControl uc1;
        private tracuuUserControl1 uc2;
        private LapphieusuachuaUserControl uc3;

        public MainForm()
        {
            InitializeComponent();
         
        }
        //Nút exit zoom mini
        private void button4_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            mainpanel.Visible = true;
            lapphieusuachuaUserControl1.Visible = false;
            uc1 = new LapphieuthutienUserControl();
            Controls.Add(uc1);
            uc2 = new tracuuUserControl1();
            Controls.Add(uc2);
            uc3 = new LapphieusuachuaUserControl();
            Controls.Add(uc3);
            uc1.Visible = false;
            uc2.Visible = false;
            uc3.Visible = false;
        }
        private void tracuuxebutton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            mainpanel.Visible = false;
            uc1.Visible = false;
            uc2.Visible = true;
            uc3.Visible = false;
            uc2.Dock = DockStyle.Right;
        }
        private void lapphieuthutienbutton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            mainpanel.Visible = false;
            uc1.Visible = true;
            uc2.Visible = false;
            uc3.Visible = false;
        }

        private void lapphieusuachuabutton_Click(object sender, EventArgs e)
        {

            panel1.Visible = true;
            mainpanel.Visible = false;
            uc1.Visible = false;
            uc2.Visible = false;
            uc3.Visible = true;
            uc3.Dock = DockStyle.Right;
        }

        private void tiepnhanbaotrixebutton_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            label2.Visible = true;
        }

        private void tiepnhanbaotrixebutton_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
