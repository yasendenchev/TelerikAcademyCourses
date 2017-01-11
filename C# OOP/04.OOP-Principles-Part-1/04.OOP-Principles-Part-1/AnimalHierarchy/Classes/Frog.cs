using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Frog : Animal
    {
        public Frog(string name, int age, Gender sex) : base(name, age, sex)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"JAB JAB, I don't know what kinds of sound frogs do! - {this.Name}, 2017");
        }
    }
}
