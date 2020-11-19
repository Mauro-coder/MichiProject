//#########################################
//# Inspirado en te lo expico con gatitos #
//#########################################


// Un using es...
using System;
using MichiProject.Animal;
using MichiProject.Species;

// Un namespace es...
namespace MichiProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aqui se instancia la clase print (Se crea una nuevo objeto llamado print a partir de su molde o plano)
            MainMenu print = new MainMenu();
            // Posteriormentr se llama/invoca/usa el metodo print
            print.PrintMenu();

            // Nuevamente se instancia una clase y se usa uno de sus metodos 
            ExecutePilarExample executeExample = new ExecutePilarExample();
            executeExample.PilarsPOO();


            #region Just Temporal Comment, Delete It!

            Bird paloma = new Bird("Paloma", "White");
            paloma.Eat();
            paloma.Fly();
            #endregion

        }
    }
}

