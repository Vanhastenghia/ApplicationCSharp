using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieProjcet
{
    public partial class Stockholm_CV : Form
    {
        Bitmap MemoryImage;
        private PrintDocument printDocument1 = new PrintDocument();
        private PrintPreviewDialog previewdlg = new PrintPreviewDialog();
        string imgpath;
        public Stockholm_CV()
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printdoc1_PrintPage);
        }
       
        public void GetPrintArea(Panel pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, MemoryImage.Width, MemoryImage.Height));
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (MemoryImage != null)
            {
                e.Graphics.DrawImage(MemoryImage, 0, 0);
                base.OnPaint(e);
            }
        }
        void printdoc1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, 0, 0);
        }
        public void Print(Panel pnl)
        {
            GetPrintArea(pnl);
            previewdlg.Document = printDocument1;
            previewdlg.ShowDialog();
        }
        private void CheckedSkill(CheckBox checkBox)
        {
            if (checkBox.Checked == true)
            {
                Attr_Skill newSkill = new Attr_Skill();
                newSkill.txt_Skill.Text = checkBox.Text;
                Flpnl_Skill_Body.Controls.Add(newSkill);
            }
            else
            {
                foreach (Attr_Skill skill in Flpnl_Skill_Body.Controls)
                {
                    if (skill.txt_Skill.Text == checkBox.Text)
                    {
                        Flpnl_Skill_Body.Controls.Remove(skill);
                        break;
                    }
                }
            }
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            lbl_FullName.Text = txt_FirstName.Text + " " + txt_LastName.Text;
            lbl_ProfessionalSummary.Text = txt_ProfessionalSummary.Text;
            lbl_Address.Text = txt_Address.Text;
            lbl_City.Text = txt_City.Text;
            lbl_Country.Text = txt_Country.Text;
            lbl_Phone.Text = txt_Phone.Text;
            lbl_Gmail.Text = txt_Email.Text;

            ptr_Avata.Image = ptr_Photo.Image;
            lbl_Job.Text = txt_WantedJobTitle.Text;

            Flpnl_EmploymentHistory.Controls.Clear();
            foreach (Attr_Employment item in Flpnl_Employment_Body.Controls)
            {
                Stockholm_Employment newEmployment = new Stockholm_Employment();
                newEmployment.lbl_EmploymentAndEmployer.Text = "";
                newEmployment.lbl_StartandEndDate.Text = "";
                newEmployment.lbl_Description.Text = "";

                if (item.txt_JobTitle.Text != "")
                {
                    newEmployment.lbl_EmploymentAndEmployer.Text += item.txt_JobTitle.Text;
                    if (item.txt_Employer.Text != "")
                    {
                        newEmployment.lbl_EmploymentAndEmployer.Text = newEmployment.lbl_EmploymentAndEmployer.Text + " at " + item.txt_Employer.Text;
                        if (item.txt_City.Text != "")
                        {
                            newEmployment.lbl_EmploymentAndEmployer.Text = newEmployment.lbl_EmploymentAndEmployer.Text + ", " + item.txt_City.Text;
                        }
                    }
                    else if (item.txt_City.Text != "")
                    {
                        newEmployment.lbl_EmploymentAndEmployer.Text = newEmployment.lbl_EmploymentAndEmployer.Text + " at " + item.txt_City.Text;
                    }
                }

                if (item.txt_StartDate.Text != "")
                {
                    newEmployment.lbl_StartandEndDate.Text += item.txt_StartDate.Text;
                    if (item.txt_EndDate.Text != "")
                    {
                        newEmployment.lbl_StartandEndDate.Text = newEmployment.lbl_StartandEndDate.Text + "-" + item.txt_EndDate.Text;
                    }
                }
                else if (item.txt_EndDate.Text != "")
                {
                    newEmployment.lbl_StartandEndDate.Text += item.txt_EndDate.Text;
                }


                char[] delims = new[] { '\r', '\n' };
                string[] DescriptionList = item.txt_Description.Text.Split(delims, StringSplitOptions.RemoveEmptyEntries);

                string temp = "";

                foreach (string Descrip in DescriptionList)
                {
                    temp += "\t\u2022 " + Descrip + "\n";
                    if (Descrip.Length >= 80)
                    {
                        newEmployment.lbl_Description.Height += 10;
                    }
                    else if (Descrip.Length >= 40)
                    {
                        newEmployment.lbl_Description.Height += 5;
                    }

                }
                newEmployment.lbl_Description.Height = newEmployment.lbl_Description.Height + 5 * DescriptionList.Length;
                newEmployment.lbl_Description.Text = temp;
                newEmployment.Size = newEmployment.panel_Body.Size;

                Flpnl_EmploymentHistory.Controls.Add(newEmployment);
            }


            Flpnl_Education.Controls.Clear();
            foreach (Attr_Education item in Flpnl_Education_Body.Controls)
            {
                Stockholm_Education newEducation = new Stockholm_Education();
                newEducation.lbl_DegreeAndSchool.Text = "";
                newEducation.lbl_StartandEndDate.Text = "";
                newEducation.lbl_Description.Text = "";

                if (item.txt_Degree.Text != "")
                {
                    newEducation.lbl_DegreeAndSchool.Text += item.txt_Degree.Text;
                    if (item.txt_School.Text != "")
                    {
                        newEducation.lbl_DegreeAndSchool.Text = newEducation.lbl_DegreeAndSchool.Text + ", " + item.txt_School.Text;
                        if (item.txt_City.Text != "")
                        {
                            newEducation.lbl_DegreeAndSchool.Text = newEducation.lbl_DegreeAndSchool.Text + ", " + item.txt_City.Text;
                        }
                    }
                    else if (item.txt_City.Text != "")
                    {
                        newEducation.lbl_DegreeAndSchool.Text = newEducation.lbl_DegreeAndSchool.Text + ", " + item.txt_City.Text;
                    }
                }

                if (item.txt_StartDate.Text != "")
                {
                    newEducation.lbl_StartandEndDate.Text += item.txt_StartDate.Text;
                    if (item.txt_EndDate.Text != "")
                    {
                        newEducation.lbl_StartandEndDate.Text = newEducation.lbl_StartandEndDate.Text + "-" + item.txt_EndDate.Text;
                    }
                }
                else if (item.txt_EndDate.Text != "")
                {
                    newEducation.lbl_StartandEndDate.Text += item.txt_EndDate.Text;
                }


                //string[] DescriptionList = item.txt_Description.Text.Split('\n');
                char[] delims = new[] { '\r', '\n' };
                string[] DescriptionList = item.txt_Description.Text.Split(delims, StringSplitOptions.RemoveEmptyEntries);

                string temp = "";

                foreach (string Descrip in DescriptionList)
                {
                    temp += "\t\u2022 " + Descrip + "\n";
                    if (Descrip.Length > 80)
                    {
                        newEducation.lbl_Description.Height += 10;
                    }
                    else if (Descrip.Length > 40)
                    {
                        newEducation.lbl_Description.Height += 5;
                    }

                }
                newEducation.lbl_Description.Height = newEducation.lbl_Description.Height + 5 * DescriptionList.Length;
                newEducation.lbl_Description.Text = temp;
                newEducation.Size = newEducation.panel_Body.Size;

                Flpnl_Education.Controls.Add(newEducation);
            }


            //Manage Skill
            Flpnl_Skills.Controls.Clear();
            foreach (Attr_Skill skill in Flpnl_Skill_Body.Controls)
            {
                Stockholm_Skill newSkill = new Stockholm_Skill();
                newSkill.lbl_Skill.Text = skill.txt_Skill.Text;
                if (newSkill.lbl_Skill.Text != "")
                {
                    Flpnl_Skills.Controls.Add(newSkill);
                }
            }

        }

        private void btn_Add_Employment_Click(object sender, EventArgs e)
        {
            Attr_Employment newEmployment = new Attr_Employment();
            Flpnl_Employment_Body.Controls.Add(newEmployment);
        }

        private void btn_Add_Education_Click(object sender, EventArgs e)
        {
            Attr_Education newEducation = new Attr_Education();
            Flpnl_Education_Body.Controls.Add(newEducation);
        }

        private void btn_Add_Skill_Click(object sender, EventArgs e)
        {
            Attr_Skill newSkill = new Attr_Skill();
            Flpnl_Skill_Body.Controls.Add(newSkill);
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            CheckedSkill(checkBox15);
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            CheckedSkill(checkBox14);
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            CheckedSkill(checkBox13);
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            CheckedSkill(checkBox12);
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            CheckedSkill(checkBox11);
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            CheckedSkill(checkBox10);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            CheckedSkill(checkBox6);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            CheckedSkill(checkBox8);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            CheckedSkill(checkBox5);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            CheckedSkill(checkBox9);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            CheckedSkill(checkBox7);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckedSkill(checkBox1);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckedSkill(checkBox3);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckedSkill(checkBox4);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckedSkill(checkBox2);
        }

        private void btn_UploadPhoto_Click(object sender, EventArgs e)
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
                    ptr_Photo.Image = Image.FromFile(imgpath);
                }
            }
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            using (DownloadCV newform = new DownloadCV())
            {
                if (newform.ShowDialog() == DialogResult.OK)
                {
                    if (newform.format == "PNG")
                    {
                        try
                        {
                            using (var bmp = new Bitmap(pnl_CV.Width, pnl_CV.Height))
                            {
                                pnl_CV.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                                bmp.Save(@"C:\Users\vietn\OneDrive\Máy tính\YourResume.png");
                            }
                            MessageBox.Show("CV saved successfully.");
                        }
                        catch
                        {
                            MessageBox.Show("Error.....");
                        }
                    }
                    else if (newform.format == "JPG")
                    {
                        try
                        {
                            using (var bmp = new Bitmap(pnl_CV.Width, pnl_CV.Height))
                            {
                                pnl_CV.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                                bmp.Save(@"C:\Users\vietn\OneDrive\Máy tính\YourResume.jpg");
                            }
                            MessageBox.Show("CV saved successfully.");
                        }
                        catch
                        {
                            MessageBox.Show("Error.....");
                        }
                    }
                    else
                    {
                        try
                        {
                            using (var bmp = new Bitmap(pnl_CV.Width, pnl_CV.Height))
                            {
                                Print(pnl_CV);
                            }
                            MessageBox.Show("CV saved successfully.");
                        }
                        catch
                        {
                            MessageBox.Show("Error.....");
                        }
                    }
                }
            }
        }
    }
}
