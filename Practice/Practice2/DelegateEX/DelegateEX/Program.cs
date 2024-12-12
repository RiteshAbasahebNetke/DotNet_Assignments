using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEX
{
    delegate int TDel(int a);
    delegate int GT(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            TDel td = delegate (int n)
            {
                return n * n;
            };
            int r = td(10);
            Console.WriteLine("Square is:" + r);
            Console.WriteLine();

            GT g = delegate (int a, int b)
            {
                if (a > b)
                    return a;
                else
                    return b;
            };
            r = g(10, 20);
            Console.WriteLine("Greater is:" + r);
        }
    }
}
