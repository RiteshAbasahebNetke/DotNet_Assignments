using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_CollectionEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Stack<int> s = new Stack<int>();
            s.Push(65);
            s.Push(89);
            s.Push(54);
            s.Push(457);

            Console.WriteLine("------------------>STACK");
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());*/

            /*Queue<string> q=new Queue<string>();
            q.Enqueue("Nilesh");
            q.Enqueue("Suresh");
            q.Enqueue("Rajesh");
            q.Enqueue("Yogesh");

            Console.WriteLine("---------------------->Queue");
            Console.WriteLine(q.Count);
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());*/

            List<string> l = new List<string>();
            l.Add("BE");
            l.Add("B TECH");
            l.Add("BSC");
            l.Add("BBA");

            Console.WriteLine("---------------------->List");
            for(int a=0;a<l.Count;a++)
            {
                Console.WriteLine(l[a]);
            }

            Console.WriteLine("Contains:" + l.Contains("JAVA"));

        }
    }
}
