using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Inżynierski
{
    public class filtrRozmywajacy
    {
        int x;
        int y;
        public filtrRozmywajacy(int xwidth, int yheight)
        {
            this.x = xwidth;
            this.y = yheight;
        }
        Color col;
        Bitmap btmpzwrot;
        Color kolor1 = new Color();
        Color kolor2 = new Color();
        Color kolor3 = new Color();
        Color kolor4 = new Color();
        Color kolor5 = new Color();
        Color kolor6 = new Color();
        Color kolor7 = new Color();
        Color kolor8 = new Color();
        Color kolor9 = new Color();
        int aver1;
        int aver2;
        int aver3;
        public Bitmap Metoda(Bitmap btmp)
        {
            btmpzwrot = (Bitmap)btmp.Clone();
            for (int j = 1; j < this.y - 1; j++)
            {

                for (int i = 1; i < this.x - 1; i++)

                {
                    kolor1 = ((Bitmap)btmp).GetPixel(i + 1, j + 1);
                    kolor2 = ((Bitmap)btmp).GetPixel(i - 1, j - 1);
                    kolor3 = ((Bitmap)btmp).GetPixel(i - 1, j);
                    kolor4 = ((Bitmap)btmp).GetPixel(i - 1, j + 1);
                    kolor5 = ((Bitmap)btmp).GetPixel(i, j - 1);
                    kolor6 = ((Bitmap)btmp).GetPixel(i, j);
                    kolor7 = ((Bitmap)btmp).GetPixel(i, j + 1);
                    kolor8 = ((Bitmap)btmp).GetPixel(i + 1, j - 1);
                    kolor9 = ((Bitmap)btmp).GetPixel(i + 1, j);

                    aver1 = (kolor1.R +
                               kolor2.R +
                               kolor3.R +
                               kolor4.R +
                               kolor5.R +
                               kolor6.R +
                               kolor7.R +
                               kolor8.R +
                               kolor9.R) / 9;

                    aver2 = (kolor1.G +
                               kolor2.G +
                               kolor3.G +
                               kolor4.G +
                               kolor5.G +
                               kolor6.G +
                               kolor7.G +
                               kolor8.G +
                               kolor9.G) / 9;

                    aver3 = (kolor1.B +
                               kolor2.B +
                               kolor3.B +
                               kolor4.B +
                               kolor5.B +
                               kolor6.B +
                               kolor7.B +
                               kolor8.B +
                               kolor9.B) / 9;

                    col = Color.FromArgb(aver1, aver2, aver3);
                    btmpzwrot.SetPixel(i, j, col);
                }
            }
            return btmpzwrot;
        }

    }
}
