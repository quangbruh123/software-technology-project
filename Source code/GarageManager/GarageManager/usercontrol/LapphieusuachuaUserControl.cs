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
    public partial class LapphieusuachuaUserControl : UserControl
    {
        private int itemCounter = 0;
        private int total = 0;

        public LapphieusuachuaUserControl()
        {
            InitializeComponent();
        }
        
        private void buttonplus_Click(object sender, EventArgs e)
        {
            bool isNumber = int.TryParse(textBoxsoluong.Text, out int res);
            if (isNumber && comboBoxvattuphutung.SelectedIndex > -1 && comboBoxTiencong.SelectedIndex > -1)
            {
                itemCounter++;
                int partPrice = (int)Storage.GetPartPrice(comboBoxvattuphutung.Text);
                int totalForAFix = partPrice * int.Parse(textBoxsoluong.Text) + Finance.GetWage(comboBoxTiencong.GetItemText(comboBoxTiencong.SelectedItem));
                dataGridView1.Rows.Add(
                    itemCounter,
                    textBoxDetails.Text,
                    comboBoxvattuphutung.GetItemText(comboBoxvattuphutung.SelectedItem),
                    textBoxsoluong.Text,
                    partPrice,
                    comboBoxTiencong.GetItemText(comboBoxTiencong.SelectedItem),
                    totalForAFix);
                total += totalForAFix;
                textBoxTongTienPhieuSuaChua.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Có giá trị không hợp lệ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                itemCounter--;
                total -= (int)dataGridView1.SelectedRows[0].Cells[5].Value;
                textBoxTongTienPhieuSuaChua.Text = total.ToString();
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    dataGridView1.Rows[j].Cells[0].Value = j + 1;
                }
            }
        }

        private void btnLuuPSC_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows != null && dataGridView1.Rows.Count != 0 && !string.IsNullOrEmpty(licenseplatetxt.Text))
            {
                List<string> detail = new List<string>();
                List<string> parts = new List<string>();
                List<string> wage = new List<string>();
                List<int> amount = new List<int>();

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    detail.Add(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    parts.Add(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    amount.Add(int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()));
                    wage.Add(dataGridView1.Rows[i].Cells[5].Value.ToString());
                }
                Vehicle.AddMaintenanceInfo(licenseplatetxt.Text, DateTime.Now, detail, wage, parts, amount);
            }
            else if (dataGridView1.Rows == null && dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có thông tin sửa chữa");
            }
            else if (string.IsNullOrEmpty(licenseplatetxt.Text))
            {
                MessageBox.Show("Biển số không được trống");
            }
        }

        private void LapphieusuachuaUserControl_Load(object sender, EventArgs e)
        {
            foreach (var part in DataProvider.Instance.DB.VATTUs.Select(x => x.TenVatTu))
            {
                comboBoxvattuphutung.Items.Add(part);
            }
            foreach (var wage in DataProvider.Instance.DB.TIENCONGs.Select(x => x.TenTienCong))
            {
                comboBoxTiencong.Items.Add(wage);
            }
            textBox4.Text = DateTime.Today.ToString("dd-MM-yyyy");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            licenseplatetxt.Clear();
        }
    }
}
