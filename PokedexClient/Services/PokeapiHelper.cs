using PokedexClient.Models.BaseCalls;
using PokedexClient.Models.PokemonByName;

namespace PokedexClient.Services
{
	public static class PokeapiHelper
	{
		public static async Task<List<PokemonInfoModel>> GetPokemonFromResult(CallResultModel result)
		{
			var pokemon = new List<PokemonInfoModel>();
			foreach (var item in result.Results)
			{
				pokemon.Add(await PokeapiService.SearchPokemonAsync(item.Name));
			}
			return pokemon;
		}
	}
}
