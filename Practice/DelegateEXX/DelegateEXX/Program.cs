using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEXX
{
    delegate int TDel(int a);
    delegate int GT(int a, int b);
    delegate int CDel(int a);
    delegate bool BDel(int a);
    delegate int ADel(int a, int b);
    delegate int G(int a, int b, int c);
    internal class Program
    {
        static void Main(string[] args)
        {
            TDel td = delegate (int n)
            {
                return n * n;
            };
            int r = td(10);
            Console.WriteLine("Value of r is:" + r);

            GT g = delegate (int a, int b)
            {
                return a * b;
            };
            r = g(10, 20);
            Console.WriteLine("Greater is:" + r);

            CDel cd = delegate (int a)
            {
                return a * a * a;
            };
            r = cd(10);
            Console.WriteLine("Cube is:" + r);

            BDel bd = delegate (int a)
            {
               return  a % 2 == 0;
            };
            bool res = bd(10);
            Console.WriteLine("Result is:"+ res);

            ADel ad = delegate (int a, int b)
            {
                return a > b ? a : b;
            };
            r = ad(10, 20);
            Console.WriteLine("Greater is:" + r);

            G gdl = delegate (int a, int b, int c)
            {
                return a > b ? (a > c ? a : c) : (b > c ? b : c);
            };
            r = gdl(10, 20, 30);
            Console.WriteLine("Greater is:" + r);
        }
    }
}
