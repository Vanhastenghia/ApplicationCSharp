
namespace MovieProjcet
{
    partial class Stockholm_Skill
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Skill = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 1);
            this.panel1.TabIndex = 11;
            // 
            // lbl_Skill
            // 
            this.lbl_Skill.AutoEllipsis = true;
            this.lbl_Skill.AutoSize = true;
            this.lbl_Skill.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Skill.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Skill.Font = new System.Drawing.Font("Cambria", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Skill.ForeColor = System.Drawing.Color.Black;
            this.lbl_Skill.Location = new System.Drawing.Point(0, 0);
            this.lbl_Skill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Skill.Name = "lbl_Skill";
            this.lbl_Skill.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lbl_Skill.Size = new System.Drawing.Size(86, 12);
            this.lbl_Skill.TabIndex = 10;
            this.lbl_Skill.Text = "Financial Analysis";
            // 
            // Stockholm_Skill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Skill);
            this.Name = "Stockholm_Skill";
            this.Size = new System.Drawing.Size(111, 19);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbl_Skill;
    }
}
