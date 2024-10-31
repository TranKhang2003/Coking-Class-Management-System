using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingClassManagementSystem.DTO
{
    public class HoanTienBaoLuu
    {
        public int Id { get; set; }
        public int HocVienId { get; set; }
        public int LopHocNauAnId { get; set; }
        public decimal SoTienHoanLai { get; set; }
        public string TrangThai { get; set; }
        public int? LopHocChuyenSangId { get; set; }

        public HoanTienBaoLuu(int id, int hocVienId, int lopHocNauAnId, decimal soTienHoanLai, string trangThai, int? lopHocChuyenSangId)
        {
            Id = id;
            HocVienId = hocVienId;
            LopHocNauAnId = lopHocNauAnId;
            SoTienHoanLai = soTienHoanLai;
            TrangThai = trangThai;
            LopHocChuyenSangId = lopHocChuyenSangId;
        }
    }
}
