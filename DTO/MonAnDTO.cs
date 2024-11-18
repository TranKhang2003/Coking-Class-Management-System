using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonAnDTO
    {
        public string tenMon { get; set; }
        public string hinhAnhMon { get; set; }
        public string loaiMon { get; set; }

        public MonAnDTO(string tenMon, string hinhAnhMon, string loaiMon)
        {
            this.tenMon = tenMon;
            this.hinhAnhMon = hinhAnhMon;
            this.loaiMon = loaiMon;
        }

        public MonAnDTO(DataRow row)
        {
            tenMon = row["TenMon"].ToString();
            hinhAnhMon = row["HinhAnhMon"].ToString();
            loaiMon = row["LoaiMon"].ToString();
        }
  
    }
}
