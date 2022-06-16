using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GarageManager.Classes
{
    /// <summary>
    /// Handles financial operations of the garage
    /// </summary>
    public class Finance
    {
        /// <summary>
        /// Create a receipt for a vehicle after maintenancing. The amount of money customer pays must be lower than the amount said customer owes the garage.
        /// </summary>
        /// <param name="plate"></param>
        /// <returns>True if the pay satisfy the condition, false if not</returns>
        public static void AddReceipt(string plate, long pay, DateTime createDate)
        {
            if (DataProvider.Instance.DB.XEs.Any(x => x.BienSo == plate))
            {
                Model.XE vehicle = DataProvider.Instance.DB.XEs.FirstOrDefault(x => x.BienSo == plate);
                if (createDate.Date.CompareTo(vehicle.NgayTiepNhan.Value.Date) < 0)
                {
                    MessageBox.Show("Ngày lập phiếu không thể bé hơn ngày tiếp nhận", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (vehicle.TienNo >= pay)
                {
                    Model.PHIEUTHUTIEN receipt = new Model.PHIEUTHUTIEN()
                    {
                        BienSo = plate,
                        SoTienThu = pay,
                        NgayLap = createDate,
                        XE = vehicle
                    };
                    DataProvider.Instance.DB.PHIEUTHUTIENs.Add(receipt);
                    vehicle.PHIEUTHUTIENs.Add(receipt);
                    vehicle.TienNo -= pay;

                    if (DataProvider.Instance.DB.BAOCAODOANHSOes.Any(x => x.Thang == createDate.Month && x.Nam == createDate.Year))
                    {
                        Model.BAOCAODOANHSO financialReport = DataProvider.Instance.DB.BAOCAODOANHSOes
                            .FirstOrDefault(x => x.Thang == createDate.Month && x.Nam == createDate.Year);
                        if (financialReport.CT_BCDS.Any(x => x.HIEUXE == vehicle.HIEUXE))
                        {
                            Model.CT_BCDS financialReportDetail = DataProvider.Instance.DB.CT_BCDS
                                .FirstOrDefault(x => x.MaBCDS == financialReport.MaBCDS && x.MaHieuXe == vehicle.MaHieuXe);                          
                            financialReport.TongDoanhThu += receipt.SoTienThu;
                            financialReportDetail.SoLuotSua++;
                            financialReportDetail.ThanhTien += receipt.SoTienThu;
                        }
                        else
                        {
                            financialReport.TongDoanhThu += receipt.SoTienThu;
                            Model.CT_BCDS financialReportDetail = new Model.CT_BCDS()
                            {
                                MaHieuXe = vehicle.HIEUXE.MaHieuXe,
                                SoLuotSua = 1,
                                ThanhTien = receipt.SoTienThu,
                                BAOCAODOANHSO = financialReport,
                                HIEUXE = vehicle.HIEUXE
                            };                                                   
                            financialReport.CT_BCDS.Add(financialReportDetail);
                        }
                    }
                    else
                    {
                        Model.BAOCAODOANHSO financialReport = new Model.BAOCAODOANHSO()
                        {
                            Thang = createDate.Month,
                            Nam = createDate.Year
                        };
                        List<Model.CT_BCDS> reportDetailsList = new List<Model.CT_BCDS>();
                        foreach (var vehicleBrand in DataProvider.Instance.DB.HIEUXEs)
                        {
                            Model.CT_BCDS reportDetail = new Model.CT_BCDS
                            {
                                MaHieuXe = vehicleBrand.MaHieuXe,
                                HIEUXE = vehicleBrand,
                                SoLuotSua = 0,
                                ThanhTien = 0,
                                BAOCAODOANHSO = financialReport
                            };
                            reportDetailsList.Add(reportDetail);
                        }
                        financialReport.CT_BCDS = reportDetailsList;
                    }

                    DataProvider.Instance.DB.SaveChanges();
                    MessageBox.Show("Lập phiếu thu tiền thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Lập phiếu thu tiền thất bại.\nSố tiền thu không được vượt quá số tiền nợ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Lập phiếu thu tiền thất bại.\nKhông tìm thấy xe nào với biển số xe vừa nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// Add a new type of wage. The name of it must not have existed in the database
        /// </summary>
        /// <param name="newWageName"></param>
        /// <param name="newWageAmount"></param>
        /// <returns>True if successfully added, false if not</returns>
        public static bool AddWageType(string newWageName, long newWageAmount)
        {
            if (!DataProvider.Instance.DB.TIENCONGs.Any(x => x.TenTienCong == newWageName))
            {
                Model.TIENCONG newWage = new Model.TIENCONG()
                {
                    TenTienCong = newWageName,
                    GiaTienCong = newWageAmount
                };
                DataProvider.Instance.DB.TIENCONGs.Add(newWage);
                DataProvider.Instance.DB.SaveChanges();
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Update the price of a wage. The wage must have existed in the database
        /// </summary>
        /// <param name="wageName"></param>
        /// <param name="wagePrice"></param>
        /// <returns>True if successfully added, false if not</returns>
        public static bool UpdateWagePrice(string wageName, int wagePrice)
        {            
            if (DataProvider.Instance.DB.TIENCONGs.Any(x => x.TenTienCong == wageName))
            {
                Model.TIENCONG wage = DataProvider.Instance.DB.TIENCONGs.FirstOrDefault(x => x.TenTienCong == wageName);
                wage.GiaTienCong = wagePrice;
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Get the price of a wage from its name
        /// </summary>
        /// <param name="wageName"></param>
        /// <returns>The price of the wage</returns>
        public static long GetWage(string wageName)
        {
            return (long)DataProvider.Instance.DB.TIENCONGs.FirstOrDefault(x => x.TenTienCong == wageName).GiaTienCong;
        }

        public static void NewMonthlyFinancialReport(int month, int year)
        {
            if (!DataProvider.Instance.DB.BAOCAODOANHSOes.Any(x => x.Thang == month && x.Nam == year))
            {
                Model.BAOCAODOANHSO financialReport = new Model.BAOCAODOANHSO()
                {
                    Thang = month,
                    Nam = year,
                    TongDoanhThu = 0
                };
                List<Model.CT_BCDS> reportDetailsList = new List<Model.CT_BCDS>();
                foreach (var brand in DataProvider.Instance.DB.HIEUXEs)
                {
                    Model.CT_BCDS reportDetail = new Model.CT_BCDS()
                    {
                        MaHieuXe = brand.MaHieuXe,
                        SoLuotSua = 0,
                        ThanhTien = 0,
                        BAOCAODOANHSO = financialReport,
                        HIEUXE = brand
                    };
                    reportDetailsList.Add(reportDetail);
                }
                financialReport.CT_BCDS = reportDetailsList;
                DataProvider.Instance.DB.BAOCAODOANHSOes.Add(financialReport);
                DataProvider.Instance.DB.CT_BCDS.AddRange(reportDetailsList);
                DataProvider.Instance.DB.SaveChanges();
            }
        }

        public static Model.BAOCAODOANHSO GetMonthlyFinancialReport(int month, int year)
        {           
            if (DataProvider.Instance.DB.BAOCAODOANHSOes.Any(x => x.Thang == month && x.Nam == year))
            {
                return DataProvider.Instance.DB.BAOCAODOANHSOes.FirstOrDefault(x => x.Thang == month && x.Nam == year);
            }
            else
            {
                return null;
            }
        }
    }
}
