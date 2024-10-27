using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NestedPerConditionalEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p, c, b, m, e;
            int Total;
            double per;

            Console.Write("Enter Physics Marks:");
            p=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Chemistry Marks:");
            c=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Biology Marks:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Maths Marks:");
            m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter English Marks:");
            e = Convert.ToInt32(Console.ReadLine());

            Total=p+c+b+m+e;
            Console.WriteLine("Total Marks are:" + Total);

            if(Total >70)
            {
                Console.WriteLine("Passed with Distinction");
            }
            else
            {
                if(Total >60)
                {
                    Console.WriteLine("Passed with First Class");
                }
                else
                {
                    if(Total>50)
                    {
                        Console.WriteLine("Passed with Second Class");
                    }
                    else
                    {
                        if(Total>40)
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("Try Again");
                        }
                    }
                }
            }
        }
    }
}
