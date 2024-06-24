using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack<int> s = new Stack<int>();
            //s.Push(85);
            //s.Push(63);
            //s.Push(20);
            //s.Push(97);

            //Console.WriteLine("--------------------->Stack");
            //Console.WriteLine(s.Pop());
            //Console.WriteLine(s.Pop());
            //Console.WriteLine(s.Pop());
            //Console.WriteLine(s.Pop());

            //Queue<string> q = new Queue<string>();
            //q.Enqueue("Nilesh");
            //q.Enqueue("Mangesh");
            //q.Enqueue("Manish");
            //q.Enqueue("Avinash");

            //Console.WriteLine("---------------------->Queue");
            //Console.WriteLine(q.Dequeue());
            //Console.WriteLine(q.Dequeue());
            //Console.WriteLine(q.Dequeue());
            //Console.WriteLine(q.Dequeue());

            List<string> l = new List<string>();
            l.Add("Angular");
            l.Add("Javascript");
            l.Add("Knockout");
            l.Add("Java");

            Console.WriteLine("----------------->List");
            for(int a = 0; a < l.Count; a++)
            {
                Console.WriteLine(l[a]);
            }

            Console.WriteLine("Contains:" + l.Contains("Java"));
        }
    }
}
