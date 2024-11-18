using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RoleDTO
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
        public RoleDTO(DataRow row)
        {
            Id = Convert.ToInt32(row["Id"]);
            RoleName = row["RoleName"].ToString();
        }
    }
}
