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
    public partial class DetailRecruitmentBox : Form
    {
        public DetailRecruitmentBox()
        {
            InitializeComponent();
        }

        public string _lastform;
        public string _id;
        public string LastForm { get => _lastform; set => _lastform = value; }
        public string GetID { get => _id; set => _id = value; }
        public Image DetailRecruimentBoxLogo
        {
            get
            {
                return imageLogo.BackgroundImage;
            }
            set
            {
                imageLogo.BackgroundImage = value;
            }
        }
        public string DetailRecruimentBoxJob
        {
            get
            {
                return titleJob.Text;
            }
            set
            {
                titleJob.Text = value;
            }
        }
        public string DetailRecruimentBoxCompany
        {
            get
            {
                return titleCompany.Text;
            }
            set
            {
                titleCompany.Text = value;
            }
        }
        public string DetailRecruimentBoxLocation
        {
            get
            {
                return titleLocation.Text;
            }
            set
            {
                titleLocation.Text = value;
            }
        }
        public string DetailRecruimentBoxSalary
        {
            get
            {
                return titleSalary.Text;
            }
            set
            {
                titleSalary.Text = value;
            }
        }
        public string DetailRecruimentBoxJobType
        {
            get
            {
                return DetailJobtype.Text;
            }
            set
            {
                DetailJobtype.Text = value;
            }
        }
        public string DetailRecruimentBoxLevel
        {
            get
            {
                return DetailLevel.Text;
            }
            set
            {
                DetailLevel.Text = value;
            }
        }
        public string DetailRecruimentBoxNumberRecruit
        {
            get
            {
                return DetailNumberRecruit.Text;
            }
            set
            {
                DetailNumberRecruit.Text = value;
            }
        }
        public string DetailRecruimentBoxGender
        {
            get
            {
                return DetailGender.Text;
            }
            set
            {
                DetailGender.Text = value;
            }
        }
        public string DetailRecruimentBoxExperience
        {
            get
            {
                return DetailExperience.Text;
            }
            set
            {
                DetailExperience.Text = value;
            }
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
        private void iconPictureBox8_Click(object sender, EventArgs e)
        {
            if(_lastform == "FindAJob")
            {
                OpenChildForm(new FindAJob());
            }
            if (_lastform == "User")
            {
                OpenChildForm(new User());
            }
        }

        XmlDocument xmlDoc = new XmlDocument();
        XmlNodeList nodeList = null;

        public bool flag = true;

        public void ClickApply()
        {
            if(buttonApply.Text == "Apply now")
            {
                foreach (XmlNode node in xmlDoc.SelectNodes("/Dataset" + "/info"))
                {
                    buttonApply.Text = "Applied";
                    buttonApply.BackColor = Color.FromArgb(161, 163, 180);
                    string Name = node.SelectSingleNode("job").InnerText.Trim();
                    if (Name == titleJob.Text)
                    {
                        XmlNode likeNode = node.SelectSingleNode(UserPage.UserName);
                        likeNode.InnerText = "1";
                        break;
                    }
                }
                xmlDoc.Save(@"..\\..\\Dataset\Dataset.xml");
            }
            else
            {
                foreach (XmlNode node in xmlDoc.SelectNodes("/Dataset" + "/info"))
                {
                    buttonApply.Text = "Apply now";
                    buttonApply.BackColor = Color.FromArgb(0, 150, 90);
                    string Name = node.SelectSingleNode("job").InnerText.Trim();
                    if (Name == titleJob.Text)
                    {
                        XmlNode likeNode = node.SelectSingleNode(UserPage.UserName);
                        likeNode.InnerText = "0";
                        break;
                    }
                }
                xmlDoc.Save(@"..\\..\\Dataset\Dataset.xml");
            }
            
        }
        private void buttonApplyNow_Click(object sender, EventArgs e)
        {
            ClickApply();
        }

        private void DetailRecruitmentBox_Load(object sender, EventArgs e)
        {
            xmlDoc.Load(@"..\\..\\Dataset\Dataset.xml");

            foreach (XmlNode node in xmlDoc.SelectNodes("/Dataset" + "/info"))
            {
                string Name = node.SelectSingleNode("job").InnerText.Trim();
                if (Name == titleJob.Text)
                {
                    string StateApply = node.SelectSingleNode(UserPage.UserName).InnerText.Trim();
                    if (StateApply == "1")
                    {
                        buttonApply.Text = "Applied";
                        buttonApply.BackColor = Color.FromArgb(161, 163, 180);
                    }
                    break;
                }
            }
        }
        string tempName = "";
        string tempAddress = "";
        private void iconButton1_Click(object sender, EventArgs e)
        {
            nodeList = xmlDoc.SelectNodes("/Dataset" + "/info");
            for(int i = 0; i < nodeList.Count; i++)
            {
                tempName = nodeList[i].SelectSingleNode("job").InnerText.Trim();
                // tempName = nodeList[i].SelectSingleNode("address").InnerText.Trim();
                if(titleJob.Text == tempName)
                {
                    tempAddress = nodeList[i].SelectSingleNode("address").InnerText.Trim();
                    break;
                }
            }
            OpenChildForm(new NewMap(tempAddress));
        }
    }
}
