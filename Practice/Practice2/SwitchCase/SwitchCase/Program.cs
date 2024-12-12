using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amount, discount;
            string cityname;
            Console.Write("Enter CityName:");
            cityname = Console.ReadLine();
            Console.Write("Enter Amount:");
            amount = Convert.ToDouble(Console.ReadLine());

            switch("cityname")
            {
                case "Pune":
                    Console.Write(amount * (0.04));
                    break;
                case "PCMC":
                    Console.Write(amount * (0.03));
                    break;
                case "Mumbai":
                    Console.Write(amount * (0.02));
                    break;
                case "Delhi":
                    Console.Write(amount * (0.01));
                    break;
                    default:
                    Console.Write(amount * 0.005);
                    break;

                    Console.WriteLine("Discount is:"+ discount);
            }
        }
    }
}
