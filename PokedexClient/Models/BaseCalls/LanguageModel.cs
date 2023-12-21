using PokedexClient.Models.PokemonByName;

namespace PokedexClient.Models.BaseCalls
{
	public class LanguageModel
	{
		public NameUrlModel Language { get; set; } = new NameUrlModel();
		public string Name {  get; set; } = string.Empty;
	}
}
