using ooadLabb2.Models;

namespace ooadLabb2.Services
{
    public interface IJsonParser
    {
        public T deserialize<T>(string json);
    }
}