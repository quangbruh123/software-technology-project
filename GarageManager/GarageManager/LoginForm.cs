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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void taotaikhoanbtn_Click(object sender, EventArgs e)
        {
            this.Hide();    
            Formtaotaikhoan formtaotaikhoan = new Formtaotaikhoan();
            formtaotaikhoan.ShowDialog();
        }

        private void dangnhapbtn_Click(object sender, EventArgs e)
        {
            if (Classes.Account.LogIn(usertxt.Text, passwordtxt.Text))
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                MainForm.isLoggedIn = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
