using System;
using System.Collections.Generic;
using System.Net;
using ooadLabb2.Models;

namespace ooadLabb2.Services
{
    public class AstronautService : IAstronautService
    {
        private List<Astronaut> astronauts;
        private IJsonParser jsonParser;
        private readonly string url;

        public AstronautService(IJsonParser jsonParser)
        {
            this.jsonParser = jsonParser;
            url = "http://api.open-notify.org/astros.json";
        }

        public List<Astronaut> GetAstronautsInSpace()
        {
            var client = new WebClient();
            var json = client.DownloadString(url);

            JsonModel jsonObject = jsonParser.deserialize<JsonModel>(json);
            astronauts = jsonObject.People;

            return astronauts;
        }
    }
}
