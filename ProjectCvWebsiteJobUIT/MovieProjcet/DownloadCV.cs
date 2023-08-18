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
    public partial class DownloadCV : Form
    {
        public DownloadCV()
        {
            InitializeComponent();
        }
        public string format = "PNG";
        private void btn_PNG_Click(object sender, EventArgs e)
        {
            format = "PNG";
            btn_Download.Text = "Download in PNG";
            btn_PNG.BackColor = Color.FromArgb(26, 145, 240);
            btn_PNG.ForeColor = Color.White;
            btn_JPG.BackColor = Color.White;
            btn_JPG.ForeColor = Color.Black;
        }

        private void btn_JPG_Click(object sender, EventArgs e)
        {
            format = "JPG";
            btn_Download.Text = "Download in JPG";
            btn_JPG.BackColor = Color.FromArgb(26, 145, 240);
            btn_JPG.ForeColor = Color.White;
            btn_PNG.BackColor = Color.White;
            btn_PNG.ForeColor = Color.Black;
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_PDF_Click(object sender, EventArgs e)
        {
            format = "PDF";
            btn_Download.Text = "Download in PDF";
            btn_PDF.BackColor = Color.FromArgb(26, 145, 240);
            btn_PDF.ForeColor = Color.White;
            btn_PNG.BackColor = Color.White;
            btn_PNG.ForeColor = Color.Black;
            btn_JPG.BackColor = Color.White;
            btn_JPG.ForeColor = Color.Black;
        }
    }
}
