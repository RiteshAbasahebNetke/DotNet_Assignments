using ShapeAbstractEX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAbstractEX
{
    abstract class Shape
    {
        public abstract double CalculateArea();
    }
    class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            double area = 3.14 * radius * radius;
            return area;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(5);
            double area=c.CalculateArea();
            Console.WriteLine("Area of Circle is:"+ area);
        }
    }
}
