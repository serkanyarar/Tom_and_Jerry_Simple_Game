using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tom_and_jerry
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEasy_MouseEnter(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void btnEasy_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void btnNormal_MouseEnter(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void btnNormal_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void btnHard_MouseEnter(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void btnHard_MouseLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            frmGame.difficulty = "easy";
            this.Visible = false;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            frmGame.difficulty = "normal";
            this.Visible = false;
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            frmGame.difficulty = "hard";
            this.Visible = false;
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            { Application.Exit(); }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
