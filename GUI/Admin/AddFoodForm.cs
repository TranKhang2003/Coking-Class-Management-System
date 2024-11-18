using BLL.BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class AddFoodForm : Form
    {
      
        private string selectedImagePath;
        public AddFoodForm()
        {
            
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Chosefile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
        
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

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

        private void addFood_Click(object sender, EventArgs e)
        {
            string foodName = foodNameTextBox.Text.Trim();
            string foodType = textBox1.Text.Trim();

            // Validate input fields
            if (string.IsNullOrWhiteSpace(foodName) || string.IsNullOrWhiteSpace(foodType) || string.IsNullOrWhiteSpace(selectedImagePath))
            {
                MessageBox.Show("Please fill in all fields and select an image.");
                return;
            }

            try
            {
              
                byte[] imageBytes = File.ReadAllBytes(selectedImagePath);
                using (SqlConnection conn = new SqlConnection("Server=LEGION5\\SQLSERVER;Database=QLLHNA;Trusted_Connection=True;"))
                {
                    string query = "INSERT INTO MonAn (TenMon, HinhAnhMon, LoaiMon) VALUES (@TenMon, @HinhAnhMon, @LoaiMon)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TenMon", foodName);
                
                    cmd.Parameters.AddWithValue("@HinhAnhMon", imageBytes);
                    cmd.Parameters.AddWithValue("@LoaiMon", foodType);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Food added successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add food.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            //MonAnDTO newFood = new MonAnDTO(foodName, selectedImagePath, foodType);


            //bool success = LopHocBLL.ThemMonAn(newFood);

            //if (success)
            //{
            //    MessageBox.Show("Food added successfully!");
            //}
            //else
            //{

            //    MessageBox.Show("Error deleting image: ");
            //}

        }
            

        


    }
}
