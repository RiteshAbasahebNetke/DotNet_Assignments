using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            try
            {
                Console.Write("Enter Number:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Number:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.Write("Division is:" + c);
            }
            /*catch (DivideByZeroException ex) 
            {
                Console.WriteLine("Can not divide by zero");
            }*/
            catch(FormatException fx)
            {
                Console.WriteLine("Format is incorrect");
            }
        }
    }
}
