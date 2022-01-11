using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Bro!");
            Console.WriteLine("Now you will write 2 parameter, I mean width and height and You must be find a Rectangular's Area and Perimeter!");
            Console.Write("Width : ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Height : ");
            int height = Convert.ToInt32(Console.ReadLine());
            Parameters(width, height);
        }

        public static void Parameters(int width, int height)
        {
            int area = width * height;
            int perimeter = 2 * (width + height);
            Console.WriteLine($"Chosen parameters: Width: {width}, Height: {height}");
            Console.WriteLine($"Area: {area} , Perimeter: {perimeter}");
            Console.WriteLine("Task Completed ;)");
        }
    }
}
