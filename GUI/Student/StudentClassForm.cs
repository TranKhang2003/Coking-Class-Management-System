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

namespace GUI.Student
{
    public partial class StudentClassForm : Form
    {
        string connectionString = "Server=LEGION5\\SQLSERVER;Database=QLLHNA;Trusted_Connection=True;";
        private ImageList imageList = new ImageList();
        private Form activeForm = null;
        public StudentClassForm()
        {
            InitializeComponent();
            comboBox1.Items.Add("A-Z");
            comboBox1.Items.Add("Giá tiền");
            SetupListViewWithImages();
            LoadClassesToListView();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            listClass.ItemActivate += ListClass_ItemActivate;

        }
        private void SetupListViewWithImages()
        {
            imageList.ImageSize = new Size(150, 150);
            listClass.LargeImageList = imageList;
            listClass.View = View.Tile;
            listClass.TileSize = new Size(300, 200);

            listClass.Columns.Add("Tên Món", 150);
            listClass.Columns.Add("Giáo viên", 150);
            listClass.Columns.Add("Số lượng", 150);
            listClass.Columns.Add("Chi Phí", 150);
            listClass.Columns.Add("Địa Điểm", 150);
            listClass.Columns.Add("Ngày", 150);
            listClass.Columns.Add("Thời Gian", 150);
            //listClass.ForeColor = Color.FromArgb(214, 0, 21);

        }

        private void LoadClassesToListView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT L.MaLopHoc, L.MonAn,M.HinhAnhMon, G.HoTen, L.SoNguoiDangKy, L.SoNguoiDangKyToiDA, " +
                                   "LH.ChiPhi, L.DiaDiem, LH.Ngay, LH.ThoiGianBatDau, LH.ThoiGianKetThuc " +
                                   "FROM LopHocNauAn L " +
                                   "JOIN MonAn M ON L.MonAn = M.TenMon " +
                                   "JOIN GiaoVien G ON L.GiaoVienId = G.Id " +
                                   "JOIN LichHoc LH ON L.MaLopHoc = LH.MaLopHoc";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    listClass.Items.Clear();
                    imageList.Images.Clear();
                    int imageIndex = 0;


                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Không có lớp học nào trong cơ sở dữ liệu.");
                    }

                    while (reader.Read())
                    {
                        string maLopHoc = reader["MaLopHoc"].ToString();
                        string monAn = reader["MonAn"].ToString();
                        string tenGiaoVien = reader["HoTen"]?.ToString() ?? "Chưa có thông tin";
                        int soNguoiDangKy = reader["SoNguoiDangKy"] != DBNull.Value ? (int)reader["SoNguoiDangKy"] : 0;
                        int soNguoiDangKyToiDA = reader["SoNguoiDangKyToiDA"] != DBNull.Value ? (int)reader["SoNguoiDangKyToiDA"] : 0;
                        decimal chiPhi = reader["ChiPhi"] != DBNull.Value ? (decimal)reader["ChiPhi"] : 0;
                        string diaDiem = reader["DiaDiem"]?.ToString() ?? "Chưa có thông tin";
                        string ngay = reader["Ngay"]?.ToString() ?? "Chưa có thông tin";
                        string thoiGianBatDau = reader["ThoiGianBatDau"]?.ToString() ?? "Chưa có thông tin";
                        string thoiGianKetThuc = reader["ThoiGianKetThuc"]?.ToString() ?? "Chưa có thông tin";
                        byte[] imageBytes = reader["HinhAnhMon"] as byte[];

                        ListViewItem item = new ListViewItem($"{maLopHoc}: {monAn}");


                        item.SubItems.Add($"Giáo viên: {tenGiaoVien}");
                        item.SubItems.Add($"Tham gia: {soNguoiDangKy}/{soNguoiDangKyToiDA}");
                        item.SubItems.Add($"Chi phí: {chiPhi.ToString("C0", new System.Globalization.CultureInfo("vi-VN"))}");
                        item.SubItems.Add($"Địa điểm: {diaDiem}");
                        item.SubItems.Add($"Ngày: {ngay}");
                        item.SubItems.Add($"Thời gian: {thoiGianBatDau} - {thoiGianKetThuc}");

                        // Add the image if it exists
                        if (imageBytes != null)
                        {
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                Image image = Image.FromStream(ms);

                                imageList.Images.Add(image);
                                item.ImageIndex = imageIndex++;  // Set the image for the item
                            }
                        }

                        // Add the item to the ListView
                        listClass.Items.Add(item);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách lớp học: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = comboBox1.SelectedItem.ToString();

            if (selectedOption == "A-Z")
            {
                // Sắp xếp theo cột 0 (Tên món)
                listClass.ListViewItemSorter = new ListViewItemComparer(0, true);
                listClass.Sort();
            }
            else if (selectedOption == "Giá tiền")
            {
                // Sắp xếp theo cột 3 (Chi phí)
                listClass.ListViewItemSorter = new ListViewItemComparer(3, true);
                listClass.Sort();
            }
        }
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void ListClass_ItemActivate(object sender, EventArgs e)
        {
          
            if (listClass.SelectedItems.Count > 0)
            {
                string maLopHoc = listClass.SelectedItems[0].Text.Split(':')[0].Trim();
                openChildForm(new DetailsClassForm(maLopHoc));
            }
        }

       
    }
}
