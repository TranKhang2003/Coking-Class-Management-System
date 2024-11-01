using System;
using System.Data;

namespace CookingClassManagementSystem.DTO
{
    public class LopHocCoPhi
    {
        public int maLopHoc { get; set; }
        public int lopHocNauAnId { get; set; }

        public LopHocCoPhi(int maLopHoc, int lopHocNauAnId)
        {
            this.maLopHoc = maLopHoc;
            this.lopHocNauAnId = lopHocNauAnId;
        }

        public LopHocCoPhi(DataRow row)
        {
            maLopHoc = Convert.ToInt32(row["MaLopHoc"]);
            lopHocNauAnId = Convert.ToInt32(row["LopHocNauAnId"]);
        }
    }
}
