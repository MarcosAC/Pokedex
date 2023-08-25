using Pokedex.ViewModels;
using Xamarin.Forms;

namespace Pokedex
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ViewModel = new ListPokemonsViewModel();
        }

        public ListPokemonsViewModel ViewModel 
        {
            get { return BindingContext as ListPokemonsViewModel; }
            set { BindingContext = value; }
        }

        private void OnItemSelect(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
                ViewModel.SelectPokemonCommand.Execute(e.SelectedItem);

            PokemonList.SelectedItem = null;
        }
    }
}
