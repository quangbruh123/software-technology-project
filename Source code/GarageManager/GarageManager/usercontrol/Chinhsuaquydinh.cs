using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GarageManager.Classes;

namespace GarageManager.usercontrol
{
    public partial class Chinhsuaquydinh : UserControl
    {
        public Chinhsuaquydinh()
        {
            InitializeComponent();
        }

        private void txtBoxSoXeSuaChuaToiDa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnCapNhatSoXeSuaToiDa_Click(object sender, EventArgs e)
        {
            Regulation.ChangeVehicleLimitPerDay(int.Parse(txtBoxSoXeSuaChuaToiDa.Text));
            dataGridViewQuyDinhHienHanh.Rows.Clear();
            var quydinh = DataProvider.Instance.DB.THAMSOes;
            foreach(var item in quydinh)
            {
                dataGridViewQuyDinhHienHanh.Rows.Add(item.SoSuaChua, item.TienNo);
            }
        }

        private void buttonLamMoiQuyDinh_Click(object sender, EventArgs e)
        {
            dataGridViewQuyDinhHienHanh.Rows.Clear();
            var quydinh = DataProvider.Instance.DB.THAMSOes;
            foreach (var item in quydinh)
            {
                dataGridViewQuyDinhHienHanh.Rows.Add(item.SoSuaChua, item.TienNo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Regulation.ChangePaymentRule(true);
                dataGridViewQuyDinhHienHanh.Rows.Clear();
                var quydinh = DataProvider.Instance.DB.THAMSOes;
                foreach (var item in quydinh)
                {
                    dataGridViewQuyDinhHienHanh.Rows.Add(item.SoSuaChua, item.TienNo);
                }
            }
            else
            {
                Regulation.ChangePaymentRule(false);
                dataGridViewQuyDinhHienHanh.Rows.Clear();
                var quydinh = DataProvider.Instance.DB.THAMSOes;
                foreach (var item in quydinh)
                {
                    dataGridViewQuyDinhHienHanh.Rows.Add(item.SoSuaChua, item.TienNo);
                }
            }
        }
    }
}
