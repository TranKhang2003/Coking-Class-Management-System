using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingClassManagementSystem.DAO
{
    public class LopHocMienPhiDAO
    {
        private static LopHocMienPhiDAO instance;
        public static LopHocMienPhiDAO Instance
        {
            get { if (instance == null) instance = new LopHocMienPhiDAO(); return instance; }
            private set { instance = value; }
        }
        private LopHocMienPhiDAO() { }
        
    }
}   
