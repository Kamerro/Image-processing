using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Inżynierski
{
    class laplasjan : grayScaleFiltering
    {
        readonly int x;
        readonly int y;
        Bitmap btmpzmieniona;
        Color kolor1, kolor, col;
        public laplasjan(int xwidth, int yheight) : base(xwidth, yheight)
        {
            this.x = xwidth;
            this.y = yheight;
        }
        public Bitmap FLaplasjanowy(Bitmap btmp)
        {
            int averrage;
            grayScaleFiltering Bitmapa = new grayScaleFiltering(this.x, this.y);
            btmp = Bitmapa.gsMetod(btmp);
            btmpzmieniona = (Bitmap)btmp.Clone();
            Color kolor1 = new Color();
            Color kolor2 = new Color();
            Color kolor3 = new Color();
            Color kolor4 = new Color();
            Color kolor5 = new Color();
            Color kolor6 = new Color();
            Color kolor7 = new Color();
            Color kolor8 = new Color();
            Color kolor9 = new Color();

            for (int i = 1; i < this.x - 1; i++)
            {

                for (int j = 1; j < this.y - 1; j++)
                {

                    kolor1 = btmp.GetPixel(i + 1, j + 1);
                    kolor2 = btmp.GetPixel(i - 1, j - 1);
                    kolor3 = btmp.GetPixel(i - 1, j);
                    kolor4 = btmp.GetPixel(i - 1, j + 1);
                    kolor5 = btmp.GetPixel(i, j - 1);
                    kolor6 = btmp.GetPixel(i, j);
                    kolor7 = btmp.GetPixel(i, j + 1);
                    kolor8 = btmp.GetPixel(i + 1, j - 1);
                    kolor9 = btmp.GetPixel(i + 1, j);
                    averrage = (kolor1.R + kolor2.R + kolor3.R + kolor4.R + kolor5.R + kolor7.R + kolor8.R + kolor9.R) - kolor6.R * 8;
                    if (averrage > 30)
                    {

                        averrage = 255;
                    }
                    else
                    {

                        averrage = 0;
                    }

                    col = Color.FromArgb(averrage, averrage, averrage);
                    btmpzmieniona.SetPixel(i, j, col);
                }
            }
            return btmpzmieniona;
        }
    }
}
