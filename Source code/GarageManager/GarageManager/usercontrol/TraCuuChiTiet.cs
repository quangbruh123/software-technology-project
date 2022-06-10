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
    public partial class TraCuuChiTiet : UserControl
    {
        private int counter = 0;

        public TraCuuChiTiet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refresh();
        }

        public void LoadChitiet(Model.XE xe)
        {
            foreach (var item in Classes.DataProvider.Instance.DB.PHIEUSUACHUAs)
            {
                if (item.BienSo == xe.BienSo)
                {
                    dataGridView1.Rows.Add(item.MaPhieuSC, item.BienSo, item.NgaySuaChua, int.Parse(item.TongTien.ToString()) + " VND");
                }
            }
            counter++;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
            {
                return;
            }
            dataGridView2.Rows.Clear();

            counter++;

            int maPSC;
            if (dataGridView1.SelectedRows.Count > 0)
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
                    string wageName = Classes.DataProvider.Instance.DB.TIENCONGs.FirstOrDefault(x => x.MaTienCong == item.MaTienCong).TenTienCong;
                    dataGridView2.Rows.Add(item.MaCTPSC, item.MaPhieuSC, item.NoiDung, item.SoLan, wageName, int.Parse(item.ThanhTien.ToString()) + " VND");
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView2.Rows.Count < 1)
            {
                return;
            }
            dataGridView3.Rows.Clear();

            counter++;

            int maCTPSC;
            if (dataGridView2.SelectedRows.Count > 0)
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
                    string partName = Classes.DataProvider.Instance.DB.VATTUs.FirstOrDefault(x => x.MaVatTu == item.MaVatTu).TenVatTu;
                    dataGridView3.Rows.Add(item.MaCTPSC, partName, item.SoLuong, item.DonGia, int.Parse(item.ThanhTien.ToString()) + " VND");
                }
            }
        }

        private void panel1_VisibleChanged(object sender, EventArgs e)
        {
            if ( counter > 0)
            {
                refresh();
            }
            
        }

        private void refresh()
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            TraCuu tracuu = (TraCuu)Parent;
            tracuu.LoadTraCuuUserControl();
            counter = 0;
        }
    }
}
