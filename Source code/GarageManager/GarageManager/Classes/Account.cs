using System.Linq;

namespace GarageManager.Classes
{
    /// <summary>
    /// Handles accounts
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Add a staff account to the database
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>
        /// True if successfully added, otherwise false
        /// </returns>
        public static bool AddStaffAccount(string fullName, string userName, string email, string gender, string password)
        {
            if (!DataProvider.Instance.DB.TAIKHOANs.Any(x => x.TenTaiKhoan == userName && x.MatKhau == password))
            {
                Model.TAIKHOAN newaccount = new Model.TAIKHOAN
                {
                    HoTen = fullName,
                    TenTaiKhoan = userName,
                    Email = email,
                    MatKhau = password,
                    GioiTinh = gender,
                    QuyenHan = 0
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
        /// True if successfully added, otherwise false
        /// </returns>
        public static bool AddAdminAccount(string fullName, string userName, string email, string gender, string password)
        {
            if (!DataProvider.Instance.DB.TAIKHOANs.Any(x => x.TenTaiKhoan == userName && x.MatKhau == password))
            {
                Model.TAIKHOAN newaccount = new Model.TAIKHOAN
                {
                    HoTen = fullName,
                    TenTaiKhoan = userName,
                    Email = email,
                    MatKhau = password,
                    GioiTinh = gender,
                    QuyenHan = 1
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
        public static bool DeleteAccount(string username)
        {
            if (DataProvider.Instance.DB.TAIKHOANs.Any(x => x.TenTaiKhoan == username))
            {
                Model.TAIKHOAN unwantedAccount = DataProvider.Instance.DB.TAIKHOANs.Where(x => x.TenTaiKhoan == username).FirstOrDefault();
                Model.VAITRO role = DataProvider.Instance.DB.VAITROes.FirstOrDefault(x => x.MaVaiTro == unwantedAccount.QuyenHan);
                role.TAIKHOANs.Remove(unwantedAccount);
                DataProvider.Instance.DB.TAIKHOANs.Remove(unwantedAccount);
                DataProvider.Instance.DB.SaveChanges();
                return true;
            }
            else
                return false;
        }
    }
}
    