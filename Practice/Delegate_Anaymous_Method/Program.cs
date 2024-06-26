using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Anaymous_Method
{
    internal class Program
    {
        delegate int CDel(int a);
        delegate int GDel(int m, int n, int o);
        delegate int ADel(int b, int d);
        delegate void DDel(int e);
        static void Main(string[] args)
        {
            CDel c = delegate (int n)
            {
                return n * n * n;
            };
            int w = c(2);
            Console.WriteLine("Cube is:" + w);

            GDel g = delegate (int m, int n, int o)
            {
                if (m > n)
                    if (m > o)
                        return m;
                    else
                        return o;
                else
                    if (n > o)
                    return n;
                else
                    return o;
            };
            int x = g(10, 52, 96);
            Console.WriteLine("Greater Number is:" + x);

            ADel a = delegate (int b, int f)
            {
                return b + f;
            };
            int y = a(5, 5);
            Console.WriteLine("Addition is:" + y);

            DDel d = delegate (int e)
            {
                if (e % 2 == 0)
                {
                    Console.WriteLine("Number is Even");
                }
                else
                {
                    Console.WriteLine("Number is Odd");
                }
            };
            d(29);

        }
    }
}
