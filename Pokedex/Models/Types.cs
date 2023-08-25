using Newtonsoft.Json;

namespace Pokedex.Models
{
    public class Types
    {
        [JsonProperty("slot")]
        public int Slot { get; set; }

        [JsonProperty("type")]
        public Type Type { get; set; }
    }
}
