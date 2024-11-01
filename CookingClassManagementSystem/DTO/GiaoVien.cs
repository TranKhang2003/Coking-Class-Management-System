using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingClassManagementSystem.DTO
{
    public class GiaoVien
    {
        private int id;
        private int userId;
        private string hoTen;
        private DateTime ngaySinh;
        private bool gioiTinh;
        private string chuyenMon;
        private int soNamKinhNghiem;
        private string sdt;
        private decimal luong;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public int UserId
        {
            get => userId;
            set => userId = value;
        }

        public string HoTen
        {
            get => hoTen;
            set => hoTen = value;
        }

        public DateTime NgaySinh
        {
            get => ngaySinh;
            set => ngaySinh = value;
        }

        public bool GioiTinh
        {
            get => gioiTinh;
            set => gioiTinh = value;
        }

        public string ChuyenMon
        {
            get => chuyenMon;
            set => chuyenMon = value;
        }

        public int SoNamKinhNghiem
        {
            get => soNamKinhNghiem;
            set => soNamKinhNghiem = value;
        }

        public string Sdt
        {
            get => sdt;
            set => sdt = value;
        }

        public decimal Luong
        {
            get => luong;
            set => luong = value;
        }
        public GiaoVien(int id, int userId, string hoTen, DateTime ngaySinh, bool gioiTinh, string chuyenMon, int soNamKinhNghiem, string sdt, decimal luong)
        {
            Id = id;
            UserId = userId;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            ChuyenMon = chuyenMon;
            SoNamKinhNghiem = soNamKinhNghiem;
            Sdt = sdt;
            Luong = luong;
        }
        public User User { get; set; }
        public GiaoVien(DataRow row)
        {
            Id = Convert.ToInt32(row["Id"]);
            UserId = Convert.ToInt32(row["UserId"]);
            HoTen = row["HoTen"].ToString();
            NgaySinh = Convert.ToDateTime(row["NgaySinh"]);
            GioiTinh = Convert.ToBoolean(row["GioiTinh"]);
            ChuyenMon = row["ChuyenMon"].ToString();
            SoNamKinhNghiem = Convert.ToInt32(row["SoNamKinhNghiem"]);
            Sdt = row["Sdt"].ToString();
            Luong = Convert.ToDecimal(row["Luong"]);
        }
    }

}
