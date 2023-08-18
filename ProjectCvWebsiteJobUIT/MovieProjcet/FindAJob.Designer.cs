
namespace MovieProjcet
{
    partial class FindAJob
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
            this.pnlmain = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Search = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.jobType1 = new MovieProjcet.JobType();
            this.jobType2 = new MovieProjcet.JobType();
            this.jobType3 = new MovieProjcet.JobType();
            this.jobType4 = new MovieProjcet.JobType();
            this.pnlmain.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlmain
            // 
            this.pnlmain.AutoScroll = true;
            this.pnlmain.Controls.Add(this.pnlSearch);
            this.pnlmain.Controls.Add(this.panel5);
            this.pnlmain.Controls.Add(this.pnlBody);
            this.pnlmain.Controls.Add(this.panel6);
            this.pnlmain.Controls.Add(this.flowLayoutPanel2);
            this.pnlmain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.pnlmain.Location = new System.Drawing.Point(5, 1);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(851, 751);
            this.pnlmain.TabIndex = 7;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.panel1);
            this.pnlSearch.Location = new System.Drawing.Point(3, 3);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(824, 62);
            this.pnlSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Maiandra GD", 14F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.White;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 32;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(361, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.btnSearch.Size = new System.Drawing.Size(136, 39);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Search);
            this.panel1.Location = new System.Drawing.Point(6, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 39);
            this.panel1.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Search.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Search.Location = new System.Drawing.Point(10, 9);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(323, 20);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            this.Search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Search_MouseClick);
            this.Search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Search_KeyUp);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(3, 71);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(824, 34);
            this.panel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 16F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recruitment news, best jobs";
            // 
            // pnlBody
            // 
            this.pnlBody.AutoScroll = true;
            this.pnlBody.Location = new System.Drawing.Point(3, 111);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(824, 497);
            this.pnlBody.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(3, 614);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(824, 34);
            this.panel6.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 16F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(2, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Recruitment news, best jobs";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(this.jobType1);
            this.flowLayoutPanel2.Controls.Add(this.jobType2);
            this.flowLayoutPanel2.Controls.Add(this.jobType3);
            this.flowLayoutPanel2.Controls.Add(this.jobType4);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 654);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(824, 200);
            this.flowLayoutPanel2.TabIndex = 3;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // jobType1
            // 
            this.jobType1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.jobType1.Location = new System.Drawing.Point(3, 3);
            this.jobType1.Name = "jobType1";
            this.jobType1.Size = new System.Drawing.Size(250, 173);
            this.jobType1.TabIndex = 0;
            // 
            // jobType2
            // 
            this.jobType2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.jobType2.Location = new System.Drawing.Point(259, 3);
            this.jobType2.Name = "jobType2";
            this.jobType2.Size = new System.Drawing.Size(250, 173);
            this.jobType2.TabIndex = 1;
            // 
            // jobType3
            // 
            this.jobType3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.jobType3.Location = new System.Drawing.Point(515, 3);
            this.jobType3.Name = "jobType3";
            this.jobType3.Size = new System.Drawing.Size(250, 173);
            this.jobType3.TabIndex = 2;
            // 
            // jobType4
            // 
            this.jobType4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.jobType4.Location = new System.Drawing.Point(771, 3);
            this.jobType4.Name = "jobType4";
            this.jobType4.Size = new System.Drawing.Size(250, 173);
            this.jobType4.TabIndex = 3;
            // 
            // FindAJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(853, 749);
            this.Controls.Add(this.pnlmain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FindAJob";
            this.Text = "FindAJob";
            this.Load += new System.EventHandler(this.FindAJob_Load);
            this.Shown += new System.EventHandler(this.FindAJob_Shown);
            this.pnlmain.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel pnlmain;
        public System.Windows.Forms.Panel pnlSearch;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox Search;
        public FontAwesome.Sharp.IconButton btnSearch;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.FlowLayoutPanel pnlBody;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public JobType jobType1;
        public JobType jobType2;
        public JobType jobType3;
        public JobType jobType4;
    }
}