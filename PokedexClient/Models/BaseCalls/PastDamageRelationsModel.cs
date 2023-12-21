using PokedexClient.Models.PokemonByName;

namespace PokedexClient.Models.BaseCalls
{
	public class PastDamageRelationsModel
	{
		public DamageRelationsModel Damage_Relations { get; set; } = new DamageRelationsModel();
		public NameUrlModel Generation {  get; set; }= new NameUrlModel();
	}
}
