using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Clearing_Prices_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int[] x = { 2, 4, 0 };
            int[] y = { 3, 6, 0 };

            Console.Write("Nhap gia tri cua a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia tri cua b: ");
            b = int.Parse(Console.ReadLine());

            if (x[0] - a < x[1] - b)
            {
                Console.WriteLine("b la nguoi ban yeu thich cua x");
                x[2] = b;
            }
            else
            {
                Console.WriteLine("a la nguoi ban yeu thich cua x");
                x[2] = a;
            }

            if (y[0] - a < y[1] - b)
            {
                Console.WriteLine("b la nguoi ban yeu thich cua y");
                y[2] = b;
            }
            else
            {
                Console.WriteLine("a la nguoi ban yeu thich cua y");
                y[2] = a;
            }

            if (x[2] == y[2])
                Console.WriteLine("Bo gia tren khong phai la bo gia bu tru thi truong");
            else
                Console.WriteLine("Bo gia tren la bo gia bu tru thi truong");
        }
    }
}
