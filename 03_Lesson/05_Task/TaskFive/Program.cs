using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Bro!");
            Console.WriteLine("Now you will write 5 numbers, You must be find middle of the numbers!");
            Console.WriteLine("First number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Third number: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fourth number: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fiveth number: ");
            int e = Convert.ToInt32(Console.ReadLine());
            int numbers = average(a, b, c, d, e);
            Console.WriteLine($"Chosen numbers: {a} {b} {c} {d} {e},");
            Console.WriteLine($"Before: {a + b + c + d + e},");
            Console.WriteLine($"After: {numbers}.");
            Console.WriteLine("Task Completed ;)");
        }
        public static int average(int a, int b, int c, int d, int e)
        {
            int progress = (a + b + c + d + e) / 5;
            return progress;
        }
    }
}
