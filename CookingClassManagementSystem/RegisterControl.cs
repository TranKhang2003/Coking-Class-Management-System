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
    public partial class RegisterControl : UserControl
    {
        public RegisterControl()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterUserForm registerUserForm = new RegisterUserForm();
            registerUserForm.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegisterTeacherForm registerTeacherForm = new RegisterTeacherForm();
            registerTeacherForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
