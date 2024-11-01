using System;
using System.Data;

namespace CookingClassManagementSystem.DTO
{
    public class DanhGiaLopHoc
    {
        public int id { get; set; }
        public int maLopHoc { get; set; }
        public int hocVienId { get; set; }
        public int diemDanhGia { get; set; }
        public string nhanXet { get; set; }
        public DateTime ngayDanhGia { get; set; }

        public DanhGiaLopHoc(int id, int maLopHoc, int hocVienId, int diemDanhGia, string nhanXet, DateTime ngayDanhGia)
        {
            this.id = id;
            this.maLopHoc = maLopHoc;
            this.hocVienId = hocVienId;
            this.diemDanhGia = diemDanhGia;
            this.nhanXet = nhanXet;
            this.ngayDanhGia = ngayDanhGia;
        }

        public DanhGiaLopHoc(DataRow row)
        {
            id = Convert.ToInt32(row["Id"]);
            maLopHoc = Convert.ToInt32(row["MaLopHoc"]);
            hocVienId = Convert.ToInt32(row["HocVienId"]);
            diemDanhGia = Convert.ToInt32(row["DiemDanhGia"]);
            nhanXet = row["NhanXet"].ToString();
            ngayDanhGia = Convert.ToDateTime(row["NgayDanhGia"]);
        }
    }
}
