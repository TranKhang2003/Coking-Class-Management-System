using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiaoVienDTO
    {
        private int id;
        private int userId;
        private string hoTen;
        private DateTime ngaySinh;
        private bool gioiTinh;
        private string chuyenMon;
        private int soNamKinhNghiem;
        private string sdt;
        private decimal luong;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public int UserId
        {
            get => userId;
            set => userId = value;
        }

        public string HoTen
        {
            get => hoTen;
            set => hoTen = value;
        }

        public DateTime NgaySinh
        {
            get => ngaySinh;
            set => ngaySinh = value;
        }

        public bool GioiTinh
        {
            get => gioiTinh;
            set => gioiTinh = value;
        }

        public string ChuyenMon
        {
            get => chuyenMon;
            set => chuyenMon = value;
        }

        public int SoNamKinhNghiem
        {
            get => soNamKinhNghiem;
            set => soNamKinhNghiem = value;
        }

        public string Sdt
        {
            get => sdt;
            set => sdt = value;
        }

        public decimal Luong
        {
            get => luong;
            set => luong = value;
        }

        public GiaoVienDTO(int id, int userId, string hoTen, DateTime ngaySinh, bool gioiTinh, string chuyenMon, int soNamKinhNghiem, string sdt, decimal luong)
        {
            this.id = id;
            this.userId = userId;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.chuyenMon = chuyenMon;
            this.soNamKinhNghiem = soNamKinhNghiem;
            this.sdt = sdt;
            this.luong = luong;
        }
        public GiaoVienDTO(string hoTen)
        {
            this.hoTen = hoTen;
        }

      

        public GiaoVienDTO(DataRow row)
        {
            id = Convert.ToInt32(row["Id"]);
            userId = Convert.ToInt32(row["UserId"]);
            hoTen = row["HoTen"].ToString();
            ngaySinh = Convert.ToDateTime(row["NgaySinh"]);
            gioiTinh = Convert.ToBoolean(row["GioiTinh"]);
            chuyenMon = row["ChuyenMon"].ToString();
            soNamKinhNghiem = Convert.ToInt32(row["SoNamKinhNghiem"]);
            sdt = row["Sdt"].ToString();
            luong = Convert.ToDecimal(row["Luong"]);
        }
    }
}
