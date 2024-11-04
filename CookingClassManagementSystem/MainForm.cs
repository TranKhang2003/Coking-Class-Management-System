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
    public partial class MainForm : Form
    {
        private bool isMaximized = false;
        HomeControl homeControl = new HomeControl();
        public MainForm()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;

            homeControl.Dock = DockStyle.Fill;
            panel3.Controls.Add(homeControl);
            homeControl.BringToFront();

            // Đăng ký sự kiện để nhận thông báo khi cần hiển thị DetailsClassControl
            homeControl.ShowDetailsRequested += HomeControl_ShowDetailsRequested;
        }

        private void label3_Click(object sender, EventArgs e) { }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (isMaximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

            isMaximized = !isMaximized;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            homeControl.BringToFront();
        }

        private void HomeControl_ShowDetailsRequested(object sender, EventArgs e)
        {

            DetailsClassControl detailsClassControl = new DetailsClassControl
            {
                Dock = DockStyle.Fill
            };

            panel3.Controls.Clear(); // Xóa các control hiện tại trong panel3
            panel3.Controls.Add(detailsClassControl); // Thêm DetailsClassControl vào panel3
            detailsClassControl.BringToFront();




        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
