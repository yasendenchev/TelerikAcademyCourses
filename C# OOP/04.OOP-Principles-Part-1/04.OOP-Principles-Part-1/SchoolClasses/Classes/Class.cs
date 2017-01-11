using SchoolClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class Class : IClass
    {
        private string id;
        private List<Student> students;
        private List<Teacher> teachers;
        private List<string> comments;

        public Class(string id, List<Student> students, List<Teacher> teachers,List<string> comments = null)
        {
            this.id = id;
            this.students = students;
            this.teachers = teachers;
            this.comments = comments;

        }

        #region Properties
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
        #endregion


        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
        }
    }
}
