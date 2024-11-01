using System;
using System.Collections.Generic;
using System.Data;
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
        public HoanTienBaoLuu(DataRow row)
        {
            Id = Convert.ToInt32(row["Id"]);
            HocVienId = Convert.ToInt32(row["HocVienId"]);
            LopHocNauAnId = Convert.ToInt32(row["LopHocNauAnId"]);
            SoTienHoanLai = Convert.ToDecimal(row["SoTienHoanLai"]);
            TrangThai = row["TrangThai"].ToString();
            LopHocChuyenSangId = row["LopHocChuyenSangId"] != DBNull.Value ? (int?)Convert.ToInt32(row["LopHocChuyenSangId"]) : null;
        }
    }
}
