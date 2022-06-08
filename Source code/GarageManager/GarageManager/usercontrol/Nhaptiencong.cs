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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Nhaptiencong_Load(object sender, EventArgs e)
        {
            int i = 1;
            var taikhoan = DataProvider.Instance.DB.TIENCONGs;
            foreach (var x in taikhoan)
            {
                dataGridView1.Rows.Add(i, x.TenTienCong,x.GiaTienCong);
                i++;
            }
        }
    }
}
