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
        public string Age { get; set; }
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
                Console.WriteLine(Name + " Tiene hambre y no puede hablar");
            }
            else
            {
                Console.WriteLine(Message);
            }

        }
    }
}
