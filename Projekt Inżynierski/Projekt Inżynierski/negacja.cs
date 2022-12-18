using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Inżynierski
{
    class negacja : grayScaleFiltering
    {
        int x;
        int y;
        int min, max, wartoscsrodkowa;
        double nowa;
        Bitmap btmpzmieniona;
        Color kolor1, col;

        public negacja(int xwidth, int yheight) : base(xwidth, yheight)
        {

            this.x = xwidth;
            this.y = yheight;
            min = 255;
            max = 0;

        }
        public Bitmap Fnegacja(Bitmap btmp)
        {

            grayScaleFiltering Bitmapa = new grayScaleFiltering(this.x, this.y);
            btmp = Bitmapa.gsMetod(btmp);
            btmpzmieniona = (Bitmap)btmp.Clone();

            for (int i = 0; i < this.x; i++)
            {
                for (int j = 0; j < this.y; j++)
                {

                    col = btmp.GetPixel(i, j);
                    nowa = (255 - col.R);
                    col = Color.FromArgb((int)nowa, (int)nowa, (int)nowa);
                    btmpzmieniona.SetPixel(i, j, col);
                }
            }
            return btmpzmieniona;
        }
    }
}
