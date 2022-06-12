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
using System.Security.Cryptography;

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
        public bool logout;

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
            LoadDataGridView();
            if (currentRole == 0) mainpanel.Visible = false;
            logout = false;

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
            if (currentRole == 0)
            {
                button7.Visible = false;
            }
            Debug.WriteLine(Properties.Settings.Default.LastLoginDate.Month + " " + Properties.Settings.Default.LastLoginDate.Year);
            Debug.WriteLine(DataProvider.Instance.DB.THAMSOes.FirstOrDefault(x => x.TenThamSo == "TodayVehicle").GiaTri + " vehicle");
            if (DataProvider.Instance.DB.BAOCAOTONs.Count() == 0)
            {
                Storage.NewStorageReports(DateTime.Today.Month, DateTime.Today.Year);
            }
            if (DataProvider.Instance.DB.BAOCAODOANHSOes.Count() == 0)
            {
                Finance.NewMonthlyFinancialReport(DateTime.Today.Month, DateTime.Today.Year);
            }
            if (DateTime.Today.Month != Properties.Settings.Default.LastLoginDate.Month || DateTime.Today.Year != Properties.Settings.Default.LastLoginDate.Year)
            {
                Storage.NewStorageReports(DateTime.Today.Month, DateTime.Today.Year);
                Finance.NewMonthlyFinancialReport(DateTime.Today.Month, DateTime.Today.Year);
                Properties.Settings.Default.Save();
            }           
            if (DateTime.Today.Date != Properties.Settings.Default.LastLoginDate.Date)
            {
                DataProvider.Instance.DB.THAMSOes.FirstOrDefault(x => x.TenThamSo == "TodayVehicle").GiaTri = 0;
                DataProvider.Instance.DB.SaveChanges();
                Properties.Settings.Default.LastLoginDate = DateTime.Today;
                Properties.Settings.Default.Save();
            }

            addAccountPnl.Visible = false;
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

        private void LoadDataGridView()
        {
            dataGridViewNhanvien.Rows.Clear();
            int stt = 1;
            foreach (Model.TAIKHOAN item in DataProvider.Instance.DB.TAIKHOANs)
            {
                dataGridViewNhanvien.Rows.Add(stt, item.HoTen, item.TenTaiKhoan, item.Email, item.QuyenHan);
                stt++;
            }
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát ứng dụng?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Trangchubtn_Click(object sender, EventArgs e)
        {
            if (currentRole == 0) return;
            mainpanel.Visible = true;
            uc1.Visible = false;
            uc2.Visible = false;
            uc3.Visible = false;
            uc4.Visible = false;
            uc5.Visible = false;
        }

        private void addAccountBtn_Click(object sender, EventArgs e)
        {
            accTbx.Clear();
            emailTbx.Clear();
            nameTbx.Clear();
            genderTbx.Clear();
            passTbx.Clear();
            addAccountBtn.Visible = false;
            delAccountBtn.Visible = false;
            addAccountPnl.Visible = true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            addAccountBtn.Visible = true;
            delAccountBtn.Visible = true;
            addAccountPnl.Visible = false;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            SHA256 sha256hash = SHA256.Create();
            string passwordhash = LoginForm.GetHash(sha256hash, passTbx.Text);
            if (!ValidateEmail.EmailIsValid(emailTbx.Text))
            {
                MessageBox.Show("Email không hợp lệ", "Không thể tạo tài khoản");
                return;
            }    
            if (string.IsNullOrEmpty(accTbx.Text) || string.IsNullOrEmpty(passTbx.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Không thể tạo tài khoản");
                return;
            }
            if (adminCbx.Checked)
            {
                if (Account.AddAdminAccount(nameTbx.Text, accTbx.Text, emailTbx.Text, genderTbx.Text, passwordhash))
                {
                    MessageBox.Show("Đã tạo tài khoản", "Tạo tài khoản thành công");
                }
                else
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại", "Không thể tạo tài khoản");
                }
            }
            else
            {
                if (Account.AddStaffAccount(nameTbx.Text, accTbx.Text, emailTbx.Text, genderTbx.Text, passwordhash))
                {
                    MessageBox.Show("Đã tạo tài khoản", "Tạo tài khoản thành công");
                }
                else
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại", "Không thể tạo tài khoản");
                }
            }
            addAccountBtn.Visible = true;
            delAccountBtn.Visible = true;
            addAccountPnl.Visible = false;
            LoadDataGridView();
        }

        private void delAccountBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewNhanvien.Rows.Count < 1)
            {
                return;
            }

            string tentaikhoan;
            if (dataGridViewNhanvien.SelectedRows.Count > 0)
            {
                tentaikhoan = dataGridViewNhanvien.SelectedRows[0].Cells[2].Value.ToString();
            }
            else
            {
                tentaikhoan = dataGridViewNhanvien.Rows[dataGridViewNhanvien.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
            }
            Classes.Account.DeleteAccount(tentaikhoan);
            LoadDataGridView();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            logout = true;
            this.Close();
        }
    }
}
