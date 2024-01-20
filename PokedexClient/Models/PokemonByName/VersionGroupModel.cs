namespace PokedexClient.Models.PokemonByName
{
    public class VersionGroupModel
    {
        public int Level_Learned_At { get; set; } = 0;
        public NameUrlModel Move_Learn_Method { get; set; } = new NameUrlModel();
        public NameUrlModel Version_Group { get; set; } = new NameUrlModel();
    }
}
