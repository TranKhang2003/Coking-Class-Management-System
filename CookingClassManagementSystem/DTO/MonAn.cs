using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingClassManagementSystem.DTO
{
    public class MonAn
    {
        public string TenMon { get; set; }
        public string HinhAnhMon { get; set; }
        public string LoaiMon { get; set; }

        public MonAn(string tenMon, string hinhAnhMon, string loaiMon)
        {
            TenMon = tenMon;
            HinhAnhMon = hinhAnhMon;
            LoaiMon = loaiMon;
        }
    }
}
