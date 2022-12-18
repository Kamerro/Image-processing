using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Inżynierski
{

    class Histogram
    {
        public int[] tabR = new int[256];
        public int[] tabG = new int[256];
        public int[] tabB = new int[256];
        public void zerowanieTablic()
        {
            for (int i = 0; i < tabR.Length; i++)
            {
                tabR[i] = 0;
                tabG[i] = 0;
                tabB[i] = 0;
            }
        }
    }
}
