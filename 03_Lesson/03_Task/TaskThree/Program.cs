using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskThree
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Hello Bro!");

            // StepOne
            Console.WriteLine("When text isn't Palindrome"); 
            string beforeOne = "NiagaraFalls";
            string afterOne = string.Empty;
            for (int i = beforeOne.Length - 1; i >= 0; i--)
            {
                afterOne += beforeOne[i];
            }
            if (beforeOne == afterOne)
            {   
                Console.WriteLine($"Before: {beforeOne},");
                Console.WriteLine($"After: {beforeOne} is Palindrome."); // Result > UnCorrect
            }
            else
            {
                Console.WriteLine($"Before: {beforeOne},");
                Console.WriteLine($"After: {beforeOne} isn't Palindrome."); // Result > Correct
            }

            // StepTwo
            Console.WriteLine("When text is Palindrome.");
            string beforeTwo = "NiagaraaragaiN";
            string afterTwo = string.Empty;
            for (int i = beforeTwo.Length - 1; i >= 0; i--)
            {
                afterTwo += beforeTwo[i];
            }
            if (beforeTwo == afterTwo)
            {   
                Console.WriteLine($"Before: {beforeTwo},");
                Console.WriteLine($"After: {beforeTwo} is Palindrome."); // Result > Correct
            }
            else
            {
                Console.WriteLine($"Before: {beforeTwo},");
                Console.WriteLine($"After: {beforeTwo} isn't Palindrome."); // Result > UnCorrect
            }
            
            Console.WriteLine("Task Completed ;)");
        }
    }
}
