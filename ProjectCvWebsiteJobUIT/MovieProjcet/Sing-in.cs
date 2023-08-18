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
using System.Net.Mail;
using System.Net;

namespace MovieProjcet
{
    public partial class Sing_in : Form
    {
        public Sing_in()
        {
            InitializeComponent();
        }
        XmlDocument xmlDoc = new XmlDocument();
        XmlNodeList nodeList = null;
        private void UserName_Click(object sender, EventArgs e)
        {
            UserName.Text = "";
            pnlColorPassword.BackColor = Color.FromArgb(45, 50, 80);
            pnlColorUserName.BackColor = Color.FromArgb(177, 134, 110);
        }

        private void pnlUserName_Click(object sender, EventArgs e)
        {
            pnlColorPassword.BackColor = Color.FromArgb(45, 50, 80);
            pnlColorUserName.BackColor = Color.FromArgb(177, 134, 110);
        }

        private void Password_Click(object sender, EventArgs e)
        {
            Password.Text = "";
            Password.PasswordChar = '*';
            pnlColorPassword.BackColor = Color.FromArgb(177, 134, 110);
            pnlColorUserName.BackColor = Color.FromArgb(45, 50, 80);
        }

        private void pnlPassword_Click(object sender, EventArgs e)
        {
            pnlColorPassword.BackColor = Color.FromArgb(177, 134, 110);
            pnlColorUserName.BackColor = Color.FromArgb(45, 50, 80);
        }

        private void Sing_in_Load(object sender, EventArgs e)
        {
            TempUserName = UserName.Text;
        }

        public void OpenChildForm(Form childForm)
        {
            MainMenuPage newform = (MainMenuPage)this.Parent.Parent.Parent.Parent.Parent;
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioAdmin.Checked == true)
            {
                xmlDoc.Load(@"..\\..\\Dataset\Admin.xml");
                nodeList = xmlDoc.SelectNodes("/info" + "/profile");
                for (int i = 0; i < nodeList.Count; i++)
                {
                    TempUserName = nodeList[i].SelectSingleNode("username").InnerText.Trim();
                    TempPassword = nodeList[i].SelectSingleNode("password").InnerText.Trim();
                    if(TempPassword == Password.Text && TempUserName == UserName.Text)
                    {
                        OpenChildForm(new AdminPage() { CurrentAdmin = TempUserName});
                        break;
                    } else Alert.Visible = true;
                }
            }
            if (radioUser.Checked == true)
            {
                xmlDoc.Load(@"..\\..\\Dataset\User.xml");
                nodeList = xmlDoc.SelectNodes("/info" + "/profile");
                for (int i = 0; i < nodeList.Count; i++)
                {
                    TempUserName = nodeList[i].SelectSingleNode("username").InnerText.Trim();
                    TempPassword = nodeList[i].SelectSingleNode("password").InnerText.Trim();
                    if (TempPassword == Password.Text && TempUserName == UserName.Text)
                    {
                        OpenChildForm(new UserPage() { CurrentUser = TempUserName }) ;
                        break;
                    } else Alert.Visible = true;
                }
            } 
        }

        public void GotoForgotPassword(Form childForm)
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

        private void label2_Click(object sender, EventArgs e)
        {
            GotoForgotPassword(new ForgotPassword());
        }
    }
}
