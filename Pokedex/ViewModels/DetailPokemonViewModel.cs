using Pokedex.Models;
using System.Collections.Generic;

namespace Pokedex.ViewModels
{
    public class DetailPokemonViewModel : BaseViewModel
    {
        public Pokemon _selectedPokemon;

        public List<Types> ListTypes => Types;

        public List<Abilities> ListAbilities => Abilities;

        public DetailPokemonViewModel(Pokemon selectedPokemon)
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

        public int Height
        {
            get { return _selectedPokemon.Height; }
            set
            {
                _selectedPokemon.Height = value;
                OnPropertyChanged();
            }
        }

        public int Weight
        {
            get { return _selectedPokemon.Weight; }
            set 
            { 
                _selectedPokemon.Weight = value;
                OnPropertyChanged();
            }
        }

        public int BaseExperience
        {
            get { return _selectedPokemon.BaseExperience; }
            set
            {
                _selectedPokemon.BaseExperience = value;
                OnPropertyChanged();
            }
        }

        public List<Types> Types{
            get { return _selectedPokemon.Types; }
            set
            {
                _selectedPokemon.Types = value;
                OnPropertyChanged();
            }
        }

        public List<Abilities> Abilities
        {
            get { return _selectedPokemon.Abilities; }
            set
            {
                _selectedPokemon.Abilities = value;
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
