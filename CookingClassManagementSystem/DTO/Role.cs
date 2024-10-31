using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingClassManagementSystem.DTO
{
    public class Role
    {
        private int id;
        private string roleName;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string RoleName
        {
            get => roleName;
            set => roleName = value;
        }
    }

}
