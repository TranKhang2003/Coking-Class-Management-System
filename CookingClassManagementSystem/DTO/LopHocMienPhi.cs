using System;
using System.Data;

namespace CookingClassManagementSystem.DTO
{
    public class LopHocMienPhi
    {
        public int maLopHoc { get; set; }
        public string nhanHangHocTac { get; set; }
        public int lopHocNauAnId { get; set; }

        public LopHocMienPhi(int maLopHoc, string nhanHangHocTac, int lopHocNauAnId)
        {
            this.maLopHoc = maLopHoc;
            this.nhanHangHocTac = nhanHangHocTac;
            this.lopHocNauAnId = lopHocNauAnId;
        }

        public LopHocMienPhi(DataRow row)
        {
            maLopHoc = Convert.ToInt32(row["MaLopHoc"]);
            nhanHangHocTac = row["NhanHangHocTac"].ToString();
            lopHocNauAnId = Convert.ToInt32(row["LopHocNauAnId"]);
        }
    }
}
