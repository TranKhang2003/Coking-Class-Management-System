
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL.DAO
{
    public class LichHocDAO
    {
        private static LichHocDAO instance;
        public static LichHocDAO Instance
        {
            get { if (instance == null) { instance = new LichHocDAO(); } return instance; }
            private set { instance = value; }
        }
        private LichHocDAO() { }
        public bool AddLichHoc(LichHocDTO lichHoc)
        {
            object[] para = new object[]
            {
                lichHoc.maLopHoc,
                lichHoc.ngay,
                lichHoc.chiPhi,
                lichHoc.thoiGianBatDau,
                lichHoc.thoiGianKetThuc
            };
            object data = DataProvider.Instance.ExcuteNonQuery("exec P_AddLichHoc @MaLopHoc , @Ngay , @ChiPhi , @ThoiGianBatDau , @ThoiGianKetThuc", para);
            return (int)data > 0;
        }
    }
}
