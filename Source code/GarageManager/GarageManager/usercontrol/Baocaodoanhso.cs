using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageManager.usercontrol
{
    public partial class Baocaodoanhso : UserControl
    {
        private int month;
        private int year;
        private double TongTien;

        public Baocaodoanhso()
        {
            InitializeComponent();
            month = DateTime.Now.Month;
            year = DateTime.Now.Year;
        }

        private void getFinancialReportButton_Click(object sender, EventArgs e)
        {
            dataGridViewBaoCaoDoanhSo.Rows.Clear();
            if (yearComboBox.SelectedItem == null || monthComboBox.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ giá trị");
            }
            else
            {
                month = int.Parse(monthComboBox.GetItemText(monthComboBox.SelectedItem));
                year = int.Parse(yearComboBox.GetItemText(yearComboBox.SelectedItem));

                TongTien = 0;
                Model.BAOCAODOANHSO financialReport = Classes.Finance.GetMonthlyFinancialReport(month, year);
                if (financialReport != null)
                {
                    int stt = 1;
                    foreach (var item in financialReport.CT_BCDS)
                    {
                        Model.HIEUXE xe = Classes.DataProvider.Instance.DB.HIEUXEs.FirstOrDefault(x => x.MaHieuXe == item.MaHieuXe);
                        string brand = xe.TenHieuXe.ToString();
                        dataGridViewBaoCaoDoanhSo.Rows.Add(
                            stt.ToString(),
                            brand,
                            item.SoLuotSua.ToString(),
                            ((int)item.ThanhTien).ToString(),
                            financialReport.TongDoanhThu != 0 ? (double)(item.ThanhTien * item.SoLuotSua / financialReport.TongDoanhThu * 100) : 0);
                        stt++;
                        TongTien += double.Parse(item.ThanhTien.ToString());
                    }
                    textBoxTongDoanhThu.Text = TongTien.ToString() + " VND";
                }
                else
                {
                    MessageBox.Show("Không có báo cáo doanh số cho tháng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Baocaodoanhso_Load(object sender, EventArgs e)
        {

        }

        private void Baocaodoanhso_VisibleChanged(object sender, EventArgs e)
        {
            monthComboBox.Items.Clear();
            List<string> months = CultureInfo.InvariantCulture.DateTimeFormat.MonthNames.Take(12).ToList();
            for (int i = 0; i < months.Count; i++)
            {
                monthComboBox.Items.Add(DateTime.ParseExact(months[i], "MMMM", CultureInfo.InvariantCulture).Month);
            }
            monthComboBox.SelectedItem = DateTime.Now.Month;
            yearComboBox.DataSource = Enumerable.Range(DateTime.Now.Year - 10, DateTime.Now.Year - (DateTime.Now.Year - 10) + 1).ToList();
            yearComboBox.SelectedItem = DateTime.Now.Year;
            TongTien = 0;
            Model.BAOCAODOANHSO financialReport = Classes.Finance.GetMonthlyFinancialReport(month, year);

            if (financialReport != null)
            {
                int stt = 1;
                foreach (var item in financialReport.CT_BCDS)
                {
                    Model.HIEUXE xe = Classes.DataProvider.Instance.DB.HIEUXEs.FirstOrDefault(x => x.MaHieuXe == item.MaHieuXe);
                    string brand = xe.TenHieuXe.ToString();
                    dataGridViewBaoCaoDoanhSo.Rows.Add(
                        stt.ToString(),
                        brand,
                        item.SoLuotSua.ToString(),
                        ((int)item.ThanhTien).ToString(),
                        financialReport.TongDoanhThu != 0 ? (double)(item.ThanhTien * item.SoLuotSua / financialReport.TongDoanhThu * 100) : 0);
                    stt++;
                    TongTien += double.Parse(item.ThanhTien.ToString());
                }
                textBoxTongDoanhThu.Text = TongTien.ToString() + " VND";
            }
        }
    }
}
