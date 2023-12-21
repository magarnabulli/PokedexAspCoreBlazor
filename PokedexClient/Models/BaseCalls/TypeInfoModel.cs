using PokedexClient.Models.PokemonByName;

namespace PokedexClient.Models.BaseCalls
{
	public class TypeInfoModel
	{
		public DamageRelationsModel DamageRelations { get; set; } = new DamageRelationsModel();
		public GameIndicesModel[] Game_Indices { get; set; } = new GameIndicesModel[0];
		public NameUrlModel Generation { get; set; } = new NameUrlModel();
		public int Id { get; set; } = 0;
		public NameUrlModel Move_Damage_Class { get; set; } = new NameUrlModel();
		public NameUrlModel[] Moves { get; set; } = new NameUrlModel[0];
		public string Name { get; set; } = string.Empty;
		public LanguageModel[] Names { get; set; } = new LanguageModel[0];
		public PastDamageRelationsModel[] Past_Damage_Relations { get; set; } = new PastDamageRelationsModel[0];
		public PokemonSlotModel[] Pokemon { get; set;} = new PokemonSlotModel[0];
	}
}
