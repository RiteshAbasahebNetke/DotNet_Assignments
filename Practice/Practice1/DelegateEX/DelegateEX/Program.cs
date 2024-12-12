using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEX
{
    delegate int SDel(int a);
    delegate int GDel(int a, int b);
    delegate int CDel(int a);
    delegate int ADel(int a, int b);

    internal class Program
    {
        static void Main(string[] args)
        {
            SDel sd = delegate (int n)
            {
                return n * n;
            };
            int r = sd(10);
            Console.WriteLine("Value of r is:"+ r);

            GDel gd = delegate (int n, int m)
            {
                if (n > m)
                    return n;
                else
                    return m;
            };
            int s = gd(5, 10);
            Console.WriteLine("Greater No. is:" + s);

            CDel cu = (a) => a * a * a;
            int t = cu(5);
            Console.WriteLine("Cube is:" + t);

            ADel ad = (a, b) => a > b ? a : b;
            int u = ad(20, 30);
            Console.WriteLine("Greater no. is:"+ u);
        }
    }
}
