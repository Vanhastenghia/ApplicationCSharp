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
    public partial class OpenTempPlate : Form
    {
        public Form CurForm;

        public Form GetForm
        {
            get
            {
                return CurForm;
            }
            set
            {
                CurForm = value;
            }
        }

        public void Quit(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(childForm);
            pnlBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public OpenTempPlate()
        {
            InitializeComponent();
        }
        public void OpenChildForm(Form childForm)
        {
            UserPage newform = (UserPage)this.Parent.Parent;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            newform.pnlBody.Controls.Add(childForm);
            newform.pnlBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void OpenTempPlate_Load(object sender, EventArgs e)
        {
            Quit(CurForm);
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateCV());
        }
    }
}
