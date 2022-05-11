﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.Classes
{
    /// <summary>
    /// Handles financial operations of the garage
    /// </summary>
    public class Finance
    {
        /// <summary>
        /// Create a receipt for a vehicle after maintenancing. The amount of money customer pays must be lower than the amount said customer owes the garage.
        /// </summary>
        /// <param name="plate"></param>
        /// <returns>True if the pay satisfy the condition, false if not</returns>
        public static bool AddReceipt(string plate, decimal pay)
        {
            if (DataProvider.Instance.DB.XEs.Where(x => x.BienSo == plate).FirstOrDefault().TienNo > pay)
            {
                Model.PHIEUTHUTIEN receipt = new Model.PHIEUTHUTIEN()
                {
                    BienSo = plate,
                    SoTienThu = pay
                };
                DataProvider.Instance.DB.PHIEUTHUTIENs.Add(receipt);
                DataProvider.Instance.DB.SaveChanges();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Get full information of a receipt from a plate
        /// </summary>
        /// <param name="plate"></param>
        /// <returns>The vehicle's information and a list of its receipts, or null if the vehicle doesn't exist in the databse</returns>
        public static dynamic GetReceiptInfo(string plate)
        {
            Model.XE vehicle = DataProvider.Instance.DB.XEs.Where(x => x.BienSo == plate).FirstOrDefault();
            List<Model.PHIEUTHUTIEN> receipt = DataProvider.Instance.DB.PHIEUTHUTIENs.Where(x => x.BienSo == plate).ToList();
            if (vehicle != null && receipt != null)
                return new { vehicle, receipt };
            else
                return null;
        }
    }
}
