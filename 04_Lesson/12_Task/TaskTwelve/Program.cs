using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwelve
{
    internal class Program
    {
        public static void Main()
        {
            int[] arr = new int[] { 1, 2, 3, 6, 7, 8, 23, 78, 34, 12 };
            Array.Sort(arr);
            Array.Reverse(arr);
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
        }
    }
}
