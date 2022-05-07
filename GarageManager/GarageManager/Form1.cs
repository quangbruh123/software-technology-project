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
        public static bool isLoggedIn = false;

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
        //Hào đặt sao tùy
        private void LogIn(string username, string password)
        {
            var userCount = Classes.DataProvider.Instance.DB.TAIKHOANs.Where(x => x.TenDangNhap == username && x.MatKhau == password).Count();
            if (userCount == 0) isLoggedIn = true;
        }
        //Nút nhảy usercontrol
        LapphieuthutienUserControl uc1;
        tracuuUserControl1 uc2;
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
    }
}
