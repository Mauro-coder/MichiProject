using System;
using System.Collections.Generic;
using System.Text;

namespace MichiProject
{
    class ExecutePilarExample
    {
        public void PilarsPOO()
        {
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    // Instanciar y asignar propiedades
                    Cat snowBall = new Cat()
                    {
                        Name = "Bola de nieve",
                        IsHungry = true,
                        IsTired = true,
                        Message = "Prrrrrrrrrrrrr :3",
                        Age = 4,
                        Color = "Blanco",
                        Size = "Mediano",
                        Weight = 5,
                    };
                    Console.WriteLine("El gato " + snowBall.Name + "Tiene las siguientes propiedades" + Environment.NewLine);
                    snowBall.PrintAllPropertys();
                    Console.WriteLine("Ejecutando hablar..." + Environment.NewLine);
                    snowBall.Talk();
                    Console.WriteLine("Ejecutando comer..." + Environment.NewLine);
                    snowBall.Eat();
                    Console.WriteLine("Ejecutando hablar..." + Environment.NewLine);
                    snowBall.Talk();

                    break;
                case "2":
                    Console.WriteLine("En construccion...");
                    break;
                case "3":
                    Console.WriteLine("En construccion...");
                    break;
                default:
                    break;
            }
        }


    }

}
