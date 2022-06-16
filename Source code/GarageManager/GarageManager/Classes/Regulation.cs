using System.Linq;

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
