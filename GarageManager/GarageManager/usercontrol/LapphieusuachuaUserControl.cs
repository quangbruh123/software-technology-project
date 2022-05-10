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
        public LapphieusuachuaUserControl()
        {
            InitializeComponent();
        }

        // Only number in text box ( So luong )
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;

            if (!double.TryParse(textBox1.Text, out parsedValue))
            {
                textBox1.Text = "";
            }
        }

        // Only number in text box ( Tien cong )
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            double parsedValue;

            if (!double.TryParse(textBox1.Text, out parsedValue))
            {
                textBox1.Text = "";
            }
        }
    }
}
