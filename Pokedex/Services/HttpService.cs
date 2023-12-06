using PokedexShared.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace Pokedex.Services
{
	public static class HttpService
	{
		public static HttpClient GetClient()
		{
			HttpClient client = new HttpClient();
			client.BaseAddress = new Uri("https://localhost:7212");
			return client;
		}

		public static async Task<List<PokemonModel>> GetPokemonAsync()
		{
			try
			{
				var response = await GetClient().GetAsync("/api/GetPokemon");
				var pokemon = await response.Content.ReadFromJsonAsync<List<PokemonModel>>();
				return pokemon!;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

		}
		public static async Task<IAsyncResult> AddPokemon(PokemonModel newPokemon)
		{
			try
			{
				var response = await GetClient().PostAsJsonAsync("/api/AddPokemon/", newPokemon);
				return await response.Content.ReadFromJsonAsync<IAsyncResult>();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
