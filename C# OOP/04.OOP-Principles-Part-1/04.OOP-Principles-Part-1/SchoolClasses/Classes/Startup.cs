using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Disciplines
            var math = new Discipline("math", 15, 30);
            var english = new Discipline("english", 40, 20);
            var biology = new Discipline("biology", 10, 5);

            //Students
            var students = new List<Student>();
            students.Add(new Student("Pesho", 1));
            students.Add(new Student("Vanko1", 2));
            students.Add(new Student("Peter Pan", 3));
            students.Add(new Student("Izdislav", 4));
            students.Add(new Student("GeorgiNikol", 5));
            students.Add(new Student("Doncho", 6));
            students.Add(new Student("St3ven", 7));

            //Teachers
            var teachers = new List<Teacher>();
            teachers.Add(new Teacher("Kuzmanova");
            
            var a = new Class("a",)

        }
    }
}
