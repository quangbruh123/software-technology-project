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
            if (!String.IsNullOrEmpty(txtBoxSoXeSuaChuaToiDa.Text))
            {
                Regulation.ChangeRule("Số xe sửa chữa trong ngày tối đa", int.Parse(txtBoxSoXeSuaChuaToiDa.Text));
                dataGridViewQuyDinhHienHanh.Rows.Clear();
                var quydinh = DataProvider.Instance.DB.THAMSOes;
                foreach (var item in quydinh)
                {
                    dataGridViewQuyDinhHienHanh.Rows.Add(item.TenThamSo, item.GiaTri);
                }
            }
        }

        private void buttonLamMoiQuyDinh_Click(object sender, EventArgs e)
        {
            dataGridViewQuyDinhHienHanh.Rows.Clear();
            var quydinh = DataProvider.Instance.DB.THAMSOes;
            foreach (var item in quydinh)
            {
                dataGridViewQuyDinhHienHanh.Rows.Add(item.TenThamSo, item.GiaTri);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtboxHieuxe_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtboxTienCong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnCapNhatHieuxe_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtboxHieuxe.Text))
            {
                Regulation.ChangeRule("Số lượng hiệu xe", int.Parse(txtboxHieuxe.Text));
                dataGridViewQuyDinhHienHanh.Rows.Clear();
                var quydinh = DataProvider.Instance.DB.THAMSOes;
                foreach (var item in quydinh)
                {
                    dataGridViewQuyDinhHienHanh.Rows.Add(item.TenThamSo, item.GiaTri);
                }
            }
            
        }

        private void btnCapNhatTienCong_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtboxTienCong.Text))
            {
                Regulation.ChangeRule("Số lượng tiền công", int.Parse(txtboxTienCong.Text));
                dataGridViewQuyDinhHienHanh.Rows.Clear();
                var quydinh = DataProvider.Instance.DB.THAMSOes;
                foreach (var item in quydinh)
                {
                    dataGridViewQuyDinhHienHanh.Rows.Add(item.TenThamSo, item.GiaTri);
                }
            }
        }

        private void Chinhsuaquydinh_VisibleChanged(object sender, EventArgs e)
        {
            txtboxHieuxe.Clear();
            txtBoxSoXeSuaChuaToiDa.Clear();
            txtboxTienCong.Clear();
        }
    }
}
