namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft achievement categories.
	/// </summary>
	[System.Serializable]
	public class WowAchievementCategory_JSON : Object_Json
	{
		public LinkStruct _links;

		public int id;
		public LocalizedString name;
		public RefNameIdStruct[] achievements;
		public RefNameIdStruct[] subcategories;
		public bool is_guild_category;

		[System.Serializable]
		public struct PointsTotal
		{
			public int quantity;
			public int points;
		}
		[System.Serializable]
		public struct AggregatesByFaction
		{
			public PointsTotal alliance;
			public PointsTotal horde;
		}
		public AggregatesByFaction aggregates_by_faction;

		public int display_order;
	}
}