using System;
using System.Collections.Generic;
using System.Net;
using ooadLabb2.Models;

namespace ooadLabb2.Services
{
    public class AstronautService<JsonModel> : IAstronautService<JsonModel>
    {
        private IJsonParser jsonParser;
        private readonly string url;

        public AstronautService(IJsonParser jsonParser)
        {
            this.jsonParser = jsonParser;
            url = "http://api.open-notify.org/astros.json";
        }

        public JsonModel GetAstronautsInSpace()
        {
            var client = new WebClient();
            var json = client.DownloadString(url);

            return jsonParser.deserialize<JsonModel>(json);
        }
    }
}
