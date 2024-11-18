using GUI.Admin;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace GUI
{
    public partial class MonAnForm : Form
    {
    
        private ContextMenuStrip contextMenuStrip;
        private Form activeForm = null;
        private ImageList imageList = new ImageList();
        
        string connectionString = "Server=LEGION5\\SQLSERVER;Database=QLLHNA;Trusted_Connection=True;";
        public MonAnForm()
        {
           
            InitializeComponent();
            SetupListViewWithImages();
         

            // Tạo ContextMenuStrip
            contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem editItem = new ToolStripMenuItem("Sửa");
            ToolStripMenuItem deleteItem = new ToolStripMenuItem("Xóa");

            // Đăng ký sự kiện cho các mục menu
            editItem.Click += EditItem_Click;
            deleteItem.Click += DeleteItem_Click;

            // Thêm các mục vào ContextMenu
            contextMenuStrip.Items.Add(editItem);
            contextMenuStrip.Items.Add(deleteItem);

            // Gán ContextMenuStrip vào ListView
            listView1.ContextMenuStrip = contextMenuStrip;
        }
        private void MonAnForm_Load(object sender, EventArgs e)
        {
            LoadFoodImagesToListView();
        }
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void SetupListViewWithImages()
        {
            imageList.ImageSize = new Size(90, 90);
            listView1.LargeImageList = imageList;
            listView1.View = View.LargeIcon;
            ForeColor = Color.FromArgb(214, 0, 21);
        }

        public void LoadFoodImagesToListView()
        {
            
              
            string query = "SELECT TenMon, HinhAnhMon FROM MonAn";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    listView1.Items.Clear(); 
                    imageList.Images.Clear(); 

                    while (reader.Read())
                    {
                        string foodName = reader["TenMon"].ToString();

                           
                        byte[] imageBytes = (byte[])reader["HinhAnhMon"];
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            Image foodImage = Image.FromStream(ms);
                            imageList.Images.Add(foodImage); 
                        }

                        
                        ListViewItem item = new ListViewItem
                        {
                            Text = foodName
                        };

                            
                        item.ImageIndex = imageList.Images.Count - 1;

                        listView1.Items.Add(item);
                    }
                }
            }
            
          
        }

        private void EditItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string selectedFoodName = selectedItem.Text;
    
                openChildForm(new EditFoodForm(selectedFoodName ));
                
            }
        }

    
        private void DeleteItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string selectedFoodName = listView1.SelectedItems[0].Text;
                var result = MessageBox.Show($"Bạn có chắc chắn muốn xóa món ăn {selectedFoodName}?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                 
                    string connectionString = "Server=LEGION5\\SQLSERVER;Database=QLLHNA;Trusted_Connection=True;";
                    string deleteQuery = "DELETE FROM MonAn WHERE TenMon = @TenMon";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@TenMon", selectedFoodName);
                                cmd.ExecuteNonQuery();
                            }

                
                            LoadFoodImagesToListView();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting data: " + ex.Message);
                        }
                    }
                }
            }
        }

       
    }
}
