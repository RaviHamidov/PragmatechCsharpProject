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
            string before = "NiagaraFalls";
            string after = "";
            for (int i = 0; i < before.Length; i++)
            {
                after += Convert.ToString(before[before.Length - 1 - i]);
            }
            Console.WriteLine($"Before: {before},");
            Console.WriteLine($"After: {after}."); // Result > sllaFaragaiN
            Console.WriteLine("Task Comleted ;)");
        }
    }
}
