using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNoEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum;
            int i=1, dig=0;

            Console.Write("Enter No:");
            num = Convert.ToInt32(Console.ReadLine());

            sum = 0;
            i = num;
            while(num>0)
            {
                dig = num % 10;
                sum = sum + (dig * dig * dig);
                num = num / 10;
            }
            if(sum==i)
            {
                Console.WriteLine(i + ":Is a Armstrong Number");
            }
            else
            {
                Console.WriteLine(i +":Is not a Armstrong Number");
            }
        }
    }
}
