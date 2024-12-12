using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Replace Even Digit from number with 0

            int num, dig;
            Console.Write("Enter Number:");
            num=Convert.ToInt32(Console.ReadLine());
            Console.Write("Output is:");
            do
            {
                dig = num % 10;
                if (dig % 2 == 0)
                {
                    Console.Write("0");
                }
                else
                {
                    Console.Write(dig);
                }
                num = num / 10;
            } while (num > 0);

        }
    }
}
