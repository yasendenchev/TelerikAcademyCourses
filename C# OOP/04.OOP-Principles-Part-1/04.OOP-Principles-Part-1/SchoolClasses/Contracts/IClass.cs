using System.Collections.Generic;

namespace SchoolClasses.Contracts
{
    interface IClass
    {
        string Id { get; set; }
        List<Teacher> Teachers { get; }
        List<Student> Students { get; }

    }
}
