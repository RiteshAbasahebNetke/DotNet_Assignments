using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageANDGenderex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Enter Age:");
            age=Convert.ToInt32(Console.ReadLine());

            string gender;
            Console.Write("Enter Gender:");
            gender=Console.ReadLine();

            if(age >=18 && gender=="Male")
            {
                Console.WriteLine("Qualified for the Job");
            }
            else
            {
                Console.WriteLine("Not Qualified for the Job");
            }
        }
    }
}
