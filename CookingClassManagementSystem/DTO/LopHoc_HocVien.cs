using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingClassManagementSystem.DTO
{
    public class LopHocNauAnHocVien
    {
        public int LopHocNauAnId { get; set; }
        public int HocVienId { get; set; }
        public DateTime NgayGioDangKy { get; set; }
        public string TrangThaiDangKy { get; set; }
        public decimal SoTienDaThanhToan { get; set; }
        public bool HinhThucThanhToan { get; set; }
        public string TrangThaiThanhToan { get; set; }
        public int? MaGiamGia { get; set; }

        public LopHocNauAnHocVien(int lopHocNauAnId, int hocVienId, DateTime ngayGioDangKy, string trangThaiDangKy, decimal soTienDaThanhToan, bool hinhThucThanhToan, string trangThaiThanhToan, int? maGiamGia)
        {
            LopHocNauAnId = lopHocNauAnId;
            HocVienId = hocVienId;
            NgayGioDangKy = ngayGioDangKy;
            TrangThaiDangKy = trangThaiDangKy;
            SoTienDaThanhToan = soTienDaThanhToan;
            HinhThucThanhToan = hinhThucThanhToan;
            TrangThaiThanhToan = trangThaiThanhToan;
            MaGiamGia = maGiamGia;
        }
        public LopHocNauAnHocVien(DataRow row)
        {
            LopHocNauAnId = Convert.ToInt32(row["LopHocNauAnId"]);
            HocVienId = Convert.ToInt32(row["HocVienId"]);
            NgayGioDangKy = Convert.ToDateTime(row["NgayGioDangKy"]);
            TrangThaiDangKy = row["TrangThaiDangKy"].ToString();
            SoTienDaThanhToan = Convert.ToDecimal(row["SoTienDaThanhToan"]);
            HinhThucThanhToan = Convert.ToBoolean(row["HinhThucThanhToan"]);
            TrangThaiThanhToan = row["TrangThaiThanhToan"].ToString();
            MaGiamGia = row["MaGiamGia"] != DBNull.Value ? (int?)Convert.ToInt32(row["MaGiamGia"]) : null;
        }
    }
}
