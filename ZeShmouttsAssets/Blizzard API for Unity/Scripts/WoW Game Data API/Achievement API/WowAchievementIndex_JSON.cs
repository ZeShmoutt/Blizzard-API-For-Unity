namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for an index of World of Warcraft achievements.
	/// </summary>
	[System.Serializable]
	public class WowAchievementIndex_JSON : Object_Json
	{
		public LinkStruct _links;
		public RefNameIdStruct[] achievements;
	}
}