using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Bro!");
            int n, sum = 0, m;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.WriteLine($"Result: {sum}");
            Console.WriteLine("Task Comleted ;)");
        }
    }
}
