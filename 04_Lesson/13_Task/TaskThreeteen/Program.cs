using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskThreeteen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Bro!");
            var arr1 = new[] { 1, 2, 3, 4, 5 };
            var arr2 = new[] { 6, 7, 8, 9, 0 };
            var arr = arr1.Union(arr2).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Task Completed;)");
        }
    }
}
