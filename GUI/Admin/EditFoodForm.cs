using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace GUI.Admin
{
    public partial class EditFoodForm : Form
    {
        private MonAnForm monAnForm;
        private string foodName;
        private string selectedImagePath;
        string connectionString = "Server=LEGION5\\SQLSERVER;Database=QLLHNA;Trusted_Connection=True;";
        public EditFoodForm(string foodName)
        {
            InitializeComponent();
            this.foodName = foodName;
            foodNameTextBox.Text = foodName;
            foodNameTextBox.Enabled = false;
            LoadFoodImage(foodName);
        }
        private void LoadFoodImage(string tenMonAn)
        {
            string query = "SELECT HinhAnhMon, LoaiMon FROM MonAn WHERE TenMon = @TenMon";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenMon", tenMonAn);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Lấy dữ liệu hình ảnh từ cơ sở dữ liệu
                                byte[] imageBytes = reader["HinhAnhMon"] as byte[];

                                if (imageBytes != null && imageBytes.Length > 0)
                                {
                                    using (MemoryStream ms = new MemoryStream(imageBytes))
                                    {
                                        pictureBox1.Image = Image.FromStream(ms);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Hình ảnh không tồn tại trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                                // Lấy loại món
                                string loaiMon = reader["LoaiMon"].ToString();
                                textBox1.Text = loaiMon;
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editFood_Click(object sender, EventArgs e)
        {

            UpdateFoodImage(foodName, selectedImagePath, textBox1.Text);
            
        }

        private void UpdateFoodImage(string foodName, string newImagePath, string newFoodType)
        {
            string queryUpdateFood = "UPDATE MonAn SET HinhAnhMon = @HinhAnhMon, LoaiMon = @LoaiMon WHERE TenMon = @TenMon";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    
                    byte[] imageBytes = null;
                    if (!string.IsNullOrEmpty(newImagePath) && File.Exists(newImagePath))
                    {
                        imageBytes = File.ReadAllBytes(newImagePath);
                    }

                   
                    using (SqlCommand cmd = new SqlCommand(queryUpdateFood, conn))
                    {
                        cmd.Parameters.AddWithValue("@HinhAnhMon", imageBytes);
                        cmd.Parameters.AddWithValue("@LoaiMon", newFoodType);
                        cmd.Parameters.AddWithValue("@TenMon", foodName);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Cập nhật ảnh và loại món ăn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    monAnForm.LoadFoodImagesToListView();


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi cập nhật ảnh và loại món ăn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void Chosefile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Chọn hình ảnh mới";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                    pictureBox1.Image = ResizeImage(Image.FromFile(selectedImagePath), 350, 350);
                }
            }
        }

        private Image ResizeImage(Image img, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(img, 0, 0, width, height);
            }
            return resizedImage;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
