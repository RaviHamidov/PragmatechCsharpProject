using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractiseMark_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            =======================
            # LessonMark_01

            CLI languages
            Loops
            Switch Statement
            Data Types
            Stack Value Type
            Heap Reference Type
            Stack vs Heap Memory
            =======================
            # LessonMark_02

            Ref & out keyword C#
            Methods
            Type Casting
            Boxing and Unboxing
            =======================
            # LessonMark_03

            Method Overloading
            String Methods
            Arrays
            Duplicate values
            =======================
            # LessonMark_04

            Use Params Keyword
            Class And Object
            =======================
            # LessonMark_05

            String vs StringBuilder
            Constructors
            =======================
            # LessonMark_06

            Static keyword
            =======================
            # LessonMark_07

            ArrayList
            =======================
            */

            Console.WriteLine("= = = = = = = For Loops = = = = = = =");
            #region ForLoops

            /*for (initializer; condition; iterator)
            {
                Code block
            }

            for (int q = 0; q < 10; q++)
            {
                Console.WriteLine("Q Result is: {0}", q);
            }
            Console.WriteLine("-----------------------");
            // or
            for (int w = 0; w < 10; w++)
                Console.WriteLine("W Result is: {0}", w);
            // If a code block contains a single statement, then you don't need to wrap it inside curly brackets {}.
            int e = 0;

            for (; ; )
            {
                if (e < 10)
                {
                    Console.WriteLine("E Result is: {0}", e);
                    e++;
                }
                else
                    break;
            }
            Console.WriteLine("-----------------------");
            // An initializer, Condition and Iterator sections are optional. You can initialize a variable before for loop, and Condition and Iterator can be defined inside a code block.
            for (double r = 1.01D; r < 1.10; r += 0.01D)
                Console.WriteLine("R Result is: {0}", r);
            Console.WriteLine("-----------------------");
            // The control variable for the for loop can be of any numeric data type such as double, decimal, etc.
            for (int t = 0; t < 10; t++)
            {
                if (t == 5)
                    break;
                Console.WriteLine("T Result is: {0}", t);
            }
            Console.WriteLine("-----------------------");
            // You can also exit from a for loop by using the break keyword
            for (int y = 0, u = 0; y + u < 5; y++, u++)
                Console.WriteLine("Y;U Result First: {0}, Second: {1}", y, u);
            Console.WriteLine("-----------------------");*/
            #endregion
            Console.WriteLine("= = = = = = = For Each Loops = = = = = = =");
            #region ForEachLoops
            #endregion
            Console.WriteLine("= = = = = = = While Loops = = = = = = =");
            #region WhileLoops
            #endregion
            Console.WriteLine("= = = = = = = Do While Loops = = = = = = =");
            #region DoWhileLoops
            #endregion
            Console.WriteLine("= = = = = = = If & Else Statement = = = = = = =");
            #region If&ElseStatement
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
            Console.WriteLine("= = = = = = = Switch Statement = = = = = = =");
            #region SwitchStatement
            // switch la practise demeli user dan reqem sorus eger 42 yazsa yazsin ki senden yoxdu ama basqa reqem yazsa desin ki agilli ol
            /*int i;
            Console.WriteLine("Write a Number from zero to ten");
            i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 5:
                    Console.WriteLine("Number is 5");
                    break;
                case 6:
                    Console.WriteLine("Number is 6");
                    break;
                default:
                    Console.WriteLine("You are stupid, Because you don't write my chosen numbers :)");
                    break;
            }

            int o;
            Console.WriteLine("Odd or Even pls check");
            o = int.Parse(Console.ReadLine());
            switch (o % 2)
            {
                case 0:
                    Console.WriteLine($"is {o} even value");
                    break;
                case 1:
                    Console.WriteLine($"is {o} odd value");
                    break;
            }

            Console.WriteLine("Write Switch:");
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
            }

            int p;
            Console.WriteLine("Write something");
            p = int.Parse(Console.ReadLine());
            switch (p)
            {
                case 1:
                    Console.WriteLine("Number is 1");
                    break;
                case 2:
                    Console.WriteLine("Number is 2");
                    break;
                case 3:
                case 6:
                    Console.WriteLine("Number is 3 or 6");
                    break;
                default:
                    Console.WriteLine("You are stupid, Because you don't write my chosen numbers :)");
                    break;
            }

            int a;
            Console.WriteLine("Write something");
            a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    switch (a - 3)
                    {
                        case 7:
                            Console.WriteLine("When chosen number -3, Result is 7");
                            switch (a - 4)
                            {
                                case 3:
                                    Console.WriteLine("When chosen number - 4, Result is 3");
                                    break;
                            }
                            break;
                    }
                    break;
                case 7:
                    Console.WriteLine("Number is 7");
                    break;
                case 8:
                case 9:
                    Console.WriteLine("Number is 8 or 9");
                    break;
                default:
                    Console.WriteLine("You are stupid, Because you don't write my chosen numbers :)");
                    break;
            }*/
            #endregion
            Console.WriteLine("= = = = = = = Ref & Out Keyword = = = = = = =");
            #region Ref&OutKeyword
            /*int b = 5;
            int c = 7;

            Console.WriteLine("with out Ref Keyword");
            Console.WriteLine(b);
            Console.WriteLine(c);
            ChangeNumberOne(ref b);
            Console.WriteLine("- - - - - - - - - - - - - -");
            Console.WriteLine("with Ref Keyword");
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine("- - - - - - - - - - - - - -");

            Console.WriteLine("with Out Keyword");
            int NumberOne;
            int NumberTwo = 42;
            var result = ChangeNumberTwo(out NumberOne, NumberTwo);
            Console.WriteLine(result);
            Console.WriteLine(NumberOne);*/
            #endregion
            Console.WriteLine("= = = = = = = Methods = = = = = = =");
            #region Methods
            /*int a = 5;
            int b = 7;
            int c = Sum(a, b);

            Console.WriteLine("The Value of the sum is " + c);
            Console.ReadKey();*/
            #endregion
            Console.WriteLine("= = = = = = = Type Casting = = = = = = =");
            #region TypeCasting
            // value typler* arasinda kecid (*eyni deyer tipne sahib)
            /*birdeki upCast, downCast sohbeti var ordada demeli kicik value
            typedan boyuye kecende upcast, boyukden kiciye downcast deyilir*/
            // Meselen:
            /*
            int int_numberOne = 5;
            Console.WriteLine($"{int_numberOne} IntOne");
            long long_numberOne = int_numberOne;
            Console.WriteLine($"{long_numberOne} LongOne"); // that is a upCasting
            Console.WriteLine("- - - - - - - - - -");
            long long_numberTwo = 7;
            Console.WriteLine($"{long_numberTwo} LongTwo");
            int int_numberTwo = (int)long_numberTwo;
            Console.WriteLine($"{int_numberTwo} IntTwo"); // and this one is downCasting
            */
            #endregion
            Console.WriteLine("= = = = = = = Boxing & Unboxing = = = = = = =");
            #region Boxing&UnBoxing
            /*Demeli Boxing Unboxing prosesi beledirki, value type nin reference type a kecirende
            boxing ancaq, reference type value type a kecirende unboxing*/
            // Meselen:
            /*
            int int_NumberThree = 7;
            object obj = int_NumberThree;
            Console.WriteLine(obj); // Burda bas veren prosese boxing deyilir
            Console.WriteLine("- - - - - -");
            object objTwo = 9;
            int int_NumberFour = (int)objTwo;
            Console.WriteLine(int_NumberFour);  // Burda olan ise unboxingdir
            */
            #endregion
            Console.WriteLine("= = = = = = = Method OverLoading = = = = = = =");
            #region MethodOverLoading
            /*int a = 9;
            int b = 6;
            int c = Add(a, b);

            Console.WriteLine("Method Overloading: " + c);*/
            #endregion
            #region StringMethods
            #endregion
            #region Arrays
            #endregion
            #region DublicateValues
            #endregion
            #region UseParamsKeyword
            #endregion
            #region Class&Objects
            #endregion
            #region String&StringBuilder
            #endregion
            #region Constructors
            #endregion
            #region StaticKeyword
            #endregion
            #region ArrayList
            #endregion
            #region non generic collection
            /*// non generic collection\

            // Fifo
            ArrayList arraylist = new ArrayList();
            arraylist.Add(5);
            arraylist.Add(6);
            arraylist.Add(7);
            arraylist.Add("ajkhflef");
            arraylist.Add(true);
            foreach (var item in arraylist)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(" - - - - - - - - - ");

            // Lifo
            Stack stack = new Stack();
            stack.Push(2);
            stack.Push("efjkw");
            stack.Push(true);
            stack.Push("push");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(stack.Pop() + " remove");

            Console.WriteLine(" - - - - - - - - - ");

            //Fifo
            Queue queue = new Queue();
            queue.Enqueue(2);
            queue.Enqueue(1);
            queue.Enqueue(4);
            queue.Enqueue(6);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(queue.Dequeue() + " bayira ");
            Console.WriteLine(queue.Peek() + " ba qaqan bunu secir ");

            Console.WriteLine("- - - - - - - - - ");

            // Lifo
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "Ravus");
            hashtable.Add(2, "Rehi");
            hashtable.Add(3, "Elmar");
            hashtable.Add("Memmedeli", "Elmar");

            foreach (var item in hashtable)
            {
                Console.WriteLine(item);
            }

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key + "  sosial mesafe  " + item.Value);
            }

            hashtable.Remove(2);

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key + "  sosial mesafe  " + item.Value);
            }

            Console.WriteLine("- - - - - - - - - ");

            // burda lofi fofi sobeti yodu
            SortedList numberler = new SortedList();
            numberler.Add(1, "memmedeli");
            numberler.Add(8, "alma");
            numberler.Add(3, null);
            numberler.Add(9, "kartof");
            numberler.Add(5, "memefdlkeflw");

            foreach (DictionaryEntry kvp in numberler)
            {
                Console.WriteLine("Key: {0}, Value: {1}",kvp.Key, kvp.Value);       
            }
            */

            // Task

            /*Stack stack = new Stack();
            stack.Push(12);
            stack.Push(122);
            stack.Push(124);
            stack.Push(166);

            Queue queue = new Queue();
            queue.Enqueue(12);
            queue.Enqueue(14);
            queue.Enqueue(16);
            queue.Enqueue(72);

            ArrayList array = new ArrayList();
            array.Add(12);
            array.Add(14);
            array.Add(17);
            array.Add(15);
            array.AddRange(stack);
            array.RemoveAt(5);
            array.AddRange(queue);

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }*/

            // opsm neyse buda praktika olsin sljbgfahbak 

            #endregion
            #region Generikolar

            /*List<int> list = new List<int>();
            list.Add(9);
            list.Add(3);
            list.Add(5);
            list.Add(7);

            List<int> list2 = new List<int>();
            list2.Add(93);
            list2.Add(34);
            list2.Add(556);
            list2.Add(79);

            list2.AddRange(list);

            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }*/

            /*foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.Remove(7);
            list.RemoveAt(2); 

            foreach (var item in list)
            {
                Console.WriteLine(item + " new"); 
            }*/

            /*Dictionary<int, string> pairs = new Dictionary<int, string>()
            {
                {1,"memmedeli" },
                {2,"memmedvelli" },
                {3,"wfwfwememmedvelli" }
            };

            if (pairs.ContainsKey(1)) ;
            {
                Console.WriteLine(pairs[1]);
            }

            pairs[1] = "kartof";

            if (pairs.ContainsKey(1)) ;
            {
                Console.WriteLine(pairs[1]);
            }*/
            #endregion

        }
        static int Sum(int x, int y) // Sum Method
        {
            int result = x + y;
            return result;
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
        static int Add(int a, int b)  //two int type Parameters method  
        {
            int result = a + b;
            return result;
        }
        static int Add(int a, int b, int c)  //three int type Parameters with same method same as above  
        {
            int result = a + b + c;
            return result;
        }
        static float Add(float a, float b, float c, float d)  //four float type Parameters with same method same as above two method 
        {
            float result = a + b + c + d;
            return result;
        }
    }
}
