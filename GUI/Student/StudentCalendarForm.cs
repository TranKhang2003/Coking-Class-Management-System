using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Student
{
    public partial class StudentCalendarForm : Form
    {
        private int currentMonth;
        private int currentYear;
        public StudentCalendarForm()
        {
            InitializeComponent();
            DateTime today = DateTime.Now;
            currentMonth = today.Month;
            currentYear = today.Year;
            SetupCalendar();
        }

        private void SetupCalendar()
        {
            // Xóa các control cũ nếu có
            tableLayoutPanel1.Controls.Clear();

            // Lấy số ngày trong tháng hiện tại
            int daysInMonth = DateTime.DaysInMonth(currentYear, currentMonth);
            DateTime firstDayOfMonth = new DateTime(currentYear, currentMonth, 1);
            int startDayOfWeek = (int)firstDayOfMonth.DayOfWeek;

            // Thêm các tiêu đề ngày
            string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            for (int i = 0; i < 7; i++)
            {
                Label lblDay = new Label();
                lblDay.Text = daysOfWeek[i];
                lblDay.TextAlign = ContentAlignment.MiddleCenter;
                lblDay.Dock = DockStyle.Fill;
                lblDay.ForeColor = (i == 0) ? Color.Red : Color.Black;
                lblDay.Font = new Font("Microsoft Sans Serif", 12f); // Set font to Microsoft Sans Serif, 12pt
                tableLayoutPanel1.Controls.Add(lblDay, i, 0);
            }

            // Thêm các ngày vào lịch
            int day = 1;
            for (int row = 1; row < 6; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    if (row == 1 && col < startDayOfWeek)
                    {
                        // Các ô trước ngày đầu tiên của tháng để trống
                        tableLayoutPanel1.Controls.Add(new Label(), col, row);
                    }
                    else if (day <= daysInMonth)
                    {
                        Label lblDate = new Label();
                        lblDate.Text = day.ToString();
                        lblDate.TextAlign = ContentAlignment.MiddleCenter;
                        lblDate.Dock = DockStyle.Fill;
                        lblDate.BorderStyle = BorderStyle.FixedSingle;
                        lblDate.ForeColor = (col == 0) ? Color.Red : Color.Black;
                        lblDate.Font = new Font("Microsoft Sans Serif", 12f); // Set font to Microsoft Sans Serif, 12pt

                        // Tô màu ngày hiện tại nếu là tháng và năm hiện tại
                        if (day == DateTime.Now.Day && currentMonth == DateTime.Now.Month && currentYear == DateTime.Now.Year)
                        {
                            lblDate.BackColor = Color.LightCoral;
                        }

                        tableLayoutPanel1.Controls.Add(lblDate, col, row);
                        day++;
                    }
                }
            }
        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            // Lùi về tháng trước
            currentMonth--;
            if (currentMonth < 1)
            {
                currentMonth = 12;
                currentYear--;
            }
            SetupCalendar();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            // Tiến về tháng sau
            currentMonth++;
            if (currentMonth > 12)
            {
                currentMonth = 1;
                currentYear++;
            }
            SetupCalendar();
        }
    }
}
