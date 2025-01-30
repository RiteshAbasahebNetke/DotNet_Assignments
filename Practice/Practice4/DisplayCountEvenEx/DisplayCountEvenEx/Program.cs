using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayCountEvenEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ecnt = 0;
            for(int i=10; i<=30;  i++)
            {
                if(i%2==0)
                {
                    ecnt++;
                } 
            }
            Console.WriteLine("Even Count is:"+ ecnt);  
        }
    }
}
