using SchoolClasses.Contracts;
using System;
using System.Collections.Generic;

namespace SchoolClasses
{
    public class Class : IClass, IComment
    {
        
        private string id;
        private List<Student> students;
        private List<Teacher> teachers;
        private List<string> comments;
        
        
        public Class(string id)
        {
            this.Id = id;
            this.Students = new List<Student>();
            this.Teachers = new List<Teacher>();
            this.Comments = new List<string>();
            NumClasses++;
        }

        public Class(string id, List<Student> students, List<Teacher> teachers, List<string> comments)
        {
            this.Id = id;
            this.Students = students;
            this.Teachers = teachers;
            this.Comments = comments;
            NumClasses++;

        }
        
        
        public string Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                this.students = value;
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }

            set
            {
                this.teachers = value;
            }
        }

        public List<string> Comments
        {
            get
            {
                return this.comments;
            }

            set
            {
                this.comments = value;
            }
        }

        public static int NumClasses { get; protected set; }
        

        
        public void AddTeacher(Teacher teacher)
        {
            this.Teachers.Add(teacher);
        }


        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }


        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
        }

        public void PrintInfo()
        {

            Console.WriteLine($"{this.Id} has {this.Students.Count} students and {this.Teachers.Count} teachers. \nThe Students in {this.Id} are:");
            foreach (var student in this.Students)
            {
                Console.WriteLine("------------------------------------------------------------------------------");
                Console.WriteLine($"#{student.ClassNum} - {student.Name}:");
                if (student.Comments.Count != 0)
                {
                    foreach (var comment in student.Comments)
                    {
                        Console.WriteLine(comment);
                    }
                }
                else
                {
                    Console.WriteLine("There aren't any comments about this student yet.");
                }
            }
            Console.WriteLine("------------------------------------------------------------------------------\n");
            Console.WriteLine($"The teachers who are teaching {this.Id} are:");
            foreach (var teacher in this.Teachers)
            {
                Console.WriteLine("------------------------------------------------------------------------------");
                Console.Write($"Teacher {teacher.Name} is teaching:\n");
                foreach (var discipline in teacher.Disciplines)
                {
                    Console.Write($"{discipline.Name} that has {discipline.Lectures} lectures and {discipline.Excercises} excercises\n");
                    Console.WriteLine();

                    Console.WriteLine($"Comments about {teacher.Name}'s discipline:");
                    if (discipline.Comments.Count != 0)
                    {
                        foreach (var comment in discipline.Comments)
                        {
                            Console.WriteLine($"{comment}");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("There aren't any comments about this discipline yet\n");
                    }
                }


                Console.WriteLine("Comments about this teacher:");
                if (teacher.Comments.Count != 0)
                {
                    foreach (var comment in teacher.Comments)
                    {
                        Console.WriteLine($"{comment}");
                    }
                }
                else
                {
                    Console.WriteLine("There aren't any comments about this teacher yet.");
                }
            }

            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Comments about this class:");
            if (this.Comments.Count != 0)
            foreach (var comment in this.Comments)
            {
                Console.WriteLine(comment);
            }
            else
            {
                Console.WriteLine($"There aren't any comments about {this.Id} yet.");
            }
            Console.WriteLine("\n==============================================================================");

        }
    }
}
