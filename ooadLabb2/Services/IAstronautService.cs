using System.Collections.Generic;
using ooadLabb2.Models;

namespace ooadLabb2.Services
{
    public interface IAstronautService<T>
    {
        public T GetAstronautsInSpace();
    }
}