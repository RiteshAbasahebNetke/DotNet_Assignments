using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbersEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prime No. from 1 to 100
            int i, j, k;
            for(i=1;i<=100;i++)
            {
                k = 0;
                for(j=2;j<i;j++)
                {
                    if(i%j==0)
                    {
                        k= 1;
                        break;
                    }
                }
                if (k == 0)
                {
                    Console.WriteLine("Prime:" + i);
                }
            }
            
        }
    }
}
