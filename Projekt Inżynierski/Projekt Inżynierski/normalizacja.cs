using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Inżynierski
{
    class normalizacja : grayScaleFiltering
    {

        int x;
        int y;
        int min, max, wartoscsrodkowa;
        double nowa;
        Bitmap btmpzmieniona;
        Color kolor1, col;

        public normalizacja(int xwidth, int yheight) : base(xwidth, yheight)
        {

            this.x = xwidth;
            this.y = yheight;
            min = 255;
            max = 0;

        }
        public Bitmap SprawdzenieOdcieni(Bitmap btmp)
        {

            grayScaleFiltering Bitmapa = new grayScaleFiltering(this.x, this.y);
            btmp = Bitmapa.gsMetod(btmp);
            btmpzmieniona = (Bitmap)btmp.Clone();

            for (int i = 0; i < this.x; i++)
            {
                for (int j = 0; j < this.y; j++)
                {

                    col = btmp.GetPixel(i, j);

                    if (col.R > max)
                    {

                        max = col.R;
                    }
                    if (col.R < min)
                    {

                        min = col.R;
                    }
                }
            }
            wartoscsrodkowa = max - min;

            for (int i = 0; i < this.x; i++)
            {
                for (int j = 0; j < this.y; j++)
                {

                    col = btmp.GetPixel(i, j);
                    nowa = (col.R - min);
                    nowa = (double)(nowa / wartoscsrodkowa);
                    nowa = nowa * 255;
                    col = Color.FromArgb((int)nowa, (int)nowa, (int)nowa);
                    btmpzmieniona.SetPixel(i, j, col);
                }
            }
            return btmpzmieniona;
        }
    }
}
