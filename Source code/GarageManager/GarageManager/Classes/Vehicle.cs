using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GarageManager.Classes
{
    /// <summary>
    /// Handles all operations related to vehicles
    /// </summary>
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
                if (date.Date.CompareTo(vehicle.NgayTiepNhan.Value.Date) < 0)
                {
                    MessageBox.Show("Ngày sửa phải lớn hơn ngày tiếp nhận", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                List<Model.CT_SUDUNGVATTU> partUsageDetailList = new List<Model.CT_SUDUNGVATTU>();
                for (int i = 0; i < partNames.Count; i++)
                {
                    string requiredPart = partNames[i];
                    var part = DataProvider.Instance.DB.VATTUs.FirstOrDefault(x => x.TenVatTu == requiredPart);
                    if (part.SoLuongTon < amount[i])
                    {
                        MessageBox.Show("Không đủ vật tư trong kho để lập phiếu.\nVật tư: " + part.TenVatTu, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Model.CT_SUDUNGVATTU partUsageDetail = new Model.CT_SUDUNGVATTU
                    {
                        MaVatTu = part.MaVatTu,
                        SoLuong = amount[i],
                        DonGia = part.DonGiaHienTai,
                        ThanhTien = part.DonGiaHienTai * amount[i],
                        VATTU = part
                    };
                    partUsageDetailList.Add(partUsageDetail);
                    part.SoLuongTon -= amount[i];
                    Model.BAOCAOTON storageReport = DataProvider.Instance.DB.BAOCAOTONs
                        .FirstOrDefault(x => x.Thang == date.Month && x.Nam == date.Year && x.MaVatTu == part.MaVatTu);
                    storageReport.TonCuoi -= amount[i];
                    DataProvider.Instance.DB.SaveChanges();
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
                        ThanhTien = partUsageDetailList[i].SoLuong * partUsageDetailList[i].DonGia + wage.GiaTienCong,
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
                for (int i = 0; i < maintenanceDetailList.Count; i++)
                {
                    maintenanceCard.TongTien += maintenanceDetailList[i].ThanhTien;
                }
                DataProvider.Instance.DB.PHIEUSUACHUAs.Add(maintenanceCard);
                vehicle.PHIEUSUACHUAs.Add(maintenanceCard);
                vehicle.TienNo += maintenanceCard.TongTien;
                DataProvider.Instance.DB.CT_PSC.AddRange(maintenanceDetailList);
                for (int i = 0; i < partUsageDetailList.Count; i++)
                {
                    partUsageDetailList[i].CT_PSC = maintenanceDetailList[i];
                    DataProvider.Instance.DB.CT_SUDUNGVATTU.Add(partUsageDetailList[i]);
                }
                DataProvider.Instance.DB.SaveChanges();

                MessageBox.Show("Lưu phiếu sửa chữa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Không tìm thấy xe với biển số đã cho.\nHãy chắc chắn xe đã được tiếp nhận rồi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
