using PokedexDb.Entities;
using PokedexShared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexDb.Helpers
{
	public static class ModelConverter
	{
		public static List<PokemonModel> GetPokemonModelsAsync(List<Pokemon> dbPokemon)
		{
			var result = new List<PokemonModel>();
			foreach (var pokemon in dbPokemon)
			{
				result.Add(CreatePokemonModelAsync(pokemon));
			}
			return result;
		}
		public static Pokemon CreatePokemonAsync(PokemonModel pokeModel)
		{
			var pokemonEntity = new Pokemon()
			{
				SpriteUrl = pokeModel.SpriteUrl,
				PokemonType = GetTypesEntityAsync(pokeModel.PokemonType),
				Name = pokeModel.Name,
				Height = pokeModel.Height,
				Weight = pokeModel.Weight,
				Health = pokeModel.Health,
				Attack = pokeModel.Attack,
				Defense = pokeModel.Defense,
				SpecialDefense = pokeModel.SpecialDefense,
				Speed = pokeModel.Speed
			};
			return pokemonEntity;
		}
		public static List<Pokemon.PokeType> GetTypesEntityAsync(List<PokemonModel.PokeType> pokeModelTypes)
		{

			var pokeTypes = new List<Pokemon.PokeType>();
			foreach (var type in pokeModelTypes)
			{
				var list = Enum.GetValues(typeof(Pokemon.PokeType));
				var blä = list.GetValue((int)type);

				pokeTypes.Add((Pokemon.PokeType)blä);

			}
			return pokeTypes;
		}

		public static PokemonModel CreatePokemonModelAsync(Pokemon pokemonEntity)
		{

			var pokemonModel = new PokemonModel()
			{
				SpriteUrl = pokemonEntity.SpriteUrl,
				PokemonType = GetTypesModelAsync(pokemonEntity.PokemonType),
				Name = pokemonEntity.Name,
				Height = pokemonEntity.Height,
				Weight = pokemonEntity.Weight,
				Health = pokemonEntity.Health,
				Attack = pokemonEntity.Attack,
				Defense = pokemonEntity.Defense,
				SpecialDefense = pokemonEntity.SpecialDefense,
				Speed = pokemonEntity.Speed
			};
			return pokemonModel;

		}
		public static List<PokemonModel.PokeType> GetTypesModelAsync(List<Pokemon.PokeType> pokeTypes)
		{

			var pokeModelTypes = new List<PokemonModel.PokeType>();
			foreach (var type in pokeTypes)
			{
				var list = Enum.GetValues(typeof(PokemonModel.PokeType));
				var blä = list.GetValue((int)type);

				pokeModelTypes.Add((PokemonModel.PokeType)blä);

			}
			return pokeModelTypes;
		}
	}
}
