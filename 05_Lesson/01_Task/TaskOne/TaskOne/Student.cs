
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    internal class Student
    {
        public string FullNames;
        public string GroupNumbers;
        public int Ages;
        public Student(string FullName, string GroupNumber, int Age)
        {
            this.FullNames = FullName;
            this.GroupNumbers = GroupNumber;
            this.Ages = Age;
        }
        public static int BirthYearMethod(Student student)
        {
            return DateTime.Now.Year - student.Ages;
        }
        public static void ShowStudentMethod(string ThisGroup, Student[] student)
        {
            foreach (var item in student)
            {
                if (item.GroupNumbers == ThisGroup)
                {
                    Console.WriteLine(item.FullNames);
                }

            }
        }
    }
}
