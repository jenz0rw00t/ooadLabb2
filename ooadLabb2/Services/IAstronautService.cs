using System.Collections.Generic;
using ooadLabb2.Models;

namespace ooadLabb2.Services
{
    public interface IAstronautService
    {
        public List<Astronaut> GetAstronautsInSpace();
    }
}