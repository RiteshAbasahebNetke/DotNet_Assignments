﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPatternEx4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // * Pattern
            /*for(int i=1; i<=5; i++)
            {
                for(int j=4;j>=i; j--)
                {
                    Console.Write(" ");
                }
                for(int k=1; k<=i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }*/

            // Number Pattern
            /*for(int i=1; i<=5; i++)
            {
                for(int j=4; j>=i; j--)
                {
                    Console.Write(" ");
                }
                for(int k=1; k<=i; k++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }*/

            for(int i=1; i<=5; i++)
            {
                for(int j=4; j>=i; j--)
                {
                    Console.Write(" ");
                }
                for(int k=1; k<=i; k++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
