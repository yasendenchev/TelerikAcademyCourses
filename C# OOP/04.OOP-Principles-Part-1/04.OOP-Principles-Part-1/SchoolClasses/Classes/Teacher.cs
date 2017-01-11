using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class Teacher : Person
    {

        private List<Discipline> disciplines;


        public Teacher(string name, List<Discipline> disciplines, List<string> comments = null) : base(name, comments)
        {
            this.disciplines = disciplines;

        }

        public List<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }

            set
            {
                this.disciplines = value;
            }
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.Disciplines.Add(discipline);
        }
    }
}
