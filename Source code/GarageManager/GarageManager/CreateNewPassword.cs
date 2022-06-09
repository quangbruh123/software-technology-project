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
    }
}
