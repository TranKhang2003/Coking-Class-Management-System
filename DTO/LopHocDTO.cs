using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopHocDTO
    {
        public int maLopHoc { get; set; }
        public string monAn { get; set; }
        public int giaoVienId { get; set; }
        public string diaDiem { get; set; }
        public int soNguoiDangKy { get; set; }
        public int soNguoiDangKyToiDa { get; set; }
        public string thongTin { get; set; }
        public string ghiChu { get; set; }

        public LopHocDTO(int maLopHoc, string monAn, int giaoVienId, string diaDiem, int soNguoiDangKy, int soNguoiDangKyToiDa, string thongTin, string ghiChu)
        {
            this.maLopHoc = maLopHoc;
            this.monAn = monAn;
            this.giaoVienId = giaoVienId;
            this.diaDiem = diaDiem;
            this.soNguoiDangKy = soNguoiDangKy;
            this.soNguoiDangKyToiDa = soNguoiDangKyToiDa;
            this.thongTin = thongTin;
            this.ghiChu = ghiChu;
        }

        public LopHocDTO(DataRow row)
        {
            maLopHoc = Convert.ToInt32(row["MaLopHoc"]);
            monAn = row["MonAn"].ToString();
            giaoVienId = Convert.ToInt32(row["GiaoVienId"]);
            diaDiem = row["DiaDiem"].ToString();
            soNguoiDangKy = Convert.ToInt32(row["SoNguoiDangKy"]);
            soNguoiDangKyToiDa = Convert.ToInt32(row["SoNguoiDangKyToiDa"]);
            thongTin = row["ThongTin"].ToString();
            ghiChu = row["GhiChu"].ToString();
        }
    }
}
