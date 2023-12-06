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
		public async Task<List<PokemonModel>> ReadPokemonAsync()
		{
			var entites = await _db.Set<Pokemon>().ToListAsync();
			return Helpers.ModelConverter.GetPokemonModelsAsync(entites);
		}
		public async Task<PokemonModel> ReadOnePokemonAsync(int id)
		{
			var pokemonEntity = await _db.Pokemons.FirstOrDefaultAsync(p => p.Id == id);
			return Helpers.ModelConverter.CreatePokemonModelAsync(pokemonEntity!);
		}
		public async Task AddPokemonAsync(PokemonModel pokemon)
		{
			var entity = Helpers.ModelConverter.CreatePokemonAsync(pokemon);
			await _db.Set<Pokemon>().AddAsync(entity);
			await _db.SaveChangesAsync();
		}
		public async Task EditPokemonAsync(int id, PokemonModel pokemon)
		{
			var entity = Helpers.ModelConverter.CreatePokemonAsync(pokemon);
			entity.Id = id;
			_db.Set<Pokemon>().Update(entity);
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
