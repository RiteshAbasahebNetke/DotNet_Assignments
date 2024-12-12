using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPatternEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // * Pattern
            /*for(int i=1; i<=5; i++)
            {
                for(int j=5; j>=i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/

            //Number Pattern
            /*for(int i=1; i<=5; i++)
            {
                for(int j=5; j>=i;j--)
                {
                    Console.Write(i+ " ");
                }
                Console.WriteLine();
            }*/

            for(int i=1; i<=5; i++)
            {
                for(int j=5;j>=i; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
