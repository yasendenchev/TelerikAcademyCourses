using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Startup
    {
        static void Main(string[] args)
        {

            var myStudents = new List<Student>();

            myStudents.Add(new Student("Ailqk", "Bichov", 35));
            myStudents.Add(new Student("Pesho", "Peshov", 25));
            myStudents.Add(new Student("Petkan", "Peshov", 22));
            myStudents.Add(new Student("Sasho", "Hristov", 23));
            myStudents.Add(new Student("Tommy", "Georgiev", 17));
            Console.WriteLine("Students whose first name is before their last name alphabetically:");
            Student[] filteredStudents = myStudents.ToArray();
            filteredStudents = filteredStudents.FilterStudentsByName();

            foreach (var student in filteredStudents)
            {
                Console.WriteLine(student.FirstName);
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine("Same done with LINQ:");

            var filteredByNames = from s in myStudents
                         where s.FirstName.CompareTo(s.LastName) < 0
                         select s;

            foreach (var student in filteredByNames)
            {
                Console.WriteLine(student.FirstName);
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine("Students with age between 18 and 24");

            var filteredByAge = from s in myStudents
                                where s.Age < 24 && s.Age > 18
                                select s;

            foreach (var student in filteredByAge)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} - {student.Age}");
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine("Students sorted by first and last name in descending order");

            var studentsInDescending = myStudents.OrderByDescending(Student => Student.FirstName).ThenByDescending(Student => Student.LastName);

            foreach (var student in studentsInDescending)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine("Same done with LINQ:");

            var studentsDescending = from s in myStudents
                                     orderby s.FirstName descending, s.LastName descending
                                     select s;

            foreach (var student in studentsDescending)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
        }
    }
}
