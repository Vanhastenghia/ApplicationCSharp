
namespace MovieProjcet
{
    partial class AdminPage
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
            this.pnlBody = new System.Windows.Forms.Panel();
            this.rjPanel2 = new MovieProjcet.RJPanel();
            this.Logout = new FontAwesome.Sharp.IconButton();
            this.buttonUser = new FontAwesome.Sharp.IconButton();
            this.buttonCrateCV = new FontAwesome.Sharp.IconButton();
            this.buttonDashboard = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Logo = new FontAwesome.Sharp.IconPictureBox();
            this.rjPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(203)))), ((int)(((byte)(228)))));
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(219, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(939, 788);
            this.pnlBody.TabIndex = 2;
            // 
            // rjPanel2
            // 
            this.rjPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(85)))));
            this.rjPanel2.BorderRadiusBotLeft = 1;
            this.rjPanel2.BorderRadiusBotRight = 1;
            this.rjPanel2.BorderRadiusTopLeft = 1;
            this.rjPanel2.BorderRadiusTopRight = 1;
            this.rjPanel2.Controls.Add(this.Logout);
            this.rjPanel2.Controls.Add(this.buttonUser);
            this.rjPanel2.Controls.Add(this.buttonCrateCV);
            this.rjPanel2.Controls.Add(this.buttonDashboard);
            this.rjPanel2.Controls.Add(this.label2);
            this.rjPanel2.Controls.Add(this.Logo);
            this.rjPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.rjPanel2.ForeColor = System.Drawing.Color.Black;
            this.rjPanel2.GradientAng = 90F;
            this.rjPanel2.GradientBottomColor = System.Drawing.Color.White;
            this.rjPanel2.GradientTopColor = System.Drawing.Color.White;
            this.rjPanel2.Location = new System.Drawing.Point(0, 0);
            this.rjPanel2.Name = "rjPanel2";
            this.rjPanel2.Size = new System.Drawing.Size(219, 788);
            this.rjPanel2.TabIndex = 1;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.Logout.ForeColor = System.Drawing.Color.White;
            this.Logout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.Logout.IconColor = System.Drawing.Color.White;
            this.Logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Logout.IconSize = 26;
            this.Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout.Location = new System.Drawing.Point(12, 718);
            this.Logout.Name = "Logout";
            this.Logout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Logout.Size = new System.Drawing.Size(189, 37);
            this.Logout.TabIndex = 5;
            this.Logout.Text = "Log out";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.BackColor = System.Drawing.Color.White;
            this.buttonUser.FlatAppearance.BorderSize = 0;
            this.buttonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUser.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.buttonUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(184)))));
            this.buttonUser.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.buttonUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(184)))));
            this.buttonUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonUser.IconSize = 26;
            this.buttonUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUser.Location = new System.Drawing.Point(13, 278);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonUser.Size = new System.Drawing.Size(189, 37);
            this.buttonUser.TabIndex = 0;
            this.buttonUser.Text = "Profile";
            this.buttonUser.UseVisualStyleBackColor = false;
            this.buttonUser.Visible = false;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonCrateCV
            // 
            this.buttonCrateCV.BackColor = System.Drawing.Color.White;
            this.buttonCrateCV.FlatAppearance.BorderSize = 0;
            this.buttonCrateCV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrateCV.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.buttonCrateCV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(184)))));
            this.buttonCrateCV.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            this.buttonCrateCV.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(184)))));
            this.buttonCrateCV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonCrateCV.IconSize = 26;
            this.buttonCrateCV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCrateCV.Location = new System.Drawing.Point(13, 216);
            this.buttonCrateCV.Name = "buttonCrateCV";
            this.buttonCrateCV.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonCrateCV.Size = new System.Drawing.Size(189, 37);
            this.buttonCrateCV.TabIndex = 0;
            this.buttonCrateCV.Text = "Create Job";
            this.buttonCrateCV.UseVisualStyleBackColor = false;
            this.buttonCrateCV.Click += new System.EventHandler(this.buttonCrateCV_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(80)))), ((int)(((byte)(224)))));
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            this.buttonDashboard.IconColor = System.Drawing.Color.White;
            this.buttonDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonDashboard.IconSize = 26;
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(13, 151);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonDashboard.Size = new System.Drawing.Size(189, 37);
            this.buttonDashboard.TabIndex = 0;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = false;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Quicksand", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(80)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(84, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Admin";
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.White;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(80)))), ((int)(((byte)(224)))));
            this.Logo.IconChar = FontAwesome.Sharp.IconChar.SlackHash;
            this.Logo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(80)))), ((int)(((byte)(224)))));
            this.Logo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Logo.IconSize = 80;
            this.Logo.Location = new System.Drawing.Point(12, 30);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(80, 80);
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1158, 788);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.rjPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.rjPanel2.ResumeLayout(false);
            this.rjPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RJPanel rjPanel2;
        private FontAwesome.Sharp.IconButton buttonUser;
        private FontAwesome.Sharp.IconButton buttonCrateCV;
        private FontAwesome.Sharp.IconButton buttonDashboard;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox Logo;
        private FontAwesome.Sharp.IconButton Logout;
        public System.Windows.Forms.Panel pnlBody;
    }
}