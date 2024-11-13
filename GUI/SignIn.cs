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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            Design.Design.RoundControl(textBoxUsername,10);
            Design.Design.RoundControl(textBoxPassword, 10);
            Design.Design.RoundControl(btnSignIn, 40);
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnPicture_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbSignIn_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
           
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void textBoxPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Clear();
            }
        }
        

        private void textBoxUsername_Click(object sender, EventArgs e)
        {
        if (textBoxUsername.Text == "Username")
        {
                textBoxUsername.Clear();
        }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp formSignUp = new SignUp();
            formSignUp.ShowDialog();
            this.Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string userName = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            UserDTO userDTO = new UserDTO(userName,password);
            if (userDTO.HoTen == null || userDTO.MatKhau == null)
            {
                MessageBox.Show("Vui Long Nhap Thong Tin Dang Nhap");
            }
            if(UserBLL.SiginBLL(userDTO) == true)
            {
                SignUp mainForm = new SignUp();
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai thong tin dang nhap");
            }
        }
    }
}
