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
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
        }
        frmGameOver gameover = new frmGameOver();
        frmMain main = new frmMain();
        public static int sure = 0;
        public static int puan = 0;
        public static bool loseorwin;
        public static string difficulty;
        public static int peynirSayisi = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            main.ShowDialog();
            OyunKur(difficulty);
        }
        private void btnOyuncu_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'w':
                    btnOyuncu.Top -= 10;
                    if (btnOyuncu.Top < 0) btnOyuncu.Top = 413;
                    break;
                case 'a':
                    btnOyuncu.Left -= 10;
                    if (btnOyuncu.Left < 0) btnOyuncu.Left = 432;
                    break;
                case 's':
                    btnOyuncu.Top += 10;
                    if (btnOyuncu.Top > 413) btnOyuncu.Top = 0;
                    break;
                case 'd':
                    btnOyuncu.Left += 10;
                    if (btnOyuncu.Left > 432) btnOyuncu.Left = 0;
                    break;
            }
        }
        private void timerSure_Tick(object sender, EventArgs e)
        {
            lblSure.Text = sure + " SN";
            sure++;
        }
        public void OyunBitti()
        {
            timerSure.Stop();
            timerTom.Stop();
            if (puan == peynirSayisi * 10) loseorwin = true;
            else loseorwin = false;
            gameover.Show();
            OyunKur(difficulty);
        }
        public void OyunKur(string zorluk)
        {
            Random rnd = new Random();
            if (difficulty == "easy")
            {
                peynirSayisi = 25;
                timerTom.Interval = 5000;
            }
            else if (difficulty == "normal")
            {
                peynirSayisi = 50;
                timerTom.Interval = 3000;
            }
            else if (difficulty == "hard")
            {
                peynirSayisi = 70;
                timerTom.Interval = 1000;
            }
            for (int i = 0; i < peynirSayisi; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(25, 20);
                btn.Location = new Point(rnd.Next(1, 450), rnd.Next(20, 450));
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackgroundImage = Properties.Resources.cheese;
                btn.Enabled = false;
                btn.Name = "btn" + (i + 1);
                this.Controls.Add(btn);
            }
            sure = 0;
            puan = 0;
            timerSure.Start();
            timerTom.Start();
        }
        private void timerTom_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            btnTom.Location = new Point(random.Next(413), random.Next(413));
        }
        private void btnOyuncu_LocationChanged(object sender, EventArgs e)
        {
            //------------------Tom yakaladımı kontrol-----------------
            if ((btnOyuncu.Right >= btnTom.Left && btnOyuncu.Bottom >= btnTom.Top && btnOyuncu.Top <= btnTom.Bottom && btnOyuncu.Left <= btnTom.Right))
            {
                OyunBitti();
            }

            //--------------------Peynirleri Toplama-------------------
            for (int i = 0; i < peynirSayisi; i++)
            {
                if ((
                        btnOyuncu.Right >= ((Button)this.Controls["btn" + (i + 1)]).Left &&
                        btnOyuncu.Bottom >= ((Button)this.Controls["btn" + (i + 1)]).Top &&
                        btnOyuncu.Top <= ((Button)this.Controls["btn" + (i + 1)]).Bottom &&
                        btnOyuncu.Left <= ((Button)this.Controls["btn" + (i + 1)]).Right) &&
                        ((Button)this.Controls["btn" + (i + 1)]).Visible == true)
                {
                    ((Button)this.Controls["btn" + (i + 1)]).Visible = false;
                    puan += 10;
                    lblPuan.Text = "Puan : " + puan;
                    if (puan == peynirSayisi * 10)
                    {
                        OyunBitti();
                    }
                }
            }
        }
        private void frmGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            { Application.Exit(); }
        }
    }
}
