using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class MonAnDAO
    {
        private static MonAnDAO instance;
        public static MonAnDAO Instance
        {
            get { if (instance == null) { instance = new MonAnDAO(); } return instance; }
            private set { instance = value; }
        }
        private MonAnDAO() { }
    }
}
