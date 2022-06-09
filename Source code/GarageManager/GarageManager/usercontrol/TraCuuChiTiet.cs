﻿using System;
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
    public partial class TraCuuChiTiet : UserControl
    {
        public TraCuuChiTiet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TraCuu tracuu = (TraCuu)Parent;
            tracuu.LoadTraCuuUserControl();
        }

        public void LoadChitiet(Model.XE xe)
        {
            foreach (var item in Classes.DataProvider.Instance.DB.PHIEUSUACHUAs)
            {
                if (item.BienSo == xe.BienSo)
                {
                    dataGridView1.Rows.Add(item.MaPhieuSC, item.BienSo, item.NgaySuaChua, item.TongTien);
                }
            }

            if (dataGridView1.Rows.Count < 2)
            {
                return;
            }
            dataGridView1.Rows[0].Selected = true;

            int maPSC;
            if (dataGridView1.SelectedRows.Count != 0)
            {
                maPSC = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                maPSC = int.Parse(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
            }
            foreach (var item in Classes.DataProvider.Instance.DB.CT_PSC)
            {
                if (item.MaPhieuSC == maPSC)
                {
                    dataGridView2.Rows.Add(item.MaCTPSC, item.MaPhieuSC, item.NoiDung, item.SoLan, item.MaTienCong, item.ThanhTien);
                }
            }

            if (dataGridView2.Rows.Count < 2)
            {
                return;
            }
            dataGridView1.Rows[2].Selected = true;

            int maCTPSC;
            if (dataGridView2.SelectedRows.Count != 0)
            {
                maCTPSC = int.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                maCTPSC = int.Parse(dataGridView2.Rows[dataGridView2.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
            }
            foreach (var item in Classes.DataProvider.Instance.DB.CT_SUDUNGVATTU)
            {
                if (item.MaCTPSC == maCTPSC)
                {
                    dataGridView3.Rows.Add(item.MaCTPSC, item.MaVatTu, item.SoLuong, item.DonGia, item.ThanhTien);
                }
            }

        }
    }
}
