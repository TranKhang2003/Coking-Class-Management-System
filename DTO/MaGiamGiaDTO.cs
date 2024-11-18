using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class MaGiamGiaDTO
    {
        public int ma { get; set; }
        public decimal giaTri { get; set; }
        public string loai { get; set; }
        public int phanTramGiamGia { get; set; }
        public int code { get; set; }

        public MaGiamGiaDTO(int ma, decimal giaTri, string loai, int phanTramGiamGia, int code)
        {
            this.ma = ma;
            this.giaTri = giaTri;
            this.loai = loai;
            this.phanTramGiamGia = phanTramGiamGia;
            this.code = code;
        }

        public MaGiamGiaDTO(DataRow row)
        {
            ma = Convert.ToInt32(row["Ma"]);
            giaTri = Convert.ToDecimal(row["GiaTri"]);
            loai = row["Loai"].ToString();
            phanTramGiamGia = Convert.ToInt32(row["PhanTramGiamGia"]);
            code = Convert.ToInt32(row["Code"]);
        }
    }
}
