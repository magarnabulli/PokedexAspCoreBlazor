using PokedexClient.Models.BaseCalls;
using PokedexClient.Models.PokemonByName;
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


		public static async Task<TypeInfoModel> GetPokemonTypesAsync(string type)
		{
			try
			{

				var response = await GetClient().GetAsync($"type/{type}");
				return await response.Content.ReadFromJsonAsync<TypeInfoModel>();
				

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

		}
		public static async Task<List<PokemonInfoModel>> GetPokemonAsync()
		{
			try
			{
			
				var response = await GetClient().GetAsync("pokemon?limit=20&offset=0");
				var results= await response.Content.ReadFromJsonAsync<CallResultModel>();
				return await PokeapiHelper.GetPokemonFromResult(results);

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
