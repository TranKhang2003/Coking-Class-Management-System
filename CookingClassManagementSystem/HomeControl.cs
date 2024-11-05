using System;
using System.Windows.Forms;

namespace CookingClassManagementSystem
{
    public partial class HomeControl : UserControl
    {
        public event EventHandler ShowDetailsRequested; // Sự kiện để yêu cầu hiển thị DetailsClassControl

        public HomeControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Xử lý click của button 1 (nếu cần)
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Gọi sự kiện khi nhấn button 1 trong HomeControl
            ShowDetailsRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
