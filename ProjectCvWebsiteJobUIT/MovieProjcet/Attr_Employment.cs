using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieProjcet
{
    public partial class Attr_Employment : UserControl
    {
        public Attr_Employment()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void Attr_Employment_Load(object sender, EventArgs e)
        {

        }

        private void txt_JobTitle_TextChange(object sender, EventArgs e)
        {
            if (txt_JobTitle.Text != "")
            {
                lbl_Title.Text = txt_JobTitle.Text;
                if (txt_Employer.Text != "")
                {
                    lbl_Title.Text = txt_JobTitle.Text + " at " + txt_Employer.Text;
                }
            }
            else if (txt_Employer.Text != "")
            {
                lbl_Title.Text = txt_Employer.Text;
            }
        }

        private void txt_Employer_TextChange(object sender, EventArgs e)
        {
            if (txt_JobTitle.Text != "")
            {
                lbl_Title.Text = txt_JobTitle.Text;
                if (txt_Employer.Text != "")
                {
                    lbl_Title.Text = txt_JobTitle.Text + " at " + txt_Employer.Text;
                }
            }
            else if (txt_Employer.Text != "")
            {
                lbl_Title.Text = txt_Employer.Text;
            }
        }

        bool isCollapsed = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                btn_Collapse.BackgroundImage = Image.FromFile(@"..//..//Icon/up-arrow.png");
                this.Height += 10;
                if (this.Size == this.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                btn_Collapse.BackgroundImage = Image.FromFile(@"..//..//Icon/down-arrow.png");
                this.Height -= 10;
                if (this.Size == this.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel flowLayout = (FlowLayoutPanel)this.Parent;
            flowLayout.Controls.Remove(this);
        }

        private void btn_Collapse_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
