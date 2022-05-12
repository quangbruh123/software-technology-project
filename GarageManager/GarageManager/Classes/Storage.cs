using System;
using System.Collections.Generic;
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
        private int GetPartID(string partName)
        {
            return DataProvider.Instance.DB.VATTUs.Where(x => x.TenVatTu == partName).FirstOrDefault().MaVatTu;
        }
        
        /// <summary>
        /// Add a new vehicle part. The part must have not existed in the database
        /// </summary>
        /// <param name="newPartName"></param>
        /// <param name="newPartPrice"></param>
        /// <param name="newPartAmount"></param>
        /// <returns>True if successfully added, false if not</returns>
        public static bool AddNewPart(string newPartName, decimal newPartPrice, int newPartAmount)
        {
            if (!DataProvider.Instance.DB.VATTUs.Any(x => x.TenVatTu == newPartName))
            {
                /// not done yet

                DataProvider.Instance.DB.SaveChanges();
                return true;
            }
            else
                return false;
        }

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

        public static bool UpdatePartAmount(string partName, int newAmount)
        {
            if (DataProvider.Instance.DB.VATTUs.Any(x => x.TenVatTu == partName))
            {
                Model.VATTU part = DataProvider.Instance.DB.VATTUs.Where(x => x.TenVatTu == partName).FirstOrDefault();


                DataProvider.Instance.DB.SaveChanges();
                return true;
            }
            else
                return false;
        }
    }
}
