using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingClassManagementSystem.DTO
{
    public class LopHocCoPhi
    {
        public int MaLopHoc { get; set; }
        public int LopHocNauAnId { get; set; }

        public LopHocCoPhi(int maLopHoc, int lopHocNauAnId)
        {
            MaLopHoc = maLopHoc;
            LopHocNauAnId = lopHocNauAnId;
        }
        public LopHocCoPhi(DataRow row)
        {
            MaLopHoc = Convert.ToInt32(row["MaLopHoc"]);
            LopHocNauAnId = Convert.ToInt32(row["LopHocNauAnId"]);
        }
    }
}
