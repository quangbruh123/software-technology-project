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
    public partial class Baocaoton : UserControl
    {
        private int month;
        private int year;
        public Baocaoton()
        {
            InitializeComponent();
        }

        private void Baocaoton_Load(object sender, EventArgs e)
        {

        }

        private void getFinancialReportButton_Click(object sender, EventArgs e)
        {
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

        private void LoadData()
        {
            /////
        }
    }
}
