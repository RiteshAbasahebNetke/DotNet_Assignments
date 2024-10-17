using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop4
{
    //Print count of odd numbers from 10 to 40.
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, Ocount = 0;
            for(num=10;num<=40;num++)
            {
                if (!(num % 2 == 0))
                {
                    Ocount++;
                  // Console.WriteLine("No is:" + num);
                }
                
            }
            Console.WriteLine("Count of Odd No is:" +Ocount);
        }
    }
}
