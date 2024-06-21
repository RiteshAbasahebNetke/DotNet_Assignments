using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace String1
{
    internal class Program
    {
        //Input string from user and display count of all capital letters from that string
        static void Main(string[] args)
        {
            //string str;
            //int count = 0,b;
            //Console.Write("Enter Name:");
            //str = Console.ReadLine();
            //b = str.Length;
            //for(int a=0; a<b; a++)
            //{
            //    if (str[a] >= 'A' && str[a] <='Z')
            //   {
            //    count++;
            //    }
            //}
            //Console.WriteLine("Count is:" + count);

            //OR

            string str;
            int count = 0;
            Console.Write("Enter Name:");
            str = Console.ReadLine();

            foreach(char temp in str)
            {
                if(char.IsUpper(temp))
                {
                    count++;
                }
            }
            Console.WriteLine("Count of Capital letters is:" + count);

        }
    }
}
