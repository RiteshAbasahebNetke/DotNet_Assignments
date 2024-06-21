using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Enter Name:");
            name = Console.ReadLine();

            for(int a=name.Length; a>0; a--)
            {
                Console.WriteLine(name.Substring(0,a));
            }   
        }
    }
}
