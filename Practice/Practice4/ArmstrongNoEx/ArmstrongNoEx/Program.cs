using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNoEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, dig, sum;

            for(int i=1;i<=500;i++)
            {
                sum = 0;
                num = i;

                while(num>0)
                {
                    dig = num % 10;
                    sum = sum + (dig*dig*dig);
                    num=num / 10;
                }
                if(sum==i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
