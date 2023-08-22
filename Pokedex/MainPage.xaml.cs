using Pokedex.ViewModels;
using Xamarin.Forms;

namespace Pokedex
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ViewModel = new ListPokemonsServiceViewModel();
        }

        public ListPokemonsServiceViewModel ViewModel 
        {
            get { return BindingContext as ListPokemonsServiceViewModel; }
            set { BindingContext = value; }
        }

        //private void OnItemSelect(object sender, SelectedItemChangedEventArgs e)
        //{
        //    if (e.SelectedItem != null)
        //        ViewModel.SelecionarServicoCommand.Execute(e.SelectedItem);

        //    ListaServicos.SelectedItem = null;
        //}
    }
}
