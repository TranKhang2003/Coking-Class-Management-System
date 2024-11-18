using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopHocCoPhiDTO : LopHocDTO
    {
       
        public decimal hocPhi { get; set; }

        public LopHocCoPhiDTO(int maLopHoc, string monAn, int giaoVienId, string diaDiem, int soNguoiDangKy, int soNguoiDangKyToiDa, string thongTin, string ghiChu, decimal hocPhi)
            : base(maLopHoc, monAn, giaoVienId, diaDiem, soNguoiDangKy, soNguoiDangKyToiDa, thongTin, ghiChu)
        {
            this.hocPhi = hocPhi;
        }

        public decimal TinhDoanhThu()
        {
            return soNguoiDangKy * hocPhi;
        }
        
    }
}
