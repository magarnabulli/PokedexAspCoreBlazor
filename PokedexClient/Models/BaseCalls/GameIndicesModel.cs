using PokedexClient.Models.PokemonByName;

namespace PokedexClient.Models.BaseCalls
{
	public class GameIndicesModel
	{
		public int Game_Index { get; set; } = 0;
		public NameUrlModel Generation {  get; set; } = new NameUrlModel();
	}
}
