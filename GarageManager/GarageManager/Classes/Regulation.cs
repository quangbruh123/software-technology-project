using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.Classes
{
    /// <summary>
    /// Handles operations related to regulations
    /// </summary>
    public class Regulation
    {
        /// <summary>
        /// Add a new vehicle brand. The brand must not have existed in the database
        /// </summary>
        /// <param name="brandName"></param>
        /// <returns>True if successfully added, otherwise false</returns>
        public static bool AddVehicleBrand(string brandName)
        {
            if (!DataProvider.Instance.DB.HIEUXEs.Any(x => x.TenHieuXe == brandName))
            {
                DataProvider.Instance.DB.HIEUXEs.Add(new Model.HIEUXE { TenHieuXe = brandName });
                DataProvider.Instance.DB.SaveChanges();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Get the number of vehicle brand in the database
        /// </summary>
        /// <returns></returns>
        public static int GetBrandAmount()
        {
            return DataProvider.Instance.DB.HIEUXEs.Count();
        }

        public static void ChangeVehicleLimitPerDay(int newLimit)
        {
            Model.THAMSO vehicleLimit = DataProvider.Instance.DB.THAMSOes.Where(x => x.TenThamSo == "VehicleLimitPerDay").FirstOrDefault();
            vehicleLimit.GiaTri = newLimit;
            DataProvider.Instance.DB.SaveChanges();
        }

        
    }
}
