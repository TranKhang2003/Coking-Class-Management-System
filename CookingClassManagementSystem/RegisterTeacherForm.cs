using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookingClassManagementSystem
{
    public partial class RegisterTeacherForm : Form
    {
        private string connectionString = "Data Source=LOCALHOST\\SQLEXPRESS01;Initial Catalog=QLLHNA;Integrated Security=True";
        public RegisterTeacherForm()
        {
            InitializeComponent();
            gender.Items.Add("Male");
            gender.Items.Add("Female");
           

            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");
            comboBox1.Items.Add("5");

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != textBox6.Text) 
            {
                MessageBox.Show("Password và Re-password không trùng khớp. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            int gioiTinhValue;
            if (gender.SelectedItem.ToString() == "Male")
            {
                gioiTinhValue = 1; 
            }
            else
            {
                gioiTinhValue = 0; 
            }
            


            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Thêm người dùng vào bảng Users
                    string insertUserQuery = "INSERT INTO Users (HoTen, MatKhau, Email) VALUES (@HoTen, @MatKhau, @Email)";
                    SqlCommand cmd = new SqlCommand(insertUserQuery, conn);
                    cmd.Parameters.AddWithValue("@HoTen", name.Text);
                    cmd.Parameters.AddWithValue("@MatKhau", HashPassword(textBox5.Text)); 
                    cmd.Parameters.AddWithValue("@Email", email.Text);

                    cmd.ExecuteNonQuery();
                    string queryGetId = "SELECT id FROM Users WHERE Email = @Email";
                    int newUserId;
                    using (SqlCommand cmdGetId = new SqlCommand(queryGetId, conn))
                    {
                        cmdGetId.Parameters.AddWithValue("@Email", email.Text);
                        newUserId = (int)cmdGetId.ExecuteScalar();
                    }

             

                    // Gán vai trò giáo viên cho người dùng
                    string insertUserRoleQuery = "INSERT INTO User_Role (UserId, RoleId) VALUES (@UserId, (SELECT id FROM Roles WHERE RoleName = 'teacher'))";
                    SqlCommand roleCmd = new SqlCommand(insertUserRoleQuery, conn);
                    roleCmd.Parameters.AddWithValue("@UserId", newUserId);
                    roleCmd.ExecuteNonQuery();

                    // Thêm thông tin chi tiết vào bảng GiaoVien
                    string insertTeacherQuery = @"
                        INSERT INTO GiaoVien (user_id, HoTen, NgaySinh, GioiTinh, ChuyenMon, SoNamKinhNghiem, Sdt, Luong) 
                        VALUES (@UserId, @HoTen, @NgaySinh, @GioiTinh, @ChuyenMon, @SoNamKinhNghiem, @Sdt, @Luong)";
                    SqlCommand teacherCmd = new SqlCommand(insertTeacherQuery, conn);
                    teacherCmd.Parameters.AddWithValue("@UserId", newUserId);
                    teacherCmd.Parameters.AddWithValue("@HoTen", name.Text);
                    teacherCmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker1.Value.ToString("MMM d yyyy"));
                    teacherCmd.Parameters.AddWithValue("@GioiTinh", gioiTinhValue);
                    teacherCmd.Parameters.AddWithValue("@ChuyenMon", textBox2.Text);
                    teacherCmd.Parameters.AddWithValue("@SoNamKinhNghiem", int.Parse(comboBox1.SelectedItem.ToString()));
                    teacherCmd.Parameters.AddWithValue("@Sdt", phoneNumber.Text);
                    decimal luong = TinhLuongTheoSoNamKinhNghiem(int.Parse(comboBox1.SelectedItem.ToString()));
                    teacherCmd.Parameters.AddWithValue("@Luong", luong);

                    teacherCmd.ExecuteNonQuery();

                    MessageBox.Show("Đăng ký giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng ký giáo viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegisterControl registerControl = new RegisterControl();
            registerControl.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private decimal TinhLuongTheoSoNamKinhNghiem(int soNamKinhNghiem)
        {

            if (soNamKinhNghiem == 1)
            {
                return 7000000; 
            }
            else if (soNamKinhNghiem == 2)
            {
                return 10000000; 
            }
            else if (soNamKinhNghiem == 3)
            {
                return 15000000;
            }
            else if (soNamKinhNghiem == 4) 
            {
                return 20000000; 
            }
            else 
            {
                return 25000000;
            }
        }
        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Chuyển đổi mật khẩu thành mảng byte
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Chuyển đổi mảng byte thành chuỗi hex
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }






    }
}
