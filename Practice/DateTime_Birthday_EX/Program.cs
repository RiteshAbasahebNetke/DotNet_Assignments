using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Birthday_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day, month;
            Console.Write("Enter Day:");
            day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Month:");
            month = Convert.ToInt32(Console.ReadLine());
            if(DateTime.Now.Day==day && DateTime.Now.Month == month)
            {
                Console.WriteLine("Happy Birthday Dude..!");
            }
            else
            {
                Console.WriteLine("Try Again..!"); ;
            }
        }
    }
}
