using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Clearing_Prices_11
{
    class Program
    {
        //Nguoi ban a, b, c
        //Nguoi mua x, y, z
        static void Main(string[] args)
        {
            int a = 2, b = 3, c = 6;

            Console.Write("Nhap gia tri cua x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia tri cua y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia tri cua z: ");
            int z = int.Parse(Console.ReadLine());

            //Khoang cach giua mot nguoi den cho dau xe
            Console.WriteLine("Khoang cach tu x den a la: " + (a - x));
            Console.WriteLine("Khoang cach tu y den a la: " + (a - y));
            Console.WriteLine("Khoang cach tu z den a la: " + (a - z));
            Console.WriteLine("Khoang cach tu x den b la: " + (b - x));
            Console.WriteLine("Khoang cach tu y den b la: " + (b - x));
            Console.WriteLine("Khoang cach tu z den b la: " + (b - x));
            Console.WriteLine("Khoang cach tu x den c la: " + (c - x));
            Console.WriteLine("Khoang cach tu y den c la: " + (c - x));
            Console.WriteLine("Khoang cach tu z den c la: " + (c - x));

            //Muc dinh gia cua mot nguoi cho mot cho dau xe
            Console.WriteLine("Muc dinh gia cua x cho a la: " + (8 - a + x));
            Console.WriteLine("Muc dinh gia cua y cho a la: " + (8 - a + y));
            Console.WriteLine("Muc dinh gia cua z cho a la: " + (8 - a + z));
            Console.WriteLine("Muc dinh gia cua x cho b la: " + (8 - b + x));
            Console.WriteLine("Muc dinh gia cua y cho b la: " + (8 - b + y));
            Console.WriteLine("Muc dinh gia cua z cho b la: " + (8 - b + z));
            Console.WriteLine("Muc dinh gia cua x cho c la: " + (8 - c + x));
            Console.WriteLine("Muc dinh gia cua y cho c la: " + (8 - c + y));
            Console.WriteLine("Muc dinh gia cua z cho c la: " + (8 - c + z));
        }
    }
}
