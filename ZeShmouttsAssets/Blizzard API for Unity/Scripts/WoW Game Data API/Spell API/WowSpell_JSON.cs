namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft spell.
	/// </summary>
	[System.Serializable]
	public class WowSpell_JSON : Object_Json
	{
		public LinkStruct _links;

		public int id;
		public LocalizedString name;
		public LocalizedString description;
		public RefIdStruct media;
	}
}