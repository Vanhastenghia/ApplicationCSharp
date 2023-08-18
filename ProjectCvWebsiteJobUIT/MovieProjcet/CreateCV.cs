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
    public partial class CreateCV : Form
    {
        public CreateCV()
        {
            InitializeComponent();
        }

        public static Form currentChildForm;

        public static Form lastForm;

        public static string currentForm;

        public static string UserName;
        public void Quit(Form childForm)
        {
            UserPage newform = (UserPage)this.Parent.Parent;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            newform.pnlBody.Controls.Add(childForm);
            newform.pnlBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btn_Generate_Click(object sender, EventArgs e)
        {
            Toronto_CV f = new Toronto_CV();
            Quit(new OpenTempPlate() { 
            GetForm = f});
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Dublin_CV f = new Dublin_CV();
            Quit(new OpenTempPlate()
            {
                GetForm = f
            });
        }

        private void pnl_Header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            Stockholm_CV f = new Stockholm_CV();
            Quit(new OpenTempPlate()
            {
                GetForm = f
            });
        }
    }
}
