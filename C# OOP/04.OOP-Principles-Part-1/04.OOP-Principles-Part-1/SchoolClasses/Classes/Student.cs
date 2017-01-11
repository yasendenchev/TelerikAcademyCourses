using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class Student : Person
    {
        private int classNum;

        public Student(string name, int classNum, List<string> comments = null) : base(name, comments)
        {
            this.classNum = classNum;

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
