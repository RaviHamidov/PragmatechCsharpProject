using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Bro!");
            int sum = 0,multiplication=1 ;
            Console.WriteLine("Now you will must be set the Algorithm that calculates the subtraction between multiplication with sum of the numbers between 0 and a given number!");
            Console.WriteLine("Write a Number please: ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                sum += i;
                multiplication *= i;
            }
            Console.WriteLine($"Multiplication: {multiplication}, Sum: {sum}");
            Console.WriteLine($"Substraction: {multiplication - sum}.");
            Console.WriteLine("Task Completed ;)");
        }
    }
}
