namespace PokedexClient.Models
{
	public class MovesModel
	{
		public NameUrlModel Move { get; set; } = new NameUrlModel();
		public VersionGroupModel[] Version_Group_Details { get; set; } = new VersionGroupModel[0];

	}
}
