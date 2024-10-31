using System;
using System.Collections.Generic;
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
    }
}
