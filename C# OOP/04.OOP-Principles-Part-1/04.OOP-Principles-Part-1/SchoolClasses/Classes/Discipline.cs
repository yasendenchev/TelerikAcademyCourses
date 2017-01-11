using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class Discipline
    {
        private  string name;
        private int lectures;
        private int excercises;
        private List<string> comments;

        public Discipline(string name, int lectures, int excercises, List<string> comments = null)
        {
            this.name = name;
            this.lectures = lectures;
            this.excercises = excercises;
            this.comments = comments;
        }

        #region Properties
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public int Lectures
        {
            get
            {
                return this.lectures;
            }

            set
            {
                this.lectures = value;
            }
        }

        public int Excercises
        {
            get
            {
                return this.excercises;
            }

            set
            {
                this.excercises = value;
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
