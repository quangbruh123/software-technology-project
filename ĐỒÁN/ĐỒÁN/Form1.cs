using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐỒÁN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelsetting.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            lapphieusuachuaUserControl1.Visible = false;    

        }
        private void searchbutton_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.Visible = false;
          
        }

        private void functionbutton_Click(object sender, EventArgs e)
        {
        
            panel3.Visible = false;
            panel2.Visible = true;
        }
        private void lapphieusuachuabutton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panelsetting.Visible=false;
            lapphieusuachuaUserControl1.Visible = true;
        }

        private void tiepnhanbaotrixebutton_Click(object sender, EventArgs e)
        {

        }

        private void lapphieuthutienbutton_Click(object sender, EventArgs e)
        {

        }

        private void lapbaocaothangbutton_Click(object sender, EventArgs e)
        {

        }

        private void baocaodoanhsobutton_Click(object sender, EventArgs e)
        {

        }

        private void baocaotonbutton_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
    }
}
