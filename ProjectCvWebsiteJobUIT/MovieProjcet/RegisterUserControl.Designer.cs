
namespace MovieProjcet
{
    partial class RegisterUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Password = new System.Windows.Forms.TextBox();
            this.iconHidePassword = new FontAwesome.Sharp.IconPictureBox();
            this.iconUnHidePassword = new FontAwesome.Sharp.IconPictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.userName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHidePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUnHidePassword)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(177)))), ((int)(((byte)(122)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Maiandra GD", 14F);
            this.button1.Location = new System.Drawing.Point(20, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 36);
            this.button1.TabIndex = 34;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(20, 286);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(6, 66);
            this.panel7.TabIndex = 33;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.panel6.Location = new System.Drawing.Point(20, 214);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(6, 66);
            this.panel6.TabIndex = 32;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Password);
            this.panel5.Controls.Add(this.iconHidePassword);
            this.panel5.Controls.Add(this.iconUnHidePassword);
            this.panel5.Location = new System.Drawing.Point(26, 286);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(390, 66);
            this.panel5.TabIndex = 31;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Font = new System.Drawing.Font("Maiandra GD", 14F);
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.Password.Location = new System.Drawing.Point(15, 21);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(335, 23);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // iconHidePassword
            // 
            this.iconHidePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.iconHidePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.iconHidePassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.iconHidePassword.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.iconHidePassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconHidePassword.IconSize = 24;
            this.iconHidePassword.Location = new System.Drawing.Point(356, 20);
            this.iconHidePassword.Name = "iconHidePassword";
            this.iconHidePassword.Size = new System.Drawing.Size(24, 24);
            this.iconHidePassword.TabIndex = 2;
            this.iconHidePassword.TabStop = false;
            // 
            // iconUnHidePassword
            // 
            this.iconUnHidePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.iconUnHidePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.iconUnHidePassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconUnHidePassword.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.iconUnHidePassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUnHidePassword.IconSize = 24;
            this.iconUnHidePassword.Location = new System.Drawing.Point(356, 20);
            this.iconUnHidePassword.Name = "iconUnHidePassword";
            this.iconUnHidePassword.Size = new System.Drawing.Size(24, 24);
            this.iconUnHidePassword.TabIndex = 3;
            this.iconUnHidePassword.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.userName);
            this.panel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel8.Location = new System.Drawing.Point(26, 214);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(390, 66);
            this.panel8.TabIndex = 30;
            this.panel8.Click += new System.EventHandler(this.panel8_Click);
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.userName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userName.Font = new System.Drawing.Font("Maiandra GD", 14F);
            this.userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.userName.HideSelection = false;
            this.userName.Location = new System.Drawing.Point(15, 21);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(335, 23);
            this.userName.TabIndex = 0;
            this.userName.Text = "User name";
            this.userName.Click += new System.EventHandler(this.userName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(18, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Find jobs easier with JobUIT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 39);
            this.label1.TabIndex = 28;
            this.label1.Text = "Welcome to JobUIT!";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(20, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 66);
            this.panel1.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Controls.Add(this.iconPictureBox2);
            this.panel2.Location = new System.Drawing.Point(26, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 66);
            this.panel2.TabIndex = 35;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Maiandra GD", 14F);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.textBox1.Location = new System.Drawing.Point(15, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Name";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 24;
            this.iconPictureBox1.Location = new System.Drawing.Point(356, 20);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(24, 24);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 24;
            this.iconPictureBox2.Location = new System.Drawing.Point(356, 20);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(24, 24);
            this.iconPictureBox2.TabIndex = 3;
            this.iconPictureBox2.TabStop = false;
            // 
            // RegisterUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterUserControl";
            this.Size = new System.Drawing.Size(431, 443);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHidePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUnHidePassword)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.TextBox Password;
        private FontAwesome.Sharp.IconPictureBox iconHidePassword;
        private FontAwesome.Sharp.IconPictureBox iconUnHidePassword;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}
