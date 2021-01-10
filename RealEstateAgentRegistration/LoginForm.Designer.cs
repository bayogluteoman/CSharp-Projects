
namespace RealEstateAgentRegistration
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lbl_time = new System.Windows.Forms.Label();
            this.txt_psswrd = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_psswrd = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_header = new System.Windows.Forms.Label();
            this.lblPasswordAstri = new System.Windows.Forms.Label();
            this.lblUsernameAstri = new System.Windows.Forms.Label();
            this.timerr = new System.Windows.Forms.Timer(this.components);
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_time
            // 
            this.lbl_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_time.Font = new System.Drawing.Font("Rockwell", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl_time.Location = new System.Drawing.Point(1093, 9);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(127, 30);
            this.lbl_time.TabIndex = 16;
            this.lbl_time.Text = "date/time";
            // 
            // txt_psswrd
            // 
            this.txt_psswrd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_psswrd.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_psswrd.Location = new System.Drawing.Point(661, 519);
            this.txt_psswrd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_psswrd.MaxLength = 16;
            this.txt_psswrd.Multiline = true;
            this.txt_psswrd.Name = "txt_psswrd";
            this.txt_psswrd.PasswordChar = '*';
            this.txt_psswrd.Size = new System.Drawing.Size(163, 29);
            this.txt_psswrd.TabIndex = 14;
            // 
            // txt_username
            // 
            this.txt_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_username.BackColor = System.Drawing.SystemColors.Window;
            this.txt_username.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_username.Location = new System.Drawing.Point(661, 400);
            this.txt_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_username.MaximumSize = new System.Drawing.Size(249, 80);
            this.txt_username.MaxLength = 16;
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(163, 26);
            this.txt_username.TabIndex = 13;
            // 
            // lbl_psswrd
            // 
            this.lbl_psswrd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_psswrd.BackColor = System.Drawing.Color.Transparent;
            this.lbl_psswrd.Font = new System.Drawing.Font("Rockwell", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_psswrd.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl_psswrd.Location = new System.Drawing.Point(435, 506);
            this.lbl_psswrd.Name = "lbl_psswrd";
            this.lbl_psswrd.Size = new System.Drawing.Size(247, 59);
            this.lbl_psswrd.TabIndex = 12;
            this.lbl_psswrd.Text = "Password";
            // 
            // lbl_username
            // 
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.Font = new System.Drawing.Font("Rockwell", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl_username.Location = new System.Drawing.Point(435, 386);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(240, 52);
            this.lbl_username.TabIndex = 11;
            this.lbl_username.Text = "Username";
            // 
            // lbl_header
            // 
            this.lbl_header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_header.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl_header.Location = new System.Drawing.Point(0, 0);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(1356, 231);
            this.lbl_header.TabIndex = 10;
            this.lbl_header.Text = "USER LOGIN";
            this.lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPasswordAstri
            // 
            this.lblPasswordAstri.AutoSize = true;
            this.lblPasswordAstri.BackColor = System.Drawing.Color.White;
            this.lblPasswordAstri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordAstri.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblPasswordAstri.Location = new System.Drawing.Point(837, 519);
            this.lblPasswordAstri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordAstri.Name = "lblPasswordAstri";
            this.lblPasswordAstri.Size = new System.Drawing.Size(21, 25);
            this.lblPasswordAstri.TabIndex = 18;
            this.lblPasswordAstri.Text = "*";
            this.lblPasswordAstri.Visible = false;
            // 
            // lblUsernameAstri
            // 
            this.lblUsernameAstri.AutoSize = true;
            this.lblUsernameAstri.BackColor = System.Drawing.Color.White;
            this.lblUsernameAstri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameAstri.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblUsernameAstri.Location = new System.Drawing.Point(832, 400);
            this.lblUsernameAstri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsernameAstri.Name = "lblUsernameAstri";
            this.lblUsernameAstri.Size = new System.Drawing.Size(21, 25);
            this.lblUsernameAstri.TabIndex = 17;
            this.lblUsernameAstri.Text = "*";
            this.lblUsernameAstri.Visible = false;
            // 
            // timerr
            // 
            this.timerr.Tick += new System.EventHandler(this.timer1);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnLogin.Location = new System.Drawing.Point(561, 686);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(217, 47);
            this.btnLogin.TabIndex = 19;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.BackColor = System.Drawing.Color.Transparent;
            this.lblLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblLink.Location = new System.Drawing.Point(535, 753);
            this.lblLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLink.Name = "lblLink";
            this.lblLink.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLink.Size = new System.Drawing.Size(227, 20);
            this.lblLink.TabIndex = 20;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "Can\'t login? Sign up here!";
            this.lblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::RealEstateAgentRegistration.Properties.Resources.backimage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1356, 814);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.txt_psswrd);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_psswrd);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.lblPasswordAstri);
            this.Controls.Add(this.lblUsernameAstri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.TextBox txt_psswrd;
        private System.Windows.Forms.Label lbl_psswrd;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label lblPasswordAstri;
        private System.Windows.Forms.Label lblUsernameAstri;
        private System.Windows.Forms.Timer timerr;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lblLink;
        public System.Windows.Forms.TextBox txt_username;
    }
}

