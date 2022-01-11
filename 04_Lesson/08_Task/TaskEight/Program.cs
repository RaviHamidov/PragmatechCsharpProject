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
            int[] ChosenNums = { 1, 2, 3, 78, 34, 12, 6, 7, 8, 23, 78, 34, 12, 42 };
            SingleNums(ChosenNums);
        }
        static void SingleNums(params int[] repo)
        {
            int sum = 0;
            foreach (int num in repo)
            {
                if (num % 2 != 0)
                {
                    sum += num;
                }
            }
            Console.WriteLine("Result:" + sum);
            Console.ReadKey();
        }
    }
}
