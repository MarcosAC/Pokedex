using Pokedex.Models;
using Pokedex.Services;
using Pokedex.Views;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

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

        private Command _selectPokemonCommand;
        public Command SelectPokemonCommand => _selectPokemonCommand ??
            new Command<Results>(async results => await ExecuteSelectePokemonCommand(results));

        private async Task ExecuteSelectePokemonCommand(Results resultsSelected)
        {
            if (resultsSelected == null)
                return;

            await App.Current.MainPage.Navigation.PushAsync(new DetailPokemonView(resultsSelected));
        }

    }
}
