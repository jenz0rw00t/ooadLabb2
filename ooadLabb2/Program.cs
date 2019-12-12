using System;
using ooadLabb2.Models;
using ooadLabb2.Services;

namespace ooadLabb2
{
    class Program
    {
        static void Main(string[] args)
        {
            var astroService = new AstronautService<JsonModel>(new NewsoftJsonParser());
            var consoleProgram = new ConsoleProgram(astroService);
            consoleProgram.Run();
        }
    }
}
