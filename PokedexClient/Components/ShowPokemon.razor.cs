namespace PokedexClient.Components
{
	public partial class ShowPokemon
	{
		protected override async Task OnInitializedAsync()
		{
			//Appstate.Pokemon = await Services.HttpService.GetPokemonAsync();
		}
		public async Task GetPokemon()
		{
			var pokemon = await Services.PokeapiService.GetPokemonAsync();
			Console.WriteLine($"Name: {pokemon.Name}\nBaseXP: {pokemon.Base_Experience}\nHeight:{pokemon.Height}");
			foreach (var item in pokemon.Moves)
			{
				Console.WriteLine(item.Move.Name, item.Move.Url);
			}
		}
		public async Task GetPokemonById(int id)
		{
			var pokemon = await Services.PokeapiService.GetPokemonAsync();
			
		}
	}
}
