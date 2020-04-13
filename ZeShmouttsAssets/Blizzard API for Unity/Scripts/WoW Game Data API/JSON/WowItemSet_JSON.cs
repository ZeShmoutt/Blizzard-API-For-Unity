namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft item sets.
	/// </summary>
	[System.Serializable]
	public class WowItemSet_JSON : Object_Json
	{
		public LinkStruct _links;

		public int id;
		public LocalizedString name;
		public RefNameIdStruct[] items;

		[System.Serializable]
		public struct ItemSetEffect
		{
			public LocalizedString display_string;
			public int required_count;
		}
		public ItemSetEffect[] effects;

		public bool is_effect_active;
	}
}