using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddnOfTenNoUsingForLoopEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum=0;
            
            for(int i=0; i<10;i++)
            {
                Console.Write("Enter No:");
                num = Convert.ToInt32(Console.ReadLine());
                sum = num + sum;
            }
            Console.WriteLine("Addition of 10 number is:"+ sum);
        }
    }
}
