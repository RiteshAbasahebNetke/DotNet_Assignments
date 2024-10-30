using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            try
            {
                Console.Write("Enter No:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter No:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("Division is:");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Can not divide by zero");
            }
        }
    }
}
