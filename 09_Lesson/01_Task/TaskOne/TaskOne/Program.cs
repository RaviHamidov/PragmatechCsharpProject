using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TaskOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // non generic collection\

            // Fifo
            ArrayList arraylist = new ArrayList();
            arraylist.Add(5);
            arraylist.Add(6);
            arraylist.Add(7);
            arraylist.Add("ajkhflef");
            arraylist.Add(true);
            foreach (var item in arraylist)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(" - - - - - - - - - ");

            // Lifo
            Stack stack = new Stack();
            stack.Push(2);
            stack.Push("efjkw");
            stack.Push(true);
            stack.Push("push");
            
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(stack.Pop() + " remove");

            Console.WriteLine(" - - - - - - - - - ");

            //Fifo
            Queue queue = new Queue();
            queue.Enqueue(2);
            queue.Enqueue(1);
            queue.Enqueue(4);
            queue.Enqueue(6);

            foreach (var item in queue)
            {
                Console.WriteLine(item);       
            }

            Console.WriteLine(queue.Dequeue() + " bayira ");
            Console.WriteLine(queue.Peek() + " ba qaqan bunu secir ");

            Console.WriteLine("- - - - - - - - - ");

            // Lifo
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "Ravus");    
            hashtable.Add(2, "Rehi");
            hashtable.Add(3, "Elmar");
            hashtable.Add("Memmedeli", "Elmar");

            foreach (var item in hashtable)
            {
                Console.WriteLine(item);
            }

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key + "  sosial mesafe  " + item.Value);
            }

            Console.WriteLine("- - - - - - - - - ");
        }
    }
}
