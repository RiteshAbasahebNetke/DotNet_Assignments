using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollecctionEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Stack s = new Stack();
            s.Push(1);
            s.Push("Sham");
            s.Push(234.56);

            Console.WriteLine("*********Stack**********");
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());*/

            /*Queue q=new Queue();
            q.Enqueue(23);
            q.Enqueue("Raju");
            q.Enqueue(true);
            q.Enqueue(false);

            Console.WriteLine("**********Queue********");
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());*/

            List<string>l=new List<string>();
            l.Add("Rajesh");
            l.Add("Ranjan");
            l.Add("Ramesh");
            l.Add("Raju");

            Console.WriteLine("**********List**********");
            for(int i=0; i<l.Count; i++)
            {
                Console.WriteLine(l[i]);
            }
            Console.WriteLine("Name Count:"+ l.Count);
            Console.WriteLine("Contains:" + l.Contains("Raju"));
        }
    }
}
