using System;
using System.Data;

namespace CookingClassManagementSystem.DTO
{
    public class LichHoc
    {
        public int maLichHoc { get; set; }
        public int maLopHoc { get; set; }
        public DateTime ngay { get; set; }
        public decimal chiPhi { get; set; }
        public TimeSpan thoiGianBatDau { get; set; }
        public TimeSpan thoiGianKetThuc { get; set; }

        public LichHoc(int maLichHoc, int maLopHoc, DateTime ngay, decimal chiPhi, TimeSpan thoiGianBatDau, TimeSpan thoiGianKetThuc)
        {
            this.maLichHoc = maLichHoc;
            this.maLopHoc = maLopHoc;
            this.ngay = ngay;
            this.chiPhi = chiPhi;
            this.thoiGianBatDau = thoiGianBatDau;
            this.thoiGianKetThuc = thoiGianKetThuc;
        }

        public LichHoc(DataRow row)
        {
            maLichHoc = Convert.ToInt32(row["MaLichHoc"]);
            maLopHoc = Convert.ToInt32(row["MaLopHoc"]);
            ngay = Convert.ToDateTime(row["Ngay"]);
            chiPhi = Convert.ToDecimal(row["ChiPhi"]);
            thoiGianBatDau = (TimeSpan)row["ThoiGianBatDau"];
            thoiGianKetThuc = (TimeSpan)row["ThoiGianKetThuc"];
        }
    }
}
