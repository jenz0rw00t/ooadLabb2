using System;
using System.Collections.Generic;
using ooadLabb2.Models;

namespace ooadLabb2.Services
{
    //An adapter to change the object from DTO(JsonModel) to Astronaut
    public class JsonToAstronautAdapter : IAstronautService<List<Astronaut>>
    {
        private IAstronautService<JsonModel> astronautService;

        public JsonToAstronautAdapter(IAstronautService<JsonModel> astronautService)
        {
            this.astronautService = astronautService;
        }

        public List<Astronaut> GetAstronautsInSpace()
        {
            return astronautService.GetAstronautsInSpace().People;
        }
    }
}
