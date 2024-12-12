using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopAddEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            for(int i=0;i<5;i++)
            {
                Console.Write("Enter No:");
                num=Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine("Sum of all digits is:"+ sum);    
        }
    }
}
