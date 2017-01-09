using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students2
{
   public static class Extensions
    {
        public static List<Student> ExtractStudentsFromGroup2(this List<Student> students)
        {
            var result = new List<Student>();

            foreach (var student in students)
            {
                if (student.Group.GroupNum == 2)
                {
                    result.Add(student);
                }
            }

            result = result.OrderBy(order => order.FirstName).ToList();

            return result;
        }
        
        public static List<Student> ExtractStudentsWithGrade2(this List<Student> students)
        {
            var result = new List<Student>();

            result = students.Where(x => x.Marks.Count(y => y == 2) == 2).ToList();

            return result;
        }

        public static IEnumerable<IGrouping<string, Student>> GroupByGroupName(this List<Student> students)
        {
            

            var result = students.GroupBy(x => x.Group.DeptName);

            return result;
        }
    }

}
