﻿#region[Using] 
using System; // Un using es...
using System.Collections.Generic;
using System.Text;
#endregion[Using]


namespace MichiProject // Un namespace es...
{
    class Print /* Una clase es ...
                   como un molde de galletas o los planos de una casa */
    {

        // add a language selector here 
        public void PrintMenu() /* Un metodo es...
                                   una funcionalidad de una clase que le permite hacer una acción específica,
                                   (opcionalmente un metodo puede recibir y/o enviar inormacion adicional)  */
        {

            Console.WriteLine("Hola michi usuario");
            Console.WriteLine("Selecciona que ejemplo deseas ejecutar:");
            Console.WriteLine("1- Herencia");
            Console.WriteLine("2- Encapsulamiento");
            Console.WriteLine("3- Polimorfismo");
            string option = Console.ReadLine();
            Console.WriteLine("input: " + option);

            // Return
        }
    }
}
