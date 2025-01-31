using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestNoFromGivenNo_ArrayEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[5];

            int max = n[0];

            for(int i=0;i<5;i++)
            {
                Console.Write("Enter No:");
                n[i] = Convert.ToInt32(Console.ReadLine());
                if (max<n[i])
                {
                    max = n[i];
                }
            }
            Console.WriteLine("Maximum is:"+ max);  
        }
    }
}
