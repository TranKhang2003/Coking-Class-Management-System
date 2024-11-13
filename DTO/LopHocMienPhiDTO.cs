using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopHocMienPhiDTO
    {
        public int maLopHoc { get; set; }
        public string nhanHangHocTac { get; set; }
        public int lopHocNauAnId { get; set; }

        public LopHocMienPhiDTO(int maLopHoc, string nhanHangHocTac, int lopHocNauAnId)
        {
            this.maLopHoc = maLopHoc;
            this.nhanHangHocTac = nhanHangHocTac;
            this.lopHocNauAnId = lopHocNauAnId;
        }

        public LopHocMienPhiDTO(DataRow row)
        {
            maLopHoc = Convert.ToInt32(row["MaLopHoc"]);
            nhanHangHocTac = row["NhanHangHocTac"].ToString();
            lopHocNauAnId = Convert.ToInt32(row["LopHocNauAnId"]);
        }
    }
}
