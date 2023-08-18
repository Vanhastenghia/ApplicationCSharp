using FontAwesome.Sharp;
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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        string AdminName;

        public string CurrentAdmin
        {
            get
            {
                return AdminName;
            }

            set
            {
                AdminName = value;
            }
        }

        private IconButton currentBtn;
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(118, 80, 224);
                currentBtn.ForeColor = Color.White;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                currentBtn.IconColor = Color.White;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = Color.FromArgb(159, 164, 184);
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(159, 164, 184);
            }
        }
        public static Form currentChildForm;
        public static string currentForm;
        public void OpenChildForm(Form childForm, string FormName)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            currentForm = FormName;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(childForm);
            pnlBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new AdminDashboard(), "AdminDashboard");
        }

        private void buttonCrateCV_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new AdminCreateJob(), "AdminCreateJob");
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new AdminProfile(), "AdminProfile");
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            ActivateButton(buttonDashboard);
            OpenChildForm(new AdminDashboard(), "AdminDashboard");
        }
        public void Quit(Form childForm)
        {
            MainMenuPage newform = (MainMenuPage)this.Parent.Parent.Parent;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            newform.pnlBody.Controls.Add(childForm);
            newform.pnlBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Quit(new Login());
        }
    }
}
