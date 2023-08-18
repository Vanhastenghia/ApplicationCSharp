
namespace MovieProjcet
{
    partial class RecruitmentBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecruitmentBox));
            this.imageLogo = new System.Windows.Forms.PictureBox();
            this.titleCompany = new System.Windows.Forms.Label();
            this.rjPanel2 = new MovieProjcet.RJPanel();
            this.titleLocation = new System.Windows.Forms.Label();
            this.rjPanel1 = new MovieProjcet.RJPanel();
            this.titleSalary = new System.Windows.Forms.Label();
            this.titleJob = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).BeginInit();
            this.rjPanel2.SuspendLayout();
            this.rjPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageLogo
            // 
            this.imageLogo.BackColor = System.Drawing.Color.White;
            this.imageLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imageLogo.BackgroundImage")));
            this.imageLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageLogo.Location = new System.Drawing.Point(3, 13);
            this.imageLogo.Name = "imageLogo";
            this.imageLogo.Size = new System.Drawing.Size(60, 60);
            this.imageLogo.TabIndex = 0;
            this.imageLogo.TabStop = false;
            // 
            // titleCompany
            // 
            this.titleCompany.AutoSize = true;
            this.titleCompany.Font = new System.Drawing.Font("Maiandra GD", 11F);
            this.titleCompany.ForeColor = System.Drawing.Color.Black;
            this.titleCompany.Location = new System.Drawing.Point(70, 50);
            this.titleCompany.Name = "titleCompany";
            this.titleCompany.Size = new System.Drawing.Size(93, 18);
            this.titleCompany.TabIndex = 2;
            this.titleCompany.Text = "FPT Software";
            // 
            // rjPanel2
            // 
            this.rjPanel2.BackColor = System.Drawing.Color.White;
            this.rjPanel2.BorderRadiusBotLeft = 10;
            this.rjPanel2.BorderRadiusBotRight = 10;
            this.rjPanel2.BorderRadiusTopLeft = 10;
            this.rjPanel2.BorderRadiusTopRight = 10;
            this.rjPanel2.Controls.Add(this.titleLocation);
            this.rjPanel2.ForeColor = System.Drawing.Color.Black;
            this.rjPanel2.GradientAng = 90F;
            this.rjPanel2.GradientBottomColor = System.Drawing.Color.LightGray;
            this.rjPanel2.GradientTopColor = System.Drawing.Color.LightGray;
            this.rjPanel2.Location = new System.Drawing.Point(122, 79);
            this.rjPanel2.Name = "rjPanel2";
            this.rjPanel2.Size = new System.Drawing.Size(131, 25);
            this.rjPanel2.TabIndex = 4;
            // 
            // titleLocation
            // 
            this.titleLocation.AutoSize = true;
            this.titleLocation.BackColor = System.Drawing.Color.LightGray;
            this.titleLocation.Font = new System.Drawing.Font("Maiandra GD", 10F);
            this.titleLocation.Location = new System.Drawing.Point(13, 5);
            this.titleLocation.Name = "titleLocation";
            this.titleLocation.Size = new System.Drawing.Size(105, 16);
            this.titleLocation.TabIndex = 0;
            this.titleLocation.Text = "HCM or Hà Nội";
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.White;
            this.rjPanel1.BorderRadiusBotLeft = 10;
            this.rjPanel1.BorderRadiusBotRight = 10;
            this.rjPanel1.BorderRadiusTopLeft = 10;
            this.rjPanel1.BorderRadiusTopRight = 10;
            this.rjPanel1.Controls.Add(this.titleSalary);
            this.rjPanel1.ForeColor = System.Drawing.Color.Black;
            this.rjPanel1.GradientAng = 90F;
            this.rjPanel1.GradientBottomColor = System.Drawing.Color.LightGray;
            this.rjPanel1.GradientTopColor = System.Drawing.Color.LightGray;
            this.rjPanel1.Location = new System.Drawing.Point(7, 79);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(105, 25);
            this.rjPanel1.TabIndex = 3;
            // 
            // titleSalary
            // 
            this.titleSalary.AutoSize = true;
            this.titleSalary.BackColor = System.Drawing.Color.LightGray;
            this.titleSalary.Font = new System.Drawing.Font("Maiandra GD", 10F);
            this.titleSalary.Location = new System.Drawing.Point(14, 5);
            this.titleSalary.Name = "titleSalary";
            this.titleSalary.Size = new System.Drawing.Size(80, 16);
            this.titleSalary.TabIndex = 0;
            this.titleSalary.Text = "400 - 900 $";
            // 
            // titleJob
            // 
            this.titleJob.AutoSize = true;
            this.titleJob.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.titleJob.ForeColor = System.Drawing.Color.Black;
            this.titleJob.Location = new System.Drawing.Point(69, 16);
            this.titleJob.Name = "titleJob";
            this.titleJob.Size = new System.Drawing.Size(154, 19);
            this.titleJob.TabIndex = 1;
            this.titleJob.Text = "Fresher C Embedded";
            // 
            // RecruitmentBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.rjPanel2);
            this.Controls.Add(this.rjPanel1);
            this.Controls.Add(this.titleCompany);
            this.Controls.Add(this.titleJob);
            this.Controls.Add(this.imageLogo);
            this.Name = "RecruitmentBox";
            this.Size = new System.Drawing.Size(262, 113);
            this.Load += new System.EventHandler(this.RecruitmentBox_Load);
            this.Click += new System.EventHandler(this.RecruitmentBox_Click);
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).EndInit();
            this.rjPanel2.ResumeLayout(false);
            this.rjPanel2.PerformLayout();
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox imageLogo;
        public System.Windows.Forms.Label titleCompany;
        public RJPanel rjPanel1;
        public System.Windows.Forms.Label titleSalary;
        public RJPanel rjPanel2;
        public System.Windows.Forms.Label titleLocation;
        public System.Windows.Forms.Label titleJob;
    }
}
