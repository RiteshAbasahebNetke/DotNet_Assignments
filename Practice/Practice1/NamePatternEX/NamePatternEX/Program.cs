using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamePatternEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "RITESH";
            int l=s.Length;

            // Vertically name will be displayed
            /*for(int i=0; i<l; i++)
            {
                for(int j=0; j<l; j++)
                {
                    Console.Write(s[i] + " ");
                }
                Console.WriteLine();
            }*/

            // Horizontally name will be displayed
            for(int i=0; i<l; i++)
            {
                for(int j=0; j<l; j++)
                {
                    Console.Write(s[j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
