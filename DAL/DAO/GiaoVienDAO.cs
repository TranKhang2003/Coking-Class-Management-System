using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
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
        public DataTable getGiaoVienId(string hoten)
        {
            int id = 0;
            string query = "select GiaoVien.id from GiaoVien where HoTen = @hoten";
            object[] para = new object[] {hoten};
            return DataProvider.Instance.ExcuteQuery(query, para);
        }
    }
}
