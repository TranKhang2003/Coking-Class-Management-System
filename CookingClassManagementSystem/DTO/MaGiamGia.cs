using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingClassManagementSystem.DTO
{
    public class MaGiamGia
    {
        public int Ma { get; set; }
        public decimal GiaTri { get; set; }
        public string Loai { get; set; }
        public int PhanTramGiamGia { get; set; }
        public int Code { get; set; }

        public MaGiamGia(int ma, decimal giaTri, string loai, int phanTramGiamGia, int code)
        {
            Ma = ma;
            GiaTri = giaTri;
            Loai = loai;
            PhanTramGiamGia = phanTramGiamGia;
            Code = code;
        }
    }
}
