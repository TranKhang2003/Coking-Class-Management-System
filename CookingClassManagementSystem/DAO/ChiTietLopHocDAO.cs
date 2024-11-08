using CookingClassManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingClassManagementSystem.DAO
{
    public class ChiTietLopHocDAO
    {
        private static ChiTietLopHocDAO instance;
        public static ChiTietLopHocDAO Instance
        { get { if (instance == null) instance = new ChiTietLopHocDAO(); return instance; }
            private set {
                instance = value;
                        }
        }
        public bool AddChiTietLopHocDAO(ChiTietLopHoc chiTietLopHoc)
        {
            object[] para = new object[]
            {
                chiTietLopHoc.maLopHoc,
                chiTietLopHoc.phiDiaDiem,
                chiTietLopHoc.tongThu,
                chiTietLopHoc.giamGia,
                chiTietLopHoc.tienHoanLai,
                chiTietLopHoc.nguyenLieu,
                chiTietLopHoc.phiKhac,
                chiTietLopHoc.thucThu,
                chiTietLopHoc.trangThai
            };
            object data = DataProvider.Instance.ExcuteNonQuery("exec P_AddChiTietLopHoc @MaLopHoc , @PhiDiaDiem , @TongThu , @GiamGia , @TienHoanLai , @NguyenLieu , @PhiKhac , @ThucThu , @TrangThai", para);
            return (int)data > 0;
        }
    }
}
