using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPatternEx5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // * Pattern
            /*for(int i=5; i>=1;i--)
            {
                for(int k=4;k>=i;k--)
                {
                    Console.Write(" ");
                }
                for(int j=i;j>=1;j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }*/

            // Number Pattern
            /*for(int i=5;i>=1;i--)
            {
                for(int k=4;k>=i;k--)
                {
                    Console.Write(" ");
                }
                for(int j=i;j>=1;j--)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }*/

            for(int i=5;i>=1;i--)
            {
                for(int k=4;k>=i;k--)
                {
                    Console.Write(" ");
                }
                for(int j=i;j>=1;j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
