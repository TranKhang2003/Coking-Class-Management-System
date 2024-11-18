using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class HoanTienBaoLuuDAO
    {
        private static HoanTienBaoLuuDAO instance;
        public static HoanTienBaoLuuDAO Instance
        {
            get { if (instance == null) instance = new HoanTienBaoLuuDAO(); return instance; }
            private set { instance = value; }
        }
        private HoanTienBaoLuuDAO() { }
    }
}
