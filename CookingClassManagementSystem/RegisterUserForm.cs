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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace CookingClassManagementSystem
{
    public partial class RegisterUserForm : Form
    {
        private string connectionString = "Data Source=LOCALHOST\\SQLEXPRESS01;Initial Catalog=QLLHNA;Integrated Security=True";
        public RegisterUserForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hoTen = textBox4.Text.Trim();
            string matKhau = textBox2.Text.Trim();
            string rematKhau = textBox3.Text.Trim();
            string email = textBox1.Text.Trim();

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(rematKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Password và Re-password không trùng khớp. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Kiểm tra xem email đã tồn tại chưa
                    string queryCheck = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
                    using (SqlCommand cmdCheck = new SqlCommand(queryCheck, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@Email", email);
                        int count = (int)cmdCheck.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Email này đã được sử dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Chèn dữ liệu vào bảng Users
                    string queryInsert = "INSERT INTO Users (HoTen, MatKhau, Email) VALUES (@HoTen, @MatKhau, @Email)";
                    int newUserId;
                    using (SqlCommand cmdInsert = new SqlCommand(queryInsert, conn))
                    {
                        cmdInsert.Parameters.AddWithValue("@HoTen", hoTen);
                        cmdInsert.Parameters.AddWithValue("@MatKhau", HashPassword(matKhau));
                        cmdInsert.Parameters.AddWithValue("@Email", email);

                        cmdInsert.ExecuteNonQuery();
                    }

                    // Lấy ID của người dùng dựa trên email vừa chèn
         
                    string queryGetId = "SELECT id FROM Users WHERE Email = @Email";
                    using (SqlCommand cmdGetId = new SqlCommand(queryGetId, conn))
                    {
                        cmdGetId.Parameters.AddWithValue("@Email", email);
                        newUserId = (int)cmdGetId.ExecuteScalar();
                    }

                    // Gán vai trò "user" cho người dùng mới
                    string queryAssignRole = "INSERT INTO User_Role (UserId, RoleId) VALUES (@UserId, @RoleId)";
                    using (SqlCommand cmdAssignRole = new SqlCommand(queryAssignRole, conn))
                    {
                
                        cmdAssignRole.Parameters.AddWithValue("@UserId", newUserId);
                        cmdAssignRole.Parameters.AddWithValue("@RoleId", 3);
                        cmdAssignRole.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void clsbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
