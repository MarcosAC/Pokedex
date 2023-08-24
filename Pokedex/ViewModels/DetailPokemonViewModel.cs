using Pokedex.Models;

namespace Pokedex.ViewModels
{
    public class DetailPokemonViewModel : BaseViewModel
    {
        public Results _selectedPokemon;

        public DetailPokemonViewModel(Results selectedPokemon)
        {
            _selectedPokemon = selectedPokemon;
        }

        public string Name
        {
            get { return _selectedPokemon.Name; }
            set
            {
                _selectedPokemon.Name = value;
                OnPropertyChanged();
            }
        }

        public string Image
        {
            get { return _selectedPokemon.Image; }
            set
            {
                _selectedPokemon.Image = value;
                OnPropertyChanged();
            }
        }
    }
}
