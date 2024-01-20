namespace PokedexClient.Models.PokemonByName
{
    public class PokemonInfoModel
    {
        public AbilityModel[] Abilities { get; set; } = new AbilityModel[0];
        public int Base_Experience { get; set; } = 0;
        public NameUrlModel[] Forms { get; set; } = new NameUrlModel[0];
        public GameModel[] GameIndices { get; set; } = new GameModel[0];
        public int Height { get; set; } = 0;
        public HeldItemModel[] Held_Items { get; set; } = new HeldItemModel[0];
        public int Id { get; set; } = 0;
        public bool Is_Default { get; set; } = false;
        public string Location_Area_Encounters { get; set; } = string.Empty;
        public MovesModel[] Moves { get; set; } = new MovesModel[0];
        public string Name { get; set; } = string.Empty;
        public int Order { get; set; } = 0;
        public AbilityModel[] Past_Abilities { get; set; } = new AbilityModel[0];
        public TypesModel[] Past_Types { get; set; } = new TypesModel[0];
        public NameUrlModel Species { get; set; } = new NameUrlModel();
        public SpritesModel Sprites { get; set; } = new SpritesModel();
        public StatModel[] Stats { get; set; } = new StatModel[0];
        public TypesModel[] Types { get; set; } = new TypesModel[0];
        public int Weight { get; set; } = 0;


    }
}
