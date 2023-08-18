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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static Form currentChildForm;
        public static Form lastForm;

        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(childForm);
            pnlBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Sing_in());
            pnlColorLogin.BackColor = Color.FromArgb(149, 115, 101);
            pnlColorRegister.BackColor = Color.FromArgb(45, 50, 80);
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Sing_in());
            pnlColorLogin.BackColor = Color.FromArgb(149, 115, 101);
            pnlColorRegister.BackColor = Color.FromArgb(45, 50, 80); 
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Sign_up());
            pnlColorLogin.BackColor =  Color.FromArgb(45, 50, 80);
            pnlColorRegister.BackColor = Color.FromArgb(149, 115, 101);
        }
    }
}
