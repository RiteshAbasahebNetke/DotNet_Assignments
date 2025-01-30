using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcntAndOcntUsingWhileLoopEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, ecnt = 0, ocnt = 0,dig;
            Console.Write("Enter No:");
            num = Convert.ToInt32(Console.ReadLine());

            while(num>0)
            {
                dig = num % 10;
                if(dig%2==0)
                {
                    ecnt++;
                }
                else
                {
                    ocnt++;
                }
                num = num / 10;
            }
            Console.WriteLine("Odd Count is:" + ocnt);
            Console.WriteLine("Even Count is:"+ ecnt);
        }
    }
}
