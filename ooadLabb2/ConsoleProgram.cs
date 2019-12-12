using System;
using System.Collections.Generic;
using ooadLabb2.Models;
using ooadLabb2.Services;

namespace ooadLabb2
{
    public class ConsoleProgram
    {
        private IAstronautService<JsonModel> astroService;

        public ConsoleProgram(IAstronautService<JsonModel> astroService)
        {
            this.astroService = astroService;
        }

        public void Run()
        {
            Console.WriteLine("Press ENTER to get the astronauts that are currently in space!");
            Console.ReadLine();
            printAstronautsInSpace();
            Console.Write("\nPress ENTER to quit");
            Console.ReadLine();
            Console.WriteLine("Bye!");
        }

        private void printAstronautsInSpace()
        {
            Console.WriteLine("Loading...\n");
            var jsonToAstronaut = new JsonToAstronautAdapter(astroService);
            var list = jsonToAstronaut.GetAstronautsInSpace();
            Console.WriteLine("The following people are in space right now: ");
            foreach (var astronaut in list)
            {
                Console.WriteLine("Name: " + astronaut.Name + ", On: " + astronaut.Craft);
            }
        }
    }
}