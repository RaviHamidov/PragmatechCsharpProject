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
            /*
            Demeli burda yazilan kodla file adindaki kimi ozumcundur burada zero to hero Hocanin kecdiyi
            derslerin topic lerin adlarin yazacam haqlarinda yazacam numune kodlar uzerinde isleyecem ve.s*/
            /*
            CLI languages
            For Loop
            Switch Statement
            Data Types
            Stack Value Type
            Heap Reference Type
            Stack vs Heap Memory
            */
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
            /*int t;
            Console.WriteLine("Nese yaz");
            t = int.Parse(Console.ReadLine());
            switch (t)
            {
                case 1:
                    Console.WriteLine("reqem 1 dir");
                    break;
                case 2:
                    Console.WriteLine("reqem 2 dir");
                    break;
                case 3:
                case 6:
                    Console.WriteLine("reqem 3 ve ya 6 dir");
                    break;
                default:
                    Console.WriteLine("yoe qeqes o del");
                    break;
            }*/

            /*int u;
            Console.WriteLine("Nese yaz");
            u = int.Parse(Console.ReadLine());
            switch (u)
            {
                case 10:
                    Console.WriteLine("reqem 10 dir");
                    switch (u-3)
                    {
                        case 7:
                            Console.WriteLine("daxil etdiyini eded -3 edende 7 qaldi");
                            switch (u - 4)
                            {
                                case 3:
                                    Console.WriteLine(" -4 edende 3 qaldi");
                                    break;
                            }
                            break;
                    }
                    break;
                case 7:
                    Console.WriteLine("reqem 2 dir");
                    break;
                case 8:
                case 9:
                    Console.WriteLine("reqem 3 ve ya 6 dir");
                    break;
                default:
                    Console.WriteLine("yoe qeqes o del");
                    break;
            }

            Console.ReadKey();*/
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
            /*
            Ref & out keyword C#
            Methods
            Type Casting
            Boxing and Unboxing
            */
            #region Ref&OutKeyword 
            /*int a = 5;
            int b = 7;

            Console.WriteLine("with out Ref Keyword");   
            Console.WriteLine(a);
            Console.WriteLine(b);
            ChangeNumberOne(ref a);
            Console.WriteLine("- - - - - - - - - - - - - -");
            Console.WriteLine("with Ref Keyword");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("- - - - - - - - - - - - - -");

            Console.WriteLine("with Out Keyword");
            int NumberOne;
            int NumberTwo = 42;
            var result = ChangeNumberTwo(out NumberOne, NumberTwo);
            Console.WriteLine(result);
            Console.WriteLine(NumberOne);
            Console.ReadKey();*/
            #endregion
            #region Methods
            /*int a = 5;
            int b = 7;
            int c = Sum(a, b);

            Console.WriteLine("The Value of the sum is " + c);
            Console.ReadKey();*/
            #endregion
            #region TypeCasting
            // value typler* arasinda kecid (*eyni deyer tipne sahib)
            /*birdeki upCast, downCast sohbeti var ordada demeli kicik value
            typedan boyuye kecende upcast, boyukden kiciye downcast deyilir*/
            // Meselen:
            /*int int_numberOne = 5;
            Console.WriteLine($"{int_numberOne} IntOne");
            long long_numberOne = int_numberOne;
            Console.WriteLine($"{long_numberOne} LongOne"); // that is a upCasting
            Console.WriteLine("- - - - - - - - - -");
            long long_numberTwo = 7;
            Console.WriteLine($"{long_numberTwo} LongTwo");
            int int_numberTwo = (int)long_numberTwo;
            Console.WriteLine($"{int_numberTwo} IntTwo");
            Console.ReadKey();*/
            #endregion
            #region Boxing and Unboxing
            /*Demeli Boxing Unboxing prosesi beledirki, value type nin reference type a kecirende
            boxing ancaq, reference type value type a kecirende unboxing*/
            // Meselen:
            /*int int_NumberThree = 7;
            object obj = int_NumberThree;
            Console.WriteLine(obj); // Burda bas veren prosese boxing deyilir
            Console.WriteLine("- - - - - -");
            object objTwo = 9;
            int int_NumberFour = (int)objTwo;
            Console.WriteLine(int_NumberFour);  // Burda olan ise unboxingdir
            Console.ReadKey();  */
            #endregion
            /*
            Method Overloading burdan Overloading-e qeder oxuyun
            String Methods
            String Methods 2
            Arrays
            Duplicate values
            */
            #region Method Overloading
            /*
            Demeli method overloading methodlarin eyni addan istifade edibde ferqli funksiyalar icra etmesine deyilir
            Bunu methodun void veya return olmasina gore yadaki parametrlerinin sayina gore ferqlendirmek olar
            */
            #endregion
            #region String Methods
            /*string myName = "My name is memmedEli";
            myName = myName.ToUpper();
            Console.WriteLine(myName);*/ // Step 1

            /*string myName = "My name is NoBody";
            myName = myName.ToLower();
            Console.WriteLine(myName);*/ // Step 2

            /*string myName = "     M y n a m e i s m e m e d e l i      ";
            Console.WriteLine(myName);
            myName = myName.Trim();
            Console.WriteLine(myName);*/

            /*string myName = " my name is memmedeli";
            bool isContains = myName.Contains("elimemmed");
            Console.WriteLine(isContains); // False*/

            /*string text = "NoBody";
            char[] charArray = text.ToCharArray();
            foreach (var c in charArray)
            {
                Console.WriteLine(c);
            }*/

            /*string textT = "No Body";
                   textT = textT.Substring(2,5);    
            Console.WriteLine(textT);*/

            /*string myName = "myName is memmefwfw";
            bool isContains = myName.StartsWith("my");
            Console.WriteLine(isContains);*/

            /*string memmed = "memmed kartof alma armuf";
            string[] whiteSpace = memmed.Split(' ');
            foreach (string oZudu in whiteSpace)
            {
                Console.WriteLine(oZudu);
            }*/


            Console.ReadKey();

            #endregion
            #region Arrays
            /*int[] evenNums = new int[5] { 2, 3, 4, 5, 6 };
            string[] oddNums = new string[2] { "memmed", "kartof" };
            // with var
            var evenNumsTwo = new int[] { 1, 2, 3, 4 };
            var evenNumsThree = new string[] { "memed", "kartof", "armud" };
            // short version with crreate array
            int[] evenNumb = new int[] { 1, 2, 4 };
            string[] oddNumb = new string[] { "memed", "kartof", "alma" };
            // Late initilazition 
            int[] evennumbers;
            evennumbers = new int[] { 1, 2, 3, 4, 5, 2, 12 };
            // or
            evennumbers = new int[5]; */

            #endregion
            #region Dublicate values
            #endregion
        }
        static void ChangeNumberOne(ref int number) // Ref Keyword
        {
            number = 42;
        }
        static int ChangeNumberTwo(out int NumberOne, int NumberTwo) // Out Keyword
        {
            NumberOne = 30;
            return NumberOne + NumberTwo;
        }
        static int Sum(int x ,int y) // Sum Method
        {
            int a = x;
            int b = y;
            int result = x + y;

            return result;
        }
    }
}
