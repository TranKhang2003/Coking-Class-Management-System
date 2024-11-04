using System;
using System.Data;

namespace CookingClassManagementSystem.DTO
{
    public class LopHoc_HocVien
    {
        public int lopHocNauAnId { get; set; }
        public int hocVienId { get; set; }
        public DateTime ngayGioDangKy { get; set; }
        public string trangThaiDangKy { get; set; }
        public decimal soTienDaThanhToan { get; set; }
        public bool hinhThucThanhToan { get; set; }
        public string trangThaiThanhToan { get; set; }
        public int? maGiamGia { get; set; }

        public LopHoc_HocVien(int lopHocNauAnId, int hocVienId, DateTime ngayGioDangKy, string trangThaiDangKy, decimal soTienDaThanhToan, bool hinhThucThanhToan, string trangThaiThanhToan, int? maGiamGia)
        {
            this.lopHocNauAnId = lopHocNauAnId;
            this.hocVienId = hocVienId;
            this.ngayGioDangKy = ngayGioDangKy;
            this.trangThaiDangKy = trangThaiDangKy;
            this.soTienDaThanhToan = soTienDaThanhToan;
            this.hinhThucThanhToan = hinhThucThanhToan;
            this.trangThaiThanhToan = trangThaiThanhToan;
            this.maGiamGia = maGiamGia;
        }

        public LopHoc_HocVien(DataRow row)
        {
            lopHocNauAnId = Convert.ToInt32(row["LopHocNauAnId"]);
            hocVienId = Convert.ToInt32(row["HocVienId"]);
            ngayGioDangKy = Convert.ToDateTime(row["NgayGioDangKy"]);
            trangThaiDangKy = row["TrangThaiDangKy"].ToString();
            soTienDaThanhToan = Convert.ToDecimal(row["SoTienDaThanhToan"]);
            hinhThucThanhToan = Convert.ToBoolean(row["HinhThucThanhToan"]);
            trangThaiThanhToan = row["TrangThaiThanhToan"].ToString();
            maGiamGia = row["MaGiamGia"] != DBNull.Value ? (int?)Convert.ToInt32(row["MaGiamGia"]) : null;
        }
    }
}
