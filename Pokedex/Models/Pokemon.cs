using Newtonsoft.Json;
using System;
using System.Collections.Generic;

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

        public List<Types> Types { get; set; }

        public List<Results> Results { get; set; }

        public string Image
        {
            get { return "https://img.pokemondb.net/artwork/" + Name + ".jpg"; }
            set { }
        }
    }

    public class Results
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        public string Image
        {
            get{ return "https://img.pokemondb.net/artwork/" + Name + ".jpg"; }
            set { }
        }
    }

    public class Types
    {
        [JsonProperty("slot")]
        public int Slot { get; set; }

        [JsonProperty("type")]
        public Type Type { get; set; }
    }

    public class Type
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
