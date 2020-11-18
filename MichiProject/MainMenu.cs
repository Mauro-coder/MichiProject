#region[Using] 

using System;
using System.Collections.Generic;
using System.Text;
#endregion[Using]


namespace MichiProject
{
    // Una clase es como un molde de galletas o los planos de una casa
    class MainMenu
    {
        /* Este es ek metodo PrintMenu. Un metodo es:
            una funcionalidad de una clase que le permite hacer una acción específica,
            (opcionalmente un metodo puede recibir y/o enviar inormacion adicional) */
        public void PrintMenu()
        {

            Console.WriteLine("Hola michi usuario");
            Console.WriteLine("Selecciona que ejemplo deseas ejecutar:");
            Console.WriteLine("1- Herencia");
            Console.WriteLine("2- Encapsulamiento");
            Console.WriteLine("3- Polimorfismo");
            Console.WriteLine(Environment.NewLine);

        }
    }
}
