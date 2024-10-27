using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloopEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            for(int i=0;i<5;i++)
            {
                Console.Write("Enter No:");
                n=Convert.ToInt32(Console.ReadLine());
                sum=sum+n;
            }
            Console.WriteLine("Sum is:" + sum);
  
        }
    }
}
