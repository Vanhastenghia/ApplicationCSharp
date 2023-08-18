
namespace MovieProjcet
{
    partial class Sign_up
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
            this.buttonNext = new System.Windows.Forms.Button();
            this.pnlColorPassword = new System.Windows.Forms.Panel();
            this.pnlColorUserName = new System.Windows.Forms.Panel();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.Password = new System.Windows.Forms.TextBox();
            this.pnlUserName = new System.Windows.Forms.Panel();
            this.UserName = new System.Windows.Forms.TextBox();
            this.pnlColorGmail = new System.Windows.Forms.Panel();
            this.pnlGmail = new System.Windows.Forms.Panel();
            this.Gmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Alert = new System.Windows.Forms.Label();
            this.pnlPassword.SuspendLayout();
            this.pnlUserName.SuspendLayout();
            this.pnlGmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(155)))), ((int)(((byte)(115)))));
            this.buttonNext.Enabled = false;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Maiandra GD", 14F);
            this.buttonNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.buttonNext.Location = new System.Drawing.Point(135, 386);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(156, 36);
            this.buttonNext.TabIndex = 22;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlColorPassword
            // 
            this.pnlColorPassword.Location = new System.Drawing.Point(43, 282);
            this.pnlColorPassword.Name = "pnlColorPassword";
            this.pnlColorPassword.Size = new System.Drawing.Size(6, 62);
            this.pnlColorPassword.TabIndex = 20;
            // 
            // pnlColorUserName
            // 
            this.pnlColorUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.pnlColorUserName.Location = new System.Drawing.Point(43, 214);
            this.pnlColorUserName.Name = "pnlColorUserName";
            this.pnlColorUserName.Size = new System.Drawing.Size(6, 62);
            this.pnlColorUserName.TabIndex = 19;
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.pnlPassword.Controls.Add(this.Password);
            this.pnlPassword.Location = new System.Drawing.Point(49, 282);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(339, 62);
            this.pnlPassword.TabIndex = 18;
            this.pnlPassword.Click += new System.EventHandler(this.pnlPassword_Click);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Font = new System.Drawing.Font("Maiandra GD", 16F);
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.Password.Location = new System.Drawing.Point(7, 17);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(299, 26);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // pnlUserName
            // 
            this.pnlUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.pnlUserName.Controls.Add(this.UserName);
            this.pnlUserName.Location = new System.Drawing.Point(49, 214);
            this.pnlUserName.Name = "pnlUserName";
            this.pnlUserName.Size = new System.Drawing.Size(339, 62);
            this.pnlUserName.TabIndex = 17;
            this.pnlUserName.Click += new System.EventHandler(this.pnlUserName_Click);
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName.Font = new System.Drawing.Font("Maiandra GD", 16F);
            this.UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.UserName.Location = new System.Drawing.Point(7, 19);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(299, 26);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "User Name";
            this.UserName.Click += new System.EventHandler(this.UserName_Click);
            this.UserName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            // 
            // pnlColorGmail
            // 
            this.pnlColorGmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(134)))), ((int)(((byte)(110)))));
            this.pnlColorGmail.Location = new System.Drawing.Point(43, 146);
            this.pnlColorGmail.Name = "pnlColorGmail";
            this.pnlColorGmail.Size = new System.Drawing.Size(6, 62);
            this.pnlColorGmail.TabIndex = 23;
            // 
            // pnlGmail
            // 
            this.pnlGmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.pnlGmail.Controls.Add(this.Gmail);
            this.pnlGmail.Location = new System.Drawing.Point(49, 146);
            this.pnlGmail.Name = "pnlGmail";
            this.pnlGmail.Size = new System.Drawing.Size(339, 62);
            this.pnlGmail.TabIndex = 21;
            this.pnlGmail.Click += new System.EventHandler(this.pnlGmail_Click);
            // 
            // Gmail
            // 
            this.Gmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.Gmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Gmail.Font = new System.Drawing.Font("Maiandra GD", 16F);
            this.Gmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.Gmail.Location = new System.Drawing.Point(7, 19);
            this.Gmail.Name = "Gmail";
            this.Gmail.Size = new System.Drawing.Size(299, 26);
            this.Gmail.TabIndex = 0;
            this.Gmail.Text = "Gmail";
            this.Gmail.Click += new System.EventHandler(this.Gmail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(33, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Welcome to JobUIT !";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.label3.Location = new System.Drawing.Point(41, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Easier job search with JobUIT";
            // 
            // Alert
            // 
            this.Alert.AutoSize = true;
            this.Alert.Font = new System.Drawing.Font("Maiandra GD", 10F);
            this.Alert.ForeColor = System.Drawing.Color.Red;
            this.Alert.Location = new System.Drawing.Point(48, 351);
            this.Alert.Name = "Alert";
            this.Alert.Size = new System.Drawing.Size(227, 16);
            this.Alert.TabIndex = 25;
            this.Alert.Text = "Password or User Name is incorrect";
            this.Alert.Visible = false;
            // 
            // Sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(431, 443);
            this.Controls.Add(this.Alert);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.pnlColorPassword);
            this.Controls.Add(this.pnlColorUserName);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.pnlUserName);
            this.Controls.Add(this.pnlColorGmail);
            this.Controls.Add(this.pnlGmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sign_up";
            this.Text = "Sign_up";
            this.Load += new System.EventHandler(this.Sign_up_Load);
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.pnlUserName.ResumeLayout(false);
            this.pnlUserName.PerformLayout();
            this.pnlGmail.ResumeLayout(false);
            this.pnlGmail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Panel pnlColorPassword;
        private System.Windows.Forms.Panel pnlColorUserName;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Panel pnlUserName;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Panel pnlColorGmail;
        private System.Windows.Forms.Panel pnlGmail;
        private System.Windows.Forms.TextBox Gmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Alert;
    }
}