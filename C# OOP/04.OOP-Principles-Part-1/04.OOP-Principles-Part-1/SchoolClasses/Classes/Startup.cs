using System;

namespace SchoolClasses
{
    class Startup
    {
        static void Main(string[] args)
        {
            
            var classA = new Class("Class A");
            var classB = new Class("Class B");

            
            var math = new Discipline("Mathematics", 15, 30);
            var management = new Discipline("Management", 30, 60);
            var informatics = new Discipline("Informatics", 22, 16);

            
            var pesho = new Student("Pesho", 1);
            var vanko = new Student("Vanko1", 2);
            var peter = new Student("Peter Pan", 3);
            var izdislav = new Student("Izdislav", 4);
            var georgi = new Student("GeorgiNikol", 5);
            var kalin = new Student("Kalin", 6);
            var todor = new Student("Todor", 7);

            
            var kuzmanova = new Teacher("Kuzmanova");
            var uzunov = new Teacher("Uzunov");
            var evlogi = new Teacher("Evlogi");
            

            kuzmanova.AddDiscipline(management);
            uzunov.AddDiscipline(math);
            evlogi.AddDiscipline(informatics);

            classA.AddTeacher(kuzmanova);
            classA.AddTeacher(uzunov);

            classA.AddStudent(pesho);
            classA.AddStudent(vanko);
            classA.AddStudent(todor);
            classA.AddStudent(izdislav);
            
            

            classB.AddTeacher(evlogi);
            classB.AddTeacher(uzunov);

            classB.AddStudent(peter);
            classB.AddStudent(georgi);
            classB.AddStudent(kalin);

            //Students' comments
            vanko.AddComment("This guy fights a lot.");
            izdislav.AddComment("We need to find this guy.");
            georgi.AddComment("This girl with a boy's name keeps asking who is gonna BARA THE DUPARA.");
            pesho.AddComment("Just a regular guy. He gets mentioned a lot at Telerik and no one knows why.");

            //Teachers' comments
            uzunov.AddComment("This teacher likes getting up early in the morning and making his students get up even earlier to go to school.");
            uzunov.AddComment("He is an amazing teacher!");

            
            Console.WriteLine($"In our school there are {Class.NumClasses}");
            classA.PrintInfo();
            classB.PrintInfo();
            
        }
    }
}
