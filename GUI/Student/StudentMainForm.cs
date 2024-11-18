using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Student
{
    public partial class StudentMainForm : Form
    {
        string connectionString = "Server=LEGION5\\SQLSERVER;Database=QLLHNA;Trusted_Connection=True;";
        private ImageList imageList = new ImageList();
        private Form activeForm = null;
        public StudentMainForm()
        {
            InitializeComponent(); 
          
        }
        
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new StudentCalendarForm());
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            openChildForm(new StudentClassForm());
        }
    }
    public class ListViewItemComparer : IComparer
    {
        private int col; // Cột để sắp xếp
        private bool ascending; // Thứ tự tăng dần hoặc giảm dần

        public ListViewItemComparer(int column, bool ascendingOrder = true)
        {
            col = column;
            ascending = ascendingOrder;
        }

        public int Compare(object x, object y)
        {
            ListViewItem itemX = x as ListViewItem;
            ListViewItem itemY = y as ListViewItem;

            // Lấy giá trị của cột đang sắp xếp
            string valueX = itemX.SubItems[col].Text.Replace("VND", "").Trim();
            string valueY = itemY.SubItems[col].Text.Replace("VND", "").Trim();

            // Xử lý sắp xếp cột giá tiền (kiểu số)
            if (col == 3) // Cột "Chi phí"
            {
                if (decimal.TryParse(valueX, out decimal numX) && decimal.TryParse(valueY, out decimal numY))
                {
                    return ascending ? numX.CompareTo(numY) : numY.CompareTo(numX);
                }
            }

            // Xử lý mặc định: kiểu chuỗi
            return ascending ? string.Compare(valueX, valueY) : string.Compare(valueY, valueX);
        }
    }

}



