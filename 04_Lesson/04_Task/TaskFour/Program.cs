using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                4)Console.Readline vasitesile ilə istifadəçinin yaşını daxil etməsini istəyin.
                İstifadəçinin yaşı 30 - dan kiçikdirsə istifadəçinin yaşının kvadratını ekrana çap edin
                Yaş 30 - 40 aralığındadırsa daxil edilən ədədin son rəqəmini ekrana çap edin
                Yaş 0 - dan kiçik vəya 100 - dən böyükdürsə ekrana "Düzgün məlumat daxil etməmisiniz" yazdırın
            */
            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 30 && age > 0)
            {
                double result = Math.Pow(age, 2);
                Console.WriteLine($"Your age's squares is: {result}");
            }
            else if (age > 30 && age < 40)
            {
                int result = age % 10;
                Console.WriteLine($"Your age's last digit is: {result}");
            }
            else if (age > 100 && age < 0)
            {
                Console.WriteLine("Düzgün məlumat daxil etməmisiniz");
            }
            else
            {
                Console.WriteLine("Yazdiqiniz eded hecbir serti odemir.");
            }
        }
    }
}
