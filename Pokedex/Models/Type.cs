using Newtonsoft.Json;

namespace Pokedex.Models
{
    public class Type
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
