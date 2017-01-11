using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Startup
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Kitten("Ivanka", 42));
            animals.Add(new Tomcat("Ivan4ou", 43));
            animals.Add(new Dog("Izdislav", 6000, Gender.Male));
            animals.Add(new Dog("Paulo Coelho", 35000, Gender.Male));

            foreach (var animal in animals)
            {
                animal.MakeSound();
            }

            double DogAverageAge = (from a in animals
                       select Dog)
                      .Average();
            Console.WriteLine(DogAverageAge);
        }
    }
}
