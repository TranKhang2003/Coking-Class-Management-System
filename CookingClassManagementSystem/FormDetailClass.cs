using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookingClassManagementSystem.DAO;
using CookingClassManagementSystem.Design;

namespace CookingClassManagementSystem
{
    public partial class FormDetailClass : Form
    {
        public FormDetailClass(string tenmon)
        {
            InitializeComponent();
            Form1_Load(tenmon);
        }
      
   
        private void Form1_Load(string tenmon)
        {
            Design.Design.RoundControl(buttonJoin, 30);
            Design.Design.RoundControl(panelInfor, 100);
            Design.Design.RoundControl(panelImage, 100);
            Design.Design.RoundControlA(textBoxGhiChu, 30);
            Design.Design.RoundControlA(textBoxThongTin, 30);
            Design.Design.RoundPictureBox(pictureBoximageMonAn, 30);

            DataTable dt = LopHocDAO.Instance.GetClassDetail(tenmon);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0]; // Lấy dòng đầu tiên (có thể có nhiều dòng)

                // Giả sử bạn có các TextBox hoặc Label để hiển thị dữ liệu
                labelTenMon.Text = "Lớp Học Dạy Nấu "  + row["TenMon"].ToString();
                textBoxThongTin.Text = row["ThongTin"].ToString();
                textBoxGhiChu.Text = row["GhiChu"].ToString();
                labelTenGiaoVien.Text = row["HoTen"].ToString();
                labelThoiGian.Text = Convert.ToDateTime(row["Ngay"]).ToString("dd/MM/yyyy");
                labelDiaDiem.Text = row["DiaDiem"].ToString();
                labelChiPhi.Text = row["ChiPhi"].ToString();
                labelTrangThai.Text = row["TrangThai"].ToString();
                labelSoHocVien.Text = row["SoNguoiDangKy"].ToString() + "/" + row["SoNguoiDangKyToiDA"].ToString();
            }
            else
            {
                // Xử lý trường hợp không có dữ liệu
                MessageBox.Show("Không có dữ liệu chi tiết cho lớp học này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
