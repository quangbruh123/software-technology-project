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
    public partial class TraCuuChiTiet : UserControl
    {
        public TraCuuChiTiet()
        {
            InitializeComponent();
        }

        private tracuuUserControl1 uc1;

        private void button1_Click(object sender, EventArgs e)
        {
            TraCuu tracuu = (TraCuu)Parent;
            tracuu.LoadTraCuuUserControl();
        }
    }
}
