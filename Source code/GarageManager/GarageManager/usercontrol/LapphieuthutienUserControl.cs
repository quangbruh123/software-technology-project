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
    public partial class LapphieuthutienUserControl : UserControl
    {
        private Bitmap memoryImage;

        public LapphieuthutienUserControl()
        {
            InitializeComponent();
        }

        private void buttonInPhieuThuTienPTT_Click(object sender, EventArgs e)
        {
            buttonLapPhieuThuTienPTT.Visible = false;
            buttonPhieuThuTienMoiPTT.Visible = false;
            buttonInPhieuThuTienPTT.Visible = false;

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

            buttonLapPhieuThuTienPTT.Visible = true;
            buttonPhieuThuTienMoiPTT.Visible = true;
            buttonInPhieuThuTienPTT.Visible = true;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
