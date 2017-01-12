using System;

namespace AnimalHierarchy
{
    class Cat : Animal
    {

        public Cat(string name, int age, Gender sex) : base(name, age, sex)
        {
        }


        public override void MakeNoise()
        {
            Console.WriteLine($"MIALO MIALO, my name is {this.Name}!");
        }
    }
}
