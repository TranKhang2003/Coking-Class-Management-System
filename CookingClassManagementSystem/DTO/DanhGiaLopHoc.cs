using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingClassManagementSystem.DTO
{
    public class DanhGiaLopHoc
    {
        public int Id { get; set; }
        public int MaLopHoc { get; set; }
        public int HocVienId { get; set; }
        public int DiemDanhGia { get; set; }
        public string NhanXet { get; set; }
        public DateTime NgayDanhGia { get; set; }

        public DanhGiaLopHoc(int id, int maLopHoc, int hocVienId, int diemDanhGia, string nhanXet, DateTime ngayDanhGia)
        {
            Id = id;
            MaLopHoc = maLopHoc;
            HocVienId = hocVienId;
            DiemDanhGia = diemDanhGia;
            NhanXet = nhanXet;
            NgayDanhGia = ngayDanhGia;
        }
        public DanhGiaLopHoc(DataRow row)
        {
            Id = Convert.ToInt32(row["Id"]);
            MaLopHoc = Convert.ToInt32(row["MaLopHoc"]);
            HocVienId = Convert.ToInt32(row["HocVienId"]);
            DiemDanhGia = Convert.ToInt32(row["DiemDanhGia"]);
            NhanXet = row["NhanXet"].ToString();
            NgayDanhGia = Convert.ToDateTime(row["NgayDanhGia"]);
        }
    }
}
