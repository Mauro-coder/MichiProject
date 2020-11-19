using System;

namespace MichiProject.Species
{
    public class Bird: Animal.Animal
    {
        public Bird(string name, string color) : base(name, color)
        {
        }

        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }
}