namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for an index of World of Warcraft achievement categories.
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