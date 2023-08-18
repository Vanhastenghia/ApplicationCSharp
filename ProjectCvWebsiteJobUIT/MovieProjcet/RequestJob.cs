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
    public partial class RequestJob : UserControl
    {
        public RequestJob()
        {
            InitializeComponent();
        }
        string usernameBox = "";
        string passwordBox = "";
        string jobBox = "";
        string levelBox = "";
        string nameBox = "";
        string ageBox = "";
        string phonenumberBox = "";
        string addressBox = "";
        string allowcontactBox = "";
        string statusjobBox = "";
        string gmailBox = "";

        string companyrequest = "";
        string jobrequest = "";
        Image img;


        public Image GetimgBox
        {
            get { return img; }
            set { img = value; }
        }
        public string companyrequestBox
        {
            get { return companyrequest; }
            set { companyrequest = value; }
        }

        public string jobrequestBox
        {
            get { return jobrequest; }
            set { jobrequest = value; }
        }

        public string GetusernameBox
        {
            get { return usernameBox; }
            set { usernameBox = value; }
        }
        public string GetpasswordBox
        {
            get { return passwordBox; }
            set { passwordBox = value; }
        }
        public string GetjobBox
        {
            get { return jobBox; }
            set { jobBox = value; }
        }
        public string GetlevelBox
        {
            get { return levelBox; }
            set { levelBox = value; }
        }
        public string GetnameBox
        {
            get { return nameBox; }
            set { nameBox = value; }
        }
        public string GetageBox
        {
            get { return ageBox; }
            set { ageBox = value; }
        }
        public string GetphonenumberBox
        {
            get { return phonenumberBox; }
            set { phonenumberBox = value; }
        }
        public string GetaddressBox
        {
            get { return addressBox; }
            set { addressBox = value; }
        }
        public string GetallowcontactBox
        {
            get { return allowcontactBox; }
            set { allowcontactBox = value; }
        }
        public string GetstatusjobBox
        {
            get { return statusjobBox; }
            set { statusjobBox = value; }
        }
        public string GetgmailBox
        {
            get { return gmailBox; }
            set { gmailBox = value; }
        }

        public void OpenChildForm(Form childForm)
        {
            AdminPage newform = (AdminPage)this.Parent.Parent.Parent.Parent;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            newform.pnlBody.Controls.Add(childForm);
            newform.pnlBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        XmlDocument xmlDoc = new XmlDocument();
        private void button1_Click(object sender, EventArgs e)
        {
            DetailEmployee f = new DetailEmployee()
            {
                GetusernameBoxDetail = GetusernameBox,
                GetpasswordBoxDetail = GetpasswordBox,
                GetjobBoxDetail = GetjobBox,
                GetlevelBoxDetail = GetlevelBox,
                GetnameBoxDetail = GetnameBox,
                GetageBoxDetail = GetageBox,
                GetphonenumberBoxDetail = GetphonenumberBox,
                GetaddressBoxDetail = GetaddressBox,
                GetallowcontactBoxDetail = GetallowcontactBox,
                GetstatusjobBoxDetail = GetstatusjobBox,
                GetgmailBoxDetail = GetgmailBox,
                GetcompanyrequestBox = companyrequestBox,
                GetjobrequestBox = jobrequestBox,
                GetimgBox = img
            };
            f.iconButton1.Visible = true;
            f.iconButton2.Visible = true;
            OpenChildForm(f);
        }

        private void RequestJob_Load(object sender, EventArgs e)
        {
            label1.Text = nameBox;
            label2.Text = jobBox;
            label5.Text = jobrequest;
            label6.Text = companyrequest;
            label21.Text = jobrequest;
            pictureBox1.BackgroundImage = img;
            xmlDoc.Load(@"..\\..\\Dataset\Dataset.xml");
        }

        public void ClickApply()
        {
            foreach (XmlNode node in xmlDoc.SelectNodes("/Dataset" + "/info"))
            {
                label22.Text = node.SelectSingleNode("job").InnerText.Trim();
                iconButton1.Text = "Accepted";
                if (label21.Text == label22.Text)
                {
                    XmlNode likeNode = node.SelectSingleNode(usernameBox);
                    likeNode.InnerText = "0";
                    break;
                }
            }
            xmlDoc.Save(@"..\\..\\Dataset\Dataset.xml");
        }
        public void ClickApply1()
        {
            foreach (XmlNode node in xmlDoc.SelectNodes("/Dataset" + "/info"))
            {
                label22.Text = node.SelectSingleNode("job").InnerText.Trim();
                iconButton2.Text = "Rejected";
                if (label21.Text == label22.Text)
                {
                    XmlNode likeNode = node.SelectSingleNode(usernameBox);
                    likeNode.InnerText = "0";
                    break;
                }
            }
            xmlDoc.Save(@"..\\..\\Dataset\Dataset.xml");
        }

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
                    msg.Subject = "Your request has been accepted";
                    msg.Body = "Request to apply to company" + companyrequest + " ( " + jobrequest + " ) " + "has been accepted";
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

        void Sendpassword1(string gmail)
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
                    msg.Subject = "Your request has been rejected";
                    msg.Body = "Request to apply to company" + companyrequest + " ( " + jobrequest + " ) " + "has been rejected";
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
        private void iconButton1_Click(object sender, EventArgs e)
        {
            ClickApply();
            Sendpassword(gmailBox);
        }

        private void rjPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ClickApply1();
            Sendpassword1(gmailBox);
        }
    }
}
