using System.Collections.Generic;

namespace SchoolClasses.Contracts
{
    interface ITeacher
    {
        List<Discipline> Disciplines { get; }
        void AddDiscipline(Discipline discipline);
    }
}
