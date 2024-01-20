using PokedexClient.Models.PokemonByName;

namespace PokedexClient.Models.BaseCalls
{
	public class DamageRelationsModel
	{
		public NameUrlModel[] Double_Damage_From { get; set; } = new NameUrlModel[0];
		public NameUrlModel[] Double_Damage_To { get; set; } = new NameUrlModel[0];
		public NameUrlModel[] Half_Damage_From { get; set; } = new NameUrlModel[0];
		public NameUrlModel[] Half_Damage_To { get; set; } = new NameUrlModel[0];
		public NameUrlModel[] No_Damage_From { get; set; } = new NameUrlModel[0];
		public NameUrlModel[] No_Damage_To { get; set; } = new NameUrlModel[0];
	}
}
