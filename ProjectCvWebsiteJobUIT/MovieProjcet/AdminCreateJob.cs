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

namespace MovieProjcet
{
    public partial class AdminCreateJob : Form
    {
        public AdminCreateJob()
        {
            InitializeComponent();
        }
        XmlDocument xmlDoc = new XmlDocument();
        XmlNodeList nodeList = null;
        string temp = "";
        public void AddJob()
        {

            temp = UserPage.UserName;
            XmlNode info = xmlDoc.CreateElement("info");
            XmlNode Companyname = xmlDoc.CreateElement("name");
            XmlNode Namejob = xmlDoc.CreateElement("job");
            XmlNode Jobtype = xmlDoc.CreateElement("jobtype");
            XmlNode Numbercruit = xmlDoc.CreateElement("numberrecruitment");
            XmlNode JobDes = xmlDoc.CreateElement("jobdescription");
            XmlNode Right = xmlDoc.CreateElement("right");
            XmlNode Level = xmlDoc.CreateElement("requiredlevel");
            XmlNode Location = xmlDoc.CreateElement("location");
            XmlNode Experience = xmlDoc.CreateElement("experience");
            XmlNode Salary = xmlDoc.CreateElement("salary");
            XmlNode Gender = xmlDoc.CreateElement("gender");
            XmlNode user1 = xmlDoc.CreateElement("user1");
            XmlNode user2 = xmlDoc.CreateElement("user2");
            XmlNode user3 = xmlDoc.CreateElement("user3");
            XmlNode user4 = xmlDoc.CreateElement("user4");
            XmlNode address = xmlDoc.CreateElement("address");
            XmlNode coordinate = xmlDoc.CreateElement("coordinate");
            XmlNode Current = xmlDoc.CreateElement(temp);



            /*< address > 18 Nguyễn Thị Nhung, Khu đô thị Vạn Phúc, P Hiệp Bình Phước, Thủ Đức </ address >
   
       < coordinate > 10.845162856540211, 106.70903946959791 </ coordinate >*/

            address.InnerText = "18 Nguyễn Thị Nhung, Khu đô thị Vạn Phúc, P Hiệp Bình Phước, Thủ Đức";
            coordinate.InnerText = "10.845162856540211, 106.7090394695979";
            Current.InnerText = "0";
            user1.InnerText = "0";
            user2.InnerText = "0";
            user3.InnerText = "0";
            user4.InnerText = "0";
            Companyname.InnerText = textBox9.Text;
            Namejob.InnerText = textBox1.Text;
            Jobtype.InnerText = textBox2.Text;
            Numbercruit.InnerText = textBox4.Text;
            JobDes.InnerText = richTextBox1.Text;
            Right.InnerText = richTextBox2.Text;
            Level.InnerText = textBox7.Text;
            Location.InnerText = textBox8.Text;
            Experience.InnerText = textBox6.Text;
            Salary.InnerText = textBox5.Text;
            Gender.InnerText = textBox3.Text;

            info.AppendChild(Current);
            info.AppendChild(address);
            info.AppendChild(coordinate);
            info.AppendChild(user1);
            info.AppendChild(user2);
            info.AppendChild(user3);
            info.AppendChild(user4);
            info.AppendChild(Companyname);
            info.AppendChild(Namejob);
            info.AppendChild(Jobtype);
            info.AppendChild(Numbercruit);
            info.AppendChild(JobDes);
            info.AppendChild(Right);
            info.AppendChild(Level);
            info.AppendChild(Location);
            info.AppendChild(Experience);
            info.AppendChild(Salary);
            info.AppendChild(Gender);

            xmlDoc.DocumentElement.AppendChild(info);
            xmlDoc.Save(@"..\\..\\Dataset\Dataset.xml");
        }
        string imgpath;
        private void button1_Click(object sender, EventArgs e)
        {
           if(flag == true)
            {
                label12.Text = "Add job successfull!";
                label12.ForeColor = Color.Green;
                label12.Visible = true;
                //imgpath = "@"C: \Users\vietn\Downloads\abc.jpg"";
                File.Copy(imgpath, Path.Combine(@"..\\..\\Dataset\Logo\", Path.GetFileName(@"C:\Users\vietn\Downloads\" + textBox9.Text + ".jpg")), true);
                AddJob();
            }
        }

        private void AdminCreateJob_Load(object sender, EventArgs e)
        {
            xmlDoc.Load(@"..\\..\\Dataset\Dataset.xml");
            xmlDoc.SelectNodes("/Dataset");
            ptr_Playlist.BackgroundImage = Image.FromFile(@"..\\..\\Dataset\Icon\ChoosePhoto.png");
            ptr_Playlist.BackColor = Color.Gray;
        }
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
                    //Temp = Image.FromFile(imgpath);
                    //File.Copy(imgpath, Path.Combine(@"..\\..\\Dataset\Icon\", Path.GetFileName(imgpath)), true);
                }
            }
        }

        bool flag = false;
        private void ptr_Playlist_Click(object sender, EventArgs e)
        {
            OpenFile();
            flag = true;
        }
    }
}
