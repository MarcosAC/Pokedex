using Pokedex.Models;
using Pokedex.Services;
using Pokedex.Views;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Pokedex.ViewModels
{
    public class ListPokemonsViewModel : BaseViewModel
    {
        private readonly PokedexService pokedexService;

        public ObservableCollection<Results> Pokemons { get; set; }

        public ListPokemonsViewModel()
        {
            pokedexService = new PokedexService();
            Pokemons = new ObservableCollection<Results>();
            LoadPokemons();
        }

        private void LoadPokemons()
        {
            Pokemons = pokedexService.GetAll();
        }

        private Pokemon Get(string name)
        {
            Pokemon pokemon = pokedexService.Get(name);
            return pokemon;
        }

        private Command _selectPokemonCommand;
        public Command SelectPokemonCommand => _selectPokemonCommand ??
            new Command<Results>(async results => await ExecuteSelectePokemonCommand(results));

        private async Task ExecuteSelectePokemonCommand(Results resultsSelected)
        {
            if (resultsSelected == null)
            {
                return;
            }

            await App.Current.MainPage.Navigation.PushAsync(new DetailPokemonView(Get(resultsSelected.Name)));
        }
    }
}
