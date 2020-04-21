namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for an index of World of Warcraft playable races.
	/// </summary>
	[System.Serializable]
	public class WowPlayableRace_JSON : Object_Json
	{
		public LinkStruct _links;

		public int id;
		public LocalizedString name;
		public GenderName gender_name;
		public TypeNameStruct faction;
		public bool is_selectable;
		public bool is_allied_race;
	}
}