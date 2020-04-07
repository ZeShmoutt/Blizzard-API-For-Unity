namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft index of achievements.
	/// </summary>
	[System.Serializable]
	public class WowAchievementIndex_JSON : Object_Json
	{
		public LinkStruct _links;
		public RefNameIdStruct[] achievements;
	}
}