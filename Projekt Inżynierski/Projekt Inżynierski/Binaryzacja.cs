using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Inżynierski
{
    class Binaryzacja
    {
        int x;
        int y;
        Bitmap btmpzmieniona;
        Color kolor1, col;

        public Binaryzacja(int xwidth, int yheight)
        {

            this.x = xwidth;
            this.y = yheight;
        }
        public Bitmap FBinaryzacja(Bitmap btmp)
        {
            btmpzmieniona = (Bitmap)btmp.Clone();

            for (int i = 0; i < this.x; i++)
            {

                for (int j = 0; j < this.y; j++)

                {
                    kolor1 = ((Bitmap)btmp).GetPixel(i, j);
                    if (kolor1.R > 130)
                    {
                        kolor1 = Color.FromArgb(255, 255, 255);
                    }
                    else
                        kolor1 = Color.Black;

                    ((Bitmap)btmpzmieniona).SetPixel(i, j, kolor1);

                }

            }
            return btmpzmieniona;
        }
    }
}
