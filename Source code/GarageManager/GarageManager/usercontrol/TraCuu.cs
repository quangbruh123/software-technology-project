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
    public partial class TraCuu : UserControl
    {
        private static tracuuUserControl1 tc1;
        private static TraCuuChiTiet tcct;
        public TraCuu()
        {
            InitializeComponent();
            tc1 = new tracuuUserControl1();
            tcct = new TraCuuChiTiet();
            Controls.Add(tc1);
            Controls.Add(tcct);
            LoadTraCuuUserControl();
        }

        public void LoadTraCuuUserControl()
        {
            tc1.Show();
            tcct.Hide();
        }

        public void LoadTraCuuChiTiet(Model.XE xe)
        {
            tc1.Hide();
            tcct.Show();
            tcct.LoadChitiet(xe);
        }
    }
}
