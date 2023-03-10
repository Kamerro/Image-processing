using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Inżynierski
{
    class potegowy : grayScaleFiltering
    {

        int x;
        int y;
        double averrage, r;
        Bitmap btmpzmieniona;
        Color kolor1, col;

        public potegowy(int xwidth, int yheight, double r) : base(xwidth, yheight)
        {

            this.x = xwidth;
            this.y = yheight;
            this.r = r;
        }
        public Bitmap Fpotegowy(Bitmap btmp)
        {
            r = r / 10.0;
            grayScaleFiltering Bitmapa = new grayScaleFiltering(this.x, this.y);
            btmp = Bitmapa.gsMetod(btmp);
            btmpzmieniona = (Bitmap)btmp.Clone();

            for (int i = 0; i < this.x; i++)
            {

                for (int j = 0; j < this.y; j++)
                {

                    kolor1 = btmp.GetPixel(i, j);
                    averrage = (255 / Math.Pow(255, r) * Math.Pow(kolor1.R, r));
                    col = Color.FromArgb((int)averrage, (int)averrage, (int)averrage);
                    btmpzmieniona.SetPixel(i, j, col);
                }
            }
            return btmpzmieniona;
        }

    }
}
