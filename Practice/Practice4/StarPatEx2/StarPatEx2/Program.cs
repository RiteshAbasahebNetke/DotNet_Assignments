using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPatEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // * Pattern
            /*for(int i=1;i<=5;i++)
            {
                for(int k=4;k>=i;k--)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=i;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }*/

            // Number Pattern
            /*for(int i=1; i<=5;  i++)
            {
                for(int k=4; k>=i; k--)
                {
                    Console.Write(" ");
                }
                for(int j=1; j<=i; j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }*/

            for(int i=1;i<=5;i++)
            {
                for(int k=4;k>=i;k--)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
