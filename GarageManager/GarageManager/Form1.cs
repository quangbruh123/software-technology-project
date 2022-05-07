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
    public partial class Form1 : Form
    {
        /// <summary>
        /// Logged in status
        /// </summary>
        public static bool isLoggedIn = false;
        //Nút nhảy usercontrol
        private LapphieuthutienUserControl uc1;
        private tracuuUserControl1 uc2;

        public Form1()
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
            uc1 = new LapphieuthutienUserControl();
            Controls.Add(uc1);
            uc2 = new tracuuUserControl1();
            Controls.Add(uc2);
            uc1.Visible = false;
            uc2.Visible = false;
        }
        private void tracuuxebutton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            mainpanel.Visible = false;
            uc1.Visible = false;
            uc2.Visible = true;
        }
        private void lapphieuthutienbutton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            mainpanel.Visible = false;
            uc1.Visible = true;
            uc2.Visible = false;
        }

        /// <summary>
        /// User log in check, set isLoggedIn to true if the user's account existed, false if it doesn't
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        private void LogIn(string username, string password)
        {
            var userCount = Classes.DataProvider.Instance.DB.TAIKHOANs.Where(x => x.TenDangNhap == username && x.MatKhau == password).Count();
            if (userCount == 0) isLoggedIn = true;
        }
    }
}
