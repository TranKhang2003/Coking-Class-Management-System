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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CookingClassManagementSystem
{
    public partial class LoginForm : Form
    {
        private string connectionString = "Server=LEGION5\\SQLSERVER;Database=QLLHNA;Trusted_Connection=True;";
        public LoginForm()
        {
            InitializeComponent();
        }


        private void clsbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            RegisterControl homeControl = new RegisterControl();
          

            homeControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(homeControl);
            homeControl.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Mã hóa mật khẩu người dùng nhập
                string hashedPassword = HashPassword(textBox2.Text);

                // Kiểm tra người dùng trong bảng Users
                string query = "SELECT U.id, U.HoTen, R.RoleName " +
                               "FROM Users U " +
                               "JOIN User_Role UR ON U.id = UR.UserId " +
                               "JOIN Roles R ON UR.RoleId = R.id " +
                               "WHERE U.HoTen = @HoTen AND U.MatKhau = @MatKhau";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@HoTen", textBox1.Text);
                cmd.Parameters.AddWithValue("@MatKhau", hashedPassword);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string roleName = reader["RoleName"].ToString();

                    if (roleName == "admin")
                    {
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                        this.Hide();
                    }
                    else if (roleName == "teacher")
                    {
                        TeacherMainForm teacherForm = new TeacherMainForm();
                        teacherForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
