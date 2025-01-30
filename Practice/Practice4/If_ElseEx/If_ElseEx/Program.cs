using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_ElseEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qty, price;
            string CityName;

            Console.Write("Enter Quantity:");
            qty=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Price:");
            price = Convert.ToInt32(Console.ReadLine());

            int Amount;
            Amount = qty * price;

            Console.Write("Enter CityName:");
            CityName = Console.ReadLine();

            if(CityName=="Pune")
            {
                Console.WriteLine("Discount is:" + Amount * 0.2);
            }
            else
            {
                Console.WriteLine("Discount is:" + Amount * 0.1);
            }
        }
    }
}
