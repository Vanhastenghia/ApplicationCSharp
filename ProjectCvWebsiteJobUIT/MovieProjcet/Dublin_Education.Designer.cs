
namespace MovieProjcet
{
    partial class Dublin_Education
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
            this.panel_Body = new System.Windows.Forms.Panel();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_StartandEndDate = new System.Windows.Forms.Label();
            this.lbl_DegreeAndSchool = new System.Windows.Forms.Label();
            this.panel_Body.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Body
            // 
            this.panel_Body.AutoSize = true;
            this.panel_Body.Controls.Add(this.lbl_Description);
            this.panel_Body.Controls.Add(this.lbl_StartandEndDate);
            this.panel_Body.Controls.Add(this.lbl_DegreeAndSchool);
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Body.Location = new System.Drawing.Point(0, 0);
            this.panel_Body.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(220, 43);
            this.panel_Body.TabIndex = 10;
            // 
            // lbl_Description
            // 
            this.lbl_Description.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.Location = new System.Drawing.Point(0, 27);
            this.lbl_Description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbl_Description.Size = new System.Drawing.Size(220, 16);
            this.lbl_Description.TabIndex = 9;
            this.lbl_Description.Text = "Participated in study and homework groups";
            // 
            // lbl_StartandEndDate
            // 
            this.lbl_StartandEndDate.AutoSize = true;
            this.lbl_StartandEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_StartandEndDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_StartandEndDate.Font = new System.Drawing.Font("Century", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StartandEndDate.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_StartandEndDate.Location = new System.Drawing.Point(0, 12);
            this.lbl_StartandEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StartandEndDate.Name = "lbl_StartandEndDate";
            this.lbl_StartandEndDate.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lbl_StartandEndDate.Size = new System.Drawing.Size(97, 15);
            this.lbl_StartandEndDate.TabIndex = 8;
            this.lbl_StartandEndDate.Text = "06/2020 - 12/2023";
            // 
            // lbl_DegreeAndSchool
            // 
            this.lbl_DegreeAndSchool.AutoEllipsis = true;
            this.lbl_DegreeAndSchool.AutoSize = true;
            this.lbl_DegreeAndSchool.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DegreeAndSchool.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_DegreeAndSchool.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DegreeAndSchool.ForeColor = System.Drawing.Color.Black;
            this.lbl_DegreeAndSchool.Location = new System.Drawing.Point(0, 0);
            this.lbl_DegreeAndSchool.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DegreeAndSchool.Name = "lbl_DegreeAndSchool";
            this.lbl_DegreeAndSchool.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lbl_DegreeAndSchool.Size = new System.Drawing.Size(108, 12);
            this.lbl_DegreeAndSchool.TabIndex = 7;
            this.lbl_DegreeAndSchool.Text = "Student at UIT, HCM";
            // 
            // Dublin_Education
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Body);
            this.Name = "Dublin_Education";
            this.Size = new System.Drawing.Size(220, 39);
            this.panel_Body.ResumeLayout(false);
            this.panel_Body.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel_Body;
        public System.Windows.Forms.Label lbl_Description;
        public System.Windows.Forms.Label lbl_StartandEndDate;
        public System.Windows.Forms.Label lbl_DegreeAndSchool;
    }
}
