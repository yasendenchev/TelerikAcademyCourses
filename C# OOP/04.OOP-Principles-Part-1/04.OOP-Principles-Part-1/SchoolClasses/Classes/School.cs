using System.Collections.Generic;

namespace SchoolClasses.Classes
{
    public class School
    {
        private List<Class> classes;

        public School(List<Class> classes)
        {
            this.classes = classes;
        }

        public List<Class> Classes
        {
            get
            {
                return this.classes;
            }

            set
            {
                this.classes = value;
            }
        }

        public void AddClass(Class schoolClass)
        {
            this.classes.Add(schoolClass);
        }
    }
}
