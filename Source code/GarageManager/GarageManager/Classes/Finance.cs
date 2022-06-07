using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static bool AddReceipt(string plate, decimal pay)
        {
            Model.XE vehicle = DataProvider.Instance.DB.XEs.Where(x => x.BienSo == plate).FirstOrDefault();
            if (vehicle != null && vehicle.TienNo >= pay)
            {
                Model.PHIEUTHUTIEN receipt = new Model.PHIEUTHUTIEN()
                {
                    BienSo = plate,
                    SoTienThu = pay
                };
                DataProvider.Instance.DB.PHIEUTHUTIENs.Add(receipt);
                vehicle.PHIEUTHUTIENs.Add(receipt);
                vehicle.TienNo -= pay;
                DataProvider.Instance.DB.SaveChanges();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Get full information of a receipt from a plate
        /// </summary>
        /// <param name="plate"></param>
        /// <returns>The vehicle's information and a list of its receipts, or null if the vehicle doesn't exist in the databse</returns>
        public static dynamic GetReceiptInfo(string plate)
        {
            Model.XE vehicle = DataProvider.Instance.DB.XEs.Where(x => x.BienSo == plate).FirstOrDefault();
            List<Model.PHIEUTHUTIEN> receipt = DataProvider.Instance.DB.PHIEUTHUTIENs.Where(x => x.BienSo == plate).ToList();
            if (vehicle != null && receipt != null)
                return new { vehicle, receipt };
            else
                return null;
        }

        /// <summary>
        /// Add a new type of wage. The name of it must not have existed in the database
        /// </summary>
        /// <param name="newWageName"></param>
        /// <param name="newWageAmount"></param>
        /// <returns>True if successfully added, false if not</returns>
        public static bool AddWageType(string newWageName, decimal newWageAmount)
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
        /// Remove a wage type. The wage type must have existed in the database
        /// </summary>
        /// <param name="wageName"></param>
        /// <returns>True if successfully removed, false if not</returns>
        public static bool RemoveWageType(string wageName)
        {           
            if (DataProvider.Instance.DB.TIENCONGs.Any(x => x.TenTienCong == wageName))
            {
                Model.TIENCONG unwantedWage = DataProvider.Instance.DB.TIENCONGs.Where(x => x.TenTienCong == wageName).FirstOrDefault();
                DataProvider.Instance.DB.TIENCONGs.Remove(unwantedWage);
                DataProvider.Instance.DB.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public static int GetWage(string wageName)
        {
            return (int)DataProvider.Instance.DB.TIENCONGs.FirstOrDefault(x => x.TenTienCong == wageName).GiaTienCong;
        }

        public static Model.BAOCAODOANHSO GetMonthlyFinancialReport(int month, int year)
        {
            Model.BAOCAODOANHSO financialReport = DataProvider.Instance.DB.BAOCAODOANHSOes.FirstOrDefault(x => x.Thang == month && x.Nam == year);
            if (financialReport != null)
            {
                return financialReport;
            }
            else
            {
                financialReport = new Model.BAOCAODOANHSO();
                List<Model.HIEUXE> vehicleBrands = DataProvider.Instance.DB.HIEUXEs.ToList();
                List<Model.CT_BCDS> reportDetailsList = new List<Model.CT_BCDS>();
                List<Model.XE> vehicles = DataProvider.Instance.DB.XEs.Where(x => SqlFunctions.DatePart("month", x.NgayTiepNhan) == month
                                                                               && SqlFunctions.DatePart("year", x.NgayTiepNhan) == year).ToList();

                foreach (var vehicleBrand in DataProvider.Instance.DB.HIEUXEs)
                {
                    Model.CT_BCDS reportDetail = new Model.CT_BCDS
                    {
                        MaHieuXe = vehicleBrand.MaHieuXe,
                        HIEUXE = vehicleBrand
                    };
                    reportDetailsList.Add(reportDetail);
                }
                //for (int i = 0; i < vehicleBrands.Count; i++)
                //{
                //    Model.CT_BCDS reportDetail = new Model.CT_BCDS
                //    {
                //        MaHieuXe = vehicleBrands[i].MaHieuXe,
                //        HIEUXE = vehicleBrands[i]
                //    };
                //    reportDetailsList.Add(reportDetail);
                //}
                for (int i = 0; i < vehicles.Count(); i++)
                {
                    for (int j = 0; j < reportDetailsList.Count; j++)
                    {
                        if (vehicles[i].HIEUXE == reportDetailsList[j].HIEUXE)
                        {
                            foreach (var receipt in vehicles[i].PHIEUTHUTIENs)
                            {
                                reportDetailsList[i].ThanhTien += receipt.SoTienThu;
                            }
                        }
                    }
                }
                for (int i = 0; i < reportDetailsList.Count; i++)
                {
                    reportDetailsList[i].TiLe = (reportDetailsList[i].ThanhTien / vehicleBrands.Count * 100).ToString();
                }

                financialReport.CT_BCDS = reportDetailsList;
                financialReport.Thang = month;
                financialReport.Nam = year;
                for (int i = 0; i < reportDetailsList.Count; i++)
                {
                    financialReport.TongDoanhThu += reportDetailsList[i].ThanhTien;
                }

                DataProvider.Instance.DB.BAOCAODOANHSOes.Add(financialReport);
                DataProvider.Instance.DB.CT_BCDS.AddRange(reportDetailsList);
                DataProvider.Instance.DB.SaveChanges();

                return financialReport;
            }
        }
    }
}
