using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop3
{
    internal class Program
    {
        //Print count of even number from 10 to 30
        static void Main(string[] args)
        {
             int num, Ecount = 0;

             for(num=10; num<=30;num++)
             {
                if (num % 2==0)
                {
                     Ecount++;
                //    Console.WriteLine("Number is:" + num); 
                }
            }
             Console.WriteLine("Count of Even No is:" + Ecount);
        }
    }
}
