
namespace MovieProjcet
{
    partial class Dublin_Skill
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Skill = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 2);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lbl_Skill);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(113, 14);
            this.panel2.TabIndex = 12;
            // 
            // lbl_Skill
            // 
            this.lbl_Skill.AutoEllipsis = true;
            this.lbl_Skill.AutoSize = true;
            this.lbl_Skill.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Skill.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Skill.Font = new System.Drawing.Font("Cambria", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Skill.ForeColor = System.Drawing.Color.White;
            this.lbl_Skill.Location = new System.Drawing.Point(0, 0);
            this.lbl_Skill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Skill.Name = "lbl_Skill";
            this.lbl_Skill.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lbl_Skill.Size = new System.Drawing.Size(91, 12);
            this.lbl_Skill.TabIndex = 10;
            this.lbl_Skill.Text = "Financial Analysis";
            // 
            // Dublin_Skill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(76)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.panel2);
            this.Name = "Dublin_Skill";
            this.Size = new System.Drawing.Size(113, 14);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lbl_Skill;
    }
}
