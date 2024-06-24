using System;
using System.Collections;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack s = new Stack();
            //s.Push(2);
            //s.Push("Ram");
            //s.Push(true);
            //s.Push(852.024);

            // Console.WriteLine(">>>>>>>>>>>>>>>>>>>>Stack");
            //Console.WriteLine(s.Pop());
            //Console.WriteLine(s.Pop());
            //Console.WriteLine(s.Pop());
            //Console.WriteLine(s.Pop());

            //Queue q = new Queue();
            //q.Enqueue(25);
            //q.Enqueue("Rajesh");
            //q.Enqueue(5647.3654);
            //q.Enqueue(false);

            //Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>Queue");
            //Console.WriteLine(q.Dequeue());
            //Console.WriteLine(q.Dequeue());
            //Console.WriteLine(q.Dequeue());
            //Console.WriteLine(q.Dequeue());

            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add("Ramesh");
            al.Add(254.25);
            al.Add(false);

            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>ArrayList");
             for(int a=0; a<al.Count; a++)
            {
                Console.WriteLine(al[a]);
            }
            Console.WriteLine();

            // al.Remove(false);
           // al.Insert(1, "Java");
            al.Reverse();
            for(int a=0; a<al.Count; a++)
            {
                Console.WriteLine(al[a]);
            }
        }
    }
}
