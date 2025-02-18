using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionEx
{
    abstract class Shape
    {
        public abstract double CalculateArea();
    }
    class Circle:Shape
    {
        private double radius;
        public double a;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double CalculateArea()
        {
            double a = 3.14 * this.radius * this.radius;
            return a;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(2);
            double a=c.CalculateArea();
            Console.WriteLine("Area of Circle is:" + a);
        }
    }
}
