using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class UserDAO
    {
        private static UserDAO instance;
        public static UserDAO Instance
        {
            get { if (instance == null) { instance = new UserDAO(); } return instance; }
            private set
            {
                instance = value;
            }
        }
        private UserDAO() { }
        public bool LoginDAO(UserDTO userDTO)
        {
            string query = "SELECT U.id, U.HoTen, R.RoleName " +
                           "FROM Users U " +
                           "JOIN User_Role UR ON U.id = UR.UserId " +
                           "JOIN Roles R ON UR.RoleId = R.id " +
                           "WHERE U.HoTen = @HoTen AND U.MatKhau = @MatKhau";

            object[] para = new object[]
                {userDTO.HoTen,
                userDTO.MatKhau
                };
            DataTable data = DataProvider.Instance.ExcuteQuery(query,para);
            return data.Rows.Count > 0;
        }
        public int SignUpDAO(UserDTO userDTO)
        {
            string queryCheckUsename = "select id from Users where HoTen = @HoTen";
            string queryCheckEmail = "select id from Users where Email = @Email";
            string query = "insert into Users(HoTen,MatKhau,Email) "  + "values ( @HoTen , @MatKhau , @Email )";
            object[] paraCheckEmail = new object[]
           {
                userDTO.Email

           };
            object[] para = new object[]
            {
                userDTO.HoTen,
                userDTO.MatKhau,
                userDTO.Email

            };
            if (DataProvider.Instance.ExcuteQuery(queryCheckUsename, para).Rows.Count > 0)
            {
                return -1;
            }
            else if (DataProvider.Instance.ExcuteQuery(queryCheckEmail, paraCheckEmail).Rows.Count > 0)
            {
                return 0;
            }
            object data = DataProvider.Instance.ExcuteNonQuery(query,para);
            return (int)data ;
        }
    }
}
