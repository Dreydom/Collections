using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList<Array> Arr1 = new ArrayList<Array>();
            //ArrayList<Array> Arr2 = new ArrayList<Array>();

            Stack<char> stack = new Stack<char>(new char[] {'1','2','3'});
            for (int i = 0; i < stack.Count; i++)
            {
                Console.Write(stack.at(i));
            }
            Console.WriteLine();
            stack.Push('4');
            stack.Push('5');
            stack.Push('6');
            for(int i=0; i<stack.Count;i++)
            {
                Console.Write(stack.at(i));
            }
            Console.WriteLine();
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());

            Queue<string> queue = new Queue<string>(new string[] { "first", "second", "third" });
            Console.WriteLine(queue.size());
            for (int i = 0; i < queue.Count; i++)
            {
                Console.Write("{0},",queue.at(i));
            }
            Console.WriteLine();
            queue.Enqueue("fourth");
            queue.Enqueue("fifth");
            for (int i = 0; i < queue.Count; i++)
            {
                Console.Write("{0},",queue.at(i));
            }
            Console.WriteLine();
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.at(0));
            Console.WriteLine(queue.size());
            Console.WriteLine(queue.Dequeue());
            for (int i = 0; i < queue.Count; i++)
            {
                Console.Write("{0},",queue.at(i));
            }
            Console.WriteLine();

            ArrayList<int> array = new ArrayList<int>(new int[] {1,2,3,4,5});
            for (int i = 0; i < array.Count; i++)
            {
                Console.Write("{0},",array.at(i));
            }
            Console.WriteLine();
            array.Add(13);
            array.Add(46);
            array.Add(10);
            array.Add(32);
            array.Add(5);
            array.Add(27);
            for (int i = 0; i < array.Count; i++)
            {
                Console.Write("{0},",array.at(i));
            }
            Console.WriteLine();
            Console.WriteLine("array.at(3) = {0}. now Remove(2):", array.at(3));
            array.Remove(2);
            for (int i = 0; i < array.Count; i++)
            {
                Console.Write("{0},", array.at(i));
            }
            Console.WriteLine();
            Console.WriteLine("count: {0}", array.Count);
            Console.ReadKey();
        }
    }
}
