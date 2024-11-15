using BLL.BLL;
using DTO;
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
    public partial class LopHocChiTiet : Form
    {
        public LopHocChiTiet(int idLopHoc, int idLichHoc)
        {
            InitializeComponent();
            LopHocChiTiet_Load1(idLopHoc, idLichHoc);
        }


        private void flpLopHoc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {

        }
        private void LopHocChiTiet_Load1(int idLopHoc, int idLichHoc)
        {
            LichHocDTO lichHocDTO = new LichHocDTO(idLopHoc, idLichHoc);
            DataTable data = LopHocBLL.LayThongTinLopHocChon(lichHocDTO);

            if (data.Rows.Count > 0) // Kiểm tra nếu có dữ liệu trả về
            {
                DataRow row = data.Rows[0]; // Lấy hàng đầu tiên từ kết quả
                label4.Text = "Lớp học dạy nấu món " + row["MonAn"].ToString();
                label1.Text = row["HoTen"].ToString();
                label2.Text = row["DiaDiem"].ToString();
                label3.Text = row["SoNguoiDangKy"].ToString() + "/" + row["SoNguoiDangKyToiDA"].ToString();
            }
            else
            {
                // Xử lý khi không có dữ liệu trả về
                MessageBox.Show("Không tìm thấy thông tin lớp học");
            }
        }

        private void LopHocChiTiet_Load(object sender, EventArgs e)
        {

        }
    }
}
