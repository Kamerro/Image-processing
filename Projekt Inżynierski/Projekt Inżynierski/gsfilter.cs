using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Inżynierski
{

        class grayScaleFiltering
        {
            int x, y;
            public grayScaleFiltering(int xwidth, int yheight)
            {
                this.x = xwidth;
                this.y = yheight;
            }
            public Bitmap gsMetod(Bitmap btmp)
            {
                Color kolor1, colors;
                int averrage;
                Bitmap Editedbtmp = (Bitmap)btmp.Clone();

                for (int i = 0; i < this.x; i++)
                {
                    for (int j = 0; j < this.y; j++)
                    {

                        kolor1 = btmp.GetPixel(i, j);
                        averrage = (kolor1.R + kolor1.G + kolor1.B) / 3;
                        colors = Color.FromArgb(averrage, averrage, averrage);
                        Editedbtmp.SetPixel(i, j, colors);
                    }
                }
                return Editedbtmp;

            }
        }
}
