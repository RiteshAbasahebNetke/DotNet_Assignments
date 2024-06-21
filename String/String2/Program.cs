using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String2
{
    internal class Program
    {
        //Input 10 names from the user and dispaly count of names those ends with with sh
        static void Main(string[] args)
        {
            string name;
            int count = 0;

            for (int a = 0; a < 10; a++)
            {
                Console.Write("Enter Name:");
                name = Console.ReadLine();

                if (name.EndsWith("sh"))
                {
                    count++;
                }
            }
            Console.WriteLine("Count is:" + count);

            //Input 10 names from the user in array and display count of names ends with sh

            string[] str = new string[10];
            string b;
            int cnt=0;
            for(int a=0; a<10; a++)
            {
                Console.Write("Enter Name:");
                b = Console.ReadLine();

                if (b.EndsWith("sh"))
                {
                    count++;
                }
            }
            Console.WriteLine("Count of ending with sh:" + count);


        }
    }
}
