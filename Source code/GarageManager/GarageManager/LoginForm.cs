using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            button2.Parent = gradient1;
            button2.BackColor = Color.Transparent;
            pictureBox3.Parent = gradient1;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.Parent = gradient1;
            pictureBox4.BackColor = Color.Transparent;
        }

        private void dangnhapbtn_Click(object sender, EventArgs e)
        {
            SHA256 sha256hash = SHA256.Create();
            string passwordhash = GetHash(sha256hash, passwordtxt.Text);
            if (Classes.DataProvider.Instance.DB.TAIKHOANs.Any(x => x.TenTaiKhoan == usertxt.Text && x.MatKhau == passwordhash))
            {
                Model.TAIKHOAN currentAccount = Classes.DataProvider.Instance.DB.TAIKHOANs.FirstOrDefault(x => x.TenTaiKhoan == usertxt.Text && x.MatKhau == passwordhash);
                MainForm.currentRole = (int)currentAccount.QuyenHan;
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
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

        private void gradient1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usertxt_Enter(object sender, EventArgs e)
        {
            if (usertxt.Text == "Tên đăng nhập")
            {
                usertxt.Text = "";
                usertxt.ForeColor = Color.Black;
            }
        }

        private void usertxt_Leave(object sender, EventArgs e)
        {
            if (usertxt.Text == "")
            {
                usertxt.Text = "Tên đăng nhập";
                usertxt.ForeColor = Color.Silver;
            }
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void passwordtxt_Enter(object sender, EventArgs e)
        {
            if (passwordtxt.Text == "Mật khẩu")
            {
                passwordtxt.Text = "";
                passwordtxt.ForeColor = Color.Black;
            }
        }

        private void passwordtxt_Leave(object sender, EventArgs e)
        {
            if (passwordtxt.Text == "")
            {
                passwordtxt.Text = "Mật khẩu";
                passwordtxt.ForeColor = Color.Silver;
            }
        }

        public static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.FormClosed += ForgetPassword_FormClosed;
            forgetPassword.Show();
            
        }

        private void ForgetPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
