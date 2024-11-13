using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopHocCoPhiDTO
    {
        public int maLopHoc { get; set; }
        public int lopHocNauAnId { get; set; }

        public LopHocCoPhiDTO(int maLopHoc, int lopHocNauAnId)
        {
            this.maLopHoc = maLopHoc;
            this.lopHocNauAnId = lopHocNauAnId;
        }

        public LopHocCoPhiDTO(DataRow row)
        {
            maLopHoc = Convert.ToInt32(row["MaLopHoc"]);
            lopHocNauAnId = Convert.ToInt32(row["LopHocNauAnId"]);
        }
    }
}
