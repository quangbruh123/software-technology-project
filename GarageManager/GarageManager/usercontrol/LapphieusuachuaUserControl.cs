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
    public partial class LapphieusuachuaUserControl : UserControl
    {

        public LapphieusuachuaUserControl()
        {
            InitializeComponent();
           

        }
        int i =1;
        private void LapphieusuachuaUserControl_Load(object sender, EventArgs e)
        {
       

        }
        private void buttonplus_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(i,textBoxvattuphutung.Text,textBoxsoluong.Text,textBoxtiencong.Text);
            i++;
        }
        private void buttondellte_Click(object sender, EventArgs e)
        {     
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.ShowDialog();
        }
        private UserControldatagrid1 uc4;
        private void buttonnext_Click(object sender, EventArgs e)
        {
        
        uc4 = new UserControldatagrid1();
        Controls.Add(uc4);
        uc4.BringToFront();
            this.buttonnext.Hide();
        }

        private void userControldatagrid11_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvDelRow = dataGridView1.Rows[i];
            dataGridView1.Rows.Remove(dgvDelRow);
            i--;
        }
    }
}
