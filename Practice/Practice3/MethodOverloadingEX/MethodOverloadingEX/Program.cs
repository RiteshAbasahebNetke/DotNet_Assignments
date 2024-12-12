using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingEX
{
    class Shape
    {
        public void CalculateArea(int r)
        {
            double a = 3.14 * r * r;
            Console.WriteLine("Area of Circle is:" + a);
        }
        public void CalculateArea(int l,int b)
        {
            double a = l * b;
            Console.WriteLine("Area of Rectangle is:" + a);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            s.CalculateArea(4);
            s.CalculateArea(4, 5);
        }
    }
}
