﻿using System;
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
            if (!Classes.DataProvider.Instance.DB.TAIKHOANs.Any(x => x.TenTaiKhoan == usertxt.Text && x.Email == gmailtxt.Text))
            {
                MessageBox.Show("Tên tài không tồn tại hoặc gmail không chính xác", "Không thể gửi mã xác nhận");
                return;
            }

            Random rand = new Random();
            code = rand.Next(1000, 9999).ToString();
            
            MailMessage mail = new MailMessage("sorunaito@gmail.com", gmailtxt.Text, "Mã xác nhận - Garage Management", "Mã xác nhận của bạn là " + code);
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("sorunaito@gmail.com", "nwmhvxvdwnxodrne");

            smtpClient.Send(mail);
            MessageBox.Show("Đã gửi mã tới gmail " + gmailtxt.Text + "\nNếu không tìm thấy tin nhắn, xin thử tìm ở mục thư rác", "Gửi mã thành công");
        }

        private void dangnhapbtn_Click(object sender, EventArgs e)
        {
            if(codetxt.Text == code)
            {
                this.Hide();
                CreateNewPassword newPassword = new CreateNewPassword();
                newPassword.FormClosed += NewPassword_FormClosed;
                newPassword.tenTaiKhoan = usertxt.Text;
                newPassword.Show();
            }
            else
            {
                MessageBox.Show("Mã xác nhận không hợp lệ", "Lỗi");
            }
        }

        private void NewPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
