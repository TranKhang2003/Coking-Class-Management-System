using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopHocMienPhiDTO : LopHocDTO
    {
    
        public int maLopHoc { get; set; }
        public string nhanHangHocTac { get; set; }
        public int lopHocNauAnId { get; set; }

        public LopHocMienPhiDTO(int maLopHoc, string monAn, int giaoVienId, string diaDiem, int soNguoiDangKy, int soNguoiDangKyToiDa, string thongTin, string ghiChu, string nhaHangHopTac,int lopHocNauAn)
            : base(maLopHoc, monAn, giaoVienId, diaDiem, soNguoiDangKy, soNguoiDangKyToiDa, thongTin, ghiChu)
        {
            this.maLopHoc = maLopHoc;
            this.nhanHangHocTac = nhanHangHocTac;
            this.lopHocNauAnId = lopHocNauAnId;
        }

       
    }
}
