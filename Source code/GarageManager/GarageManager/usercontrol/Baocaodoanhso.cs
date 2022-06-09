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
            LoadData();
        }
        
        private void LoadData()
        {
            TongTien = 0;
            Model.BAOCAODOANHSO financialReport = Classes.Finance.GetMonthlyFinancialReport(month, year);
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

        private void getFinancialReportButton_Click(object sender, EventArgs e)
        {
            dataGridViewBaoCaoDoanhSo.Rows.Clear();
            if (yearComboBox.SelectedItem == null || monthComboBox.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ giá trị");
            }
            else
            {
                month = DateTime.ParseExact((string)monthComboBox.SelectedValue, "MMMM", CultureInfo.InvariantCulture).Month;
                year = int.Parse(yearComboBox.GetItemText(yearComboBox.SelectedItem));
                LoadData();
            }
        }

        private void Baocaodoanhso_Load(object sender, EventArgs e)
        {
            monthComboBox.DataSource = CultureInfo.InvariantCulture.DateTimeFormat.MonthNames.Take(12).ToList();
            monthComboBox.SelectedItem = CultureInfo.InvariantCulture.DateTimeFormat.MonthNames[DateTime.Now.AddMonths(-1).Month];
            yearComboBox.DataSource = Enumerable.Range(2010, DateTime.Now.Year - 2010 + 1).ToList();
            yearComboBox.SelectedItem = DateTime.Now.Year;     
        }

        private void Baocaodoanhso_VisibleChanged(object sender, EventArgs e)
        {
            monthComboBox.SelectedItem = null;
            yearComboBox.SelectedItem = null;
            dataGridViewBaoCaoDoanhSo.Rows.Clear();
            
        }
    }
}
