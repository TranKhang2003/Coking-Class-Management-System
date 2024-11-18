using DAL.DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BLL.BLL
{
    public class UserBLL
    {
        public static bool SiginBLL(UserDTO userDTO)
        {
            userDTO.MatKhau = HashPassword(userDTO.MatKhau);
            return UserDAO.Instance.LoginDAO(userDTO);
        }
        public static int SignupBLL(UserDTO userDTO, string rePassword) {

            if (userDTO.MatKhau != rePassword)
            {
                return 0;
            }
            else if (userDTO.HoTen == "")
            {
                return 1;
            }
            else if (userDTO.MatKhau == "")
            {
                return 2;
            }
            else if (userDTO.Email == "" || IsValidEmail(userDTO.Email) == false)
            {
                return 3;
            }
            else
                userDTO.MatKhau = HashPassword(userDTO.MatKhau);
            if (UserDAO.Instance.SignUpDAO(userDTO) == -1)
            {
                return 4;
            }
            else if(UserDAO.Instance.SignUpDAO(userDTO) == 0)
            {
                return 5;
            }
            else if (UserDAO.Instance.SignUpDAO(userDTO) > 0)
            {
                return 6;
            }
            else return 7;
        }
        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
               
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

              
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Định nghĩa biểu thức chính quy cho email hợp lệ
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            return Regex.IsMatch(email, emailPattern, RegexOptions.IgnoreCase);
        }
    }
}
