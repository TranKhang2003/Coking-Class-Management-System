using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingClassManagementSystem.DAO
{
    public class MaGiamGiaDAO
    {
        private static MaGiamGiaDAO instance;
        public static MaGiamGiaDAO Instance
        {
            get { if (instance == null) instance = new MaGiamGiaDAO(); return instance; }
           private set { instance = value; }
        }
        private MaGiamGiaDAO() { }
    }
}
