using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TaskOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Dictionary<string, string> CityAndCapital = new Dictionary<string, string>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter Name of the Country pls: ");
                string City = Console.ReadLine();
                Console.WriteLine("And write Capital of the City: ");
                string Capital = Console.ReadLine();
                CityAndCapital.Add(City, Capital);
            }
            // Time
        }
    }
}
