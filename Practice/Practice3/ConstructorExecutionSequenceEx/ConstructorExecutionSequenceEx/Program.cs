
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExecutionSequenceEx
{
    class Test
    {
        public Test()
        {
            Console.WriteLine("Parent Default Constructor Called..!");
        }
        public Test(int a)
        {
            Console.WriteLine("Parent Parameterized Constructor Called..!");
        }
    }
    class Child:Test
    {
        public Child():base(1)
        {
            Console.WriteLine("Child Constructor Called..!");
        }
        public Child(int b):base()
        {
            Console.WriteLine("Child Parameterized Constructor Called..!");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            Child c1=new Child(12);
        }
    }
}
