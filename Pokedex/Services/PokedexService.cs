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

                //var response = await _HttpClient.GetAsync(url);

                //if (!response.IsSuccessStatusCode)
                //    await App.Current.MainPage.DisplayAlert("Eita Nóis...", "Alguma coisa de errado não deu certo!!!", "Ok");

                //var data = await response.Content.ReadAsStringAsync();

                //var pokemons = new List<Pokemon>();

                //pokemons.Add(content);

                //return content;

                var response = _HttpClient.GetStringAsync(url).Result;                

                var content = JsonConvert.DeserializeObject<Pokemon>(response);
                
                return new ObservableCollection<Results>(content.Results);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}