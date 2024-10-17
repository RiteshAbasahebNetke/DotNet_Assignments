using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print sum of Odd & Even numbers from the entered  10 nummbers
           int num, Esum=0,Osum=0;
            for(int a=0;a<10;a++)
            {
                Console.Write("Enter No:");
                num = Convert.ToInt32(Console.ReadLine());
                    if(num%2==0)
                    {
                    Esum = Esum + num;
                    }
                    else
                    {
                    Osum = Osum + num;
                    }
            }
            Console.WriteLine("Sum of Even number is:" + Esum);
            Console.WriteLine("sum of Odd number is:" + Osum);
        }
    }
}
