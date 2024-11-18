using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class DanhGiaHocVienDAO
    {
        private static DanhGiaHocVienDAO instance;
        public static DanhGiaHocVienDAO Instance
        { get { if (instance == null) instance = new DanhGiaHocVienDAO(); return instance; } 
           private set { instance = value; }
        }
        private DanhGiaHocVienDAO() { }
    }
}
