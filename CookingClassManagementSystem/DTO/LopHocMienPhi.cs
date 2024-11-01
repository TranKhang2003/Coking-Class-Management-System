using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingClassManagementSystem.DTO
{
    public class LopHocMienPhi
    {
        public int MaLopHoc { get; set; }
        public string NhanHangHocTac { get; set; }
        public int LopHocNauAnId { get; set; }

        public LopHocMienPhi(int maLopHoc, string nhanHangHocTac, int lopHocNauAnId)
        {
            MaLopHoc = maLopHoc;
            NhanHangHocTac = nhanHangHocTac;
            LopHocNauAnId = lopHocNauAnId;
        }
        public LopHocMienPhi(DataRow row)
        {
            MaLopHoc = Convert.ToInt32(row["MaLopHoc"]);
            NhanHangHocTac = row["NhanHangHocTac"].ToString();
            LopHocNauAnId = Convert.ToInt32(row["LopHocNauAnId"]);
        }
    }
}
