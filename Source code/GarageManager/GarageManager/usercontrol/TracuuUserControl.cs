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
                        foreach (var x in DataProvider.Instance.DB.XEs.Where(x => x.HIEUXE.TenHieuXe.Contains(brand)))
                        {
                            itemCounter++;
                            dataGridView1.Rows.Add(
                            itemCounter,
                            x.TenChuXe,
                            x.HIEUXE.TenHieuXe,
                            x.BienSo,
                            x.NgayTiepNhan,
                            (int)x.TienNo
                            );
                        }
                    }

                    else if (string.IsNullOrEmpty(CarPlateTextbox.Text) && OwnerTextbox.Text != null)
                    {
                        string brand = comboBoxCarBrand.GetItemText(comboBoxCarBrand.SelectedItem);
                        foreach (var x in DataProvider.Instance.DB.XEs
                            .Where(x => x.HIEUXE.TenHieuXe.Contains(brand) && x.TenChuXe.Contains(OwnerTextbox.Text)))
                        {
                            itemCounter++;
                            dataGridView1.Rows.Add(
                            itemCounter,
                            x.TenChuXe,
                            x.HIEUXE.TenHieuXe,
                            x.BienSo,
                            x.NgayTiepNhan,
                            (int)x.TienNo
                            );
                        }
                    }

                    else if (string.IsNullOrEmpty(OwnerTextbox.Text) && CarPlateTextbox.Text != null)
                    {
                        string brand = comboBoxCarBrand.GetItemText(comboBoxCarBrand.SelectedItem);
                        foreach (var x in DataProvider.Instance.DB.XEs
                            .Where(x => x.HIEUXE.TenHieuXe.Contains(brand) && x.BienSo.Contains(CarPlateTextbox.Text)))
                        {
                            itemCounter++;
                            dataGridView1.Rows.Add(
                            itemCounter,
                            x.TenChuXe,
                            x.HIEUXE.TenHieuXe,
                            x.BienSo,
                            x.NgayTiepNhan,
                            (int)x.TienNo
                            );
                        }
                    }

                    else if (CarPlateTextbox.Text != null && OwnerTextbox.Text != null)
                    {
                        string brand = comboBoxCarBrand.GetItemText(comboBoxCarBrand.SelectedItem);
                        foreach (var x in DataProvider.Instance.DB.XEs
                            .Where(x => x.HIEUXE.TenHieuXe.Contains(brand) && x.TenChuXe.Contains(OwnerTextbox.Text) && x.BienSo.Contains(CarPlateTextbox.Text)))
                        {
                            itemCounter++;
                            dataGridView1.Rows.Add(
                            itemCounter,
                            x.TenChuXe,
                            x.HIEUXE.TenHieuXe,
                            x.BienSo,
                            x.NgayTiepNhan,
                            (int)x.TienNo
                            );
                        }
                    }

                    if (dataGridView1.Rows.Count < 1)
                    {
                        MessageBox.Show("Không có kết quả");
                    }
                    else
                    {
                        MessageBox.Show("Có " + dataGridView1.Rows.Count + " kết quả", "", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    }
                }

                if (MainWordTextbox.Text != null && comboBoxCarBrand.SelectedItem == null)
                {
                    foreach (var x in DataProvider.Instance.DB.XEs
                        .Where(x => x.HIEUXE.TenHieuXe.Contains(MainWordTextbox.Text) || x.TenChuXe.Contains(MainWordTextbox.Text) || x.BienSo.Contains(MainWordTextbox.Text)))
                    {
                        itemCounter++;
                        dataGridView1.Rows.Add(
                        itemCounter,
                        x.TenChuXe,
                        x.HIEUXE.TenHieuXe,
                        x.BienSo,
                        x.NgayTiepNhan,
                        (int)x.TienNo
                        );
                    }

                    if (dataGridView1.Rows.Count < 1)
                    {
                        MessageBox.Show("Không có kết quả");
                    }
                    else
                    {
                        MessageBox.Show("Có " + dataGridView1.Rows.Count + " kết quả", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void reset()
        {
            dataGridView1.Rows.Clear();
            itemCounter = 0;
            MainWordTextbox.Clear();
            OwnerTextbox.Clear();
            CarPlateTextbox.Clear();
            comboBoxCarBrand.SelectedItem = null;
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            reset();

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

        private void tracuuUserControl1_VisibleChanged(object sender, EventArgs e)
        {
            reset();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count < 1 )
            {
                //MessageBox.Show("Chưa có dữ liệu");
            }
            else
            {
                if (MessageBox.Show("Xem chi tiết về thông tin xe?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string bienso;
                    if (dataGridView1.SelectedRows.Count != 0)
                    {
                        bienso = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    }
                    else
                    {
                        bienso = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[3].Value.ToString();
                    }
                    Model.XE xe = DataProvider.Instance.DB.XEs.FirstOrDefault(x => x.BienSo == bienso);
                    TraCuu tracuu = (TraCuu)Parent;
                    tracuu.LoadTraCuuChiTiet(xe);
                }

            }
        }
    }
}
