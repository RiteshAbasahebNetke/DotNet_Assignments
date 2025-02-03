using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_whileEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, ocnt = 0;
            do
            {
                Console.Write("Enter No:");
                num = Convert.ToInt32(Console.ReadLine());

                if (!(num%2==0))
                {
                    ocnt++;
                }
            } while (!(num % 8 == 0));
            Console.WriteLine("Count is:"+ ocnt);
        }
    }
}
