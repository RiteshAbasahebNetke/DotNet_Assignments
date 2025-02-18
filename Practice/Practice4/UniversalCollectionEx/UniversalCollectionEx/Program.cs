using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalCollectionEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Stack s = new Stack();
            s.Push(1);
            s.Push("Ramesh");
            s.Push(true);

            Console.WriteLine("**************Stack*************");
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());*/

            /*Queue q=new Queue();
            q.Enqueue(1);
            q.Enqueue("Suresh");
            q.Enqueue(false);
            q.Enqueue(123.456);

            Console.WriteLine("*************Queue*************");
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());*/

            ArrayList al=new ArrayList();
            al.Add(1);
            al.Add("Rajn");
            al.Add(true);
            al.Add(234.098);

            Console.WriteLine("************ArrayList*************");
           /* for(int i=0;i<al.Count;i++)
            {
                Console.WriteLine(al[i]);
            }*/
            al.Remove(true);
            al.Add("C#");
            for(int i=0;i<al.Count;i++)
            {
                Console.WriteLine(al[i]);
            }
        }
    }
}
