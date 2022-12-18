using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Inżynierski
{

    class usunOdosobnione
    {
        int x, y;
        Bitmap zmieniona;
        public usunOdosobnione(int x, int y)
        {
            this.x = x;
            this.y = y;

        }
        public Bitmap Metoda(Bitmap btmp)
        {
            zmieniona = (Bitmap)btmp.Clone();
            Color colors;
            Color a11, a12, a13, a21, a22, a23, a31, a32, a33;
            for (int i = 1; i < this.x - 1; i++)
            {

                for (int j = 1; j < this.y - 1; j++)
                {

                    a11 = ((Bitmap)btmp).GetPixel(i - 1, j - 1);
                    a12 = ((Bitmap)btmp).GetPixel(i - 1, j);
                    a13 = ((Bitmap)btmp).GetPixel(i - 1, j + 1);
                    a21 = ((Bitmap)btmp).GetPixel(i, j - 1);
                    a22 = ((Bitmap)btmp).GetPixel(i, j);
                    a23 = ((Bitmap)btmp).GetPixel(i, j + 1);
                    a31 = ((Bitmap)btmp).GetPixel(i + 1, j - 1);
                    a32 = ((Bitmap)btmp).GetPixel(i + 1, j);
                    a33 = ((Bitmap)btmp).GetPixel(i + 1, j + 1);

                    if ((a22.R == 255) && (a12.R == 0) && (a13.R == 0) &&
                        (a21.R == 0) && (a11.R == 0) && (a23.R == 0) &&
                        (a31.R == 0) && (a32.R == 0) && (a33.R == 0))
                    {

                        colors = Color.Black;
                        zmieniona.SetPixel(i, j, colors);
                    }
                }
            }
            return zmieniona;
        }
    }
}
