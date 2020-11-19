#region[Using] 
using System; // Un using es...
using System.Collections.Generic;
using System.Text;
#endregion[Using]


namespace MichiProject // 
{
    class Print /**/
    {
        public void PrintMenu() /* */
        {
            Console.WriteLine("Hi michi user");
            Console.WriteLine("Select an option to run:");
            Console.WriteLine("1- Herency");
            Console.WriteLine("2- Encapsulation");
            Console.WriteLine("3- polymorphism");
            string InputOption = Console.ReadLine();
        }
    }
}
