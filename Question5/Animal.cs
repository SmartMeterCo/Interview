using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Question5
{
    public class Animal
    {
        public string AnimalType { get; set; }
        public string AnimalSound;

        public Animal(string animalType)
        {
            AnimalType = animalType;
        }
        public void MakeSound()
        {
            if (AnimalSound == null)
            {
                switch (AnimalType)
                {
                    case "Cat":
                        Console.WriteLine("Meow");
                        AnimalSound = "Meow";
                        break;
                    case "Dog":
                        Console.WriteLine("Woof");
                        AnimalSound = "Woof";
                        break;
                    case "Bird":
                        Console.WriteLine("Tweet");
                        AnimalSound = "Tweet";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine(AnimalSound);
            }
        }
    }
}
