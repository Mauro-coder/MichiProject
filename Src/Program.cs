using System;

namespace MichiProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Print print = new Print(); /* Aqui se instancia la clase print 
                                          (Se crea una nuevo objeto llamado print a partir de su molde o plano) */

            print.PrintMenu(); /* Aqui se llama/invoca/usa el metodo print */
        }
    }
}
