using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.Classes
{
    public class Account
    {
        /// <summary>
        /// Add a staff account to the database
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>
        /// true if successfully added, otherwise false
        /// </returns>
        public bool AddStaffAccount(string username, string password)
        {
            var userCount = DataProvider.Instance.DB.TAIKHOANs.Where(x => x.TenDangNhap == username && x.MatKhau == password).Count();
            if (userCount == 0)
            {
                Model.TAIKHOAN newaccount = new Model.TAIKHOAN
                {
                    TenDangNhap = username,
                    MatKhau = password,
                    Quyen = "staff"
                };
                DataProvider.Instance.DB.TAIKHOANs.Add(newaccount);
                DataProvider.Instance.DB.SaveChanges();
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Add a admin account to the database
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>
        /// true if successfully added, otherwise false
        /// </returns>
        public bool AddAdminAccount(string username, string password)
        {
            var userCount = DataProvider.Instance.DB.TAIKHOANs.Where(x => x.TenDangNhap == username && x.MatKhau == password).Count();
            if (userCount == 0)
            {
                Model.TAIKHOAN newaccount = new Model.TAIKHOAN
                {
                    TenDangNhap = username,
                    MatKhau = password,
                    Quyen = "admin"
                };
                DataProvider.Instance.DB.TAIKHOANs.Add(newaccount);
                DataProvider.Instance.DB.SaveChanges();
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Delete an account from the database
        /// </summary>
        /// <param name="username"></param>
        public void DeleteAccount(string username)
        {
            Model.TAIKHOAN unwantedAccount = DataProvider.Instance.DB.TAIKHOANs.Where(x => x.TenDangNhap == username).First();
            DataProvider.Instance.DB.TAIKHOANs.Remove(unwantedAccount);
            DataProvider.Instance.DB.SaveChanges();
        }
    }
}
