using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Clearing_Prices_8
{
    class Program
    {
        static void PriceSet(int[] x, int[] y)
        {
            int a = 0, b = 0;

            if (x[0] - a < y[0] - a)
            {
                a++;
                y[2] = a;
            }
            else if (x[0] - a > y[0] - a)
            {
                a++;
                x[2] = a;
            }

            if (x[0] - a == x[1] - b)
            {
                x[2] = a;
                x[3] = b;
            }
        }

        static void Main(string[] args)
        {
            int a = 0, b = 0;
            int[] x = { 7, 5, 0, 0 };
            int[] y = { 4, 1, 0, 0 };

        }
    }
}
