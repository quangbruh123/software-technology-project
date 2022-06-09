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
            string plate = comboBienSoXe2.SelectedItem.ToString();
            int pay = int.Parse(textBoxSoTienThuPTT.Text);
            DateTime a = DateTime.Now;
            Finance.AddReceipt(plate, pay, a);
        }

        private void textBoxHoTenChuXePTT_TextChanged(object sender, EventArgs e)
        {
            comboBienSoXe2.Items.Clear();
            foreach (var plates in DataProvider.Instance.DB.XEs.Where(x => x.TenChuXe == textBoxHoTenChuXePTT.Text).Select(x => x.BienSo))
            {
                comboBienSoXe2.Items.Add(plates);
            }
        }

        private void LapphieuthutienUserControl_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonPhieuThuTienMoiPTT_Click(object sender, EventArgs e)
        {
            textBoxSoTienThuPTT.Clear();
            textBoxHoTenChuXePTT.Clear();
            comboBienSoXe2.Items.Clear();
            comboBienSoXe2.SelectedIndex = -1;
            textBoxNgayThuTien.Text = DateTime.Now.ToString();
        }

        private void LapphieuthutienUserControl_VisibleChanged(object sender, EventArgs e)
        {
            textBoxNgayThuTien.Text = DateTime.Now.ToShortDateString();
            textBoxHoTenChuXePTT.Text = null;
            comboBienSoXe2.Items.Clear();
            comboBienSoXe2.SelectedIndex = -1;
            comboBienSoXe2.SelectedItem = null;
        }
    }
}
