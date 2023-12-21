using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokedexDb.Entities;
using PokedexDb.Services;
using PokedexShared.Models;

namespace PokedexAPI.Controllers
{
	[Route("api/pokemon")]
	[ApiController]
	public class PokemonController : ControllerBase
	{
		private readonly PokemonService _pokemonService;
		public PokemonController(PokemonService pokemonService)
		{
			_pokemonService = pokemonService;
		}
		[HttpGet]
		public async Task<List<Pokemon>> Get()
		{
			try
			{
				return await _pokemonService.ReadPokemonAsync();
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}

		}

		[HttpGet("{id}")]
		public async Task<Pokemon> Get(int id)
		{
			try
			{
				return await _pokemonService.ReadOnePokemonAsync(id);
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}

		}
		[HttpPost]
		public async Task<IResult> AddPokemon([FromBody] Pokemon pokemon)
		{
			try
			{
				await _pokemonService.AddPokemonAsync(pokemon);
				return Results.Ok("Added");

			}
			catch (Exception e)
			{
				return Results.BadRequest(e.Message);
			}
		}
		[HttpPut("{id}")]
		public async Task<IResult> EditPokemon(int id,[FromBody] Pokemon pokemon)
		{
			try
			{
				await _pokemonService.EditPokemonAsync(id,pokemon);
				return Results.Ok();

			}
			catch (Exception e)
			{
				return Results.BadRequest(e.Message);
			}
		}
		[HttpDelete("{id}")]
		public async Task<IResult> DeletePokemon(int id)
		{
			try
			{
				await _pokemonService.DeletePokemonAsync(id);
				return Results.Ok();
			}
			catch (Exception e)
			{
				return Results.BadRequest(e.Message);
			}

		}
	}
}

