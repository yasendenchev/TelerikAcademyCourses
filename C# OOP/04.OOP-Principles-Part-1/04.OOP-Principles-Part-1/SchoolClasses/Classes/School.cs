using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses.Classes
{
    class School
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

    }
}
