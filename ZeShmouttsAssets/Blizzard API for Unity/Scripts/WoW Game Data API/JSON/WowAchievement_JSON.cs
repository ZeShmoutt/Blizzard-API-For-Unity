namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft achievements.
	/// </summary>
	[System.Serializable]
	public class WoWAchievement_JSON : Object_Json
	{
		public LinkStruct _links;

		public int id;
		public RefNameIdStruct category;
		public LocalizedString name;
		public LocalizedString description;
		public int points;
		public bool is_account_wide;

		[System.Serializable]
		public struct CriteriaStruct
		{
			public HRefStruct key;
			public int id;
			public LocalizedString description;
			public int amount;
		}
		public CriteriaStruct criteria;
		public RefNameIdStruct next_achievement;
		public RefIdStruct media;

		public int display_order;
	}
}