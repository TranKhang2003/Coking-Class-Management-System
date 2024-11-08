using CookingClassManagementSystem.DAO;
using CookingClassManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookingClassManagementSystem
{
    public partial class AddClassForm : Form
    {
        public AddClassForm()
        {
            InitializeComponent();
            loadAddClassForm();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void loadAddClassForm()
        {
            Design.Design.RoundControl(panelCookingClass, 100);
            Design.Design.RoundControl(panelInfor1, 100);
     
            Design.Design.RoundControl(panelImageFood, 100);
            Design.Design.RoundControl(pictureFood, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenMon = textBoxTenMon.Text;
            string tenGiaoVien = textBoxTenGiaoVien.Text;
            decimal hocPhi = decimal.Parse(textBoxHocPhi.Text);
            decimal phiNguyenLieu = decimal.Parse(textBoxPhiNguyenLieu.Text);
            string diaDiem = textBoxDiaDiem.Text;
            decimal phiDiaDiem = decimal.Parse(textBoxPhiDiaDiem.Text);
            int soNguoiDangKi = int.Parse(textBoxSoNguoiThamGia.Text);
            string thongTin = textBoxThongTin.Text;
            string ghiChu = textBoxNote.Text;
            string taiTro = textBoxNhanHangTaiTro.Text;
            DateTime ngay = DateTime.Parse(textBoxNgayDienRa.Text);
            TimeSpan thoiGianBatDau = TimeSpan.Parse(textBoxThoiGian.Text);
            TimeSpan thoiGianKetThuc = thoiGianBatDau.Add(TimeSpan.FromHours(1));
            DataTable dt = GiaoVienDAO.Instance.getGiaoVienId(tenGiaoVien);
            int giaoVienId = 0; // Giá trị mặc định nếu không tìm thấy giáo viên
            if (dt.Rows.Count > 0)
            {
                giaoVienId = Convert.ToInt32(dt.Rows[0]["id"]); // Lấy giá trị của cột "id" từ hàng đầu tiên
            }
            else
            {
                MessageBox.Show("There is no teacher with the above name.");
                return;
            }
            LopHoc lopHoc = new LopHoc(0,tenMon, giaoVienId, diaDiem,0,soNguoiDangKi,thongTin,ghiChu);
            int lopHocId = LopHocDAO.Instance.AddClassReturnId(lopHoc);
            if (lopHocId != 0)
            {
              
                ChiTietLopHoc chiTietLopHoc = new ChiTietLopHoc(0, lopHocId, phiDiaDiem, hocPhi * soNguoiDangKi, 0, 0, phiNguyenLieu, 0, 0, "Chua dien ra");
                LichHoc lichHoc = new LichHoc(0, lopHocId, ngay, hocPhi, thoiGianBatDau, thoiGianKetThuc);
                if (taiTro.Equals(""))
                {
                    LopHocCoPhi lopHocCoPhi = new LopHocCoPhi(0, lopHocId);
                    LopHocCoPhiDAO.Instance.AddLopHocCoPhi(lopHocCoPhi);
                }
                else
                {
                    LopHocMienPhi lopHocMienPhi = new LopHocMienPhi(0, taiTro, lopHocId);
                    LopHocMienPhiDAO.Instance.AddLopHocMienPhi(lopHocMienPhi);
                }
                if (((ChiTietLopHocDAO.Instance.AddChiTietLopHocDAO(chiTietLopHoc) ) && (LichHocDAO.Instance.AddLichHoc(lichHoc))))
                {
                    MessageBox.Show("Add Succesfully");
                }
              
            }
            else
            {
                MessageBox.Show("Add Faildly");
            }
        }
        private void saveData(
             string tenMon,
             string tenGiaoVien,
             decimal hocPhi,
             decimal phiNguyenLieu,
             string diaDiem,
             decimal phiDiaDiem,
             int soNguoiDangKi,
             string thongTin,
             string ghiChu,
             string taiTro,
             DateTime ngay,
             TimeSpan thoiGianBatDau,
             TimeSpan thoiGianKetThuc)
        {
            
        }
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
