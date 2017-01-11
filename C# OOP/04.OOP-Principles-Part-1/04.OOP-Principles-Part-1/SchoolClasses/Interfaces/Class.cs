using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses.Interfaces
{
    interface IClass
    {
        string Id { get; set; }
        List<Teacher> Teachers { get; set; }
        List<Student> Students { get; set; }

    }
}
