using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Implicit_InterfaceEX
{
    //Implicit interface implementation
    /*interface Aint
    {
        void SayHello();
    }
    interface Bint
    {
        void SayHello();
    }
    class Message : Aint, Bint
    {
        public void SayHello()
        {
            Console.WriteLine("Say Hello Called..!");
        }
    }*/


    //Explicit interface implementation
    interface Aint
    {
        void SayHello();
    }
    interface Bint
    {
        void SayHello();
    }
    class Message : Aint, Bint
    {
        void Aint.SayHello()
        {
            Console.WriteLine("Say Hello for Aint Called..!");
        }
        void Bint.SayHello()
        {
            Console.WriteLine("Say Hello for Bint Called..!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implicit interface implementation
            /*Message m =new Message();
            m.SayHello();  */ 

            //Explicit interface implementation
            Message m=new Message();
            Aint a = new Message();
            a.SayHello();

            Bint b=new Message();
            b.SayHello();
        }
    }
}
