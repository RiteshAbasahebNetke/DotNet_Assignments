using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAreaEx
{
    interface Area
    {
        double CalculateArea();
    }
    class Rectangle:Area
    {
        public double l, b;
        public Rectangle(double l, double b)
        {
            this.l = l;
            this.b = b;
        }
        public double CalculateArea()
        {
            double a = l * b;
            return a;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(5, 5);
            double a=r.CalculateArea();
            Console.WriteLine("Area of Rectangle is:" + a);
        }
    }
}
