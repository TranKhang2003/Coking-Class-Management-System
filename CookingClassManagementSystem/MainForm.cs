using CookingClassManagementSystem.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CookingClassManagementSystem
{
    public partial class MainForm : Form
    {
        private bool isMaximized = false;
        //HomeControl homeControl = new HomeControl();
        public MainForm()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;

            //homeControl.Dock = DockStyle.Fill;
            //panel3.Controls.Add(homeControl);
            //homeControl.BringToFront();


            //homeControl.ShowDetailsRequested += HomeControl_ShowDetailsRequested;
            loadListView();
        }
        void loadListView()
        {
            // Clear existing items
            listViewClass.Items.Clear();

            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(64, 64); 

         
            listViewClass.LargeImageList = imageList; 

            
            DataTable classData = LopHocDAO.Instance.GetClass();

          
            int imageIndex = 0;
            string defaultImagePath = "Image\\a.jpg";
         
            foreach (DataRow row in classData.Rows)
            {
               
                string imagePath = row["HinhAnhMon"].ToString();
                Bitmap image;

                if (File.Exists(defaultImagePath))
                {
                    
                    image = new Bitmap(imagePath);
                    imageList.Images.Add(image);
                }
               


               
               
                ListViewItem item = new ListViewItem(row["TenMon"].ToString())
                {
                    ImageIndex = imageIndex // Associate the item with the image
                };

                // Add subitems
                item.SubItems.Add(row["ChiPhi"].ToString());

                // Add the item to the ListView
                listViewClass.Items.Add(item);

                // Increment the image index
                imageIndex++;
           
                Console.WriteLine("Added item: " + row["TenMon"].ToString());

            }
        }

        private void label3_Click(object sender, EventArgs e) { }

        private void button15_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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
            //homeControl.BringToFront();
        }

        private void HomeControl_ShowDetailsRequested(object sender, EventArgs e)
        {

            //DetailsClassControl detailsClassControl = new DetailsClassControl
            //{
            //    Dock = DockStyle.Fill
            //};

            //panel3.Controls.Clear(); // Xóa các control hiện tại trong panel3
            //panel3.Controls.Add(detailsClassControl); // Thêm DetailsClassControl vào panel3
            //detailsClassControl.BringToFront();




        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
