namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft playable classes.
	/// </summary>
	[System.Serializable]
	public class WowPlayableClass_JSON : Object_Json
	{
		public LinkStruct _links;

		public int id;
		public LocalizedString name;

		public GenderName gender_name;

		public RefNameIdStruct power_type;
		public RefNameIdStruct[] specializations;

		public RefIdStruct media;
		public HRefStruct pvp_talent_slots;
	}
}