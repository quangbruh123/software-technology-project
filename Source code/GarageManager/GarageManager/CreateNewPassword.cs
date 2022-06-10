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
    public partial class CreateNewPassword : Form
    {
        public CreateNewPassword()
        {
            InitializeComponent();
        }

        public string tenTaiKhoan;

        private void dangnhapbtn_Click(object sender, EventArgs e)
        {
            if (passwordtxt.Text != repasswordtxt.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không đúng", "Lỗi");
                return;
            }
            Model.TAIKHOAN forgetAccount = Classes.DataProvider.Instance.DB.TAIKHOANs.FirstOrDefault(x => x.TenTaiKhoan == tenTaiKhoan);
            SHA256 sha256hash = SHA256.Create();
            string passwordhash = LoginForm.GetHash(sha256hash, passwordtxt.Text);

            forgetAccount.MatKhau = passwordhash;
            this.Close();
        }

        private void passwordtxt_Enter(object sender, EventArgs e)
        {
            if (passwordtxt.Text == "Mậu khẩu mới")
            {
                passwordtxt.Clear();
                passwordtxt.UseSystemPasswordChar = true;
            }
        }

        private void passwordtxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passwordtxt.Text))
            {
                passwordtxt.Text = "Mậu khẩu mới";
                passwordtxt.UseSystemPasswordChar = false;
            }
        }

        private void repasswordtxt_Enter(object sender, EventArgs e)
        {
            if (repasswordtxt.Text == "Nhập lại mật khẩu")
            {
                repasswordtxt.Clear();
                repasswordtxt.UseSystemPasswordChar = true;
            }
        }

        private void repasswordtxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(repasswordtxt.Text))
            {
                repasswordtxt.Text = "Nhập lại mật khẩu";
                repasswordtxt.UseSystemPasswordChar = false;
            }
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
