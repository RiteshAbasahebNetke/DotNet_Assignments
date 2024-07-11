using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
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
                Console.WriteLine("Division is:" + c);
            }
            catch(DivideByZeroException dv)
            {
                Console.WriteLine("****** Can not divide by zero ******");
                Console.WriteLine(dv.ToString());
            }
            catch(FormatException fe)
            {
                Console.WriteLine("++++++ Invalid Input ++++++");
                Console.WriteLine(fe.ToString());
            }
            catch(Exception e)
            {
                Console.WriteLine("Some exception occured");
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("###### Finally Block ######");
                Console.WriteLine("$$$$$$ Finally Block Executed $$$$$$");
                Console.WriteLine("########################################");
            }
        }
    }
}
