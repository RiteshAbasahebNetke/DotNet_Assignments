using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHidingEx
{
    class Parent
    {
        public void DispMethod()
        {
            Console.WriteLine("Parent Class");
        }
    }
    class Child:Parent
    {
        public new void DispMethod()
        {
            Console.WriteLine("Child Class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.DispMethod();
        }
    }
}
