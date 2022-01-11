using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Bro!");
            string before = ("NiagaraFalls");
            string after = "";
            for (int i = 0; i < before.Length; i++)
            {
                if (!after.Contains(before[i]))
                {
                    after += before[i];
                }
            }
            Console.WriteLine($"Before: {before}");
            Console.WriteLine($"After: {after}"); // Result > NiagrFls
            Console.WriteLine("Task Completed ;)");
        }
    }
}
