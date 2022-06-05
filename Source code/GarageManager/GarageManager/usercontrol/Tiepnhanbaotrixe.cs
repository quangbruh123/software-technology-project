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
    }
}
