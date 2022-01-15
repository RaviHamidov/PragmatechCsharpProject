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
            Student[] students = new Student[2];
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Write your Name: ");
                string FullName = Console.ReadLine();
                Console.WriteLine("Write your ClassName: ");
                string GroupNumber = (Console.ReadLine());
                Console.WriteLine("Write your Age: ");
                int Age = Convert.ToInt32(Console.ReadLine());

                Student student = new Student(FullName, GroupNumber, Age);
                students[i] = student;
                Console.WriteLine($"Your BirthDay: {Student.BirthYearMethod(student)}");

            }
            Console.WriteLine("Write your GroupNumber");
            string GroupName = Console.ReadLine();
            Console.WriteLine($"In the Group memmbers sum is:{GroupSumMethod(GroupName, students)}");
            Student.ShowStudentMethod(GroupName, students);
        }

        public static int GroupSumMethod(string GroupName, Student[] student)
        {
            int SomeHumans = 0;
            foreach (var item in student)
            {
                if (item.GroupNumbers == GroupName)
                {
                    SomeHumans++;
                }
            }
            return SomeHumans;
        }

    }
}

