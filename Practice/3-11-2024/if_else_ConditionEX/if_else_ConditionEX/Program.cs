using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_ConditionEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p, c, m, b, e;
            int Total;
            double per;

            Console.Write("Enter Marks for Physics:");
            p = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Marks for Chemistry:");
            c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Marks for Maths:");
            m=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Marks for Biology:");
            b=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Marks for English:");
            e=Convert.ToInt32(Console.ReadLine());
            
            Total=p+c+m+b+e;
            Console.WriteLine("Total is:" + Total);
            per = (Total / 5);
            Console.WriteLine("Percentage is:"+ per);

            if(per>70)
            {
                Console.WriteLine("Passed with Distinction");
            }
            else
            {
                if(per>60)
                {
                    Console.WriteLine("Passed with First Class");
                }
                else
                {
                    if(per>50)
                    {
                        Console.WriteLine("Passed with Second Class");
                    }
                    else
                    {
                        if(per>40)
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("Failed");
                        }
                    }
                }
            }
        }
    }
}
