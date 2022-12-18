using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Inżynierski
{
    class krawedziowy : grayScaleFiltering
    {

        int x;
        int y;
        int averrage;
        Bitmap btmpzmieniona;
        Color kolor1, kolor2, kolor;

        public krawedziowy(int xwidth, int yheight) : base(xwidth, yheight)
        {

            this.x = xwidth;
            this.y = yheight;
        }
        public Bitmap Fkrawedziowy(Bitmap btmp)
        {

            grayScaleFiltering Bitmapa = new grayScaleFiltering(this.x, this.y);
            btmp = Bitmapa.gsMetod(btmp);
            btmpzmieniona = (Bitmap)btmp.Clone();
            for (int i = 1; i < this.x - 1; i++)
            {

                for (int j = 1; j < this.y - 1; j++)
                {

                    kolor1 = ((Bitmap)btmp).GetPixel(i, j);
                    kolor2 = ((Bitmap)btmp).GetPixel(i + 1, j);
                    averrage = kolor1.R - kolor2.R;
                    if (averrage < 0)
                    {
                        averrage = 0;
                    }

                    kolor = Color.FromArgb(averrage, averrage, averrage);
                    // }
                    // else{

                    //kolor = Color.Black;
                    //  }
                    ((Bitmap)btmpzmieniona).SetPixel(i, j, kolor);
                }
            }
            return btmpzmieniona;
        }
    }
}
