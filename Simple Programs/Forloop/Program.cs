using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print sum of inputted 10 numbers
            int num, sum = 0;
            for(int i=0;i<10;i++)
            {
                Console.Write("Enter No:");
                num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine("Sum is:" + sum);
        }
    }
}
