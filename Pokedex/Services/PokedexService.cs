using Newtonsoft.Json;
using Pokedex.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Pokedex.Services
{
    public class PokedexService
    {
        private readonly HttpClient _HttpClient;

        public PokedexService()
        {
            _HttpClient = new HttpClient();            
        }

        public async Task<Pokemon> GetAll()
        {            
            try
            {
                string url = Constantes.BaseUrl;
                var response = await _HttpClient.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                    await App.Current.MainPage.DisplayAlert("Eita Nóis...", "Alguma coisa de errado não deu certo!!!", "Ok");

                var data = await response.Content.ReadAsStringAsync();

                var pokemons = JsonConvert.DeserializeObject<Pokemon>(data);

                return pokemons;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}