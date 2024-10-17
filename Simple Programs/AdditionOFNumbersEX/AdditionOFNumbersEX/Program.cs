using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionOFNumbersEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int add = 0;
            for(int i=0;i<5;i++)
            {
                Console.Write("Enter Number:");
                num = Convert.ToInt32(Console.ReadLine());
                add = num + add;
            }
            Console.WriteLine("Addition of number is:"+ add);
        }
    }
}
