using System;

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
