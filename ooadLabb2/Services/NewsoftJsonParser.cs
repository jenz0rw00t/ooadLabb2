using System;
using Newtonsoft.Json;
using ooadLabb2.Models;

namespace ooadLabb2.Services
{
    public class NewsoftJsonParser : IJsonParser
    {
        public T deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
