using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Cat : Animal
    {
        public Cat(string name, int age, Gender sex) : base(name, age, sex)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"MIALO MIALO, my name is {this.Name}!");
        }
    }
}
