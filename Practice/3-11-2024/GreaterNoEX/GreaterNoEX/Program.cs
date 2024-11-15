using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNoEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Enter value for A:");
            a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value for B:");
            b=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value for C:");
            c=Convert.ToInt32(Console.ReadLine());

            if(a>b)
            {
                if(a>c)
                {
                    Console.WriteLine("A is Greater");
                }
                else
                {   // b>a>c
                    Console.WriteLine("B is Greater");
                }
            }
            else
            {
                if(c>b)
                {
                    Console.WriteLine("C is Greater");
                }
                else
                {   // a<c<b
                    Console.WriteLine("B is Greater");
                }
            }
        }
    }
}
