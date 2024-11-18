using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI.Admin
{
    public partial class EditClassForm : Form
    {
        ClassroomForm classroomForm;
        private string classId;
        string connectionString = "Server=LEGION5\\SQLSERVER;Database=QLLHNA;Trusted_Connection=True;";
        public EditClassForm(string classId)
        {
            this.classId = classId; 
            InitializeComponent();
        }
        private void LoadClass(string classId)
        {
            string query = "SELECT  FROM LopHocNauAn WHERE MaLopHoc = @MaLopHoc";

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
