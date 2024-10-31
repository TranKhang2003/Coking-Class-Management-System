using System;
using System.Collections.Generic;
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
    }
}
