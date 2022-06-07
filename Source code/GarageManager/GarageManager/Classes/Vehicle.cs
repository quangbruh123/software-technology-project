using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public static bool AddVehicle(string plate, string owner, string vehicleBrand, string phonenum, string address, string email, DateTime date)
        {
            if (!DataProvider.Instance.DB.XEs.Any(x => x.BienSo == plate))
            {
                Model.HIEUXE brand = DataProvider.Instance.DB.HIEUXEs.FirstOrDefault(x => x.TenHieuXe == vehicleBrand);
                Model.XE car = new Model.XE()
                {
                    BienSo = plate,
                    TenChuXe = owner,
                    MaHieuXe = brand.MaHieuXe,
                    DienThoai = phonenum,
                    DiaChi = address,
                    Email = email,
                    NgayTiepNhan = date,
                    TienNo = 0,
                    HIEUXE = brand
                };
                DataProvider.Instance.DB.XEs.Add(car);
                DataProvider.Instance.DB.SaveChanges();
                Debug.WriteLine(car.BienSo + " " + car.TenChuXe + " " + car.MaHieuXe + " " + car.DienThoai + " " + car.DiaChi + " " + car.Email + " " + car.NgayTiepNhan.ToString() + " " + car.TienNo);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Add maintenance info for a vehicle. The vehicle must have been added to the garage first
        /// </summary>
        /// <param name="plate"></param>
        /// <param name="date"></param>
        /// <param name="details"></param>
        /// <returns>True if successfully added, otherwise false</returns>
        public static void AddMaintenanceInfo(string plate, DateTime date, List<string> details, List<string> wageName, List<string> partNames, List<int> amount)
        {                
            if (DataProvider.Instance.DB.XEs.Any(x => x.BienSo == plate))
            {
                Model.XE vehicle = DataProvider.Instance.DB.XEs.FirstOrDefault(x => x.BienSo == plate);
                List<Model.CT_SUDUNGVATTU> partUsageDetailList = new List<Model.CT_SUDUNGVATTU>();
                for (int i = 0; i < partNames.Count; i++)
                {
                    string requiredPart = partNames[i];
                    Debug.WriteLine(requiredPart);
                    var part = DataProvider.Instance.DB.VATTUs.FirstOrDefault(x => x.TenVatTu == requiredPart);
                    if (part.SoLuongTon < amount[i])
                    {
                        MessageBox.Show("Không đủ vật tư trong kho để lập phiếu.\nVật tư: " + part.TenVatTu);
                        return;
                    }
                    Model.CT_SUDUNGVATTU partUsageDetail = new Model.CT_SUDUNGVATTU
                    {
                        MaVatTu = part.MaVatTu,
                        SoLuong = amount[i],
                        DonGia = part.DonGiaHienTai
                    };
                    partUsageDetailList.Add(partUsageDetail);
                    part.SoLuongTon -= amount[i];
                }

                List<Model.CT_PSC> maintenanceDetailList = new List<Model.CT_PSC>();
                for (int i = 0; i < partNames.Count; i++)
                {
                    string requiredWage = wageName[i];
                    Model.TIENCONG wage = DataProvider.Instance.DB.TIENCONGs.FirstOrDefault(x => x.TenTienCong == requiredWage);
                    Model.CT_PSC maintenanceDetail = new Model.CT_PSC
                    {
                        NoiDung = details[i],
                        SoLan = DataProvider.Instance.DB.PHIEUSUACHUAs.Where(x => x.BienSo == plate).Count() + 1,
                        MaTienCong = wage.MaTienCong,
                        ThanhTien = partUsageDetailList[i].SoLuong * partUsageDetailList[i].DonGia + wage.MaTienCong,
                        TIENCONG = wage
                    };
                    maintenanceDetail.CT_SUDUNGVATTU.Add(partUsageDetailList[i]);                    
                    maintenanceDetailList.Add(maintenanceDetail);
                }

                Model.PHIEUSUACHUA maintenanceCard = new Model.PHIEUSUACHUA
                {
                    BienSo = plate,
                    NgaySuaChua = date,
                    CT_PSC = maintenanceDetailList,
                    XE = vehicle,
                    TongTien = 0
                };
                for (int i = 0; i < partNames.Count; i++)
                {
                    maintenanceCard.TongTien += maintenanceDetailList[i].ThanhTien;
                }
                DataProvider.Instance.DB.PHIEUSUACHUAs.Add(maintenanceCard);
                vehicle.PHIEUSUACHUAs.Add(maintenanceCard);
                vehicle.TienNo = maintenanceCard.TongTien;
                DataProvider.Instance.DB.CT_PSC.AddRange(maintenanceDetailList);
                for (int i = 0; i < partUsageDetailList.Count; i++)
                {
                    partUsageDetailList[i].CT_PSC = maintenanceDetailList[i];
                    DataProvider.Instance.DB.CT_SUDUNGVATTU.Add(partUsageDetailList[i]);
                }
                DataProvider.Instance.DB.SaveChanges();

                MessageBox.Show("Lưu phiếu sửa chữa thành công");
                return;
            }
            else
            {
                MessageBox.Show("Không tìm thấy xe với biển số đã cho.\nHãy chắc chắn xe đã được tiếp nhận rồi.");
                return;
            }
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
            Model.PHIEUSUACHUA psc = new Model.PHIEUSUACHUA();
            if (DataProvider.Instance.DB.PHIEUSUACHUAs.Any(x => x.BienSo == plate))
            {
                psc = DataProvider.Instance.DB.PHIEUSUACHUAs.Where(x => x.BienSo == plate).FirstOrDefault();
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
