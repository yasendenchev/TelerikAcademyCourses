using SchoolClasses.Contracts;
using System.Collections.Generic;

namespace SchoolClasses
{
    public class Student : Person, IStudent
    {
        private int classNum;

        public Student(string name) : base(name)
        {
            this.ClassNum = classNum;
        }

        public Student(string name, int classNum, List<string> comments = null) : base(name)
        {
            this.ClassNum = classNum;

        }

        public int ClassNum
        {
            get
            {
                return this.classNum;
            }

            set
            {
                this.classNum = value;
            }

        }
    }
}
