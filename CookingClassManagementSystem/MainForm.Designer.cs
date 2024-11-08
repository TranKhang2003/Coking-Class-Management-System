using System.Drawing;
using System.Windows.Forms;

namespace CookingClassManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listViewClass = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.largeIconImage = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 718);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(0)))), ((int)(((byte)(21)))));
            this.SidePanel.Location = new System.Drawing.Point(1, 75);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(13, 66);
            this.SidePanel.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(16, 206);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(263, 66);
            this.button3.TabIndex = 4;
            this.button3.Text = "       Calender";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(16, 139);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 66);
            this.button2.TabIndex = 4;
            this.button2.Text = "       Signed up class";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(16, 73);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 66);
            this.button1.TabIndex = 4;
            this.button1.Text = "       Home";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(0)))), ((int)(((byte)(21)))));
            this.panel2.Controls.Add(this.button16);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.button15);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(279, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1089, 24);
            this.panel2.TabIndex = 1;
            // 
            // button16
            // 
            this.button16.AllowDrop = true;
            this.button16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button16.Dock = System.Windows.Forms.DockStyle.Right;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button16.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button16.Location = new System.Drawing.Point(1017, 0);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(24, 24);
            this.button16.TabIndex = 6;
            this.button16.Text = "-";
            this.button16.UseCompatibleTextRendering = true;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button13
            // 
            this.button13.AllowDrop = true;
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.Dock = System.Windows.Forms.DockStyle.Right;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.Location = new System.Drawing.Point(1041, 0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(24, 24);
            this.button13.TabIndex = 6;
            this.button13.UseCompatibleTextRendering = true;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button15
            // 
            this.button15.AllowDrop = true;
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.Dock = System.Windows.Forms.DockStyle.Right;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button15.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button15.Location = new System.Drawing.Point(1065, 0);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(24, 24);
            this.button15.TabIndex = 5;
            this.button15.Text = "X";
            this.button15.UseCompatibleTextRendering = true;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Tomato;
            this.panel4.Controls.Add(this.button12);
            this.panel4.Controls.Add(this.button11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(279, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1089, 52);
            this.panel4.TabIndex = 6;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Right;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(955, 0);
            this.button12.Margin = new System.Windows.Forms.Padding(0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(66, 52);
            this.button12.TabIndex = 5;
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Right;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(1021, 0);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(68, 52);
            this.button11.TabIndex = 6;
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listViewClass);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(279, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1089, 642);
            this.panel3.TabIndex = 7;
            // 
            // listViewClass
            // 
            this.listViewClass.BackColor = System.Drawing.Color.Tomato;
            this.listViewClass.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewClass.HideSelection = false;
            this.listViewClass.HoverSelection = true;
            this.listViewClass.LargeImageList = this.largeIconImage;
            this.listViewClass.Location = new System.Drawing.Point(0, 0);
            this.listViewClass.Name = "listViewClass";
            this.listViewClass.Size = new System.Drawing.Size(1089, 642);
            this.listViewClass.TabIndex = 0;
            this.listViewClass.UseCompatibleStateImageBehavior = false;
            this.listViewClass.View = System.Windows.Forms.View.Tile;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "item1";
            this.columnHeader1.Width = 122;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "item2";
            this.columnHeader2.Width = 143;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Tag = "item3";
            this.columnHeader3.Width = 143;
            // 
            // largeIconImage
            // 
            this.largeIconImage.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.largeIconImage.ImageSize = new System.Drawing.Size(70, 70);
            this.largeIconImage.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1368, 718);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button15;
        private Button button13;
        private Button button16;
        private Panel panel4;
        private Button button12;
        private Button button11;
        private Panel panel3;
        private ListView listViewClass;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ImageList largeIconImage;
    }
}

