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
            string Num = Console.ReadLine();
            SingleNum(Num);
        }
        static void SingleNum(string Num)
        {
            string val = "";
            int num = 0;
            Console.WriteLine("Evde qalmislar: ");
            for (int i = 0; i < Num.Length; i++)
            {
                val = Convert.ToString(Num[i]);
                num = Convert.ToInt32(val);
                if (num % 2 != 0)
                {
                    Console.WriteLine(num + " ");
                }
            }
            Console.ReadKey();

        }
    }   
}
