using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenoddex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter No:");
            n=Convert.ToInt32(Console.ReadLine());
            if(n%2==0)
            {
                Console.WriteLine("Number is Even");
            }
            else { Console.WriteLine("Number is Odd"); }
        }
    }
}
