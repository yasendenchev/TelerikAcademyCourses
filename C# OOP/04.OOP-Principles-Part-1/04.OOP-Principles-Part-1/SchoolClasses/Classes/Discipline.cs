using SchoolClasses.Contracts;
using System.Collections.Generic;

namespace SchoolClasses
{
    public class Discipline : IDiscipline
    {
        private string name;
        private int lectures;
        private int excercises;
        private List<string> comments;
        

        public Discipline(string name, int lectures, int excercises)
        {
            this.Name = name;
            this.Lectures = lectures;
            this.Excercises = excercises;
            this.Comments = new List<string>();
        }

        public Discipline(string name, int lectures, int excercises, List<string> comments)
        {
            this.Name = name;
            this.Lectures = lectures;
            this.Excercises = excercises;
            this.Comments = comments;
        }
        

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

        
        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
        }
    }
}
