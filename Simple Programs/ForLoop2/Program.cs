using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input 10 integer numbers & print count of Odd & Even number
            int num, Ecount=0, Ocount=0;
            for(int a=0;a<10;a++)
            {
                Console.Write("Enter No:");
                num = Convert.ToInt32(Console.ReadLine());
              if(num%2==0)
                {
                    Ecount++;
                }
              else
                {
                    Ocount++;
                }
            }
            Console.WriteLine("Even count is:" + Ecount);
            Console.WriteLine("Odd count is:" + Ocount);
        }
    }
}
