using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFourteen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Bro!");
            string str = "NiagaraFalls";
            string substr = str.Substring(str.Length - 1);
            Console.WriteLine(substr);
            Console.WriteLine("Task Completed ;)");
        }
    }
}
