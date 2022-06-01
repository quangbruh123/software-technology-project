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
            passwordtxt.UseSystemPasswordChar = true;
            label4.Parent = gradient1;
            label4.BackColor = Color.Transparent;
            label1.Parent = gradient1;
            label1.BackColor = Color.Transparent;
            label2.Parent = gradient1;
            label2.BackColor = Color.Transparent;
            taotaikhoanbtn.Parent = gradient1;
            taotaikhoanbtn.BackColor = Color.Transparent;
            button2.Parent = gradient1;
            button2.BackColor = Color.Transparent;
            pictureBox3.Parent = gradient1;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.Parent = gradient1;
            pictureBox4.BackColor = Color.Transparent;
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
            else
                MessageBox.Show("Sai mật khẩu hoặc tên tài khoản");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close this Application?", "Notice", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
