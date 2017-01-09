using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public static class Extensions
    {
        public static Student[] FilterStudentsByName(this Student[] students)
        {
            var filtered = new List<Student>();

            foreach (var student in students)
            {
                if (student.FirstName.CompareTo(student.LastName) < 0)
                {
                    filtered.Add(student);
                }
            }
            

            return filtered.ToArray();
        }
    }
}
