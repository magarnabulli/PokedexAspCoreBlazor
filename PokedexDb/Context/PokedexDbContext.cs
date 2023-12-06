using Microsoft.EntityFrameworkCore;
using PokedexDb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PokedexDb.Context
{
	public class PokedexDbContext : DbContext
	{
		public PokedexDbContext(DbContextOptions<PokedexDbContext> options) : base(options) { }
		public virtual DbSet<Pokemon> Pokemons { get; set; } = null!;
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Pokemon>();
			modelBuilder.Entity<Pokemon>().HasData(new Pokemon
			{
				Id=1,
				SpriteUrl= "dinMamma.png",
				PokemonType = new List<Pokemon.PokeType>()
				{
					Pokemon.PokeType.Fire, Pokemon.PokeType.Ice
				},
				Name="ChariCunt",
				Height=230,
				Weight=90,
				Health= 45,
				Attack=24,
				Defense=31,
				SpecialDefense=14,
				Speed=8
			});
			base.OnModelCreating(modelBuilder);
		}
	}
}
