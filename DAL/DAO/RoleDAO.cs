using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class RoleDAO
    {
        private static RoleDAO instance;
        public static RoleDAO Instance
        {
            get { if (instance == null) { instance = new RoleDAO(); } return instance; }
            private set { instance = value; }
        }
        private RoleDAO() { }
    }
}
