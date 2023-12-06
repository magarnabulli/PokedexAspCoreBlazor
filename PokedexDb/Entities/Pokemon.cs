using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexDb.Entities
{
	public class Pokemon
	{
		public int Id { get; set; }
		public string SpriteUrl { get; set; } = string.Empty;
		public enum PokeType
		{
			Fire,
			Water,
			Rock,
			Dark,
			Psychic,
			Fighting,
			Ghost,
			Bug,
			Ground,
			Ice,
			Dragon,
			Steel,
			Grass,
			Flying,
			Electric,
			Poison,
			Normal
		}
		public List<PokeType> PokemonType { get; set; }
		public string Name { get; set; } = string.Empty;
		public int Height { get; set; } = 1;
		public int Weight { get; set; } = 1;
		public int Health { get; set; } = 1;
		public int Attack { get; set; } = 1;
		public int Defense { get; set; } = 0;
		public int SpecialDefense { get; set; } = 0;
		public int Speed { get; set; } = 0;

	}
}
