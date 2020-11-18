using System;
using System.Collections.Generic;
using System.Text;

namespace MichiProject
{
    class ExecuteExample
    {
        public void PilarsPOO()
        {
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("selected 1");
                    break;
                case "2":
                    Console.WriteLine("selected 2");
                    break;
                case "3":
                    Console.WriteLine("selected 3");
                    break;
                default:
                    break;
            }
        }


    }

}
