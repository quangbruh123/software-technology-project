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
    public partial class Nhapvatu : UserControl
    {
        public Nhapvatu()
        {
            InitializeComponent();
            string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
        }

        private void MAVTlb_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nhapvatu_Load(object sender, EventArgs e)
        {
            int i = 1;
            var taikhoan = DataProvider.Instance.DB.VATTUs;
            foreach (var x in taikhoan)
            {
                dataGridView1.Rows.Add(i, x.TenVatTu, (int)x.DonGiaHienTai + " VND", x.SoLuongTon);
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxTenVTPTMoi.Text) == true ||
                String.IsNullOrEmpty(textBoxDongiaNhap.Text) == true ||
                String.IsNullOrEmpty(textBox3.Text) == true ||
                String.IsNullOrEmpty(textBox1.Text) == true )
            {
                MessageBox.Show("Thông tin chưa được điền đầy đủ", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                List<string> partNameslist = new List<string>();
                List<int> amountList = new List<int>();
                List<int> originalValuesList = new List<int>();
                List<int> priceTagsList = new List<int>();
                partNameslist.Add(textBoxTenVTPTMoi.Text);
                amountList.Add(int.Parse(textBox1.Text));
                originalValuesList.Add(int.Parse(textBoxDongiaNhap.Text));
                priceTagsList.Add(int.Parse(textBox3.Text));
                Storage.AddPartInputCard(partNameslist, amountList, originalValuesList, priceTagsList, DateTime.Now);
                dataGridView1.Rows.Clear();
                int i = 1;
                var vattu = DataProvider.Instance.DB.VATTUs;
                foreach (var x in vattu)
                {
                    dataGridView1.Rows.Add(i, x.TenVatTu, (int)x.DonGiaHienTai + " VND", x.SoLuongTon);
                    i++;
                }
                MessageBox.Show("Thông tin vật tư đã được thêm thành công", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxDongiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cancerbtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBoxDongiaNhap.Clear();
            textBoxTenVTPTMoi.Clear();
        }

        private void Nhapvatu_VisibleChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBoxDongiaNhap.Clear();
            textBoxTenVTPTMoi.Clear();
        }
    }
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    //Classes.Storage.RemovePart(textBox2.Text);
        //    //dataGridView1.Rows.Clear();
        //    //int i = 1;
        //    //var taikhoan = DataProvider.Instance.DB.VATTUs;
        //    //foreach (var x in taikhoan)
        //    //{
        //    //    dataGridView1.Rows.Add(i, x.TenVatTu, x.DonGiaHienTai, x.SoLuongTon);
        //    //    i++;
        //    //}
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Storage.AddPartInputCard(textBoxTenVTPTMoi.Text, Int32.Parse(textBox3.Text), Int32.Parse(textBoxDongiaNhap.Text), Int32.Parse(textBox1.Text), DateTime.Now);
        //}

      
        //private void button1_Click(object sender, EventArgs e)
        ////{
        ////        Classes.Storage.AddPartInputCard()
        //}
  }

