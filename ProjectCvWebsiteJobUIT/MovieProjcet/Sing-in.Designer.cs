
namespace MovieProjcet
{
    partial class Sing_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sing_in));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlColorPassword = new System.Windows.Forms.Panel();
            this.pnlColorUserName = new System.Windows.Forms.Panel();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.Password = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pnlUserName = new System.Windows.Forms.Panel();
            this.UserName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.radioUser = new System.Windows.Forms.RadioButton();
            this.Alert = new System.Windows.Forms.Label();
            this.pnlPassword.SuspendLayout();
            this.pnlUserName.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.label2.Location = new System.Drawing.Point(268, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Forgot password?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(155)))), ((int)(((byte)(115)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Maiandra GD", 14F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.button1.Location = new System.Drawing.Point(39, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlColorPassword
            // 
            this.pnlColorPassword.Location = new System.Drawing.Point(39, 227);
            this.pnlColorPassword.Name = "pnlColorPassword";
            this.pnlColorPassword.Size = new System.Drawing.Size(6, 62);
            this.pnlColorPassword.TabIndex = 12;
            // 
            // pnlColorUserName
            // 
            this.pnlColorUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(134)))), ((int)(((byte)(110)))));
            this.pnlColorUserName.Location = new System.Drawing.Point(39, 159);
            this.pnlColorUserName.Name = "pnlColorUserName";
            this.pnlColorUserName.Size = new System.Drawing.Size(6, 62);
            this.pnlColorUserName.TabIndex = 11;
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.pnlPassword.Controls.Add(this.Password);
            this.pnlPassword.Location = new System.Drawing.Point(45, 227);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(339, 62);
            this.pnlPassword.TabIndex = 10;
            this.pnlPassword.Click += new System.EventHandler(this.pnlPassword_Click);
            // 
            // Password
            // 
            this.Password.AcceptsReturn = false;
            this.Password.AcceptsTab = false;
            this.Password.AnimationSpeed = 200;
            this.Password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Password.BackgroundImage")));
            this.Password.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.Password.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.Password.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.Password.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.Password.BorderRadius = 1;
            this.Password.BorderThickness = 1;
            this.Password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.DefaultFont = new System.Drawing.Font("Maiandra GD", 16F);
            this.Password.DefaultText = "";
            this.Password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.Password.HideSelection = true;
            this.Password.IconLeft = null;
            this.Password.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.IconPadding = 10;
            this.Password.IconRight = null;
            this.Password.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.Lines = new string[0];
            this.Password.Location = new System.Drawing.Point(7, 14);
            this.Password.MaxLength = 32767;
            this.Password.MinimumSize = new System.Drawing.Size(1, 1);
            this.Password.Modified = false;
            this.Password.Multiline = false;
            this.Password.Name = "Password";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Password.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Password.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Password.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            stateProperties12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Password.OnIdleState = stateProperties12;
            this.Password.Padding = new System.Windows.Forms.Padding(3);
            this.Password.PasswordChar = '\0';
            this.Password.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Password.PlaceholderText = "Password";
            this.Password.ReadOnly = false;
            this.Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Password.SelectedText = "";
            this.Password.SelectionLength = 0;
            this.Password.SelectionStart = 0;
            this.Password.ShortcutsEnabled = true;
            this.Password.Size = new System.Drawing.Size(299, 46);
            this.Password.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.Password.TabIndex = 0;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password.TextMarginBottom = 0;
            this.Password.TextMarginLeft = 3;
            this.Password.TextMarginTop = 0;
            this.Password.TextPlaceholder = "Password";
            this.Password.UseSystemPasswordChar = false;
            this.Password.WordWrap = true;
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // pnlUserName
            // 
            this.pnlUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.pnlUserName.Controls.Add(this.UserName);
            this.pnlUserName.Location = new System.Drawing.Point(45, 159);
            this.pnlUserName.Name = "pnlUserName";
            this.pnlUserName.Size = new System.Drawing.Size(339, 62);
            this.pnlUserName.TabIndex = 9;
            this.pnlUserName.Click += new System.EventHandler(this.pnlUserName_Click);
            // 
            // UserName
            // 
            this.UserName.AcceptsReturn = false;
            this.UserName.AcceptsTab = false;
            this.UserName.AnimationSpeed = 200;
            this.UserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UserName.BackColor = System.Drawing.Color.Transparent;
            this.UserName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserName.BackgroundImage")));
            this.UserName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.UserName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.UserName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.UserName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.UserName.BorderRadius = 1;
            this.UserName.BorderThickness = 1;
            this.UserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName.DefaultFont = new System.Drawing.Font("Maiandra GD", 16F);
            this.UserName.DefaultText = "";
            this.UserName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.UserName.HideSelection = true;
            this.UserName.IconLeft = null;
            this.UserName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName.IconPadding = 10;
            this.UserName.IconRight = null;
            this.UserName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName.Lines = new string[0];
            this.UserName.Location = new System.Drawing.Point(7, 13);
            this.UserName.MaxLength = 32767;
            this.UserName.MinimumSize = new System.Drawing.Size(1, 1);
            this.UserName.Modified = false;
            this.UserName.Multiline = false;
            this.UserName.Name = "UserName";
            stateProperties13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UserName.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.UserName.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UserName.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            stateProperties16.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UserName.OnIdleState = stateProperties16;
            this.UserName.Padding = new System.Windows.Forms.Padding(3);
            this.UserName.PasswordChar = '\0';
            this.UserName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.UserName.PlaceholderText = "User Name";
            this.UserName.ReadOnly = false;
            this.UserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserName.SelectedText = "";
            this.UserName.SelectionLength = 0;
            this.UserName.SelectionStart = 0;
            this.UserName.ShortcutsEnabled = true;
            this.UserName.Size = new System.Drawing.Size(299, 46);
            this.UserName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.UserName.TabIndex = 1;
            this.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserName.TextMarginBottom = 0;
            this.UserName.TextMarginLeft = 3;
            this.UserName.TextMarginTop = 0;
            this.UserName.TextPlaceholder = "User Name";
            this.UserName.UseSystemPasswordChar = false;
            this.UserName.WordWrap = true;
            this.UserName.Click += new System.EventHandler(this.UserName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(33, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 32);
            this.label1.TabIndex = 8;
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
            this.label3.TabIndex = 15;
            this.label3.Text = "Easier job search with JobUIT";
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.radioAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.radioAdmin.Location = new System.Drawing.Point(47, 296);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(74, 23);
            this.radioAdmin.TabIndex = 16;
            this.radioAdmin.TabStop = true;
            this.radioAdmin.Text = "Admin";
            this.radioAdmin.UseVisualStyleBackColor = true;
            // 
            // radioUser
            // 
            this.radioUser.AutoSize = true;
            this.radioUser.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.radioUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.radioUser.Location = new System.Drawing.Point(156, 296);
            this.radioUser.Name = "radioUser";
            this.radioUser.Size = new System.Drawing.Size(58, 23);
            this.radioUser.TabIndex = 17;
            this.radioUser.TabStop = true;
            this.radioUser.Text = "User";
            this.radioUser.UseVisualStyleBackColor = true;
            // 
            // Alert
            // 
            this.Alert.AutoSize = true;
            this.Alert.Font = new System.Drawing.Font("Maiandra GD", 10F);
            this.Alert.ForeColor = System.Drawing.Color.Red;
            this.Alert.Location = new System.Drawing.Point(44, 332);
            this.Alert.Name = "Alert";
            this.Alert.Size = new System.Drawing.Size(227, 16);
            this.Alert.TabIndex = 18;
            this.Alert.Text = "Password or User Name is incorrect";
            this.Alert.Visible = false;
            // 
            // Sing_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(431, 443);
            this.Controls.Add(this.Alert);
            this.Controls.Add(this.radioUser);
            this.Controls.Add(this.radioAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlColorPassword);
            this.Controls.Add(this.pnlColorUserName);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.pnlUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sing_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sing_in";
            this.Load += new System.EventHandler(this.Sing_in_Load);
            this.pnlPassword.ResumeLayout(false);
            this.pnlUserName.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlColorPassword;
        private System.Windows.Forms.Panel pnlColorUserName;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Panel pnlUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioAdmin;
        private System.Windows.Forms.RadioButton radioUser;
        private System.Windows.Forms.Label Alert;
        private Bunifu.UI.WinForms.BunifuTextBox Password;
        private Bunifu.UI.WinForms.BunifuTextBox UserName;
    }
}