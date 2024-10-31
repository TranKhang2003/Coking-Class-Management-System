using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingClassManagementSystem.DTO
{
    public class ChiTietLopHoc
    {
        public int MaLopHocChiTiet { get; set; }
        public int MaLopHoc { get; set; }
        public decimal PhiDiaDiem { get; set; }
        public decimal TongThu { get; set; }
        public decimal GiamGia { get; set; }
        public decimal TienHoanLai { get; set; }
        public decimal NguyenLieu { get; set; }
        public decimal PhiKhac { get; set; }
        public decimal ThucThu { get; set; }
        public string TrangThai { get; set; }

        public ChiTietLopHoc(int maLopHocChiTiet, int maLopHoc, decimal phiDiaDiem, decimal tongThu, decimal giamGia, decimal tienHoanLai, decimal nguyenLieu, decimal phiKhac, decimal thucThu, string trangThai)
        {
            MaLopHocChiTiet = maLopHocChiTiet;
            MaLopHoc = maLopHoc;
            PhiDiaDiem = phiDiaDiem;
            TongThu = tongThu;
            GiamGia = giamGia;
            TienHoanLai = tienHoanLai;
            NguyenLieu = nguyenLieu;
            PhiKhac = phiKhac;
            ThucThu = thucThu;
            TrangThai = trangThai;
        }
    }
}
