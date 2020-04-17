namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for medias of a World of Warcraft achievement.
	/// </summary>
	[System.Serializable]
	public class WowAchievementMedia_JSON : Object_Json
	{
		public LinkStruct _links;

		public KeyValueStruct[] assets;
		public int id;
	}
}