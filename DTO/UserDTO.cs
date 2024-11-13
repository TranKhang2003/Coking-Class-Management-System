using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        private int id;
        private string hoTen;
        private string matKhau;
        private string email;
        public UserDTO(string hoTen, string matKhau) { 
            this.hoTen = hoTen;
            this.matKhau = matKhau;
        }
        public UserDTO(string hoTen, string matKhau,string email)
        {
            this.hoTen = hoTen;
            this.matKhau = matKhau;
            this.email = email;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string HoTen
        {
            get => hoTen;
            set => hoTen = value;
        }

        public string MatKhau
        {
            get => matKhau;
            set => matKhau = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }
        public UserDTO(DataRow row)
        {
            Id = Convert.ToInt32(row["Id"]);
            HoTen = row["HoTen"].ToString();
            MatKhau = row["MatKhau"].ToString();
            Email = row["Email"].ToString();
        }
    }
}
