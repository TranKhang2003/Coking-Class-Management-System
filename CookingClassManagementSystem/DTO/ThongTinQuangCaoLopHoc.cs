using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingClassManagementSystem.DTO
{
    public class ThongTinQuangCaoLopHoc
    {
        public int MaThongTin { get; set; }
        public int MaLopHoc { get; set; }
        public int IdNguoiViet { get; set; }
        public bool TrangThaiBaiDang { get; set; }
        public bool ChayADS { get; set; }

        public ThongTinQuangCaoLopHoc(int maThongTin, int maLopHoc, int idNguoiViet, bool trangThaiBaiDang, bool chayADS)
        {
            MaThongTin = maThongTin;
            MaLopHoc = maLopHoc;
            IdNguoiViet = idNguoiViet;
            TrangThaiBaiDang = trangThaiBaiDang;
            ChayADS = chayADS;
        }
    }
}
