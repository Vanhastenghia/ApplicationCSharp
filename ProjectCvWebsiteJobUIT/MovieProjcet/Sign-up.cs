using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MovieProjcet
{
    public partial class Sign_up : Form
    {
        public Sign_up()
        {
            InitializeComponent();
        }

        private void UserName_Click(object sender, EventArgs e)
        {
            UserName.Text = "";
            pnlColorPassword.BackColor = Color.FromArgb(45, 50, 80);
            pnlColorUserName.BackColor = Color.FromArgb(177, 134, 110);
            pnlColorGmail.BackColor = Color.FromArgb(45, 50, 80);
        }

        private void pnlUserName_Click(object sender, EventArgs e)
        {
            pnlColorPassword.BackColor = Color.FromArgb(45, 50, 80);
            pnlColorUserName.BackColor = Color.FromArgb(177, 134, 110);
            pnlColorGmail.BackColor = Color.FromArgb(45, 50, 80);
        }

        private void Password_Click(object sender, EventArgs e)
        {
            Password.Text = "";
            pnlColorPassword.BackColor = Color.FromArgb(177, 134, 110);
            pnlColorUserName.BackColor = Color.FromArgb(45, 50, 80);
            pnlColorGmail.BackColor = Color.FromArgb(45, 50, 80);
        }

        private void pnlPassword_Click(object sender, EventArgs e)
        {
            pnlColorPassword.BackColor = Color.FromArgb(177, 134, 110);
            pnlColorUserName.BackColor = Color.FromArgb(45, 50, 80);
            pnlColorGmail.BackColor = Color.FromArgb(45, 50, 80);
        }

        private void Gmail_Click(object sender, EventArgs e)
        {
            Gmail.Text = "";
            pnlColorPassword.BackColor = Color.FromArgb(45, 50, 80);
            pnlColorUserName.BackColor = Color.FromArgb(45, 50, 80);
            pnlColorGmail.BackColor = Color.FromArgb(177, 134, 110);
        }

        private void pnlGmail_Click(object sender, EventArgs e)
        {
            pnlColorPassword.BackColor = Color.FromArgb(45, 50, 80);
            pnlColorUserName.BackColor = Color.FromArgb(45, 50, 80);
            pnlColorGmail.BackColor = Color.FromArgb(177, 134, 110);
        }

        public void OpenChildForm(Form childForm)
        {
            Login newform = (Login)this.Parent.Parent;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            newform.pnlBody.Controls.Add(childForm);
            newform.pnlBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public string TempUserName = "";
        public string TempPassword = "";

        private void Sign_up_Load(object sender, EventArgs e)
        {

        }

        XmlDocument xmlDoc = new XmlDocument();
        XmlNodeList nodeList = null;
        private bool flag = false;
        private void button1_Click(object sender, EventArgs e)
        {
            xmlDoc.Load(@"..\\..\\Dataset\User.xml");
            nodeList = xmlDoc.SelectNodes("/info" + "/profile");
            for (int i = 0; i < nodeList.Count; i++)
            {
                TempUserName = nodeList[i].SelectSingleNode("username").InnerText.Trim();
                if (TempUserName == UserName.Text)
                {
                    flag = true;
                    break;
                }
            }
            if (flag == true)
            {
                Alert.Text = "User name has been registered before";
                Alert.Visible = true;
            }
            else
            {
                OpenChildForm(new AddInfoRegister()
                {
                    GetUser = UserName.Text,
                    GetPassword = Password.Text,
                    GetGmail = Gmail.Text
                });
            }
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            if(Password.Text != null && UserName.Text != null)
            {
                buttonNext.Enabled = true;
            }
            
        }
    }
}
