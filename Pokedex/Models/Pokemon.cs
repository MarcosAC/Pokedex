using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Pokedex.Models
{
    public class Pokemon
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("next")]
        public Uri Next { get; set; }

        [JsonProperty("previous")]
        public object Previous { get; set; }

        [JsonProperty("results")]
        public List<Results> Results { get; set; }

        //[JsonProperty("id")]
        //public long Id { get; set; }

        //[JsonProperty("name")]
        //public string Name { get; set; }

        //[JsonProperty("url")]
        //public string Url { get; set; }

        //[JsonProperty("height")]
        //public long Height { get; set; }

        //[JsonProperty("sprites")]
        //public Sprites Sprites { get; set; }

        //public byte[] Image { get; set; }

        //public string Description { get; set; }       
    }

    public class Results
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    //public class Results
    //{
    //    [JsonProperty("name")]
    //    public string name { get; set; }

    //    [JsonProperty("url")]
    //    public Uri Url { get; set; }
    //    public string imagem
    //    {
    //        get
    //        {
    //            return "https://img.pokemondb.net/artwork/" + name + ".jpg";
    //        }
    //    }
    //}
}
