﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0ddcntEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ocnt=0;
            for(int i=0;i<100;i++)
            {
                if((i%2==0))
                {
                    ocnt++;
                }
            }
            Console.WriteLine("Odd Count is:"+ ocnt);
        }
    }
}
