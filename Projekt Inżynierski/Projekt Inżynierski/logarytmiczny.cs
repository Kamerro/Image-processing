using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Inżynierski
{
    class logarytmiczny : grayScaleFiltering
    {

        int x;
        int y;
        double averrage;
        Bitmap btmpzmieniona;
        Color kolor1, col;

        public logarytmiczny(int xwidth, int yheight) : base(xwidth, yheight)
        {

            this.x = xwidth;
            this.y = yheight;
        }
        public Bitmap Flogarytmiczny(Bitmap btmp)
        {

            grayScaleFiltering Bitmapa = new grayScaleFiltering(this.x, this.y);
            btmp = Bitmapa.gsMetod(btmp);
            btmpzmieniona = (Bitmap)btmp.Clone();

            for (int i = 0; i < this.x; i++)
            {

                for (int j = 0; j < this.y; j++)
                {

                    kolor1 = btmp.GetPixel(i, j);
                    averrage = (255 / (Math.Log10(256))) * Math.Log10(kolor1.R + 1);
                    col = Color.FromArgb((int)averrage, (int)averrage, (int)averrage);
                    btmpzmieniona.SetPixel(i, j, col);
                }
            }
            return btmpzmieniona;
        }
    }
}
