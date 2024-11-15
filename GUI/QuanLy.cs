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
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            Trangchu trangchu = new Trangchu();
            trangchu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lophoc lophoc = new Lophoc();
            lophoc.Show();
            this.Hide();
        }
    }
}
