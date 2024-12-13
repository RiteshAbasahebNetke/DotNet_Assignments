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
                Console.WriteLine("Division is:"+ c);
            }
            catch (DivideByZeroException dv)
            {
                Console.WriteLine("Can not divide by Zero");
                Console.WriteLine(dv.ToString());
            }
            catch(FormatException fe)
            {
                Console.WriteLine("Incorrect Format");
                Console.WriteLine(fe.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine("Some Exception Occured");
                Console.WriteLine(ex.ToString());
            }
            
        }
    }
}
