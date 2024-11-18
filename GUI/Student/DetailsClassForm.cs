using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace GUI.Student
{
    public partial class DetailsClassForm : Form
    {
        string maLopHoc;
        string connectionString = "Server=LEGION5\\SQLSERVER;Database=QLLHNA;Trusted_Connection=True;";

        public DetailsClassForm(string maLopHoc)
        {
            InitializeComponent();
            this.maLopHoc = maLopHoc;
            SetupPage();
        }

       

        private void SetupPage()
        {
            string query = @"
                                SELECT 
                                    G.HoTen AS TenGiaoVien,
                                    M.HinhAnhMon AS HinhAnhMonAn,
                                    L.DiaDiem,
                                    L.MonAn,
                                    LH.ThoiGianBatDau,
                                    LH.ThoiGianKetThuc,
                                    LH.Ngay AS NgayHoc,
                                    LH.ChiPhi,
                                    L.ThongTin,
                                    L.GhiChu
                                FROM 
                                    LopHocNauAn L
                                JOIN 
                                    GiaoVien G ON L.GiaoVienId = G.id
                                JOIN 
                                    MonAn M ON L.MonAn = M.TenMon
                                JOIN 
                                    LichHoc LH ON L.MaLopHoc = LH.MaLopHoc
                                WHERE 
                                    L.MaLopHoc = @MaLopHoc;
                            ";

          
            string tenGiaoVien = "";
            byte[] hinhAnhMonAn = null;
            string diaDiem = "";
            string monAn = "";
            string thoiGianBatDau = "";
            string thoiGianKetThuc = "";
            string ngayHoc = "";
            string thongTin = "";
            string ghiChu = "";
            decimal chiPhi = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                    
                        cmd.Parameters.AddWithValue("@MaLopHoc", maLopHoc);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) 
                            {
                            
                                tenGiaoVien = reader["TenGiaoVien"].ToString();
                                hinhAnhMonAn = reader["HinhAnhMonAn"] as byte[];
                                diaDiem = reader["DiaDiem"].ToString();
                                monAn = reader["MonAn"].ToString();
                                thoiGianBatDau = reader["ThoiGianBatDau"].ToString();
                                thoiGianKetThuc = reader["ThoiGianKetThuc"].ToString();
                                ngayHoc = reader["NgayHoc"].ToString();
                                thongTin = reader["ThongTin"].ToString();
                                ghiChu = reader["GhiChu"].ToString();
                                chiPhi = reader["ChiPhi"] != DBNull.Value ? (decimal)reader["ChiPhi"] : 0;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

           
            chef.Text = "Đầu bếp: " + tenGiaoVien;

            
            if (hinhAnhMonAn != null)
            {
                using (MemoryStream ms = new MemoryStream(hinhAnhMonAn))
                {
                    imagefood.Image = Image.FromStream(ms);
                    imagefood.SizeMode = PictureBoxSizeMode.StretchImage;  
                }
            }

     
            location.Text = diaDiem;
            classtile.Text = monAn;
            string TimeInfor = "";

            DateTime classDate;


            string format = "dd/MM/yyyy"; 
            CultureInfo vietnameseCulture = new CultureInfo("vi-VN");

            if (DateTime.TryParseExact(ngayHoc, format, null, DateTimeStyles.None, out classDate))
            {
                // Lấy ngày trong tuần và tháng bằng tiếng Việt
                string formattedDate = $"{vietnameseCulture.DateTimeFormat.GetDayName(classDate.DayOfWeek)}, {classDate.ToString("MM")}/{classDate.Day}";
                TimeInfor += formattedDate;
            }

            DateTime startTime, endTime;
            if (DateTime.TryParse(thoiGianBatDau, out startTime) && DateTime.TryParse(thoiGianKetThuc, out endTime))
            {
                TimeSpan duration = endTime - startTime;
                string durationFormatted = $"{duration.Hours}h:{duration.Minutes}";

                TimeInfor += $" | Thời gian bắt đầu: {thoiGianBatDau}h";
                TimeInfor +=  $" | Thời lượng: {durationFormatted}";
            }

         
            day.Text = TimeInfor;
            decribe.Text = thongTin;
            note.Text = ghiChu;
            thamgia.Text = $"Tham gia ngay chỉ với {chiPhi.ToString("C0", new System.Globalization.CultureInfo("vi-VN"))}";

        }
    }
}
