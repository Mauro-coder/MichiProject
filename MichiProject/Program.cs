//#########################################
//# Inspirado en te lo expico con gatitos #
//#########################################


// Un using es...
using System;
using MichiProject.Animal;

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
            Redirigir executeExample = new Redirigir();
            executeExample.Redirigir_();


        }
    }
}

