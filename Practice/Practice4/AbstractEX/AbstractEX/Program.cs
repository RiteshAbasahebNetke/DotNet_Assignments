using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEX
{
    abstract class Shape
    {
        public abstract double Calculatearea();
    }
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Calculatearea()
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
            double area = c.Calculatearea();
            Console.WriteLine("Area of circle is:" + area);
        }
    }
}
