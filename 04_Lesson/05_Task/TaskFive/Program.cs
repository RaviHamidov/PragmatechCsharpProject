using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Bro!");
            Console.WriteLine("What month is it today: ");
            String month = Console.ReadLine();

            switch (month)
            {
                case "Yanvar":
                    Console.WriteLine("Yanvar ayinda yeqinki 31 gundu, sehv etmiremse Qis feslidi");
                    break;
                case "Fevral":
                    Console.WriteLine("Fevral ayinda yeqinki 30 gundu, sehv etmiremse Qis feslidi");
                    break;
                case "Mart":
                    Console.WriteLine("Mart ayinda yeqinki 31 gundu, sehv etmiremse Yaz feslidi");
                    break;
                case "Aprel":
                    Console.WriteLine("Aprel ayinda yeqinki 30 gundu, sehv etmiremse Yaz feslidi");
                    break;
                case "May":
                    Console.WriteLine("May ayinda yeqinki 30 gundu, sehv etmiremse Yaz feslidi");
                    break;
                case "Iyun":
                    Console.WriteLine("Iyun ayinda yeqinki 32 gundu, sehv etmiremse Yay feslidi");
                    break;
                case "Iyul":
                    Console.WriteLine("Yeqinki 32 gundu, sehv etmiremse Yay feslidi");
                    break;
                case "Avgust":
                    Console.WriteLine("Yeqinki 32 gundu, sehv etmiremse Yay feslidi");
                    break;
                case "Sentyabr":
                    Console.WriteLine("Yeqinki 32 gundu, sehv etmiremse Payiz feslidi");
                    break;
                case "Oktyabr":
                    Console.WriteLine("Yeqinki 32 gundu, sehv etmiremse Payiz feslidi");
                    break;
                case "Noyabr":
                    Console.WriteLine("Yeqinki 32 gundu, sehv etmiremse Payiz feslidi");
                    break;
                case "Dekabr":
                    Console.WriteLine("Yanvar ayinda yeqinki 31 gundu, sehv etmiremse Qis feslidi");
                    break;
                default:
                    Console.WriteLine(month + " Ae yekebas bu nedi ay adi daxil ele reqem yada ayri sey yox ozde duzgun yaz ilk herf boyuknen flan");
                    break;
            }
            Console.WriteLine("Task Completed;)");
        }
    }
}
