using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace GarageManager
{
    public partial class ForgetPassword : Form
    {
        string code = "0";

        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

            ///Kiểm tra tài khoản
            ///Kiểm tra gmail

            Random rand = new Random();
            string code = rand.Next(1000, 9999).ToString();
            
            MailMessage mail = new MailMessage("sorunaito@gmail.com", gmailtxt.Text, "Mã xác nhận - Garage Management", "Mã xác nhận của bạn là " + code);
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("sorunaito@gmail.com", "nwmhvxvdwnxodrne");

            smtpClient.Send(mail);

        }

        private void dangnhapbtn_Click(object sender, EventArgs e)
        {
            if(codetxt.Text == code)
            {
                ///Mở form CreateNewPassword
            }
            else
            {
                MessageBox.Show("Mã xác nhận không hợp lệ", "Lỗi");
            }
        }
    }
}
