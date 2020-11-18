// La herencia es crear una clase apartir de otra ya existente 
using System;
using System.Collections.Generic;
using System.Text;

namespace MichiProject
{
    class Feline
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int Age { get; set; }
        public string Message { get; set; }
        public double Weight { get; set; }
        public bool IsTired { get; set; }
        public bool IsHungry { get; set; }

        public void Sleep()
        {
            IsTired = false;
            IsHungry = true;
        }

        public void Eat()
        {
            IsTired = true;
            IsHungry = false;
        }

        public void Talk()
        {
            if (IsHungry)
            {
                Console.WriteLine(Name + " tiene demasiada hambre para hablar");
                Console.WriteLine(Environment.NewLine);

            }
            else
            {
                Console.WriteLine(Message);
            }
        }

        public void PrintAllPropertys()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Size: " + Size);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Message: " + Message);
            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine("IsTired: " + IsTired);
            Console.WriteLine("IsHungry: " + IsHungry);
            Console.WriteLine(Environment.NewLine);
        }
    }
}
