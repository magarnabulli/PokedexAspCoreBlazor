using PokedexClient.Models.PokemonByName;

namespace PokedexClient.Models.BaseCalls
{
	public class PokemonSlotModel
	{
		public NameUrlModel Pokemon { get; set; } = new NameUrlModel();
		public int Slot {  get; set; } = 0;
	}
}
