using System;
using System.Data;

namespace CookingClassManagementSystem.DTO
{
    public class MonAn
    {
        public string tenMon { get; set; }
        public string hinhAnhMon { get; set; }
        public string loaiMon { get; set; }

        public MonAn(string tenMon, string hinhAnhMon, string loaiMon)
        {
            this.tenMon = tenMon;
            this.hinhAnhMon = hinhAnhMon;
            this.loaiMon = loaiMon;
        }

        public MonAn(DataRow row)
        {
            tenMon = row["TenMon"].ToString();
            hinhAnhMon = row["HinhAnhMon"].ToString();
            loaiMon = row["LoaiMon"].ToString();
        }
    }
}
