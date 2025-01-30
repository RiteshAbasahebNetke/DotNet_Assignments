using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndLogicalOpEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            string gender;

            Console.Write("Enter Age:");
            age=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Gender:");
            gender=Console.ReadLine();

            if(age>18 && gender=="Male")
            {
                Console.WriteLine("Eligible for Job");
            }
            else
            {
                Console.WriteLine("Not Eligible for a Job");
            }
        }
    }
}
