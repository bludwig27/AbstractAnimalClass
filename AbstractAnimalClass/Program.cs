using System;
using System.Xml.Linq;

namespace AbstractAnimalClass
{
    class Program
    {
        abstract class Animal
        {
            public abstract string Name { get; set; }
            public abstract string Describe();
            public string whatAmI()
            {
                return "I am an animal";
            }
        }
        class Platypus : Animal
        {
            public override string Name { get; set; }
            public string Species { get; set; }
            public int Weight { get; set; }

            public Platypus()
            {
                Name = string.Empty;
                Species = "platypus";
                Weight = 0;
            }
            public Platypus(string name, string species, int weight)
            {
                Name = name;
                Species = species;
                Weight = weight;
            }
            public override string Describe()
            {
                return "I am a " + Species + ".\nMy name is " + Name + " and I weigh " + Weight + " kilograms.";
            }

        }
        static void Main(string[] args)
        {
            Platypus pam = new Platypus();
            pam.Name = "Pam";
            pam.Species = "platypus";
            pam.Weight = 2;

            Platypus pete = new Platypus("Pete","duck-billed platypus", 3);

            Console.WriteLine("Animal information:");
            Console.WriteLine(pam.Describe());
            Console.WriteLine();
            Console.WriteLine(pete.Describe());
        }
    }
}