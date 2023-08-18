using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MovieProjcet
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        XmlDocument xmlDoc = new XmlDocument();
        XmlNodeList nodeList = null;
        void Sendpassword(string gmail)
        {
            try
            {

                try
                {
                    var fromAddress = new MailAddress("vanhastenghia@gmail.com");
                    const string frompass = "retrlhyfxjbzkxfa";
                    SmtpClient client = new SmtpClient("smtp.gmail.com");
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.Timeout = 100000;
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(fromAddress.Address, frompass);
                    MailMessage msg = new MailMessage();
                    msg.To.Add(gmail);
                    msg.From = new MailAddress("vanhastenghia@gmail.com");
                    msg.Subject = "ResenPassword";
                    msg.Body = tempPassword;
                    client.Send(msg);
                    MessageBox.Show("Successfully Sent Message.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sing_in());
        }

        string TempUserName = "";
        string tempGmail = "";
        string tempPassword = "";
        bool flag = false;

        private void buttonSend_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nodeList.Count; i++)
            {
                TempUserName = nodeList[i].SelectSingleNode("username").InnerText.Trim();
                if (TempUserName == UserName.Text)
                {
                    tempGmail = nodeList[i].SelectSingleNode("gmail").InnerText.Trim();
                    tempPassword = nodeList[i].SelectSingleNode("password").InnerText.Trim();
                    flag = true;
                    break;
                }
                
            }
            if (flag == true)
            {
                Alert.Text = "Successful";
                Alert.ForeColor = Color.Green;
                Alert.Visible = true;
                Sendpassword(tempGmail);
            }
            else
            {
                Alert.Text = "User name is not registered";
                Alert.ForeColor = Color.Red;
                Alert.Visible = true;
            }

        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            xmlDoc.Load(@"..\\..\\Dataset\User.xml");
            nodeList = xmlDoc.SelectNodes("/info" + "/profile");
        }
    }
}
