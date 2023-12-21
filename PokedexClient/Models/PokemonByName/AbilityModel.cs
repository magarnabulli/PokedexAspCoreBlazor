namespace PokedexClient.Models.PokemonByName
{
    public class AbilityModel
    {
        public NameUrlModel Ability { get; set; } = new NameUrlModel();
        public bool Is_Hidden { get; set; } = false;
        public int Slot { get; set; } = 0;

    }
}
