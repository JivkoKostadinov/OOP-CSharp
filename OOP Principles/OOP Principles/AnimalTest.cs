using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fauna;

//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.
//Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface).
//Kittens and tomcats are cats. All animals are described by age, name and sex.
//Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
//Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

class AnimalTest
{
    static void Main()
    {
        Cat[] cats = new Cat[]{
            new Cat(2, "Kiti", SexType.Male),
            new Cat(3, "Kiti1", SexType.Male),
            new Cat(6, "Kiti2", SexType.Male),
            new Kitten(1, "Pisana", SexType.Female),
            new Kitten(6, "Pisana1", SexType.Female),
            new Tomcat(7, "Pisan4o", SexType.Male)
        };

        Dog[] dogs = new Dog[]{
            new Dog(4, "Sharo", SexType.Male),
            new Dog(8, "Sharo1", SexType.Male),
            new Dog(12, "Sharo2", SexType.Male)
        };

        Frog[] frogs = new Frog[]{
            new Frog(5, "Jaburana", SexType.Female),
            new Frog(9, "Jaburana1", SexType.Female)
        };

        Console.WriteLine("Cats average age: " + Animal.AverageAge(cats).ToString("F2"));
        Console.WriteLine("Dogs average age: " + Animal.AverageAge(dogs).ToString("F2"));
        Console.WriteLine("Frogs average age: " + Animal.AverageAge(frogs).ToString("F2"));

    }
}
