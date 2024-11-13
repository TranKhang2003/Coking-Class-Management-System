namespace GUI
{
    partial class SignUp
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
            this.pnPicture = new System.Windows.Forms.Panel();
            this.ptbLogo2 = new System.Windows.Forms.PictureBox();
            this.ptbLogo1 = new System.Windows.Forms.PictureBox();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.llbSignin = new System.Windows.Forms.LinkLabel();
            this.labelCheckaccount = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbSignIn = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.lbRePassword = new System.Windows.Forms.Label();
            this.pnPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo1)).BeginInit();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnPicture
            // 
            this.pnPicture.BackColor = System.Drawing.Color.Red;
            this.pnPicture.Controls.Add(this.ptbLogo2);
            this.pnPicture.Controls.Add(this.ptbLogo1);
            this.pnPicture.Location = new System.Drawing.Point(745, 1);
            this.pnPicture.Margin = new System.Windows.Forms.Padding(4);
            this.pnPicture.Name = "pnPicture";
            this.pnPicture.Size = new System.Drawing.Size(267, 555);
            this.pnPicture.TabIndex = 3;
            // 
            // ptbLogo2
            // 
            this.ptbLogo2.Location = new System.Drawing.Point(23, 455);
            this.ptbLogo2.Margin = new System.Windows.Forms.Padding(4);
            this.ptbLogo2.Name = "ptbLogo2";
            this.ptbLogo2.Size = new System.Drawing.Size(212, 42);
            this.ptbLogo2.TabIndex = 1;
            this.ptbLogo2.TabStop = false;
            // 
            // ptbLogo1
            // 
            this.ptbLogo1.Location = new System.Drawing.Point(23, 69);
            this.ptbLogo1.Margin = new System.Windows.Forms.Padding(4);
            this.ptbLogo1.Name = "ptbLogo1";
            this.ptbLogo1.Size = new System.Drawing.Size(212, 133);
            this.ptbLogo1.TabIndex = 0;
            this.ptbLogo1.TabStop = false;
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.txtRePassword);
            this.pnMenu.Controls.Add(this.lbRePassword);
            this.pnMenu.Controls.Add(this.txtPassword);
            this.pnMenu.Controls.Add(this.labelPassword);
            this.pnMenu.Controls.Add(this.llbSignin);
            this.pnMenu.Controls.Add(this.labelCheckaccount);
            this.pnMenu.Controls.Add(this.btnSignUp);
            this.pnMenu.Controls.Add(this.txtEmail);
            this.pnMenu.Controls.Add(this.txtUsername);
            this.pnMenu.Controls.Add(this.label6);
            this.pnMenu.Controls.Add(this.lbEmail);
            this.pnMenu.Controls.Add(this.lbUsername);
            this.pnMenu.Controls.Add(this.lbSignIn);
            this.pnMenu.Location = new System.Drawing.Point(-55, 1);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(776, 555);
            this.pnMenu.TabIndex = 2;
            // 
            // llbSignin
            // 
            this.llbSignin.AutoSize = true;
            this.llbSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbSignin.LinkColor = System.Drawing.Color.Red;
            this.llbSignin.Location = new System.Drawing.Point(389, 453);
            this.llbSignin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbSignin.Name = "llbSignin";
            this.llbSignin.Size = new System.Drawing.Size(52, 18);
            this.llbSignin.TabIndex = 13;
            this.llbSignin.TabStop = true;
            this.llbSignin.Text = "Sign In";
            this.llbSignin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSignin_LinkClicked);
            // 
            // labelCheckaccount
            // 
            this.labelCheckaccount.AutoSize = true;
            this.labelCheckaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckaccount.Location = new System.Drawing.Point(214, 453);
            this.labelCheckaccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCheckaccount.Name = "labelCheckaccount";
            this.labelCheckaccount.Size = new System.Drawing.Size(176, 18);
            this.labelCheckaccount.TabIndex = 9;
            this.labelCheckaccount.Text = "Already have an account?";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Red;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(111, 383);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSignUp.Size = new System.Drawing.Size(503, 43);
            this.btnSignUp.TabIndex = 8;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.ForeColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(114, 189);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(503, 30);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Text = "Email";
            this.txtEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtEmail_MouseClick);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.ForeColor = System.Drawing.Color.Silver;
            this.txtUsername.Location = new System.Drawing.Point(111, 118);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(10);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(503, 30);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.Text = "Username";
            this.txtUsername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUsername_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 455);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 5;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(110, 152);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(56, 20);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Email";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(107, 81);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(94, 20);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "Username";
            // 
            // lbSignIn
            // 
            this.lbSignIn.AutoSize = true;
            this.lbSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignIn.Location = new System.Drawing.Point(104, 20);
            this.lbSignIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSignIn.Name = "lbSignIn";
            this.lbSignIn.Size = new System.Drawing.Size(146, 39);
            this.lbSignIn.TabIndex = 0;
            this.lbSignIn.Text = "Sign Up";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtPassword.Location = new System.Drawing.Point(114, 258);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(503, 30);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.Text = "Password";
            this.txtPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPassword_MouseClick);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(110, 223);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(91, 20);
            this.labelPassword.TabIndex = 14;
            this.labelPassword.Text = "Password";
            // 
            // txtRePassword
            // 
            this.txtRePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRePassword.ForeColor = System.Drawing.Color.Silver;
            this.txtRePassword.Location = new System.Drawing.Point(114, 335);
            this.txtRePassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtRePassword.Multiline = true;
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(503, 30);
            this.txtRePassword.TabIndex = 17;
            this.txtRePassword.Text = "Confirm Password";
            this.txtRePassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRePassword_MouseClick);
            // 
            // lbRePassword
            // 
            this.lbRePassword.AutoSize = true;
            this.lbRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRePassword.Location = new System.Drawing.Point(110, 301);
            this.lbRePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRePassword.Name = "lbRePassword";
            this.lbRePassword.Size = new System.Drawing.Size(163, 20);
            this.lbRePassword.TabIndex = 16;
            this.lbRePassword.Text = "Confirm Password";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 557);
            this.Controls.Add(this.pnPicture);
            this.Controls.Add(this.pnMenu);
            this.Name = "SignUp";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.pnPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo1)).EndInit();
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnPicture;
        private System.Windows.Forms.PictureBox ptbLogo2;
        private System.Windows.Forms.PictureBox ptbLogo1;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.Label lbRePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.LinkLabel llbSignin;
        private System.Windows.Forms.Label labelCheckaccount;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbSignIn;
    }
}