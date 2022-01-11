using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSix
{
    internal class Program
    {
        static void Main(String[] arg)
		{
			Console.WriteLine("Hello Bro!");
			int[] nums = { 1, 2, 3, 6, 7, 8, 23, 78, 34, 12 };

			int highestNums = maximum(nums);

			Console.WriteLine($"The highest Num is: {highestNums}");
			Console.WriteLine("Task Completed ;)");
		}
		public static int maximum(int[] numbers)
		{
			int maxSoFar = numbers[0];

			foreach (int num in numbers)
			{
				if (num > maxSoFar)
				{
					maxSoFar = num;
				}
			}
			return maxSoFar;
		}
    }
}
