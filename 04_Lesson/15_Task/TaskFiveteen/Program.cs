using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFiveteen
{
    internal class Program
    {
        static void Main()
        {
            string[] words;
            words = new string[] { "word1", "word2", "word3", "word4", "word5"};
            foreach (string word in words)
            Console.Write(word + " ");
            Console.Write("\nTotal Number of Elements: ");
            Console.Write(words.Length);
        }
    }
}
