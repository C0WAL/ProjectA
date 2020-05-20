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
        List<PictureBox> przeciwnik = new List<PictureBox>();
        List<PictureBox> zniszcz = new List<PictureBox>();
        const int x = 360;
        const int y = 650;
        const int limit = 730;

        int predkosc = -1;
        int lewo = -1;
        int gora = 0;
        int cts = 0;
        int pts = 0; /// punkty

        bool gra = true;
        bool ruszLewo;
        bool ruszPrawo;
        bool Strzal;

        private void Pressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                ruszLewo = true;
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                ruszPrawo = true;
            }
            else if (e.KeyCode == Keys.Space && gra && !Strzal)
            {
                Missle();
                Strzal = true;
            }
        }

        private void NoPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                ruszLewo = false;
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                ruszPrawo = false;
            }
<<<<<<< HEAD
            else if (e.KeyCode = Keys.Space)
=======
            else if(e.KeyCode == Keys.Space)
>>>>>>> bce29c22bbee754cf14d9127decae246adddecac
            {
                Strzal = false;
            }


        }

        private void Missle()
        {
            PictureBox bullet = new PictureBox();
            bullet.Location = new Point(Gracz.Location.X + Gracz.Width / 2, Gracz.Location.Y - 20);
            bullet.Size = new Size(5, 20);
            bullet.BackgroundImage = Properties.Resources.bullet;
            bullet.BackgroundImageLayout = ImageLayout.Stretch;
            bullet.Name = "bullet";
            this.Controls.Add(bullet);

        }

<<<<<<< HEAD
        private void GraczRuch(object sender, EventArgs e)
        {
            if (ruszLewo && Gracz.Location.X >= 0)
            {
                Gracz.Left--;
            }


            else if (ruszPrawo && Gracz.Location.X <= limit)
            {
                Gracz.Left++;
            }
        }

        private void SprawdzWygrana()
        {
            int licznik = 0;
            foreach(Control c in this.Controls)
            {
                if (c is PictureBox && c.Name = "Wrog") licznik++;
            }

            if (licznik == 0) Wygrales();

        }

        private void Wygrales()
        {
            gra = false;

            foreach(Control c in this.Controls)
            {
                if(c is Label && c.Name ="Koniec")
                {
                    Label lbl = (Label)c;
                    lbl.Text = "Wygrales !" + "\n"
                        + "Wynik: " + pts.ToString();
                }
                else
                {
                    c.Visible = false;
                }
            }

        }

        private void Przegrales()
        {
            timer1.Stop(); timer2.Stop(); timer3.Stop(); timer4.Stop(); timer5.Stop(); Observer.Stop();

            foreach(Control c in this.Controls)
            {
                if(c is Label && c.Name == "Finish")
                {
                    Label lbl = (Label)c;
                    lbl.Text = "Przegrales! ";
                    gra = false;
                }
                else
                {
                    c.Visible = false;
                }
            }
        }

           
=======
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.Observer = new System.Windows.Forms.Timer(this.components);
            this.Gracz = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Zycie1 = new System.Windows.Forms.PictureBox();
            this.Zycie2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Gracz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zycie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zycie2)).BeginInit();
            this.SuspendLayout();
            // 
            // Gracz
            // 
            this.Gracz.Location = new System.Drawing.Point(291, 326);
            this.Gracz.Name = "Gracz";
            this.Gracz.Size = new System.Drawing.Size(40, 37);
            this.Gracz.TabIndex = 0;
            this.Gracz.TabStop = false;
            this.Gracz.Click += new System.EventHandler(this.Gracz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // pictureBox1
            // 
            this.Zycie1.Location = new System.Drawing.Point(106, 355);
            this.Zycie1.Name = "pictureBox1";
            this.Zycie1.Size = new System.Drawing.Size(53, 44);
            this.Zycie1.TabIndex = 3;
            this.Zycie1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.Zycie2.Location = new System.Drawing.Point(171, 354);
            this.Zycie2.Name = "pictureBox2";
            this.Zycie2.Size = new System.Drawing.Size(55, 44);
            this.Zycie2.TabIndex = 4;
            this.Zycie2.TabStop = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(637, 415);
            this.Controls.Add(this.Zycie2);
            this.Controls.Add(this.Zycie1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gracz);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Gracz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zycie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zycie2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Gracz_Click(object sender, EventArgs e)
        {

        }
>>>>>>> bce29c22bbee754cf14d9127decae246adddecac
    }
}
