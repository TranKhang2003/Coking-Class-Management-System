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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            Design.Design.RoundControl(txtUsername,10);
            Design.Design.RoundControl(txtEmail, 10);
            Design.Design.RoundControl(txtRePassword, 10);
            Design.Design.RoundControl(txtPassword, 10);
            Design.Design.RoundControl(btnSignUp, 40);
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
          
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Clear();
            }
           
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
           
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
            }
            txtRePassword.UseSystemPasswordChar = true;
        }

        private void txtRePassword_MouseClick(object sender, MouseEventArgs e)
        {
          
            if (txtRePassword.Text == "Confirm Password")
            {
                txtRePassword.Clear();
            }
            txtRePassword.UseSystemPasswordChar = true;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string rePassword = txtRePassword.Text;
            UserDTO userDTO = new UserDTO(username,password,email);
            switch (UserBLL.SignupBLL(userDTO, rePassword)) {
                case 0:
                    MessageBox.Show("Xác nhận mật khẩu không trùng khớp");
                    break;
                case 1:
                    MessageBox.Show("Vui lòng nhập họ tên");
                    break;
                case 2:
                    MessageBox.Show("Vui lòng nhập mật khẩu");
                    break;
                case 3:
                    MessageBox.Show("Vui lòng nhập email đúng định dạng");
                    break;
                case 4:
                    MessageBox.Show("Tên người dùng đã tồn tại");
                    break;
                case 5:
                    MessageBox.Show("Email đã tồn tại");
                    break;
                case 6:
                    MessageBox.Show("Tạo tài khoản thành công");
                    break;
                case 7:
                    MessageBox.Show("Lỗi hệ thống, vui lòng thử lại sau");
                    break;
            }
        }

        private void llbSignin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn formSignIn = new SignIn();
            formSignIn.ShowDialog();
            this.Close();
        }

        private void pnMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
