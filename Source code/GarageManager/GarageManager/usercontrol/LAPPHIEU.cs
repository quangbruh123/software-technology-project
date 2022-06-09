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
    public partial class LAPPHIEU : UserControl
    {
        public LAPPHIEU()
        {
            InitializeComponent();
        }
        private LapphieuthutienUserControl uc1;
        private Nhapvatu uc2;
        private LapphieusuachuaUserControl uc3;
        private Nhaptiencong uc4;


        private void LAPPHIEU_Load(object sender, EventArgs e)
        {
            uc1 = new LapphieuthutienUserControl();
            Controls.Add(uc1);
            uc2 = new Nhapvatu();
            Controls.Add(uc2);
            uc3 = new LapphieusuachuaUserControl();
            Controls.Add(uc3);
            uc4 = new Nhaptiencong();
            Controls.Add(uc4);
            uc1.Visible = false;
            uc2.Visible = false;
            uc3.Visible = false;
            uc4.Visible = false;
        }
        private void Lapphieusuachuabtn_Click(object sender, EventArgs e)
        {
            uc4.Visible = false;
            uc1.Visible = false;
            uc2.Visible = false;
            uc3.Visible = true;
            uc3.Location = new Point(0, 156);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uc4.Visible = false;
            uc1.Visible = true;
            uc2.Visible = false;
            uc3.Visible = false;
            uc1.Location = new Point(0, 156);
        }

        private void VTPTbtn_Click(object sender, EventArgs e)
        {
            uc4.Visible = false;
            uc1.Visible = false;
            uc2.Visible = true;
            uc3.Visible = false;
            uc2.Location = new Point(0, 156);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            uc4.Visible = true;
            uc1.Visible = false;
            uc2.Visible = false;
            uc3.Visible = false;
            uc4.Location = new Point(0, 156);
        }

        private void LAPPHIEU_VisibleChanged(object sender, EventArgs e)
        {
            uc1.Visible = false;
            uc2.Visible = false;
            uc3.Visible = false;
            uc4.Visible = false;
        }
    }
}
