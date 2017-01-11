using StudentsAndWorkers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Student : Human,  IHuman, IStudent
    {
        private int grade;

        public Student(string fName, string lName, int grade) : base(fName, lName)
        {
            this.grade = grade;
        }



        public int Grade
        {
            get
            {
                return this.grade;
            }

            set
            {
                this.grade = value;
            }
        }
    }
}
