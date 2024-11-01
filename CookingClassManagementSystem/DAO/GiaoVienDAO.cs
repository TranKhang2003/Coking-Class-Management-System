using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingClassManagementSystem.DAO
{
    public class GiaoVienDAO
    {
        private static GiaoVienDAO instance;
        public static GiaoVienDAO Instance
        {
            get { if (instance == null) { instance = new GiaoVienDAO(); } return instance; }
            private set { instance = value; }
        }
        private GiaoVienDAO() { }

    }
}
