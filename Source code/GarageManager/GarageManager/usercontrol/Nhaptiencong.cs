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

namespace GarageManager.usercontrol
{
    public partial class Nhaptiencong : UserControl
    {
        public Nhaptiencong()
        {
            InitializeComponent();
            panel2.Visible = false;
            panel4.Visible = false;
            cancerbtn.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Nhaptiencong_Load(object sender, EventArgs e)
        {
            panel4.Location = new Point(480, 124);
            int i = 1;
            var taikhoan = DataProvider.Instance.DB.TIENCONGs;
            foreach (var x in taikhoan)
            {
                dataGridView1.Rows.Add(i, x.TenTienCong, (int)x.GiaTienCong + " VND");
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTenVTPTMoi.Text) == true ||
                string.IsNullOrEmpty(textBoxSoLuongVTPT.Text) == true)
            {
                MessageBox.Show("Thông tin chưa được điền đầy đủ", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Finance.AddWageType(textBoxTenVTPTMoi.Text, long.Parse(textBoxSoLuongVTPT.Text)) == true)
                {
                    MessageBox.Show("Thông tin đã được thêm thành công", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.Rows.Clear();
                    int i = 1;
                    var taikhoan = DataProvider.Instance.DB.TIENCONGs;
                    foreach (var x in taikhoan)
                    {
                        dataGridView1.Rows.Add(i, x.TenTienCong, (int)x.GiaTienCong + " VND");
                        i++;
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin không được thêm thành công, yêu cầu kiểm tra lại thông tin", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cancerbtn_Click(object sender, EventArgs e)
        {
            textBoxTenVTPTMoi.Clear();
            textBoxSoLuongVTPT.Clear();
            textBoxTCSua.Clear();
            textBoxDGMoi.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Thêm")
            {
                panel2.Visible = true;
                panel4.Visible = false;
                btnSua.Enabled = false;
                cancerbtn.Visible = true;
                textBoxTenVTPTMoi.Clear();
                textBoxSoLuongVTPT.Clear();
            }
            if (comboBox1.Text == "Chỉnh sửa")
            {
                panel2.Visible = false;
                panel4.Visible = true;
                btnSua.Enabled = false;
                cancerbtn.Visible = true;
                textBoxTCSua.Clear();
                textBoxDGMoi.Clear();
            }
            if (comboBox1.SelectedIndex == -1)
            {
                panel2.Visible = false;
                panel4.Visible = false;
            }
        }

        private void btnChonSua_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            textBoxTCSua.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDGMoi.Text))
            {
                MessageBox.Show("Thông tin chưa được điền đầy đủ", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Classes.Finance.UpdateWagePrice(textBoxTCSua.Text, int.Parse(textBoxDGMoi.Text)) == true)
                {
                    MessageBox.Show("Thông tin đã được sửa thành công", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.Rows.Clear();
                    int i = 1;
                    var taikhoan = DataProvider.Instance.DB.TIENCONGs;
                    foreach (var x in taikhoan)
                    {
                        dataGridView1.Rows.Add(i, x.TenTienCong, (int)x.GiaTienCong + " VND");
                        i++;
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin không được sửa thành công", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void textBoxSoLuongVTPT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxDGMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
