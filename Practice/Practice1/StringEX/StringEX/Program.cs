using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ritesh
            //Rites
            //Rite
            //Rit
            //Ri
            //R

            string name;
            Console.WriteLine("Enter Name:");
            name= Console.ReadLine();   
            for(int i=name.Length-1; i>0; i--)
            {
                Console.WriteLine(name.Substring(0, i));
            }
        }
    }
}
