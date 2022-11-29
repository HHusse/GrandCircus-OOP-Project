using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrandCircus.Animals;
using GrandCircus.CircusModel;
using GrandCircus.Presentation;

namespace GrandCircus
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Circus> circuses = new List<Circus>();
            Arena arena = new Arena();


            Circus circus = new Circus(arena, "Circus vargas");

            circus.Perform();
            Console.WriteLine("\n");


            Pause();
        }

        private static void Pause()
        {
            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
            Console.WriteLine();
        }
    }
}

