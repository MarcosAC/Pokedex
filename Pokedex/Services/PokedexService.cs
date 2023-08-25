using Newtonsoft.Json;
using Pokedex.Models;
using System;
using System.Collections.ObjectModel;
using System.Net.Http;

namespace Pokedex.Services
{
    public class PokedexService
    {
        private readonly HttpClient _HttpClient;

        public PokedexService()
        {
            _HttpClient = new HttpClient();
        }

        public ObservableCollection<Results> GetAll()
        {
            try
            {
                string url = Constantes.BaseUrl;

                string response = _HttpClient.GetStringAsync(url).Result;

                Pokemon content = JsonConvert.DeserializeObject<Pokemon>(response);

                return new ObservableCollection<Results>(content.Results);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Pokemon Get(string name)
        {
            string url = Constantes.BaseUrl + name;

            string response = _HttpClient.GetStringAsync(url).Result;

            Pokemon content = JsonConvert.DeserializeObject<Pokemon>(response);

            return content;
        }
    }
}