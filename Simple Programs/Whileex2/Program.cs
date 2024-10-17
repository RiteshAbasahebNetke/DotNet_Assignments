using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whileex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print sum of Odd digit number from the entered number`
             int num, dig, sum = 0;
             Console.Write("Enter the Number:");
             num = Convert.ToInt32(Console.ReadLine());
             while(num!=0)
             {
                 dig = num % 10;
                 if(!(dig%2==0))
                 {
                     sum = sum + dig;
                 }
                 num = num / 10;
             }
             Console.WriteLine("Sum of Odd Number is:" + sum); 
             

            //Print sum of entered number
           /* int num, dig, sum = 0;
            Console.Write("Enter Number:");
            num = Convert.ToInt32(Console.ReadLine());
            while(num!=0)
            {
                dig = num % 10;
                sum = sum + dig;
                num = num / 10;
            }
            Console.WriteLine("The sum is:" + sum);  */
        }
    }
}
