using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

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
        public bool AddStaffAccount(string username, string password)
        {
            if (!DataProvider.Instance.DB.TAIKHOANs.Any(x => x.TenTaiKhoan == username && x.MatKhau == password))
            {
                Model.TAIKHOAN newaccount = new Model.TAIKHOAN
                {
                    TenTaiKhoan = username,
                    MatKhau = password,
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
        public bool AddAdminAccount(string username, string password)
        {
            if (!DataProvider.Instance.DB.TAIKHOANs.Any(x => x.TenTaiKhoan == username && x.MatKhau == password))
            {
                Model.TAIKHOAN newaccount = new Model.TAIKHOAN
                {
                    TenTaiKhoan = username,
                    MatKhau = password,
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
        public void DeleteAccount(string username)
        {
            Model.TAIKHOAN unwantedAccount = DataProvider.Instance.DB.TAIKHOANs.Where(x => x.TenTaiKhoan == username).First();
            DataProvider.Instance.DB.TAIKHOANs.Remove(unwantedAccount);
            DataProvider.Instance.DB.SaveChanges();
        }

        /// <summary>
        /// User log in check, set isLoggedIn to true if the user's account existed, false if it doesn't
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        private void LogIn(string username, string password)
        {
            SHA256 sha256hash = SHA256.Create();
            string passwordhash = GetHash(sha256hash, password);
            if(Classes.DataProvider.Instance.DB.TAIKHOANs.Any(x => x.TenTaiKhoan == username && VerifyHash(sha256hash, x.MatKhau, passwordhash)))
                MainForm.isLoggedIn = true;
        }

        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        private static bool VerifyHash(HashAlgorithm hashAlgorithm, string input, string hash)
        {
            // Hash the input.
            var hashOfInput = GetHash(hashAlgorithm, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            return comparer.Compare(hashOfInput, hash) == 0;
        }
    }
}
    