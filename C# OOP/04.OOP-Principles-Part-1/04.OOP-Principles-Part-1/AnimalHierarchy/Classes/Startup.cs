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
            animals.Add(new Kitten("Pisanka", 1));

            animals.Add(new Tomcat("Ivan4ou", 43));
            animals.Add(new Tomcat("Tommy", 4));

            animals.Add(new Dog("Izdislav", 65, Gender.Male));
            animals.Add(new Dog("Spot", 8, Gender.Male));

            animals.Add(new Frog("Paulo Coelho", 3600, Gender.Male));
            animals.Add(new Frog("Kermit the frog", 2, Gender.Male));
            
            
            double dogsAverageAge = (from a in animals
                                     where a.GetType() == typeof(Dog)
                                     select a.Age).Average();

            double tomcatsAverageAge = (from a in animals
                                        where a.GetType() == typeof(Tomcat)
                                        select a.Age).Average();

            double kittensAverageAge = (from a in animals
                                        where a.GetType() == typeof(Kitten)
                                        select a.Age).Average();

            double catsAverageAge = (from a in animals
                                     where a.GetType() == typeof(Kitten) || a.GetType() == typeof(Tomcat)
                                     select a.Age).Average();

            double frogsAverageAge = (from a in animals
                                      where a.GetType() == typeof(Frog)
                                      select a.Age).Average();

            foreach (var animal in animals)
            {
                animal.MakeNoise();
                Console.WriteLine();
            }

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"The average age of dogs is:\n{dogsAverageAge}");
            Console.WriteLine();
            Console.WriteLine($"The average age of tomcats is:\n{tomcatsAverageAge}");
            Console.WriteLine();
            Console.WriteLine($"The average age of kittens is:\n{kittensAverageAge}");
            Console.WriteLine();
            Console.WriteLine($"The average age of all kinds of cats is:\n{catsAverageAge}");
            Console.WriteLine();
            Console.WriteLine($"The average age of frogs is:\n{frogsAverageAge}");






        }
    }
}
