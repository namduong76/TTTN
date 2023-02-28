using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Clearing_Prices_2
{
    class Program
    {
        static void nguoibanyeuthich(int[] x, int a, int b, int c)
        {
            if (x[0] - a < x[1] - b && x[2] - c < x[1] - b)
            {
                Console.WriteLine("b la nguoi ban yeu thich cua nguoi mua");
                x[3] = b;
            }
            else if (x[1] - b < x[0] - a && x[2] - c < x[0] - a)
            {
                Console.WriteLine("a la nguoi ban yeu thich cua nguoi mua");
                x[3] = a;
            }
            else if (x[0] - a < x[2] - c && x[1] - b < x[2] - c)
            {
                Console.WriteLine("c la nguoi ban yeu thich cua nguoi mua");
                x[3] = c;
            }
            else
            {
                Console.WriteLine("Khong xac dinh nguoi ban yeu thich");
            }
        }

        static void Main(string[] args)
        {
            int a, b, c;
            int[] x = { 5, 7, 1, 0 };
            int[] y = { 2, 3, 1, 0 };
            int[] z = { 5, 4, 4, 0 };

            Console.Write("Nhap gia tri cua a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia tri cua b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia tri cua c: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Nguoi ban yeu thich cua nguoi mua x:");
            nguoibanyeuthich(x, a, b, c);
            Console.WriteLine();

            Console.WriteLine("Nguoi ban yeu thich cua nguoi mua y:");
            nguoibanyeuthich(y, a, b, c);
            Console.WriteLine();

            Console.WriteLine("Nguoi ban yeu thich cua nguoi mua z:");
            nguoibanyeuthich(z, a, b, c);
            Console.WriteLine();

            /*if(x[3]<0||y[3]<0||z[3]<0)
                Console.WriteLine("Bo gia tren khong phai la bo gia bu tru thi truong");*/

            if (x[3] != y[3] && x[3] != z[3] && y[3] != z[3])
                Console.WriteLine("Bo gia tren la bo gia bu tru thi truong");
            else
                Console.WriteLine("Bo gia tren khong phai la bo gia bu tru thi truong");
        }
    }
}
