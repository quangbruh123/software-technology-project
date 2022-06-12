using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageManager.usercontrol
{
    public partial class Baocaoton : UserControl
    {
        public Baocaoton()
        {
            InitializeComponent();
        }

        private void Baocaoton_Load(object sender, EventArgs e)
        {           

        }

        private void yearComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void monthComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void getStorageReportButton_Click(object sender, EventArgs e)
        {
            int itemCounter = 1;
            dataGridViewStorageReport.Rows.Clear();
            List<Model.BAOCAOTON> storageReportList = Classes.Storage
                .GetMonthlyStorageReport(int.Parse(monthComboBox.GetItemText(monthComboBox.SelectedItem)), int.Parse(yearComboBox.GetItemText(yearComboBox.SelectedItem)));
            if (storageReportList != null)
            {
                foreach (var report in storageReportList)
                {
                    dataGridViewStorageReport.Rows.Add(itemCounter, report.VATTU.TenVatTu, report.TonDau, report.PhatSinh, report.TonCuoi);
                    itemCounter++;
                }
            }
            else
            {
                MessageBox.Show("Không có báo cáo tồn cho tháng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Baocaoton_VisibleChanged(object sender, EventArgs e)
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

            int itemCounter = 1;
            dataGridViewStorageReport.Rows.Clear();
            int month = int.Parse(monthComboBox.GetItemText(monthComboBox.SelectedItem));
            int year = int.Parse(yearComboBox.GetItemText(yearComboBox.SelectedItem));
            List<Model.BAOCAOTON> storageReportList = Classes.DataProvider.Instance.DB.BAOCAOTONs.Where(x => x.Thang == month && x.Nam == year).ToList();
            foreach (var report in storageReportList)
            {
                dataGridViewStorageReport.Rows.Add(itemCounter, report.VATTU.TenVatTu, report.TonDau, report.PhatSinh, report.TonCuoi);
                itemCounter++;
            }
        }
    }
}
