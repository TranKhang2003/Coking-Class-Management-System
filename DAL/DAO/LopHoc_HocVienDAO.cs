using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class LopHoc_HocVienDAO
    {
        private static LopHoc_HocVienDAO instance;
        public static LopHoc_HocVienDAO Instance
        {
            get { if (instance == null) instance = new LopHoc_HocVienDAO(); return instance; }
            private set { instance = value; }
        }
        private LopHoc_HocVienDAO() { }
    }
}
