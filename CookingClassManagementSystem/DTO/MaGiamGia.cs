using System;
using System.Data;

namespace CookingClassManagementSystem.DTO
{
    public class MaGiamGia
    {
        public int ma { get; set; }
        public decimal giaTri { get; set; }
        public string loai { get; set; }
        public int phanTramGiamGia { get; set; }
        public int code { get; set; }

        public MaGiamGia(int ma, decimal giaTri, string loai, int phanTramGiamGia, int code)
        {
            this.ma = ma;
            this.giaTri = giaTri;
            this.loai = loai;
            this.phanTramGiamGia = phanTramGiamGia;
            this.code = code;
        }

        public MaGiamGia(DataRow row)
        {
            ma = Convert.ToInt32(row["Ma"]);
            giaTri = Convert.ToDecimal(row["GiaTri"]);
            loai = row["Loai"].ToString();
            phanTramGiamGia = Convert.ToInt32(row["PhanTramGiamGia"]);
            code = Convert.ToInt32(row["Code"]);
        }
    }
}
