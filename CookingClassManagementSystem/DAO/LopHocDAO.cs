using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
