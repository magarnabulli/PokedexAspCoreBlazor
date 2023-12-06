using PokedexShared.Models;

namespace Pokedex.Components
{
	public partial class AddPokemon
	{
		public List<PokemonModel.PokeType> PokeTypes { get; set; } = new List<PokemonModel.PokeType>();
		public async Task AddPokemonAsync()
		{

		}
	}
}
