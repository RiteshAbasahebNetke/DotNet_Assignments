using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_CounttofNames
{
    internal class Program
    {

        //Count of names ending with sh
        static void Main(string[] args)
        {
            string[] str = new string[10];

            for(int a=0; a<10; a++)
            {
                Console.Write("Enter Name: ");
                str[a] = Console.ReadLine();
            }

            int count = 0;
            for(int a=0; a<str.Length; a++)
            {
                if (str[a].EndsWith("sh"))
                {
                    count++;
                }              
            }
            Console.WriteLine("Count is:" + count);
        }
    }
}
