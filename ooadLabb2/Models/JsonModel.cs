using System;
using System.Collections.Generic;

namespace ooadLabb2.Models
{
    // This is the DTO from the API call
    public class JsonModel
    {
        public List<Astronaut> People { get; set; }
        public int Number { get; set; }
        public string Message { get; set; }
    }
}
