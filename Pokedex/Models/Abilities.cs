using Newtonsoft.Json;

namespace Pokedex.Models
{
    public class Abilities
    {
        [JsonProperty("slot")]
        public int Slot { get; set; }

        [JsonProperty("ability")]
        public Ability Abilitie { get; set; }
    }
}
