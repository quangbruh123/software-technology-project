using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.Classes
{
    public class Vehicle
    {
        /// <summary>
        /// Add a vehicle to the garage
        /// </summary>
        /// <param name="plate"></param>
        /// <param name="owner"></param>
        /// <param name="phonenum"></param>
        /// <param name="address"></param>
        /// <param name="email"></param>
        public void AddVehicle(string plate, string owner, string phonenum, string address, string email, DateTime date, int owe)
        {
            Model.XE car = new Model.XE()
            {
                BienSo = plate,
                TenChuXe = owner,
                DienThoai = phonenum,
                DiaChi = address,
                Email = email,
                NgayTiepNhan = date,
                TienNo = owe
            };
            DataProvider.Instance.DB.XEs.Add(car);
            DataProvider.Instance.DB.SaveChanges();
        }

        /// <summary>
        /// Get the ID of a type of wage (service) from its name
        /// </summary>
        /// <param name="wageName"></param>
        /// <returns>The ID</returns>
        private int GetWageId (string wageName)
        {
            Model.TIENCONG wage = new Model.TIENCONG();
            wage = (Model.TIENCONG)DataProvider.Instance.DB.TIENCONGs.Where(x => x.TenTienCong == wageName);
            return wage.MaTienCong;
        }

        private decimal? GetWage (int wageID)
        {
            Model.TIENCONG wage = new Model.TIENCONG();
            wage = (Model.TIENCONG)DataProvider.Instance.DB.TIENCONGs.Where(x => x.MaTienCong == wageID);
            return wage.GiaTienCong;
        }

        /// <summary>
        /// Get the ID of a car part from its name
        /// </summary>
        /// <param name="partsName"></param>
        /// <returns>The ID</returns>
        private int GetPartsID (string partsName)
        {
            Model.VATTU parts = new Model.VATTU();
            parts = (Model.VATTU)DataProvider.Instance.DB.VATTUs.Where(x => x.TenVatTu == partsName);
            return parts.MaVatTu;
        }

        /// <summary>
        /// Get the price of a part from its name
        /// </summary>
        /// <param name="partsName"></param>
        /// <returns>The price</returns>
        private decimal? GetPartsPrice (string partsName)
        {
            Model.VATTU parts = new Model.VATTU();
            parts = (Model.VATTU)DataProvider.Instance.DB.VATTUs.Where(x => x.TenVatTu == partsName);
            return parts.DonGiaHienTai;
        }

        /// <summary>
        /// Add maintenance info for a vehicle. The vehicle must have been added to the garage first
        /// </summary>
        /// <param name="plate"></param>
        /// <param name="date"></param>
        /// <param name="details"></param>
        /// <returns>True if successfully added, otherwise false</returns>
        public bool AddMaintenanceInfo(string plate, DateTime date, string details, string wageName, string[] parts, int[] amount)
        {
            if (DataProvider.Instance.DB.XEs.Any(x => x.BienSo == plate))
            {              
                Model.CT_SUDUNGVATTU[] ct_sdvt = new Model.CT_SUDUNGVATTU[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    ct_sdvt[i].MaVatTu = GetPartsID(parts[i]);
                    ct_sdvt[i].SoLuong = amount[i];
                    ct_sdvt[i].DonGia = GetPartsPrice(parts[i]);
                }

                Model.CT_PSC[] ct_psc = new Model.CT_PSC[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    ct_psc[i].NoiDung = details;
                    ct_psc[i].SoLan = DataProvider.Instance.DB.PHIEUSUACHUAs.Where(x => x.BienSo == plate).Count();
                    ct_psc[i].MaTienCong = GetWageId(wageName);
                    ct_psc[i].ThanhTien = ct_sdvt[i].SoLuong * ct_sdvt[i].DonGia + GetWage((int)ct_psc[i].MaTienCong);
                    ct_psc[i].CT_SUDUNGVATTU = ct_sdvt[i];
                }

                Model.PHIEUSUACHUA phieusuachua = new Model.PHIEUSUACHUA
                {
                    BienSo = plate,
                    NgaySuaChua = date,
                    CT_PSC = ct_psc,
                    TongTien = 0
                };
                for (int i = 0; i < parts.Length; i++)
                {
                    phieusuachua.TongTien += ct_psc[i].ThanhTien;
                }
                DataProvider.Instance.DB.PHIEUSUACHUAs.Add(phieusuachua);
                DataProvider.Instance.DB.SaveChanges();

                for (int i = 0; i < ct_psc.Length; i++)
                {
                    DataProvider.Instance.DB.CT_PSC.Add(ct_psc[i]);
                }
                DataProvider.Instance.DB.SaveChanges();

                for (int i = 0; i < ct_sdvt.Length; i++)
                {
                    DataProvider.Instance.DB.CT_SUDUNGVATTU.Add(ct_sdvt[i]);
                }
                DataProvider.Instance.DB.SaveChanges();

                return true;
            }
            else
                return false;
        }
    }
}
