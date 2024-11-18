using DAL.DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL
{
    public class LopHocBLL
    {


        public static DataTable LayLopHoc()
        {
            return LopHocDAO.Instance.GetClass();
        }
        public static DataTable LayThongTinLopHocChon(LichHocDTO lichHocDTO)
        {
            return LopHocDAO.Instance.XemLopHoc(lichHocDTO);
        }
        public static bool ThemLophoc(LopHocDTO lichHocDTO)
        {
            return LopHocDAO.Instance.AddClass(lichHocDTO);
        }
        public static bool ThemMonAn(MonAnDTO monAn)
        {
            return MonAnDAO.Instance.AddMonAn(monAn);
        }
        public static List<string> LayMonAn()
        {
            return MonAnDAO.Instance.GetAllMonAn(); 
        }
        public static List<string> LayDanhSachGiaoVien()
        {
            return GiaoVienDAO.Instance.GetTeachers(); 
        }

    }
}
