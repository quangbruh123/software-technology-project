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
        private void buttonplus_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(i,comboBoxvattuphutung.Text,textBoxsoluong.Text, comboBoxTiencong.Text);
            i++;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.SelectedRows.Count;
            if (dataGridView1.SelectedRows.Count > 1)
            {
                for (int i = 0; i < count; i++)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
            if (dataGridView1.SelectedRows.Count == 1)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
         
        }
    }
}
