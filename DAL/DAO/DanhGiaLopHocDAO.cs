using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class DanhGiaLopHocDAO
    {
        private static DanhGiaLopHocDAO instance;
        public static DanhGiaLopHocDAO Instace
        {  get {  if (instance == null) instance = new DanhGiaLopHocDAO(); return instance; }
            private set { instance = value; }
        }
        private DanhGiaLopHocDAO() { }
    }
}
