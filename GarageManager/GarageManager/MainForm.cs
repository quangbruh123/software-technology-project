using GarageManager.usercontrol;
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
        private Chinhsuaquydinh uc1;
        private tracuuUserControl1 uc2;
        private Tiepnhanbaotrixe uc4;
        private LAPPHIEU uc5;
        private Baocaothang uc3;
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
            uc1 = new Chinhsuaquydinh();
            Controls.Add(uc1);
            uc2 = new tracuuUserControl1();
            Controls.Add(uc2);
            uc3 = new Baocaothang();
            Controls.Add(uc3);
            uc4 = new Tiepnhanbaotrixe();
            Controls.Add(uc4);
            uc5 = new LAPPHIEU();
            Controls.Add(uc5);
            uc1.Visible = false;
            uc2.Visible = false;
            uc3.Visible = false;
            uc4.Visible = false;
            uc5.Visible = false;
        }     
         
        private void Lapphieubtn_Click(object sender, EventArgs e)
        {

            mainpanel.Visible = false;
            uc1.Visible = false;
            uc2.Visible = false;
            uc3.Visible = false;
            uc4.Visible = false;
            uc5.Visible = true;
            uc5.Location = new Point(211, 48);
        }

        private void Tracuubtn_Click(object sender, EventArgs e)
        {
            mainpanel.Visible = false;
            uc1.Visible = false;
            uc2.Visible = true;
            uc3.Visible = false;
            uc4.Visible = false;
            uc5.Visible = false;
            uc2.Location = new Point(211, 48);
        }

        private void Tiepnhanbaotrixebtn_Click(object sender, EventArgs e)
        {
            mainpanel.Visible = false;
            uc1.Visible = false;
            uc2.Visible = false;
            uc3.Visible = false;
            uc4.Visible = true;
            uc5.Visible = false;
            uc4.Location = new Point(211, 48);
        }

        private void Baocaothangbtn_Click(object sender, EventArgs e)
        {
            mainpanel.Visible = false;
            uc1.Visible = false;
            uc2.Visible = false;
            uc3.Visible = true;
            uc4.Visible = false;
            uc5.Visible = false;
            uc3.Location = new Point(211, 48);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mainpanel.Visible = false;
            uc1.Visible = true;
            uc2.Visible = false;
            uc3.Visible = false;
            uc4.Visible = false;
            uc5.Visible = false;
            uc1.Location = new Point(211, 48);
        }
    }
}
