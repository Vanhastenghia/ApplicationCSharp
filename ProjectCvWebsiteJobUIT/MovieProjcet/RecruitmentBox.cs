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
    public partial class RecruitmentBox : UserControl
    {


        public RecruitmentBox() {
            InitializeComponent();
        }

        public string _GetID;
        public string RecruimentBoxID
        {
            get
            {
                return _GetID;
            }
            set
            {
                _GetID = value;
            }
        }

        public Image RecruimentBoxLogo {
            get {
                return imageLogo.BackgroundImage;
            }
            set {
                imageLogo.BackgroundImage = value;
            }
        }

        public string RecruimentBoxJob
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

        public string Jobtype;

        public string RecruimentBoxJobType
        {
            get
            {
                return Jobtype;
            }
            set
            {
                Jobtype = value;
            }
        }

        public string Level;

        public string RecruimentBoxLevel
        {
            get
            {
                return Level;
            }
            set
            {
                Level = value;
            }
        }

        public string NumberRecruit;

        public string RecruimentBoxNumberRecruit
        {
            get
            {
                return NumberRecruit;
            }
            set
            {
                NumberRecruit = value;
            }
        }

        public string Gender;

        public string RecruimentBoxGender
        {
            get
            {
                return Gender;
            }
            set
            {
                Gender = value;
            }
        }

        public string Experience;

        public string RecruimentBoxExperience
        {
            get {
                return Experience;
            }
            set {
                Experience = value;
            }
        }

        public string RecruimentBoxCompany {
            get {
                return titleCompany.Text;
            }
            set {
                titleCompany.Text = value;
            }
        }

        public string RecruimentBoxLocation {
            get {
                return titleLocation.Text;
            }
            set {
                titleLocation.Text = value;
            }
        }

        public string RecruimentBoxSalary {
            get {
                return titleSalary.Text;
            }
            set {
                titleSalary.Text = value;
            }
        }

        public void OpenChildForm(Form childForm, string CurrentFrom)
        {
            UserPage newform = (UserPage)this.Parent.Parent.Parent.Parent.Parent;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            newform.pnlBody.Controls.Add(childForm);
            newform.pnlBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void RecruitmentBox_Click(object sender, EventArgs e)
        {
            //if(mainMenu.currentForm)
            DetailRecruitmentBox f = new DetailRecruitmentBox() {
                DetailRecruimentBoxCompany = RecruimentBoxCompany,
                DetailRecruimentBoxJob = RecruimentBoxJob,
                DetailRecruimentBoxSalary = RecruimentBoxSalary,
                DetailRecruimentBoxLogo = RecruimentBoxLogo,
                DetailRecruimentBoxLocation = RecruimentBoxLocation,
                DetailRecruimentBoxExperience = RecruimentBoxExperience,
                DetailRecruimentBoxGender = RecruimentBoxGender,
                DetailRecruimentBoxJobType = RecruimentBoxJobType,
                DetailRecruimentBoxLevel = RecruimentBoxLevel,
                DetailRecruimentBoxNumberRecruit = RecruimentBoxNumberRecruit,
                LastForm = UserPage.currentForm,
                GetID = _GetID,
            };
            
            OpenChildForm(f, "DetailRecruitmentBox");
        }

        private void RecruitmentBox_Load(object sender, EventArgs e)
        {

        }
    }
}
