using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEX
{
    interface AreaInt
    {
        double CalculateArea();
    }
    class Circle : AreaInt
    {
        private double r;
        public Circle(double r)
        {
            this.r = r;
        }
        public double CalculateArea()
        {
            double area = 3.14 * r * r;
            return area;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(4);
            double area = c.CalculateArea();
            Console.WriteLine("Area of Circle is:" + area);
        }
    }
}
