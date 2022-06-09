using GarageManager.usercontrol;
using GarageManager.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GarageManager
{
    public partial class MainForm : Form
    {
        //Nút nhảy usercontrol
        private Chinhsuaquydinh uc1;
        private TraCuu uc2;
        private Tiepnhanbaotrixe uc4;
        private LAPPHIEU uc5;
        private Baocaothang uc3;
        /// <summary>
        /// Stores the current role of the user. 0 is staff, 1 is admin
        /// </summary>
        public static int currentRole;

        public MainForm()
        {
            InitializeComponent();
            MinimizeBtn.Parent = gradient2;
            MinimizeBtn.BackColor = Color.Transparent;
            CloseBtn.Parent = gradient2;
            CloseBtn.BackColor = Color.Transparent;

        }
        //Nút exit zoom mini
        private void button4_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            int stt = 1;
            foreach (Model.TAIKHOAN item in DataProvider.Instance.DB.TAIKHOANs)
            {
                dataGridViewNhanvien.Rows.Add(stt, item.HoTen, item.TenTaiKhoan, item.Email, item.QuyenHan);
                stt++;
            }
            uc1 = new Chinhsuaquydinh();
            Controls.Add(uc1);
            uc2 = new TraCuu();
            Controls.Add(uc2);
            uc3 = new Baocaothang();
            Controls.Add(uc3);
            uc4 = new Tiepnhanbaotrixe();
            Controls.Add(uc4);
            uc5 = new LAPPHIEU();
            Controls.Add(uc5);
            uc1.Visible = false;
            uc2.Visible = false;
            uc3.Visible = false;
            uc4.Visible = false;
            uc5.Visible = false;

            Debug.WriteLine(Properties.Settings.Default.LastLoginDate.Month + " " + Properties.Settings.Default.LastLoginDate.Year);
            if (DateTime.Today.Month != Properties.Settings.Default.LastLoginDate.Month || DateTime.Today.Year != Properties.Settings.Default.LastLoginDate.Year)
            {
                Classes.Storage.NewStorageReports(DateTime.Today.Month, DateTime.Today.Year);
                Properties.Settings.Default.LastLoginDate = DateTime.Today;
                Properties.Settings.Default.Save();
            }
        }
        
        private void Lapphieubtn_Click(object sender, EventArgs e)
        {
            mainpanel.Visible = false;
            uc1.Visible = false;
            uc2.Visible = false;
            uc3.Visible = false;
            uc4.Visible = false;
            uc5.Visible = true;
            uc5.Location = new Point(213, 31);
        }

        private void Tracuubtn_Click(object sender, EventArgs e)
        {
            mainpanel.Visible = false;
            uc1.Visible = false;
            uc2.Visible = true;
            uc3.Visible = false;
            uc4.Visible = false;
            uc5.Visible = false;
            uc2.Location = new Point(213, 31);
        }

        private void Tiepnhanbaotrixebtn_Click(object sender, EventArgs e)
        {
            mainpanel.Visible = false;
            uc1.Visible = false;
            uc2.Visible = false;
            uc3.Visible = false;
            uc4.Visible = true;
            uc5.Visible = false;
            uc4.Location = new Point(213, 31);
        }

        private void Baocaothangbtn_Click(object sender, EventArgs e)
        {
            mainpanel.Visible = false;
            uc1.Visible = false;
            uc2.Visible = false;
            uc3.Visible = true;
            uc4.Visible = false;
            uc5.Visible = false;
            uc3.Location = new Point(213, 31);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mainpanel.Visible = false;
            uc1.Visible = true;
            uc2.Visible = false;
            uc3.Visible = false;
            uc4.Visible = false;
            uc5.Visible = false;
            uc1.Location = new Point(213, 31);
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close this Application?", "Notice", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Addaccount_Click(object sender, EventArgs e)
        {
            //Account.AddStaffAccount(tktxt.Text, Mktxt.Text);
        }

        private void deletebnt_Click(object sender, EventArgs e)
        {
            //Account.DeleteAccount(deletetktxt.Text);
        }

        private void Trangchubtn_Click(object sender, EventArgs e)
        {
            mainpanel.Visible = true;
            uc1.Visible = false;
            uc2.Visible = false;
            uc3.Visible = false;
            uc4.Visible = false;
            uc5.Visible = false;
        }
    }
}
