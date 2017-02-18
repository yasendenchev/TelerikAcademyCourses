using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndCourses
{
    public class School
    {
        private List<Student> students = new List<Student>();


        public List<Student> Students
        {
            get
            {
                return this.students;
            }
        }

        public void AddStudent(string name, int? id)
        {
            if (this.Students.Any(x => x.Id == id))
            {
                throw new ArgumentException($@"There are duplicate ID's");
            }
            else if (id == null)
            {
                throw new ArgumentNullException("Id cannot be null");
            }
            else if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name cannot be null");
            }
            else
            {
                this.students.Add(new Student(name, id));
            }
        }
    }
}
