using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNoEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, fact = 1;

            Console.Write("Enter Number:");
            n=Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of" + n + "is" + fact);
        }
    }
}
