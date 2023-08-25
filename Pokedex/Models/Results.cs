using Newtonsoft.Json;
using System;

namespace Pokedex.Models
{
    public class Results
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        public string Image
        {
            get { return "https://img.pokemondb.net/artwork/" + Name + ".jpg"; }
            set { }
        }
    }
}
