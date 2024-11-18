using BLL.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class AddClassForm : Form
    {
        
        private Boolean fee = true;
        string connectionStr = "Server=LEGION5\\SQLSERVER;Database=QLLHNA;Trusted_Connection=True;";

        public AddClassForm()
        {
         
            InitializeComponent();
            List<string> loaiLopHoc = new List<string> { "Có phí", "Miễn phí" };
            LoadMonAnIntoComboBox();
            LoadTeachersIntoComboBox();
            sponsor.Visible = false;
            sponsors.Visible = false;
            comboBox2.DataSource = loaiLopHoc;
            comboBox2.SelectedIndexChanged += new EventHandler(comboBox2_SelectedIndexChanged);
        }
        private void LoadTeachersIntoComboBox()
        {
            try
            {
                List<string> teacherList = LopHocBLL.LayDanhSachGiaoVien(); 
                comboBoxTeacher.Items.Clear();

                foreach (string teacherInfo in teacherList)
                {
                    comboBoxTeacher.Items.Add(teacherInfo); 
                }

                if (comboBoxTeacher.Items.Count > 0)
                {
                    comboBoxTeacher.SelectedIndex = 0; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách giáo viên: " + ex.Message);
            }
        }
        private void LoadMonAnIntoComboBox()
        {
            try
            {
                List<string> monAnList = LopHocBLL.LayMonAn();
                comboBoxMonAn.Items.Clear();

                foreach (string tenMon in monAnList)
                {
                    comboBoxMonAn.Items.Add(tenMon); 
                }

                if (comboBoxMonAn.Items.Count > 0)
                {
                    comboBoxMonAn.SelectedIndex = 0; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu món ăn: " + ex.Message);
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "Miễn phí")
            {
                fee = false;
                tuition.Visible = false;
                label14.Visible = false;
                sponsor.Visible = true;
                sponsors.Visible = true;

            }
            else
            {
                fee = true;
                tuition.Visible = true;
                label14.Visible = true;
                sponsor.Visible = false;
                sponsors.Visible = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string locations = location.Text.Trim();
            int studentmax = int.Parse(students.Text.Trim());
            string food = comboBoxMonAn.Text.Trim();
      
            string gioBatDau = startTime.Value.ToString("HH:mm");
            string gioKetThuc = endTime.Value.ToString("HH:mm");
            string ngayBatDau = dateTimePicker3.Value.ToString("dd/MM/yyyy");
            string selectedTeacherInfo = comboBoxTeacher.SelectedItem.ToString();
            int teacherId = int.Parse(selectedTeacherInfo.Split(' ')[0]);
            string information = richTextBox2.Text.Trim();
            string decription = richTextBox1.Text.Trim();
            decimal tuitions = 0;
            string sponsor = sponsors.Text.Trim();

            int classId = 0;
            if (fee)
            {
                tuitions = decimal.Parse(tuition.Text.Trim());
                try
                {
                 
                    using (SqlConnection connection = new SqlConnection(connectionStr))
                    {
                        connection.Open();
                        // Insert vào bảng LopHocNauAn
                        string queryInsertClass = "INSERT INTO LopHocNauAn (MonAn, GiaoVienId, DiaDiem, SoNguoiDangKy, SoNguoiDangKyToiDA, ThongTin, GhiChu) " +
                                                  "VALUES (@MonAn, @teacherId, @locations, @SoNguoiDangKy, @studentmax, @information, @decription)";
                        using (SqlCommand cmdClass = new SqlCommand(queryInsertClass, connection))
                        {
                            cmdClass.Parameters.AddWithValue("@MonAn", food);
                            cmdClass.Parameters.AddWithValue("@teacherId", teacherId);
                            cmdClass.Parameters.AddWithValue("@locations", locations);
                            cmdClass.Parameters.AddWithValue("@SoNguoiDangKy", 0);
                            cmdClass.Parameters.AddWithValue("@studentmax", studentmax);
                            cmdClass.Parameters.AddWithValue("@information", information);
                            cmdClass.Parameters.AddWithValue("@decription", decription);
                            cmdClass.ExecuteNonQuery();
                        }

                        // Get the ClassId that was just inserted
                        string queryGetClassId = "SELECT TOP 1 MaLopHoc FROM LopHocNauAn WHERE MonAn = @food AND GiaoVienId = @teacherId ORDER BY MaLopHoc DESC";
                        
                        using (SqlCommand cmdClassId = new SqlCommand(queryGetClassId, connection))
                        {
                            cmdClassId.Parameters.AddWithValue("@food", food);
                            cmdClassId.Parameters.AddWithValue("@teacherId", teacherId);
                            SqlDataReader reader = cmdClassId.ExecuteReader();
                            if (reader.Read())
                            {
                                classId = reader.GetInt32(0);
                            }
                            reader.Close();
                        }

                        // Insert vào bảng LichHoc
                        string queryInsertSchedule = "INSERT INTO LichHoc (MaLopHoc, Ngay, ChiPhi, ThoiGianBatDau, ThoiGianKetThuc) " +
                                                     "VALUES (@classId, @ngayBatDau, @tuitions, @gioBatDau, @gioKetThuc)";
                        using (SqlCommand cmdSchedule = new SqlCommand(queryInsertSchedule, connection))
                        {
                            cmdSchedule.Parameters.AddWithValue("@classId", classId);
                            cmdSchedule.Parameters.AddWithValue("@ngayBatDau", ngayBatDau);
                            cmdSchedule.Parameters.AddWithValue("@tuitions", tuitions);
                            cmdSchedule.Parameters.AddWithValue("@gioBatDau", gioBatDau);
                            cmdSchedule.Parameters.AddWithValue("@gioKetThuc", gioKetThuc);
                            cmdSchedule.ExecuteNonQuery();
                        }

                        // Insert vào bảng LopHocCoPhi 
                        string queryInsertClassFee = "INSERT INTO LopHocCoPhi (LopHocNauAnId) " +
                                                      "VALUES (@classId)";
                        using (SqlCommand cmdClassFee = new SqlCommand(queryInsertClassFee, connection))
                        {
                            cmdClassFee.Parameters.AddWithValue("@classId", classId);
                            cmdClassFee.ExecuteNonQuery();
                        }

                 
                        MessageBox.Show("Lớp học đã được tạo thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi lưu dữ liệu: " + ex.Message);
                }

            }
            else
            {
               
                try
                {

                    using (SqlConnection connection = new SqlConnection(connectionStr))
                    {
                        connection.Open();
                        // Insert vào bảng LopHocNauAn
                        string queryInsertClass = "INSERT INTO LopHocNauAn (MonAn, GiaoVienId, DiaDiem, SoNguoiDangKy, SoNguoiDangKyToiDA, ThongTin, GhiChu) " +
                                                  "VALUES (@MonAn, @teacherId, @locations, @SoNguoiDangKy, @studentmax, @information, @decription)";
                        using (SqlCommand cmdClass = new SqlCommand(queryInsertClass, connection))
                        {
                            cmdClass.Parameters.AddWithValue("@MonAn", food);
                            cmdClass.Parameters.AddWithValue("@teacherId", teacherId);
                            cmdClass.Parameters.AddWithValue("@locations", locations);
                            cmdClass.Parameters.AddWithValue("@SoNguoiDangKy", 0);
                            cmdClass.Parameters.AddWithValue("@studentmax", studentmax);
                            cmdClass.Parameters.AddWithValue("@information", information);
                            cmdClass.Parameters.AddWithValue("@decription", decription);
                            cmdClass.ExecuteNonQuery();
                        }

                        
                        string queryGetClassId = "SELECT TOP 1 MaLopHoc FROM LopHocNauAn WHERE MonAn = @food AND GiaoVienId = @teacherId ORDER BY MaLopHoc DESC";
                        
                        using (SqlCommand cmdClassId = new SqlCommand(queryGetClassId, connection))
                        {
                            cmdClassId.Parameters.AddWithValue("@food", food);
                            cmdClassId.Parameters.AddWithValue("@teacherId", teacherId);
                            SqlDataReader reader = cmdClassId.ExecuteReader();
                            if (reader.Read())
                            {
                                classId = reader.GetInt32(0);
                            }
                            reader.Close();
                        }

                        // Insert vào bảng LichHoc
                        string queryInsertSchedule = "INSERT INTO LichHoc (MaLopHoc, Ngay, ChiPhi, ThoiGianBatDau, ThoiGianKetThuc) " +
                                                     "VALUES (@classId, @ngayBatDau, @tuitions, @gioBatDau, @gioKetThuc)";
                        using (SqlCommand cmdSchedule = new SqlCommand(queryInsertSchedule, connection))
                        {
                            cmdSchedule.Parameters.AddWithValue("@classId", classId);
                            cmdSchedule.Parameters.AddWithValue("@ngayBatDau", ngayBatDau);
                            cmdSchedule.Parameters.AddWithValue("@tuitions", tuitions);
                            cmdSchedule.Parameters.AddWithValue("@gioBatDau", gioBatDau);
                            cmdSchedule.Parameters.AddWithValue("@gioKetThuc", gioKetThuc);
                            cmdSchedule.ExecuteNonQuery();
                        }

                        // Insert vào bảng LopHocMienPhi nếu không có phí
                        string queryInsertClassFree = "INSERT INTO LopHocMienPhi (NhanHangHocTac, LopHocNauAnId) " +
                                                      "VALUES (@NhanHangHocTac, @classId)";
                        using (SqlCommand cmdClassFree = new SqlCommand(queryInsertClassFree, connection))
                        {
                            cmdClassFree.Parameters.AddWithValue("@NhanHangHocTac", sponsor);
                            cmdClassFree.Parameters.AddWithValue("@classId", classId);
                            cmdClassFree.ExecuteNonQuery();
                        }


                        MessageBox.Show("Lớp học đã được tạo thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi lưu dữ liệu: " + ex.Message);
                }

            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

    

     

     
    }
}
