using System;
using System.Data;

namespace CookingClassManagementSystem.DTO
{
    public class HocVien
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string hoTen { get; set; }
        public bool gioiTinh { get; set; }
        public DateTime ngaySinh { get; set; }
        public DateTime ngayDangKy { get; set; }
        public string ghiChu { get; set; }
        public string sdt { get; set; }

        public HocVien(int id, int userId, string hoTen, bool gioiTinh, DateTime ngaySinh, DateTime ngayDangKy, string ghiChu, string sdt)
        {
            this.id = id;
            this.userId = userId;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.ngayDangKy = ngayDangKy;
            this.ghiChu = ghiChu;
            this.sdt = sdt;
        }

        public HocVien(DataRow row)
        {
            id = Convert.ToInt32(row["Id"]);
            userId = Convert.ToInt32(row["UserId"]);
            hoTen = row["HoTen"].ToString();
            gioiTinh = Convert.ToBoolean(row["GioiTinh"]);
            ngaySinh = Convert.ToDateTime(row["NgaySinh"]);
            ngayDangKy = Convert.ToDateTime(row["NgayDangKy"]);
            ghiChu = row["GhiChu"].ToString();
            sdt = row["Sdt"].ToString();
        }
    }
}
