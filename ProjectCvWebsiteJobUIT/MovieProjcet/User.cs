using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using AForge.Video;
using AForge.Video.DirectShow;

namespace MovieProjcet
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        public static List<History> ListHistory = new List<History>();

        XmlDocument xmlDoc = new XmlDocument();
        XmlDocument xmlDocUser = new XmlDocument();
        XmlNodeList nodeList = null;
        // XmlNodeList nodeList = null;

        private void User_Load(object sender, EventArgs e)
        {
            xmlDoc.Load(@"..\\..\\Dataset\Dataset.xml");
            xmlDocUser.Load(@"..\\..\\Dataset\User.xml");
            foreach (XmlNode node1 in xmlDocUser.SelectNodes("/info" + "/profile"))
            {
                string __ = node1.SelectSingleNode("username").InnerText.Trim();
                if (__ == UserPage.UserName)
                {
                    /*titleName.Text = node1.SelectSingleNode("name").InnerText.Trim();
                    titlePhone.Text = node1.SelectSingleNode("phonenumber").InnerText.Trim();
                    titleAge.Text = node1.SelectSingleNode("age").InnerText.Trim();
                    titleAddress.Text = node1.SelectSingleNode("address").InnerText.Trim();
                    passwordTemp = node1.SelectSingleNode("password").InnerText.Trim();*/
                    stateavttemp = node1.SelectSingleNode("stateavt").InnerText.Trim();
                    break;
                }

            }
            if (stateavttemp == "1")
            {
                ptr_Playlist.BackgroundImage = Image.FromFile(@"..\\..\\Avt\" + UserPage.UserName + ".jpg");
                Temp = ptr_Playlist.BackgroundImage;
            }
            else
            {

            }
        }
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
        public Image Temp;
        string passwordTemp;
        string stateavttemp = "";
        private void User_Shown(object sender, EventArgs e)
        {
            foreach (XmlNode node in xmlDoc.SelectNodes("/Dataset" + "/info"))
            {
                string _ = node.SelectSingleNode(UserPage.UserName).InnerText.Trim();
                if(_ == "1")
                {
                    NameJob = node.SelectSingleNode("job").InnerText.Trim();
                    NameCompany = node.SelectSingleNode("name").InnerText.Trim();
                    ValueSalary = node.SelectSingleNode("salary").InnerText.Trim();
                    NameLocation = node.SelectSingleNode("location").InnerText.Trim();
                    LogoImage = Image.FromFile(@"..\\..\\Dataset\Logo\" + NameCompany + ".jpg");
                    ValueID = "1";//node.SelectSingleNode("id").InnerText.Trim();

                    NameJobType = node.SelectSingleNode("jobtype").InnerText.Trim();
                    NameGender = node.SelectSingleNode("gender").InnerText.Trim();
                    ValueNumberRecruit = node.SelectSingleNode("numberrecruitment").InnerText.Trim();
                    NameLevel = node.SelectSingleNode("requiredlevel").InnerText.Trim();
                    NameExperience = node.SelectSingleNode("experience").InnerText.Trim();

                    HistoryBox x = new HistoryBox();

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

                    pnlHistory.Controls.Add(x);
                }
            }
            foreach (XmlNode node1 in xmlDocUser.SelectNodes("/info" + "/profile"))
            {
                string __ = node1.SelectSingleNode("username").InnerText.Trim();
                if (__ == UserPage.UserName)
                {
                    titleName.Text = node1.SelectSingleNode("name").InnerText.Trim();
                    titlePhone.Text = node1.SelectSingleNode("phonenumber").InnerText.Trim();
                    titleAge.Text = node1.SelectSingleNode("age").InnerText.Trim();
                    titleAddress.Text = node1.SelectSingleNode("address").InnerText.Trim();
                    passwordTemp = node1.SelectSingleNode("password").InnerText.Trim();
                    /*stateavttemp = node1.SelectSingleNode("stateavt").InnerText.Trim();*/
                    break;
                }

            }
        }
        public void UpdateProfile()
        {
            foreach (XmlNode node in xmlDocUser.SelectNodes("/info" + "/profile"))
            {
                string _ = node.SelectSingleNode("username").InnerText.Trim();
                if (_ == UserPage.UserName)
                {
                        XmlNode UpdateName = node.SelectSingleNode("name");
                        UpdateName.InnerText = editName.Text;

                        XmlNode UpdatePhone = node.SelectSingleNode("phonenumber");
                        UpdatePhone.InnerText = editPhoneNumber.Text;

                        XmlNode UpdateAge = node.SelectSingleNode("age");
                        UpdateAge.InnerText = editDateOfBirth.Text;

                        XmlNode UpdateAdress = node.SelectSingleNode("address");
                        UpdateAdress.InnerText = editAddress.Text;
                        break;
                }
            }
            xmlDocUser.Save(@"..\\..\\Dataset\User.xml");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(buttonEditProfile.Text == "Edit profile")
            {
                editPhoneNumber.Text = titlePhone.Text;
                editDateOfBirth.Text = titleAge.Text;
                editAddress.Text = titleAddress.Text;
                editName.Text = titleName.Text;

                titlePhone.Visible = false;
                titleAge.Visible = false;
                titleAddress.Visible = false;

                editAddress.Visible = true;
                editDateOfBirth.Visible = true;
                editPhoneNumber.Visible = true;
                iconEditName.Visible = true;
                buttonEditProfile.Text = "Update";

            } 
            else
            {
                titlePhone.Text = editPhoneNumber.Text;
                titleAge.Text = editDateOfBirth.Text;
                titleAddress.Text = editAddress.Text;
                titleName.Text = editName.Text;

                titlePhone.Visible = true;
                titleAge.Visible = true;
                titleAddress.Visible = true;
                titleName.Visible = true;

                editAddress.Visible = false;
                editDateOfBirth.Visible = false;
                editPhoneNumber.Visible = false;
                iconEditName.Visible = false;
                editName.Visible = false;
                buttonEditProfile.Text = "Edit profile";
                UpdateProfile();
            }

        }
        private void ptr_Playlist_MouseMove(object sender, MouseEventArgs e)
        {
            if (buttonEditProfile.Text == "Update")
            {
                ptr_Playlist.BackgroundImage = Image.FromFile(@"..\\..\\Dataset\Icon\ChoosePhoto.png");
                ptr_Playlist.BackColor = Color.Gray;
            }
        }
        private void ptr_Playlist_MouseLeave(object sender, EventArgs e)
        {
            if (buttonEditProfile.Text == "Update")
            {
                ptr_Playlist.BackgroundImage = Temp;
                ptr_Playlist.BackColor = Color.White;
            }
            
        }
        private void iconEditName_Click(object sender, EventArgs e)
        {
            titleName.Visible = false;
            editName.Visible = true;
        }
        string imgpath = "";
        public void OpenFile()
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imgpath = openFileDialog1.FileName;
                    ptr_Playlist.BackgroundImage = Image.FromFile(imgpath);
                    Temp = Image.FromFile(imgpath);
                    File.Copy(imgpath, Path.Combine(@"..\\..\\Avt\", Path.GetFileName(@"C:\Users\vietn\Downloads\" + UserPage.UserName + ".jpg")),true);
                }
            }
        }
        private void ptr_Playlist_Click(object sender, EventArgs e)
        {
           if(buttonEditProfile.Text == "Update")
            {
                pnlSelectPictureAvatar.Visible = true;
            }
        }
        private void SelectFromAlbum_Click(object sender, EventArgs e)
        {
            OpenFile();
            pnlSelectPictureAvatar.Visible = false;
        }
        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            if(buttonChangePassword.Text == "Change password")
            {
                buttonChangePassword.Text = "Save";
                OldPassword.Enabled = true;
                NewPassword.Enabled = true;
                ReEnter.Enabled = true;
            } else
            {
                if(OldPassword.Text == passwordTemp)
                {
                    if (NewPassword.Text == ReEnter.Text)
                    {
                        Alert.Text = "Update successful";
                        Alert.ForeColor = Color.Green;
                        Alert.Visible = true;
                        OldPassword.Enabled = false;
                        NewPassword.Enabled = false;
                        ReEnter.Enabled = false;
                        buttonChangePassword.Text = "Change password";

                        foreach (XmlNode node in xmlDocUser.SelectNodes("/info" + "/profile"))
                        {
                            string _ = node.SelectSingleNode("username").InnerText.Trim();
                            if (_ == UserPage.UserName)
                            {
                                XmlNode UpdatePassword = node.SelectSingleNode("password");
                                UpdatePassword.InnerText = NewPassword.Text;
                                passwordTemp = NewPassword.Text;
                                break;
                            }
                        }
                        xmlDocUser.Save(@"..\\..\\Dataset\User.xml");
                    }else
                    {
                        Alert.Text = "Re-enter new password is incorrect";
                        Alert.ForeColor = Color.Red;
                        Alert.Visible = true;
                    }
                } else
                {
                    Alert.Text = "Old password is incorrect";
                    Alert.ForeColor = Color.Red;
                    Alert.Visible = true;
                }
            }
        }
        private void OldPassword_TextChanged(object sender, EventArgs e)
        {
            OldPassword.PasswordChar = '*';
            NewPassword.PasswordChar = '*';
            ReEnter.PasswordChar = '*';
        }

        private void pnlHistory_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
