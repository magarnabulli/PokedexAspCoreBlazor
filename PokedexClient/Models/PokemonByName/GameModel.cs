﻿namespace PokedexClient.Models.PokemonByName
{
    public class GameModel
    {
        public int Game_Index { get; set; } = 0;
        public NameUrlModel Version { get; set; } = new NameUrlModel();
    }
}
