using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageManager
{
    public partial class FormDăngNhập : Form
    {
        public FormDăngNhập()
        {
            InitializeComponent();
        }

        private void taotaikhoanbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formtaotaikhoan formtaotaikhoan = new Formtaotaikhoan();
            formtaotaikhoan.ShowDialog();
        }

        private void dangnhapbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(); 
            mainForm.ShowDialog();  
        }
    }
}
