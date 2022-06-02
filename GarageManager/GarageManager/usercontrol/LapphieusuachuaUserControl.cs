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
        private int itemCounter = 1;

        public LapphieusuachuaUserControl()
        {
            InitializeComponent();
        }
        
        private void buttonplus_Click(object sender, EventArgs e)
        {
            bool isNumber = int.TryParse(textBoxsoluong.Text, out int res);
            if (isNumber && comboBoxvattuphutung.SelectedIndex != 0 && comboBoxTiencong.SelectedIndex != 0)
            {
                int partPrice = (int)Storage.GetPartPrice(comboBoxvattuphutung.Text);
                dataGridView1.Rows.Add(
                    itemCounter,
                    comboBoxvattuphutung.GetItemText(comboBoxvattuphutung.SelectedItem),
                    textBoxsoluong.Text,
                    partPrice,
                    comboBoxTiencong.GetItemText(comboBoxTiencong.SelectedItem),
                    partPrice * int.Parse(textBoxsoluong.Text) + Finance.GetWage(textBoxsoluong.Text));
                itemCounter++;
            }
            else
            {
                MessageBox.Show("Có giá trị không hợp lệ trong ô điền");
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
            int count = dataGridView1.SelectedRows.Count;
            itemCounter--;
            if (dataGridView1.SelectedRows.Count > 1)
            {
                for (int j = 0; j < count; j++)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    dataGridView1.Rows[j].Cells[0].Value = j + 1;
                }
            }
            if (dataGridView1.SelectedRows.Count == 1)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    dataGridView1.Rows[j].Cells[0].Value = j + 1;
                }
            }
        }

        private void btnLuuPSC_Click(object sender, EventArgs e)
        {
            List<string> detail = new List<string>();
            List<string> parts = new List<string>();
            List<string> wage = new List<string>();
            List<int> amount = new List<int>();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                detail.Add(dataGridView1.Rows[i].Cells[1].ToString());
                parts.Add(dataGridView1.Rows[i].Cells[2].ToString());
                amount.Add(int.Parse(dataGridView1.Rows[i].Cells[3].ToString()));
                wage.Add(dataGridView1.Rows[i].Cells[5].ToString());
            }
            if (Vehicle.AddMaintenanceInfo(licenseplatetxt.Text, DateTime.Today, detail, wage, parts, amount))
            {
                MessageBox.Show("Lưu phiếu sửa chữa thành công");
            }
            else
            {
                MessageBox.Show("Không lưu được phiếu sửa chữa");
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
