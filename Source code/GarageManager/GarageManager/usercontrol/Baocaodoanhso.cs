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
    public partial class Baocaodoanhso : UserControl
    {
        int month;
        int year;
        double TongTien;
        public Baocaodoanhso()
        {
            InitializeComponent();
            month = DateTime.Now.Month;
            year = DateTime.Now.Year;
            textBoxThangBaoCao.Text = month.ToString() + '/' + year.ToString();
            LoadData();
        }
        
        void LoadData()
        {
            TongTien = 0;
            Model.BAOCAODOANHSO financialReport = Classes.Finance.GetMonthlyFinancialReport(month, year);
            int stt = 1;
            foreach (var item in financialReport.CT_BCDS)
            {
                Model.HIEUXE xe = Classes.DataProvider.Instance.DB.HIEUXEs.FirstOrDefault(x => x.MaHieuXe == item.MaHieuXe);
                string brand = xe.TenHieuXe.ToString();
                dataGridViewBaoCaoDoanhSo.Rows.Add(stt.ToString(), brand, item.SoLuotSua.ToString(), item.ThanhTien.ToString());
                stt++;
                TongTien += double.Parse(item.ThanhTien.ToString());
            }
            textBoxTongDoanhThu.Text = TongTien.ToString();
        }

        private void btnLapBaoCaoDoanhSo_Click(object sender, EventArgs e)
        {
            dataGridViewBaoCaoDoanhSo.Rows.Clear();
            string[] txt = textBoxThangBaoCao.Text.Split('/');
            month = Convert.ToInt32(txt[0]);
            year = Convert.ToInt32(txt[1]);
            if (year > DateTime.Now.Year)
            {
                MessageBox.Show("Thời gian lớn hơn thời gian hiện tại", "Lập báo cáo không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (month > DateTime.Now.Month)
            {
                MessageBox.Show("Thời gian lớn hơn thời gian hiện tại", "Lập báo cáo không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadData();
        }

        private void btnBaoCaoDoanhSoMoi_Click(object sender, EventArgs e)
        {
            dataGridViewBaoCaoDoanhSo.Rows.Clear();
        }
    }
}
