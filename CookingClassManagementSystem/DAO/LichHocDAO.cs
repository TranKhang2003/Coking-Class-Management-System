using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingClassManagementSystem.DAO
{
    public class LichHocDAO
    {
        private static LichHocDAO instance;
        public static LichHocDAO Instance
        {
            get { if (instance == null) { instance = new LichHocDAO(); } return instance; }
            private set { instance = value; }
        }
        private LichHocDAO() { }

    }
}
