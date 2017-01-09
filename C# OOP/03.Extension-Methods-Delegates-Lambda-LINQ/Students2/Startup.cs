using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students2
{
    class Startup
    {
        static void Main(string[] args)
        {

            Group math = new Group(2, "Math");
            Group it = new Group(1, "IT");
            Group law = new Group(3, "Law");

            List<Student> students = new List<Student>();

            students.Add(new Student("Ivan", "Geshov", "114506", "02948564", "ivangeshov@abv.bg", new List<int> { 2, 4, 5, 4, 6 }, math));
            students.Add(new Student("Georgi", "Nikol", "9644506", "02948564", "qkataduparabby@gmail.com", new List<int> { 2, 4, 5, 4, 6 }, law));
            students.Add(new Student("Iz", "Dislav", "696969", "069948564", "comingcloser@guve4.bg", new List<int> { 2, 4, 5, 4, 6 }, math));
            students.Add(new Student("Todor", "Kableshkov", "135506", "052948564", "tod0r4o@abv.bg", new List<int> { 2, 4, 1, 3, 4 }, it));

            Console.WriteLine("Extract students from group number 2:");
            Console.WriteLine();
            var group2 = from s in students
                         where s.Group.GroupNum == 2
                         orderby s.FirstName ascending
                         select s;

            foreach (var student in group2)
            {
                student.PrintInfo(student);
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Extract students from group number 2 with extension methods:");
            Console.WriteLine();

            List<Student> group2Students = students.ExtractStudentsFromGroup2();

            foreach (var student in group2Students)
            {
                student.PrintInfo(student);
                Console.WriteLine();
            }


            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Extract students that have email in abv.bg");
            Console.WriteLine();

            var abvStudents = from s in students
                              where s.Email.Contains("abv.bg")
                              select s;

            foreach (var student in abvStudents)
            {
                student.PrintInfo(student);
            }


            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Extract students with phones in Sofia");
            Console.WriteLine();

            var studentsFromSofia = from s in students
                                    where s.PhoneNum.StartsWith("02")
                                    select s;

            foreach (var student in studentsFromSofia)
            {
                student.PrintInfo(student);
                Console.WriteLine();
            }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Extract students with at least one excellent mark");
            Console.WriteLine();

            var studentsWithExcellentGrade = from s in students
                                    where s.Marks.Contains(6)
                                    select new { Name = s.FirstName + " " + s.LastName, Marks = s.Marks };

            foreach (var student in studentsWithExcellentGrade)
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Marks: ");

                foreach (var mark in student.Marks)
                {
                    Console.Write($"{mark} ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Extract students with two marks 2");
            Console.WriteLine();

            var studentsWith2BadGrades = new List<Student>();

            studentsWith2BadGrades = students.ExtractStudentsWithGrade2();

            foreach (var student in studentsWith2BadGrades)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }



            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Extract marks of students from the year of 2006");
            Console.WriteLine();

            var studentsFrom2006 = from s in students
                                   where s.FacultyNum[4] == '0' && s.FacultyNum[5] == '6'
                                   select new { Marks = s.Marks };

            foreach (var student in studentsFrom2006)
            {
                foreach (var mark in student.Marks)
                {
                    Console.Write($"{mark} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Extract students from math group");
            Console.WriteLine();

            var mathStudents = from s in students
                               where s.Group.DeptName == "Math"
                               select new { Name = s.FirstName + " " + s.LastName };

            string mathStudentsAsString = String.Join(" ", mathStudents.Select(x => x.Name));
            Console.WriteLine(mathStudentsAsString);

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Group students by group number");
            Console.WriteLine();

            var groupedByGroupNum = from s in students
                         where s != null
                         orderby s.Group.GroupNum
                         group s by s.Group.GroupNum;
            foreach (var group in groupedByGroupNum)
            {
                Console.WriteLine($"Group number {group.Key} has {group.Count()} student/s:");
                foreach (var student in group)
                {
                    Console.WriteLine(student.FirstName + " " + student.LastName);
                }
                Console.WriteLine();
            }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Group students by group name");
            Console.WriteLine();

            var groupedByGroupName = students.GroupByGroupName();

            foreach (var group in groupedByGroupName)
            {
                Console.WriteLine($"Group {group.Key} has {group.Count()} student/s:");
                foreach (var student in group)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                }
                Console.WriteLine();
            }
        }

    }
}
