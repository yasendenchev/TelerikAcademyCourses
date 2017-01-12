using SchoolClasses.Contracts;
using System.Collections.Generic;

namespace SchoolClasses
{
    public class Person : IComment
    {
        private string name;
        private List<string> comments;
        

        public Person(string name) : base()
        {
            this.Name = name;
            this.Comments = new List<string>();
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
