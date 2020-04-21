namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for an index of World of Warcraft auctions.
	/// </summary>
	[System.Serializable]
	public class WowAuctions_JSON : Object_Json
	{
		public LinkStruct _links;

		public HRefStruct connected_realm;

		[System.Serializable]
		public struct AuctionItemModifier
		{
			public int type;
			public int value;
		}

		[System.Serializable]
		public struct AuctionItem
		{
			public int id;
			public int context;
			public int[] bonus_lists;
			public AuctionItemModifier[] modifiers;
			public int pet_breed_id;
			public int pet_level;
			public int pet_quality_id;
			public int pet_species_id;
		}

		[System.Serializable]
		public struct Auction
		{
			public int id;
			public AuctionItem item;
			public int buyout;
			public int quantity;
			public string time_left;
		}

		public Auction[] auctions;
	}
}