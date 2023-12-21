namespace PokedexClient.Models
{
	public class HeldItemModel
	{
		public NameUrlModel Item { get; set; } = new NameUrlModel();
		public ItemDetailModel[] Version_details { get; set; } = new ItemDetailModel[0];
	}
}
