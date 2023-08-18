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
    public partial class AddInfoRegister : Form
    {
        public AddInfoRegister()
        {
            InitializeComponent();
        }

        public string GmailRegister;
        public string UserRegister;
        public string PasswordRegister;

        public string GetGmail
        {
            get
            {
                return GmailRegister;
            }
            set { GmailRegister = value; }
        }

        public string GetUser
        {
            get { return UserRegister; }
            set { UserRegister = value; }
        }

        public string GetPassword
        {
            get { return PasswordRegister; }
            set { PasswordRegister = value; }
        }

        private void AddInfoRegister_Load(object sender, EventArgs e)
        {
            xmlDoc.Load(@"..\\..\\Dataset\User.xml");
            xmlDoc.SelectNodes("/info");

            xmlDocData.Load(@"..\\..\\Dataset\Dataset.xml");
            xmlDocData.SelectNodes("/Dataset"+"/info");
            nodeList = xmlDoc.SelectNodes("/Dataset" + "/info");
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

        XmlDocument xmlDoc = new XmlDocument();
        XmlDocument xmlDocData = new XmlDocument();
        XmlNodeList nodeList = null;

        public class Book
        {
            public String title;
        }


        public void UpdateUser()
        {
            XmlNode profile = xmlDoc.CreateElement("profile");
            XmlNode username = xmlDoc.CreateElement("username");
            XmlNode password = xmlDoc.CreateElement("password");
            XmlNode job = xmlDoc.CreateElement("job");
            XmlNode level = xmlDoc.CreateElement("level");
            XmlNode name = xmlDoc.CreateElement("name");
            XmlNode age = xmlDoc.CreateElement("age");
            XmlNode phonenumber = xmlDoc.CreateElement("phonenumber");
            XmlNode address = xmlDoc.CreateElement("address");
            XmlNode gmail = xmlDoc.CreateElement("gmail");
            XmlNode stateavt = xmlDoc.CreateElement("stateavt");

            gmail.InnerText = GmailRegister;
            stateavt.InnerText = "0";
            address.InnerText = Address.Text;
            phonenumber.InnerText = PhoneNumber.Text;
            age.InnerText = Date.Text;
            name.InnerText = Name.Text;
            level.InnerText = Level.Text;
            job.InnerText = Job.Text;
            password.InnerText = PasswordRegister;
            username.InnerText = UserRegister;

            profile.AppendChild(username);
            profile.AppendChild(stateavt);
            profile.AppendChild(password);
            profile.AppendChild(job);
            profile.AppendChild(level);
            profile.AppendChild(name);
            profile.AppendChild(age);
            profile.AppendChild(phonenumber);
            profile.AppendChild(address);
            profile.AppendChild(gmail);

            xmlDoc.DocumentElement.AppendChild(profile);
            xmlDoc.Save(@"..\\..\\Dataset\User.xml");

            foreach (XmlNode node in xmlDocData.SelectNodes("/Dataset" + "/info"))
            {
                XmlNode user = xmlDocData.CreateElement(username.InnerText);
                user.InnerText = "0";
                node.AppendChild(user);
            }
            xmlDocData.Save(@"..\\..\\Dataset\Dataset.xml");
        }

        
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            UpdateUser();
            OpenChildForm(new Sing_in());
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
