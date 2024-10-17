using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whileex1
{
    internal class Program
    {
        //Print Odd and even count from the entered number
        static void Main(string[] args)
        {
             int num, dig, Ecount = 0, Ocount = 0;
              Console.Write("Enter Number:");
              num = Convert.ToInt32(Console.ReadLine());
              while(num!=0)
              {
                  dig = num % 10;
                  if(dig%2==0)
                  {
                      Ecount++;
                  }
                  else
                  {
                      Ocount++;
                  }
                  num = num / 10;
              }
              Console.WriteLine("Even count is:" + Ecount);
              Console.WriteLine("Odd count is:" + Ocount);       

           //Print reverse number
          /*  int num, dig, reverse=0;
            Console.Write("Enter Number:");
            num = Convert.ToInt32(Console.ReadLine());
            while(num!=0)
            {
                dig = num % 10;
                reverse = dig+reverse*10;
                num = num / 10;
            }
            Console.WriteLine("Reverse Number is:" + reverse); */
        }
    }
}
