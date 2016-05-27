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
    public partial class frmGameOver : Form
    {
        public frmGameOver()
        {
            InitializeComponent();
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmGameOver_Load(object sender, EventArgs e)
        {
            if (frmGame.loseorwin == true)
            {
                lblSonuc.Text = "Jerry kazandı";
                lblSonuc.ForeColor = Color.Orange;
                this.BackgroundImage = Properties.Resources.win;
                lblPuan.Text = "Puan : " + frmGame.puan.ToString();
                lblSure.Text = frmGame.sure.ToString() + " Saniye";
            }
            else
            {
                lblSonuc.Text = "Tom kazandı";
                lblSonuc.ForeColor = Color.DarkGray;
                this.BackgroundImage = Properties.Resources.lose;
                lblPuan.Text = "Puan : " + frmGame.puan.ToString();
                lblSure.Text = frmGame.sure.ToString() + " Saniye";
            }
        }

        private void frmGameOver_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            { Application.Exit(); }
            if (e.KeyCode == Keys.Enter)
            { Application.Restart(); }
        }
    }
}
