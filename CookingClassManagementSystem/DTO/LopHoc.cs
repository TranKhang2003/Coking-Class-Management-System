﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingClassManagementSystem.DTO
{
    public class LopHoc
    {
        public int MaLopHoc { get; set; }
        public string MonAn { get; set; }
        public int GiaoVienId { get; set; }
        public string DiaDiem { get; set; }
        public int SoNguoiDangKy { get; set; }
        public int SoNguoiDangKyToiDa { get; set; }
        public string ThongTin { get; set; }
        public string GhiChu { get; set; }

        public LopHoc(int maLopHoc, string monAn, int giaoVienId, string diaDiem, int soNguoiDangKy, int soNguoiDangKyToiDa, string thongTin, string ghiChu)
        {
            MaLopHoc = maLopHoc;
            MonAn = monAn;
            GiaoVienId = giaoVienId;
            DiaDiem = diaDiem;
            SoNguoiDangKy = soNguoiDangKy;
            SoNguoiDangKyToiDa = soNguoiDangKyToiDa;
            ThongTin = thongTin;
            GhiChu = ghiChu;
        }
    }


}
