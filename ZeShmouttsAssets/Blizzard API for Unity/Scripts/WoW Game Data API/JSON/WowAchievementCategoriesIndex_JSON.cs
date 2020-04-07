namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft index of achievement categories.
	/// </summary>
	[System.Serializable]
	public class WowAchievementCategoriesIndex_Json : Object_Json
	{
		public LinkStruct _links;

		public RefNameIdStruct[] categories;
		public RefNameIdStruct[] root_categories;
		public RefNameIdStruct[] guild_categories;
	}
}