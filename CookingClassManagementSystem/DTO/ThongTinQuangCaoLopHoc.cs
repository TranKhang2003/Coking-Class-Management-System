using System;
using System.Data;

namespace CookingClassManagementSystem.DTO
{
    public class ThongTinQuangCaoLopHoc
    {
        public int maThongTin { get; set; }
        public int maLopHoc { get; set; }
        public int idNguoiViet { get; set; }
        public bool trangThaiBaiDang { get; set; }
        public bool chayADS { get; set; }

        public ThongTinQuangCaoLopHoc(int maThongTin, int maLopHoc, int idNguoiViet, bool trangThaiBaiDang, bool chayADS)
        {
            this.maThongTin = maThongTin;
            this.maLopHoc = maLopHoc;
            this.idNguoiViet = idNguoiViet;
            this.trangThaiBaiDang = trangThaiBaiDang;
            this.chayADS = chayADS;
        }

        public ThongTinQuangCaoLopHoc(DataRow row)
        {
            maThongTin = Convert.ToInt32(row["MaThongTin"]);
            maLopHoc = Convert.ToInt32(row["MaLopHoc"]);
            idNguoiViet = Convert.ToInt32(row["IdNguoiViet"]);
            trangThaiBaiDang = Convert.ToBoolean(row["TrangThaiBaiDang"]);
            chayADS = Convert.ToBoolean(row["ChayADS"]);
        }
    }
}
