using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CntOFoddeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, dig, ocnt = 0, ecnt = 0;
            Console.Write("Enter Number:");
            num=Convert.ToInt32(Console.ReadLine());

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
            Console.WriteLine("Event Count is:" + ecnt);
            Console.WriteLine("Odd Count is:"+ ocnt);
        }
    }
}
