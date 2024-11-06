using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CookingClassManagementSystem.Design;

namespace CookingClassManagementSystem
{
    public partial class FormDetailClass : Form
    {
        public FormDetailClass()
        {
            InitializeComponent();
            Form1_Load();
        }
      
   
        private void Form1_Load()
        {
            Design.Design.RoundControl(buttonJoin, 30);
            Design.Design.RoundControl(panelInfor, 100);
            Design.Design.RoundControl(panelImage, 100);
        }
    }
}
