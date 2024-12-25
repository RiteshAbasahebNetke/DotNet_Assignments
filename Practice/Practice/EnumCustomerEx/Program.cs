using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumCustomerEx
{
    internal class Program
    {
        enum Category { Platinum = 1, Diamond = 2, Gold = 3, Silver = 4 };
        static void Main(string[] args)
        {
            int CustomerCategory;
            string Productname;
            int Qty;
            double Price;
            Console.Write("Enter Customer Category:");
            CustomerCategory = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Product Name:");
            Productname = Console.ReadLine();
            Console.Write("Enter Quantity:");
            Qty = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Price:");
            Price = Convert.ToDouble(Console.ReadLine());

            double Amount, DiscountAmount;

            Amount = Qty * Price;
            Console.WriteLine("Amount is:" + Amount);
            switch (CustomerCategory)
            {
                case (int)Category.Platinum:
                    DiscountAmount = Amount * 0.5;
                    break;
                case (int)Category.Diamond:
                    DiscountAmount = Amount * 0.4;
                    break;
                case (int)Category.Gold:
                    DiscountAmount = Amount * 0.3;
                    break;
                case (int)Category.Silver:
                        DiscountAmount = Amount * 0.2;
                    break;
                default:
                    DiscountAmount = Amount * 0.1;
                    break;
            }
            Console.WriteLine("Discount Amount is:" + DiscountAmount);
        }
    }
}
