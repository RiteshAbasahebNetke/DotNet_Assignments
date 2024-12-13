using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitInterfaceEx
{
    interface AInt
    {
        void SayHello();
    }
    interface BInt
    {
        void SayHello();
    }
    class Message : AInt, BInt
    {
        public void SayHello()
        {
            Console.WriteLine("Say Hello Called...!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Message m=new Message();
            m.SayHello();
        }
    }
}
