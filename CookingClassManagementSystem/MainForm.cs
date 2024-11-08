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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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
            imageList.ImageSize = new Size(80, 80);
                  
            listViewClass.LargeImageList = imageList; 

            
            DataTable classData = LopHocDAO.Instance.GetClass();
            

            int imageIndex = 0;
            string defaultImagePath = "C:\\Users\\admin\\Downloads\\Coking-Class-Management-System-master\\Coking-Class-Management-System-master\\CookingClassManagementSystem\\Image\\a.jpg";
            foreach (DataRow row in classData.Rows)
            {
                System.Drawing.Image originalImage = System.Drawing.Image.FromFile(defaultImagePath); // Đường dẫn ảnh gốc
            Bitmap roundedImage = Design.Design.CreateRoundedImage(originalImage, 30); // Bo góc với bán kính 30
            imageList.Images.Add(roundedImage); // Thêm vào ImageList

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
           

            }
            listViewClass.OwnerDraw = true;

            // Gán sự kiện DrawItem
            listViewClass.DrawItem += (s, e) =>
            {
                
                if (e.Item.Selected)
                {
                    
                    e.Graphics.FillRectangle(Brushes.LightBlue, e.Bounds);
                  
                    e.Graphics.DrawString(e.Item.Text, e.Item.Font, Brushes.White, e.Bounds);
                }
                else
                {
                    e.DrawDefault = true;
                }
            };

            listViewClass.ItemActivate += (s, e) =>
            {
                var selectedItem = listViewClass.SelectedItems[0];
                string itemName = selectedItem.Text; 
                 Console.WriteLine(itemName);
                ShowItemDetails(itemName);
            };
        }
        private void ShowItemDetails(string itemName)
        {
            // Mở form mới và hiển thị thông tin chi tiết của item
            Form detailForm = new FormDetailClass(itemName);
            detailForm.ShowDialog();
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
