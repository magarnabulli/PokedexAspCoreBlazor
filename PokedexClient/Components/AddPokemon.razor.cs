using Microsoft.AspNetCore.Components.Forms;
using PokedexClient.Services;
using PokedexShared.Models;

namespace PokedexClient.Components
{
	public partial class AddPokemon
	{
	
		public List<int> SelectedTypes { get; set; } = new List<int>();
		public async void SaveSpriteAsync(InputFileChangeEventArgs e)
		{
			var projectPath = Path.Combine(Directory.GetCurrentDirectory()+"/wwwroot/sprites");
			Console.WriteLine(projectPath);
			var browserFile = e.File;
			await using FileStream fs = new(projectPath, FileMode.Create);
			await browserFile.OpenReadStream().CopyToAsync(fs);
			Appstate.PokemonModel.SpriteUrl = e.File.Name.ToString();


		}
		public void OnTypeSelect(int typeE, object isSelected)
		{
			if ((bool)isSelected && SelectedTypes.Count >= 0)
			{

				SelectedTypes.Add(typeE);

			}
			else if (SelectedTypes.Count != 0 && SelectedTypes.Contains(typeE))
			{
				SelectedTypes.Remove(typeE);
			}

		}
		public async Task AddPokemonAsync()
		{
			Appstate.PokemonModel.PokemonType = GetTypes();
			await HttpService.AddPokemon(Appstate.PokemonModel);
		}
		public List<PokemonModel.PokeType> GetTypes()
		{
			var availableTypes = Enum.GetValues(typeof(PokemonModel.PokeType));
			var foundTypes = new List<PokemonModel.PokeType>();
			foreach (var typeId in SelectedTypes)
			{
				if (availableTypes.GetValue(typeId) != null)
				{
					foundTypes.Add((PokemonModel.PokeType)typeId);
				}
			}
			return foundTypes;
		}
	}
}
