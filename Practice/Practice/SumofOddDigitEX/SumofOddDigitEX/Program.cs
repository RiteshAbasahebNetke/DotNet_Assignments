﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofOddDigitEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, dig, sum = 0;
            Console.Write("Enter No:");
            num = Convert.ToInt32(Console.ReadLine());
            while(num>0)
            {
                dig = num % 10;
                if(!(num%2==0))
                {
                    sum = sum + dig;
                }
                num = num / 10;
            }
            Console.WriteLine("Sum of Odd Digits is:"+ sum);
        }
    }
}