using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses.Interfaces
{
    interface IDiscipline
    {
        string Name { get; set; }
        int Lecture { get; set; }
        int Excercises { get; set; }
        List<string> Comments { get; set; }
    }
}
