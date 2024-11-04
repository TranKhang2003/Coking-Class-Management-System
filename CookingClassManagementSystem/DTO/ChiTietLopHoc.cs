using System;
using System.Data;

namespace CookingClassManagementSystem.DTO
{
    public class ChiTietLopHoc
    {
        public int maLopHocChiTiet { get; set; }
        public int maLopHoc { get; set; }
        public decimal phiDiaDiem { get; set; }
        public decimal tongThu { get; set; }
        public decimal giamGia { get; set; }
        public decimal tienHoanLai { get; set; }
        public decimal nguyenLieu { get; set; }
        public decimal phiKhac { get; set; }
        public decimal thucThu { get; set; }
        public string trangThai { get; set; }

        public ChiTietLopHoc(int maLopHocChiTiet, int maLopHoc, decimal phiDiaDiem, decimal tongThu, decimal giamGia, decimal tienHoanLai, decimal nguyenLieu, decimal phiKhac, decimal thucThu, string trangThai)
        {
            this.maLopHocChiTiet = maLopHocChiTiet;
            this.maLopHoc = maLopHoc;
            this.phiDiaDiem = phiDiaDiem;
            this.tongThu = tongThu;
            this.giamGia = giamGia;
            this.tienHoanLai = tienHoanLai;
            this.nguyenLieu = nguyenLieu;
            this.phiKhac = phiKhac;
            this.thucThu = thucThu;
            this.trangThai = trangThai;
        }

        public ChiTietLopHoc(DataRow row)
        {
            maLopHocChiTiet = Convert.ToInt32(row["MaLopHocChiTiet"]);
            maLopHoc = Convert.ToInt32(row["MaLopHoc"]);
            phiDiaDiem = Convert.ToDecimal(row["PhiDiaDiem"]);
            tongThu = Convert.ToDecimal(row["TongThu"]);
            giamGia = Convert.ToDecimal(row["GiamGia"]);
            tienHoanLai = Convert.ToDecimal(row["TienHoanLai"]);
            nguyenLieu = Convert.ToDecimal(row["NguyenLieu"]);
            phiKhac = Convert.ToDecimal(row["PhiKhac"]);
            thucThu = Convert.ToDecimal(row["ThucThu"]);
            trangThai = row["TrangThai"].ToString();
        }
    }
}
