using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string before = "NiagaraFalls";
            Console.WriteLine("Hello Bro!");
            Console.WriteLine($"Before: {before},");
            Console.WriteLine($"After: {SubStringProduct(before, 7, 12)}."); // Result > Falls
            Console.WriteLine("Task Completed ;)");
        }
        public static string SubStringProduct(string before, int index, int end)
        {
            string after = "";
            for (int i = index; i < end; i++)
            {
                after += before[i];
            }
            return after;
        }
    }
}
