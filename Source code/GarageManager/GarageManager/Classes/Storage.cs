﻿using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.Classes
{
    /// <summary>
    /// Handles operations related to storage managing
    /// </summary>
    public class Storage
    {
        /// <summary>
        /// Add a new vehicle part. The part must have not existed in the database
        /// </summary>
        /// <param name="newPartName"></param>
        /// <param name="originalValue"></param>
        /// <param name="priceTag"></param>
        /// <param name="amount"></param>
        /// <returns>True if successfully added, false if not</returns>
        //public static bool AddNewPart(string newPartName, decimal originalValue, decimal priceTag, int amount)
        //{
        //    if (!DataProvider.Instance.DB.VATTUs.Any(x => x.TenVatTu == newPartName))
        //    {
        //        Model.CT_PNVT ct_pnvt = new Model.CT_PNVT
        //        {
        //            MaVatTu = GetPartID(newPartName),
        //            DonGiaNhap = originalValue,
        //            DonGiaBan = priceTag,
        //            SoLuong = amount,
        //            ThanhTien = originalValue * amount
        //        };                
        //        DataProvider.Instance.DB.CT_PNVT.Add(ct_pnvt);
        //        DataProvider.Instance.DB.SaveChanges();

        //        Model.VATTU part = new Model.VATTU
        //        {
        //            TenVatTu = newPartName,
        //            SoLuongTon = amount,
        //            DonGiaHienTai = priceTag
        //        };
        //        part.CT_PNVT.Add(ct_pnvt);
        //        DataProvider.Instance.DB.VATTUs.Add(part);
        //        DataProvider.Instance.DB.SaveChanges();

        //        return true;
        //    }
        //    else
        //        return false;
        //}

        /// <summary>
        /// Add to an existing vehicle part. The part must have existed in the database
        /// </summary>
        /// <param name="partName"></param>
        /// <param name="originalValue"></param>
        /// <param name="priceTag"></param>
        /// <param name="amount"></param>
        /// <returns>True if successfully added, false if not</returns>
        //public static bool AddExistingPart(string partName, decimal originalValue, decimal priceTag, int amount)
        //{
        //    if (DataProvider.Instance.DB.VATTUs.Any(x => x.TenVatTu == partName))
        //    {
        //        Model.CT_PNVT ct_pnvt = new Model.CT_PNVT
        //        {
        //            MaVatTu = GetPartID(partName),
        //            DonGiaNhap = originalValue,
        //            DonGiaBan = priceTag,
        //            SoLuong = amount,
        //            ThanhTien = originalValue * amount
        //        };
        //        DataProvider.Instance.DB.CT_PNVT.Add(ct_pnvt);
        //        DataProvider.Instance.DB.SaveChanges();

        //        Model.VATTU part = DataProvider.Instance.DB.VATTUs.Where(x => x.TenVatTu == partName).FirstOrDefault();
        //        part.SoLuongTon += amount;
        //        part.CT_PNVT.Add(ct_pnvt);
        //        part.DonGiaHienTai = priceTag;
        //        DataProvider.Instance.DB.SaveChanges();

        //        return true;
        //    }
        //    else
        //        return false;
        //}

        /// <summary>
        /// Remove a vehicle part. The part must exists in the database
        /// </summary>
        /// <param name="partName"></param>
        /// <returns>True if successfullt removed, false if not</returns>
        public static bool RemovePart(string partName)
        {
            if (DataProvider.Instance.DB.VATTUs.Any(x => x.TenVatTu == partName))
            {
                Model.VATTU unwantedPart = DataProvider.Instance.DB.VATTUs.Where(x => x.TenVatTu == partName).FirstOrDefault();
                DataProvider.Instance.DB.VATTUs.Remove(unwantedPart);
                DataProvider.Instance.DB.SaveChanges();
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Update the price of a part. The part must exist in the database
        /// </summary>
        /// <param name="partName"></param>
        /// <param name="partNewPrice"></param>
        /// <returns>True if successfully updated, false if not</returns>
        public static bool UpdatePartPrice(string partName, decimal partNewPrice)
        {
            if (DataProvider.Instance.DB.VATTUs.Any(x => x.TenVatTu == partName))
            {
                Model.VATTU part = DataProvider.Instance.DB.VATTUs.Where(x => x.TenVatTu == partName).FirstOrDefault();
                part.DonGiaHienTai = partNewPrice;
                DataProvider.Instance.DB.SaveChanges();
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Update the amount of a vehicle part. The part must have existed in the database
        /// </summary>
        /// <param name="partName"></param>
        /// <param name="newAmount"></param>
        /// <returns>True if successfully added, false if not</returns>
        public static bool UpdatePartAmount(string partName, int newAmount)
        {
            if (DataProvider.Instance.DB.VATTUs.Any(x => x.TenVatTu == partName))
            {
                Model.VATTU part = DataProvider.Instance.DB.VATTUs.Where(x => x.TenVatTu == partName).FirstOrDefault();
                part.SoLuongTon = newAmount;
                DataProvider.Instance.DB.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public static decimal? GetPartPrice(string partName)
        {
            return DataProvider.Instance.DB.VATTUs.FirstOrDefault(x => x.TenVatTu == partName).DonGiaHienTai;
        }

        public static List<Model.VATTU> GetAllParts()
        {
            return DataProvider.Instance.DB.VATTUs.ToList();
        }

        /// <summary>
        /// Create and save a part input card
        /// </summary>
        /// <param name="partNamesList"></param>
        /// <param name="amountList"></param>
        /// <param name="originalValuesList"></param>
        /// <param name="priceTagsList"></param>
        /// <param name="inputDate"></param>
        public static void AddPartInputCard(List<string> partNamesList, List<int> amountList, List<int> originalValuesList, List<int> priceTagsList, DateTime inputDate)
        {
            Model.PHIEUNHAPVATTU partInputCard = new Model.PHIEUNHAPVATTU()
            {
                NgayNhap = inputDate,
                TongTien = 0
            };
            List<Model.CT_PNVT> partInputInfoesList = new List<Model.CT_PNVT>();
            for (int i = 0; i < partNamesList.Count; i++)
            {                
                string partName = partNamesList[i];                              
                if (DataProvider.Instance.DB.VATTUs.Any(x => x.TenVatTu == partName))
                {
                    Model.VATTU part = DataProvider.Instance.DB.VATTUs.FirstOrDefault(x => x.TenVatTu == partName);
                    Model.CT_PNVT partInputInfo = new Model.CT_PNVT()
                    {
                        MaVatTu = part.MaVatTu,
                        SoLuong = amountList[i],
                        DonGiaNhap = originalValuesList[i],
                        DonGiaBan = priceTagsList[i],
                        ThanhTien = originalValuesList[i] * amountList[i],
                        VATTU = part
                    };
                    partInputInfoesList.Add(partInputInfo);
                    part.DonGiaHienTai = priceTagsList[i];
                    partInputCard.CT_PNVT.Add(partInputInfo);
                    partInputCard.TongTien += partInputInfo.ThanhTien;
                    partInputInfo.PHIEUNHAPVATTU = partInputCard;
                    Model.BAOCAOTON storageReport = DataProvider.Instance.DB.BAOCAOTONs
                        .FirstOrDefault(x => x.Thang == inputDate.Month && x.Nam == inputDate.Year && x.VATTU == part);
                    storageReport.PhatSinh += amountList[i];
                    storageReport.TonCuoi += amountList[i];
                    DataProvider.Instance.DB.SaveChanges();
                }
                else
                {
                    Model.VATTU part = new Model.VATTU()
                    {
                        TenVatTu = partNamesList[i],
                        DonGiaHienTai = priceTagsList[i],
                        SoLuongTon = amountList[i]
                    };
                    DataProvider.Instance.DB.VATTUs.Add(part);
                    DataProvider.Instance.DB.SaveChanges();
                    Model.CT_PNVT partInputInfo = new Model.CT_PNVT()
                    {
                        MaVatTu = part.MaVatTu,
                        SoLuong = amountList[i],
                        DonGiaNhap = originalValuesList[i],
                        DonGiaBan = priceTagsList[i],
                        ThanhTien = originalValuesList[i] * amountList[i]
                    };
                    partInputInfoesList.Add(partInputInfo);
                    partInputCard.CT_PNVT.Add(partInputInfo);
                    partInputCard.TongTien += partInputInfo.ThanhTien;
                    partInputInfo.PHIEUNHAPVATTU = partInputCard;
                    Model.BAOCAOTON storageReport = new Model.BAOCAOTON()
                    {
                        Thang = inputDate.Month,
                        Nam = inputDate.Year,
                        TonDau = 0,
                        PhatSinh = amountList[i],
                        TonCuoi = amountList[i],
                        VATTU = part
                    };
                    DataProvider.Instance.DB.BAOCAOTONs.Add(storageReport);
                    DataProvider.Instance.DB.SaveChanges();
                }
            }
            DataProvider.Instance.DB.PHIEUNHAPVATTUs.Add(partInputCard);
            DataProvider.Instance.DB.CT_PNVT.AddRange(partInputInfoesList);
            DataProvider.Instance.DB.SaveChanges();
        }

        /// <summary>
        /// Get storage reports for each parts a specific month
        /// </summary>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns>A list of storage reports according to each parts in the database</returns>
        public List<Model.BAOCAOTON> GetMonthlyStorageReport(int month, int year)
        {
            return DataProvider.Instance.DB.BAOCAOTONs.Where(x => x.Thang == month && x.Nam == year).ToList();
        }

        public static void NewStorageReports(int month, int year)
        {
            List<Model.BAOCAOTON> storageReportList = new List<Model.BAOCAOTON>();
            foreach (var part in DataProvider.Instance.DB.VATTUs)
            {
                Model.BAOCAOTON storageReport = new Model.BAOCAOTON()
                {
                    MaVatTu = part.MaVatTu,
                    Thang = month,
                    Nam = year,
                    TonDau = part.SoLuongTon,
                    PhatSinh = 0,
                    TonCuoi = part.SoLuongTon,
                    VATTU = part
                };
                storageReportList.Add(storageReport);
            }
            DataProvider.Instance.DB.BAOCAOTONs.AddRange(storageReportList);
            DataProvider.Instance.DB.SaveChanges();
        }
    }
}
