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
    public partial class Baocaothang : UserControl
    {
        public Baocaothang()
        {
            InitializeComponent();
        }
        private Baocaodoanhso uc1;
        private Baocaoton uc2;


        

        private void Baocaothang_Load(object sender, EventArgs e)
        {
            uc1 = new Baocaodoanhso();
            Controls.Add(uc1);
            uc2 = new Baocaoton();
            Controls.Add(uc2);
            uc1.Visible = false;
            uc2.Visible = false;
        }
        private void baocaodoanhsobtn_Click(object sender, EventArgs e)
        {
            uc1.Visible = true;
            uc2.Visible = false;
            uc1.Location = new Point(0, 156);
        }
        private void baocaotonbtn_Click(object sender, EventArgs e)
        {
            uc1.Visible = false;
            uc2.Visible = true;
            uc2.Location = new Point(0, 156);
        }

        private void Baocaothang_VisibleChanged(object sender, EventArgs e)
        {
            uc1.Visible = false;
            uc2.Visible = false;
        }
    }
}
