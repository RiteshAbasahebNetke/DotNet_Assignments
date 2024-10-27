using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNoEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, dig, rn = 0;
            Console.Write("Enter No:");
            num = Convert.ToInt32(Console.ReadLine());
            while(num>0)
            {
                dig = num % 10;
                rn = dig + (rn * 10);
                num = num / 10;
            }
            Console.WriteLine("Reverse No is:" + rn);
        }
    }
}
