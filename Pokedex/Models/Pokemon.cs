using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace Pokedex.Models
{
    public class Pokemon
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }

        [JsonProperty("base_experience")]
        public int BaseExperience { get; set; }

        public ObservableCollection<Types> Types { get; set; }

        public ObservableCollection<Abilities> Abilities { get; set; }

        public ObservableCollection<Results> Results { get; set; }

        public string Image
        {
            get { return "https://img.pokemondb.net/artwork/" + Name + ".jpg"; }
            set { }
        }
    }
}
