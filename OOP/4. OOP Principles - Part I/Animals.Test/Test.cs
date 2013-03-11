//Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).
using System;
using System.Collections.Generic;
using System.Linq;
using Animals.Library;

namespace Animals.Test
{
    static class Test
    {

        static void Main()
        {
            Console.WriteLine(new String('*', 40));
            Console.WriteLine("Creating a string with dogs:");
            Dog[] dogs = new Dog[]{
                new Dog("Ivan",15,Sex.Male),
                new Dog("Pesho",7,Sex.Male),
                new Dog("Johny",6,Sex.Female),
                new Dog("Sharo",3,Sex.Male),
                new Dog("Gergana",4,Sex.Female),
                new Dog("Spaska",5,Sex.Female),
            };

            foreach (var dog in dogs)
            {
                Console.WriteLine(dog);
                dog.MakeSound();
                Console.WriteLine();
            }

            Console.WriteLine("Average age of the dogs:");
            Console.WriteLine(dogs.Average(a => a.Age));

            Console.WriteLine(new String('*', 40));
            Console.WriteLine("Creating a string with cats:");
            Cat[] cats = new Cat[]{
                new Cat("Ivan",3,Sex.Male),
                new Cat("Pesho",1,Sex.Male),
                new Tomcat("Johny",15),
                new Tomcat("Sharo",7),
                new Kitten("Gergana",3),
                new Kitten("Spaska",6),
            };

            foreach (var cat in cats)
            {
                Console.WriteLine(cat);
                cat.MakeSound();
                Console.WriteLine();
            }

            Console.WriteLine("Average age of the cats:");
            Console.WriteLine(cats.Average(a => a.Age));

            Console.WriteLine(new String('*', 40));
            Console.WriteLine("Making a list with animals:");
            List<Animal> animals = new List<Animal>(){
            new Cat("Gosho",1,Sex.Female),
            new Dog("Ivan",5,Sex.Male),
            new Frog("Spaska",9,Sex.Male),
            new Tomcat("Ivan",7),
            new Kitten("Spaska",1),
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
                animal.MakeSound();
                Console.WriteLine();
            }

            Console.WriteLine("Average age of the animals:");
            Console.WriteLine(animals.Average(a => a.Age));

        }
    }
}
