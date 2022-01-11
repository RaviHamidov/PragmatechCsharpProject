using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Bro!");
            Console.WriteLine("Now you will must be set the Algorithm to sum the squares between 1 and a given number!");
            Console.WriteLine("Write a Number please: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int result = sumsquares(a);
            Console.WriteLine($"Result: {result}.");
            Console.WriteLine("Task Completed ;)");
        }
        public static int sumsquares(int a)
        {
            int sum = 0, b;
            for (int i = 0; i <= a; i++)
            {
                b = i * i;
                sum += b;
            }
            return sum;
        }
    }
}
