using PokedexClient.Services;

namespace PokedexClient.Components
{
	public partial class HomeContent
	{
		protected override async Task OnInitializedAsync()
		{
			Appstate.AllPokemon = await PokeapiService.GetPokemonAsync();
		}
	}
}
