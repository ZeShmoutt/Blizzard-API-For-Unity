namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft creatures.
	/// </summary>
	[System.Serializable]
	public class WowCreature_JSON : Object_Json
	{
		public LinkStruct _links;

		public int id;
		public LocalizedString name;
		public RefNameIdStruct type;
		public RefNameIdStruct family;
		public RefIdStruct creature_displays;
		public bool is_tameable;
	}
}