using Newtonsoft.Json;

namespace Pokedex.Models
{
    public class Ability
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
