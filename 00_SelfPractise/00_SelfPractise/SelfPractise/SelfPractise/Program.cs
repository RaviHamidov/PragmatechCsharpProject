using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForLoopPractise

            /*for (initializer; condition; iterator)
            {
                // code block
            }*/

            /*for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Value of i: {0}", i);
            }*/

            /*int i = 0;

            for (; ; )
            {
                if (i <= 10)
                {
                    Console.WriteLine("Value of i: {0}", i);
                    i++;
                }
                else
                    break;
            }*/

            /* for (; ; )
             {
                 Console.Write(1);
             }*/

            /*for (double d = 1.01D; d < 1.10; d += 0.01D)
            {
                Console.WriteLine("Value of i: {0}", d);
            }*/

            /*for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("Value of i: {0}", i);
            }*/

            /*int i = 0, j = 5;
            for (Console.WriteLine($"Initializer: i={i}, j={j}");
                i++ < j--;
                Console.WriteLine($"Iterator: i={i}, j={j}"))
            {
            }*/

            /*for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break;

                Console.WriteLine("Value of i: {0}", i);
            }*/

            /*for (int i = 0, j = 0; i + j < 5; i++, j++)
            {
                Console.WriteLine("Value of i: {0}, J: {1} ", i, j);
            }*/

            /*for (int i = 0; i < 2; i++)
            {
                for (int j = i; j < 4; j++)
                    Console.WriteLine("Value of i: {0}, J: {1} ", i, j);
            }*/
            /*for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Result is a: {0}",i);
            }*/
            string a = "memmed";
            Console.WriteLine($"Salam {a}");

            Console.ReadKey();  
            #endregion
        }
    }
}
