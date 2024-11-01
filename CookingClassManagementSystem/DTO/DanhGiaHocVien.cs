using System;
using System.Data;

namespace CookingClassManagementSystem.DTO
{
    public class DanhGiaHocVien
    {
        public int id { get; set; }
        public int maLopHoc { get; set; }
        public int hocVienId { get; set; }
        public int giaoVienId { get; set; }
        public string nhanXet { get; set; }
        public DateTime ngayDanhGia { get; set; }

        public DanhGiaHocVien(int id, int maLopHoc, int hocVienId, int giaoVienId, string nhanXet, DateTime ngayDanhGia)
        {
            this.id = id;
            this.maLopHoc = maLopHoc;
            this.hocVienId = hocVienId;
            this.giaoVienId = giaoVienId;
            this.nhanXet = nhanXet;
            this.ngayDanhGia = ngayDanhGia;
        }

        public DanhGiaHocVien(DataRow row)
        {
            id = Convert.ToInt32(row["Id"]);
            maLopHoc = Convert.ToInt32(row["MaLopHoc"]);
            hocVienId = Convert.ToInt32(row["HocVienId"]);
            giaoVienId = Convert.ToInt32(row["GiaoVienId"]);
            nhanXet = row["NhanXet"].ToString();
            ngayDanhGia = Convert.ToDateTime(row["NgayDanhGia"]);
        }
    }
}
