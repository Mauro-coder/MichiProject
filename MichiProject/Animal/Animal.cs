using System;

namespace MichiProject.Animal
{
    public class Animal : IAnimal
    {
        private string Name { get; }
        private string Color { get; }
        private HungerLevel HungerLevel { get; set; } = HungerLevel.Satisfied;

        protected Animal(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public string GetName()
        {
            Console.WriteLine($"Name: {Name}");
            return Name;
        }

        public string GetColor()
        {
            Console.WriteLine($"Color: {Color}");
            return Name;
        }

        public HungerLevel Eat()
        {
            HungerLevel = HungerLevel switch
            {
                HungerLevel.Starving => HungerLevel.Satisfied,
                HungerLevel.Satisfied => HungerLevel.Full,
                HungerLevel.Full => throw new Exception("I'm full!"),
                _ => throw new ArgumentOutOfRangeException($"Weak, I've died!")
            };

            Console.WriteLine($"HungerLevel: {HungerLevel:G}");
            return HungerLevel;
        }
    }
}