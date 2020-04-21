namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft realm.
	/// </summary>
	[System.Serializable]
	public class WowRealm_JSON : Object_Json
	{
		public LinkStruct _links;

		public int id;
		public RefNameIdStruct region;
		public HRefStruct connected_realm;
		public LocalizedString name;
		public LocalizedString category;
		public string locale;
		public string timezone;

		[System.Serializable]
		public struct RealmType
		{
			public string type;
			public LocalizedString name;
		}
		public RealmType type;
		public bool is_tournament;
		public string slug;
	}
}