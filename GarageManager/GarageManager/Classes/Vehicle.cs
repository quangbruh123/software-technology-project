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
        void AddVehicle(string plate, string owner, string phonenum, string address, string email, DateTime date, int owe)
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
        /// Add maintenance info for a vehicle. The vehicle must have been added to the garage first
        /// </summary>
        void AddMaintenanceInfo(string plate)
        {

        }
    }
}
