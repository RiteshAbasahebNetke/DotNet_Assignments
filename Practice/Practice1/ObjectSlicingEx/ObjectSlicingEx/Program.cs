using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectSlicingEx
{
    class Parent
    {
        public virtual void DispMethod()
        {
            Console.WriteLine("Parent Class");
        }
    }
    class Child:Parent
    {
        public override void DispMethod()
        {
            Console.WriteLine("Child Class");  
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            Child c=new Child();
            p = c;
            p.DispMethod();
        }
    }
}
