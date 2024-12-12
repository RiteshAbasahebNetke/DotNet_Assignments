using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountEOEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Count of Odd and Even digit from given number
            int num, dig,Ecnt = 0, Ocnt = 0;
            Console.Write("Enter No:");
            num = Convert.ToInt32(Console.ReadLine());
            while(num>0)
            {
                dig = num % 10;
                if(dig%2==0)
                {
                    Ecnt++;
                }
                else
                {
                    Ocnt++;
                }
                num = num / 10;
            }
            Console.WriteLine("Even Count is:"+Ecnt);
            Console.WriteLine("Odd Count is:"+Ocnt);
        }
    }
}
