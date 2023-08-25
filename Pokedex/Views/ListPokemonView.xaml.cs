using Pokedex.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pokedex.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPokemonView : ContentPage
    {
        public ListPokemonView()
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