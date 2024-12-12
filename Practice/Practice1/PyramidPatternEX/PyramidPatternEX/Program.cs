using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidPatternEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int k=4;k>=i;k--)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=i;j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
            

            for(int a=1;a<=5;a++)
            {
                for(int b=4;b>=a;b--)
                {
                    Console.Write(" ");
                }
                for(int c=1;c<=a;c++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
