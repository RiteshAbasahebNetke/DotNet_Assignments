using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Implicit_InterfaceEX
{
    //Implicit interface
    /*interface Aint
    {
        void SayHello();
    }
    interface Bint
    {
        void SayHello();
    }
    class Message:Aint,Bint
    {
        public void SayHello()
        {
            Console.WriteLine("Say Hello Called...!");
        }
    }*/

    //Explicit interface
    interface Aint
    {
        void SayHello();
    }
    interface Bint
    {
        void SayHello();
    }

    class Message:Aint,Bint
    {
        void Aint.SayHello()
        {
            Console.WriteLine("Say Hello for Aint");
        }
        void Bint.SayHello()
        {
            Console.WriteLine("Say Hello for Bint");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Message m=new Message();
            m.SayHello();*/

            Aint a=new Message();
            a.SayHello();
            Bint b=new Message();
            b.SayHello();   
        }
    }
}
