using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingClassManagementSystem.DTO
{
    public class LichHoc
    {
        public int MaLichHoc { get; set; }
        public int MaLopHoc { get; set; }
        public DateTime Ngay { get; set; }
        public decimal ChiPhi { get; set; }
        public TimeSpan ThoiGianBatDau { get; set; }
        public TimeSpan ThoiGianKetThuc { get; set; }

        public LichHoc(int maLichHoc, int maLopHoc, DateTime ngay, decimal chiPhi, TimeSpan thoiGianBatDau, TimeSpan thoiGianKetThuc)
        {
            MaLichHoc = maLichHoc;
            MaLopHoc = maLopHoc;
            Ngay = ngay;
            ChiPhi = chiPhi;
            ThoiGianBatDau = thoiGianBatDau;
            ThoiGianKetThuc = thoiGianKetThuc;
        }
        public LichHoc(DataRow row)
        {
            MaLichHoc = Convert.ToInt32(row["MaLichHoc"]);
            MaLopHoc = Convert.ToInt32(row["MaLopHoc"]);
            Ngay = Convert.ToDateTime(row["Ngay"]);
            ChiPhi = Convert.ToDecimal(row["ChiPhi"]);
            ThoiGianBatDau = (TimeSpan)row["ThoiGianBatDau"];
            ThoiGianKetThuc = (TimeSpan)row["ThoiGianKetThuc"];
        }
    }
}
