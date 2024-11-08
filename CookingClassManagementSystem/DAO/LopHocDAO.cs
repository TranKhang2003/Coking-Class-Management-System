using CookingClassManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookingClassManagementSystem.DAO
{
    public class LopHocDAO
    {
        private static LopHocDAO instance;
        public static LopHocDAO Instance
        {
            get { if (instance == null) instance = new LopHocDAO(); return instance; }
            private set { instance = value; }
        }
        private LopHocDAO() { }
        public DataTable GetClass()
        {
            return DataProvider.Instance.ExcuteQuery("select MonAn.TenMon, MonAn.HinhAnhMon, LichHoc.ChiPhi from MonAn join LopHocNauAn on MonAn.TenMon = LopHocNauAn.MonAn join LichHoc on LopHocNauAn.MaLopHoc = LichHoc.MaLopHoc");
        }
        public DataTable GetClassDetail(string tenmon)
        {
            string query = "SELECT MonAn.TenMon, LopHocNauAn.ThongTin, LopHocNauAn.GhiChu, GiaoVien.HoTen, LichHoc.Ngay, LopHocNauAn.DiaDiem, LichHoc.ChiPhi, ChiTietLopHoc.TrangThai, LopHocNauAn.SoNguoiDangKy, LopHocNauAn.SoNguoiDangKyToiDA " +
                           "FROM MonAn, LopHocNauAn, GiaoVien, LichHoc, ChiTietLopHoc " +
                           "WHERE MonAn.TenMon = @TenMon AND MonAn.TenMon = LopHocNauAn.MonAn " +
                           "AND GiaoVien.id = LopHocNauAn.GiaoVienId " +
                           "AND LichHoc.MaLopHoc = LopHocNauAn.MaLopHoc " +
                           "AND ChiTietLopHoc.MaLopHoc = LopHocNauAn.MaLopHoc";

            string[] parameters = new string[] { tenmon };

            return DataProvider.Instance.ExcuteQuery(query, parameters);
        }
        public bool AddClass(LopHoc lopHoc)
        {
            string query = "P_AddLopHocNauAn @MonAn , @GiaoVienId , @DiaDiem, @SoNguoiDangKyToiDA, @ThongTin, @GhiChu";

            object[] parameters = new object[]
            {
                lopHoc.monAn,
                lopHoc.giaoVienId,
                lopHoc.diaDiem,
                lopHoc.soNguoiDangKy,
                lopHoc.soNguoiDangKyToiDa,
                lopHoc.thongTin,
                lopHoc.ghiChu
            };

            object result = DataProvider.Instance.ExcuteNonQuery(query, parameters);
            return (int)result > 0;
        }
        public int AddClassReturnId(LopHoc lopHoc)
        {
            object[] parameters = new object[]
            {
                lopHoc.monAn,
                lopHoc.giaoVienId,
                lopHoc.diaDiem,
                lopHoc.soNguoiDangKyToiDa,
                lopHoc.thongTin,
                lopHoc.ghiChu
            };

            object outputValue;
            int result = DataProvider.Instance.ExecuteNonQueryWithOutputMaLopHoc(
                "EXEC P_AddLopHocNauAn @MonAn , @GiaoVienId , @DiaDiem , @SoNguoiDangKyToiDA , @ThongTin , @GhiChu , @MaLopHoc OUTPUT",
                parameters,
                out outputValue
            );
            if ((int)outputValue != 0)
            {
                int maLopHoc = (int)outputValue; // Lấy ID lớp học vừa được thêm
            }

            return (int)outputValue;
        }

        public bool AddClassAll(LopHoc lopHoc, ChiTietLopHoc chiTietLopHoc, LichHoc lichHoc, LopHocMienPhi lopHocMienPhi)
        {
            string query = "INSERT INTO LopHocNauAn (MonAn, GiaoVienId, DiaDiem, SoNguoiDangKy, SoNguoiDangKyToiDa, ThongTin, GhiChu) " +
                           "VALUES (@MonAn, @GiaoVienId, @DiaDiem, @SoNguoiDangKy, @SoNguoiDangKyToiDa, @ThongTin, @GhiChu)";

            object[] parameters = new object[]
            {
                lopHoc.monAn,
                lopHoc.giaoVienId,
                lopHoc.diaDiem,
                lopHoc.soNguoiDangKy,
                lopHoc.soNguoiDangKyToiDa,
                lopHoc.thongTin,
                lopHoc.ghiChu
            };

            object result = DataProvider.Instance.ExcuteNonQuery(query, parameters);
            return (int)result > 0;

        }
     }
}
