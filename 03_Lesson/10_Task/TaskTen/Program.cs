using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Bro!");
            Console.WriteLine("Now you will must be set the Algorithm that deletes gaps between words. For example: 'hello my name is Mina'!");
            Console.WriteLine("Write a Phrase:");
            string a = Convert.ToString(Console.ReadLine());
            string result = GapDeleteMethod(a);
        }
        public static string GapDeleteMethod(string a)
        {
            string[] words = a.Split(' ');
            foreach (var word in words)
            {
                System.Console.Write($"{word}");
            }
            return a;
        }
    }
}
