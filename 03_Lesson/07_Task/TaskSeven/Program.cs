using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Bro!");
            Console.WriteLine("Now you will write a Number, You must be find a chosen number's multiplication table's Alghoritms!");
            Console.WriteLine("Write a Number please:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Before: {x}");
            Console.WriteLine($"After: {ChangeNumber(ref x)}");
            Console.WriteLine("Task Completed ;)");
        }
        public static int ChangeNumber(ref int input)
        {
            int result = 0;
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                result = i * input;
                sum += result;
            }
            input = sum;
            return sum;
        }
    }
}
