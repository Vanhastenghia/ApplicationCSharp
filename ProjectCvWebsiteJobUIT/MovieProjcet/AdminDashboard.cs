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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }
        XmlDocument xmlDoc = new XmlDocument();
        XmlNodeList nodeList = null;

        XmlDocument xmlDocJob = new XmlDocument();
        XmlNodeList nodeListJob = null;
        string username = "";
        string password = "";
        string job = "";
        string level = "";
        string name = "";
        string age = "";
        string phonenumber = "";
        string address = "";
        string allowcontact = "";
        string statusjob = "";
        string gmail = "";


        string Nameaccount = "";
        string StateJob = "";

        private void AdminDashboard_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < nodeList.Count; i++)
            {
                username = nodeList[i].SelectSingleNode("username").InnerText.Trim();
                password = nodeList[i].SelectSingleNode("name").InnerText.Trim();
                job = nodeList[i].SelectSingleNode("job").InnerText.Trim();
                level = nodeList[i].SelectSingleNode("level").InnerText.Trim();
                name = nodeList[i].SelectSingleNode("name").InnerText.Trim();
                age = nodeList[i].SelectSingleNode("age").InnerText.Trim();
                phonenumber = nodeList[i].SelectSingleNode("phonenumber").InnerText.Trim();
                address = nodeList[i].SelectSingleNode("address").InnerText.Trim();
                gmail = nodeList[i].SelectSingleNode("gmail").InnerText.Trim();
                UserBox x = new UserBox();
                x.GetimgBox = Image.FromFile(@"..\\..\\Avt\"+username+".jpg");
                x.GetusernameBox = username;
                x.GetpasswordBox = password;
                x.GetjobBox = job;
                x.GetlevelBox = level;
                x.GetnameBox = name;
                x.GetageBox = age;
                x.GetphonenumberBox = phonenumber;
                x.GetaddressBox = address;
                x.GetallowcontactBox = allowcontact;
                x.GetstatusjobBox = statusjob;
                x.GetgmailBox = gmail;

                pnlBody.Controls.Add(x);
            }

            for (int h = 0; h < nodeList.Count; h++)
            {
                Nameaccount = nodeList[h].SelectSingleNode("username").InnerText.Trim();
                for (int j = 0; j < nodeListJob.Count; j++)
                {
                    StateJob = nodeListJob[j].SelectSingleNode(Nameaccount).InnerText.Trim();
                    if (StateJob == "1")
                    {
                        username = nodeList[h].SelectSingleNode("username").InnerText.Trim();
                        password = nodeList[h].SelectSingleNode("password").InnerText.Trim();
                        job = nodeList[h].SelectSingleNode("job").InnerText.Trim();
                        level = nodeList[h].SelectSingleNode("level").InnerText.Trim();
                        name = nodeList[h].SelectSingleNode("name").InnerText.Trim();
                        age = nodeList[h].SelectSingleNode("age").InnerText.Trim();
                        phonenumber = nodeList[h].SelectSingleNode("phonenumber").InnerText.Trim();
                        address = nodeList[h].SelectSingleNode("address").InnerText.Trim();
                        gmail = nodeList[h].SelectSingleNode("gmail").InnerText.Trim();

                        RequestJob x = new RequestJob();
                        x.GetimgBox = Image.FromFile(@"..\\..\\Avt\" + username + ".jpg");
                        x.GetusernameBox = username;
                        x.GetpasswordBox = password;
                        x.GetjobBox = job;
                        x.GetlevelBox = level;
                        x.GetnameBox = name;
                        x.GetageBox = age;
                        x.GetphonenumberBox = phonenumber;
                        x.GetaddressBox = address;
                        x.GetallowcontactBox = allowcontact;
                        x.GetstatusjobBox = statusjob;
                        x.GetgmailBox = gmail;
                        x.jobrequestBox = nodeListJob[j].SelectSingleNode("job").InnerText.Trim();
                        x.companyrequestBox = nodeListJob[j].SelectSingleNode("name").InnerText.Trim();
                        pnlAccept.Controls.Add(x);
                    }
                }
            }
            
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            xmlDoc.Load(@"..\\..\\Dataset\User.xml");
            nodeList = xmlDoc.SelectNodes("/info" + "/profile");

            xmlDocJob.Load(@"..\\..\\Dataset\Dataset.xml");
            nodeListJob = xmlDocJob.SelectNodes("/Dataset" + "/info");
        }
    }
}
