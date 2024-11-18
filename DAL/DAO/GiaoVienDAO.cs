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
        public List<string> GetTeachers()
        {
            string query = "SELECT id, HoTen, ChuyenMon FROM GiaoVien"; 
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            List<string> teacherList = new List<string>();
            foreach (DataRow row in data.Rows)
            {
                string teacherInfo = $"{row["id"]} - {row["HoTen"]} - {row["ChuyenMon"]}";
                teacherList.Add(teacherInfo); 
            }
            return teacherList;
        }
    }
}
