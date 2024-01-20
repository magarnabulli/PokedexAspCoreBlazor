using PokedexClient.Services;

namespace PokedexClient.Pages
{
	public partial class Home
	{
		protected async override Task OnInitializedAsync()
		{
			if (Appstate.ChildContentMode != (""))
			{
				await InvokeAsync(StateHasChanged);
			}
		}
	}
}
