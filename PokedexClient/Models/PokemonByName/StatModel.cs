namespace PokedexClient.Models.PokemonByName
{
    public class StatModel
    {
        public int Base_Stat { get; set; } = 0;
        public int Effort { get; set; } = 0;
        public NameUrlModel Stat { get; set; } = new NameUrlModel();
    }
}
