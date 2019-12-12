using System;
using ooadLabb2.Services;

namespace ooadLabb2
{
    class Program
    {
        static void Main(string[] args)
        {
            IAstronautService astroService = new AstronautService(new NewsoftJsonParser());
            var consoleProgram = new ConsoleProgram(astroService);
            consoleProgram.Run();
        }
    }
}
