using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingClassManagementSystem.DTO
{
    public class HocVien
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public DateTime NgayDangKy { get; set; }
        public string GhiChu { get; set; }
        public string Sdt { get; set; }

        public HocVien(int id, int userId, string hoTen, bool gioiTinh, DateTime ngaySinh, DateTime ngayDangKy, string ghiChu, string sdt)
        {
            Id = id;
            UserId = userId;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            NgayDangKy = ngayDangKy;
            GhiChu = ghiChu;
            Sdt = sdt;
        }
        public HocVien(DataRow row)
        {
            Id = Convert.ToInt32(row["Id"]);
            UserId = Convert.ToInt32(row["UserId"]);
            HoTen = row["HoTen"].ToString();
            GioiTinh = Convert.ToBoolean(row["GioiTinh"]);
            NgaySinh = Convert.ToDateTime(row["NgaySinh"]);
            NgayDangKy = Convert.ToDateTime(row["NgayDangKy"]);
            GhiChu = row["GhiChu"].ToString();
            Sdt = row["Sdt"].ToString();
        }
    }

}

