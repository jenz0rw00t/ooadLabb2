using System;
using ooadLabb2.Services;

namespace ooadLabb2
{
    public class ConsoleProgram
    {
        private IAstronautService astroService;

        public ConsoleProgram(IAstronautService astroService)
        {
            this.astroService = astroService;
        }

        public void Run()
        {
            Console.WriteLine("Press enter to get the astronauts that are currently in space");
            Console.ReadLine();
            printAstronautsInSpace();
            Console.Write("\nPress enter to quit");
            Console.ReadLine();
            Console.WriteLine("Bye!");
        }

        private void printAstronautsInSpace()
        {
            Console.WriteLine("Loading...\n");
            var list = astroService.GetAstronautsInSpace();
            Console.WriteLine("The following people are in space right now: ");
            foreach (var astronaut in list)
            {
                Console.WriteLine("Name: " + astronaut.Name + ", On: " + astronaut.Craft);
            }
        }
    }
}