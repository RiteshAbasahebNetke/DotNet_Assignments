using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx
{
    delegate int TDel(int a);
    delegate int Gt(int a, int b);


    internal class Program
    {
        static void Main(string[] args)
        {
            TDel td = delegate (int n)
            {
                return n*n;
            };
            int r = td(10);
            Console.WriteLine("Square is:"+ r);

            Gt g = delegate (int a, int b)
            {
                if (a > b)
                    return a;
                else
                    return b;
            };
            r = g(10, 122);
            Console.WriteLine("Greater Number is:" + r);
        }
    }
}
