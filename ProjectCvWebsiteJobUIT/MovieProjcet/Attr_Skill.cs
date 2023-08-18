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
    public partial class Attr_Skill : UserControl
    {
        public Attr_Skill()
        {
            InitializeComponent();
        }

        private void txt_Skill_TextChange(object sender, EventArgs e)
        {
            lbl_Title.Text = txt_Skill.Text;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel flowLayout = (FlowLayoutPanel)this.Parent;
            flowLayout.Controls.Remove(this);
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

        private void btn_Collapse_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Attr_Skill_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Attr_Skill_Load(object sender, EventArgs e)
        {

        }
    }
}
