using Microsoft.EntityFrameworkCore;
using PokedexDb.Context;
using PokedexDb.Entities;
using PokedexShared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexDb.Services
{
	public class PokemonService
	{
		private readonly PokedexDbContext _db;
		public PokemonService(PokedexDbContext db)
		{
			_db = db;
		}
		public async Task<List<Pokemon>> ReadPokemonAsync()
		{
			return  await _db.Set<Pokemon>().ToListAsync();
			
		}
		public async Task<Pokemon> ReadOnePokemonAsync(int id)
		{
			var pokemonEntity = await _db.Pokemons.FirstOrDefaultAsync(p => p.Id == id);
			return pokemonEntity!;
		}
		public async Task AddPokemonAsync(Pokemon pokemon)
		{
			await _db.Set<Pokemon>().AddAsync(pokemon);
			await _db.SaveChangesAsync();
		}
		public async Task EditPokemonAsync(int id,Pokemon pokemon)
		{
			var pokemonEntity = await _db.Pokemons.FirstOrDefaultAsync(p => p.Id == id);
			pokemon.Id = pokemonEntity!.Id;
			_db.Set<Pokemon>().Update(pokemon);
			await _db.SaveChangesAsync();
		}
		public async Task DeletePokemonAsync(int id)
		{
			var pokemonEntity = await _db.Pokemons.FirstOrDefaultAsync(p => p.Id == id);
			_db.Remove(pokemonEntity!);
			await _db.SaveChangesAsync();
		}
	}
}
