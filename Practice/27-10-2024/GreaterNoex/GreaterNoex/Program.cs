using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNoex
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
            c = Convert.ToInt32(Console.ReadLine());

            if(a>b)
            {
                if(a>c)
                {
                    Console.WriteLine("A is greater number:"+ a);
                }
                else
                {   //C>B>A
                    Console.WriteLine("C is greater number:"+ c);
                }
            }
            else
            {   //B>A
                if(b>a)
                {
                    Console.WriteLine("B is greater number:" + b);
                }
                else
                {   //A<B<C
                    Console.WriteLine("C is greter number:" + c);
                }
            }
        }   
    }
}
