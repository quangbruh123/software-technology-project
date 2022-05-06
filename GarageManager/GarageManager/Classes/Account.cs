using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.Classes
{
    public class Account
    {
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

        public void DeleteAccount(string username)
        {
            Model.TAIKHOAN unwantedAccount = DataProvider.Instance.DB.TAIKHOANs.Where(x => x.TenDangNhap == username).First();
            DataProvider.Instance.DB.TAIKHOANs.Remove(unwantedAccount);
            DataProvider.Instance.DB.SaveChanges();
        }
    }
}
