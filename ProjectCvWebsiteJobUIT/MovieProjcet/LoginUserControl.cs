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
    public partial class LoginUserControl : UserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();
        }

   
        private void userName_Click(object sender, EventArgs e)
        {
            panel6.BackColor = Color.FromArgb(116, 100, 110);
            panel7.BackColor = Color.FromArgb(45, 50, 80);
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            panel6.BackColor = Color.FromArgb(116, 100, 110);
            panel7.BackColor = Color.FromArgb(45, 50, 80);
        }

        private void Password_Click(object sender, EventArgs e)
        {
            panel6.BackColor = Color.FromArgb(45, 50, 80);
            panel7.BackColor = Color.FromArgb(116, 100, 110);
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            panel6.BackColor = Color.FromArgb(45, 50, 80);
            panel7.BackColor = Color.FromArgb(116, 100, 110);
        }
    }
}
