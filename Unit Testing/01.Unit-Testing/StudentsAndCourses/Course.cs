using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndCourses
{
    public class Course
    {
        private List<Student> students;

        public Course()
        {
            this.Students = new List<Student>();
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

        public void AddStudent(Student student)
        {
            if (this.students.Count == 30)
            {
                throw new Exception("You cannot add more students to this course.");
            }
            else
            {
                this.students.Add(student);
            }
        }
    }
}
