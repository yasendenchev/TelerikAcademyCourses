using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Dog : Animal
    {
        public Dog(string name, int age, Gender sex) : base(name, age, sex)
        {
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"BALO BALO, my name is {this.Name}!");
        }
    }
}
