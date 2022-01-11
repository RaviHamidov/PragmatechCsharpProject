using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Bro!");
            // bool a=(3+4*2==2*3)&&(true+false/2)
            /* The question is that the result and reason of the above statement should be clarified
               Result:False
               Reason:The result is False, because if the result of the first side of 
               the expression is "False", if the first side is "False" according to the && expression,
               there is no need to calculate the second side, and therefore the total result is "False".
             */
            Console.WriteLine("Task Completed ;)");
        }
    }
}
