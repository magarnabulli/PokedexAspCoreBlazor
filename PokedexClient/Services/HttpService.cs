using PokedexDb.Entities;
using PokedexShared.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace PokedexClient.Services
{
	public static class HttpService
	{
		public static HttpClient GetClient()
		{
			HttpClient client = new HttpClient();
			client.BaseAddress = new Uri("https://localhost:7212");
			return client;
		}
		public static async Task<T?> GetResult<T>(HttpResponseMessage response)
		{
			return await response.Content.ReadFromJsonAsync<T>();
		}
		public static async Task<List<Pokemon>> GetPokemonAsync()
		{
			try
			{
				var response = await GetClient().GetAsync("/api/pokemon");
				var pokemon = await GetResult<List<Pokemon>>(response);

				return pokemon;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public static async Task<PokemonModel> GetPokemonById(int id)
		{
			try
			{
				var response = await GetClient().GetAsync($"/api/pokemon/{id}");
				var pokemon = await GetResult<Pokemon>(response);
				return PokemonBuilderHelper.CreatePokemonModelAsync(pokemon!);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public static async Task AddPokemon(PokemonModel newPokemon)
		{
			var response = await GetClient().PostAsJsonAsync("/api/pokemon/", PokemonBuilderHelper.CreatePokemonAsync(newPokemon));
			response.EnsureSuccessStatusCode();
		}
		public static async Task EditPokemonAsync(int id, PokemonModel editPokemon)
		{
			var response = await GetClient().PostAsJsonAsync($"/api/pokemon/{id}", PokemonBuilderHelper.CreatePokemonAsync(editPokemon));
			response.EnsureSuccessStatusCode();
		}

	}
}
