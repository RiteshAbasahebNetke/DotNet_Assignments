using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPatternEX3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for(int i=1;i<=5;i++)
            {
                for(int j=5;j>=i;j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/

            for(int i=1;i<=5;i++)
            {
                for(int j=5;j>=i;j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
