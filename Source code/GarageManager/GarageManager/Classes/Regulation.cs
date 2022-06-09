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
        /// Get the number of vehicle brands in the database
        /// </summary>
        /// <returns>The number of vehicle brands</returns>
        public static int GetBrandAmount()
        {
            return DataProvider.Instance.DB.HIEUXEs.Count();
        }

        /// <summary>
        /// Change the limit of the number of vehicles can be maintenanced in a day
        /// </summary>
        /// <param name="newLimit"></param>
        public static void ChangeRule(string TenQuyDinh, int GiaTriMoi)
        {
            Model.THAMSO Rule = DataProvider.Instance.DB.THAMSOes.FirstOrDefault(x => x.TenThamSo == TenQuyDinh);
            Rule.GiaTri = GiaTriMoi;
            DataProvider.Instance.DB.SaveChanges();
        }
    }
}
