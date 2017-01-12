using System.Collections.Generic;

namespace SchoolClasses.Contracts
{
    interface IDiscipline
    {
        string Name { get; }
        int Lectures { get; }
        int Excercises { get; }
        List<string> Comments { get; }
    }
}
