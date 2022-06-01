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
    public partial class Formtaotaikhoan : Form
    {    
        public Formtaotaikhoan()
        {
            InitializeComponent();
            label11.Parent = gradient1;
            label11.BackColor = Color.Transparent;
            paneluser.Parent = gradient1;
            paneluser.BackColor = Color.Transparent;
            panelpassword.Parent = gradient1;
            panelpassword.BackColor = Color.Transparent;
            panel1.Parent = gradient1;
            panel1.BackColor = Color.Transparent;


        }

        private void pictureBoxexit_Click(object sender, EventArgs e)   
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.ShowDialog();
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
            LoginForm loginform = new LoginForm();
            loginform.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            passwordtxt.UseSystemPasswordChar = !passwordtxt.UseSystemPasswordChar;
            repasswordtxt.UseSystemPasswordChar = !repasswordtxt.UseSystemPasswordChar;
        }


        private void CloseBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
