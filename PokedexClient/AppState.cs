using PokedexClient.Models;
using PokedexDb.Entities;
using PokedexShared.Models;

namespace PokedexClient
{
	public class AppState
	{

		public PokemonInfoModel PokemonInfo { get; set; } = new PokemonInfoModel();
		public PokemonModel PokemonModel { get; set; } = new PokemonModel();
		public List<Pokemon> Pokemon { get; set; } = new List<Pokemon>();
		public string SearchInput { get; set; } = string.Empty;
		public string[] SearchFilters { get;set; } = new string[0];	
	}
}
