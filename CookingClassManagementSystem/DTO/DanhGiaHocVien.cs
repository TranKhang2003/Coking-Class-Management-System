﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingClassManagementSystem.DTO
{
    public class DanhGiaHocVien
    {
        public int Id { get; set; }
        public int MaLopHoc { get; set; }
        public int HocVienId { get; set; }
        public int GiaoVienId { get; set; }
        public string NhanXet { get; set; }
        public DateTime NgayDanhGia { get; set; }

        public DanhGiaHocVien(int id, int maLopHoc, int hocVienId, int giaoVienId, string nhanXet, DateTime ngayDanhGia)
        {
            Id = id;
            MaLopHoc = maLopHoc;
            HocVienId = hocVienId;
            GiaoVienId = giaoVienId;
            NhanXet = nhanXet;
            NgayDanhGia = ngayDanhGia;
        }
        public DanhGiaHocVien(DataRow row)
        {
            Id = Convert.ToInt32(row["Id"]);
            MaLopHoc = Convert.ToInt32(row["MaLopHoc"]);
            HocVienId = Convert.ToInt32(row["HocVienId"]);
            GiaoVienId = Convert.ToInt32(row["GiaoVienId"]);
            NhanXet = row["NhanXet"].ToString();
            NgayDanhGia = Convert.ToDateTime(row["NgayDanhGia"]);
        }
    }
}
