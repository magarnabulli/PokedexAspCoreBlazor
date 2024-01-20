using PokedexClient.Models;
using PokedexClient.Models.BaseCalls;
using PokedexClient.Models.PokemonByName;
using PokedexDb.Entities;
using PokedexShared.Models;

namespace PokedexClient
{
    public class AppState
    {
        //Container -> Childcontent switch
        public string ChildContentMode { get; set; } = string.Empty;

        //searchbar
        public string SearchInput { get; set; } = string.Empty;
        public string[] SearchFilters { get; set; } = new string[0];

        //api
        public PokemonInfoModel PokemonInfo { get; set; } = new PokemonInfoModel();
        public List<PokemonInfoModel> AllPokemon { get; set; } = new List<PokemonInfoModel>();
        public TypeInfoModel CurrentType { get; set; } = new TypeInfoModel();
        public AllTypesModel AllTypes { get; set; } = new AllTypesModel();
        //db
        public PokemonModel PokemonModel { get; set; } = new PokemonModel();

    }
}
