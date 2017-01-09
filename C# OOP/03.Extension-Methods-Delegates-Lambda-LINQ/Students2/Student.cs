using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students2
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private string facultyNum;
        private string phoneNum;
        private string email;
        private List<int> marks;
        private Group group;

        public Student(string firstName, string lastName, string facultyNum, string phoneNum, string email, List<int> marks, Group group)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.facultyNum = facultyNum;
            this.phoneNum = phoneNum;
            this.email = email;
            this.marks = marks;
            this.group = group;
        }

        #region Properties
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.lastName = value;
            }
        }

        public string FacultyNum
        {
            get
            {
                return this.facultyNum;
            }

            set
            {
                this.facultyNum = value;
            }
        }

        public string PhoneNum
        {
            get
            {
                return this.phoneNum;
            }

            set
            {
                this.phoneNum = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                this.email = value;
            }
        }

        public List<int> Marks
        {
            get
            {
                return this.marks;
            }

            set
            {
                this.marks = value;
            }
        }

        public Group Group
        {
            get
            {
                return this.group;
            }

            set
            {
                this.group = value;
            }
            #endregion
        }

        public void PrintInfo(Student student)
        {
            Console.Write(
                $"Name: {this.firstName} {this.lastName} \nF.Num: {this.facultyNum} \nPhone: {this.phoneNum} \nEmail: {this.email} \nGroup Department: {this.group.DeptName} \nGroup number: {this.group.GroupNum} \nMarks: ");

            foreach (var mark in this.marks)
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine();
        }
    }
}
