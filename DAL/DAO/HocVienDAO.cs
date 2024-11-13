using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class HocVienDAO
    {
        private static HocVienDAO instance;
        public static HocVienDAO Instance
        {
            get { if (instance == null) instance = new HocVienDAO(); return instance; }
            private set { instance = value; }
        }
        private HocVienDAO() { }
    }
}
