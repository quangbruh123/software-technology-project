using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.Classes
{
    /// <summary>
    /// Handles all operations related to vehicles
    /// </summary>
    public class Vehicle
    {
        /// <summary>
        /// Check if a vehicle's plate exists in the database
        /// </summary>
        /// <param name="plate"></param>
        /// <returns>True if the vehicle is in the database, false if not</returns>
        public static bool VerifyPlate(string plate)
        {
            return DataProvider.Instance.DB.XEs.Any(x => x.BienSo == plate);
        }

        /// <summary>
        /// Add a vehicle to the garage
        /// </summary>
        /// <param name="plate"></param>
        /// <param name="owner"></param>
        /// <param name="phonenum"></param>
        /// <param name="address"></param>
        /// <param name="email"></param>
        public static void AddVehicle(string plate, string owner, string phonenum, string address, string email, DateTime date)
        {
            Model.XE car = new Model.XE()
            {
                BienSo = plate,
                TenChuXe = owner,
                DienThoai = phonenum,
                DiaChi = address,
                Email = email,
                NgayTiepNhan = date,
                TienNo = 0
            };
            DataProvider.Instance.DB.XEs.Add(car);
            DataProvider.Instance.DB.SaveChanges();
        }

        /// <summary>
        /// Get the ID of a type of wage (service) from its name
        /// </summary>
        /// <param name="wageName"></param>
        /// <returns>The ID</returns>
        private static int GetWageId (string wageName)
        {
            return DataProvider.Instance.DB.TIENCONGs.Where(x => x.TenTienCong == wageName).FirstOrDefault().MaTienCong;
        }

        private static decimal? GetWage (int wageID)
        {
            return DataProvider.Instance.DB.TIENCONGs.Where(x => x.MaTienCong == wageID).FirstOrDefault().GiaTienCong;
        }

        /// <summary>
        /// Get the ID of a car part from its name
        /// </summary>
        /// <param name="partsName"></param>
        /// <returns>The ID</returns>
        private static int GetPartsID (string partsName)
        {
            return DataProvider.Instance.DB.VATTUs.Where(x => x.TenVatTu == partsName).FirstOrDefault().MaVatTu;
        }

        /// <summary>
        /// Get the price of a part from its name
        /// </summary>
        /// <param name="partsName"></param>
        /// <returns>The price</returns>
        private static decimal? GetPartsPrice (string partsName)
        {
            return DataProvider.Instance.DB.VATTUs.Where(x => x.TenVatTu == partsName).FirstOrDefault().DonGiaHienTai;
        }

        /// <summary>
        /// Add maintenance info for a vehicle. The vehicle must have been added to the garage first
        /// </summary>
        /// <param name="plate"></param>
        /// <param name="date"></param>
        /// <param name="details"></param>
        /// <returns>True if successfully added, otherwise false</returns>
        public static bool AddMaintenanceInfo(string plate, DateTime date, List<string> details, List<string> wageName, List<string> parts, List<int> amount)
        {
            Model.XE vehicle = DataProvider.Instance.DB.XEs.FirstOrDefault(x => x.BienSo == plate);
            if (vehicle != null)
            {
                Model.CT_SUDUNGVATTU[] ct_sdvt = new Model.CT_SUDUNGVATTU[parts.Count];
                for (int i = 0; i < parts.Count; i++)
                {
                    ct_sdvt[i].MaVatTu = GetPartsID(parts[i]);
                    ct_sdvt[i].SoLuong = amount[i];
                    ct_sdvt[i].DonGia = GetPartsPrice(parts[i]);
                }

                Model.CT_PSC[] ct_psc = new Model.CT_PSC[parts.Count];
                for (int i = 0; i < parts.Count; i++)
                {
                    Model.TIENCONG wage = DataProvider.Instance.DB.TIENCONGs.FirstOrDefault(x => x.TenTienCong == wageName[i]);
                    ct_psc[i].NoiDung = details[i];
                    ct_psc[i].SoLan = DataProvider.Instance.DB.PHIEUSUACHUAs.Where(x => x.BienSo == plate).Count() + 1;
                    ct_psc[i].MaTienCong = wage.MaTienCong;
                    ct_psc[i].TIENCONG = wage;
                    ct_psc[i].ThanhTien = ct_sdvt[i].SoLuong * ct_sdvt[i].DonGia + GetWage((int)ct_psc[i].MaTienCong);
                    ct_psc[i].CT_SUDUNGVATTU = ct_sdvt[i];
                }

                Model.PHIEUSUACHUA phieusuachua = new Model.PHIEUSUACHUA
                {
                    BienSo = plate,
                    NgaySuaChua = date,
                    CT_PSC = ct_psc,
                    XE = vehicle,
                    TongTien = 0
                };
                for (int i = 0; i < parts.Count; i++)
                {
                    phieusuachua.TongTien += ct_psc[i].ThanhTien;
                }
                DataProvider.Instance.DB.PHIEUSUACHUAs.Add(phieusuachua);
                vehicle.PHIEUSUACHUAs.Add(phieusuachua);
                vehicle.TienNo = phieusuachua.TongTien;
                DataProvider.Instance.DB.SaveChanges();

                for (int i = 0; i < ct_psc.Length; i++)
                {
                    DataProvider.Instance.DB.CT_PSC.AddRange(ct_psc);
                }
                DataProvider.Instance.DB.SaveChanges();

                for (int i = 0; i < ct_sdvt.Length; i++)
                {
                    ct_sdvt[i].CT_PSC = ct_psc[i];
                    DataProvider.Instance.DB.CT_SUDUNGVATTU.AddRange(ct_sdvt);
                }
                DataProvider.Instance.DB.SaveChanges();

                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Find all vehicles that has their plates containing the given key word
        /// </summary>
        /// <param name="plate"></param>
        /// <returns>A list of vehicle satisfies the condition</returns>
        public static List<Model.XE> FindVehicleFromPlate(string plate)
        {
            return DataProvider.Instance.DB.XEs.Where(x => x.BienSo.Contains(plate)).ToList();
        }

        /// <summary>
        /// Find all vehicles that has their owner's names containing the given key word
        /// </summary>
        /// <param name="name"></param>
        /// <returns>A list of vehicle satisfies the condition</returns>
        public static List<Model.XE> FindVehicleFromNameOfOwner(string name)
        {
            return DataProvider.Instance.DB.XEs.Where(x => x.TenChuXe.Contains(name)).ToList();
        }

        /// <summary>
        /// Get all maintenance information of a vehicle from its plate. The vehicle must already has a maintenance card
        /// </summary>
        /// <param name="plate"></param>
        /// <returns>PHIEUSUACHUA, a list of CT_PSC and a list of CT_SUDUNGVATTU, or null if it doesn't have a maintenance card yet</returns>
        public static dynamic GetMaintenanceCard(string plate)
        {
            Model.PHIEUSUACHUA psc = DataProvider.Instance.DB.PHIEUSUACHUAs.Where(x => x.BienSo == plate).FirstOrDefault();
            if (psc != null)
            {
                List<Model.CT_PSC> ct_psc = DataProvider.Instance.DB.CT_PSC.Where(x => x.MaPhieuSC == psc.MaPhieuSC).ToList();
                List<Model.CT_SUDUNGVATTU> ct_sdvt = new List<Model.CT_SUDUNGVATTU>();
                for (int i = 0; i < ct_psc.Count; i++)
                {
                    ct_sdvt.Add(DataProvider.Instance.DB.CT_SUDUNGVATTU.Where(x => x.MaCTPSC == ct_psc[i].MaCTPSC).FirstOrDefault());
                }
                return new { psc, ct_psc, ct_sdvt };
            }
            else
                return null;
        }

        /// <summary>
        /// Get all maintenance information
        /// </summary>
        /// <returns>Return a list of maintenance information</returns>
        public static List<Model.CT_PSC> GetAllMaintenanceInfo()
        {
            return DataProvider.Instance.DB.CT_PSC.ToList();
        }
    }
}
