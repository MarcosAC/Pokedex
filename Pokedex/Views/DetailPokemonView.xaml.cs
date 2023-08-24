using Pokedex.Models;
using Pokedex.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pokedex.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPokemonView : ContentPage
    {
        public DetailPokemonView(Results selectedPokemon)
        {
            InitializeComponent();

            BindingContext = new DetailPokemonViewModel(selectedPokemon);
        }
    }
}