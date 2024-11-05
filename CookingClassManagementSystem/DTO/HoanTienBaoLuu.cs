using System;
using System.Data;

namespace CookingClassManagementSystem.DTO
{
    
    public class HoanTienBaoLuu
    {
        public int id { get; set; }                      
        public int hocVienId { get; set; }               
        public int lopHocNauAnId { get; set; }           
        public decimal soTienHoanLai { get; set; }        
        public string trangThai { get; set; }            
        public int? lopHocChuyenSangId { get; set; }     

        public HoanTienBaoLuu(int id, int hocVienId, int lopHocNauAnId, decimal soTienHoanLai, string trangThai, int? lopHocChuyenSangId)
        {
            this.id = id;
            this.hocVienId = hocVienId;
            this.lopHocNauAnId = lopHocNauAnId;
            this.soTienHoanLai = soTienHoanLai;
            this.trangThai = trangThai;
            this.lopHocChuyenSangId = lopHocChuyenSangId;
        }

        
        public HoanTienBaoLuu(DataRow row)
        {
            try
            {
                id = Convert.ToInt32(row["Id"]);
                hocVienId = Convert.ToInt32(row["HocVienId"]);
                lopHocNauAnId = Convert.ToInt32(row["LopHocNauAnId"]);
                soTienHoanLai = Convert.ToDecimal(row["SoTienHoanLai"]);
                trangThai = row["TrangThai"].ToString();
                lopHocChuyenSangId = row["LopHocChuyenSangId"] != DBNull.Value ? (int?)Convert.ToInt32(row["LopHocChuyenSangId"]) : null;
            }
            catch (Exception ex)
            {
              
                throw new DataException("Error parsing DataRow to HoanTienBaoLuu", ex);
            }
        }
    }
}
