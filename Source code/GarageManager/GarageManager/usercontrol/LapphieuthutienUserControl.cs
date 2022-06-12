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
    public partial class LapphieuthutienUserControl : UserControl
    {
        public LapphieuthutienUserControl()
        {
            InitializeComponent();
        }

        private void buttonLapPhieuThuTienPTT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxHoTenChuXePTT.Text))
            {
                MessageBox.Show("Tên chủ xe không được trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBienSoXe2.SelectedIndex == -1)
            {
                MessageBox.Show("Biển số xe không được trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string plate = comboBienSoXe2.SelectedItem.ToString();
            bool isNumber = int.TryParse(textBoxSoTienThuPTT.Text, out int pay);
            if (isNumber && pay > 0)
            {
                Finance.AddReceipt(plate, pay, dateTimePicker1.Value);
                reset();
            }
            else if (!isNumber)
            {
                MessageBox.Show("Có giá trị không hợp lệ trong số tiền thu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pay <= 0)
            {
                MessageBox.Show("Số tiền thu phải lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxHoTenChuXePTT_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                comboBienSoXe2.Items.Clear();
                foreach (var plates in DataProvider.Instance.DB.XEs.Where(x => x.TenChuXe.Contains(textBoxHoTenChuXePTT.Text)).Select(x => x.BienSo))
                {
                    comboBienSoXe2.Items.Add(plates);
                }
            }
        }

        private void buttonPhieuThuTienMoiPTT_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void LapphieuthutienUserControl_VisibleChanged(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            dateTimePicker1.Value = DateTime.Now;
            textBoxHoTenChuXePTT.Clear();
            textBoxSoTienThuPTT.Clear();
            comboBienSoXe2.Items.Clear();
            comboBienSoXe2.SelectedIndex = -1;
            comboBienSoXe2.SelectedItem = null;

            int itemCounter = 1;
            dataGridView1.Rows.Clear();
            foreach (var vehicle in DataProvider.Instance.DB.XEs
                .Where(x => x.TienNo > 0)
                .OrderByDescending(x => x.NgayTiepNhan)
                .Select(x => new { x.BienSo, x.TenChuXe, x.NgayTiepNhan, x.TienNo })
                .Take(40))
            {
                dataGridView1.Rows.Add(itemCounter, vehicle.BienSo, vehicle.TenChuXe, vehicle.NgayTiepNhan.ToString(), vehicle.TienNo);
                itemCounter++;
            }
        }

        private void textBoxSoTienThuPTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                textBoxHoTenChuXePTT.Text = row.Cells[2].Value.ToString();
                comboBienSoXe2.Items.Clear();
                comboBienSoXe2.Items.Add(row.Cells[1].Value.ToString());
                comboBienSoXe2.SelectedItem = row.Cells[1].Value.ToString();
            }
        }
    }
}
