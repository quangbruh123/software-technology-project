﻿using GarageManager.usercontrol;
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
            int i = 1;
            var taikhoan = DataProvider.Instance.DB.VATTUs;
            foreach (var x in taikhoan)
            {
                dataGridView1.Rows.Add(i, x.TenVatTu, x.DonGiaHienTai, x.SoLuongTon);
                i++;
            }
        }
    }
}
