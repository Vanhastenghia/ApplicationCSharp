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
    public partial class FindAJob : Form
    {
        public FindAJob()
        {
            InitializeComponent();
        }

        bool flag = true;

        XmlDocument xmlDoc = new XmlDocument();
        XmlNodeList nodeList = null;

        string NameJob = "";
        string ValueID;
        string NameCompany = "";
        string ValueSalary = "";
        string NameLocation = "";
        string NameJobType = "";
        string NameGender = "";
        string ValueNumberRecruit = "";
        string NameLevel = "";
        string NameExperience = "";
        Image LogoImage;

        public Random rd = new Random();
        public int Numbrd = 0;
        public List<int> ListRand = new List<int>();

        private void FindAJob_Load(object sender, EventArgs e)
        {
            xmlDoc.Load(@"..\\..\\Dataset\Dataset.xml");
            nodeList = xmlDoc.SelectNodes("/Dataset" + "/info");
        }

        private void FindAJob_Shown(object sender, EventArgs e)
        {
           for(int i = 0; i< nodeList.Count; i++)
           {
                NameJob = nodeList[i].SelectSingleNode("job").InnerText.Trim();
                NameCompany = nodeList[i].SelectSingleNode("name").InnerText.Trim();
                ValueSalary = nodeList[i].SelectSingleNode("salary").InnerText.Trim();
                NameLocation = nodeList[i].SelectSingleNode("location").InnerText.Trim();
                LogoImage = Image.FromFile(@"..\\..\\Dataset\Logo\" + NameCompany + ".jpg");
                //ValueID = nodeList[i].SelectSingleNode("id").InnerText.Trim();

                NameJobType = nodeList[i].SelectSingleNode("jobtype").InnerText.Trim();
                NameGender = nodeList[i].SelectSingleNode("gender").InnerText.Trim();
                ValueNumberRecruit = nodeList[i].SelectSingleNode("numberrecruitment").InnerText.Trim();
                NameLevel = nodeList[i].SelectSingleNode("requiredlevel").InnerText.Trim();
                NameExperience = nodeList[i].SelectSingleNode("experience").InnerText.Trim();


                RecruitmentBox x = new RecruitmentBox();

                x.RecruimentBoxID = ValueID;
                x.RecruimentBoxCompany = NameCompany;
                x.RecruimentBoxJob = NameJob;
                x.RecruimentBoxLocation = NameLocation;
                x.RecruimentBoxSalary = ValueSalary;
                x.RecruimentBoxLogo = LogoImage;
                x.RecruimentBoxJobType = NameJobType;
                x.RecruimentBoxLevel = NameLevel;
                x.RecruimentBoxGender = NameGender;
                x.RecruimentBoxExperience = NameExperience;
                x.RecruimentBoxNumberRecruit = ValueNumberRecruit;

                pnlBody.Controls.Add(x);
           }
        }

        public static string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
    "đ",
    "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
    "í","ì","ỉ","ĩ","ị",
    "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
    "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
    "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
    "d",
    "e","e","e","e","e","e","e","e","e","e","e",
    "i","i","i","i","i",
    "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
    "u","u","u","u","u","u","u","u","u","u","u",
    "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }

        private void Search_MouseClick(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                Search.Text = "";
                flag = false;
            }
        }

        string TextSearch = "";

        private void Search_KeyUp(object sender, KeyEventArgs e)
        {
            //FindAJob newform = (FindAJob)this.Parent.Parent.Parent.Parent;
            foreach (var item in pnlBody.Controls)
            {
                var f = (RecruitmentBox)item;
                NameCompany = f.titleJob.Text;
                NameJob = f.titleCompany.Text;
                TextSearch = NameCompany + " " + NameJob;
                if (RemoveUnicode(TextSearch).ToLower().Contains(RemoveUnicode(Search.Text).ToLower()))
                {
                    f.Visible = true;
                }
                else
                {
                    f.Visible = false;
                }
            }
        }
    }
}
