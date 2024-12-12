using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAddOfEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            int[] num = new int[5];
            for(int i=1;i<=5;i++)
            {
                Console.Write("Enter No:");
                num[i] = Convert.ToInt32(Console.ReadLine());
                if(num[i]%2 == 0)
                {
                    sum=sum+num[i];
                }
            }
            Console.WriteLine("Sum is:"+ sum);
        }
    }
}
