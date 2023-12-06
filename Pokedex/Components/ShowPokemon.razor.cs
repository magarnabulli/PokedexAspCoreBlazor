namespace Pokedex.Components
{
	public partial class ShowPokemon
	{
		public async Task GetPokemon()
		{
			var list = await Services.HttpService.GetPokemonAsync();
			foreach (var item in list)
			{
				Console.WriteLine(item.Name);
			}
		}
	}
}
