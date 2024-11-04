using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingClassManagementSystem.DAO
{
    public class ThongTinQuangCaoLopHocDAO
    {
        private static ThongTinQuangCaoLopHocDAO instance;
        public static ThongTinQuangCaoLopHocDAO Instance
        {
            get { if (instance == null) instance = new ThongTinQuangCaoLopHocDAO(); return instance; }
            private set { instance = value; }
        }
        private ThongTinQuangCaoLopHocDAO() { }
    }
}
