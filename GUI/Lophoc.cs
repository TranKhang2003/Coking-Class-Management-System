using BLL.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Lophoc : Form
    {
        public Lophoc()
        {
            InitializeComponent();
            Lophoc_Load();
        }

        private void Lophoc_Load()
        {
            DataTable classesTable = LopHocBLL.LayLopHoc();
            foreach (DataRow row in classesTable.Rows)
            {
                // Lấy dữ liệu từ mỗi hàng
                string tenLop = "Lớp học nấu " + row["TenMon"].ToString();
                string ngayBatDau = row["ThoiGianBatDau"].ToString();
                string trangThai = row["TrangThai"].ToString();

                // Tạo một panel cho mỗi lớp học
                Panel classPanel = new Panel
                {
                    Width = 200,
                    Height = 120,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5)
                };

                // Thêm label cho tên lớp
                Label lblTenLop = new Label
                {
                    Text = tenLop,
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Location = new Point(10, 10)
                };
                classPanel.Controls.Add(lblTenLop);

                // Thêm label cho ngày bắt đầu
                Label lblNgayBatDau = new Label
                {
                    Text = ngayBatDau,
                    AutoSize = true,
                    Location = new Point(10, 30)
                };
                classPanel.Controls.Add(lblNgayBatDau);

                // Thêm label cho trạng thái
                Label lblTrangThai = new Label
                {
                    Text = "Status: " + trangThai,
                    AutoSize = true,
                    Location = new Point(10, 50),

                    ForeColor = Color.Green
                };
                classPanel.Controls.Add(lblTrangThai);

                // Thêm button cho nút "Join Now"
                Button btnJoin = new Button
                {
                    Text = "Join Now",
                    Width = 100,
                    Location = new Point(10, 80),
                    
                };
                classPanel.Controls.Add(btnJoin);
                btnJoin.Click += (sender, e) => HienThiThongTinLopHoc((int)row["MaLopHoc"], (int)row["MaLopHoc"]);

                // Thêm panel vào FlowLayoutPanel
                flpLopHoc.Controls.Add(classPanel);
            }
        }
        private void HienThiThongTinLopHoc(int maLopHoc,int maLichHoc)
        {
            // Khởi tạo form chi tiết lớp học
            LopHocChiTiet lopHocChiTietForm = new LopHocChiTiet(maLopHoc, maLichHoc);
            lopHocChiTietForm.ShowDialog(); // Hiển thị form chi tiết lớp học dưới dạng dialog
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            Trangchu trangchu = new Trangchu();
            trangchu.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuanLy quanLy = new QuanLy();
               quanLy.Show();
            this.Hide();
        }
    }
}
