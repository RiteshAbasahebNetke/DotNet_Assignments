using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNoEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Enter No:");
            a=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter No:");
            b=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter No:");
            c=Convert.ToInt32(Console.ReadLine());

            if(a>b)
            {
                if(a>c)
                {
                    Console.WriteLine("Greater is:"+ a);
                }
                else
                {
                    Console.WriteLine("Greater is:"+ c);
                }
            }
            else
            {
                if(b>c)
                {
                    Console.WriteLine("Greater is:"+ b);
                }
                else
                {
                    Console.WriteLine("Greater is:"+ c);
                }
            }
        }
    }
}
