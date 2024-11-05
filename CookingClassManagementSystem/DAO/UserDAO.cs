using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingClassManagementSystem.DAO
{
    public class UserDAO
    {
        private static UserDAO instance;
        public static UserDAO Instance
        {
            get { if (instance == null) { instance = new UserDAO(); } return instance; }
            private set
            {
                instance = value;
            }
        }
            private UserDAO() { }
        
    }
}
