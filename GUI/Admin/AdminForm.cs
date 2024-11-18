using GUI.Admin;
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
    public partial class AdminForm : Form
    {
        private Form activeForm = null;
        private ContextMenuStrip contextMenuStrip;
        public AdminForm()
        {
            InitializeComponent();
            hideSubMenu();
        }
        private void hideSubMenu()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
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

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            openChildForm(new ClassroomForm());
            showSubMenu(panelMediaSubMenu);
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            openChildForm(new MonAnForm());
            showSubMenu(panelToolsSubMenu);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            openChildForm(new AddFoodForm());
            showSubMenu(panelMediaSubMenu);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new AddClassForm());
            showSubMenu(panelMediaSubMenu);
        }
    }
}
