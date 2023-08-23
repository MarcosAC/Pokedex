using Pokedex.Models;
using Pokedex.Services;
using System.Collections.ObjectModel;

namespace Pokedex.ViewModels
{
    public class ListPokemonsServiceViewModel : BaseViewModel
    {
        private readonly PokedexService pokedexService;        

        public ObservableCollection<Results> Pokemons { get; set; }

        public ListPokemonsServiceViewModel()
        {
            pokedexService = new PokedexService();
            Pokemons = new ObservableCollection<Results>();
            LoadPokemons();
        }

        private void LoadPokemons()
        {
            Pokemons = pokedexService.GetAll();            
        }
    }
}
