using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSeven
{
    internal class Program
    {
        static void Main(String[] arg)
		{
			Console.WriteLine("Hello Bro!");
			int[] nums = { 1, 2, 3, 6, 7, 8, 23, 78, 34, 12 };

			int lowestNums = minimum(nums);

			Console.WriteLine($"The lowhest Num is: {lowestNums}");
			Console.WriteLine("Task Completed ;)");
		}
		public static int minimum(int[] numbers)
		{
			int minSoFar = numbers[0];

			foreach (int num in numbers)
			{
				if (num < minSoFar)
				{
					minSoFar = num;
				}
			}
			return minSoFar;
		}
    }
}
