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
    public partial class tracuuUserControl1 : UserControl
    {
        private int itemCounter = 0;

        public tracuuUserControl1()
        {
            InitializeComponent();
        }

        private void tracuuUserControl1_Load(object sender, EventArgs e)
        {
            foreach (var brand in DataProvider.Instance.DB.HIEUXEs.Select(p => p.TenHieuXe))
            {
                comboBoxCarBrand.Items.Add(brand);
            }
            dataGridView1.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";

            radioButton1.Checked = true;
            radioButton2.Checked = false;
        }
      
        private void FindBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            itemCounter = 0;

            if (string.IsNullOrEmpty(MainWordTextbox.Text) && comboBoxCarBrand.SelectedItem == null)
            {
                MessageBox.Show("Có giá trị không hợp lệ");
            }
            else
            {
                if (comboBoxCarBrand.SelectedItem != null && string.IsNullOrEmpty(MainWordTextbox.Text))
                {
                    if (string.IsNullOrEmpty(CarPlateTextbox.Text) && string.IsNullOrEmpty(OwnerTextbox.Text))
                    {
                        string brand = comboBoxCarBrand.GetItemText(comboBoxCarBrand.SelectedItem);
                        foreach (var x in DataProvider.Instance.DB.XEs.Where(x => brand == x.HIEUXE.TenHieuXe))
                        {
                            itemCounter++;
                            dataGridView1.Rows.Add(
                            itemCounter,
                            x.TenChuXe,
                            x.HIEUXE.TenHieuXe,
                            x.BienSo,
                            x.NgayTiepNhan,
                            x.TienNo
                            );
                        }
                    }

                    if (string.IsNullOrEmpty(CarPlateTextbox.Text) && OwnerTextbox.Text != null)
                    {
                        string brand = comboBoxCarBrand.GetItemText(comboBoxCarBrand.SelectedItem);
                        foreach (var x in DataProvider.Instance.DB.XEs
                            .Where(x => brand == x.HIEUXE.TenHieuXe && OwnerTextbox.Text == x.TenChuXe))
                        {
                            itemCounter++;
                            dataGridView1.Rows.Add(
                            itemCounter,
                            x.TenChuXe,
                            x.HIEUXE.TenHieuXe,
                            x.BienSo,
                            x.NgayTiepNhan,
                            x.TienNo
                            );
                        }
                    }

                    if (string.IsNullOrEmpty(OwnerTextbox.Text) && CarPlateTextbox.Text != null)
                    {
                        string brand = comboBoxCarBrand.GetItemText(comboBoxCarBrand.SelectedItem);
                        foreach (var x in DataProvider.Instance.DB.XEs
                            .Where(x => brand == x.HIEUXE.TenHieuXe && CarPlateTextbox.Text == x.BienSo))
                        {
                            itemCounter++;
                            dataGridView1.Rows.Add(
                            itemCounter,
                            x.TenChuXe,
                            x.HIEUXE.TenHieuXe,
                            x.BienSo,
                            x.NgayTiepNhan,
                            x.TienNo
                            );
                        }
                    }

                    if (CarPlateTextbox.Text != null && OwnerTextbox.Text != null)
                    {
                        string brand = comboBoxCarBrand.GetItemText(comboBoxCarBrand.SelectedItem);
                        foreach (var x in DataProvider.Instance.DB.XEs
                            .Where(x => brand == x.HIEUXE.TenHieuXe && OwnerTextbox.Text == x.TenChuXe && CarPlateTextbox.Text == x.BienSo))
                        {
                            itemCounter++;
                            dataGridView1.Rows.Add(
                            itemCounter,
                            x.TenChuXe,
                            x.HIEUXE.TenHieuXe,
                            x.BienSo,
                            x.NgayTiepNhan,
                            x.TienNo
                            );
                        }
                    }

                    if (dataGridView1.Rows.Count < 2)
                    {
                        MessageBox.Show("Không có kết quả");
                    }
                    else
                    {
                        
                    }
                }

                if (MainWordTextbox.Text != null && comboBoxCarBrand.SelectedItem == null)
                {
                    foreach (var x in DataProvider.Instance.DB.XEs
                        .Where(x => MainWordTextbox.Text == x.HIEUXE.TenHieuXe || MainWordTextbox.Text == x.TenChuXe || MainWordTextbox.Text == x.BienSo))
                    {
                        itemCounter++;
                        dataGridView1.Rows.Add(
                        itemCounter,
                        x.TenChuXe,
                            x.HIEUXE.TenHieuXe,
                            x.BienSo,
                            x.NgayTiepNhan,
                            x.TienNo
                        );
                    }

                    if (dataGridView1.Rows.Count < 2)
                    {
                        MessageBox.Show("Không có kết quả");
                    }
                    else
                    {
                        
                    }
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            itemCounter = 0;
            MainWordTextbox.Clear();
            OwnerTextbox.Clear();
            CarPlateTextbox.Clear();
            comboBoxCarBrand.SelectedItem = null;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            itemCounter = 0;
            MainWordTextbox.Clear();
            OwnerTextbox.Clear();
            CarPlateTextbox.Clear();
            comboBoxCarBrand.SelectedItem = null;

            if (radioButton1.Checked == true)
            {
                label1.Visible = true;
                MainWordTextbox.Visible = true;

                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                CarPlateTextbox.Visible = false;
                comboBoxCarBrand.Visible = false;
                OwnerTextbox.Visible = false;
            }
            else
            {
                label1.Visible = false; 
                MainWordTextbox.Visible = false;

                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                CarPlateTextbox.Visible = true;
                comboBoxCarBrand.Visible = true;
                OwnerTextbox.Visible = true;
            }
        }
    }
}
