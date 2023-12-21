
using Microsoft.AspNetCore.Components;
using PokedexClient.Services;
using PokedexClient.Models;

namespace PokedexClient.Components
{
	public partial class Searchbar
	{
		public async void OnSearch()
		{
			try
			{
				Console.WriteLine(Appstate.SearchInput);
				Appstate.PokemonInfo = await PokeapiService.SearchPokemonAsync(Appstate.SearchInput);
				Appstate.ChildContentMode= "pokemonInfoPage";
				await CurrentPokemon.InvokeAsync(Appstate.PokemonInfo);
				Console.WriteLine($"Name: {Appstate.PokemonInfo.Name}");
				Console.WriteLine($"Name: {CurrentPokemon.HasDelegate}");
				
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message );
			}
		}
	
	}
}
