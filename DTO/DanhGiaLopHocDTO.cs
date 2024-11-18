using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanhGiaLopHocDTO
    {
        public int id { get; set; }
        public int maLopHoc { get; set; }
        public int hocVienId { get; set; }
        public int diemDanhGia { get; set; }
        public string nhanXet { get; set; }
        public DateTime ngayDanhGia { get; set; }

        public DanhGiaLopHocDTO(int id, int maLopHoc, int hocVienId, int diemDanhGia, string nhanXet, DateTime ngayDanhGia)
        {
            this.id = id;
            this.maLopHoc = maLopHoc;
            this.hocVienId = hocVienId;
            this.diemDanhGia = diemDanhGia;
            this.nhanXet = nhanXet;
            this.ngayDanhGia = ngayDanhGia;
        }

        public DanhGiaLopHocDTO(DataRow row)
        {
            id = Convert.ToInt32(row["Id"]);
            maLopHoc = Convert.ToInt32(row["MaLopHoc"]);
            hocVienId = Convert.ToInt32(row["HocVienId"]);
            diemDanhGia = Convert.ToInt32(row["DiemDanhGia"]);
            nhanXet = row["NhanXet"].ToString();
            ngayDanhGia = Convert.ToDateTime(row["NgayDanhGia"]);
        }
    }
}
