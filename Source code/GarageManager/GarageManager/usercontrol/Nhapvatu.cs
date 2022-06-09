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
        }

        private void MAVTlb_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nhapvatu_Load(object sender, EventArgs e)
        {
            panel3.Location = new Point(546, 85);
            panel4.Location = new Point(546, 85);
            int i = 1;
            var taikhoan = DataProvider.Instance.DB.VATTUs;
            foreach (var x in taikhoan)
            {
                dataGridView1.Rows.Add(i, x.TenVatTu, x.DonGiaHienTai, x.SoLuongTon);
                i++;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Thêm")
            {
                panel2.Visible = true;
                panel3.Visible = false;
                panel4.Visible = false;
            }
            if (comboBox1.Text == "Xóa")
            {
                panel2.Visible = false;
                panel3.Visible = true;
                panel4.Visible = false;
            }
            if (comboBox1.Text == "Chỉnh sửa")
            {
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = true;
            }


        }
    }
}
