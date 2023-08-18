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
    public partial class UserPage : Form
    {
        public UserPage()
        {
            InitializeComponent();
        }

        public static Form currentChildForm;

        public static Form lastForm;

        public static string currentForm;

        public static string UserName;

        public string CurrentUser
        {
            get 
            {
                return UserName;
            }

            set 
            {
                UserName = value;
            }
        }

        public static bool flag = false;

        private IconButton currentBtn;

        private RJPanel currentPnl;

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

        private void ActivateButton(object senderBtn, object pnl)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentPnl = (RJPanel)pnl;

                currentPnl.GradientBottomColor = Color.FromArgb(48, 53, 81);
                currentPnl.GradientTopColor = Color.FromArgb(48, 53, 81);

                currentBtn.BackColor = Color.FromArgb(48, 53, 81);
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentPnl.GradientBottomColor = Color.FromArgb(53, 58, 85);
                currentPnl.GradientTopColor = Color.FromArgb(53, 58, 85);

                currentBtn.BackColor = Color.FromArgb(53, 58, 85);
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            if (currentForm == "Dashboard") { }
            else { 
                ActivateButton(sender, pnlDashboard);
                OpenChildForm(new Dashboard(), "Dashboard");
            }
        }

        private void buttonJob_Click(object sender, EventArgs e)
        {
            if (currentForm == "FindAJob") { }
            else
            {
                ActivateButton(sender, pnlFindAJob);
                OpenChildForm(new FindAJob(), "FindAJob");
            }
        }

        private void buttonCrateCV_Click(object sender, EventArgs e)
        {
            if (currentForm == "CreateCV") { }
            else
            {
                ActivateButton(sender, pnlCrateCV);
                OpenChildForm(new CreateCV(), "CreateCV");
            }
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            if (currentForm == "User") { }
            else
            {
                ActivateButton(sender, pnlUser);
                OpenChildForm(new User(), "User");
            }
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            ActivateButton(buttonDashboard, pnlDashboard);
            OpenChildForm(new Dashboard(), "Dashboard");

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

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Quit(new Login());
        }
    }
}
