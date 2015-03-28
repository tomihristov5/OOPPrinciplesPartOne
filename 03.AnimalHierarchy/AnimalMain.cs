// Problem 3. Animal hierarchy
// Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are 
// Animals. All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are 
// described by age, name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a 
// specific sound.
// Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static 
// method (you may use LINQ).

namespace _03.AnimalHierarchy
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using _03.AnimalHierarchy.Animals;

    public static class AnimalMain
    {
        public static void PrintCollection(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        public static void Main()
        {
            Dog[] dogs = 
            {
                new Dog(3, "Mecho", AnimalSex.male),
                new Dog(1, "Sarah", AnimalSex.female),
                new Dog(6, "Shish", AnimalSex.male)
            };
            Console.WriteLine("My dogs:");
            PrintCollection(dogs);
            Console.Write("Dog makes sound: ");
            dogs[0].Sound();
            Console.WriteLine("Average age: {0:0.00}", dogs.Average(x => x.Age));

            Cat[] cats = 
            {
                new Cat(4, "Snejana", AnimalSex.female),
                new Cat(2, "Lusana", AnimalSex.female),
                new Cat(1, "Jonny", AnimalSex.male)
            };
            Console.WriteLine("My cats:");
            PrintCollection(cats);
            Console.Write("Cat makes sound: ");
            cats[0].Sound();
            Console.WriteLine("Average age: {0:0.00}", cats.Average(x => x.Age));

            Frog[] frogs = 
            {
                new Frog(1, "Karmit", AnimalSex.male),
                new Frog(7, "Uglyfrog", AnimalSex.female),
                new Frog(3, "Kyaya", AnimalSex.female)
            };
            Console.WriteLine("My frogs:");
            PrintCollection(frogs);
            Console.Write("Frog makes sound: ");
            frogs[0].Sound();
            Console.WriteLine("Average age: {0:0.00}", frogs.Average(x => x.Age));

            Kitten[] kittens =
            {
                new Kitten("Molly", 1),
                new Kitten("Lolly", 2)
            };
            Console.WriteLine("My kittens:");
            PrintCollection(kittens);
            Console.Write("Kitten makes sound: ");
            kittens[0].Sound();
            Console.WriteLine("Average age: {0:0.00}", kittens.Average(x => x.Age));

            Tomcats[] tomcats = 
            {
                new Tomcats("Jack", 2),
                new Tomcats("Shisho", 3)
            };
            Console.WriteLine("My tomcats:");
            PrintCollection(tomcats);
            Console.Write("Tomcat makes sound: ");
            tomcats[0].Sound();
            Console.WriteLine("Average age: {0:0.00}", tomcats.Average(x => x.Age));
        }
    }
}
