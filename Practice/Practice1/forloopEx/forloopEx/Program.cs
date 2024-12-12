using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloopEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Addition of all 3 numbers using FOR loop

            int num, sum = 0;
            for(int i=0; i<3;i++)
            {
                Console.Write("Enter No:");
                num=Convert.ToInt32(Console.ReadLine());
                sum=sum+num;
            }
            Console.WriteLine("Sum is:"+ sum);
        }
    }
}
