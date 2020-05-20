using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            


        }
        List<PictureBox> wrog = new List<PictureBox>();
        List<PictureBox> zniszcz = new List<PictureBox>();
        const int x = 360;
        const int y = 650;
        const int limit = 730;

        int predkosc = -1;
        int lewo = -1;
        int gora = 0;
        int cts = 0;
        int pts = 0;

        bool gra = true;
        bool ruszLewo;
        bool ruszPrawo;
        bool Strzal;

        private void Pressed(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                ruszLewo = true;
            }
            else if(e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                ruszPrawo = true; 
            }
            else if(e.KeyCode == Keys.Space && gra && !Strzal)
            {
                Missle();
                Strzal = true;
            }
        }

        private void NoPressed(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                ruszLewo = false;
            }
            else if(e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                ruszPrawo = false;
            }
            else if(e.KeyCode = Keys.Space)
            {
                Strzal = false;
            }


        }

        private void Missle()
        {
            PictureBox bullet = new PictureBox();
            bullet.Location = new Point(Gracz.Location.X + Gracz.Width / 2, Gracz.Location.Y - 20)
            bullet.Size = new Size(5, 20);
            bullet.BackgroundImage = Properties.Resources.bullet;
            bullet.BackgroundImageLayout = ImageLayout.Stretch;
            bullet.Name = "bullet";
            this.Controls.Add(bullet);

        }
    }
}
