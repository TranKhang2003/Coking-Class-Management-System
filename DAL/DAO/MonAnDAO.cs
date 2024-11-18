using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public List<string> GetAllMonAn()
        {
            List<string> listMonAn = new List<string>();
            string query = "SELECT TenMon FROM MonAn"; 

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                listMonAn.Add(row["TenMon"].ToString());
            }

            return listMonAn;
        }
        public bool AddMonAn(MonAnDTO monAn)
        {
            string query = "INSERT INTO MonAn (TenMon, HinhAnhMon, LoaiMon) VALUES (@TenMon , @HinhAnhMon , @LoaiMon)";

            
            object[] parameters = new object[]
            {
                monAn.tenMon,
                monAn.hinhAnhMon,
                monAn.loaiMon
            };

            
            int result = (int)DataProvider.Instance.ExcuteNonQuery(query, parameters);
            return result > 0; 
        }



    }
}
