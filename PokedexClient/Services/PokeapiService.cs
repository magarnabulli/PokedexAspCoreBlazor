using PokedexClient.Models;
using PokedexDb.Entities;
using System.Net.Http.Json;

namespace PokedexClient.Services
{
	public class PokeapiService
	{
		public static HttpClient GetClient()
		{
			HttpClient client = new HttpClient();
			client.BaseAddress = new Uri("https://pokeapi.co/api/v2/");
			return client;
		}
		public static async Task<PokemonInfoModel> GetPokemonAsync()
		{
			try
			{
				var response = await GetClient().GetAsync("pokemon/pikachu");
				return await response.Content.ReadFromJsonAsync<PokemonInfoModel>();

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

		}
		public static async Task<PokemonInfoModel> SearchPokemonAsync(string pokemon)
		{
			try
			{
				var response = await GetClient().GetAsync($"pokemon/{pokemon}");
				return await response.Content.ReadFromJsonAsync<PokemonInfoModel>();

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
