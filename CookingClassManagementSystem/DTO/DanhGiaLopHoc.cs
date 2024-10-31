using System;
using System.Collections.Generic;
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
    }
}
