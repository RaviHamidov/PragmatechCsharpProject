using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IfElseStatementPractise
            /*oz ozume task olsun if else ile 10 qeder reqem , 10 ve 20 arasi reqem ve 20 den boyuk reqem daxil edende bize daxil olunan reqem haqqinda info veren program*/
            /*int n;
            Console.WriteLine("Demeli 0 dan 100 e qeder eded daxil edin .");
            n = int.Parse(Console.ReadLine());
            if (n < 10)
            {
                Console.WriteLine("10 dan kicikdir");
            }
            else if (n > 10 & n < 20)
            {
                Console.WriteLine(" 10 ve 20 arasindadir");
            }
            else
            {
                Console.WriteLine("20den boyukdur");
            }*/
            #endregion
            #region SwitchStatementPractise
            /*switch la practise demeli user dan reqem sorus eger 42 yazsa yazsin ki senden yoxdu ama basqa reqem yazsa desin ki agilli ol*/
            /*int x;
            Console.WriteLine("0 dan 10 e qeder eded daxil edin ");
            x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 5:
                    Console.WriteLine("reqem 5 dir");
                    break;
                case 6:
                    Console.WriteLine("reqem 6 dir");
                    break;
                default:
                    Console.WriteLine("yoe qeqes o del");
                    break;
            }*/

            /*int z;
            Console.WriteLine(" odd or even pls check");
            z = int.Parse(Console.ReadLine());
            switch (z % 2)
            {
                case 0:
                    Console.WriteLine($"is {z} even value");
                    break;
                case 1:
                    Console.WriteLine($"is {z} odd value");
                    break ;
            }*/

            /*Console.WriteLine("Wriite switch:");
            string statement = Console.ReadLine();
            switch (statement)
            {
                case "if else":
                    Console.WriteLine("This is not a switch");
                    break;
                case "switch":
                    Console.WriteLine("This is a switch");
                    break;
                case "memmedeli":
                    Console.WriteLine("This is not a switch");
                    break;
                default:
                    Console.WriteLine("This is not a switch");
                    break;
            }*/


            Console.ReadKey();
            #endregion
            #region ForLoopPractise
            /*for (initializer; condition; iterator)
            {
                // code block
            }*/

            /*for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Value of i: {0}", i);
            }*/

            /*int i = 0;

            for (; ; )
            {
                if (i <= 10)
                {
                    Console.WriteLine("Value of i: {0}", i);
                    i++;
                }
                else
                    break;
            }*/

            /* for (; ; )
             {
                 Console.Write(1);
             }*/

            /*for (double d = 1.01D; d < 1.10; d += 0.01D)
            {
                Console.WriteLine("Value of i: {0}", d);
            }*/

            /*for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("Value of i: {0}", i);
            }*/

            /*int i = 0, j = 5;
            for (Console.WriteLine($"Initializer: i={i}, j={j}");
                i++ < j--;
                Console.WriteLine($"Iterator: i={i}, j={j}"))
            {
            }*/

            /*for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break;

                Console.WriteLine("Value of i: {0}", i);
            }*/

            /*for (int i = 0, j = 0; i + j < 5; i++, j++)
            {
                Console.WriteLine("Value of i: {0}, J: {1} ", i, j);
            }*/

            /*for (int i = 0; i < 2; i++)
            {
                for (int j = i; j < 4; j++)
                    Console.WriteLine("Value of i: {0}, J: {1} ", i, j);
            }*/
            /*for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Result is a: {0}",i);
            }


            Console.ReadKey();*/
            #endregion
        }
    }

}