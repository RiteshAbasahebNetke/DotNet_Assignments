﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPatternEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // * Pattern
            /*for(int i=0;i<5;i++)
            {
                for(int j=0;j<5;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/

            // Number
            /*for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }*/

            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
