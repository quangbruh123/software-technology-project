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
            panel1.Visible =true;
            mainpanel.Visible = true;
            lapphieuthutienUserControl.Visible = false;           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            mainpanel.Visible = false;
            lapphieuthutienUserControl.Visible = true;
        }

        private void LogIn(string username, string password)
        {
            var userCount = Classes.DataProvider.Instance.DB.TAIKHOANs.Where(x => x.TenDangNhap == username && x.MatKhau == password).Count();
            if (userCount == 0) isLoggedIn = true;
        }
    }
}
