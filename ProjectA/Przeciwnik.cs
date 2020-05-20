using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA
{
   
    class Przeciwnik // deklaracja przeciwnika i jego własności
    {
        private int wysokość,szerokość;
        private int kolumny,wiersze;
        private int x,y,space;

        public Przeciwnik()
         {
            wysokość =40; 
            szerokość=40; 
            kolumny=10; 
            wiersze=5; 
            space=10; 
            x=150; 
            y=0;
        }
        public void StworzPrzeciwnik(Form p)
            {
            PictureBox pb = new PictureBox();
            pb.Location = new Point(x,y);
            pb.Size = new Size(szerokość,wysokość);
            pb.BackgroundImage = Properties.Resources.wrog2;
            pb.BackgroundImageLayout = ImageLayout.Stretch;
            pb.Name = "Obcy";
            p.Controls.Add(pb);
            }
        public void StworzSiatke(Form p) // tworzenie siatki przeciwnikow
            {
        for(int i=0; i<wiersze;i++)
            {
            for(int j=0;j<kolumny;j++)
              {
                StworzPrzeciwnik(p);
                x+= szerokość + space;
              }
            y+= wysokość + space;
                x=150;
            }
        }
    }
}
