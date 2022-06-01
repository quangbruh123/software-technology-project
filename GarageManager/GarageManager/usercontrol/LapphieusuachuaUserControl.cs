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
        private Bitmap memoryImage;
        private int i = 1;

        public LapphieusuachuaUserControl()
        {
            InitializeComponent();
        }
        
        private void buttonplus_Click(object sender, EventArgs e)
        {
            int partPrice = (int)Storage.GetPartPrice(comboBoxvattuphutung.Text);
            dataGridView1.Rows.Add(i, comboBoxvattuphutung.Text, textBoxsoluong.Text, partPrice, comboBoxTiencong.Text, partPrice * Int32.Parse(textBoxsoluong.Text) + Finance.GetWage(textBoxsoluong.Text));
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
            i--;
            if (dataGridView1.SelectedRows.Count > 1)
            {
                for (int j = 0; j < count; j++)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    dataGridView1.Rows[j].Cells[0].Value = j + 1;
                }
            }
            if (dataGridView1.SelectedRows.Count == 1)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    dataGridView1.Rows[j].Cells[0].Value = j + 1;
                }
            }
        }

        private void btnInPhieuSuaChua_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            buttonplus.Visible = false;
            btnInPhieuSuaChua.Visible = false;
            btnLuuPSC.Visible = false;

            Graphics myGraphics = CreateGraphics();
            Size s = Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(Location.X, Location.Y, 0, 0, s);
            try
            {
                printDocument1.Print();
            }
            catch (System.Drawing.Printing.InvalidPrinterException)
            {
                MessageBox.Show("Failed to print");
            }

            button1.Visible = true;
            button2.Visible = true;
            buttonplus.Visible = true;
            btnInPhieuSuaChua.Visible = true;
            btnLuuPSC.Visible = true;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void btnLuuPSC_Click(object sender, EventArgs e)
        {

        }

        private void LapphieusuachuaUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
