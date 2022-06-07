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
    public partial class Tiepnhanbaotrixe : UserControl
    {
        public Tiepnhanbaotrixe()
        {
            InitializeComponent();
        }

        private void Tiepnhanbaotrixe_Load(object sender, EventArgs e)
        {
            foreach (string brand in Classes.DataProvider.Instance.DB.HIEUXEs.Select(x => x.TenHieuXe))
            {
                comboBoxHieuXe.Items.Add(brand);
            }
        }

        private void buttonThemXe_Click(object sender, EventArgs e)
        {
            Classes.Vehicle.AddVehicle(txtBoxBienSo.Text, txtBoxTenKH.Text, comboBoxHieuXe.GetItemText(comboBoxHieuXe.SelectedItem), txtBoxDienThoai.Text, txtBoxDiaChi.Text, "test@gmail.com", DateTime.Now);
        }
    }
}
