using Pokedex.Models;
using Pokedex.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pokedex.ViewModels
{
    public class ListPokemonsServiceViewModel : BaseViewModel
    {
        private readonly PokedexService pokedexService;

        public Task<List<Pokemon>> Pokemons { get; set; }

        public ListPokemonsServiceViewModel()
        {
            pokedexService = new PokedexService();
            Pokemons = LoadPokemons();
        }

        private async Task<List<Pokemon>> LoadPokemons()
        {
            return await pokedexService.GetAll();
        }
    }
}
