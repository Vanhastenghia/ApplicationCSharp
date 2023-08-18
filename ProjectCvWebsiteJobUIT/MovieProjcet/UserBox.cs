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
    public partial class UserBox : UserControl
    {
        public UserBox()
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
        Image img;


        public Image GetimgBox
        {
            get { return img; }
            set { img = value; }
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

        private void UserBox_Load(object sender, EventArgs e)
        {
            label1.Text = nameBox;
            label2.Text = jobBox;
            pictureBox1.BackgroundImage = img;
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
                GetimgBox = img
            };
            OpenChildForm(f);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
