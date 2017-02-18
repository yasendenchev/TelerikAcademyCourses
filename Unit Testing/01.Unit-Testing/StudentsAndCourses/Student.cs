using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndCourses
{
    public class Student
    {
        private readonly string name;
        private readonly int? id;

        public Student(string name, int? id)
        {
            else
            {
                this.name = name;
                this.id = id;
                School.StudentIds.Add(this.id);
            }

        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
        }
    }
}
