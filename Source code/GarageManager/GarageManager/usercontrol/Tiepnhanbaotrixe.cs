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
            var renewTable = DataProvider.Instance.DB.XEs
                .Select(x => new { x.BienSo, x.TenChuXe, x.NgayTiepNhan, x.TienNo, x.HIEUXE })
                .OrderByDescending(x => x.NgayTiepNhan)
                .Take(40);
            foreach (var item in renewTable)
            {
                dataGridViewXeDaTiepNhan.Rows.Add(item.BienSo, item.HIEUXE.TenHieuXe, item.TenChuXe, item.NgayTiepNhan, (int)item.TienNo + " VND");
            }

            labelTodayVehicleNum.Text = DataProvider.Instance.DB.THAMSOes.FirstOrDefault(x => x.TenThamSo == "TodayVehicle").GiaTri.ToString()
                + " / " + DataProvider.Instance.DB.THAMSOes.FirstOrDefault(x => x.TenThamSo == "Số xe sửa chữa trong ngày tối đa").GiaTri;
        }

        private void buttonThemXe_Click(object sender, EventArgs e)
        {
            if (DataProvider.Instance.DB.THAMSOes.FirstOrDefault(x => x.TenThamSo == "TodayVehicle").GiaTri
                == DataProvider.Instance.DB.THAMSOes.FirstOrDefault(x => x.TenThamSo == "Số xe sửa chữa trong ngày tối đa").GiaTri)
            {
                MessageBox.Show("Đã quá giới hạn số xe sửa chữa trong một ngày", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (
                string.IsNullOrEmpty(txtBoxTenKH.Text) ||
                string.IsNullOrEmpty(txtBoxBienSo.Text) ||
                comboBoxHieuXe.SelectedIndex == -1
                )
            {
                MessageBox.Show("Thông tin chưa được điền đầy đủ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrEmpty(txtboxEmail.Text) && ValidateEmail.EmailIsValid(txtboxEmail.Text) == false)
            {
                MessageBox.Show("Email được nhập không đúng cú pháp", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (Vehicle.AddVehicle(txtBoxBienSo.Text, txtBoxTenKH.Text, comboBoxHieuXe.Text, txtBoxDienThoai.Text, txtBoxDiaChi.Text, txtboxEmail.Text, DateTime.Now))
            {
                dataGridViewXeDaTiepNhan.Rows.Clear();
                var renewTable = DataProvider.Instance.DB.XEs
                    .Select(x => new { x.BienSo, x.TenChuXe, x.NgayTiepNhan, x.TienNo, x.HIEUXE })
                    .OrderByDescending(x => x.NgayTiepNhan)
                    .Take(40);
                foreach (var item in renewTable)
                {
                    dataGridViewXeDaTiepNhan.Rows.Add(item.BienSo, item.HIEUXE.TenHieuXe, item.TenChuXe, item.NgayTiepNhan, (int)item.TienNo + " VND");
                }
                DataProvider.Instance.DB.THAMSOes.FirstOrDefault(x => x.TenThamSo == "TodayVehicle").GiaTri++;
                DataProvider.Instance.DB.SaveChanges();
                System.Diagnostics.Debug.WriteLine(DataProvider.Instance.DB.THAMSOes.FirstOrDefault(x => x.TenThamSo == "TodayVehicle").GiaTri + " vehicle");
                labelTodayVehicleNum.Text = DataProvider.Instance.DB.THAMSOes.FirstOrDefault(x => x.TenThamSo == "TodayVehicle").GiaTri
                + " / " + DataProvider.Instance.DB.THAMSOes.FirstOrDefault(x => x.TenThamSo == "Số xe sửa chữa trong ngày tối đa").GiaTri;
                MessageBox.Show("Tiếp nhận xe thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tiếp nhận xe thất bại\nĐã có biển số xe vừa nhập trong hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var renewTable = DataProvider.Instance.DB.XEs
                .Select(x => new { x.BienSo, x.TenChuXe, x.NgayTiepNhan, x.TienNo, x.HIEUXE })
                .OrderByDescending(x => x.NgayTiepNhan)
                .Take(40);
            foreach (var item in renewTable)
            {
                dataGridViewXeDaTiepNhan.Rows.Add(item.BienSo, item.HIEUXE.TenHieuXe, item.TenChuXe, item.NgayTiepNhan, (int)item.TienNo + " VND");
            }

            labelTodayVehicleNum.Text = DataProvider.Instance.DB.THAMSOes.FirstOrDefault(x => x.TenThamSo == "TodayVehicle").GiaTri.ToString()
                + " / " + Classes.DataProvider.Instance.DB.THAMSOes.FirstOrDefault(x => x.TenThamSo == "Số xe sửa chữa trong ngày tối đa").GiaTri;
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

        private void pnThemThongTinKHVaXe_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
