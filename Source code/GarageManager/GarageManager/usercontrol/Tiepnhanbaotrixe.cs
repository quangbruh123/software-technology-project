﻿using System;
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
    public partial class Tiepnhanbaotrixe : UserControl
    {
        public Tiepnhanbaotrixe()
        {
            InitializeComponent();
        }

        private void Tiepnhanbaotrixe_Load(object sender, EventArgs e)
        {
            foreach (string brand in Classes.DataProvider.Instance.DB.HIEUXEs.Select(x => x.TenHieuXe))
            {
                comboBoxHieuXe.Items.Add(brand);
            }

            dataGridViewXeDaTiepNhan.Rows.Clear();
            var renewTable = Classes.DataProvider.Instance.DB.XEs.ToList();
            foreach (var item in renewTable)
            {
                dataGridViewXeDaTiepNhan.Rows.Add(item.BienSo, item.HIEUXE.TenHieuXe, item.TenChuXe, item.NgayTiepNhan, (int)item.TienNo + " VND");
            }
        }

        private void buttonThemXe_Click(object sender, EventArgs e)
        {
            if (
                String.IsNullOrEmpty(txtBoxTenKH.Text) ||
                String.IsNullOrEmpty(txtBoxDienThoai.Text) ||
                String.IsNullOrEmpty(txtBoxDiaChi.Text) ||
                String.IsNullOrEmpty(txtBoxBienSo.Text) ||
                String.IsNullOrEmpty(txtboxEmail.Text) ||
                comboBoxHieuXe.SelectedIndex == -1
                )
            {
                MessageBox.Show("Thông tin chưa được điền đầy đủ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Classes.ValidateEmail.EmailIsValid(txtboxEmail.Text) == false)
            {
                MessageBox.Show("Email được nhập không đúng cú pháp", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Classes.Vehicle.AddVehicle(txtBoxBienSo.Text, txtBoxTenKH.Text, comboBoxHieuXe.Text, txtBoxDienThoai.Text, txtBoxDiaChi.Text, txtboxEmail.Text, DateTime.Now);
                dataGridViewXeDaTiepNhan.Rows.Clear();
                var renewTable = Classes.DataProvider.Instance.DB.XEs.ToList();
                foreach (var item in renewTable)
                {
                    dataGridViewXeDaTiepNhan.Rows.Add(item.BienSo, item.HIEUXE.TenHieuXe, item.TenChuXe, item.NgayTiepNhan, (int)item.TienNo + " VND");
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtBoxTenKH.Clear();
            txtBoxDienThoai.Clear();
            txtBoxDiaChi.Clear();
            txtBoxBienSo.Clear();
            txtboxEmail.Clear();
            comboBoxHieuXe.Items.Clear();
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            dataGridViewXeDaTiepNhan.Rows.Clear();
            var renewTable = Classes.DataProvider.Instance.DB.XEs.ToList();
            foreach (var item in renewTable)
            {
                dataGridViewXeDaTiepNhan.Rows.Add(item.BienSo, item.HIEUXE.TenHieuXe, item.TenChuXe, item.NgayTiepNhan, (int)item.TienNo + " VND");
            }
        }

        private void txtBoxDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Tiepnhanbaotrixe_VisibleChanged(object sender, EventArgs e)
        {
            txtBoxTenKH.Clear();
            txtBoxDienThoai.Clear();
            txtBoxDiaChi.Clear();
            txtBoxBienSo.Clear();
            txtboxEmail.Clear();
            comboBoxHieuXe.Items.Clear();

            foreach (string brand in Classes.DataProvider.Instance.DB.HIEUXEs.Select(x => x.TenHieuXe))
            {
                comboBoxHieuXe.Items.Add(brand);
            }
        }
    }
}
