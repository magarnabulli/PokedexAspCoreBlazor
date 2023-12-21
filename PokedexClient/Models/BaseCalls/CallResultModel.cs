using PokedexClient.Models.PokemonByName;
namespace PokedexClient.Models.BaseCalls
{
	public class CallResultModel
	{
		public int Count { get; set; } = 0;
		public string Next { get; set; } = string.Empty;
		public string Previous { get; set; } = string.Empty;
		public NameUrlModel[] Results { get; set; } = new NameUrlModel[0];
	}
}
