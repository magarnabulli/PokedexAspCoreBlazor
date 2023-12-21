namespace PokedexClient.Models.PokemonByName
{
    public class SpritesModel
    {
        public string Back_Default { get; set; } = string.Empty;
        public string Back_Female { get; set; } = string.Empty;
        public string Back_Shiny { get; set; } = string.Empty;
        public string Back_Shiny_Female { get; set; } = string.Empty;
        public string Front_Default { get; set; } = string.Empty;
        public string Front_Female { get; set; } = string.Empty;
        public string Front_Shiny { get; set; } = string.Empty;
        public string Front_Shiny_Female { get; set; } = string.Empty;
        public SpritesGroupModel Dream_World { get; set; } = new SpritesGroupModel();
        public SpritesGroupModel Home { get; set; } = new SpritesGroupModel();
        public SpritesGroupModel Official_Artwork { get; set; } = new SpritesGroupModel();
        public SpritesVersionModel Versions { get; set; } = new SpritesVersionModel();
    }
    public class SpritesVersionModel
    {
        public GenISpritesModel GenISprites { get; set; } = new GenISpritesModel();
        public GenIISpritesModel GenIISprites { get; set; } = new GenIISpritesModel();
        public GenIIISpritesModel GenIIISprites { get; set; } = new GenIIISpritesModel();
        public GenIVSpritesModel GenIVSprites { get; set; } = new GenIVSpritesModel();
        public GenVSpritesModel GenVSprites { get; set; } = new GenVSpritesModel();
        public GenVISpritesModel GenVISprites { get; set; } = new GenVISpritesModel();
        public GenVIISpritesModel GenVIISprites { get; set; } = new GenVIISpritesModel();
        public GenVIIISpritesModel GenVIIISprites { get; set; } = new GenVIIISpritesModel();
    }
    public class GenISpritesModel
    {
        public SpritesGroupModel RedBlue { get; set; } = new SpritesGroupModel();
        public SpritesGroupModel Yellow { get; set; } = new SpritesGroupModel();
    }
    public class GenIISpritesModel
    {
        public SpritesGroupModel Crystal { get; set; } = new SpritesGroupModel();
        public SpritesGroupModel Gold { get; set; } = new SpritesGroupModel();
        public SpritesGroupModel Silver { get; set; } = new SpritesGroupModel();
    }
    public class GenIIISpritesModel
    {
        public SpritesGroupModel Emerald { get; set; } = new SpritesGroupModel();
        public SpritesGroupModel FireredLeafGreen { get; set; } = new SpritesGroupModel();
        public SpritesGroupModel RubySaphire { get; set; } = new SpritesGroupModel();
    }
    public class GenIVSpritesModel
    {
        public SpritesGroupModel DiamondPearl { get; set; } = new SpritesGroupModel();
        public SpritesGroupModel HeartGoldSoulSilver { get; set; } = new SpritesGroupModel();
        public SpritesGroupModel Platinum { get; set; } = new SpritesGroupModel();
    }
    public class GenVSpritesModel
    {
        public SpritesGroupModel BlackWhite { get; set; } = new SpritesGroupModel();
        public SpritesGroupModel Animated { get; set; } = new SpritesGroupModel();

    }
    public class GenVISpritesModel
    {
        public SpritesGroupModel OmegaRubyAlphaSapphire { get; set; } = new SpritesGroupModel();
        public SpritesGroupModel XY { get; set; } = new SpritesGroupModel();
        public SpritesGroupModel Animated { get; set; } = new SpritesGroupModel();

    }
    public class GenVIISpritesModel
    {
        public SpritesGroupModel Icons { get; set; } = new SpritesGroupModel();
        public SpritesGroupModel UltraSunUltraMoon { get; set; } = new SpritesGroupModel();

    }
    public class GenVIIISpritesModel
    {
        public SpritesGroupModel Icons { get; set; } = new SpritesGroupModel();

    }
    public class SpritesGroupModel
    {
        public string Front_Default { get; set; } = string.Empty;
        public string Front_Transparent { get; set; } = string.Empty;
        public string Front_Shiny_Transparent { get; set; } = string.Empty;
        public string Front_Shiny { get; set; } = string.Empty;
        public string Front_Female { get; set; } = string.Empty;
        public string Front_Shiny_Female { get; set; } = string.Empty;
        public string Front_Gray { get; set; } = string.Empty;
        public string Back_Default { get; set; } = string.Empty;
        public string Back_Transparent { get; set; } = string.Empty;
        public string Back_Shiny_Transparent { get; set; } = string.Empty;
        public string Back_Shiny_Female { get; set; } = string.Empty;
        public string Back_Shiny { get; set; } = string.Empty;
        public string Back_Gray { get; set; } = string.Empty;
    }
}
