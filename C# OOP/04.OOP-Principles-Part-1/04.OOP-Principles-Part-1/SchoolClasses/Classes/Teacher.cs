using SchoolClasses.Contracts;
using System.Collections.Generic;

namespace SchoolClasses
{
    public class Teacher : Person, ITeacher
    {

        private List<Discipline> disciplines;


        public Teacher(string name) : base(name)
        {
            this.Disciplines = new List<Discipline>();
        }

        public Teacher(string name, List<Discipline> disciplines, List<string> comments) : base(name)
        {
            this.Disciplines = disciplines;

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

        public void AddDiscipline(Discipline newDiscipline)
        {

            this.Disciplines.Add(newDiscipline);
        }
    }
}
