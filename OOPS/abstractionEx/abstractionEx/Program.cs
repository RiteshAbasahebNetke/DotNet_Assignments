using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractionEx
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
    class Rectangle : Shape
    {
        private double length;
        private double bredth;
        public Rectangle(double length, double bredth)
        {
            this.length = length;
            this.bredth = bredth;
        }

        public override double CalculateArea()
        {
            double a = this.length * this.bredth;
            return a;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(2);
            double area=c.CalculateArea();
            Console.WriteLine("Area of Cirle is:" + area);

            Rectangle r = new Rectangle(2, 3);
            double a = r.CalculateArea();
            Console.WriteLine("Area of rectangle is:" + a);
        }
    }
}
